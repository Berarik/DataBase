SELECT [dbo].[Officers].[Nvb],[dbo].[Officers].[FIO],[dbo].[S_udal].[D_udal] 
from [dbo].[Officers],[dbo].[F_udal],[dbo].[S_udal] 
where [dbo].[Officers].[Nvb]=[dbo].[F_udal].[Nvb] and [dbo].[F_udal].[Udal]=[dbo].[S_udal].[udal];