#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 10 — โจทย์ของคุณ
//  รัน:  dotnet run Ex10_Exercise.cs
//  ดูตัวอย่างแนวทาง:  dotnet run Ex10_Example.cs
// ------------------------------------------------------------
//  โจทย์: 1 -> "จันทร์",  2 -> "อังคาร",  3 -> "พุธ",  อื่น ๆ -> "ไม่รู้จัก"
//  ใบ้:  switch (day) { case 1: return "จันทร์"; ... default: return "ไม่รู้จัก"; }
// ============================================================

static string DayName(int day)
{
    return "";   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, string got, string expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: \"{got}\"   ต้องการ: \"{expected}\"");
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 10 — DayName (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("DayName(2)", DayName(2), "อังคาร");
Check("DayName(9)", DayName(9), "ไม่รู้จัก");
Console.WriteLine();
