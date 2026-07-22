#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 6 — ตัวอย่าง: LINQ  GroupBy + ToDictionary
//  รัน:  dotnet run W06_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W06_Exercise.cs
// ============================================================

// จัดกลุ่มตามความยาวคำ แล้วนับว่าแต่ละความยาวมีกี่คำ
static Dictionary<int, int> CountByLength(List<string> words)
    => words.GroupBy(w => w.Length).ToDictionary(g => g.Key, g => g.Count());

Console.WriteLine();
Console.WriteLine("=== Warmup 6 — ตัวอย่าง: CountByLength ===");
Console.WriteLine();
var demo = new List<string> { "a", "bb", "cc", "d", "eee" };
var r = CountByLength(demo);
Console.WriteLine($"   CountByLength([a,bb,cc,d,eee]) = {string.Join(", ", r.Select(kv => $"{kv.Key}={kv.Value}"))}");
Console.WriteLine();
Console.WriteLine("แนวคิด:  .GroupBy(กุญแจ).ToDictionary(g => g.Key, g => g.Count())");
Console.WriteLine("โจทย์คุณ (W06_Exercise.cs): นับว่าแต่ละคำ (Term) ผิดกี่ครั้ง");
Console.WriteLine();
