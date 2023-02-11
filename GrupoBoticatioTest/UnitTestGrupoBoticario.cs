using GrupoBoticario.Interfaces;
using GrupoBoticario.Services;
using GrupoBoticatio;
using GrupoBoticatio.Context;
using GrupoBoticatio.Interfaces;
using Moq;

namespace GrupoBoticatioTest
{
    public class TestLoadData
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_RequestRepositoriesDetail_IsNotNull()
        {
            var mock_repository_service = new Moq.Mock<IRepositoryService>();
            var return_detail = mock_repository_service.Setup(x => x.RequestRepositoriesDetail(It.IsAny<string>(), It.IsAny<int>()));

            Assert.IsNotNull(return_detail);
        }

        [Test]
        public void Test_GetRepositoriesItem_IsNotNull()
        {
            var mock_repository_service = new Moq.Mock<IRepositoryItemService>();
            var return_detail = mock_repository_service.Setup(x => x.GetEntityList());

            Assert.IsNotNull(return_detail);
        }
    }
}