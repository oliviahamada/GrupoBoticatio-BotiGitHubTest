using GrupoBoticario.Interfaces;
using System.Collections.Generic;
using System;
using GrupoBoticatio;
using System.Linq;
using System.Web.UI.WebControls;
using GrupoBoticatio.Context;
using GrupoBoticario.Models;
using System.Net.Http;
using System.Text.Json;

namespace GrupoBoticario.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly string order = "desc";
        private readonly string sort = "stars";
        private readonly int per_page = 100;

        protected ManagerContext Db = new ManagerContext();

        public List<RepositoriesLanguages> GetEntityList()
        {
            var data = Db
                .RepositoriesLanguages.AsQueryable().ToList();

            return data;
        }

        public List<RepositoryDetailModel> RequestRepositoriesDetail(string language, int page)
        {
            List<RepositoryDetailModel> repositoriesList = new List<RepositoryDetailModel>();

            Uri uri = new Uri("https://api.github.com/search/repositories?q=language:" + language + "&sort=" + sort + "&order=" + order + "&page=" + page + "&per_page=" + per_page);

            using (HttpClient client = new HttpClient()
            {
                BaseAddress = uri,
                DefaultRequestHeaders = {
                    { "User-Agent", "Awesome-Octocat-App" },
                    { "Accept", "application/vnd.github+json"},
                    { "X-GitHub-Api-Version", "2022-11-28"}
                }
            })
            {
                try
                {
                    JsonSerializerOptions option = new JsonSerializerOptions();

                    var response = client.GetAsync(client.BaseAddress);
                    var resultResponse = response.Result.Content.ReadAsStringAsync();

                    RepositoryDetailModel repositorydetailModel = JsonSerializer.Deserialize<RepositoryDetailModel>(resultResponse.Result);

                    if (repositorydetailModel != null)
                    {
                        repositoriesList = repositorydetailModel.repositoryItem;

                        var repositoriesItems = repositoriesList
                            .Select(x => new RepositoriesItemsDetails
                            {
                                Id = x.Id,
                                RepositoryId = x.repositoryId,
                                FullName = x.fullName,
                                IsPrivate = (short)(x.isPrivate == true ? 1 : 0),
                                StargazersCount = x.stargazersCount,
                                Language = x.language,
                                HtmlUrl = x.htmlUrl,
                                Description = x.description,
                                Page = page
                            }).ToList();

                        if (repositoriesItems.Count > 0)
                        {
                            CreateRepositoriesDetail(repositoriesItems);
                        }
                    }
                }
                catch(Exception)
                {
                    repositoriesList.Add(new RepositoryDetailModel());
                }
            }
            return repositoriesList.ToList();
        }

        public bool CreateRepositoriesDetail(List<RepositoriesItemsDetails> repositoriesItems)
        {
            foreach (RepositoriesItemsDetails row in repositoriesItems)
            {
                row.ModifiedDate = DateTime.Now;
                Db.RepositoriesItemsDetails.Add(row);
            }
            try
            {
                Db.Database.ExecuteSqlCommand("TRUNCATE TABLE [RepositoriesItemsDetails]");
                Db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
