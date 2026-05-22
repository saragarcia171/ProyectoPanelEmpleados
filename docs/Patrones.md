# Justificación de Patrones de Diseño

## 1. FACTORY METHOD PATTERN (Patrón de Método Fábrica)

### Definición
El patrón Factory Method define una interfaz para crear un objeto, pero permite que las subclases decidan qué clase instanciar. El método fábrica delega la instanciación a las subclases.

### Problema que resuelve
En Panel de empleados, necesitamos crear diferentes tipos de empleados:

```
┌─────────────────────────────────────────────────────────────┐
│                   FACTORY METHOD STRUCTURE                  │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│   ┌─────────────────┐                                       │
│   │ EmpleadoFactory │ ← Productor (Factory)                 │
│   │ (Static Class)  │                                       │
│   └────────┬────────┘                                       │
│            │                                                │
│            │ CreateEmployee(type)                           │
│            ↓                                                │
│   ┌─────────────────┐                                       │
│   │    Empleado     │ ← Producto abstracto                  │
│   │  (Abstract)     │                                       │
│   └────────┬────────┘                                       │
│            │                                                │
│     ┌──────┼──────┬──────────────┐                          │
│     ↓      ↓      ↓              ↓                          │
│ ┌──────┐ ┌──────┐ ┌──────── ┐ ┌────────┐                    │
│ │Tiempo| │Medio │ |Freelance│ │ Intern │ (Extensible)       │
│ |Completo│Tiempo│ │         │ │ (Nuevo)│                    │
│ └──────┘ └──────┘ └──────── ┘ └────────┘                    │
│                                                             │
└─────────────────────────────────────────────────────────────┘
```
## 2. REPOSITORY PATTERN (Patrón de Repositorio)

### Definición
El patrón Repository media entre el dominio y las capas de mapeo de datos, actuando como una colección en memoria de objetos de dominio. Aísla la lógica de negocio de los detalles de persistencia.

### Problema que resuelve

❌ Alto acoplamiento - Lógica de datos mezclada con lógica de UI/negocio

❌ Dificultad para cambiar fuente de datos - Memoria → SQL → API requiere reescribir todo

❌ Testing complejo - Cada prueba necesita reinicializar la lista

❌ Código duplicado - Búsquedas, filtros, ordenamiento repetidos

```
┌─────────────────────────────────────────────────────────────┐
│                   REPOSITORY STRUCTURE                      │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│   ┌─────────────────┐                                       │
│   │ MainController  │ ← Cliente (UI/Business)               │
│   └────────┬────────┘                                       │
│            │                                                │
│            │ Depende de                                     │
│            ↓                                                │
│   ┌─────────────────────────┐                               │
│   │ IEmpleadoRepository     │ ← Abstracción (Interfaz)      │
│   │ +Add()                  │                               │
│   │ +GetById()              │                               │
│   │ +GetAll()               │                               │
│   └────────────┬────────────┘                               │
│                │                                            │
│         ┌──────┼──────┬──────────────┐                      │
│         ↓      ↓      ↓              ↓                      │
│   ┌─────────┐ ┌─────────┐ ┌─────────┐ ┌─────────┐           │
│   │In-Memory│ │ SQL     │ │ WebAPI  │ │ File    │           │
│   │Repo     │ │ Server  │ │ Client  │ │ System  │           │
│   └─────────┘ └─────────┘ └─────────┘ └─────────┘           │
│        ↑           ↑           ↑           ↑                │
│        └───────────┴───────────┴───────────┘                │
│                    (Extensible)                             │
│                                                             │
│   ┌─────────────────────────────────────────┐               │
│   │ Beneficio: Cambiar fuente de datos      │               │
│   │ SOLO cambiar la implementación inyectada│               │
│   │ El Controlador NO cambia                │               │
│   └─────────────────────────────────────────┘               │
└─────────────────────────────────────────────────────────────┘
```
## 3. STRATEGY PATTERN (Patrón de Estrategia)

### Definición
El patrón Strategy define una familia de algoritmos, encapsula cada uno, y los hace intercambiables. Permite que el algoritmo varíe independientemente de los clientes que lo usan.

### Problema que resuelve

❌ Violación OCP - Nuevo tipo de empleado requiere modificar el método Calculate

❌ Alto acoplamiento - SalaryCalculator conoce todos los tipos concretos

❌ Código difícil de probar - Probar una estrategia requiere probar todas

❌ Extensibilidad limitada - Para agregar "bonificación por antigüedad", tocar código existente
```
┌─────────────────────────────────────────────────────────────┐
│                    STRATEGY STRUCTURE                       │
├─────────────────────────────────────────────────────────────┤
│                                                             │
│   ┌─────────────────┐                                       │
│   │SalaryCalculator │ ← Contexto (Cliente)                  │
│   │   (Context)     │                                       │
│   └────────┬────────┘                                       │
│            │                                                │
│            │ Usa                                            │
│            ↓                                                │
│   ┌─────────────────────────┐                               │
│   │   ISalaryStrategy       │ ← Interfaz Strategy           │
│   │  +Calculate(Employee)   │                               │
│   └────────────┬────────────┘                               │
│                │                                            │
│     ┌──────────┼──────────┬──────────────┐                  │
│     ↓          ↓          ↓              ↓                  │
│ ┌─────────┐ ┌─────────┐ ┌─────────┐ ┌─────────┐             │
│ │FullTime │ │PartTime │ │Freelance│ │ Senior  │ ← Nuevo     │
│ │Strategy │ │Strategy │ │Strategy │ │Strategy │   tipo      │
│ └─────────┘ └─────────┘ └─────────┘ └─────────┘             │
│                                                             │
│   ┌─────────────────────────────────────────┐               │
│   │ Beneficio: Algoritmos intercambiables   │               │
│   │ en tiempo de ejecución                  │               │
│   └─────────────────────────────────────────┘               │
└─────────────────────────────────────────────────────────────┘
```
## Conclusión: ¿Por qué estos 3 patrones?
| Patrón | Razón principal para este proyecto |
|---|---|
| Factory| Tenemos 3+ tipos de empleados que crecen en el tiempo |
| Repository | Necesitamos cambiar de memoria a BD sin afectar UI |
| Strategy | Cada empleado tiene reglas salariales diferentes |
