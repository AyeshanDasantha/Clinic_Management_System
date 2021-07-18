--Patient table
create table Patient_Reg
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
wight float,
height float,
bmi varchar(10),
blood varchar(20),
Disease varchar(100),
discription varchar(MAX)

constraint pk_Patient_Reg primary key (PatientID),

)


--Disease_Reg table
create table Disease_Reg
(
DiseaseID varchar(50),
wight float,
height float,
bmi varchar(10),
blood varchar(20),
Disease varchar(100),
discription varchar(MAX)

constraint pk_Disease_Reg primary key (DiseaseID)
)

drop table Patient_Reg_and_Disease_Reg
(
PatientID varchar(50),
DiseaseID varchar(50),

constraint pk_Patient_Reg_and_Disease_Reg primary key (PatientID,DiseaseID),
constraint fk_01 Foreign key (PatientID)references Patient_Reg (PatientID),
constraint fk_02 Foreign key (DiseaseID)references Disease_Reg (DiseaseID)
)
SELECT * FROM Patient_Reg_and_Disease_Reg

SELECT Patient_Reg.PatientID, Patient_Reg.FirstName, Patient_Reg.Age
FROM Patient_Reg
INNER JOIN Disease_Reg ON Patient_Reg.DiseaseID=Disease_Reg.DiseaseID;