set server="companymanagerdb.database.windows.net"
set database="CompanyManager"
set currentPath=%~dp0

sqlcmd -S %server% -d %database% -i drop_db.sql

sqlcmd -S %server% -d %database% -i create_db.sql

sqlcmd -S %server% -d %database% -i tables\Users.sql
sqlcmd -S %server% -d %database% -i tables\Medicament.sql

sqlcmd -S %server% -d %database% -i sp\select\employee\sp_select_employees_by_enterprise_id.sql

pause