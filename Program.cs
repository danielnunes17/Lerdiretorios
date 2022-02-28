
var path = @"C:\Work\C#\streams\directry_and_directory_info\Globo";
Lerdiretorios(path);
Console.WriteLine("Digite [ENTER] para finalizar");
Console.ReadLine();


static void Lerdiretorios(string path)
{
    if (Directory.Exists(path))
    {

        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome] : {dirInfo.Name}");
            Console.WriteLine($"[Raiz] : {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai] : {dirInfo.Parent.Name}");

            Console.WriteLine("______________________________");
        }
    }


    else
    {
        Console.WriteLine($"O {path} não existe");


    }
}

