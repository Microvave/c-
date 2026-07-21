#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================================
//  C# WARM-UP  —  โจทย์ทบทวนก่อนลงมือทำ DuoNotes
// ============================================================================
//
//  วิธีใช้:
//      cd D:\wave\code\duolingo\practice
//      dotnet run CSharpWarmup.cs
//
//  ตอนนี้รันแล้วจะเห็น ❌ เกือบทุกข้อ เพราะยังไม่ได้เขียน
//  งานของคุณ: แก้เฉพาะตรงที่เขียนว่า "TODO" ให้กลายเป็น ✅ ทีละข้อ
//  รันซ้ำได้เรื่อย ๆ ไม่ต้องกลัวพัง
//
//  ห้ามแก้ส่วน CHECK ด้านล่าง และไม่ต้องแก้ส่วนประกาศ type ท้ายไฟล์
//  (แต่ให้ "อ่าน" ส่วนประกาศ type นะ — มันคือตัวอย่าง syntax ที่ใช้ตอบโจทย์ได้)
//
// ============================================================================


// ---------------------------------------------------------------------------
//  ข้อมูลตัวอย่างที่โจทย์ใช้ร่วมกัน
// ---------------------------------------------------------------------------
var hola = new VocabEntry { Term = "hola", Translation = "สวัสดี" };
var agua = new VocabEntry { Term = "agua", Translation = "น้ำ", Notes = "เพศหญิงแต่ใช้ el" };

var mistakes = new List<Mistake>
{
    new() { Term = "hola",   Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 7, 18) },
    new() { Term = "hola",   Type = MistakeType.Spelling,  OccurredOn = new DateOnly(2026, 7, 19) },
    new() { Term = "hola",   Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 7, 20) },
    new() { Term = "agua",   Type = MistakeType.Meaning,   OccurredOn = new DateOnly(2026, 7, 20) },
    new() { Term = "agua",   Type = MistakeType.Listening, OccurredOn = new DateOnly(2026, 6, 1)  },
    new() { Term = "gracias",Type = MistakeType.Spelling,  OccurredOn = new DateOnly(2026, 7, 20) },
};

var today = new DateOnly(2026, 7, 20);


// ###########################################################################
// #                          เริ่มโจทย์ตรงนี้                                #
// ###########################################################################


// ---------------------------------------------------------------------------
//  ข้อ 1 — string interpolation
//  ให้คืนค่าในรูปแบบ:   hola = สวัสดี (4 ตัวอักษร)
//  ใบ้: ใช้ $"..." แล้วแทรกตัวแปรด้วย {} — ความยาว string ใช้ .Length
// ---------------------------------------------------------------------------
static string Describe(VocabEntry e)
{
    return "";   // TODO 1
}


// ---------------------------------------------------------------------------
//  ข้อ 2 — null-coalescing  (??)
//  Notes เป็น string? (เป็น null ได้)  ถ้าเป็น null ให้คืนคำว่า  ไม่มีโน้ต
//  ใบ้: เขียนได้ในบรรทัดเดียวด้วย ??
// ---------------------------------------------------------------------------
static string SafeNotes(VocabEntry e)
{
    return "";   // TODO 2
}


// ---------------------------------------------------------------------------
//  ข้อ 3 — null-conditional  (?.)
//  คืนความยาวของ Notes  แต่ถ้า Notes เป็น null ให้คืน null (ไม่ใช่ 0 และห้าม crash)
//  สังเกตว่า return type เป็น int? ไม่ใช่ int
//  ใบ้: e.Notes?.Length
// ---------------------------------------------------------------------------
static int? NoteLength(VocabEntry e)
{
    return 0;   // TODO 3
}


// ---------------------------------------------------------------------------
//  ข้อ 4 — switch expression กับ enum
//  Spelling  -> ลองเขียนมือ 5 รอบ
//  Listening -> ฟังซ้ำแบบไม่ดูตัวหนังสือ
//  Meaning   -> แต่งประโยคด้วยคำนี้
//  อื่น ๆ    -> ทบทวนตามปกติ
//  ใบ้:  return type switch { MistakeType.Spelling => "...", _ => "..." };
// ---------------------------------------------------------------------------
static string AdviceFor(MistakeType type)
{
    return "";   // TODO 4
}


// ---------------------------------------------------------------------------
//  ข้อ 5 — LINQ: Where + Select
//  คืนรายชื่อ "คำ" (Term) ของ mistake ที่เป็นประเภท Listening เท่านั้น
//  ผลลัพธ์ที่ต้องได้: hola, hola, agua   (เรียงตามลำดับเดิมในลิสต์)
//  ใบ้: .Where(m => ...).Select(m => ...).ToList()
// ---------------------------------------------------------------------------
static List<string> ListeningTerms(List<Mistake> all)
{
    return new List<string>();   // TODO 5
}


