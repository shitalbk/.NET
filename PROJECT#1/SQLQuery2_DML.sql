
--INSERT VALUES INTO CREDITCARD TABLE
INSERT INTO CreditCard(CardNumber,OwnerName,MerchantName,ExpDate,HouseStreetAddress,City,StateCode,ZipCode,Country,CreditLimit,ActivationStatus)
VALUES('111111111','Shital','EXPLUS','09/09/1990','11 Caryy ST','Woodhaven','NY','33453','Nepal','25000','True');

INSERT INTO CreditCard(CardNumber,OwnerName,MerchantName,ExpDate,HouseStreetAddress,City,StateCode,ZipCode,Country,CreditLimit,ActivationStatus)
VALUES('111111112','Garry','MARTIN','04/09/2000','City ST','Bronx','SF','33422','Japan','2000','True');

INSERT INTO CreditCard(CardNumber,OwnerName,MerchantName,ExpDate,HouseStreetAddress,City,StateCode,ZipCode,Country,CreditLimit,ActivationStatus)
VALUES('111111113','Darry','BONNY','01/02/2002','Molly ST','Queens','NY','10003','Singapore','5000','False');

INSERT INTO CreditCard(CardNumber,OwnerName,MerchantName,ExpDate,HouseStreetAddress,City,StateCode,ZipCode,Country,CreditLimit,ActivationStatus)
VALUES('111111114','Prince','RENTAL','03/07/2010','Dog ST','Staten Island','NY','90003','Australia','5000','True');

INSERT INTO CreditCard(CardNumber,OwnerName,MerchantName,ExpDate,HouseStreetAddress,City,StateCode,ZipCode,Country,CreditLimit,ActivationStatus)
VALUES('111111115','Joey','DOGJE','07/07/1999','11 Cat ST','Woodhaven','NY','33453','Italy','1000','False');


--INSERT VALUES INTO EMPLOYEEUSERACCOUNT TABLE
INSERT INTO EmployeeUserAccount(EmployeeUserAccountID,Username,UserPassword,Email)
VALUES('33','WENDY','HASHCODE','wendy_hash@gmail.com');

INSERT INTO EmployeeUserAccount(EmployeeUserAccountID,Username,UserPassword,Email)
VALUES('34','WHITNEY','HEELO','whitney_hash@gmail.com');

INSERT INTO EmployeeUserAccount(EmployeeUserAccountID,Username,UserPassword,Email)
VALUES('35','BARRY','WORLD','barry_hash@gmail.com');

INSERT INTO EmployeeUserAccount(EmployeeUserAccountID,Username,UserPassword,Email)
VALUES('36','RONIE','CARROT','ronie_hash@gmail.com');

INSERT INTO EmployeeUserAccount(EmployeeUserAccountID,Username,UserPassword,Email)
VALUES('37','PETTY','FUNKY','petty_hash@gmail.com');




--Insert Query to insert new record to Employee Table
INSERT INTO Employee(FirstName,LastName,SSNumber,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,EmployeePhone,EmployeeJobTitle,EmployeeEmail,EmployeeUserAccountID)
VALUES('Harry','Smith','224567890','01/01/1971','111 Carry ST','WoodHaven','NY','11234','United States','987234567','Painter','harry_smith@gmail.com','33');

INSERT INTO Employee(FirstName,LastName,SSNumber,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,EmployeePhone,EmployeeJobTitle,EmployeeEmail,EmployeeUserAccountID)
VALUES('Jack','Flown','224234567','07/02/1971','Mulberry ST','Queens','SF','11000','United States','9851079283','Tester','jack_flown@gmail.com','34');

INSERT INTO Employee(FirstName,LastName,SSNumber,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,EmployeePhone,EmployeeJobTitle,EmployeeEmail,EmployeeUserAccountID)
VALUES('Laxmi','Dangol','289768978','10/10/1972','Grand ST','Bronx','BA','11190','United States','9849363170','Accountant','dangol_laxmi@gmail.com','35');

INSERT INTO Employee(FirstName,LastName,SSNumber,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,EmployeePhone,EmployeeJobTitle,EmployeeEmail,EmployeeUserAccountID)
VALUES('Pretty','Zaphar','9807645653','07/11/1871','Grand Central ST','Manhattan','NY','12890','United States','9843279283','Singer','pretey_zack@gmail.com','36');

INSERT INTO Employee(FirstName,LastName,SSNumber,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,EmployeePhone,EmployeeJobTitle,EmployeeEmail,EmployeeUserAccountID)
VALUES('Astha','Maskey','9908234135','12/02/1978','Boulevard ST','Queens','NY','11223','United States','9821567890','Auditer','astha_maskey@gmail.com','37');


--INSERT QUERY INTO CUSTOMERUSERACCOUNT TABLE

INSERT INTO CustomerUserAccount(Username,UserPassword,Email)
VALUES('Bikky','TukTuk','biktuk_tuk@yahoo.com');

INSERT INTO CustomerUserAccount(Username,UserPassword,Email)
VALUES('Aunty','Ganjo','aunty_ganjo@yahoo.com');

INSERT INTO CustomerUserAccount(Username,UserPassword,Email)
VALUES('Simmy','Dragon','dragon_simmy@yahoo.com');

INSERT INTO CustomerUserAccount(Username,UserPassword,Email)
VALUES('Multi','Tasking','tasking_multi@yahoo.com');

INSERT INTO CustomerUserAccount(Username,UserPassword,Email)
VALUES('Red','Berry','berry_red@aol.com');



--INSERT QUERY INTO CUSTOMER TABLE

