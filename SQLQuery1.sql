

create DataBase weather_DB 
create table favoriteCitys 
(
	id int primary key identity,
	idUser varchar(100)  not null,
	idName varchar(100) not null,
	cityName varchar(100) not null,
	weatherText varchar(100)not null,
	temp varchar(100) not null
)
select * from favoriteCitys

