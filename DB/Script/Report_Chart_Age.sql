Create Procedure Report_Chart_Age
as
	begin
SELECT COUNT (PatientID) As 'Total'
			,Age As 'Age'
		FROM [dbo].[Patient_Reg]
		Group by Age
	end