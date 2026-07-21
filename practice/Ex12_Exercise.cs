#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 12 — โจทย์ของคุณ
//  รัน:  dotnet run Ex12_Exercise.cs
//  ดูตัวอย่างแนวทาง:  dotnet run Ex12_Example.cs
// ------------------------------------------------------------
//  โจทย์: รับชื่อเต็มคั่นด้วยช่องว่าง คืนอักษรแรกของแต่ละคำต่อกัน
//         Initials("wave suksawat") -> "WS"
//  ใบ้:  var parts = fullName.Split(' ');   ได้ array
//        parts[0][0] คืออักษรตัวแรกของคำแรก  อย่าลืม ToUpper()
// ============================================================

static string Initials(string fullName)
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
Console.WriteLine("=== ข้อ 12 — Initials (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("Initials(\"wave suksawat\")", Initials("wave suksawat"), "WS");
Check("Initials(\"a b c\")", Initials("a b c"), "ABC");
Console.WriteLine();
