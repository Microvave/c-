#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 1 — โจทย์: คืน "hola = สวัสดี (4 ตัวอักษร)" จาก VocabEntry
//   ใช้ $"..." แทรก e.Term, e.Translation, และ e.Term.Length

static string Describe(VocabEntry e)
{
    return "";   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, string got, string expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: \"{got}\"   ต้องการ: \"{expected}\"");
}

var hola = new VocabEntry { Term = "hola", Translation = "สวัสดี" };
Console.WriteLine();
Console.WriteLine("=== Warmup 1 — Describe (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("Describe(hola)", Describe(hola), "hola = สวัสดี (4 ตัวอักษร)");
Console.WriteLine();

class VocabEntry
{
    public required string Term { get; init; }
    public required string Translation { get; init; }
    public string? Notes { get; set; }
}
