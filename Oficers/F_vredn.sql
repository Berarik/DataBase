CREATE TABLE [dbo].[F_vredn]
(
	[Nvb] NCHAR(8) NOT NULL PRIMARY KEY, 
    [Vredn] NCHAR(1) NOT NULL, 
    CONSTRAINT [VrednFK] FOREIGN KEY ([Vredn]) REFERENCES [S_Vredn]([Vredn]), 
    CONSTRAINT [NvbFK] FOREIGN KEY ([Nvb]) REFERENCES [Officers]([Nvb])

)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Номер Военного Билета',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'F_vredn',
    @level2type = N'COLUMN',
    @level2name = N'Nvb'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Категория вредности',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'F_vredn',
    @level2type = N'COLUMN',
    @level2name = N'Vredn'