CREATE TABLE [dbo].[Car]
(
	[VIN] INT NOT NULL PRIMARY KEY unique, 
    [Model] NCHAR(10) NULL, 
    [Make] NCHAR(10) NULL, 
    [Year] NCHAR(10) NULL, 
    [Type] NCHAR(10) NULL, 
    [TrimCode] INT NULL, 
    [Axels] INT NULL, 
    [Tonnage] INT NULL
)
