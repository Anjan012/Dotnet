using System;

class FileHandler
{
    private string fileName;

    public FileHandler(string name)
    {
        fileName = name;
        Console.WriteLine("Opening file: " + fileName);
        // Simulate opening a file
    }

    ~FileHandler()
    {
        Console.WriteLine("Finalizer: Closing file " + fileName);
        // Simulate closing a file or releasing resources
    }
}

class Program
{
    static void Main()
    {
        FileHandler f = new FileHandler("data.txt");
        // f goes out of scope here
    }
}
