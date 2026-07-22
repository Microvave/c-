#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 6 — โจทย์: คืน Dictionary ว่าแต่ละ Term ผิดกี่ครั้ง
//   ผลลัพธ์: hola=3, agua=2, gracias=1
//   ใบ้: .GroupBy(m => m.Term).ToDictionary(g => g.Key, g => g.Count())

static Dictionary<string, int> CountByTerm(List<Mistake> all)
{
    return new Dictionary<string, int>();   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, Dictionary<string, int> got)
{
    var ok = got.Count == 3 && got.GetValueOrDefault("hola") == 3
                            && got.GetValueOrDefault("agua") == 2
                            && got.GetValueOrDefault("gracias") == 1;
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: {string.Join(", ", got.Select(kv => $"{kv.Key}={kv.Value}"))}");
}

var mistakes = Data.Mistakes;
Console.WriteLine();
Console.WriteLine("=== Warmup 6 — CountByTerm (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("CountByTerm (ต้องการ hola=3, agua=2, gracias=1)", CountByTerm(mistakes));
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
