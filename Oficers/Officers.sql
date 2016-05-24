CREATE TABLE [dbo].[Officers]
(
	[Nvb] CHAR(8) NOT NULL PRIMARY KEY , 
    [FIO] CHAR(35) NOT NULL, 
    [Birth_D] DATE NOT NULL, 
    [Stag] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [StagCheck] CHECK (Stag <= 30 and Stag >= 0), 
	CONSTRAINT [ZvanFK] FOREIGN KEY ([Zvan]) REFERENCES [S_zvan]([Zvan]), 
    CONSTRAINT [S_dolgnFK] FOREIGN KEY ([Dolgn]) REFERENCES [S_dolgn]([Dolgn]) , 

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
