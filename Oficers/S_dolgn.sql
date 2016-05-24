CREATE TABLE [dbo].[S_dolgn]
(
	[Dolgn] NCHAR(11) NOT NULL UNIQUE ,
	[O_dolgn] MONEY NOT NULL UNIQUE, 
    PRIMARY KEY ([Dolgn])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Занимаемая должность',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_dolgn',
    @level2type = N'COLUMN',
    @level2name = N'Dolgn'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Должностной оклад',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_dolgn',
    @level2type = N'COLUMN',
    @level2name = N'O_dolgn'