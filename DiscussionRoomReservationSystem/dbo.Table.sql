CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(50) NULL, 
    [roomName] VARCHAR(50) NULL, 
    [date] DATETIME NULL, 
    [startTime] DATETIME NULL, 
    [endTime] DATETIME NULL, 
    [orderStatus] VARCHAR(50) NULL
)
