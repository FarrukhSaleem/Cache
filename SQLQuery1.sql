create table tblProducts(
[id] int identity primary key,
[Name] nvarchar(50),
[Description] nvarchar(250)
)

insert into tblProducts values('Laptopts','Dell Laptopts')
insert into tblProducts values('iPhone','iPhone 4S')
insert into tblProducts values('LCD TV','Samsung LCD TV')
insert into tblProducts values('Desktop','HP Desktop Computer')


alter procedure spGetProducts
as
begin
waitfor delay '00:00:05'--hh:mm:ss
select [id],[Name],[Description] from tblProducts
end

exec spGetProducts