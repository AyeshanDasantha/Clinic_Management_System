create table P_BlindSource
(
PatientID varchar(50),
Saluation varchar(50),
FirstName varchar(100),
MiddleName varchar(100),
LastName varchar(100),
NIC varchar(10),
DOB varchar(50),
Age varchar(50),
Gender varchar(20),
MarriedStatus varchar(20),
Address varchar(max),
CHome int,
CMobile int,
Regdatetime varchar(50),
Weight float,
Height float,
BMI varchar(10),
Blood_Group varchar(20),
Disease varchar(100),
Discription varchar(MAX),

constraint pk_P_BlindSource primary key (PatientID)
)
