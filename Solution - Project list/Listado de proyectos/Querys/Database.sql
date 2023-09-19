create database project_list;

use project_list;

create table proyectos
(
Id int  primary key not null AUTO_INCREMENT,
nombre_proyecto varchar (30),
nombre_cliente varchar (30),
tipo_proyecto varchar (30)
);


insert into proyectos (nombre_proyecto, nombre_cliente, tipo_proyecto)
values ("Sportline","Carla","Tienda");