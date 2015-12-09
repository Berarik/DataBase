CREATE TABLE [dbo].[F_udal]
(
	[Nvb] NCHAR(8) NOT NULL PRIMARY KEY, 
    [Udal] NCHAR(13) NOT NULL, 
    CONSTRAINT [OfficersFK] FOREIGN KEY ([Nvb]) REFERENCES [Officers]([Nvb]), 
    CONSTRAINT [S_UdalFK] FOREIGN KEY ([Udal]) REFERENCES [S_udal]([Udal])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Номер военного билета',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'F_udal',
    @level2type = N'COLUMN',
    @level2name = N'Nvb'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Категория удаленности',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'F_udal',
    @level2type = N'COLUMN',
    @level2name = N'Udal'