#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 8 — โจทย์: นับ mistake ที่เกิดใน "days" วันล่าสุด นับจาก today (รวม today)
//   days=7 จาก 2026-07-20 -> ได้ 5  (ตัดตัว 2026-06-01 ออก)
//   ใบ้: var start = today.AddDays(-(days - 1));
//        return all.Count(m => m.OccurredOn >= start && m.OccurredOn <= today);

static int CountWithinDays(List<Mistake> all, DateOnly today, int days)
{
    return 0;   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, int got, int expected)
{
    var ok = got == expected;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: {got}   ต้องการ: {expected}");
}

var mistakes = Data.Mistakes;
var today = new DateOnly(2026, 7, 20);
Console.WriteLine();
Console.WriteLine("=== Warmup 8 — CountWithinDays (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("CountWithinDays(7)", CountWithinDays(mistakes, today, 7), 5);
Check("CountWithinDays(60)", CountWithinDays(mistakes, today, 60), 6);
Console.WriteLine();

enum MistakeType { Spelling, Meaning, Listening, Grammar }

class Mistake
{
    public required string Term { get; init; }
    public required MistakeType Type { get; init; }
    public required DateOnly OccurredOn { get; init; }
}

static class Data
{
    public static List<Mistake> Mistakes => new()
    {
        new() { Term = "hola",    Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 7, 18) },
        new() { Term = "hola",    Type = MistakeType.Spelling,  OccurredOn = new DateOnly(2026, 7, 19) },
        new() { Term = "hola",    Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 7, 20) },
        new() { Term = "agua",    Type = MistakeType.Meaning,   OccurredOn = new DateOnly(2026, 7, 20) },
        new() { Term = "agua",    Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 6, 1)  },
        new() { Term = "gracias", Type = MistakeType.Spelling,  OccurredOn = new DateOnly(2026, 7, 20) },
    };
}
