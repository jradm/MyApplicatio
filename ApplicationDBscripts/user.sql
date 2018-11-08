/*
   Donnerstag, 8. November 201815:33:23
   User: 
   Server: .
   Database: Application
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
EXECUTE sp_rename N'dbo.[user].username', N'Tmp_Username_2', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.[user].password', N'Tmp_Password_3', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.[user].Tmp_Username_2', N'Username', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.[user].Tmp_Password_3', N'Password', 'COLUMN' 
GO
ALTER TABLE dbo.[user] SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
