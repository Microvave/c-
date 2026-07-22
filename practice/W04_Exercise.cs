#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 4 — โจทย์: แปลง MistakeType เป็นคำแนะนำ (ใช้ switch expression)
//   Spelling  -> "ลองเขียนมือ 5 รอบ"
//   Listening -> "ฟังซ้ำแบบไม่ดูตัวหนังสือ"
//   Meaning   -> "แต่งประโยคด้วยคำนี้"
//   อื่น ๆ    -> "ทบทวนตามปกติ"

static string AdviceFor(MistakeType type)
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
Console.WriteLine("=== Warmup 4 — AdviceFor (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("AdviceFor(Spelling)", AdviceFor(MistakeType.Spelling), "ลองเขียนมือ 5 รอบ");
Check("AdviceFor(Listening)", AdviceFor(MistakeType.Listening), "ฟังซ้ำแบบไม่ดูตัวหนังสือ");
Check("AdviceFor(Meaning)", AdviceFor(MistakeType.Meaning), "แต่งประโยคด้วยคำนี้");
Check("AdviceFor(Grammar)", AdviceFor(MistakeType.Grammar), "ทบทวนตามปกติ");
Console.WriteLine();

enum MistakeType { Spelling, Meaning, Listening, Grammar }
