# linux-assignment3-group12

# Linux Command Helper Application
**Group Number:** 7  
**Group Members:**  
- Kushal Gurung
- Saugat Rana
- Sabin Adhikari

## Linux Command Application
**Simple .NET Console Application With C# and JSON file:**  
Learning about the most commonly used **Linux commands**.  
In this project, we expanded the original demo and included **more than 7 commands** for deeper learning and practice.

📌 *Please refer to the PDF submission for the full list of commands, descriptions, and categories.*

**Reference Cheat Sheet:**  
https://developers.redhat.com/cheat-sheets/linux-commands-cheat-sheet

---

## 📘 Overview
**Linux Command Helper Application** is a simple educational **C# console application** designed to demonstrate core **Object-Oriented Programming (OOP)** concepts and **JSON data integration**.

The project defines a blueprint class called **`LinuxCommands`** which represents each Linux command, including its name, description, category, and example usage.

A JSON file named **`linux-commands.json`** stores multiple command entries. The application loads the JSON file, converts it into object instances, and displays the data dynamically using C# code.

This project helps strengthen understanding of:

- Classes and Objects  
- Encapsulation & Constructors  
- Collections (`List<T>`)  
- JSON Deserialization using `System.Text.Json`  
- Exception Handling  
- Clean Code Structure  

---

## 🎯 Learning Outcomes

- Understand how C# classes encapsulate data and behavior  
- Learn how to read and deserialize JSON files into C# objects  
- Work with collections such as **List**  
- Practice using `foreach` loops to iterate through object collections  
- Get comfortable with namespaces and .NET project structure  
- Organize files: JSON → Class → Main Program  
- Use PascalCase naming conventions  

---

## 🧪 Codespace Installed Versions

You can verify the installed versions:

```
    - node --version
    - java --version
    - python --version
    - dotnet --version
```


---

## 📂 Files Order and Sequence

### 1️⃣ `linux-commands.json`
- Stores command names, descriptions, categories, examples  
- Serves as the data source  

### 2️⃣ `LinuxCommands.cs` (Blueprint Class)
- Defines the object structure  
- Encapsulates properties for each Linux command  
- Used for JSON mapping  

### 3️⃣ `Program.cs`
Handles the program logic:

- Reads JSON file  
- Deserializes JSON data into a `List<LinuxCommands>`  
- Uses `foreach` to display command info  
- Implements exception handling  

---

## 💻 Example Output
- ls: Lists files and directories.
- cd: Changes the current directory.
- pwd: Shows the full path of the current directory.
- mkdir: Creates a new directory.
- rm: Removes files or directories from the system.
- mv: Moves or renames files and directories.
- cat: Displays the contents of a file.


Your full project will include all commands contained in the JSON file.

---

## 🛠️ Codespace Setup for C# Application

### Step 01 — Install C# Extensions
- Install **Microsoft C# Extension** in VS Code  
- (Optional) Verify .NET installation:  

**dotnet --version**


---

### Step 02 — Create New Console App

**CTRL + SHIFT + P**


Select:

- **“.NET New Project”**
- Choose **Console App**
- Name the project (Example: `LinuxCommandsApp`)

---

### Step 03 — Add JSON File
- Create a folder named **`Data`** *(optional)*
- Add the file **`linux-commands.json`**

---

### Step 04 — Create the Blueprint Class
Inside the VS Code Explorer:

- Right-click project  
- New File → Choose **Class**  
- Name it: `LinuxCommands.cs`

---

## 📚 Credits & References

- Professor’s Lecture Recording  
- Microsoft Learn – C# for Beginners  
- C# Documentation – Microsoft Docs  
- JSON Serialization Documentation  
- `File.ReadAllText()` Method  
- RedHat Linux Commands Cheat Sheet  

---

## 👀 README Preview Tip

Use:

CTRL + SHIFT + V


To preview this README.md in VS Code.


