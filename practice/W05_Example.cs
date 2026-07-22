#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 5 — ตัวอย่าง: LINQ  Where + Select
//  รัน:  dotnet run W05_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W05_Exercise.cs
// ============================================================

// Where = กรอง (เหมือน filter), Select = แปลง (เหมือน map)
static List<int> DoubleEvens(List<int> nums)
    => nums.Where(n => n % 2 == 0).Select(n => n * 10).ToList();

Console.WriteLine();
Console.WriteLine("=== Warmup 5 — ตัวอย่าง: DoubleEvens ===");
Console.WriteLine();
var demo = new List<int> { 1, 2, 3, 4, 5, 6 };
Console.WriteLine($"   DoubleEvens([1..6]) = {string.Join(", ", DoubleEvens(demo))}");
Console.WriteLine();
Console.WriteLine("แนวคิด:  list.Where(กรอง).Select(แปลง).ToList()");
Console.WriteLine("โจทย์คุณ (W05_Exercise.cs): เอาเฉพาะ Term ของ mistake ที่เป็น Listening");
Console.WriteLine();
