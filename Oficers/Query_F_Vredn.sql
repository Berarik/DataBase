SELECT [dbo].[Officers].[Nvb],[dbo].[Officers].[FIO],[dbo].[S_vredn].[D_Vredn]  
FROM [dbo].[Officers],[dbo].[F_vredn],[dbo].[S_vredn]  
where [dbo].[Officers].[Nvb]=[dbo].[F_vredn].[Nvb] and [dbo].[F_vredn].[Vredn]=[dbo].[S_vredn].[Vredn] ;