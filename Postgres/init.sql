CREATE USER docker_user;

CREATE DATABASE docker_db;
GRANT ALL PRIVILEGES ON DATABASE docker_db TO docker_user;

CREATE TABLE Employees {
ID int not null primary key,
FullName varchar(50) not null,
BirthDate date not null,
Job varchar(50) not null,
Hobby varchar(50) not null,
FavouritePictureLink varchar(500) not null
}


