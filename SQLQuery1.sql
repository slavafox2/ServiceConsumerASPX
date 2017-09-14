select 
 
 Job_id ,
 Job_nm AS [ProductInfo/@Job_nm]

 from jobs

FOR XML PATH('Job'), ROOT('Jobs')