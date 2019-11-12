USE [eqdkp-dev]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (1, N'Main')
INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (2, N'Alt')
INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (3, N'Friends & Family')
INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (4, N'Recruit')
INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (5, N'Guest')
INSERT [dbo].[Status] ([StatusId], [Name]) VALUES (6, N'Inactive')
SET IDENTITY_INSERT [dbo].[Status] OFF
