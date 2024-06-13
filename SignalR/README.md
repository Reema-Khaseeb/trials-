# SignalR Chat App

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)

## Introduction
SignalRChatApp is a real-time chat application built with ASP.NET Core and SignalR. This application demonstrates how to use SignalR for real-time web functionality, enabling server-side code to push content to clients instantly.

## Features
- Real-time messaging
- User-friendly interface
- Easy to set up and deploy

## Prerequisites

- [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/) or any preferred IDE

## Installation

To install `SignalR` Caht App, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/Reema-Khaseeb/trials-.git
   cd SignalR
   ```
2. Restore .NET dependencies:
	```bash
	dotnet restore
	```

3. Build the project:
	```bash
	dotnet build
	```


## Usage
1. Run the application:
    ```bash
	dotnet run
	```

2. Open your web browser and navigate to `http://localhost:5201/` (or the URL specified in your launchSettings.json).

3. Enter your name and start chatting!



## Explanation of Methods
*  Client-Side Method (`ReceiveMessage`) in `\Views\Home\Index.cshtml` file:
    * Parameters:
		* `user` (string): The name of the user sending the message.
		* `message` (string): The content of the message.
    * Description: This JavaScript function receives and displays messages from the server.

* Server-Side Method (`SendMessage`) in `ChatHub` file:
    * Parameters:
    	* `user` (string): The name of the user sending the message.
        * `message` (string): The content of the message.
    * Description: This C# method in the SignalR Hub sends a message to all connected clients.
