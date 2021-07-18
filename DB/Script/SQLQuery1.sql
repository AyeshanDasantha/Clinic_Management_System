Create Procedure Report_Chart
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,Gender As 'Gender'
		FROM [dbo].[Patient_Reg]
		Group by Gender
	end