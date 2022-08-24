using System.Text;

//var path = @"D:\csharp practice\csharp_practice\codes\FileOperations\content.txt";
//var content = "I am learing c#.";

//File.WriteAllText(path, content);

//File.AppendAllText(path, content);

//using FileStream fs = File.Create(path);
//byte[] buffer = Encoding.UTF8.GetBytes(content);

//foreach (var b in buffer)
//{
//    fs.WriteByte(b);
//}

//fs.Flush();

//var line = File.ReadLines(path);

//var lineArray = File.ReadAllLines(path);

//var lineStr = File.ReadAllText(path);


var anotherPath = Directory.GetCurrentDirectory(); //D:\csharp practice\csharp_practice\codes\FileOperations\bin\Debug\net6.0
var parentFolder = Directory.GetParent(anotherPath);//D:\csharp practice\csharp_practice\codes\FileOperations\bin\Debug
var fileOperationFolder = parentFolder.Parent.Parent; //D:\csharp practice\csharp_practice\codes\FileOperations
var location = fileOperationFolder.FullName;

var fullPath = Path.Combine(location,"demo.txt"); //example

//create a directory at location
var folderName = "test";
Directory.CreateDirectory(Path.Combine(location, folderName));//D:\csharp practice\csharp_practice\codes\FileOperations\test

var directory = new DirectoryInfo(location);
var files = directory.GetFiles();
var folders = directory.GetDirectories();

foreach (var file in files)
{
    Console.WriteLine(file.Name);
}

foreach (var folder in folders)
{
    Console.WriteLine(folder.Name);
}

Console.WriteLine("completed");