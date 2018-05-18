Create database db_elektro;

USE db_elektro;

show tables;

Create Table conceptos(
	id int(15) not null primary key auto_increment,
	palabra varchar(100),
	concepto varchar(1000),
	capitulo varchar(100),
	data_created timestamp default current_timestamp
);
