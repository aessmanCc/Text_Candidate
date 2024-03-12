Email Candidates Automation

This project facilitates sending emails to candidates via SMS (Short Message Service) using their phone numbers. It's designed to send "do not reply" messages to prospective candidates, typically used by recruiters or automated systems when someone is selected for a job opportunity. The application allows users to input candidate information, compose messages, and send them directly to candidate phone numbers via email.

Overview

The application is built using C# and utilizes Windows Forms for the user interface. It provides a simple interface for users to input candidate details, compose messages, select phone providers, and send messages via email. The application also includes settings functionality for configuring email credentials.

Features

- Send SMS Messages via Email: Convert user-composed messages into SMS format and send them to candidate phone numbers via email.
- User-Friendly Interface: Intuitive Windows Forms interface for easy input of candidate details and message composition.
- Settings Configuration: Allows users to set up email credentials for sending messages.
- Data Validation: Ensures that user-provided data is valid before sending messages, preventing errors and ensuring successful delivery.

How to Use

1. Input Candidate Information: Enter candidate name, phone number, message, and select a phone provider.
2. Compose Message: Write the desired message to be sent to the candidate.
3. Send Message: Click the "Send" button to initiate the message sending process.
4. Configure Settings (Optional): Use the "Settings" option to configure email credentials for sending messages.

Code Structure

The project consists of several C# classes organized as follows:

- Email.cs: Represents an email message with candidate information.
- frmEmailCandidate.cs: Windows Form for user interaction, including message composition and sending functionality.
- frmSettings.cs: Windows Form for configuring email settings.
- Message.cs: Represents a message entity with store number, date, timestamp, and content.
- MessageDB.cs: Handles saving and retrieving message data to and from a text file.
- Program.cs: Main entry point for the application.

Requirements

- Development Environment: Visual Studio or any C# development environment.
- .NET Framework: Ensure that the appropriate .NET Framework version is installed.