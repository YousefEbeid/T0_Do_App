
Task Manager Application
Description
This console-based task manager application allows users to manage a list of tasks. Upon starting the application, a welcome message is displayed, followed by a menu system where users can perform various operations on tasks.

Requirements
Welcome Message: Display a welcome message when the application starts.
Menu System: Implement a menu system to interact with the user.
Menu Options:
"add": Add a new task to the list with a title, description, and due date.
"list": Display all tasks sorted by priority (high to low), showing titles, due dates, priorities, and completion status.
"edit": Modify an existing task by specifying its ID, allowing changes to title, description, due date, and priority.
"complete": Mark a task as completed by specifying its ID.
"delete": Remove a task from the list by specifying its ID.
"set priority": Change the priority of a task by specifying its ID and a new priority (high, medium, or low).
"exit": Quit the application.
Input Validation: Validate user inputs to ensure correct data entry:
Validate due dates in the format "YYYY-MM-DD".
Check that task IDs exist before performing edit, completion, deletion, or priority setting operations.
Ensure valid priority levels (high, medium, low) for task prioritization.
Feedback Messages: Provide appropriate feedback to the user after each operation, including error messages for invalid inputs.
Data Storage: Store tasks in memory during runtime without permanent data storage.
Code Quality: Ensure clean, well-structured, and understandable code:
Use proper naming conventions for variables, functions, and classes.
Include meaningful comments to explain complex logic or important sections.
Usage
To run the application:

Clone this repository.
Navigate to the project directory.
Run the application using your preferred IDE or command line interface.
Feel free to explore and contribute to the codebase to enhance the functionality and usability of this task manager application. Your feedback and suggestions are appreciated!