// ---------------------------------------------------------------------------
//  ข้อ 6 — LINQ: GroupBy + นับจำนวน
//  คืน Dictionary ว่าแต่ละ "คำ" ผิดไปกี่ครั้ง
//  ผลลัพธ์: hola=3, agua=2, gracias=1
//  ใบ้: .GroupBy(m => m.Term).ToDictionary(g => g.Key, g => g.Count())
// ---------------------------------------------------------------------------
static Dictionary<string, int> CountByTerm(List<Mistake> all)
{
    return new Dictionary<string, int>();   // TODO 6
}


// ---------------------------------------------------------------------------
//  ข้อ 7 — LINQ เต็มสูตร  (ข้อนี้คือของจริงที่จะใช้ใน Phase 2)
//  คืน "คำที่ผิดบ่อยที่สุด" N อันดับแรก เรียงจากมากไปน้อย
//  ผลลัพธ์เมื่อ n=2:  [ MistakeCount("hola", 3), MistakeCount("agua", 2) ]
//  ใบ้: GroupBy -> Select(g => new MistakeCount(g.Key, g.Count())) -> OrderByDescending -> Take -> ToList
// ---------------------------------------------------------------------------
static List<MistakeCount> TopMistakes(List<Mistake> all, int n)
{
    return new List<MistakeCount>();   // TODO 7
}


// ---------------------------------------------------------------------------
//  ข้อ 8 — กรองตามวันที่  (เตรียมไว้ทำ analytics 7/21/30 วัน)
//  คืนจำนวน mistake ที่เกิดขึ้นภายใน "days" วันล่าสุด นับจาก today (รวมวันนี้)
//  เมื่อ days=7 จาก 2026-07-20  ต้องได้ 5  (ตัดตัวที่เป็นวันที่ 2026-06-01 ออก)
//  ใบ้: หาวันเริ่มต้นด้วย today.AddDays(-(days - 1)) แล้วใช้ .Count(m => ...)
// ---------------------------------------------------------------------------
static int CountWithinDays(List<Mistake> all, DateOnly today, int days)
{
    return 0;   // TODO 8
}


// ---------------------------------------------------------------------------
//  ข้อ 9 — record เทียบเท่ากันด้วย "ค่า"
//  สร้าง MistakeCount สองตัวที่มีค่าเหมือนกันเป๊ะ แล้วคืนผลการเปรียบเทียบด้วย ==
//  ข้อนี้ต้องได้ true — ถ้าเป็น class ธรรมดาจะได้ false
//  ใบ้: สร้าง 2 ตัวด้วย new MistakeCount("hola", 3) แล้ว return a == b;
// ---------------------------------------------------------------------------
static bool RecordsAreEqualByValue()
{
    return false;   // TODO 9
}


// ---------------------------------------------------------------------------
//  ข้อ 10 — implement interface
//  ทำให้คลาส SimpleAdvisor ข้างล่าง (ท้ายไฟล์) ทำงานได้ ให้ผลเหมือนข้อ 4
//  ** เลื่อนลงไปแก้ที่คลาส SimpleAdvisor ท้ายไฟล์ **
//
//  หมายเหตุ: เรียก AdviceFor ของข้อ 4 จากในคลาสไม่ได้ เพราะมันเป็น local function
//  ที่อยู่ในสโคปของโค้ดด้านบนเท่านั้น — คลาสมองไม่เห็น ต้องเขียน switch ใหม่ในคลาส
//  (ในโปรเจกต์จริงเราจะไม่เจอปัญหานี้ เพราะทุกอย่างอยู่ในคลาสตั้งแต่แรก)
// ---------------------------------------------------------------------------


// ###########################################################################
// #                    ส่วนตรวจคำตอบ — ห้ามแก้ตั้งแต่ตรงนี้ลงไป              #
// ###########################################################################

int passed = 0, total = 0;

void Check(string name, bool ok, string? got = null)
{
    total++;
    if (ok)
    {
        passed++;
        Console.WriteLine($"  OK   {name}");
    }
    else
    {
        Console.WriteLine($"  ..   {name}{(got is null ? "" : $"   <- ได้: {got}")}");
    }
}

Console.WriteLine();
Console.WriteLine("=== C# Warm-up ===");
Console.WriteLine();

Check("ข้อ 1  Describe", Describe(hola) == "hola = สวัสดี (4 ตัวอักษร)", Describe(hola));

