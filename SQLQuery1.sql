select * FROM categories;

DELETE FROM categories WHERE id=1;

CREATE TABLE income(
	id INT primary key identity(1,1),
	category varchar (MAX) NULL,
	item varchar(MAX) NULL,
	income float NULL,
	description TEXT NULL,
	date_income DATE NULL,
	date_insert DATE Null

);

select * from income;