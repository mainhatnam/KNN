create database ITSS02DATA
go
use ITSS02DATA
go
create table Departments(
ID varchar(50) primary key,
Name varchar(50)
)
create table Locations(
ID varchar(50) primary key,
Name varchar(50)
)
create table AssetGroups(
ID varchar(50) primary key,
Name varchar(50)
)
create table Employees(
ID varchar(50) primary key,
FirstName varchar(50),
LastName varchar(50),
Phone varchar(50),
isAdmin bit,
UserName varchar(50),
Password varchar(50)
)
create table DepartmentLocations(
ID varchar(50) primary key,
DepartmentID varchar(50),
LocationID varchar(50),
StartDate date,
EndDate date,
Foreign key (DepartmentID) references Departments(ID),
foreign key (LocationID) references Locations(ID)
)
Create table Priorities(
ID varchar(50) primary key,
Name varchar(50)
)
create table Parts(
ID varchar(50) primary key,
name varchar(50),
Effectivelife varchar(50), 
)
Create table Assets(
ID varchar(50) primary key,
AssetSN varchar(50),
AssetName varchar(50),
DepartmentLocationID varchar(50),
EmployeeID varchar(50),
AssetGroupID varchar(50),
Description varchar(50),
WattantyDate date,
foreign key (DepartmentLocationID) references DepartmentLocations(ID),
foreign key (EmployeeID) references Employees(ID),
foreign key (AssetGroupID) references AssetGroups(ID)
)
create table EmergencyMaintenances (
ID varchar(50) primary key,
AssetID varchar(50),
PriorityID varchar(50),
DescriptionEmergency varchar(50),
OtherConsiderations varchar(50),
EMReportDate date,
EMStartDate date,
EMEndDate date,
EMTechnicianNote varchar(50),
foreign key (AssetID) references Assets(ID),
foreign key (PriorityID) references Priorities(ID)
)
create table ChangedParts(
ID varchar(50) primary key,
EmergencyMaintenanceID varchar(50),
PartID varchar(50),
Amount int,
foreign key (EmergencyMaintenanceID) references EmergencyMaintenances(ID),
foreign key (PartID) references Parts(ID)
)
