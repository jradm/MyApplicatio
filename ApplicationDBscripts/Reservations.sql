/*
   Donnerstag, 8. November 201815:38:09
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
CREATE TABLE dbo.Reservations
	(
	id int NOT NULL,
	ResId varchar(50) NOT NULL,
	[From] date NOT NULL,
	[To] date NOT NULL,
	RPD int NOT NULL,
	Total int NOT NULL,
	GuestId int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Reservations ADD CONSTRAINT
	PK_Reservations PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Reservations SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
