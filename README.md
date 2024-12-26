# Math Practice App

A simple Windows Forms application that helps young pupils practice arithmetic operations according to their grade level. There are two forms in this project:

1. **Login Form** – Validates a child's age (between 4 and 8).  
2. **Arithmetic Practice Form** – Pupils select their grade and practice corresponding operations.

## Features

1. **Login Form**  
   - Uses a DateTimePicker to capture Date of Birth.  
   - Calculates the child’s age and ensures it is between 4 and 8. Otherwise, it displays a message and stays on the login screen.

2. **Arithmetic Practice Form**  
   - A ComboBox to select **Grade 1**, **Grade 2**, or **Grade 3**.  
   - **Grade 1**: Single-digit numbers (0–9), only addition.  
   - **Grade 2**: Two-digit numbers (10–99), addition or subtraction.  
   - **Grade 3**: Two-digit numbers (10–99), addition, subtraction, multiplication, or division.  
   - “Generate Random Numbers” clears old input and displays new random numbers.  
   - Textboxes for operator and answer.  
   - Up to 5 attempts to answer correctly before the correct answer is shown.  
   - “Exit” prompts “Do you want to quit?” and closes if “Yes,” otherwise remains open.

## Requirements

- .NET Framework (or .NET 6+ if ported)  
- Visual Studio or any C# IDE that supports Windows Forms

## How to Run

1. Clone or download this repository.  
2. Open the `.sln` file in Visual Studio (or your preferred C# environment).  
3. Restore NuGet packages if prompted.  
4. Build the solution (Ctrl+Shift+B).  
5. Run the application (F5).  
6. The Login Form appears first. If age is 4–8, it proceeds to the Arithmetic Practice Form.

## Usage

1. In the Login Form, pick Date of Birth.  
2. If age is 4–8, you move on to the Arithmetic Practice Form.  
3. Select the grade from the dropdown.  
4. Click “Generate Random Numbers” to produce two numbers.  
5. Enter an operator (valid for your grade) in the operator textbox.  
6. Enter your answer in the answer textbox.  
7. Click “Check” to validate your answer.  
   - If correct, displays “Correct!”  
   - If wrong, try again up to 5 times, then shows the correct answer.  
8. Click “Exit” to close the application (with a Yes/No prompt).

## Contributing

Pull requests are welcome. For major changes, open an issue first to discuss the proposed alterations.

## License

This project is provided as-is for educational purposes and can be adapted for your own use.