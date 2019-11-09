CREATE TABLE [dbo].[Character]
(
	[CharacterId] INT IDENTITY(1,1) NOT NULL,	
	[Name] NVARCHAR(50) NOT NULL,
	[ParentId] INT NULL,
	[ClassId] TINYINT NOT NULL,
	[StatusId] TINYINT NOT NULL,
	CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED ([CharacterId]),
	CONSTRAINT [FK_Class] FOREIGN KEY (ClassId)
	REFERENCES [Class](ClassId),
	CONSTRAINT [FK_Status] FOREIGN KEY (StatusId)
	REFERENCES [Status](StatusId)
)
