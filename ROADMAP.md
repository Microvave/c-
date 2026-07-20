# DuoNotes — Roadmap

แอปจดคำศัพท์ที่ตอบผิดตอนเล่น Duolingo เพื่อเอามาทบทวนอย่างมีระบบ

**Stack:** .NET 10 · ASP.NET Core Web API · EF Core + SQLite · xUnit
**สถาปัตยกรรม:** Clean Architecture 4 ชั้น (Domain / Application / Infrastructure / Api)

---

## Phase 0 — วางโครง

- [x] ไฟล์ config พื้นฐาน (`.editorconfig`, `.gitignore`, `Directory.Build.props`)
- [x] ติดตั้ง .NET 10 SDK (10.0.302)
- [x] สร้าง solution 5 โปรเจกต์ + เชื่อม reference — `dotnet build` ผ่าน 0 warning
- [x] ปักหมุดเวอร์ชัน package ที่มีช่องโหว่ (`Microsoft.OpenApi`, `SQLitePCLRaw.lib.e_sqlite3`)
- [ ] `git init` + commit แรก

## Phase 1 — MVP

- [ ] ออกแบบ entity ใน Domain: `VocabEntry`, `MistakeLog`, `MistakeType`
- [ ] `DuoNotesDbContext` + EF Core migration แรก (SQLite แบบไฟล์จริง ไม่ใช่ in-memory)
- [ ] `IVocabRepository` ใน Application + implementation ใน Infrastructure
- [ ] Endpoint: เพิ่มคำศัพท์, บันทึกว่าตอบผิด, ดูรายการทั้งหมด
- [ ] DTO แยกจาก entity (ห้าม return entity ออกทาง API)
- [ ] เทส domain rule ด้วย xUnit

## Phase 2 — Analytics

- [ ] คำที่ผิดบ่อยที่สุด (top N)
- [ ] สถิติย้อนหลัง 7 / 21 / 30 วัน
- [ ] สัดส่วนประเภทความผิด (ฟังผิด / จำความหมายไม่ได้ / สะกดผิด / ไวยากรณ์)
- [ ] คำที่ผิดซ้ำภายในช่วงเวลาสั้น ๆ = สัญญาณว่าต้องทบทวนด่วน

## Phase 3 — Spaced Repetition

- [ ] `ReviewState` + อัลกอริทึม SM-2
- [ ] `GET /review/today` ดึงคำที่ถึงกำหนดทบทวน
- [ ] บันทึกผลการทบทวนเพื่อคำนวณรอบถัดไป

## Phase 4 — Frontend

- [ ] หน้าจอจดคำผิดแบบเร็ว (ใช้ระหว่างเล่น Duolingo ได้จริง)
- [ ] หน้า dashboard แสดง analytics

## Phase 5 — ของแถม

- [ ] import จาก CSV
- [ ] export เป็น Anki deck
- [ ] Dockerfile
- [ ] GitHub Actions รัน `dotnet test` ทุก push
