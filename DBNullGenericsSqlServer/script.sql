USE [TechNetData]
GO
/****** Object:  Table [dbo].[WorkingWithDbNull]    Script Date: 11/23/2019 6:10:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkingWithDbNull](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[AccountNumber] [int] NULL,
	[Dues] [decimal](18, 0) NULL,
	[RenewDate] [datetime2](7) NULL,
 CONSTRAINT [PK_WorkingWithDbNull] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[WorkingWithDbNull] ON 

INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (1, N'Ginger', N'Huang', 456, NULL, CAST(N'2019-04-07 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (2, N'Jami', NULL, 1246, CAST(742 AS Decimal(18, 0)), CAST(N'2019-03-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (3, N'Erika', N'Watts', 797, CAST(912 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (4, N'Jeffrey', NULL, 672, CAST(91 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (5, N'Tania', N'English', 422, CAST(543 AS Decimal(18, 0)), CAST(N'2019-10-16 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (6, N'Ginger', N'Cole', 1849, CAST(654 AS Decimal(18, 0)), CAST(N'2019-10-04 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (7, N'Frank', NULL, 1744, CAST(797 AS Decimal(18, 0)), CAST(N'2019-02-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (8, N'Alan', N'Hardin', 806, CAST(318 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (9, N'Norma', N'Torres', 1447, CAST(898 AS Decimal(18, 0)), CAST(N'2019-09-02 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (10, N'Claudia', NULL, 1173, CAST(844 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (11, N'Esther', N'Todd', 666, CAST(950 AS Decimal(18, 0)), CAST(N'2019-10-07 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (12, N'Alfred', NULL, 1431, CAST(62 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (13, NULL, N'Faulkner', 1198, CAST(493 AS Decimal(18, 0)), CAST(N'2019-05-27 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (14, N'Wallace', N'York', NULL, CAST(282 AS Decimal(18, 0)), CAST(N'2019-12-20 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (15, NULL, N'Aguilar', 1036, CAST(33 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (16, NULL, N'Charles', 1257, CAST(324 AS Decimal(18, 0)), CAST(N'2019-04-27 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (17, NULL, N'Petty', 1847, CAST(547 AS Decimal(18, 0)), CAST(N'2019-10-19 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (18, N'Marla', NULL, 57, CAST(439 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (19, N'Carolyn', N'Bonilla', 1236, CAST(233 AS Decimal(18, 0)), CAST(N'2019-04-11 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (20, N'Barry', N'Cuevas', 413, CAST(225 AS Decimal(18, 0)), CAST(N'2019-12-20 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (21, N'Terence', N'Rowland', 954, CAST(859 AS Decimal(18, 0)), CAST(N'2019-07-22 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (22, N'Paula', N'Wade', 682, NULL, CAST(N'2019-01-09 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (23, N'Frankie', N'Phelps', 86, CAST(467 AS Decimal(18, 0)), CAST(N'2019-03-04 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (24, N'Lara', N'Bolton', 1250, CAST(278 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (25, N'Marisa', N'Schmidt', 1091, NULL, NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (26, N'Dexter', N'Myers', 1425, NULL, CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (27, N'Joni', N'Carroll', 1396, CAST(790 AS Decimal(18, 0)), CAST(N'2019-11-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (28, N'Kim', N'Velazquez', 637, CAST(890 AS Decimal(18, 0)), CAST(N'2019-04-03 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (29, NULL, N'Rowe', 1017, CAST(807 AS Decimal(18, 0)), CAST(N'2019-03-31 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (30, N'Margaret', N'Hawkins', 138, CAST(337 AS Decimal(18, 0)), CAST(N'2019-08-08 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (31, NULL, N'Garrison', 1750, CAST(171 AS Decimal(18, 0)), CAST(N'2019-07-11 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (32, N'Kyle', N'Collins', 754, NULL, CAST(N'2019-12-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (33, N'Willie', N'Rowe', 1408, CAST(123 AS Decimal(18, 0)), CAST(N'2019-03-29 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (34, N'Valerie', N'Brandt', 125, CAST(335 AS Decimal(18, 0)), CAST(N'2019-11-27 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (35, N'Connie', N'Noble', 829, CAST(678 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (36, N'Elisa', N'Gomez', 1620, CAST(739 AS Decimal(18, 0)), CAST(N'2019-12-25 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (37, N'Sabrina', N'Johnson', 1306, CAST(964 AS Decimal(18, 0)), CAST(N'2019-01-12 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (38, NULL, N'Wang', 1951, CAST(455 AS Decimal(18, 0)), CAST(N'2019-09-29 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (39, N'Tamika', NULL, 287, NULL, NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (40, N'Jasmine', N'Walter', 1170, CAST(433 AS Decimal(18, 0)), CAST(N'2019-08-12 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (41, N'Trevor', N'Cross', 1053, CAST(157 AS Decimal(18, 0)), CAST(N'2019-06-26 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (42, NULL, N'Chan', 118, CAST(692 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (43, N'Edgar', N'Foley', 1075, CAST(803 AS Decimal(18, 0)), CAST(N'2019-02-09 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (44, N'Cathy', N'Crawford', 1192, NULL, NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (45, N'Tonia', NULL, 758, CAST(816 AS Decimal(18, 0)), CAST(N'2019-03-25 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (46, N'Bryce', N'Frank', 551, CAST(752 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (47, N'Darrick', N'Goodman', NULL, CAST(89 AS Decimal(18, 0)), NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (48, N'Toby', N'Andersen', 1975, NULL, NULL)
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (49, N'Sonja', N'Pearson', 279, CAST(817 AS Decimal(18, 0)), CAST(N'2019-11-10 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[WorkingWithDbNull] ([id], [FirstName], [LastName], [AccountNumber], [Dues], [RenewDate]) VALUES (50, N'Dwight', NULL, 1184, CAST(810 AS Decimal(18, 0)), CAST(N'2019-06-17 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[WorkingWithDbNull] OFF
