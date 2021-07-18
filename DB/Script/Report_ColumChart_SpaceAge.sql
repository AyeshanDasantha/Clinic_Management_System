
Create Procedure Report_Chart_Age2
as
	begin
SELECT CAST(DATEDIFF(dy, DOB, GETDATE()+1)/366 AS int)As 'Age' , COUNT (PatientID) As 'Total' FROM [dbo].[Patient_Reg]
Group by DOB
	end
	
	
	
Create Procedure Report_ColumChart_SpaceAge
as
	begin
		select 
		cast( 1 + DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10 *10 as varchar)+ '-'+ cast(10+ DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10 *10 as varchar) as AgeRange
		,
		count(1) as count
		from Patient_Reg
		group by 
		DateDiff(YY,DATEADD(YY,-1,DOB),getdate())/10
    end 

		
		
