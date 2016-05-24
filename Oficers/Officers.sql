CREATE TABLE [dbo].[Officers]
(
	[Nvb] CHAR(8) NOT NULL PRIMARY KEY , 
    [FIO] CHAR(35) NOT NULL, 
    [Birth_D] DATE NOT NULL, 
    [Zvan] CHAR(13) NOT NULL DEFAULT N'Мл. лейтенант', 
    [Dolgn] CHAR(11) NOT NULL DEFAULT N'Комвзвода  ', 
    [Stag] INT NOT NULL DEFAULT 0, 
	CONSTRAINT [Birth_D_Check] CHECK (Birth_D < N'1997-01-01'), 
    CONSTRAINT [StagCheck] CHECK (Stag <= 30 and Stag >= 0), 
	CONSTRAINT [ZvanFK] FOREIGN KEY ([Zvan]) REFERENCES [S_zvan]([Zvan]), 
    CONSTRAINT [S_dolgnFK] FOREIGN KEY ([Dolgn]) REFERENCES [S_dolgn]([Dolgn]) , 
	CONSTRAINT [ZvanDolgnCheck] CHECK  ( 
	(Zvan = 'Мл. лейтенант' AND  Dolgn =  'Комвзвода  ') or
	(Zvan = 'Лейтенант    ' and ( Dolgn = 'Комвзвода  ' or Dolgn = 'Замкомроты ')) or
	(Zvan = 'Ст. лейтенант' and ( Dolgn = 'Комвзвода  ' or Dolgn = 'Замкомроты ' or Dolgn = 'Комроты    ' )) or
	(Zvan = 'Капитан      ' and ( Dolgn = 'Комроты    ' or Dolgn = 'Замкомбат  ' or Dolgn = 'Комбат     ' )) or
	(Zvan = 'Майор        ' and ( Dolgn = 'Комбат     ' or Dolgn = 'Замкомполка' or Dolgn = 'Начштаполка' ))or 
	(Zvan = 'Подполковник ' and ( Dolgn = 'Комбат     ' or Dolgn = 'Замкомполка' or Dolgn = 'Начштаполка' or Dolgn = N'Комполка   ')) or 
	(Zvan = 'Полковник    ' and ( Dolgn = 'Комполка   ' or Dolgn = 'Начштаполка')))
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
