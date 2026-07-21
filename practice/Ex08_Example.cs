#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 8 — ตัวอย่าง (โจทย์อื่น): หา "เลขมากสุด" ในลิสต์
//  รัน:  dotnet run Ex08_Example.cs
//  *** ไฟล์นี้แก้เสร็จแล้ว มีไว้ให้ดูเป็นแนวทาง ***
//  โจทย์จริงของคุณอยู่ที่  Ex08_Exercise.cs
// ============================================================

// เทคนิค: foreach + ตัวเก็บผู้ชนะไว้นอกลูป
static int MaxOf(List<int> nums)
{
    int best = 0;                       // ตัวเก็บผู้ชนะ นอกลูป
    foreach (var x in nums)             // หยิบทีละตัว
    {
        if (x > best) { best = x; }     // เจอตัวใหญ่กว่า ก็อัปเดต
    }
    return best;
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 8 — ตัวอย่าง: MaxOf (หาเลขมากสุด) ===");
Console.WriteLine();
Console.WriteLine($"   MaxOf([3, 7, 2, 5]) = {MaxOf(new List<int> { 3, 7, 2, 5 })}");
Console.WriteLine($"   MaxOf([10, 1, 9])   = {MaxOf(new List<int> { 10, 1, 9 })}");
Console.WriteLine();
Console.WriteLine("แนวคิด: ตัวเก็บผู้ชนะ (best) ไว้นอกลูป -> วน foreach -> เจอตัวดีกว่าก็อัปเดต");
Console.WriteLine("โจทย์คุณ (Ex08_Exercise.cs): แนวเดียวกัน แต่เทียบ .Length และเก็บ \"คำ\" แทนเลข");
Console.WriteLine();
