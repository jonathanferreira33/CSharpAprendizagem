// See https://aka.ms/new-console-template for more information

string path00 = @"C:\Temp\ArqTexto.txt";

Console.WriteLine(Path.PathSeparator); // caractere para seprara entre pastas diferentes
Console.WriteLine(Path.DirectorySeparatorChar); // caractere de separação
Console.WriteLine(Path.GetDirectoryName(path00)); // caminho
Console.WriteLine(Path.GetFileName(path00)); // nome do arquivo
Console.WriteLine(Path.GetFileNameWithoutExtension(path00)); // nome do arquivo sem a extensão
Console.WriteLine(Path.GetExtension(path00)); // extensão
Console.WriteLine(Path.GetFullPath(path00)); // todo caminho



try
{
    string path = @"C:\Temp";
    Directory.CreateDirectory(path + @"\newfolder"); // criar nova pasta

    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // listar pastas
    Console.WriteLine("Paths:");
    foreach (string folder in folders)
    {
        Console.WriteLine(folder);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);  // listar arquivos
    Console.WriteLine("Files:");
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }
}
catch (Exception e) { }

string sourcePath = @"C:\Temp\ArqTexto.txt";
string targetPath = @"C:\Temp\ArqTexto2.txt";
string sourcePathFolder = @"C:\Temp\ArqTexto2.txt";

FileStream fs = null; //mais objetivo
StreamReader sr = null; // stream: sequencia de dados
FileInfo fi = new FileInfo(sourcePath); //melhor perfoamance

try
{
    fi.CopyTo(targetPath); // copia
    string[] lines = File.ReadAllLines(fi.FullName);
    string[] lines02 = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }


    fs = new FileStream(sourcePath, FileMode.Open);
    sr = new StreamReader(fs);
    string lineFs = sr.ReadLine();
    Console.WriteLine(lineFs);
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Acesso negado. {ex.Message}");
}
catch (DirectoryNotFoundException ex01)
{
    Console.WriteLine(ex01.Message);
}
catch (DriveNotFoundException ex02)
{
    Console.WriteLine(ex02.Message);
}
catch (EndOfStreamException ex03)
{
    Console.WriteLine(ex03.Message);
}
catch (FileLoadException ex04)
{
    Console.WriteLine(ex04.Message);
}
catch (FileNotFoundException ex05)
{
    Console.WriteLine($"Arquivo inexistente na pasta. {ex05.Message}");
}
catch (PathTooLongException ex06)
{
    Console.WriteLine(ex06.Message);
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}

//Outra forma

using (FileStream fs2 = new FileStream(sourcePath, FileMode.Open))
{
    try
    {

        using (StreamReader sr2 = new StreamReader(fs2))
        {
            while (!sr2.EndOfStream)
            {
                string line = sr2.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
    catch (Exception e)
    {

    }
}

// ou

try
{
    using (StreamReader sr3 = File.OpenText(sourcePath))
    {
        while (!sr3.EndOfStream)
        {
            string line = sr3.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (Exception e)
{

}

try
{
    string[] lines = File.ReadAllLines(sourcePath);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpperInvariant());
        }
    }
}
catch (Exception e)
{

}

