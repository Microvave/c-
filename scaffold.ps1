# ============================================================
#  DuoNotes - สร้างโครง solution ทั้งหมด
#  รันครั้งเดียวหลังติดตั้ง .NET SDK เสร็จ:   .\scaffold.ps1
#  (ไฟล์นี้ใช้แล้วลบทิ้งได้ เก็บไว้เพื่อให้เห็นว่าโครงถูกสร้างมายังไง)
# ============================================================

$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot

Write-Host "`n=== 1. สร้าง solution และโปรเจกต์ทั้ง 5 ===" -ForegroundColor Cyan

# solution = ไฟล์ที่รวบรวมว่าโปรเจกต์ไหนบ้างอยู่ในระบบนี้ (คล้าย parent pom ที่มี <modules>)
dotnet new sln -n DuoNotes

# classlib = โปรเจกต์ที่ compile ออกมาเป็น .dll ไม่ได้รันเอง ใช้เป็น "ชั้น" ของสถาปัตยกรรม
dotnet new classlib -o src/DuoNotes.Domain
dotnet new classlib -o src/DuoNotes.Application
dotnet new classlib -o src/DuoNotes.Infrastructure

# webapi = โปรเจกต์ที่รันได้จริง มี web server (Kestrel) ในตัว - เทียบเท่า Spring Boot app
dotnet new webapi -o src/DuoNotes.Api

# xunit = โปรเจกต์เทส (เทียบเท่า JUnit)
dotnet new xunit -o tests/DuoNotes.Domain.Tests

# template classlib แถมไฟล์ Class1.cs เปล่า ๆ มาให้ - ไม่ได้ใช้ ลบทิ้ง
Remove-Item src/DuoNotes.Domain/Class1.cs, `
            src/DuoNotes.Application/Class1.cs, `
            src/DuoNotes.Infrastructure/Class1.cs -ErrorAction SilentlyContinue


Write-Host "`n=== 2. ลงทะเบียนทุกโปรเจกต์เข้า solution ===" -ForegroundColor Cyan

Get-ChildItem -Recurse -Filter *.csproj | ForEach-Object { dotnet sln add $_.FullName }


Write-Host "`n=== 3. เชื่อม project reference (หัวใจของ Clean Architecture) ===" -ForegroundColor Cyan
# กฎเดียว: ลูกศรชี้เข้าด้านในเสมอ ชั้นนอกรู้จักชั้นใน แต่ชั้นในห้ามรู้จักชั้นนอก
# Domain ไม่มีบรรทัดไหนที่มันเป็นตัวหน้า = ไม่รู้จักใครเลย = แกนกลางที่แท้จริง

dotnet add src/DuoNotes.Application    reference src/DuoNotes.Domain       # use case ต้องใช้คลาส MistakeLog
dotnet add src/DuoNotes.Infrastructure reference src/DuoNotes.Application  # ต้อง implement IVocabRepository
dotnet add src/DuoNotes.Api            reference src/DuoNotes.Application  # controller เรียก use case
dotnet add src/DuoNotes.Api            reference src/DuoNotes.Infrastructure # Program.cs ลงทะเบียน DI (Composition Root)
dotnet add tests/DuoNotes.Domain.Tests reference src/DuoNotes.Domain       # เทสมองเข้าไปดูโค้ดจริง


Write-Host "`n=== 4. ติดตั้ง NuGet package ===" -ForegroundColor Cyan
# ไม่ระบุเลขเวอร์ชัน ปล่อยให้ NuGet เลือกตัวล่าสุดที่เข้ากับ .NET ที่ลงไว้

# EF Core + provider ของ SQLite (เทียบเท่า Hibernate + JDBC driver)
dotnet add src/DuoNotes.Infrastructure package Microsoft.EntityFrameworkCore.Sqlite

# Design = เครื่องมือที่ dotnet-ef ใช้ตอนสร้าง migration ต้องอยู่ในโปรเจกต์ที่รันได้
dotnet add src/DuoNotes.Api package Microsoft.EntityFrameworkCore.Design


Write-Host "`n=== 5. ทดสอบว่า build ผ่านทั้งหมด ===" -ForegroundColor Cyan
dotnet build

Write-Host "`nเสร็จแล้ว! ลองรัน 'dotnet test' ต่อได้เลย" -ForegroundColor Green
