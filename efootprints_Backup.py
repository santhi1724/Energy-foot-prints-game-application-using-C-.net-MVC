import pyodbc
import csv

connection = pyodbc.connect(@"data source=RM62APOPLIN.design.iastate.edu\ALENKA;initial catalog=GameDB;integrated security=False;User Id=dbadmin;Password=EnergyGame;");
)

cursor = connection.cursor()

cursor.execute("SELECT Table_Housing.*, /n" +
 " Heat.Room_temp_Page4 as roomTempAugust, Heat.AC_status as AC_August, Heat.Window_status as Window_August, /n"+
  "Table_5.Room_temp_Heat as roomTempExtremeHeat, Table_5.AC_status_heat as AC_ExtremeHeat, Table_5.Blinds_status_heat as Blinds_ExtremeHeat, Table_5.Fan_status_heat as Fan_ExtremeHeat, Table_5.Window_status_heat as Window_ExtremeHeat,/n"+
  "dbo.Table_September.Room_temp_cold as roomTempSeptember, Table_September.Heat_status_sep, Table_September.Win_ins_status_sep, Table_September.caulk_status_sep, Table_September.duct_status_sep,/n"+
  "dbo.Table_wisdom.time, dbo.Table_wisdom.hint_counter,dbo.Table_wisdom.object_counter, dbo.Table_wisdom.score,/n"+
  "Table_Cold.Room_temp_cold, Table_Cold.Win_ins_status_cold, Table_Cold.caulk_status_cold, Table_Cold.duct_status_cold, Table_Cold.Heat_status_cold,/n"+
  "Table_9.Room_temp_bill, Table_9.caulking_status_bill, Table_9.ducts_status_bill,Table_9.heat_status_bill, Table_9.Window_status_bill as window_insulation_bill /n"+

"from Table_Housing /n" + 

"INNER JOIN Table_wisdom /n" +
    "ON Table_wisdom.User_ID = Table_Housing.User_ID /n" +
"Inner Join Heat /n"+
"    on Table_Housing.User_ID = dbo.Heat.User_ID /n" +
"Inner Join Table_5 /n"+
"    on Table_Housing.User_ID = dbo.Table_5.User_ID /n" +
"Inner Join Table_September /n"+
"    on Table_Housing.User_ID = dbo.Table_September.User_ID /n" +
"Inner Join Table_9 /n"+
"    on Table_Housing.User_ID = dbo.Table_9.User_ID /n" +
"Inner Join Table_Cold /n" +
"    on Table_Housing.User_ID = dbo.Table_Cold.User_ID /n";)

data=cursor.fetchall()

with open('dataTester.csv', 'w', newline='') as fp:
    a= csv.writer(fp, delimiter=',')
    for line in data:
        a.writerows(line)
