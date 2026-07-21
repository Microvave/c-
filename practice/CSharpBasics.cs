#:property TreatWarningsAsErrors=false
#:property GenerateDocumentationFile=false
#:property EnforceCodeStyleInBuild=false

// ============================================================================
//  C# BASICS  —  ตอนที่ 1  (เริ่มจาก if)
// ============================================================================
//
//  วิธีใช้:
//      cd D:\wave\code\duolingo\practice
//      dotnet run CSharpBasics.cs
//
//  แก้เฉพาะบรรทัดที่เขียนว่า TODO ให้ ".." กลายเป็น "OK" ทีละข้อ
//  ทำครบแล้วค่อยไปต่อที่ CSharpWarmup.cs (ตอนที่ 2)
//
//  หมายเหตุสำหรับคนมาจาก Java:
//    - syntax if / for / while / switch เหมือน Java เกือบเป๊ะ
//    - ต่างที่ชื่อเมธอดขึ้นต้นตัวใหญ่:  s.Length ไม่ใช่ s.length()
//                                    s.ToUpper() ไม่ใช่ s.toUpperCase()
//
// ============================================================================


// --- ข้อ 1 — if / else ---
static bool IsPassing(int score)
{
    return score >= 60;
}


// --- ข้อ 2 — if / else if / else ---
static string Grade(int score)
{
    if (score >= 80)
    {
        return "ดีมาก";
    }
    else if (score >= 60)
    {
        return "ผ่าน";
    }
    return "ต้องทบทวน";
}


// --- ข้อ 3 — ternary ---
static int MinOf(int a, int b)
{
    int MinOf = a < b ? a : b;
    return MinOf;
}


// --- ข้อ 4 — modulo (%) กับ if ---
static string EvenOrOdd(int n)
{
    if (n % 2 == 0)
    {
        return "คู่";
    }
    return "คี่";
}


// --- ข้อ 5 — for loop ---
static int SumTo(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}


// --- ข้อ 6 — for loop + if + List ---
static List<int> EvenNumbers(int n)
{
    var result = new List<int>();
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            result.Add(i);
        }
    }
    return result;
}

// ---------------------------------------------------------------------------
//  ข้อ 7 — while loop
//  คืนจำนวนหลักของเลข n     (DigitCount(2026) = 4, DigitCount(7) = 1)
//  ใบ้:  หารด้วย 10 ไปเรื่อย ๆ จนเหลือ 0 แล้วนับรอบ
//        int หารด้วย int ใน C# จะปัดเศษทิ้งเสมอ  2026 / 10 = 202
//        ระวังลูปไม่รู้จบ ถ้าลืมเปลี่ยนค่า n ในลูป
// ---------------------------------------------------------------------------
static int DigitCount(int n)
{
    int count =0;
    while (n > 0)       // ← เงื่อนไข bool
    {
        count++;
        n = n / 10;     // ← ตรงนี้ที่ n เปลี่ยนค่าจริง
    }
    Console.WriteLine(count);
    return count;   
   
}


// ---------------------------------------------------------------------------
//  ข้อ 8 — foreach
//  คืนคำที่ยาวที่สุดในลิสต์  ถ้าลิสต์ว่างให้คืน ""
//  ใบ้:  foreach (var word in words) { ... }
//        เทียบความยาวด้วย word.Length  (ไม่ใช่ .length() แบบ Java)
//
//  ── ตัวอย่าง (โจทย์อื่น): หา "เลขมากสุด" ในลิสต์ ──
//     static int MaxOf(List<int> nums)
//     {
//         int best = 0;                       // ตัวเก็บผู้ชนะ นอกลูป
//         foreach (var x in nums)             // หยิบทีละตัว
//         {
//             if (x > best) { best = x; }     // เจอตัวใหญ่กว่า ก็อัปเดตผู้ชนะ
//         }
//         return best;
//     }
//     (ข้อ 8 ใช้แนวเดียวกัน แต่เทียบด้วย .Length และเก็บ "คำ" แทน "เลข")
// ---------------------------------------------------------------------------
static string LongestWord(List<string> words)
{
    return "";   // TODO 8
}


