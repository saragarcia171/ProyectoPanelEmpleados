# Manual de Usuario — Panel de Empleados

## Introducción

El sistema Panel de Empleados es una aplicación desarrollada en C# Windows Forms que permite administrar empleados de diferentes tipos de contrato dentro de una empresa.

La aplicación facilita el registro, visualización y administración de empleados, además del cálculo de salarios, bonificaciones y liquidaciones.

## Objetivo del sistema

El objetivo principal del sistema es centralizar la gestión básica del personal mediante una interfaz gráfica amigable y fácil de utilizar.

## Requisitos mínimos

Para ejecutar correctamente la aplicación se recomienda:

### Requisito	           ### Especificación
Sistema operativo	        Windows 10 o superior
Framework	                .NET 8
Memoria RAM	                4 GB mínimo
Resolución recomendada	    1366x768


## Inicio de la aplicación

Al ejecutar el programa, el usuario visualizará el panel principal del sistema.

### La interfaz contiene:

Menú lateral de navegación
Tabla de empleados registrados
Botones de administración
Formularios de registro y liquidación
Interfaz principal

La ventana principal permite visualizar todos los empleados registrados en el sistema.

## Elementos disponibles
### Elemento	               ### Función
Sidebar lateral	                  Navegación general
Tabla de empleados	              Visualiza la información registrada
Botón Agregar	                  Registrar nuevo empleado
Botón Editar	                  Modificar información
Botón Eliminar	                  Eliminar empleado
Módulo de liquidación	          Mostrar cálculos de pago

# Registro de empleados

El sistema permite registrar empleados de diferentes tipos de contrato:

Tiempo completo
Medio tiempo
Freelance

## Pasos para registrar un empleado

1. Presionar el botón:
Agregar

2. Se abrirá el formulario de registro

El usuario deberá ingresar:

Nombre del empleado
Salario
Tipo de contrato

3. Seleccionar el tipo de contrato

Opciones disponibles:

### Tipo	         ### Descripción
Tiempo Completo        	Empleado con salario fijo mensual
Medio Tiempo	        Empleado con jornada reducida
Freelance	            Empleado por prestación de servicios

4. Presionar:
Guardar

5. Resultado

El empleado aparecerá automáticamente en la tabla principal del sistema.

# Eliminación de empleados

La aplicación permite eliminar empleados registrados.

## Pasos para eliminar un empleado

1. Seleccionar una fila de la tabla

El empleado seleccionado quedará resaltado.

2. Presionar el botón:
Eliminar

3. Resultado

El empleado será removido de la tabla principal.

# Liquidación de empleados

El sistema incluye un módulo para visualizar información relacionada con:

Salario
Bonificaciones
Liquidación

## Funcionamiento de la liquidación

Dependiendo del tipo de contrato, el sistema calcula automáticamente:

### Tipo de contrato	   ### Cálculos
Tiempo completo	           Salario + bonificación + liquidación
Medio tiempo	           Salario proporcional
Freelance	               Pago por servicio


## Cálculo salarial

El sistema utiliza programación orientada a objetos para calcular automáticamente los pagos.

Cada tipo de empleado posee una lógica distinta de cálculo.

Navegación del sistema
Sidebar lateral

El menú lateral permite acceder a:

### Opción	                     ### Función
Inicio	                         Pantalla principal
Empleados	                     Gestión de empleados
Liquidaciones	                 Visualización de pagos

## Validaciones del sistema

La aplicación valida información básica antes de registrar empleados.

#### Recomendaciones
No dejar campos vacíos
Ingresar salarios numéricos válidos
Seleccionar un tipo de contrato

# Arquitectura utilizada

El sistema fue desarrollado utilizando:

Arquitectura MVC

Programación Orientada a Objetos

Principios SOLID

# Patrones de Diseño
## Patrones implementados
### Patrón	             ### Uso
Factory Method	             Creación de empleados
Repository	                 Gestión de datos
Strategy	                 Cálculo de pagos

# Tecnologías utilizadas

## Tecnología	            ## Uso
C#	                          Lógica del sistema
Windows Forms	              Interfaz gráfica
.NET 8	                      Framework principal
Git y GitHub	              Control de versiones

# Posibles errores comunes
## Problema	                                  ## Solución
La aplicación no inicia	                      Verificar instalación de .NET 8
Error al registrar empleado                   Validar datos ingresados
No aparecen empleados	                      Revisar que se haya guardado correctamente


# Recomendaciones de uso
Mantener actualizado el sistema
Registrar información válida
No modificar archivos internos del proyecto
Utilizar la aplicación desde Windows


# Soporte y contacto

En caso de dudas o problemas técnicos, contactar a los desarrolladores del proyecto:

Sara Garcia
Ayelen Coronado

# Repositorio oficial del proyecto:

GitHub Proyecto Panel de Empleados

https://github.com/saragarcia171/ProyectoPanelEmpleados.git

# Conclusión

El sistema Panel de Empleados permite administrar personal de manera sencilla, 
organizada y eficiente mediante una interfaz amigable 
y una arquitectura basada en buenas prácticas de desarrollo de software.