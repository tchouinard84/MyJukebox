<Query Kind="Program">
  <Reference Relative="..\..\..\Documents\Visual Studio 2017\Projects\MP3_Properties\packages\ID3.0.3.0\lib\net40\Id3.dll">&lt;MyDocuments&gt;\Visual Studio 2017\Projects\MP3_Properties\packages\ID3.0.3.0\lib\net40\Id3.dll</Reference>
  <Reference Relative="..\..\..\Documents\Visual Studio 2017\Projects\MP3_Properties\packages\ID3.Files.0.3.0\lib\net40\Id3.Files.dll">&lt;MyDocuments&gt;\Visual Studio 2017\Projects\MP3_Properties\packages\ID3.Files.0.3.0\lib\net40\Id3.Files.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Id3</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

void Main()
{
	var musicDirectory = @"C:\Users\tchouina\Music\Country"; //@"C:\Users\tchouina\Music";
	var fileTypes = new List<string> { ".mp3" };
	
	var directories = Directory.GetDirectories(musicDirectory);
	var files = Directory.GetFiles(musicDirectory);
	
	//directories.Dump();
	//files.Dump();
	
	var mp3Files = new List<Mp3>();

	foreach (var f in files)
	{
		var file = new FileInfo(f);
		if (!fileTypes.Contains(file.Extension)) { continue; }
		using (var mp3 = new Mp3File(f))
		{
			var tag = mp3.GetTag(Id3TagFamily.FileStartTag);
			
			var mp3File = new Mp3
			{
				Title = tag.Title.Value,
				Artist = tag.Artists.Value,
				Album = tag.Album.Value,
				Year = tag.Year.Value,
				Genre = tag.Genre.Value
			};
			
			//mp3File.Dump();
			
			mp3Files.Add(mp3File);
		}
	}
	var asJson = JsonConvert.SerializeObject(mp3Files);
	asJson.Dump();
	
	var fromJson = JsonConvert.DeserializeObject<List<Mp3>>(asJson);
	fromJson.Dump();
	
}

class Mp3
{
	public string Title { get; set; }
	public string Artist { get; set; }
	public string Album { get; set; }
	public string Year { get; set; }
	public string Genre { get; set; }
	public TimeSpan Length { get; set; }
	public int Rating { get; set; }
	public List<string> Tags { get; set; }
	public string FileName { get; set; }
	public string FolderPath { get; set; }
	public decimal FileSize { get; set; }
}




// Define other methods and classes here