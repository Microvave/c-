#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ข้อ 8 — โจทย์: คืนคำที่ยาวที่สุดในลิสต์ ถ้าลิสต์ว่างให้คืน ""

static string LongestWord(List<string> words)
{
    string best = "";
    foreach(var x in words)
    {
        if(x.Length > best.Length)
        {
            best = x;
        }
    }
    return best;   // TODO
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