// ---------------------------------------------------------------------------
//  ข้อ 9 — foreach + if นับจำนวน
//  นับว่ามีกี่คำในลิสต์ที่ยาวเกิน minLength ตัวอักษร
//  ใบ้:  ตัวแปรนับ + foreach + if
//
//  ── ตัวอย่าง (โจทย์อื่น): นับว่ามี "เลขบวก" กี่ตัวในลิสต์ ──
//     static int CountPositive(List<int> nums)
//     {
//         int count = 0;                      // ตัวนับ นอกลูป
//         foreach (var x in nums)
//         {
//             if (x > 0) { count++; }         // เข้าเงื่อนไขเมื่อไหร่ นับเพิ่ม
//         }
//         return count;
//     }
//     (ข้อ 9 ใช้แนวเดียวกัน แต่เงื่อนไขเป็น word.Length > minLength)
// ---------------------------------------------------------------------------
static int CountLongerThan(List<string> words, int minLength)
{
    return 0;   // TODO 9
}


// ---------------------------------------------------------------------------
//  ข้อ 10 — switch statement (แบบดั้งเดิม เหมือน Java)
//  1 -> "จันทร์",  2 -> "อังคาร",  3 -> "พุธ",  อื่น ๆ -> "ไม่รู้จัก"
//  ใบ้:  switch (day) { case 1: return "จันทร์"; ... default: return "ไม่รู้จัก"; }
//        ถ้า case ลงท้ายด้วย return ไม่ต้องใส่ break
//
//  ── ตัวอย่าง (โจทย์อื่น): แปลงสีไฟจราจรเป็นคำสั่ง ──
//     static string TrafficAction(string color)
//     {
//         switch (color)
//         {
//             case "red":    return "หยุด";
//             case "yellow": return "ชะลอ";
//             case "green":  return "ไปได้";
//             default:       return "ไม่รู้จัก";
//         }
//     }
//     (ข้อ 10 ใช้แนวเดียวกัน แต่ case เป็นตัวเลข 1/2/3)
// ---------------------------------------------------------------------------
static string DayName(int day)
{
    return "";   // TODO 10
}


// ---------------------------------------------------------------------------
//  ข้อ 11 — เมธอดของ string
//  รับข้อความที่อาจมีช่องว่างหน้า-หลัง  ให้ตัดช่องว่างออก ทำเป็นตัวพิมพ์ใหญ่ แล้วเติม !
//  Shout("  hola  ")  ->  "HOLA!"
//  ใบ้:  .Trim()  .ToUpper()  แล้วต่อ string ด้วย +  หรือใช้ $"{...}!"
//        เมธอดพวกนี้ "คืนค่าใหม่" ไม่ได้แก้ตัวเดิม จึงต้องรับค่ากลับมาเสมอ
//
//  ── ตัวอย่าง (โจทย์อื่น): ตัดช่องว่าง ทำตัวพิมพ์เล็ก แล้วเติม # ข้างหน้า ──
//     static string ToTag(string text)
//     {
//         string clean = text.Trim().ToLower();   // ต่อเมธอดกันได้ (method chaining)
//         return "#" + clean;                      // "  HELLO " -> "#hello"
//     }
//     (ข้อ 11 ใช้แนวเดียวกัน แต่ ToUpper() และเติม ! ต่อท้าย)
// ---------------------------------------------------------------------------
static string Shout(string text)
{
    return "";   // TODO 11
}


