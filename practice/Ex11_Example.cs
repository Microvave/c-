#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 11 — ตัวอย่าง (โจทย์อื่น): ตัดช่องว่าง ทำตัวพิมพ์เล็ก เติม # ข้างหน้า
//  รัน:  dotnet run Ex11_Example.cs
//  *** ไฟล์นี้แก้เสร็จแล้ว มีไว้ให้ดูเป็นแนวทาง ***
//  โจทย์จริงของคุณอยู่ที่  Ex11_Exercise.cs
// ============================================================

// เทคนิค: ต่อเมธอด string กันได้ (method chaining) และมันคืนค่าใหม่เสมอ
static string ToTag(string text)
{
    string clean = text.Trim().ToLower();   // Trim แล้วส่งผลให้ ToLower ต่อ
    return "#" + clean;
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 11 — ตัวอย่าง: ToTag (ทำ hashtag) ===");
Console.WriteLine();
Console.WriteLine($"   ToTag(\"  HELLO \") = {ToTag("  HELLO ")}");
Console.WriteLine($"   ToTag(\" C#  \")    = {ToTag(" C#  ")}");
Console.WriteLine();
Console.WriteLine("แนวคิด: .Trim().ToLower() ต่อกันได้ เพราะแต่ละตัวคืน string ใหม่");
Console.WriteLine("โจทย์คุณ (Ex11_Exercise.cs): แนวเดียวกัน แต่ใช้ ToUpper() และเติม ! ต่อท้าย");
Console.WriteLine();
