CREATE TABLE [dbo].[Admin] (
	[Id] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PassWord] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AdminName] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Content] (
	[Id] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserEmail] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserUrl] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserIP] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[FaceUrl] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[PicUrl] [nvarchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[AddTime] [datetime] NULL ,
	[Content] [ntext] COLLATE Chinese_PRC_CI_AS NULL ,
	[Reply] [ntext] COLLATE Chinese_PRC_CI_AS NULL ,
	[IsHid] [int] NULL ,
	[IsReply] [int] NULL ,
	[UserQQ] [nvarchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[System] (
	[Id] [int] IDENTITY (1, 1) NOT NULL ,
	[Maxletter] [int] NULL ,
	[Cutletter] [ntext] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Admin] WITH NOCHECK ADD 
	CONSTRAINT [PK_Admin] PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Content] WITH NOCHECK ADD 
	CONSTRAINT [PK_Content] PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[System] WITH NOCHECK ADD 
	CONSTRAINT [PK_System] PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