// ---------------------------------------------------------------------------
//  ข้อ 12 — Split + เข้าถึงสมาชิกด้วย index
//  รับชื่อเต็มคั่นด้วยช่องว่าง คืนอักษรแรกของแต่ละคำต่อกัน
//  Initials("wave suksawat")  ->  "WS"
//  ใบ้:  var parts = fullName.Split(' ');   ได้ array
//        parts[0] คือคำแรก   parts[0][0] คืออักษรตัวแรกของคำแรก
//        วนด้วย foreach แล้วต่อ string ไปเรื่อย ๆ  อย่าลืม ToUpper()
//
//  ── ตัวอย่าง (โจทย์อื่น): รับ "a,b,c" คั่นด้วย , แล้วต่ออักษรตัวสุดท้ายของแต่ละคำ ──
//     static string LastChars(string csv)
//     {
//         var parts = csv.Split(',');          // "cat,dog" -> ["cat", "dog"]
//         string acc = "";
//         foreach (var p in parts)
//         {
//             acc += p[p.Length - 1];          // p[ความยาว-1] = อักษรตัวสุดท้าย
//         }
//         return acc;                          // "cat,dog" -> "tg"
//     }
//     (ข้อ 12 ใช้แนวเดียวกัน แต่ Split(' '), เอาอักษร "ตัวแรก" p[0], และ ToUpper())
// ---------------------------------------------------------------------------
static string Initials(string fullName)
{
    return "";   // TODO 12
}


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

var words = new List<string> { "hola", "gracias", "si", "buenos" };

Console.WriteLine();
Console.WriteLine("=== C# Basics (ตอนที่ 1) ===");
Console.WriteLine();

Check("ข้อ 1  IsPassing(75)", IsPassing(75) == true, $"{IsPassing(75)}");
Check("ข้อ 1  IsPassing(42)", IsPassing(42) == false, $"{IsPassing(42)}");

Check("ข้อ 2  Grade(95)", Grade(95) == "ดีมาก", Grade(95));
Check("ข้อ 2  Grade(70)", Grade(70) == "ผ่าน", Grade(70));
Check("ข้อ 2  Grade(30)", Grade(30) == "ต้องทบทวน", Grade(30));

Check("ข้อ 3  MinOf(3, 9)", MinOf(3, 9) == 3, $"{MinOf(3, 9)}");
Check("ข้อ 3  MinOf(9, 3)", MinOf(9, 3) == 3, $"{MinOf(9, 3)}");

Check("ข้อ 4  EvenOrOdd(4)", EvenOrOdd(4) == "คู่", EvenOrOdd(4));
Check("ข้อ 4  EvenOrOdd(7)", EvenOrOdd(7) == "คี่", EvenOrOdd(7));

Check("ข้อ 5  SumTo(5)", SumTo(5) == 15, $"{SumTo(5)}");
Check("ข้อ 5  SumTo(100)", SumTo(100) == 5050, $"{SumTo(100)}");

Check("ข้อ 6  EvenNumbers(10)",
    EvenNumbers(10).SequenceEqual(new[] { 2, 4, 6, 8, 10 }),
    string.Join(",", EvenNumbers(10)));

Check("ข้อ 7  DigitCount(2026)", DigitCount(2026) == 4, $"{DigitCount(2026)}");
Check("ข้อ 7  DigitCount(7)", DigitCount(7) == 1, $"{DigitCount(7)}");

Check("ข้อ 8  LongestWord", LongestWord(words) == "gracias", LongestWord(words));
Check("ข้อ 8  LongestWord (ลิสต์ว่าง)", LongestWord(new List<string>()) == "", LongestWord(new List<string>()));

Check("ข้อ 9  CountLongerThan(3)", CountLongerThan(words, 3) == 3, $"{CountLongerThan(words, 3)}");
Check("ข้อ 9  CountLongerThan(6)", CountLongerThan(words, 6) == 1, $"{CountLongerThan(words, 6)}");

Check("ข้อ 10 DayName(2)", DayName(2) == "อังคาร", DayName(2));
Check("ข้อ 10 DayName(9)", DayName(9) == "ไม่รู้จัก", DayName(9));

Check("ข้อ 11 Shout", Shout("  hola  ") == "HOLA!", Shout("  hola  "));

Check("ข้อ 12 Initials", Initials("wave suksawat") == "WS", Initials("wave suksawat"));
Check("ข้อ 12 Initials (3 คำ)", Initials("a b c") == "ABC", Initials("a b c"));

Console.WriteLine();
Console.WriteLine($"  ผ่าน {passed}/{total}");
Console.WriteLine(passed == total
    ? "  ครบแล้ว ไปต่อที่ CSharpWarmup.cs ได้เลย"
    : "  ยังเหลืออยู่ ลองต่อ");
Console.WriteLine();
