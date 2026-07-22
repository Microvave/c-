#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ข้อ 12 — โจทย์: คืนอักษรแรกของแต่ละคำต่อกัน ("wave suksawat" -> "WS")


static string Initials(string fullName)
{
    var parts = fullName.Split(' ');
    string acc = "";
    foreach(var p in parts)
    {
        acc += p[0];
        
    }
    return acc.ToUpper();   // TODO
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
