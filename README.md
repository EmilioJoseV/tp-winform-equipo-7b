# tp-winform-equipo-7b
UTN - FRGP - TUP - PROGRAMACION 3 - TP1

# Consigna TP WinForm

Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio.  
La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc.  
Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.

---

## Requisitos generales

Deberá ser un programa de escritorio que contemple la administración de artículos.

### Funcionalidades requeridas:
- Listado de artículos.
- Búsqueda de artículos por distintos criterios.
- Agregar artículos.
- Modificar artículos.
- Eliminar artículos.
- Ver detalle de un artículo.

---

## Persistencia

Toda esta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).

---

##  Datos del artículo

Los datos mínimos con los que deberá contar el artículo son los siguientes:

- Código de artículo.
- Nombre.
- Descripción.
- Marca (seleccionable de una lista desplegable).
- Categoría (seleccionable de una lista desplegable).
- Imagen.
- Precio.

---

##  Consideraciones adicionales

El programa debe permitir administrar las Marcas y Categorías disponibles en el programa.

Además, un producto podrá tener:
- Una o más imágenes
- Sin un límite establecido

Esto debe estar contemplado en la gestión del artículo.

---

## Etapas del trabajo

### Etapa 1
Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.

### Etapa 2
Construir la interacción con la base de datos y las validaciones correspondientes para dar vida a la funcionalidad.