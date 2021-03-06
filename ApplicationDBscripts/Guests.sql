/*
   Donnerstag, 8. November 201815:43:48
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
CREATE TABLE dbo.Guests
	(
	id int NOT NULL,
	Name nchar(10) NOT NULL,
	FirstName nchar(10) NULL,
	GuestId int NOT NULL,
	Street nchar(10) NULL,
	No nchar(10) NULL,
	Lang nchar(10) NULL,
	Country nchar(10) NULL,
	PLZ nchar(10) NULL,
	City nchar(10) NULL,
	Tel int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Guests ADD CONSTRAINT
	PK_Guests PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Guests SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
