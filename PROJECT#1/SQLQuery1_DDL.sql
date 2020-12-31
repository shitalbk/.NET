
Use EZPLUSPROJECT

--1  Create table CUSTOMERUSERACCOUNT
CREATE TABLE CustomerUserAccount
(
CustomerUserAccountID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
Username VarChar(20) NOT NULL UNIQUE,
UserPassword VarChar(20) NOT NULL,
Email VarChar(50) NOT NULL UNIQUE
);

--2  Create table CREDITCARD
CREATE TABLE CreditCard
(
CardNumber Int PRIMARY KEY,
OwnerName VarChar(50) NOT NULL,
MerchantName VarChar(50) NOT NULL,
ExpDate Date NOT NULL,
HouseStreetAddress VarChar(50) NOT NULL,
City VarChar(30) NOT NULL,
StateCode Char(2) NOT NULL,
ZipCode VarChar(10) NOT NULL,
Country VarChar(50) NOT NULL,
CreditLimit Decimal(9,2) NOT NULL,
ActivationStatus VarChar(15) NOT NULL
);

--3 Create table CUSTOMER
CREATE TABLE Customer
(
CustomerID INT Identity(1,1) PRIMARY KEY,
FirstName VarChar(50) NOT NULL,
LastName VarChar(50) NOT NULL,
BirthDate Date NOT NULL,
HouseStreetAddress VarChar(50) NOT NULL,
City VarChar(30) NOT NULL,
StateCode Char(2) NOT NULL,
ZipCode VarChar(10) NOT NULL,
Country VarChar(50) NOT NULL,
Phone VarChar(20) NOT NULL,
Email VarChar(50) NOT NULL UNIQUE,
DriverLicenseNumber VarChar(30) NOT NULL UNIQUE,
DriverLicenseExpDate Date NOT NULL,
CustomerUserAccountID UNIQUEIDENTIFIER NOT NULL,
CustomerType VarChar(50) NOT NULL,

CONSTRAINT fk_Customer_AccountID
FOREIGN KEY (CustomerUserAccountID)
REFERENCES CustomerUserAccount(CustomerUserAccountID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--4  Create table CUSTOMERCREDITCARD
CREATE TABLE CustomerCreditCard
(
CardNumber INT NOT NULL,
CustomerID INT NOT NULL,

CONSTRAINT fk_Creditcard_Number
FOREIGN KEY (CardNumber)
REFERENCES CreditCard(CardNumber)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_Customer_CreditCard
FOREIGN KEY (CustomerID)
REFERENCES Customer(CustomerID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--5 Create table EMPLOYEEUSERACCOUNT
CREATE TABLE EmployeeUserAccount
(
EmployeeUserAccountID Char(36) PRIMARY KEY,
Username VarChar(30) NOT NULL UNIQUE,
UserPassword VarChar(30) NOT NULL,
Email VarChar(50) NOT NULL UNIQUE,
);


--6 CREATE TABLE EMPLOYEE
CREATE TABLE Employee
(
EmployeeID INT Identity(1,1) PRIMARY KEY,
FirstName VarChar(50) NOT NULL,
LastName VarChar(50) NOT NULL,
SSNumber Char(14) NOT NULL UNIQUE,
BirthDate Date NOT NULL,
HouseStreetAddress VarChar(50) NOT NULL,
City VarChar(30) NOT NULL,
StateCode Char(2) NOT NULL,
ZipCode VarChar(10) NOT NULL,
Country VarChar(50) NOT NULL,
EmployeePhone VarChar(20) NOT NULL,
EmployeeJobTitle VarChar(60) NOT NULL,
EmployeeEmail VarChar(50) NOT NULL UNIQUE,
EmployeeUserAccountID Char(36) NOT NULL,

CONSTRAINT fk_Employee_UserAccount
FOREIGN KEY (EmployeeUserAccountID)
REFERENCES EmployeeUserAccount(EmployeeUserAccountID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--7 CREATE TABLE DISCOUNT
CREATE TABLE Discount
(
DiscountID INT Identity(1,1) PRIMARY KEY,
DiscountCode VARCHAR(20) NOT NULL UNIQUE,
DiscountCodeDesc VARCHAR(50) NOT NULL,
);


--8 CREATE TABLE VEHICLESTATUS
CREATE TABLE VehicleStatus
(
VehicleStatusID INT PRIMARY KEY,
VehicleStatusDesc VARCHAR(50) NOT NULL,
);


--9 CREATE TABLE EZPLUS
CREATE TABLE EZPlus
(
EZPlusID INT Identity PRIMARY KEY,
EZPlusRewardsCode VARCHAR(20) NOT NULL UNIQUE,
EZPlusRewardsEarnedPoints INT NOT NULL,
);


--10 CREATE TABLE COMPANY
CREATE TABLE Company
(
CompanyID INT PRIMARY KEY,
CompanyName VARCHAR(50) NOT NULL,
ContactPhone VARCHAR(20) NOT NULL,
ContactEmail VARCHAR(50) NOT NULL UNIQUE,
);


--11 CREATE TABLE VEHICLERENTALCATEGORY
CREATE TABLE VehicleRentalCategory
(
VehicleRentalCategoryID INT PRIMARY KEY,
CategoryName VARCHAR(50) NOT NULL,
CategoryDailyRentalRate Decimal(9,2) NOT NULL,
);


--12 CREATE TABLE RENTALINSURANCEOPTION
CREATE TABLE RentalInsuranceOption
(
InsuranceOptionID INT PRIMARY KEY,
InsuranceOptionDesc VARCHAR(50) NOT NULL,
InsuranceOptionAdditionalCost Decimal(8,2) NOT NULL,
);


--13 CREATE TABLE RENTALSTATUS
CREATE TABLE RentalStatus
(
RentalStatusID  INT PRIMARY KEY,
RentalStatusDesc VARCHAR(50) NOT NULL,
);


--14 CREATE TABLE FUELOPTION
CREATE TABLE FuelOption
(
FuelOptionID INT PRIMARY KEY,
FuelOptionDesc VARCHAR(50) NOT NULL,
);


--15 CREATE TABLE RENTALAGENCY
CREATE TABLE RentalAgency
(
RentalAgencyID INT PRIMARY KEY,
RentalAgencyName VARCHAR(50) NOT NULL,
HouseStreetAddress VARCHAR(50) NOT NULL,
City VARCHAR(30) NOT NULL,
StateCode Char(2) NOT NULL,
Country VARCHAR(50) NOT NULL,
ZipCode VARCHAR(10) NOT NULL,
Phone VARCHAR(20) NOT NULL,
Email VARCHAR(50) NOT NULL UNIQUE,
);


--16 CREATE TABLE RESERVATIONSTATUS
CREATE TABLE ReservationStatus
(
ReservationStatusID INT PRIMARY KEY,
ReservationStatusDesc VARCHAR(50) NOT NULL,
);


--17 CREATE TABLE CORPORATECUSTOMER
CREATE TABLE CorporateCustomer
(
CustomerID INT NOT NULL,
CompanyID INT NOT NULL,
CompanyDailyRentalRate Decimal(9,2) NOT NULL,

CONSTRAINT fk_Customer_Corporate
FOREIGN KEY (CustomerID)
REFERENCES Customer(CustomerID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_Company_Corporate
FOREIGN KEY (CompanyID)
REFERENCES Company(CompanyID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--18 CREATE TABLE RETAILCUSTOMER
CREATE TABLE RetailCustomer
(
CustomerID INT NOT NULL,
DiscountID INT NOT NULL,
EZPlusID INT NOT NULL,

CONSTRAINT fk_Customer_Retail
FOREIGN KEY (CustomerID)
REFERENCES Customer(CustomerID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_Discount_Retail
FOREIGN KEY (DiscountID)
REFERENCES Discount(DiscountID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_EZPlus_Retail
FOREIGN KEY (EZPlusID)
REFERENCES EZPlus(EZPlusID)
ON DELETE CASCADE ON UPDATE CASCADE,
);

--19 CREATE TABLE VEHICLE
CREATE TABLE Vehicle
(
VehicleID INT Identity PRIMARY KEY,
VINNumber INT NOT NULL UNIQUE,
Make VARCHAR(25) NOT NULL,
Model VARCHAR(30) NOT NULL,
YearN INT NOT NULL,
Color VARCHAR(30) NOT NULL,
LicensePlateNumber VARCHAR(30) NOT NULL,
LicensePlateState CHAR(2) NOT NULL,
Mileage INT NOT NULL,
TransmissionType VARCHAR(50) NOT NULL,
SeatCapacity INT NOT NULL,
VehicleRentalCategoryID INT NOT NULL,
VehicleStatusID INT NOT NULL,
VehicleOwningAgencyID INT NOT NULL,
VehicleCurrentLocationAgencyID INT NOT NULL,
VehicleType VARCHAR(30) NOT NULL,

CONSTRAINT fk_VehicleRental_Vehicle
FOREIGN KEY (VehicleRentalCategoryID)
REFERENCES VehicleRentalCategory(VehicleRentalCategoryID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_VehicleStatus_Vehicle
FOREIGN KEY (VehicleStatusID )
REFERENCES VehicleStatus(VehicleStatusID )
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_VehicleOwning_Vehicle
FOREIGN KEY (VehicleOwningAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_VehicleLocation_Vehicle
FOREIGN KEY (VehicleCurrentLocationAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,
);


--20 CREATE TABLE CAR
CREATE TABLE Car
(
VehicleID INT NOT NULL,
TrunkCapacity Decimal(4,1) NOT NULL,

CONSTRAINT fk_Vehicle_Car
FOREIGN KEY (VehicleID)
REFERENCES Vehicle(VehicleID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--21 CREATE TABLE SUV
CREATE TABLE Suv
(
VehicleID INT NOT NULL,
TowingCapacity INT NOT NULL,
IsAWD VARCHAR(15) NOT NULL,

CONSTRAINT fk_Vehicle_Suv
FOREIGN KEY (VehicleID)
REFERENCES Vehicle(VehicleID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--22 CREATE TABLE MINIVAN
CREATE TABLE MiniVan
(
VehicleID INT NOT NULL,
HasDisabilityOption VARCHAR(10) NOT NULL,

CONSTRAINT fk_Vehicle_MiniVan
FOREIGN KEY (VehicleID)
REFERENCES Vehicle(VehicleID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--23 CREATE TABLE CARGOVAN
CREATE TABLE CargoVan
(
VehicleID INT NOT NULL,
CargoCapacity INT NOT NULL,
MaximumPayload INT NOT NULL,

CONSTRAINT fk_Vehicle_CargoVan
FOREIGN KEY (VehicleID)
REFERENCES Vehicle(VehicleID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--24 CREATE TABLE RESERVATION
CREATE TABLE Reservation
(
ReservationID INT PRIMARY KEY,
CustomerID INT NOT NULL,
RentalAgencyID INT NOT NULL,
VehicleRentalCategoryID INT NOT NULL,
ReservationPickUpAgencyID INT NOT NULL,
ReservationDropOffAgencyID INT NOT NULL,
ReservationPickUpDate Date NOT NULL,
ReservationPickUpTime INT NOT NULL,
ReservationDropOffDate Date NOT NULL,
ReservationDropOffTime INT NOT NULL,
ReservationStatusID INT NOT NULL,

CONSTRAINT fk_Customer_Reservation
FOREIGN KEY (CustomerID)
REFERENCES Customer(CustomerID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_RentalAgencyID_Reservation
FOREIGN KEY (RentalAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_VehicleRentalCategoryID_Reservation
FOREIGN KEY (VehicleRentalCategoryID)
REFERENCES VehicleRentalCategory(VehicleRentalCategoryID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_ReservationPickUpAgencyID_Reservation
FOREIGN KEY (ReservationPickUpAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_ReservationDropOffAgencyID_Reservation
FOREIGN KEY (ReservationDropOffAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_ReservationStatusID_Reservation
FOREIGN KEY (ReservationStatusID)
REFERENCES ReservationStatus(ReservationStatusID)
ON DELETE CASCADE ON UPDATE CASCADE,
);


--25 CREATE TABLE RENTAL
CREATE TABLE Rental
(
RentalAgreementID INT PRIMARY KEY,
CustomerID INT NOT NULL,
VehicleID INT NOT NULL,
RentalAgencyID INT NOT NULL,
RentalPickUpAgencyID INT NOT NULL,
RentalDropOffAgencyID INT NOT NULL,
ReservationID INT NULL,
RentalPickUpDate Date NOT NULL,
RentalPickUpTime INT NOT NULL,
RentalDropOffDate Date NOT NULL,
RentalDropOffTime INT NOT NULL,
RentalPickUpOdometerValue INT NOT NULL,
RentalDropOffOdometerValue INT NOT NULL,
FuelOptionID INT NOT NULL,
InsuranceOptionID INT NOT NULL,
RentalStatusID INT NOT NULL,

CONSTRAINT fk_CustomerRental
FOREIGN KEY (CustomerID)
REFERENCES Customer(CustomerID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_VehicleIDRental
FOREIGN KEY (VehicleID)
REFERENCES Vehicle(VehicleID)
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_RentalAgencyIDRental
FOREIGN KEY (RentalAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_RentalPickUpAgencyIDRental
FOREIGN KEY (RentalPickUpAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_RentalDropOffAgencyIDRental
FOREIGN KEY (RentalDropOffAgencyID)
REFERENCES RentalAgency(RentalAgencyID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_ReservationIDRental
FOREIGN KEY (ReservationID)
REFERENCES Reservation(ReservationID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_RentalFuelOptionIDRental
FOREIGN KEY (FuelOptionID)
REFERENCES FuelOption(FuelOptionID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_InsuranceOptionIDRental
FOREIGN KEY (InsuranceOptionID)
REFERENCES RentalInsuranceOption(InsuranceOptionID)
ON DELETE NO ACTION ON UPDATE NO ACTION,

CONSTRAINT fk_RentalStatusIDRental
FOREIGN KEY (RentalStatusID)
REFERENCES RentalStatus(RentalStatusID)
ON DELETE NO ACTION ON UPDATE NO ACTION,
);

