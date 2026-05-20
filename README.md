# Proyecto Panel de Empleados

Aplicación desarrollada en C# Windows Forms para la administración de empleados con distintos tipos de contrato, permitiendo gestionar información del personal, cálculo de salarios, bonificaciones y liquidaciones mediante una interfaz gráfica amigable y una arquitectura basada en buenas prácticas de desarrollo de software.

## Descripción del proyecto

El proyecto Panel de Empleados fue desarrollado como una solución académica orientada a aplicar los conceptos trabajados durante el semestre en la asignatura de Programación Orientada a Objetos y Arquitectura de Software.

La aplicación permite administrar empleados de diferentes tipos de contratación mediante un panel visual intuitivo, implementando:

Programación Orientada a Objetos (POO)
Principios SOLID
Patrones de Diseño
Arquitectura MVC
Interfaz gráfica en Windows Forms
Control de versiones con Git y GitHub

### Objetivo del sistema

Desarrollar una aplicación de escritorio que permita gestionar empleados de distintos tipos de contrato, centralizando operaciones básicas de administración y cálculo salarial dentro de una interfaz gráfica moderna y organizada.

### Características principales
Gestión de empleados
Registro de empleados
Eliminación de empleados
Visualización de empleados registrados
Administración por tipos de contrato

## Tipos de contrato implementados

| Tipo | Características |
|---|---|
| Tiempo Completo | Salario base + bonificación |
| Medio Tiempo | Salario proporcional |
| Freelance | Prestación de servicios sin bonificación |


## Funcionalidades del sistema
| Funcionalidad | Estado |
|---|---|
| Registro de empleados	| ✅ |
| Eliminación de empleados	| ✅ |
| Interfaz gráfica	| ✅ |
| Cálculo salarial	| ✅ |
| Bonificaciones | ✅ |
| Liquidación	| ✅ |
| Arquitectura MVC	| ✅ |
| Principios SOLID | ✅ |
| Patrones de diseño | ✅ |

## Arquitectura del proyecto

El sistema fue desarrollado utilizando la arquitectura:

MVC (Modelo - Vista - Controlador)
Estructura de la arquitectura
| Capa | Responsabilidad |
|---|---|
| Presentación | Interfaz gráfica y eventos |
| Controladores | Coordinación entre UI y lógica |
| Modelos | Entidades y reglas de negocio |
| Repositorios | Gestión de almacenamiento |
| Fábricas | Creación de empleados |
| Servicios | Operaciones del sistema |

Utilizado para la creación dinámica de empleados según el tipo de contrato.

### Beneficio

Evita instanciar objetos directamente desde la interfaz gráfica.

## Repository

Utilizado para centralizar el acceso y administración de empleados.

### Beneficio

Separa la lógica de almacenamiento del resto del sistema.

## Strategy

Utilizado para implementar diferentes estrategias de cálculo salarial según el tipo de empleado.

### Beneficio

Permite extender fácilmente nuevas formas de cálculo.

## Principios SOLID aplicados
| Principio | Aplicación |
|---|---|
| SRP | Cada clase tiene una responsabilidad específica |
| OCP | Se pueden agregar nuevos contratos sin modificar lógica existente |
| LSP | Las clases hijas reemplazan correctamente a la clase base |
| ISP | Interfaces pequeñas y específicas |
| DIP | Dependencias hacia abstracciones |

## Programación Orientada a Objetos aplicada

El proyecto implementa conceptos fundamentales de POO:

Herencia
Encapsulamiento
Polimorfismo
Abstracción
Interfaces
Clases abstractas


## Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| C# | Lenguaje principal |
| .NET 8 | Framework de desarrollo |
| Windows Forms | Interfaz gráfica |
| Git | Control de versiones |
| GitHub | Repositorio remoto |

La aplicación cuenta con:

Sidebar lateral de navegación
Tabla de empleados
Formularios de registro
Diseño moderno y amigable
Botones estilizados
Colores profesionales

## Estructura del proyecto
ProyectoPanelEmpleados/
│
├── Controladores/
├── Fabricas/
├── Modelos/
├── Presentacion/
├── Repositorios/
├── Servicios/
├── Utilidades/
├── docs/
│
├── Program.cs
├── ProyectoPanelEmpleados.csproj
└── README.md

## Diagramas y documentación

Dentro de la carpeta:

docs/

se incluyen:

Diagrama de clases
Diagrama de flujo interfaz
Manual de usuario
Justificación de patrones
Mapeo de principios SOLID


## Requisitos mínimos
| Requisito |	Especificación |
|---|---|
| Sistema operativo |	Windows 10 o superior |
| Framework	| .NET 8 |
| RAM mínima | 	4 GB |
| IDE recomendado |	Visual Studio Community |


## Instalación y ejecución
### 1. Clonar repositorio
git clone https://github.com/saragarcia171/ProyectoPanelEmpleados.git
### 2. Abrir proyecto

Abrir la carpeta del proyecto en:

Visual Studio Community
### 3. Compilar
dotnet build
### 4. Ejecutar
dotnet run

## Flujo general del sistema
El usuario inicia la aplicación.
Se visualiza el dashboard principal.
Se registran empleados mediante formularios.
El sistema calcula salarios automáticamente.
Los empleados pueden eliminarse o liquidarse.

## Control de versiones

El proyecto utiliza:

Git
GitHub

para gestionar cambios y trabajo colaborativo entre integrantes.

## Historial de commits

El repositorio incluye historial de commits distribuido entre:

Sara Garcia
Ayelen Coronado

con evidencia del desarrollo progresivo del proyecto.

## Integrantes
| Nombre | Rol |
|---|---|
| Sara Garcia | Desarrollo interfaz, documentación y lógica |
| Ayelen | Implementación funcional y mejoras |

## Posibles mejoras futuras
Persistencia con base de datos SQL Server
Sistema de autenticación
Exportación a PDF o Excel
Búsqueda avanzada de empleados
Dashboard estadístico
Edición completa de empleados

## Estado del proyecto
Versión académica funcional

## Licencia

Proyecto desarrollado con fines educativos y académicos.

## Repositorio oficial

Repositorio GitHub Proyecto Panel de Empleados
https://github.com/saragarcia171/ProyectoPanelEmpleados

## Conclusión

El proyecto Panel de Empleados representa la integración práctica de conceptos de Programación Orientada a Objetos,
principios SOLID, patrones de diseño y arquitectura de software mediante una aplicación funcional desarrollada en C# Windows Forms,
demostrando buenas prácticas de desarrollo y trabajo colaborativo utilizando Git y GitHub.
