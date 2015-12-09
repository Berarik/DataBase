SELECT [dbo].[Officers].[Nvb],[dbo].[Officers].[FIO],[dbo].[S_stag].[D_stag] 
from [dbo].[Officers],[dbo].[S_stag] 
where ([dbo].[Officers].[Stag]/5+1)*5 = [dbo].[S_stag].[S_min] order by [dbo].[Officers].[Nvb];