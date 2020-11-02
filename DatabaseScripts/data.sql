SET IDENTITY_INSERT [dbo].[Task] ON
INSERT INTO [dbo].[Task] ([Id], [Title], [Assignee], [Status]) VALUES (2, N'Building Design', N'Jane', N'Done')
INSERT INTO [dbo].[Task] ([Id], [Title], [Assignee], [Status]) VALUES (3, N'Interior Design ', N'Ann', N'In Progress')
INSERT INTO [dbo].[Task] ([Id], [Title], [Assignee], [Status]) VALUES (4, N'Electrical Wiring Design ', N'Edward Wilkinson', N'In Progress')
INSERT INTO [dbo].[Task] ([Id], [Title], [Assignee], [Status]) VALUES (5, N'Security System Design', N'John Davis', N'Open')
SET IDENTITY_INSERT [dbo].[Task] OFF