INSERT INTO Customer(FirstName,LastName,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,Phone,Email,DriverLicenseNumber,DriverLicenseExpDate,
CustomerUserAccountID,CustomerType)
VALUES('Humain','Chapper','10/10/2000','Henry ST','Brooklyn','NY','11900','United States','9349087980','humain_chapper@hotmail.com','980009','02/01/2034',
'B107FEDE-CD5A-4736-B78B-0BD86EB353F7','Regular');

INSERT INTO Customer(FirstName,LastName,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,Phone,Email,DriverLicenseNumber,DriverLicenseExpDate,
CustomerUserAccountID,CustomerType)
VALUES('Jacky','Decosta','04/02/2003','123 Whitney ST','Manhattan','NY','11001','United States','2123458765','jacky_decosta@hotmail.com','120987','04/09/2024',
'FF5757DA-CE3B-443C-99D3-340BD2716E12','Buyers');

INSERT INTO Customer(FirstName,LastName,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,Phone,Email,DriverLicenseNumber,DriverLicenseExpDate,
CustomerUserAccountID,CustomerType)
VALUES('Maiden','Denver','1/1/2001','34 Washington ST','Canada','OH','12345','United States','9870090233','maiden_denver@hotmail.com','980011','02/01/2022',
'70BF1710-5B5E-4901-96C5-64114982EEF9','Regular');

INSERT INTO Customer(FirstName,LastName,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,Phone,Email,DriverLicenseNumber,DriverLicenseExpDate,
CustomerUserAccountID,CustomerType)
VALUES('Dainton','Hons','10/10/2000','Henry ST','Brooklyn','NY','11900','United States','9349087980','dainton_hons@yahoo.com','912009','07/11/2024',
'D1862F47-AB98-4B4D-985F-BAA26668EEBB','Buyers');

INSERT INTO Customer(FirstName,LastName,BirthDate,HouseStreetAddress,City,StateCode,ZipCode,Country,Phone,Email,DriverLicenseNumber,DriverLicenseExpDate,
CustomerUserAccountID,CustomerType)
VALUES('Pinto','Joneer','01/12/2003','Penssy ST','Queens','NY','11901','United States','9349087777','pinto_jonner@hotmail.com','123578','02/01/2022',
'D5826BE8-130E-4D98-B47C-FE7FC775A586','Regular');

--INSERT QUERY INTO COMPANY TABLE
INSERT INTO Company(CompanyID,CompanyName,ContactPhone,ContactEmail)
VALUES('23','EY','304989909','ernest_young@gmail.com');

INSERT INTO Company(CompanyID,CompanyName,ContactPhone,ContactEmail)
VALUES('24','Accenture','987098768','accenture@gmail.com');

INSERT INTO Company(CompanyID,CompanyName,ContactPhone,ContactEmail)
VALUES('25','Microsoft','987023456','microsoft123@gmail.com');

INSERT INTO Company(CompanyID,CompanyName,ContactPhone,ContactEmail)
VALUES('26','Google','6067892345','google_shot@gmail.com');

INSERT INTO Company(CompanyID,CompanyName,ContactPhone,ContactEmail)
VALUES('27','Amazon','2345678912','amazon_web@gmail.com');



--INSERT QUERY INTO CORPORATECUSTOMER TABLE
INSERT INTO CorporateCustomer(CustomerID,CompanyID,CompanyDailyRentalRate)
VALUES('1','23','80.00');

INSERT INTO CorporateCustomer(CustomerID,CompanyID,CompanyDailyRentalRate)
VALUES('3','24','800.00');

INSERT INTO CorporateCustomer(CustomerID,CompanyID,CompanyDailyRentalRate)
VALUES('4','25','23.50');

INSERT INTO CorporateCustomer(CustomerID,CompanyID,CompanyDailyRentalRate)
VALUES('5','26','50.30');

INSERT INTO CorporateCustomer(CustomerID,CompanyID,CompanyDailyRentalRate)
VALUES('6','27','33.88');



--SELECT STATEMENT #1 FOR CUSTOMER TABLE

select * from Customer
where CustomerID = '5';

--SELECT STATEMENT #2 FOR CUSTOMER TABLE
select * from Customer;


--select* from Customer;
--select * from CorporateCustomer;
--select * from Company;

--SELECT STATEMENT #3 FOR CORPORATECUSTOMER TABLE
select a.CustomerID,a.FirstName,a.LastName,a.CustomerType,b.CompanyID,b.CompanyDailyRentalRate,c.CompanyName,c.ContactPhone
from Customer a,CorporateCustomer b, Company c
where a.CustomerID = b.CustomerID
AND b.CompanyID  = c.CompanyID;

--UPDATE STATEMENTS
--Update query to update all columns of one record
UPDATE Customer
SET FirstName='Joe',
	LastName='Smith',
	BirthDate='06/07/1990',
	HouseStreetAddress='134 Manhattan Street',
	City='Manhattan',
	StateCode='NY',
	ZipCode='11234',
	Country='US',
	Phone='9809767892',
	Email='joe_smith@hotmail.com',
	DriverLicenseNumber='878909',
	DriverLicenseExpDate='11/12/2001',
	CustomerType='Buyer'
WHERE CustomerID='1';

--Update query to update all columns of one record
UPDATE Customer
SET LastName='Stewart',
	CustomerType='Buyer'
WHERE CustomerID='4';

select * from Customer where CustomerID = '4';

--DELETE STATEMENTS

--DELETE QUERY 1
DELETE
FROM CreditCard
WHERE OwnerName = 'Shital';SELECT * FROM CreditCard;--DELETE QUERY 2DELETE FROM CustomerWHERE CustomerID = '1';SELECT * FROM Customer;
