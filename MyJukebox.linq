<Query Kind="Program" />

void Main()
{
	var musicDirectory = @"C:\Users\tchouina\Music";
	
	Directory.EnumerateFiles(musicDirectory).Dump();
	
	Directory.EnumerateDirectories(musicDirectory).Dump();
	
	var directories = Directory.GetDirectories(musicDirectory);
	var files = Directory.GetFiles(musicDirectory);
	
	directories.Dump();
	files.Dump();
}

private void Foo(string path)
{
	
}

// Define other methods and classes here
