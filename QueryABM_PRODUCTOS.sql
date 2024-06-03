CREATE DATABASE ABM_PRODUCTOS

USE ABM_PRODUCTOS

CREATE TABLE Productos(

IdProducto int primary key identity (1,1), 

Nombre varchar (30),

Tipo varchar (30),

Precio int,

Fecha_Vencimiento datetime

)

select * from Productos

















