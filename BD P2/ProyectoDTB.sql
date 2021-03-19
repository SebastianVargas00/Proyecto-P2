create database proyecto
go

use proyecto
go

create table Categorias(
ID_Categoria int not null Primary Key,
Nombre varchar(30),
Estado varchar(30)
)

create table Productos(
ID_Producto  int not null primary key,
Nombre varchar(30),
Codigo int,
Stock int,
Fecha_vencimiento date,
Descripcion varchar(30),
/*ID_Categoria int FOREIGN KEY REFERENCES Categorias(ID_Categoria),*/
ID_Categoria int,
constraint FK_Productos_ID_Categoria foreign key (ID_Categoria) references Categorias(Id_Categoria),
Estado varchar(30)
)



create table Usuario(
id_usuario int not null PRIMARY KEY,
Usuario varchar(30) not null,
Contraseña varchar(20)not null);

INSERT INTO Usuario VALUES ('1', 'Proyecto','1234');



