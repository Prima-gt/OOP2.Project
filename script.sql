USE [oop2.p]
GO
/****** Object:  Table [dbo].[Product_Info]    Script Date: 9/11/2024 10:01:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Info](
	[ProductID] [int] NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Product_Info] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
