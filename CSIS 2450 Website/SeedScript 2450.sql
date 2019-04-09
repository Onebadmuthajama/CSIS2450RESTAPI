SET IDENTITY_INSERT [Tasks] ON

INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (1, 'Task 1', 'Task 1 Description', 1, 1, 1);
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (2, 'Task 2', 'Task 2 Description', 1, 1, 1); 
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (3, 'Task 3', 'Task 3 Description', 2, 1, 1); 
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (4, 'Task 4', 'Task 4 Description', 2, 1, 1); 

INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (5, 'Task 1', 'Task 1 Description', 3, 1, 2);
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (6, 'Task 2', 'Task 2 Description', 3, 1, 2); 
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (7, 'Task 3', 'Task 3 Description', 4, 1, 2); 
INSERT INTO [Tasks] (Id, Name, Description, CategoryId, Priority, UserId)
VALUES (8, 'Task 4', 'Task 4 Description', 4, 1, 2); 

SET IDENTITY_INSERT [Tasks] OFF


SET IDENTITY_INSERT [Categories] ON

INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (1, 'Category 1', 'Category 1 Description', 1, 1);
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (2, 'Category 2', 'Category 2 Description', 1, 1); 
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (3, 'Category 3', 'Category 3 Description', 2, 1); 
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (4, 'Category 4', 'Category 4 Description', 2, 1); 

INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (5, 'Category 1', 'Category 1 Description', 1, 2);
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (6, 'Category 2', 'Category 2 Description', 1, 2); 
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (7, 'Category 3', 'Category 3 Description', 2, 2); 
INSERT INTO [Categories] (Id, Name, Description, Priority, UserId)
VALUES (8, 'Category 4', 'Category 4 Description', 2, 2); 

SET IDENTITY_INSERT [Categories] OFF


SET IDENTITY_INSERT [User] ON

INSERT INTO [User] (Id, Name, Password)
VALUES (1, 'User_1', 'password');
INSERT INTO [User] (Id, Name, Password)
VALUES (2, 'User_2', 'password');
INSERT INTO [User] (Id, Name, Password)
VALUES (3, 'User_3', 'password');
INSERT INTO [User] (Id, Name, Password)
VALUES (4, 'User_4', 'password');

SET IDENTITY_INSERT [User] OFF

select * from [tasks]
select * from [Categories]
select * from [User]