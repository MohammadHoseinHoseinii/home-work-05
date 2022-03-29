try
{
    string path = "C:\\Users\\Mohammad\\Desktop\\ex5\\Sample.txt";
    string path1 = "C:\\Users\\Mohammad\\Desktop\\ex5\\copy";
    var NewFile = File.Create(path);
    File.Copy(path, path1);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}
catch (FileLoadException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
}
catch
{
    Console.WriteLine("can not find Exception .");
}

