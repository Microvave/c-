#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 8 — ตัวอย่าง: กรองตามวันที่ (DateOnly + Count)
//  รัน:  dotnet run W08_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W08_Exercise.cs
// ============================================================

// นับว่ามีวันที่กี่ตัวที่อยู่ในช่วง days วันล่าสุด นับจาก today (รวม today)
static int CountRecent(List<DateOnly> dates, DateOnly today, int days)
{
    var start = today.AddDays(-(days - 1));
    return dates.Count(d => d >= start && d <= today);
}

Console.WriteLine();
Console.WriteLine("=== Warmup 8 — ตัวอย่าง: CountRecent ===");
Console.WriteLine();
var today = new DateOnly(2026, 7, 20);
var demo = new List<DateOnly>
{
    new(2026, 7, 20), new(2026, 7, 18), new(2026, 7, 10), new(2026, 6, 1)
};
Console.WriteLine($"   CountRecent(7 วันล่าสุด)  = {CountRecent(demo, today, 7)}");
Console.WriteLine($"   CountRecent(60 วันล่าสุด) = {CountRecent(demo, today, 60)}");
Console.WriteLine();
Console.WriteLine("แนวคิด: หาวันเริ่ม = today.AddDays(-(days-1)) แล้ว .Count(อยู่ในช่วง)");
Console.WriteLine("โจทย์คุณ (W08_Exercise.cs): นับ mistake ในช่วง N วันล่าสุด");
Console.WriteLine();
