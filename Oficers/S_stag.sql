CREATE TABLE [dbo].[S_stag]
(
	[S_min] INT NOT NULL PRIMARY KEY UNIQUE, 
    [D_stag] FLOAT NOT NULL UNIQUE, 
    CONSTRAINT [StagCheckMin] CHECK (D_stag <=  25 ), 
    CONSTRAINT [S_min_Check] CHECK (S_min = 0 or S_min = 5 or S_min = 10 or S_min = 15 or S_min = 20 or S_min = 25 or S_min = 30)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Идентификатор Стажа',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_stag',
    @level2type = N'COLUMN',
    @level2name = N'S_min'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Величина надбавки',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'S_stag',
    @level2type = N'COLUMN',
    @level2name = N'D_stag'