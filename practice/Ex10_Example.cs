#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  ข้อ 10 — ตัวอย่าง (โจทย์อื่น): แปลงสีไฟจราจรเป็นคำสั่ง
//  รัน:  dotnet run Ex10_Example.cs
//  *** ไฟล์นี้แก้เสร็จแล้ว มีไว้ให้ดูเป็นแนวทาง ***
//  โจทย์จริงของคุณอยู่ที่  Ex10_Exercise.cs
// ============================================================

// เทคนิค: switch — ถ้า case ลงท้ายด้วย return ไม่ต้องใส่ break
static string TrafficAction(string color)
{
    switch (color)
    {
        case "red": return "หยุด";
        case "yellow": return "ชะลอ";
        case "green": return "ไปได้";
        default: return "ไม่รู้จัก";
    }
}

Console.WriteLine();
Console.WriteLine("=== ข้อ 10 — ตัวอย่าง: TrafficAction (สีไฟจราจร) ===");
Console.WriteLine();
Console.WriteLine($"   TrafficAction(\"red\")    = {TrafficAction("red")}");
Console.WriteLine($"   TrafficAction(\"green\")  = {TrafficAction("green")}");
Console.WriteLine($"   TrafficAction(\"purple\") = {TrafficAction("purple")}");
Console.WriteLine();
Console.WriteLine("แนวคิด: switch แต่ละ case คืนค่า, default คือ 'อื่น ๆ ทั้งหมด'");
Console.WriteLine("โจทย์คุณ (Ex10_Exercise.cs): แนวเดียวกัน แต่ case เป็นตัวเลข 1/2/3");
Console.WriteLine();
