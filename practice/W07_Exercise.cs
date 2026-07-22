#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 7 — โจทย์: คืนคำที่ผิดบ่อยที่สุด N อันดับ เรียงจากมากไปน้อย
//   เมื่อ n=2:  [ MistakeCount("hola", 3), MistakeCount("agua", 2) ]
//   ใบ้: GroupBy(m => m.Term) -> Select(g => new MistakeCount(g.Key, g.Count()))
//        -> OrderByDescending(x => x.Count) -> Take(n) -> ToList()

static List<MistakeCount> TopMistakes(List<Mistake> all, int n)
{
    return new List<MistakeCount>();   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, List<MistakeCount> got, MistakeCount[] expected)
{
    var ok = got.SequenceEqual(expected);
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: [{string.Join(", ", got)}]");
}

var mistakes = Data.Mistakes;
Console.WriteLine();
Console.WriteLine("=== Warmup 7 — TopMistakes (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("TopMistakes(2)", TopMistakes(mistakes, 2),
    new[] { new MistakeCount("hola", 3), new MistakeCount("agua", 2) });
Console.WriteLine();

record MistakeCount(string Term, int Count);

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
