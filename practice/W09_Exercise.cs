#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 9 — โจทย์: สร้าง MistakeCount 2 ตัวที่ค่าเหมือนกันเป๊ะ แล้วคืนผล a == b
//   ต้องได้ true (เพราะเป็น record เทียบด้วยค่า)
//   ใบ้: return new MistakeCount("hola", 3) == new MistakeCount("hola", 3);

static bool RecordsAreEqualByValue()
{
    return false;   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, bool got)
{
    Console.WriteLine($"  {(got ? "OK" : "..")}   {label}   ->  ได้: {got}   ต้องการ: True");
}

Console.WriteLine();
Console.WriteLine("=== Warmup 9 — RecordsAreEqualByValue (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("RecordsAreEqualByValue", RecordsAreEqualByValue());
Console.WriteLine();

record MistakeCount(string Term, int Count);
