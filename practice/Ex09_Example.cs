#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 9 — ตัวอย่าง (โจทย์อื่น): นับว่ามี "เลขบวก" กี่ตัวในลิสต์
//  รัน:  dotnet run Ex09_Example.cs
//  *** ไฟล์นี้แก้เสร็จแล้ว มีไว้ให้ดูเป็นแนวทาง ***
//  โจทย์จริงของคุณอยู่ที่  Ex09_Exercise.cs
// ============================================================

// เทคนิค: ตัวนับไว้นอกลูป + foreach + if
static int CountPositive(List<int> nums)
{
    int count = 0;                      // ตัวนับ นอกลูป
    foreach (var x in nums)
    {
        if (x > 0) { count++; }         // เข้าเงื่อนไขเมื่อไหร่ นับเพิ่ม
    }
    return count;
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 9 — ตัวอย่าง: CountPositive (นับเลขบวก) ===");
Console.WriteLine();
Console.WriteLine($"   CountPositive([-2, 5, 0, 8, -1]) = {CountPositive(new List<int> { -2, 5, 0, 8, -1 })}");
Console.WriteLine($"   CountPositive([1, 2, 3])         = {CountPositive(new List<int> { 1, 2, 3 })}");
Console.WriteLine();
Console.WriteLine("แนวคิด: ตัวนับ (count) ไว้นอกลูป -> วน foreach -> เข้า if ก็ count++");
Console.WriteLine("โจทย์คุณ (Ex09_Exercise.cs): แนวเดียวกัน แต่เงื่อนไขเป็น word.Length > minLength");
Console.WriteLine();
