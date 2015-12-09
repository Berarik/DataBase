CREATE TABLE [dbo].[S_Vredn]
(
	[Vredn] NCHAR(1) NOT NULL PRIMARY KEY UNIQUE, 
    [D_Vredn] MONEY NOT NULL UNIQUE, 
    CONSTRAINT [VrednCheck] CHECK (Vredn>='1' and Vredn <='5')
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Категория вредности',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_Vredn',
    @level2type = N'COLUMN',
    @level2name = N'Vredn'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Надбовка за вредность',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_Vredn',
    @level2type = N'COLUMN',
    @level2name = N'D_Vredn'
GO
