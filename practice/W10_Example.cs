#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 10 — ตัวอย่าง: implement interface
//  รัน:  dotnet run W10_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W10_Exercise.cs
// ============================================================

Console.WriteLine();
Console.WriteLine("=== Warmup 10 — ตัวอย่าง: IGreeter ===");
Console.WriteLine();
IGreeter g = new ThaiGreeter();
Console.WriteLine($"   g.Greet(\"บอส\") = {g.Greet("บอส")}");
Console.WriteLine();
Console.WriteLine("แนวคิด: interface ประกาศเมธอด  -> class ... : IGreeter แล้วเขียน body");
Console.WriteLine("โจทย์คุณ (W10_Exercise.cs): ทำ SimpleAdvisor ให้ implement IAdvisor");
Console.WriteLine();

interface IGreeter
{
    string Greet(string name);
}

// class ใช้ : เพื่อ implement interface (เหมือน implements ใน Java)
class ThaiGreeter : IGreeter
{
    public string Greet(string name) => $"สวัสดี {name}";
}
