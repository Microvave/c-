#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 12 — ตัวอย่าง (โจทย์อื่น): รับ "a,b,c" คั่นด้วย ,
//           แล้วต่ออักษรตัวสุดท้ายของแต่ละคำ
//  รัน:  dotnet run Ex12_Example.cs
//  *** ไฟล์นี้แก้เสร็จแล้ว มีไว้ให้ดูเป็นแนวทาง ***
//  โจทย์จริงของคุณอยู่ที่  Ex12_Exercise.cs
// ============================================================

// เทคนิค: Split ได้ array, เข้าถึงตัวอักษรในคำด้วย index p[i]
static string LastChars(string csv)
{
    var parts = csv.Split(',');          // "cat,dog" -> ["cat", "dog"]
    string acc = "";
    foreach (var p in parts)
    {
        acc += p[p.Length - 1];          // p[ความยาว-1] = อักษรตัวสุดท้าย
    }
    return acc;
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 12 — ตัวอย่าง: LastChars (อักษรตัวสุดท้ายแต่ละคำ) ===");
Console.WriteLine();
Console.WriteLine($"   LastChars(\"cat,dog\")   = {LastChars("cat,dog")}");
Console.WriteLine($"   LastChars(\"one,two,go\") = {LastChars("one,two,go")}");
Console.WriteLine();
Console.WriteLine("แนวคิด: Split(',') ได้ array -> วนแต่ละคำ -> หยิบอักษรด้วย index -> ต่อ string");
Console.WriteLine("โจทย์คุณ (Ex12_Exercise.cs): แนวเดียวกัน แต่ Split(' '), เอา p[0], และ ToUpper()");
Console.WriteLine();
