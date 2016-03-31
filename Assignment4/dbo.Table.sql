CREATE TABLE [dbo].[Car]
(
	[VIN] INT NOT NULL PRIMARY KEY unique, 
    [Model] NCHAR(10) NULL, 
    [Make] NCHAR(10) NULL, 
    [Year] INT NULL, 
    [Type] NCHAR(10) NULL, 
    [TrimCode] NCHAR(10) NULL, 
    [Axels] NCHAR(10) NULL, 
    [Tonnage] NCHAR(10) NULL
)
