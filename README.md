# LiveEncrypt
Live Encrypt is a project to change any string value into an encrypted value where the decryption key is only stored on the users machine.

## Installation
Compile Program.cs in a console .net application and run in release.

## Message Handler Usage
My Message Handler currently utilises three main aspects but will grow.

Sending a Message to Console:
```
- Call MessageHandler.Message(string)
The Message takes inputs of: String, Int and Bool.
String = Text you wish to output
Int = Delay of the message sent in ms (Defaults to 0ms)
Bool = Enable / Disable Debug messages (Default to false)

Example:
```
```csharp
 MessageHandler.Message("Hello World", 150, true);
```

Reading input from user:
```
- Call MessageHandler.Input()
Very simple replacement for Console.ReadLine();

Example:
```
```csharp
 string example = MessageHandler.Input();
```

Output string to a file
```
- Call MessageHandler.StreamWriter(string)
This is an easier way to implement StreamWriter creation of files in your project.
Your file name will be your project name.
Your file extension will be ".neb"
String = Which text you wish to save to a file

Example:
```
```csharp
 MessageHandler.StreamWriter("Hello World");
```

## Contributing
Currently I wish for this to be a solo project.

Please feel free to use this source and improve upon it and let me know in my Discord!

```
Discord: Nebula#1337
```