#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 2 — ตัวอย่าง: null-coalescing  ??
//  รัน:  dotnet run W02_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W02_Exercise.cs
// ============================================================

// nick เป็น null ได้ (string?)  ถ้า null ให้ใช้ค่าขวามือแทน
static string Nickname(string? nick) => nick ?? "ไม่มีชื่อเล่น";

Console.WriteLine();
Console.WriteLine("=== Warmup 2 — ตัวอย่าง: Nickname ===");
Console.WriteLine();
Console.WriteLine($"   Nickname(\"บอส\") = {Nickname("บอส")}");
Console.WriteLine($"   Nickname(null)  = {Nickname(null)}");
Console.WriteLine();
Console.WriteLine("แนวคิด:  a ?? b  =  ถ้า a เป็น null ให้ใช้ b");
Console.WriteLine("โจทย์คุณ (W02_Exercise.cs): Notes เป็น null ให้คืน \"ไม่มีโน้ต\"");
Console.WriteLine();
