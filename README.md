# SQLDataAccessDemo

Database used : MS SQL Server EXPRESS
Install Dapper nuget package library.
Application is created using .Net FW 4.8
Reference link: https://www.youtube.com/watch?v=Et2khGnrIqc

Table Structure ( table name : dbo.People)

![image](https://user-images.githubusercontent.com/32676744/208697575-2641dda9-ed5c-455d-a1ff-2907c2d14862.png)



Stored procedures :
1. dbo.People_GetByLastName
```
USE [Sample]
GO
/****** Object:  StoredProcedure [dbo].[People_GetByLastName]    Script Date: 20/12/2022 15:03:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[People_GetByLastName]
	@LastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.People
	where LastName = @LastName

END

```

2. dbo.People_Insert

```
USE [Sample]
GO
/****** Object:  StoredProcedure [dbo].[People_Insert]    Script Date: 20/12/2022 15:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[People_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@PhoneNumber nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.People(FirstName,LastName,EmailAddress,PhoneNumber)
	values(@FirstName,@LastName,@EmailAddress,@PhoneNumber)

END

```
