# Simple Four-Operation WinForms Application

This project is a Windows Forms (WinForms) application developed in C#. It performs addition, subtraction, multiplication, and division operations by prompting the user for two numbers.

---

## 🚀 Features

- Performing four operations interactively with the user interface
- Alerting the user to incorrect entries (for example, if text like "abc" is entered)
- Catching division by 0 errors and displaying a message
- Displaying the result on a label

---

## 🖥️ User Interface

The form includes:

- 2 TextBoxes: For number input
- 4 Buttons: For addition, subtraction, multiplication, and division
- 1 Label: For displaying the results to the user
- Label components for input descriptions (optional)

---

## ⚙️ How Does It Work?

1. The user enters two numbers into `TextBox1` and `TextBox2`.
2. The relevant operation button is clicked (Add, Subtract, Multiply, Divide).
3. The code performs the following operations:

- Converts the contents of `TextBox.Text` to a number using `Convert.ToDouble(...)`.
- Performs the selected operation.
- Displays the result on the screen using `label1.Text`.
4. If an invalid entry is made, a warning message is displayed using the `try-catch` block:
- "Please enter a valid number!"

- If `0` is entered during the division operation, a separate warning is displayed: `"A number cannot be divided by 0!"`
