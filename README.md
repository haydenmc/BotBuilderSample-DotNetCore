# Simple BotBuilder Sample in .NET Core

Hi friends. 👋

Here's a real simple example of how to get a Bot using Microsoft's BotBuilder SDK (for use in bot framework, Azure, Cortana, etc) running using .NET Core.

This bot can run on Windows, Mac, and Linux platforms.

## Prerequisites
- [Install the .NET Core SDK](https://dot.net/core)
- [Install the Bot Framework Emulator](https://github.com/Microsoft/BotFramework-Emulator/releases)
- *(optional)* [Install Visual Studio Code](https://code.visualstudio.com/) (or use your favorite editor - but VS Code is pretty awesome, and has a built in debugger)

## Getting Started

### 1. Clone this repository

In a command prompt, `cd` to the directory you'd like to work in and run the following

```
git clone https://github.com/haydenmc/BotBuilderSample-DotNetCore.git
```

Or use the "Download ZIP" option on the GitHub website and extract to a directory of your choice.

### 2. Run your bot

In the same prompt, run the following to build and run your bot.

```
dotnet run
```

You should see your console output the following:

```
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

Your bot is now running locally!

### 3. Test your bot using the Bot Framework Emulator

Open the bot framework emulator and change the endpoint URL to point to your local server at `http://localhost:5000/api/messages`

![Bot Framework Emulator Screenshot](https://i.imgur.com/hotOWOh.png)

Hooray! Your bot is working!

### 4. Start working on your bot

In your command prompt, run `code .` to open an instance of Visual Studio Code in your current working directory.

From within Visual Studio Code, you can press F5 to run and debug your bot.

The bot logic is located in `HelloBot.cs`

You can use [the documentation for the Bot Builder SDK](https://docs.microsoft.com/en-us/azure/bot-service/dotnet/bot-builder-dotnet-overview) to learn how to use the Bot SDK to accomplish more.
