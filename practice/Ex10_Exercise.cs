#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ข้อ 10 — โจทย์: 1->"จันทร์" 2->"อังคาร" 3->"พุธ" อื่น ๆ->"ไม่รู้จัก"

static string DayName(int day)
{
    switch(day)
    {
        case 1 : return "จันทร์";
        case 2 : return "อังคาร";
        case 3 : return "พุธ";
        default: return "ไม่รู้จัก";
    }

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
