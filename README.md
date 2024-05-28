# WPF Timer

Este es un proyecto de cronómetro desarrollado en WPF (Windows Presentation Foundation) utilizando C# y los principios SOLID. El cronómetro permite iniciar, pausar y detener el tiempo mostrando el formato "horas::minutos::segundos".

## Requisitos

- .NET 8 SDK
- Visual Studio 2022 o superior

## Instalación

1. Clona el repositorio:

    ```bash
    git clone https://github.com/ernes8528/WpfTimer.git
    ```

2. Navega al directorio del proyecto:

    ```bash
    cd WpfTimer
    ```

3. Abre el archivo de solución (`.sln`) en Visual Studio.

## Uso

1. Compila el proyecto en Visual Studio (`Ctrl+Shift+B`).
2. Ejecuta la aplicación (`F5`).

## Funcionalidades

- **Start**: Inicia el cronómetro.
- **Pause**: Pausa el cronómetro.
- **Stop**: Detiene el cronómetro y reinicia el contador.

## Principios SOLID Aplicados

- **SRP (Single Responsibility Principle)**: Cada clase tiene una única responsabilidad.
- **OCP (Open/Closed Principle)**: Las clases están abiertas para extensión pero cerradas para modificación.
- **LSP (Liskov Substitution Principle)**: Las clases derivadas pueden sustituir a las clases base sin alterar el comportamiento del programa.
- **ISP (Interface Segregation Principle)**: Utilización de interfaces para asegurar que las clases no dependan de métodos que no usan.
- **DIP (Dependency Inversion Principle)**: Dependencia de abstracciones en lugar de implementaciones concretas.

## Estructura del Proyecto

- **ITimer.cs**: Interfaz que define los métodos y eventos del cronómetro.
- **Timer.cs**: Implementación de la interfaz `ITimer` utilizando un `DispatcherTimer`.
- **MainWindow.xaml**: Define la interfaz de usuario utilizando XAML.
- **MainWindow.xaml.cs**: Código de backend que maneja la lógica de la interfaz de usuario y la interacción con el cronómetro.

---

Desarrollado con ❤️ por [Ernesto Rodríguez García](https://github.com/ernes8528)
