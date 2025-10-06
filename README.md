# 🧮 SimpleCalculator — .NET (C#) Console Solution

A **.NET Framework 4.7.2** console application written in **C#**, organized as a Visual Studio solution with a separate **CalculatorEngine** class library and **MSTest** unit tests.  
This repository demonstrates clean separation of concerns, input validation, and TDD-style unit testing for a simple calculator.

---

## 🌟 Overview

The app reads two numbers and an operation from the console, validates inputs, performs the calculation, and prints a human‑readable result.  
Supported operators: **`+`**, **`-`**, **`*`**, **`/`**, **`^`** (power).  
Input parsing and arithmetic are encapsulated in reusable components.

---

## 🧩 Solution Structure

```
N33-LA-SimpleCalculator-Starter/
├── SimpleCalculator.sln                 # Visual Studio solution
├── SimpleCalculator/                    # Console app (startup project)
│   ├── Program.cs                       # Console UI / flow
│   ├── InputConverter.cs                # string → double conversion with validation
│   └── App.config
├── CalculatorEngine/                    # Class library
│   ├── CalculatorEngine.csproj
│   └── CalculatorOperations.cs          # Core operations (+, -, *, /, ^)
└── SimpleCalculator.Test.Unit/          # Unit tests (MSTest)
    ├── SimpleCalculator.Test.Unit.csproj
    ├── InputConverterTest.cs            # Conversion tests (valid / invalid)
    └── CalculatorEngineTest.cs          # Operation tests (incl. power '^')
```

---

## 🛠 Tech Stack

| Component | Technology |
|-----------|------------|
| **Language** | C# |
| **Target Framework** | .NET Framework **4.7.2** |
| **IDE** | Visual Studio 2019/2022 (Windows) |
| **Unit Tests** | MSTest (TestAdapter 2.x) |
| **Project Type** | Console App + Class Library |

> ℹ️ Because this targets **.NET Framework 4.7.2**, building on macOS/Linux requires Mono/MSBuild and is not officially supported. For cross‑platform CLI builds, consider retargeting to **.NET 8**.

---

## 📦 Getting Started (Visual Studio)

1. **Open the solution**
   ```text
   SimpleCalculator.sln
   ```
2. In **Solution Explorer**, right‑click the solution → **Restore NuGet Packages** (if prompted).
3. Set **SimpleCalculator** as the **Startup Project**.
4. Press **F5** (Run) or **Ctrl+F5** (Run without Debugging).

---

## ▶️ Usage (Console Flow)

```
Enter the first number: 5
Enter operation (+, -, *, /, ^): ^
Enter the second number: 3

Result: 5 ^ 3 = 125
```

Built‑in safeguards include numeric validation and basic error reporting (e.g., preventing invalid inputs).

---

## 🧪 Running Tests

### Visual Studio (recommended)
- Open **Test Explorer** → **Run All Tests**

### MSTest console (if installed)
```bat
vstest.console.exe SimpleCalculator.Test.Unit\bin\Debug\SimpleCalculator.Test.Unit.dll
```

Tests cover:
- `InputConverter` success & failure cases (e.g., non‑numeric input)
- `CalculatorOperations` arithmetic (+, −, ×, ÷, **power**)

---

## 🧠 Design Notes

- **Single Responsibility:** `InputConverter` handles parsing; `CalculatorOperations` performs math.  
- **Testability:** Core logic lives in a class library and is unit‑tested.  
- **Extensibility:** New operations (e.g., modulus, sqrt) can be added as new cases in `CalculatorOperations` with accompanying tests.

---

## 🔧 Common Tasks

- **Change target framework:** Right‑click project → **Properties** → **Application** → **Target framework**.  
- **Add a new operation:** Add a new `case` in `CalculatorOperations.Calculate(...)`, then add tests to `CalculatorEngineTest.cs`.
