# Prueba T�cnica WeVote

En este repositorio se encuentra la prueba t�cnica desarrollada para WeVote.
A continuaci�n se detallan las instrucciones para correr el proyecto




# Getting Started

Para utilizar este repositorio por favor descargelo o clonelo a su PC

 ## Usando GitHub
 
Para comenzar con este repositorio, necesita obtener una copia localmente. Tienes tres opciones: bifurcar, clonar o descargar. La mayor�a de las veces, probablemente s�lo quieras descargar.


## Crear Base de Datos SQL Server

Este proyecto utiliza una base de datos SQL Server, pero no est� programada para crear una desde cero. Por favor, crea una usando SQL Management Studio y llamala como m�s te guste

## Actualizar Connection String

En la carpeta WeVote.API  se pueden encontrar los appsettings.json. Por favor, una vez que hayas creado la base de datos actualiza la cadena de conexi�n. 


## Ejecutar el proyecto

El archivo de la soluci�n se encuentra dentro de la carpeta WeVote.Client, el cual es la p�gina web, y WeVote.Api, el cual es la api creada para ser consumida por nuestro
frontend. Ambos deben seleccionarse como proyecto de inicio.

Para hacerlo, haga clic derecho en el proyecto WeVote.Api o WeVote.Client y seleccione la opci�n **Configurar como proyecto de inicio predeterminado** para ambos.

Al iniciar el proyecto deber�an abrirse dos proyectos un swagger con las api y el proyecto web.

En el caso de Bolivia no cuenta con un currency, por eso dara un mensaje de error.

# EXPLICACI�N DE LOS REQUERIMIENTOS

Todos los requerimientos fueron desarrollados en su totalidad. Se tiene 3 Endpoints los cuales se encargan de realizar las operaciones directamente con el frontend. Los endopoints desarrollados consumen los endpoints
entregados en la prueba t�cnica.


# Registro de logs
Para registrar los logs se utiliz� Serilog, los logs iran saliendo en la consola. Adem�s que se escribiran en el archivo indicado en los appsettings