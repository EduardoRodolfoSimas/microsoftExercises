using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine();

var currentDirectory = Directory.GetCurrentDirectory();

var storeDirectory = Path.Combine(currentDirectory, "stores");


var salesFiles = FindFiles(storeDirectory);

foreach(var file in salesFiles)
{
    Console.WriteLine(file);
}

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;  

}