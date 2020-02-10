Create Table UserTable
(
UserId int identity(1,1) Primary key ,
Passsword Varchar(50) NOT NULL,
FirstName Varchar(50) NOT NULL,
LastName Varchar(50) NOT NULL,
Dob DateTime NOT NULL,
Gender Varchar(10) NOT NULL,
EmailID Varchar(50) UNIQUE NOT NULL,
phoneNumber BigInt NOT NULL,
Role Varchar(10) NOT NULL,
)

Create Table College
(
CollegeCode Varchar(50) Primary Key ,
CollegeName Varchar(50) NOT NULL,
CollegeWebsite Varchar(50) NOT NULL,
AdmissionFee int NOT NULL,
TotalSeats int NOT NULL,
)

Insert into College Values('2342434','hatr','edfg@ijbdjg.Org',80000,45)
select * from college

Alter Procedure sp_InsertCollege
	@CollegeCode Varchar(10),
	@CollegeName varchar(50),
	@CollegeWebsite varchar(50),
	@AdmissionFee Varchar(50),
	@TotalSeats int
As
Begin
	Insert Into College (CollegeCode, CollegeName, CollegeWebsite, AdmissionFee, TotalSeats) Values (@CollegeCode, @CollegeName, @CollegeWebsite, @AdmissionFee, @TotalSeats)
End	

Create Procedure sp_DeleteCollege
	@CollegeCode VARCHAR(10)
AS
Begin
	Delete From College where collegeCode = @CollegeCode
End

Alter Procedure sp_UpdateCollege
	@AdmissionFee Varchar(50),
	@TotalSeats int,
	@CollegeCode Varchar(10)
As
Begin
	Update  College Set AdmissionFee = @AdmissionFee, TotalSeats = @TotalSeats Where CollegeCode = @CollegeCode
End

Create Procedure sp_InsertUser
	@Password Varchar(50),
    @FirstName Varchar(50),
    @SecondName Varchar(50),
    @Dob DateTime,
	@Gender Varchar(10),
    @EmailID Varchar(50),
    @PhoneNumber Varchar(10),
	@Role Varchar(10)
AS

Begin
	INSERT INTO UserTable(passsword, FirstName, LastName, Dob, Gender, EmailID, phoneNumber, Role)
			VALUES (@Password, @FirstName, @SecondName, @Dob, @Gender, @EmailID, @phoneNumber,@Role)
End

Alter Procedure sp_Login
	@EmailID varchar(50),
	@Password varchar(20)
As
Begin
	Select 'true' From UserTable where EmailId = @EmailId And Passsword = @password
End

