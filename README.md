# TaskAPI Backend

TaskAPI es una API RESTful desarrollada con .NET Core 6.0 para gestionar tareas.

## **Características**

- **CRUD** de tareas.
- Autogeneración de documentos de API con Swagger.
- Conexión a una base de datos SQL Server o LocalDB.

## **Requisitos Previos**

- [.NET Core 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) o LocalDB (incluido en Visual Studio)

## **Configuración**

### **1. Clonar el Repositorio**

Clona el repositorio en tu máquina local:

```bash
git clone https://github.com/AlbertoVasquezR/taskapi-backend.git
cd taskapi-backend
```

### **2. Configurar la Base de Datos**
El archivo appsettings.json está configurado para utilizar LocalDB por defecto:

<pre><code>
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskDB;Trusted_Connection=True;"
    },
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
    "AllowedHosts": "*"
  }
</code></pre>

Si prefieres usar SQL Server, actualiza la cadena de conexión en appsettings.json con los detalles de tu servidor.

### **3. Crear la Base de Datos**
Navega a la carpeta del proyecto y ejecuta las migraciones para crear la base de datos:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
### **4. Ejecutar la API**
Para iniciar la API, ejecuta el siguiente comando:
```bash
dotnet run
```
La API estará disponible en https://localhost:7078 y http://localhost:5022. Puedes acceder a la documentación de la API en https://localhost:7078/swagger.

## **Ejemplos de Peticiones a la API**

### **1. Obtener Todas las Tareas**
```bash
GET /api/tasks
```
Respuesta:
<pre><code>
  [
  {
    "id": "guid",
    "title": "Titulo de la tarea",
    "description": "Descripción de la tarea",
    "isCompleted": false,
    "createdAt": "2023-01-01T00:00:00Z"
  }
]
</code></pre>

### **2. Crear una Nueva Tarea**
```bash
POST /api/tasks
```
Cuerpo de la Solicitud:
<pre><code>
  {
  "title": "Nueva tarea",
  "description": "Descripción de la nueva tarea",
  "isCompleted": false
  }
</code></pre>
Respuesta:
<pre><code>
  {
  "id": "guid",
  "title": "Nueva tarea",
  "description": "Descripción de la nueva tarea",
  "isCompleted": false,
  "createdAt": "2023-01-01T00:00:00Z"
  }
</code></pre>

### **3. Actualizar una Tarea**
```bash
PUT /api/tasks/{id}
```
Cuerpo de la Solicitud:
<pre><code>
  {
  "id": "guid",
  "title": "Tarea actualizada",
  "description": "Descripción actualizada",
  "isCompleted": true,
  "createdAt": "2023-01-01T00:00:00Z"
  }
</code></pre>

### **4. Eliminar una Tarea**
```bash
DELETE /api/tasks/{id}
```
