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
where p.ProductName not like 'E%' -- ilk harfi E olmayanlar
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

----------------------- IN ------------------
select * from Products p where p.CategoryID = 1 or p.CategoryID = 2 or p.CategoryID = 3
go

select * from Products p where p.CategoryID in (1,2,3)
go
----------------------- NOT IN -------------------------
select * from Products p where p.CategoryID != 1 and p.CategoryID != 2 and p.CategoryID != 3
go
select * from Products p where p.CategoryID <> 1 and p.CategoryID <> 2 and p.CategoryID <> 3
go
select * from Products p where p.CategoryID not in(1,2,3)

--------------------- BETWEEN --------------------

select * from Products p where p.UnitPrice >= 20 and p.UnitPrice <= 40
go

select * from Products p where p.UnitPrice between 20 and 40

----------------------- NULL ----------------------

select * from Customers c where c.Region is null
go
select * from Customers c where c.Region is not null
go
----------- ISNULL -------------------
select * from Customers c where ISNULL(c.Region,'') = ''
go
select * from Customers c where ISNULL(c.Region,'') <> ''
go
select CompanyName,ContactName,ContactTitle,ISNULL(Region,'Veri Girilmemiş') as Region from Customers c

----------------------------------- DISTINCT ------------------------

select distinct ContactTitle from Customers
go

select distinct TitleOfCourtesy,City from Employees

---------------------------------- COUNT -------------------------------
select count(*) as CountOfCustomers from Customers


-------- UYGULAMA ----
-- Unitprice değeri 10 ile 45 arasında olup CategoryID si 1 olmayan kaç adet ürün vardır ?

select count(*) as Sonuc 
from Products p
--where p.UnitPrice between 10 and 45 and CategoryID <> 1
where p.UnitPrice >= 10 and p.UnitPrice <= 45 and CategoryID != 1

------- UYGULAMA -------
--- Employee bilgilerinden Region bilgisi boş olan (NULL) kaç adet veri vardır ?

select count(*) as Sonuc from Employees e 
--where e.Region is null
where ISNULL(e.Region,'') = ''

------------------------------- TOP -----------------------
select top 10 ProductID,ProductName from Products

------------------------------- ORDER BY ------------------

select * from Products order by ProductName
go
select * from Products order by ProductName asc 
go
select * from Products order by ProductName desc ,UnitPrice desc

--------------------- UYGULAMA ---------------
---- Özel bir metod kullanmadan Products tablosu içerisinde ki 
--en büyük fiyat değerini getiren sql komutunu yazınız.
select top 3 * from Products p order by p.UnitPrice desc
select top 1 p.UnitPrice from Products p order by p.UnitPrice desc
select top 1 * from Products p order by p.UnitPrice desc

------------------- MAX -------------------
select MAX(p.UnitPrice) as MaxUnitPrice from Products p

---- Özel bir metod kullanmadan Products tablosu içerisinde ki 
--en küçük fiyat değerini getiren sql komutunu yazınız.
select top 1 * from Products p order by p.UnitPrice asc

------------------- MIN --------------------
select MIN(p.UnitPrice) as MinUnitPrice from Products p

------------------- SUM --------------------

select sum(p.UnitPrice) as SumOfUnitPrice
from Products p

go
select sum(p.UnitPrice*p.UnitsInStock) as SumOfUnitPrice
from Products p

-------------------------- UYGULAMA -----------------------
--- Products tablosunda ki ürünlerin ortalama birim fiyatı bilgisi ?
select sum(p.UnitPrice) / count(*) as OrtalamaBirimFiyat 
from Products as p
go
select sum(p.UnitPrice*p.UnitsInStock) / count(*) as OrtalamaBirimFiyat 
from Products as p

-------------------------- AVG ----------------------------
select AVG(p.UnitPrice) as OrtalamaBirimFiyat
from Products as p

-------------------------- KURAL --------------------------
---- Order by daima sonda yer almalıdır.
select * 
from Products p
where p.CategoryID = 1
order by p.UnitPrice desc

-------------------------- GROUP BY ------------------------
----- CategoryID si 3 olan kaç tane ürün vardır ?
select '5' as CategoryId ,count(*) as ToplamUrun 
from Products p where p.CategoryID = 5
go
---- Her kategoriden kaç adet ürün vardır.
select p.CategoryID,count(*) as UrunSayisi 
from Products p
group by p.CategoryID

---- Her supplierdan kaç adet ürün vardır
select p.SupplierID,p.CategoryID,count(*) as UrunSayisi 
from Products p
group by p.SupplierID,p.CategoryID

------------------ UYGULAMA ------------------------
----- Her kategoride ki toplam ürün birim fiyat bilgisi ?
select p.CategoryID,sum(p.UnitPrice) as ToplamBirimFiyat 
from Products p
group by p.CategoryID
----- Her kategoride ki ortalama ürün birim fiyat bilgisi ?
select p.CategoryID,avg(p.UnitPrice) as OrtalamaBirimFiyat 
from Products p
group by p.CategoryID

select p.CategoryID,sum(p.UnitPrice) / count(*) as OrtalamaBirimFiyat 
from Products p
group by p.CategoryID

-------------------- Her siparişin toplam tutarı ---------
select o.OrderID, sum(o.UnitPrice*o.Quantity*(1-o.Discount)) as Tutar
from [Order Details] o
group by o.OrderID

-------------------- Her üründen toplam yapılan alışveriş miktarı -----
select o.ProductID, sum(o.Quantity) as ToplamMiktar
from [Order Details] o
group by o.ProductID

---------------------- Her siparişte kaç tane detay var ?
select o.OrderID,count(*) as DetaySayi
from [Order Details] o
group by o.OrderID


------------------------ JOIN -----------------------------
--- Inner Join
--- Left Join
--- Right Join
