string path = @"D:\csharp practice\csharp_practice\codes\ReverseContentChallenge\content.txt";

FileStream fs = new FileStream(path, FileMode.Open);

var pos = fs.Length - 1;

for (int i = 0; i < fs.Length / 2; i++)
{
    var tempPos = fs.Position;

    var value = fs.ReadByte();

    fs.Position = pos;

    var temp = fs.ReadByte();

    fs.Position = pos;

    fs.WriteByte((byte)value);

    fs.Position = tempPos;

    fs.WriteByte((byte)temp);

    var p = fs.Position;

    pos--;

    fs.Flush();
}