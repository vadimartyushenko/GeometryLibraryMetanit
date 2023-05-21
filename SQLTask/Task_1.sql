create table dbo.Product
(
	ProductId int primary key,
	ProductName nvarchar(128) not null
)

-- Заполним таблицу Product данными.
insert into dbo.Product(ProductId, ProductName) values (1, N'IntelliJ IDEA')
insert into dbo.Product(ProductId, ProductName) values (2, N'Rider')
insert into dbo.Product(ProductId, ProductName) values (3, N'dotMemory')
insert into dbo.Product(ProductId, ProductName) values (4, N'Qodana')

create table dbo.Category
(
	CategoryId int primary key,
	CategoryName nvarchar(64) not null
)

-- Заполним таблицу Category данными.
insert into dbo.Category(CategoryId, CategoryName) values(1, N'IDE')
insert into dbo.Category(CategoryId, CategoryName) values(2, N'Profiler')
insert into dbo.Category(CategoryId, CategoryName) values(3, N'Plugin')
insert into dbo.Category(CategoryId, CategoryName) values(4, N'.NET Tool')

create table dbo.ProductsCategories
(
	CategoryId int foreign key references dbo.Category(CategoryId),
	ProductId int foreign key references dbo.Product(ProductId),
	primary key(CategoryId, ProductId)
)

-- Заполним таблицу ProductsCategories данными.
insert into dbo.ProductsCategories(ProductId, CategoryId) values (1, 1)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (2, 1)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (3, 2)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (2, 4)
insert into dbo.ProductsCategories(ProductId, CategoryId) values (3, 4)

-- SQL запрос для выбора всех пар «Имя продукта – Имя категории»
select p.ProductName, c.CategoryName from dbo.ProductsCategories pc
inner join dbo.Category c on c.CategoryId = pc.CategoryId
right join  dbo.Product p on p.ProductId = pc.ProductId