Check("ข้อ 2  SafeNotes (มีโน้ต)", SafeNotes(agua) == "เพศหญิงแต่ใช้ el", SafeNotes(agua));
Check("ข้อ 2  SafeNotes (ไม่มีโน้ต)", SafeNotes(hola) == "ไม่มีโน้ต", SafeNotes(hola));

Check("ข้อ 3  NoteLength (มีโน้ต)", NoteLength(agua) == 16, $"{NoteLength(agua)}");
Check("ข้อ 3  NoteLength (ไม่มีโน้ต)", NoteLength(hola) is null, $"{NoteLength(hola)}");

Check("ข้อ 4  AdviceFor(Spelling)", AdviceFor(MistakeType.Spelling) == "ลองเขียนมือ 5 รอบ");
Check("ข้อ 4  AdviceFor(Listening)", AdviceFor(MistakeType.Listening) == "ฟังซ้ำแบบไม่ดูตัวหนังสือ");
Check("ข้อ 4  AdviceFor(Grammar)", AdviceFor(MistakeType.Grammar) == "ทบทวนตามปกติ");

Check("ข้อ 5  ListeningTerms",
    ListeningTerms(mistakes).SequenceEqual(new[] { "hola", "hola", "agua" }),
    string.Join(", ", ListeningTerms(mistakes)));

var counts = CountByTerm(mistakes);
Check("ข้อ 6  CountByTerm",
    counts.Count == 3 && counts.GetValueOrDefault("hola") == 3
                      && counts.GetValueOrDefault("agua") == 2
                      && counts.GetValueOrDefault("gracias") == 1,
    string.Join(", ", counts.Select(kv => $"{kv.Key}={kv.Value}")));

var top = TopMistakes(mistakes, 2);
Check("ข้อ 7  TopMistakes",
    top.SequenceEqual(new[] { new MistakeCount("hola", 3), new MistakeCount("agua", 2) }),
    string.Join(", ", top));

Check("ข้อ 8  CountWithinDays(7)", CountWithinDays(mistakes, today, 7) == 5,
    $"{CountWithinDays(mistakes, today, 7)}");
Check("ข้อ 8  CountWithinDays(60)", CountWithinDays(mistakes, today, 60) == 6,
    $"{CountWithinDays(mistakes, today, 60)}");

Check("ข้อ 9  record เท่ากันด้วยค่า", RecordsAreEqualByValue());

IAdvisor advisor = new SimpleAdvisor();
Check("ข้อ 10 SimpleAdvisor",
    advisor.Advise(MistakeType.Listening) == "ฟังซ้ำแบบไม่ดูตัวหนังสือ",
    advisor.Advise(MistakeType.Listening));

Console.WriteLine();
Console.WriteLine($"  ผ่าน {passed}/{total}");
Console.WriteLine(passed == total ? "  ครบแล้ว พร้อมไป Phase 1" : "  ยังเหลืออยู่ ลองต่อ");
Console.WriteLine();


// ###########################################################################
// #  ประกาศ type — อ่านเป็นตัวอย่าง syntax ได้ ไม่ต้องแก้ (ยกเว้นข้อ 10)     #
// ###########################################################################

// enum: เบื้องหลังคือ int เรียงจาก 0
enum MistakeType
{
    Spelling,
    Meaning,
    Listening,
    Grammar
}

// class: มีตัวตน เทียบเท่ากันเมื่อเป็น object ตัวเดียวกัน
//   required = ต้องใส่ตอนสร้าง ไม่งั้น compile ไม่ผ่าน
//   init     = ใส่ได้ตอนสร้างเท่านั้น หลังจากนั้นแก้ไม่ได้
//   string?  = เป็น null ได้
class VocabEntry
{
    public required string Term { get; init; }
    public required string Translation { get; init; }
    public string? Notes { get; set; }
}

class Mistake
{
    public required string Term { get; init; }
    public required MistakeType Type { get; init; }
    public required DateOnly OccurredOn { get; init; }
}

// record: เป็นก้อนค่า ค่าเท่ากัน = เท่ากัน
//   บรรทัดเดียวนี้ได้ constructor + property + Equals + GetHashCode + ToString ครบ
record MistakeCount(string Term, int Count);

interface IAdvisor
{
    string Advise(MistakeType type);
}

// ---- ข้อ 10: แก้ตรงนี้ ----
// ใบ้: เขียน switch expression แบบเดียวกับข้อ 4 ไว้ในเมธอด Advise
//      ถ้าเมธอดมีแค่ return บรรทัดเดียว เขียนย่อด้วย => ได้ ไม่ต้องมีปีกกา:
//          public string Advise(MistakeType type) => type switch { ... };
class SimpleAdvisor : IAdvisor
{
    public string Advise(MistakeType type)
    {
        return "";   // TODO 10
    }
}
