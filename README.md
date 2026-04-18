# tp-winform-equipo-7b
UTN - FRGP - TUP - PROGRAMACION 3 - TP1

# Consigna TP WinForm
Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio. La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.

Deberá ser un programa de escritorio que contemple la administración de artículos. Las funcionalidades que deberá tener la aplicación serán:

- Listado de artículos.
- Búsqueda de artículos por distintos criterios.
- Agregar artículos.
- Modificar artículos.
- Eliminar artículos.
- Ver detalle de un artículo.

Toda ésta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).

Los datos mínimos con los que deberá contar el artículo son los siguientes:

- Código de artículo.
- Nombre.
- Descripción.
- Marca (seleccionable de una lista desplegable).
- Categoría (seleccionable de una lista desplegable.
- Imagen.
- Precio.

El programa debe permitir administrar las Marcas y Categorías disponibles en el programa. Además, un producto podría llegar a tener una o más imágenes, sin un límite establecido. Esto debe estar contemplado en la gestión del artículo.

Etapa 1: Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.

Etapa 2: Construir la interacción con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.

## Notas:
- En la carpeta Resources se podra encontrar el schema de SQL para la base de datos, y las pautas en un html.
- Tanto el Repo como la solución del proyecto deberán estar nombrado TPWinForm_EquipoX; siendo la sintáxis de GitHub tp-winform-equipo-x y la de la solución TPWinForm_equipo-x


# Pasos para levantar la base de datos (Con Docker)
 1) Instalar Docker Desktop
 2) Ejecutar el comando en linea de comandos (cmd) para crear el contenedor que levantara la base de datos: 
	docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=programacion3!" -e "MSSQL_PID=Express" -e "TZ=America/Buenos_Aires" -p 1440:1433 --name SQLServer2025-Programacion3 --hostname SQLServer2025-Programacion3 -d mcr.microsoft.com/mssql/server:2025-latest
 3) La primera vez que se levanta base de datos hay que crear las tablas y todo lo necesario para el proyecto, ejecutando el siguiente comando (cmd):
	  1) Espero 3 minutos, y abrir CMD donde esta el proyecto o usar el comando "cd" para ir al directorio donde esta este repositorio.
	  2) Copiar y ejecutar el comando cmd:
			sqlcmd -S localhost,1440 -U sa -P "programacion3!" -C -b -i ".\Resources\CATALOGO_DB_v3.sql"	
	Debe quedar asi: ![Ejemplo Docker base de datos](.\Resources\Ejemplo-docker-base-de-datos.png)
 4) Una vez que se creo el contenedor de SQLServer y se creo la base de datos, podemos:
	- Encenderlo con el comando en cmd:	docker start SQLServer2025-Programacion3
	- Apagarlo con el comando en cmd:	docker stop SQLServer2025-Programacion3