/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Order_Id]
      ,[Ordered_State]
      ,[Custome_MobileNo]
  FROM [pnimmagadda].[dbo].[Order_3Table]

  ALTER TABLE Corder_details
  DROP COLUMN Item

  ALTER TABLE Corder_details
  ADD  Product_Id int;

   ALTER TABLE Product_Details1
  ADD  Product_Id int;

  UPDATE Product_Details1
  SET Product_Id=8521
  WHERE Item='ijk';

SELECT * FROM Custome_details
SELECT * FROM Corder_details
SELECT * FROM  Product_Details1
  
 SELECT Custome_details.Customer_Id,Custome_details.Customer_Name,Custome_details.Customer_MobileNo,Corder_details.Order_Id,
 Product_Details1.Product_Cost,Product_Details1.Product_Color,Product_Details1.Item,Product_Details1.Product_Id  FROM ((Corder_details
  LEFT JOIN  Custome_details  ON  Corder_details.Customer_Id = Custome_details.Customer_Id )
  LEFT JOIN   Product_Details1    ON   Corder_details .Product_Id  =   Product_Details1.Product_Id);
