﻿use StudyManagementApp
go

CREATE TABLE TASK(
	USERNAME VARCHAR(100),
	DATETIMECREATE DATETIME,
	

	TASKNAME NVARCHAR(50),
	DATETIMEDEADLINE DATETIME,
	NOTE NVARCHAR(1000),
	DONE BIT,
	PK_COLOR NVARCHAR(100),
	DATETIMENOTI DATETIME,
	PRIMARY KEY(USERNAME,DATETIMECREATE)
)
GO

CREATE TABLE TYPEITEM(
	PK_COLOR NVARCHAR(100),
	USERNAME VARCHAR(100),
	TYPECOLOR NVARCHAR(15),
	NAMETYPE NVARCHAR(50),

	PRIMARY KEY(PK_COLOR)
)
GO

ALTER TABLE TASK ADD CONSTRAINT FK_TASK_USERNAME FOREIGN KEY (USERNAME) REFERENCES ACCOUNT(USERNAME)
GO
ALTER TABLE TASK ADD CONSTRAINT FK_TASK_PK_COLOR FOREIGN KEY (PK_COLOR) REFERENCES TYPEITEM(PK_COLOR)
GO
ALTER TABLE TYPEITEM ADD CONSTRAINT FK_TYPEITEM_USERNAME FOREIGN KEY (USERNAME) REFERENCES ACCOUNT(USERNAME)
GO

---------------------------------------------------------
--Them item cho user
CREATE PROC ADD_ITEM
	@userName NVARCHAR(100),
	@datetimeCREATE DATETIME,
	@taskNAME NVARCHAR(50),
	@datetimeDEADLINE DATETIME,
	@note NVARCHAR(1000),
	@done BIT,
	@pk_COLOR NVARCHAR(100),
	@datetimeNOTI DATETIME
AS
BEGIN
	INSERT INTO TASK VALUES (
	@userName,
	@datetimeCREATE ,
	@taskNAME ,
	@datetimeDEADLINE ,
	@note ,
	@done ,
	@pk_COLOR ,
	@datetimeNOTI )
END
GO


--Load toan bo item cua mot user
CREATE PROC LOAD_ALLITEM
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM TASK WHERE USERNAME = @userName
END
GO

--Update check item cua mot user
CREATE PROC UPDATE_CHECK
@userName NVARCHAR(100), @datetimeCreate DATETIME, @done BIT
AS
BEGIN
	UPDATE TASK
	SET DONE=@done
	WHERE USERNAME=@username AND DATETIMECREATE = @datetimeCREATE
END
GO

--Update taskname của item cua mot user
CREATE PROC UPDATE_TASKNAME
@userName NVARCHAR(100), @datetimeCreate DATETIME, @taskNAME NVARCHAR(50)
AS
BEGIN
	UPDATE TASK
	SET TASKNAME = @taskNAME
	WHERE USERNAME=@username AND DATETIMECREATE = @datetimeCREATE
END
GO

--Update note/description của item cua mot user
CREATE PROC UPDATE_DESCRIPTION
@userName NVARCHAR(100), @datetimeCreate DATETIME, @note NVARCHAR(1000)
AS
BEGIN
	UPDATE TASK
	SET NOTE = @note
	WHERE USERNAME=@username AND DATETIMECREATE = @datetimeCREATE
END
GO

--Update datetime NOTI
CREATE PROC UPDATE_DATETIMENOTI
@userName NVARCHAR(100), @datetimeCreate DATETIME, @datetimeNOTI DATETIME
AS
BEGIN
	UPDATE TASK
	SET DATETIMENOTI = @datetimeNOTI
	WHERE USERNAME=@username AND DATETIMECREATE = @datetimeCREATE
END
GO

--Delete mot item cua mot user
CREATE PROC DELETE_MOT_ITEM
@userName NVARCHAR(100), @datetimeCreate DATETIME
AS
BEGIN
	DELETE FROM TASK
	WHERE USERNAME=@username AND DATETIMECREATE = @datetimeCREATE
END
GO

----------------------------------------------------
--Them data TYPEITEM
CREATE PROC ADD_COLORITEM
	@pk_COLOR NVARCHAR(100),
	@userName NVARCHAR(100),
	@typeCOLOR NVARCHAR(15),
	@nameTYPE NVARCHAR(50)
AS
BEGIN
	INSERT INTO TYPEITEM VALUES (
	@pk_COLOR ,
	@userName,
	@typeCOLOR ,
	@nameTYPE)
END
GO

--Load tat ca mau user
CREATE PROC LOAD_ALL_COLORITEM
@userName VARCHAR(100)
AS
BEGIN
	SELECT * FROM TYPEITEM WHERE USERNAME = @userName
END
GO

CREATE PROC UPDATE_TYPEITEM
	@pk_COLOR NVARCHAR(100),
	@userName NVARCHAR(100),
	@typeCOLOR NVARCHAR(15),
	@nameTYPE NVARCHAR(50)
AS
BEGIN
	UPDATE TYPEITEM
	SET TYPECOLOR = @typeCOLOR, NAMETYPE = @nameTYPE
	WHERE PK_COLOR = @pk_COLOR AND USERNAME= @userName
END
GO

CREATE PROC DELETE_TYPEITEM
	@pk_COLOR NVARCHAR(100),
	@userName NVARCHAR(100)
AS
BEGIN
	DELETE FROM TYPEITEM
	WHERE PK_COLOR = @pk_COLOR AND USERNAME = @userName
END
GO