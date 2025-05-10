-- Inline SQL script
EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BikeStores_44330760199'
use [master];
USE [master]
ALTER DATABASE [BikeStores_44330760199] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
USE [master]
DROP DATABASE [BikeStores_44330760199]