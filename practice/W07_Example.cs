#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 7 — ตัวอย่าง: LINQ เต็มสูตร (GroupBy -> Select -> OrderByDescending -> Take)
//  รัน:  dotnet run W07_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W07_Exercise.cs
// ============================================================

// หา "ของที่โผล่บ่อยที่สุด" N อันดับ
static List<Tally> TopItems(List<string> items, int n)
    => items.GroupBy(x => x)
            .Select(g => new Tally(g.Key, g.Count()))
            .OrderByDescending(t => t.Count)
            .Take(n)
            .ToList();

Console.WriteLine();
Console.WriteLine("=== Warmup 7 — ตัวอย่าง: TopItems ===");
Console.WriteLine();
var demo = new List<string> { "แดง", "แดง", "แดง", "เขียว", "เขียว", "ฟ้า" };
Console.WriteLine($"   TopItems(2) = {string.Join(", ", TopItems(demo, 2))}");
Console.WriteLine();
Console.WriteLine("แนวคิด: GroupBy -> Select(สร้างผลนับ) -> OrderByDescending -> Take(n)");
Console.WriteLine("โจทย์คุณ (W07_Exercise.cs): หาคำที่ผิดบ่อยสุด N อันดับ");
Console.WriteLine();

record Tally(string Name, int Count);
