use NORTHWND
go
---- SELECT -----
select * from Categories
go
select CategoryName,CategoryID,[Description] from Categories
go
select CategoryName KategoriAdi,CategoryID as KategoriId,[Description] Aciklama from Categories
go
select c.CategoryName,c.CategoryID,c.[Description] from Categories as c

---- WHERE -----
select * froM Products as p
go
select * froM Products as p where 1 = 1
go
select * froM Products as p where (p.UnitPrice > 20 and p.UnitPrice < 80) or p.CategoryID = 2
go
select * froM Products as p where p.UnitPrice > 20 or p.UnitPrice < 80

----- OPERATORS ------
--- <> farklý anlamýna gelir

select * from Products p where p.CategoryID <> 2
go
select * 
from Products p 
where p.CategoryID != 2

go

select *
from Products as p
where (p.UnitsInStock > 0 and p.UnitsInStock < 500) or p.ReorderLevel < 100

------- LIKE -----

select *
from Products as p
where p.ProductName like 'E%' -- ilk harfi E olanlar
go

select *
from Products as p
where p.ProductName like '%e' -- son harfi e olanlar
go

select *
from Products as p
where p.ProductName like '%e%' -- Ýçinde e harfi geçenler
go

select *
from Products as p
where p.ProductName like 'Q_e%' --- Ýlk Karakter Q 3.karakter e olanlar
go

select *
from Products as p
where p.ProductName like '%o__' -- sondan 3. harfi o olanlar
