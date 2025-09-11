# README - Prueba Técnica NCQ.Test

Este proyecto se realizó como parte del proceso de selección para Ingeniero de Software en NCQ Technologies 2025 por Brayan Martinez, tomando como directríz el documento de requerimientos.

Se realizó una app de escritorio con .Net Framework 4.7.2 + WinForms + DevExpress (Licencia de prueba por 30 días) + SqLite, para gestionar tareas simples 🚀.

## Estructura del Proyecto

El proyecto está organizado en capas siguiendo principios de arquitectura limpia y separación de responsabilidades:

- **Domain**: Contiene las entidades principales (`Task`, `Term`) y sus objetos de valor. Aquí se definen las reglas de negocio y modelos.
- **Application**: Servicios de aplicación que orquestan la lógica entre la infraestructura y el dominio (`TaskService`, `TermService`).
- **Infrastructure**: Implementaciones concretas de persistencia, como los repositorios SQLite (`TaskRepository`, `TermRepository`).
- **Gui**: Interfaz gráfica basada en Windows Forms, con componentes modales, modelos de vista (`MainViewModel`), y lógica de interacción de usuario.
- **Common**: Utilidades compartidas, contratos y configuraciones de mapeo.

## Configuración Inicial

1. **Dependencias**: Instalar paquetes NuGet requeridos (`Mapster`, `Microsoft.Extensions.DependencyInjection`, `System.Data.SQLite`).
2. **Base de Datos**: La Db ya se encuentra lista dado que es en SqLite, sin embargo, se adjuntan script (`DB_DML.sql`) de creación de ser necesarios.
3. **Configuración de Servicios**: Registrar servicios y repositorios en el contenedor de dependencias en `Dependencies.cs`.
4. **Configuración de Mapeos**: Definir configuraciones de mapeo en `MappingConfig` y clases relacionadas.
5. **Recursos**: Asegurarse de que los archivos `.resx` estén correctamente configurados para la localización y los textos de la interfaz.

## Demostración de Habilidades Técnicas

### Patrones de Diseño Utilizados

- **Repository Pattern**: Separación de la lógica de acceso a datos mediante interfaces y clases concretas (`ITaskRepository`, `TaskRepository`).
- **Service Layer**: Orquestación de operaciones de negocio y persistencia en servicios (`TaskService`, `TermService`).
- **Factory Pattern**: Configuración dinámica de menús contextuales (`MainContextMenuSettingFactory`).
- **Builder Pattern**: Creación dinámica de las condiciones where derivadas del filtro (`TaskFilterBuilder`)
- **MVVM (Model-View-ViewModel)**: Separación de lógica de presentación y estado en la interfaz (`MainViewModel`, `FormMvvm`).
- **Dependency Injection**: Resolución de dependencias y desacoplamiento de componentes.

## Convenciones de Código

- **Nombres de Clases**: PascalCase, descriptivos y orientados a dominio.
- **Propiedades y Métodos**: PascalCase para públicos, camelCase para privados.
- **Interfaces**: Prefijo `I` (ejemplo: `ITaskService`).
- **Archivos Parciales**: Uso de `partial` para separar lógica y encapsulamiento.
- **Inyección de Dependencias**: Uso de `IServiceProvider` y `Microsoft.Extensions.DependencyInjection`.
- **Asincronía**: Métodos asíncronos con sufijo `Async` y uso de `Task`/`await`.
- **Mapeo de Objetos**: Uso de Mapster para transformar DTOs y entidades.
- **Validaciones**: Separadas en clases específicas (`AlterModalValidator`).

## Especificación de Convenciones de Código

- **Espacios de nombres**: Estructurados por capa y funcionalidad (`NCQ.Test.Domain.Tasks`, `NCQ.Test.Gui.Windows`).
- **Comentarios**: Breves y descriptivos, solo donde agregan valor.
- **Métodos Privados**: Prefijo `_` para campos privados, sin prefijo para métodos.
- **Propiedades Virtuales**: Uso para facilitar pruebas y extensibilidad.
- **Evitar Lógica en el Constructor**: Inicialización mínima, lógica en métodos dedicados (`Initialize`, `InitializeBinding`).
- **Eventos**: Métodos manejadores con sufijo `Click`, `MouseDown`, etc.
- **Validaciones y Excepciones**: Manejo explícito de errores y validaciones en clases separadas (`FluentValidation`).

---

Para cualquier duda o ampliación de la documentación no dude en contactarme +57 3112468260 🤝.
