#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 10 — โจทย์: ทำคลาส SimpleAdvisor ให้ implement IAdvisor
//   ให้ Advise คืนคำแนะนำแบบเดียวกับ Warmup 4 (switch expression)
//   Spelling->"ลองเขียนมือ 5 รอบ", Listening->"ฟังซ้ำแบบไม่ดูตัวหนังสือ",
//   Meaning->"แต่งประโยคด้วยคำนี้", อื่น ๆ->"ทบทวนตามปกติ"
//   ** แก้ที่คลาส SimpleAdvisor ท้ายไฟล์ **

// ===== ส่วนตรวจ — แก้ที่คลาสท้ายไฟล์ =====
void Check(string label, string got, string expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: \"{got}\"   ต้องการ: \"{expected}\"");
}

Console.WriteLine();
Console.WriteLine("=== Warmup 10 — SimpleAdvisor (โจทย์ของคุณ) ===");
Console.WriteLine();
IAdvisor advisor = new SimpleAdvisor();
Check("Advise(Listening)", advisor.Advise(MistakeType.Listening), "ฟังซ้ำแบบไม่ดูตัวหนังสือ");
Check("Advise(Spelling)", advisor.Advise(MistakeType.Spelling), "ลองเขียนมือ 5 รอบ");
Console.WriteLine();

enum MistakeType { Spelling, Meaning, Listening, Grammar }

interface IAdvisor
{
    string Advise(MistakeType type);
}

// ---- แก้ตรงนี้: เขียน switch expression ในเมธอด Advise ----
class SimpleAdvisor : IAdvisor
{
    public string Advise(MistakeType type)
    {
        return "";   // TODO
    }
}
