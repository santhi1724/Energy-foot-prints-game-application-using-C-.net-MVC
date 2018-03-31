Use GameDB
go

SELECT Table_Housing.*,
  Heat.Room_temp_Page4 as roomTempAugust, Heat.AC_status as AC_August, Heat.Window_status as Window_August,
  Table_5.Room_temp_Heat as roomTempExtremeHeat, Table_5.AC_status_heat as AC_ExtremeHeat, Table_5.Blinds_status_heat as Blinds_ExtremeHeat, Table_5.Fan_status_heat as Fan_ExtremeHeat, Table_5.Window_status_heat as Window_ExtremeHeat,
  dbo.Table_September.Room_temp_cold as roomTempSeptember, Table_September.Heat_status_sep, Table_September.Win_ins_status_sep, Table_September.caulk_status_sep, Table_September.duct_status_sep,
  dbo.Table_wisdom.time, dbo.Table_wisdom.hint_counter,dbo.Table_wisdom.object_counter, dbo.Table_wisdom.score,
  Table_Cold.Room_temp_cold, Table_Cold.Win_ins_status_cold, Table_Cold.caulk_status_cold, Table_Cold.duct_status_cold, Table_Cold.Heat_status_cold,
  Table_9.Room_temp_bill, Table_9.caulking_status_bill, Table_9.ducts_status_bill,Table_9.heat_status_bill, Table_9.Window_status_bill as window_insulation_bill

from Table_Housing

INNER JOIN Table_wisdom 
	ON Table_wisdom.User_ID = Table_Housing.User_ID 
Inner Join Heat
	on Table_Housing.User_ID = dbo.Heat.User_ID
Inner Join Table_5 
	on Table_Housing.User_ID = dbo.Table_5.User_ID
Inner Join Table_September 
	on Table_Housing.User_ID = dbo.Table_September.User_ID
Inner Join Table_9 
	on Table_Housing.User_ID = dbo.Table_9.User_ID
Inner Join Table_Cold 
	on Table_Housing.User_ID = dbo.Table_Cold.User_ID