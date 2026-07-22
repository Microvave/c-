#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ข้อ 11 — โจทย์: ตัดช่องว่าง ทำตัวพิมพ์ใหญ่ เติม ! ("  hola  " -> "HOLA!")



static string Shout(string text)
{
    string test = text.Trim().ToUpper();
    return test +"!";   // TODO
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
