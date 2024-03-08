# EmailHelperLibrary

This is a C# class library providing a foundation for building email content. It offers an abstract class and an interface to promote flexibility and reusability in creating different email content builders.

# Features

Abstract Class - EmailContentBuilder: This class defines a common structure for building email content. Subclasses can implement specific functionalities while inheriting core properties and methods.
Interface - IDataFormatter: This interface allows for implementing custom logic for formatting data used within email content.

# Benefits

Flexibility: The abstract class allows for creating diverse email content builders with specific functionalities.
Reusability: The core logic for building email content is centralized, promoting code maintainability and reducing redundancy.
Testability: Abstract classes and interfaces facilitate easier unit testing of core functionalities.

# Usage

Reference the Library: Add the EmailHelperLibrary.dll file as a reference in your project.
Create a Subclass: Inherit from the EmailContentBuilder class and implement the abstract method GenerateCustomTableCellValue to define custom cell value generation logic.
Implement Data Formatting: Implement the IDataFormatter interface to create a custom data formatter for your specific needs (optional).
Build Email Content: Use your subclass of EmailContentBuilder to construct the email content by setting properties like Table, TableHead, and TableBody.
Format Data: If needed, use your custom IDataFormatter implementation to format data used within the email content.

# Getting Started

Take a look at the EmailContentBuilder class and its abstract methods.
Consider implementing the IDataFormatter interface for custom data formatting.
Refer to the documentation for your specific project to understand how to integrate this library.

# Contributing

We welcome contributions to this library!

If you have identified bugs or have suggestions for improvement, please raise an issue on the project repository (link to be provided if applicable).
Feel free to submit pull requests with your contributions following the project's coding conventions (link to be provided if applicable).