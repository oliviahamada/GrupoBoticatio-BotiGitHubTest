SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepositoriesLanguages](
	[Language] [nvarchar](255) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.RepositoriesLanguages] PRIMARY KEY CLUSTERED 
(
	[Language] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RepositoriesItemsDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.RepositoriesItemsDetails_dbo.RepositoriesLanguages_Language] FOREIGN KEY([Language])
REFERENCES [dbo].[RepositoriesLanguages] ([Language])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RepositoriesItemsDetails] CHECK CONSTRAINT [FK_dbo.RepositoriesItemsDetails_dbo.RepositoriesLanguages_Language]
GO




insert into [dbo].[RepositoriesLanguages] ([Language],[ModifiedDate])
values ('JavaScript',getdate()),('Python',getdate()),('GO',getdate()),('PHP',getdate()),('Swift',getdate())




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepositoriesItemsDetails](
	[RepositoryId] [nvarchar](128) NOT NULL,
	[Id] [int] NOT NULL,
	[Language] [nvarchar](255) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL,
	[HtmlUrl] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsPrivate] [smallint] NOT NULL,
	[StargazersCount] [int] NOT NULL,
	[Page] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.RepositoriesItemsDetails] PRIMARY KEY CLUSTERED 
(
	[RepositoryId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
