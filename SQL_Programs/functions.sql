=========================================================================ScalarFunction(returns single variable)=====================================================================================
CREATE FUNCTION fnbal_invoice()  
RETURNS MONEY  
	BEGIN  
RETURN(SELECT SUM(invoicetotal-paymenttotal-creadittotal) FROM dbo.mcninvoices  
        WHERE invoicetotal-paymenttotal-creadittotal > 0 )  
END

print 'total balance' +convert(varchar, dbo.fnbal_invoice()  ,1)

=========================================================================ScalarFunction-Parameterized(returns single variable)=====================================================================================


CREATE FUNCTION dbo.fnven_info(@vendorid int )  
  RETURNS varchar(15)  
		BEGIN  
   		 RETURN (SELECT vendorname FROM dbo.mcnvendors WHERE vendorid=@vendorid) 
         
END


======================================
EXECTUTION:-                         =
                                     =
select * from mcnvendors             =
WHERE vendorname= dbo.fnven_info(21) =
                                     =
                                     =
select * from mcnvendors             =
WHERE vendorname= dbo.fnven_info(24) =
                                     =
select  dbo.fnven_info(22) name      =
=========================================================================Table-Valued Functions=====================================================================================
CREATE FUNCTION FN_MTABLE()  
RETURNS @mcnvendors TABLE
(  
vendorid INT, 
vendorname NVARCHAR(50),
vendorcity  NVARCHAR(50),
vendorstate  NVARCHAR(100)  
)  
AS  
BEGIN  
	INSERT INTO @mcnvendors  VALUES(1,'TEST','Test1','ap');  
RETURN  
END;
=================================
EXECUTION:-                     =
                                =
SELECT * FROM DBO.FN_MTABLE()   =
                                =
=========================================================================Table-Valued Functions(passing-Parameters)=====================================================================================
CREATE  FUNCTION dbo.abc(@vendorid INT)
RETURNS   TABLE
As
RETURN ( SELECT vendorid, vendorname,vendorcity,vendorstate from mcnvendors where vendorid= @vendorid)

===========================
EXECUTION:-               =
                          =
select * from dbo.abc(20) =
                          =
select * from mcnvendors  =
=====================================================================================Multi-Line Function=============================================================================================
create function xyz()
returns @table table(vendorid int, vendorname nvarchar(50),vendorcity nvarchar(50))
as
begin
    insert into @table
	select vendorid, vendorname,vendorcity from mcnvendors
	return
end
==============
EXECUTION:-  =
             =
EXEC xyz()   =
=====================================================================================================================================================================================================