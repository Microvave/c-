#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ข้อ 9 — โจทย์: นับว่ามีกี่คำในลิสต์ที่ยาวเกิน minLength ตัวอักษร

static int CountLongerThan(List<string> words, int minLength)
{
    int count = 0;
  
    foreach(var x in words)
    {
        if(x.Length>minLength){count++;}
    }
    return count;   // TODO
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
