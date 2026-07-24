#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 3 — โจทย์: คืนความยาวของ Notes  ถ้า Notes เป็น null ให้คืน null (ไม่ใช่ 0)
//   ใบ้: e.Notes?.Length   (return type เป็น int?)

static int? NoteLength(VocabEntry e)
{
    
    return e.Notes ?.Length;   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, int? got, int? expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: {(got is null ? "null" : got)}   ต้องการ: {(expected is null ? "null" : expected)}");
}

var hola = new VocabEntry { Term = "hola", Translation = "สวัสดี" };
var agua = new VocabEntry { Term = "agua", Translation = "น้ำ", Notes = "เพศหญิงแต่ใช้ el" };
Console.WriteLine();
Console.WriteLine("=== Warmup 3 — NoteLength (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("NoteLength(agua) มีโน้ต", NoteLength(agua), 16);
Check("NoteLength(hola) ไม่มีโน้ต", NoteLength(hola), null);
Console.WriteLine();

class VocabEntry
{
    public required string Term { get; init; }
    public required string Translation { get; init; }
    public string? Notes { get; set; }
}
