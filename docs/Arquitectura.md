# Justificación de Arquitectura MVC (Model-View-Controller)

¿Por qué MVC para Panel de Empleados?
La arquitectura MVC (Model-View-Controller) fue seleccionada como el patrón arquitectónico principal por las siguientes razones fundamentales:

## 1. MODELO (Model)

### Responsabilidad
El Modelo representa las entidades de negocio y la lógica de dominio de la aplicación. Contiene todas las reglas de negocio, validaciones y cálculos específicos del problema.

### ¿Qué problemas resuelve el Modelo?
| Problema | Solución con MVC |
|---|---|
| Lógica de negocio dispersa | Centralizada en Modelos |
| Validaciones inconsistentes | Validaciones dentro del Modelo |
| Dificultad para cambiar reglas | Modelos aislados de UI |
| Reutilización de cálculos | Modelos usables desde cualquier Controlador |

### 2. VISTA (View)

Responsabilidad
La Vista es responsable de presentar los datos al usuario y capturar las interacciones. NO contiene lógica de negocio, solo lógica de presentación.

- Ventajas de separar la Vista

- Cambio de UI sin afectar lógica

Puedes cambiar de WPF a MAUI sin tocar Modelos

Fácil modificar colores, layouts, animaciones

- Diseño independiente

Diseñadores UI trabajan en XAML

Desarrolladores trabajan en C#

- Testing visual

Pruebas unitarias para Vista no necesarias

Pruebas de integración más simples

### 3. CONTROLADOR (Controller)

Responsabilidad
El Controlador actúa como intermediario entre el Modelo y la Vista. Recibe eventos de la Vista, aplica lógica de aplicación (NO lógica de negocio), y actualiza el Modelo o la Vista según corresponda.

### Responsabilidades del Controlador
| ✅ Qué hace el Controlador | ❌ Qué NO hace el Controlador |
|---|---|
| Recibe eventos de UI | NO contiene reglas de negocio |
| Valida entrada de usuario | NO calcula salarios |
| Coordina entre Modelo y Vista | NO accede directamente a BD |
| Maneja errores de UI | NO formatea datos (eso es Vista) |
| Orquesta operaciones | NO persiste datos (eso es Modelo) |

- Flujo de comunicación MVC

```
┌─────────────────────────────────────────────────────────────┐
│                        MVC FLOW                             │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│   1. Usuario click botón                                    │
│          ↓                                                  │
│   ┌─────────────┐                                           │
│   │   VISTA     │ 2. Evento enviado al Controlador          │
│   │  (MainView) │─────────────────────────┐                 │
│   └─────────────┘                          ↓                │
│         ↑                           ┌─────────────┐         │
│         │                           │ CONTROLADOR │         │
│         │                           │ (Controller)│         │
│         │                           └─────────────┘         │
│         │ 5. Vista actualizada               │              │
│         │                                    │ 3. Solicita  │
│         │                                    │    datos al  │
│         │                                    │    Modelo    │
│         │                                    ↓              │
│         │                           ┌─────────────┐         │
│         └───────────────────────────│   MODELO    │         │
│                                     │  (Employee) │         │
│                                     └─────────────┘         │
│                                          │                  │
│                                          4. Retorna datos   │
│                                             procesados      │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```
