#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 2 — โจทย์: คืน e.Notes  แต่ถ้า Notes เป็น null ให้คืน "ไม่มีโน้ต"
//   ใบ้: ใช้ ?? บรรทัดเดียวจบ

static string SafeNotes(VocabEntry e)
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
var agua = new VocabEntry { Term = "agua", Translation = "น้ำ", Notes = "เพศหญิงแต่ใช้ el" };
Console.WriteLine();
Console.WriteLine("=== Warmup 2 — SafeNotes (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("SafeNotes(agua) มีโน้ต", SafeNotes(agua), "เพศหญิงแต่ใช้ el");
Check("SafeNotes(hola) ไม่มีโน้ต", SafeNotes(hola), "ไม่มีโน้ต");
Console.WriteLine();

class VocabEntry
{
    public required string Term { get; init; }
    public required string Translation { get; init; }
    public string? Notes { get; set; }
}
