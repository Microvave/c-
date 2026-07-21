#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 11 — โจทย์ของคุณ
//  รัน:  dotnet run Ex11_Exercise.cs
//  ดูตัวอย่างแนวทาง:  dotnet run Ex11_Example.cs
// ------------------------------------------------------------
//  โจทย์: รับข้อความที่อาจมีช่องว่างหน้า-หลัง  ตัดช่องว่างออก
//         ทำเป็นตัวพิมพ์ใหญ่ แล้วเติม !     Shout("  hola  ") -> "HOLA!"
//  ใบ้:  .Trim()  .ToUpper()  แล้วต่อ string ด้วย +  หรือใช้ $"{...}!"
// ============================================================

static string Shout(string text)
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
Console.WriteLine("=== ข้อ 11 — Shout (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("Shout(\"  hola  \")", Shout("  hola  "), "HOLA!");
Console.WriteLine();
