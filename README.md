# DuoNotes

แอปจดคำศัพท์ที่ตอบผิดตอนเล่น Duolingo เพื่อเอามาทบทวนอย่างมีระบบ
พัฒนาด้วย **.NET 10 + ASP.NET Core** ตามแนวทาง **Clean Architecture 4 ชั้น**

## โครงสร้าง

```
src/
├── DuoNotes.Domain/          # entity, business rule (ไม่ reference อะไรเลย)
├── DuoNotes.Application/     # use case, DTO, interface ของ repository
├── DuoNotes.Infrastructure/  # EF Core, DbContext, migrations
└── DuoNotes.Api/             # endpoint, DI wiring
tests/
└── DuoNotes.Domain.Tests/
practice/                     # แบบฝึกหัด C# พื้นฐาน (ระหว่างเรียน)
```

ดูแผนงานเต็มได้ที่ [ROADMAP.md](ROADMAP.md)

## รันโปรเจกต์

```bash
dotnet build
dotnet test
```
