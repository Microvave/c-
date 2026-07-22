#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 9 — ตัวอย่าง: record เท่ากันด้วย "ค่า"
//  รัน:  dotnet run W09_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W09_Exercise.cs
// ============================================================

Console.WriteLine();
Console.WriteLine("=== Warmup 9 — ตัวอย่าง: record vs class ===");
Console.WriteLine();
Console.WriteLine($"   record: Point(1,2) == Point(1,2)  ->  {new Point(1, 2) == new Point(1, 2)}");
Console.WriteLine($"   class : Box(1,2)   == Box(1,2)    ->  {new Box(1, 2) == new Box(1, 2)}");
Console.WriteLine();
Console.WriteLine("แนวคิด: record ค่าเท่ากัน = เท่ากัน (true)  แต่ class เทียบที่ตัวตน (false)");
Console.WriteLine("โจทย์คุณ (W09_Exercise.cs): สร้าง MistakeCount 2 ตัวค่าเท่ากัน แล้วคืน a == b");
Console.WriteLine();

record Point(int X, int Y);
class Box(int W, int H);   // class ธรรมดา เทียบด้วย "ตัวตน"
