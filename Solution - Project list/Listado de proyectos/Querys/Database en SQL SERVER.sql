-- Crear la base de datos
CREATE DATABASE project_list;

-- Cambiar al contexto de la base de datos creada
USE project_list;

-- Crear la tabla proyectos
CREATE TABLE proyectos
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    nombre_proyecto VARCHAR(30),
    nombre_cliente VARCHAR(30),
    tipo_proyecto VARCHAR(30)
);



use project_list;
-- Insertar un registro en la tabla proyectos
INSERT INTO proyectos (nombre_proyecto, nombre_cliente, tipo_proyecto, fecha_creacion, estado)
VALUES ('Residendial Miriam', 'Kenny', 'Casa', '2022-3-23', 1);

use project_list;

ALTER TABLE proyectos
ADD fecha_creacion DATE;

use project_list;
ALTER TABLE proyectos
ADD CONSTRAINT DF_proyectos_fecha_creacion DEFAULT GETDATE() FOR fecha_creacion;


use project_list;


DELETE FROM proyectos
WHERE Id = 2;


select * from proyectos;

use project_list;
 ALTER TABLE proyectos
ADD estado BIT DEFAULT 0; 

