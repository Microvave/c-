#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 9 — โจทย์ของคุณ
//  รัน:  dotnet run Ex09_Exercise.cs
//  ดูตัวอย่างแนวทาง:  dotnet run Ex09_Example.cs
// ------------------------------------------------------------
//  โจทย์: นับว่ามีกี่คำในลิสต์ที่ยาวเกิน minLength ตัวอักษร
//  ใบ้:  ตัวแปรนับ + foreach + if
// ============================================================

static int CountLongerThan(List<string> words, int minLength)
{
    return 0;   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, int got, int expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: {got}   ต้องการ: {expected}");
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 9 — CountLongerThan (โจทย์ของคุณ) ===");
Console.WriteLine();
var words = new List<string> { "hola", "gracias", "si", "buenos" };
Check("CountLongerThan(words, 3)", CountLongerThan(words, 3), 3);
Check("CountLongerThan(words, 6)", CountLongerThan(words, 6), 1);
Console.WriteLine();
