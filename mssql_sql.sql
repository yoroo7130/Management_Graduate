USE [YUHAN]
GO
/****** Object:  Table [dbo].[t_login]    Script Date: 2019-12-18 오후 2:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [varchar](30) NOT NULL,
	[userpwd] [varchar](30) NOT NULL,
 CONSTRAINT [PK_t_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_subject]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[subject] [varchar](50) NULL,
 CONSTRAINT [PK_t_subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_user_subject]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_user_subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[edunum] [int] NULL,
	[subject] [varchar](50) NULL,
 CONSTRAINT [PK_t_user_subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_userinfo]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_userinfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [varchar](30) NULL,
	[userpwd] [varchar](30) NULL,
	[edunum] [int] NULL,
	[name] [varchar](20) NULL,
	[birth] [varchar](30) NULL,
	[email] [varchar](40) NULL,
	[phone] [varchar](30) NULL,
 CONSTRAINT [PK_t_userinfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSubject]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteSubject]
	@param0 nvarchar(20)
AS
BEGIN
DELETE FROM t_user_subject WHERE edunum = @param0
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserInfo]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteUserInfo]
	@param0 nvarchar(20)
AS
	Declare @edunum INT
	Select @edunum = edunum FROM t_userinfo Where userid = @param0

	IF (@edunum != 0)
		Begin
			DELETE FROM t_userinfo WHERE userid = @param0
			DELETE FROM t_user_subject WHERE edunum = @edunum
			DELETE FROM t_login WHERE userid = @param0
		END
GO
/****** Object:  StoredProcedure [dbo].[InsertCheck]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertCheck]
@param0 nvarchar(20)
as
select * from t_login where userid = @param0
GO
/****** Object:  StoredProcedure [dbo].[InsertMember]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertMember]
@param0 varchar(20), @param1 varchar(20), @param2 nvarchar(20), @param3 varchar(20), @param4 varchar(20), @param5 varchar(20), @param6 varchar(20)
as
begin
insert into t_login values(@param0, @param1)
insert into t_userinfo values(@param0, @param1, @param2, @param3, @param4, @param5, @param6)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertSubject]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertSubject]
	@param0 nvarchar(20), @param1 nvarchar(20)
AS
BEGIN
INSERT INTO t_user_subject(edunum, subject) VALUES(@param0, @param1)
END
GO
/****** Object:  StoredProcedure [dbo].[SelectLogin]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectLogin]
	@param0 nvarchar(20)
AS
BEGIN
SELECT userpwd FROM t_login WHERE userid = @param0
END
GO
/****** Object:  StoredProcedure [dbo].[SelectMember]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SelectMember]
@param0 nvarchar(20),@param1 nvarchar(20)
as
select userid from t_userinfo where edunum = @param0 and name = @param1
GO
/****** Object:  StoredProcedure [dbo].[SelectPwd]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SelectPwd]
@param0 nvarchar(20),@param1 nvarchar(20),@param2 nvarchar(20)
as
select userpwd from t_userinfo where userid = @param0 and edunum = @param1 and name = @param2
GO
/****** Object:  StoredProcedure [dbo].[SelectSubject]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectSubject]
AS
BEGIN
SELECT subject FROM t_subject
END
GO
/****** Object:  StoredProcedure [dbo].[SelectSubjectInfo]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectSubjectInfo]
	@param0 nvarchar(20)
AS
BEGIN
SELECT subject FROM t_user_subject WHERE edunum = @param0
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserInfo]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectUserInfo]
	@param0 nvarchar(20)
AS
BEGIN
SELECT name, edunum, birth, email, phone FROM t_userinfo WHERE userid = @param0
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateMember]    Script Date: 2019-12-18 오후 2:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateMember]
	@param0 nvarchar(20), @param1 nvarchar(20), @param2 nvarchar(20), @param3 nvarchar(20)
AS
BEGIN
UPDATE t_userinfo SET birth = @param0 , email = @param1, phone = @param2 WHERE edunum = @param3
END
GO
