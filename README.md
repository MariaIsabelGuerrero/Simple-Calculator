# 🧮 SimpleCalculator — Kotlin Android App

A **mobile app project written fully in Kotlin**, organized with **Gradle**.  
This repository contains the app module, build scripts, and configurations. It demonstrates core Android development concepts such as layouts, user input handling, and simple data validation.

---

## 🌟 Overview

**SimpleCalculator** is a lightweight Android application built to perform basic arithmetic operations.  
It serves as a beginner-friendly project designed to introduce Kotlin syntax, Android Studio structure, and Jetpack best practices.

---

## 🚀 Features

- ➕ Addition  
- ➖ Subtraction  
- ✖️ Multiplication  
- ➗ Division  
- 🧩 Input validation to prevent division by zero  
- 🧮 Real-time calculation display  
- 🔄 Clear button to reset inputs and results  

---

## 🛠 Tech Stack

| Component | Technology |
|------------|-------------|
| **Language** | Kotlin |
| **UI** | XML Layouts / Jetpack Compose (if applicable) |
| **Architecture** | MVVM (Model-View-ViewModel) |
| **Build Tool** | Gradle |
| **IDE** | Android Studio |
| **Min SDK** | 24 (Android 7.0) |
| **Target SDK** | 35 |

---

## 📦 Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/MariaIsabelGuerrero/SimpleCalculator-Starter.git
   ```

2. **Open** the project in **Android Studio**

3. **Sync Gradle** to install dependencies

4. **Run** the app on an emulator or a physical Android device

---

## 📐 Project Structure

```
SimpleCalculator/
├── app/
│   ├── src/
│   │   ├── main/
│   │   │   ├── java/           # Kotlin source files
│   │   │   ├── res/            # Layouts, drawables, strings
│   │   │   └── AndroidManifest.xml
│   │   └── test/               # Unit tests (if applicable)
│   └── build.gradle            # App-level Gradle config
├── build.gradle                 # Project-level Gradle config
└── settings.gradle              # Includes modules
```

---

## 🧠 How It Works

1. The user enters two numbers.  
2. Selects an operation (+, −, ×, ÷).  
3. The app performs the operation using Kotlin logic and displays the result.  
4. A clear button resets the fields for a new calculation.

---

## 🧪 Testing

If the project includes test cases, run them with:
```bash
./gradlew test
```

Reports will appear under `app/build/reports/tests/`.

---

## 🤝 Contributing

Contributions are always welcome!

