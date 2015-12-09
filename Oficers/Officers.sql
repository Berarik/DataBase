CREATE TABLE [dbo].[Officers]
(
	[Nvb] NCHAR(8) NOT NULL PRIMARY KEY, 
    [FIO] NCHAR(35) NOT NULL, 
    [Birth_D] DATE NOT NULL  , 
    [Zvan] NCHAR(13) NOT NULL DEFAULT N'Мл. лейтенант', 
    [Dolgn] NCHAR(11) NOT NULL DEFAULT N'Комвзвода  ', 
    [Stag] INT NOT NULL DEFAULT 0, 
	CONSTRAINT [Birth_D_Check] CHECK (Birth_D < N'1997-01-01'), 
    CONSTRAINT [StagCheck] CHECK (Stag <= 30 and Stag >= 0), 
	CONSTRAINT [ZvanFK] FOREIGN KEY ([Zvan]) REFERENCES [S_zvan]([Zvan]), 
    CONSTRAINT [S_dolgnFK] FOREIGN KEY ([Dolgn]) REFERENCES [S_dolgn]([Dolgn]), 
	CONSTRAINT [ZvanDolgnCheck] CHECK  ( (Zvan = N'Мл. лейтенант' AND  Dolgn =  N'Замкомроты ') or
	(Zvan = N'Лейтенант    ' and (Dolgn = N'Комвзвода  ' or Zvan = N'Ст. лейтенант' )) or
	(Zvan = N'Ст. лейтенант' and( Dolgn =  N'Комроты    '  or Dolgn = N'Комвзвода  ' or Zvan = N'Ст. лейтенант' )) or
	(Zvan = N'Капитан      ' and (Dolgn =  N'Комроты    ' or Dolgn =  N'Замкомбат  ' or Dolgn =  N'Комбат     ' )) or
	(Zvan = N'Майор        ' and ( Dolgn =  N'Комбат     ' or Dolgn =  N'Начштаполка' or Dolgn =  N'Замкомполка'  ))or 
	(Zvan = N'Подполковник ' and ( Dolgn =  N'Комбат     ' or Dolgn =  N'Замкомполка'  or Dolgn =  N'Комполка   ' or Dolgn =  N'Начштаполка')) or 
	(Zvan = N'Полковник    '  and ( Dolgn =  N'Комполка   ' or Dolgn =  N'Начштаполка')))
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Номер военного билета',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'Nvb'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Фамилия И.О.',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'FIO'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Дата рождения',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'Birth_D'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Воинское звание',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'Zvan'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Занимемая должность',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'Dolgn'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Воинский стаж',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Officers',
    @level2type = N'COLUMN',
    @level2name = N'Stag'
GO
