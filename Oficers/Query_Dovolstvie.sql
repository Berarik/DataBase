SELECT	[dbo].[Officers].[Nvb] as "Номера военного билета",
		[dbo].[Officers].[FIO] as "ФИО",
		[dbo].[Officers].[Zvan] as "Звание",
		[dbo].[S_zvan].[D_zvan] as "Надбавка за звание",
		[dbo].[Officers].[Dolgn] as "Должность",
		[dbo].[S_dolgn].[O_dolgn] as "Должностной оклад" , 
		[dbo].[Officers].[Stag] as "Стаж",
		[dbo].[S_stag].[D_stag] as "Надбавка за стаж",
		[dbo].[S_udal].[Udal] as "Категория удалѐнности",
		[dbo].[S_udal].[D_udal] as "Надбавка за удалённость",
		[dbo].[S_vredn].[Vredn] as "категории вредности условий работы",
		[dbo].[S_vredn].[D_Vredn] as "Надбавка за вредность", 
		([dbo].[S_vredn].[D_Vredn]+[dbo].[S_zvan].[D_zvan]+[dbo].[S_dolgn].[O_dolgn]+[dbo].[S_udal].[D_udal])+[dbo].[S_stag].[D_stag]*([dbo].[S_vredn].[D_Vredn]+[dbo].[S_zvan].[D_zvan]+[dbo].[S_dolgn].[O_dolgn]+[dbo].[S_udal].[D_udal]) as "Довольствие"

from	[dbo].[Officers],
		[dbo].[S_zvan],
		[dbo].[S_dolgn],
		[dbo].[S_stag],
		[dbo].[S_udal],
		[dbo].[F_udal],
		[dbo].[S_vredn],
		[dbo].[F_vredn]
		
where	[dbo].[Officers].[Zvan]=[dbo].[S_zvan].[Zvan] and 
		[dbo].[S_dolgn].[Dolgn]=[dbo].[Officers].[Dolgn] and 
		([dbo].[Officers].[Stag]/5+1)*5 = [dbo].[S_stag].[S_min] and 
		([dbo].[Officers].[Nvb]=[dbo].[F_udal].[Nvb] and 
		[dbo].[F_udal].[Udal]=[dbo].[S_udal].[udal]) and 
		([dbo].[Officers].[Nvb]=[dbo].[F_vredn].[Nvb] and 
		[dbo].[F_vredn].[Vredn]=[dbo].[S_vredn].[Vredn] );