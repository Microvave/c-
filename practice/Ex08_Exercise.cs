#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 8 — โจทย์ของคุณ
//  รัน:  dotnet run Ex08_Exercise.cs
//  ดูตัวอย่างแนวทาง:  dotnet run Ex08_Example.cs
// ------------------------------------------------------------
//  โจทย์: คืนคำที่ยาวที่สุดในลิสต์  ถ้าลิสต์ว่างให้คืน ""
//  ใบ้:  foreach (var word in words) { ... }
//        เทียบความยาวด้วย word.Length  (ไม่ใช่ .length() แบบ Java)
// ============================================================

static string LongestWord(List<string> words)
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
Console.WriteLine("=== ข้อ 8 — LongestWord (โจทย์ของคุณ) ===");
Console.WriteLine();
var words = new List<string> { "hola", "gracias", "si", "buenos" };
Check("LongestWord (4 คำ)", LongestWord(words), "gracias");
Check("LongestWord (ลิสต์ว่าง)", LongestWord(new List<string>()), "");
Console.WriteLine();
