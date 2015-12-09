CREATE TABLE [dbo].[S_zvan]
(
	[Zvan] NCHAR(13) NOT NULL UNIQUE, 
	CONSTRAINT [ZvanCHeck] CHECK ( Zvan = N'Мл. лейтенант' or Zvan = N'Лейтенант    ' or Zvan = N'Ст. лейтенант' or Zvan =  N'Капитан      ' or Zvan = N'Майор        ' or Zvan = N'Подполковник ' or Zvan = N'Полковник    '), 
    [D_zvan] MONEY NOT NULL UNIQUE, 
    PRIMARY KEY ([Zvan]) 
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Воинское звание',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_zvan',
    @level2type = N'COLUMN',
    @level2name = N'Zvan'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Надбавка за воинское звание',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_zvan',
    @level2type = N'COLUMN',
    @level2name = N'D_zvan'