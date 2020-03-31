/****** Object:  Table [dbo].[CustomerTable]    Script Date: 12/11/2019 10:54:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
[id] [int] IDENTITY(1,1) NOT NULL,
[Name] [varchar](50) NULL,
[City] [varchar](50) NULL,
[Contact] [varchar](50) NULL,
[Country] [varchar](50) NULL,
 CONSTRAINT [PK_CustomerTable] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTable]    Script Date: 12/11/2019 10:54:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTable](
[id] [int] NOT NULL,
[VideoID] [int] NULL,
[CustomerID] [int] NULL,
[VideoDate] [varchar](50) NULL,
[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_RentalTable] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoTable]    Script Date: 12/11/2019 10:54:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoTable](
[id] [int] IDENTITY(1,1) NOT NULL,
[Name] [varchar](50) NULL,
[Ratting] [varchar](50) NULL,
[Year] [int] NULL,
[Cost] [int] NULL,
[Copies] [int] NULL,
 CONSTRAINT [PK_VideoTable] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [VideoRentalDecm] SET  READ_WRITE
GO
