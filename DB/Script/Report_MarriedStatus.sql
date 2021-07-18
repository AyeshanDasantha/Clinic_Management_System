Create Procedure Report_MarriedStatus
as
	begin
		SELECT COUNT (PatientID) As 'Total'
			,MarriedStatus As 'MarriedStatus'
		FROM [dbo].[Patient_Reg]
		Group by MarriedStatus
	end
