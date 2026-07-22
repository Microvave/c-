#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 1 — ตัวอย่าง: string interpolation  $"..."
//  รัน:  dotnet run W01_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W01_Exercise.cs
// ============================================================

static string FormatItem(string name, int price) => $"{name} ราคา {price} บาท";

Console.WriteLine();
Console.WriteLine("=== Warmup 1 — ตัวอย่าง: FormatItem ===");
Console.WriteLine();
Console.WriteLine($"   FormatItem(\"แอปเปิล\", 25) = {FormatItem("แอปเปิล", 25)}");
Console.WriteLine();
Console.WriteLine("แนวคิด: $\"...\" แทรกตัวแปรด้วย {}  เรียก .Length ใน {} ได้เลย");
Console.WriteLine("โจทย์คุณ (W01_Exercise.cs): ทำ \"hola = สวัสดี (4 ตัวอักษร)\" จาก VocabEntry");
Console.WriteLine();
