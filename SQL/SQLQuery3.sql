/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpId]
      ,[EmpName]
      ,[EmpLocation]
      ,[EmpSalary]
  FROM [pnimmagadda].[dbo].[Employee_Details]

  SELECT *FROM Employee_Details
  JOIN  Employee_details_extension ON Emp_Details.EmpId