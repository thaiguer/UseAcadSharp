using ACadSharp;
using ACadSharp.IO;

Console.WriteLine("Hello, World!");

string sourceFile = @"C:\dev\tablet.dwg";
string targetFile = @"C:\dev\just a drawing222.dxf";

using (DwgReader reader = new DwgReader(sourceFile))
{
    CadDocument doc = reader.Read();
    CadDocument newDoc = new CadDocument();

    foreach (var entity in doc.Entities)
    {
        doc.Entities.Remove(entity);
        newDoc.Entities.Add(entity);
    }

    using (DwgWriter writer = new DwgWriter(targetFile, newDoc))
    {
        writer.Write();
    }
}