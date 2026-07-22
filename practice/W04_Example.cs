#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 4 — ตัวอย่าง: switch expression + enum
//  รัน:  dotnet run W04_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W04_Exercise.cs
// ============================================================

// switch expression: กระชับกว่า switch แบบเก่า   _ คือ default
static string Arrow(Direction d) => d switch
{
    Direction.North => "^",
    Direction.South => "v",
    Direction.East => ">",
    _ => "<"
};

Console.WriteLine();
Console.WriteLine("=== Warmup 4 — ตัวอย่าง: Arrow ===");
Console.WriteLine();
Console.WriteLine($"   Arrow(North) = {Arrow(Direction.North)}");
Console.WriteLine($"   Arrow(West)  = {Arrow(Direction.West)}");
Console.WriteLine();
Console.WriteLine("แนวคิด:  value switch { A => x, B => y, _ => z }");
Console.WriteLine("โจทย์คุณ (W04_Exercise.cs): แปลง MistakeType เป็นคำแนะนำ");
Console.WriteLine();

enum Direction { North, South, East, West }
