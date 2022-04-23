--Select
Select ContactName Adi,CompanyName sirketAdi,City sehirAdi from Customers

Select * from Customers where City='London'
select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=18
select * from Products order by UnitPrice asc
select * from Products order by UnitPrice desc
select * from Products order by CategoryID,ProductName
select * from Products where CategoryID=1 order by UnitPrice desc
select COUNT(*) Adet from Products where CategoryID=2
select  CategoryID,COUNT(*) adet  from Products group by CategoryID
select  CategoryID,COUNT(*) adet  from Products group by CategoryID having COUNT(*)<10
select  CategoryID,COUNT(*) adet  from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice>10
--Data Transformation Object (DTO)
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID 
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID 
select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID 
inner join Orders o on  o.OrderID=od.OrderID