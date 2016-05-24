CREATE TABLE [dbo].[S_udal]
(
	[Udal] NCHAR(13) NOT NULL PRIMARY KEY UNIQUE, 
    [D_udal] FLOAT NOT NULL UNIQUE, 
    CONSTRAINT [UdalCheck] CHECK (Udal = N'средняя' or Udal = N'большая' or Udal = N'очень большая')
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор Удаленности',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_udal',
    @level2type = N'COLUMN',
    @level2name = N'Udal'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Надбавка за удаленность',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_udal',
    @level2type = N'COLUMN',
    @level2name = N'D_udal'