#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================
//  Warmup 3 — ตัวอย่าง: null-conditional  ?.
//  รัน:  dotnet run W03_Example.cs
//  *** แก้เสร็จแล้ว มีไว้ดูเป็นแนวทาง ***  โจทย์จริงอยู่ที่ W03_Exercise.cs
// ============================================================

// ถ้า middle เป็น null  middle?.Length จะได้ null (ไม่ crash)  return type จึงเป็น int?
static int? MiddleLen(string? middle) => middle?.Length;

Console.WriteLine();
Console.WriteLine("=== Warmup 3 — ตัวอย่าง: MiddleLen ===");
Console.WriteLine();
Console.WriteLine($"   MiddleLen(\"กลาง\") = {MiddleLen("กลาง")}");
Console.WriteLine($"   MiddleLen(null)   = {MiddleLen(null)}   (ว่าง = null)");
Console.WriteLine();
Console.WriteLine("แนวคิด:  x?.Length  =  ถ้า x เป็น null ทั้งนิพจน์ได้ null");
Console.WriteLine("โจทย์คุณ (W03_Exercise.cs): คืนความยาว Notes ถ้า null ให้คืน null");
Console.WriteLine();
