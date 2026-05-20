# Shapes Vector Graphics Editor

An advanced C# Windows Forms application built on top of a decoupled class library (`ShapeLibrary`). The project demonstrates professional software architecture by separating core business logic from the presentation layer, implementing the **Command Pattern** for modular action management, and providing real-time data analysis.

##  Technical Implementation & Architecture

### Core Graphics Engine (`ShapeLibrary`)
* **Advanced Architecture:** All core engine logic, shape models, and services are decoupled into a dedicated class library project, ensuring high reusability.
* **Command Design Pattern:** Structural behavior operations are completely encapsulated within isolated command classes (`AddShapeCommand`, `ColorChangeCommand`, `DeleteShapeCommand`, `MoveShapeCommand`). This decouples UI triggers from structural canvas mutations.
* **Polymorphism & Interface Contracts:** Uses explicit architectural abstraction contracts (`IShape`, `ICommand`) to govern behavior, alongside concrete geometric type definitions.
* **State Management:** Utilizes specialized central coordinators (`ShapeManager`, `CommandManager`) to track and update active canvas object states.
* **Dynamic Rendering:** Implements the native WinForms `.Paint` event coupled with layout container synchronization loops (`.Invalidate()`) to draw active objects in real-time.
* **Manual XML Serialization:** The `ShapeXmlServices` component utilizes manual LINQ to XML parsing (`XDocument`, `XElement`) to handle persistent data pipelines without overhead.
* **File Management:** Fully integrated with native Windows `SaveFileDialog` and `OpenFileDialog` dialogue systems.

### Data Analytics & Dashboard (Second Form)
* **Mathematical & Statistical Analysis:** Integrates the **Math.NET Numerics** library to perform advanced statistical operations on vector canvas properties (e.g., calculating distribution, mean, variance, or geometric frequency of the drawn shapes).
* **Data Visualization (Chart):** Uses the native WinForms `Chart` component to graphically display statistical distributions, frequency histograms, or shape attribute patterns through dynamic visual graphs.

##  Repository Structure

###  ShapeLibrary
* `/Contracts` - Core application tracking interfaces (`IShape`, `ICommand`).
* `/Models` - Concrete geometric model implementations (`Circle`, `Rectangle`, `Triangle`).
* `/Managers` - Central component state coordinators (`ShapeManager`, `CommandManager`).
* `/Commands` - Encapsulated behavior execution actions (`Add`, `Move`, `Color`, `Delete`).
* `/Services` - Data persistence tracking providers (`ShapeXmlServices`).

###  ShapeApplication (UI)
* `MainForm.cs` - The primary drawing interface managing canvas interactions and command execution triggers.
* `AnalyticsForm.cs` - The secondary interface hosting the statistical dashboard, Math.NET compute engines, and graphical `Chart` elements.

## How to Run and Test
1. Clone or download this repository.
2. Open the `.sln` solution file in **Visual Studio**.
3. Ensure NuGet packages are restored (specifically `MathNet.Numerics`).
4. Press **F5** or click **Start** to compile and run the application.
5. Interact with the drawing canvas to trigger behavioral commands, open the analytics form to inspect the statistical charts, and use the integrated file dialogue buttons to test the XML data storage pipeline.
