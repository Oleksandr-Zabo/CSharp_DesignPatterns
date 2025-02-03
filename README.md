---

# CSharp_DesignPatterns

This repository contains various design patterns implemented in C#. These patterns can be utilized in the `Program.cs` file to demonstrate their use and functionality.

## Project Setup

The project is built using .NET 9.0, and it includes several design pattern projects as references:

- AbstractFactory
- Builder
- FabricMethod
- Patterns_2
- Patterns_3

## Design Patterns

Below is a list of design patterns included in this repository:

1. **Visitor Template Method**
   - Implemented in the `Patterns_3` project.
   - Demonstrates the Visitor design pattern combined with the Template Method pattern.

## How to Run

To run the project and see the design patterns in action:

1. Clone the repository: `git clone https://github.com/Oleksandr-Zabo/CSharp_DesignPatterns.git`
2. Open the solution in your preferred IDE (e.g., Visual Studio).
3. Build the solution to restore all necessary dependencies.
4. Run the `Program.cs` file to execute the main method which demonstrates the design patterns.

The `Program.cs` file contains the entry point of the application:

```csharp
using Patterns_3.Visitor_TemplateMethod;
namespace CSharp_DesignPatterns
{
    class Program 
    {
        static void Main()
        {
            ClientCode client = new ClientCode();
            client.Main();
        }
    }
}
```

This code initializes a `ClientCode` object from the `Patterns_3` project and calls the `Main` method to demonstrate the Visitor Template Method design pattern.

## Contributions

Feel free to contribute to this project by adding new design patterns or improving the existing ones. Please follow the standard GitHub workflow for contributions (fork the repository, create a feature branch, commit your changes, and open a pull request).

---
