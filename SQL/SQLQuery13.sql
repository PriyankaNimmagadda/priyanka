/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Expr1]
      ,[AutoId]
      ,[Subjects]
      ,[SubSubjects]
      ,[FacultyName]
      ,[Contact]
      ,[TotalMarks]
  FROM [pnimmagadda].[dbo].[Sub_SecondTable]

  declare @Address varchar(50)
  SET @Address='sheo'
  print @Address
  select *from SecondTable
  select *from Subjects


  select SubjectsId, FacultyName from SecondTable 
  select top(3)  SubjectsId, FacultyName from SecondTable 

 select distinct  FacultyName from SecondTable

 select AutoId,Subjects,SubSubjects 
		      from  Subjects 
			  order by Subjects desc
select SubSubjects ,Subjects
		from Subjects
		order by Subjects,AutoId desc

select TotalSubjsects=(select SubSubjects+' '+Subjects
						from Subjects s where
						s.SubjectsId=st.SubjectsId),
						TotalMarks,FacultyName,Contact
						from SecondTable st

select *from Subjects 
where SubjectsId<>200


--same id get added
select
		Subjects,
	    SUM(SubjectsId) as SubjectsId
	
		from Subjects
group by Subjects
