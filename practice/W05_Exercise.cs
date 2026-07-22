#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// Warmup 5 — โจทย์: คืน Term ของ mistake ที่เป็นประเภท Listening เท่านั้น
//   ผลลัพธ์: hola, hola, agua   (เรียงตามลำดับเดิม)
//   ใบ้: .Where(m => m.Type == MistakeType.Listening).Select(m => m.Term).ToList()

static List<string> ListeningTerms(List<Mistake> all)
{
    return new List<string>();   // TODO
}


// ===== ส่วนตรวจ — แก้เฉพาะข้างบน =====
void Check(string label, List<string> got, string[] expected)
{
    var ok = got.SequenceEqual(expected);
    Console.WriteLine($"  {(ok ? "OK" : "..")}   {label}   ->  ได้: [{string.Join(", ", got)}]   ต้องการ: [{string.Join(", ", expected)}]");
}

var mistakes = Data.Mistakes;
Console.WriteLine();
Console.WriteLine("=== Warmup 5 — ListeningTerms (โจทย์ของคุณ) ===");
Console.WriteLine();
Check("ListeningTerms", ListeningTerms(mistakes), new[] { "hola", "hola", "agua" });
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
