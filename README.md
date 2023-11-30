# Prueba Técnica WeVote

En este repositorio se encuentra la prueba técnica desarrollada para WeVote.
A continuación se detallan las instrucciones para correr el proyecto




# Getting Started

Para utilizar este repositorio por favor descargelo o clonelo a su PC

 ## Usando GitHub
 
Para comenzar con este repositorio, necesita obtener una copia localmente. Tienes tres opciones: bifurcar, clonar o descargar. La mayoría de las veces, probablemente sólo quieras descargar.


## Crear Base de Datos SQL Server

Este proyecto utiliza una base de datos SQL Server, pero no está programada para crear una desde cero. Por favor, crea una usando SQL Management Studio y llamala como más te guste

## Actualizar Connection String

En la carpeta WeVote.API  se pueden encontrar los appsettings.json. Por favor, una vez que hayas creado la base de datos actualiza la cadena de conexión. 


## Ejecutar el proyecto

El archivo de la solución se encuentra dentro de la carpeta WeVote.Client, el cual es la página web, y WeVote.Api, el cual es la api creada para ser consumida por nuestro
frontend. Ambos deben seleccionarse como proyecto de inicio.

Para hacerlo, haga clic derecho en el proyecto WeVote.Api o WeVote.Client y seleccione la opción **Configurar como proyecto de inicio predeterminado** para ambos.

Al iniciar el proyecto deberían abrirse dos proyectos un swagger con las api y el proyecto web.

En el caso de Bolivia no cuenta con un currency, por eso dara un mensaje de error.

# EXPLICACIÓN DE LOS REQUERIMIENTOS

Todos los requerimientos fueron desarrollados en su totalidad. Se tiene 3 Endpoints los cuales se encargan de realizar las operaciones directamente con el frontend. Los endopoints desarrollados consumen los endpoints
entregados en la prueba técnica.


# Registro de logs
Para registrar los logs se utilizó Serilog, los logs iran saliendo en la consola. Además que se escribiran en el archivo indicado en los appsettings