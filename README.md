# C# File Handling – Complete Notes
### Somali & Easy English Explanation

---

## 1. What is File Handling?

**File Handling** waa habka uu program-ku u sameeyo, u furo, u akhriyo, wax ugu qoro, wax ugu daro, una tirtiro files.

A file wuxuu kaydin karaa xog si dib loogu isticmaalo maalmo ama waqti dambe, xitaa marka program-ka la xiro.

**Example:**
- `students.txt` – wuxuu kaydin karaa magacyada ardayda.
- `notes.txt` – wuxuu kaydin karaa qoraallo.
- `report.doc` – wuxuu kaydin karaa document, laakiin habka TXT ee casharkan si toos ah uma maamulo qaabka DOC.

> **Important:** `StreamWriter` iyo `StreamReader` waxay si fudud ula shaqeeyaan text files sida `.txt`. DOC/DOCX waa document formats leh qaab-dhismeed gaar ah; laguma maamulo sidii plain text file haddii la doonayo in formatting-ka la ilaaliyo.

### Why do we use File Handling?
1. To save data for later use – xogta mustaqbalka loo kaydiyo.
2. To read saved information – xog hore loo kaydiyey loo akhriyo.
3. To update files – xog cusub loogu daro.
4. To delete unnecessary files – files aan loo baahnayn loo tirtiro.

---

## 2. The Two Important Classes

C# File Handling casharkan wuxuu si gaar ah u isticmaalaa laba class:

### A. StreamWriter Class

`StreamWriter` waxaa loo isticmaalaa **writing** iyo **appending** text gudaha file.

- **Writing:** xog ayuu file ku qoraa.
- **Appending:** xog cusub ayuu ku daraa dhammaadka file-ka.

Example:

```csharp
using System.IO;

StreamWriter sw = new StreamWriter("students.txt");

sw.WriteLine("Abdullahi");
sw.Close();
```

Sharaxaad:
- `StreamWriter` – class-ka wax ku qora file.
- `sw` – magaca object-ka.
- `new StreamWriter(...)` – wuxuu furaa ama abuuraa file si wax loogu qoro.
- `WriteLine()` – wuxuu qoraa qoraalka kadibna wuxuu u gudbaa line cusub.
- `Close()` – wuxuu xiraa file-ka.

### B. StreamReader Class

`StreamReader` waxaa loo isticmaalaa **reading** – akhrinta xogta ku jirta file.

Example:

```csharp
using System.IO;

StreamReader sr = new StreamReader("students.txt");

string data = sr.ReadToEnd();

Console.WriteLine(data);

sr.Close();
```

Sharaxaad:
- `StreamReader` – class-ka wax ka akhriya file.
- `sr` – magaca object-ka.
- `ReadToEnd()` – wuxuu akhriyaa dhammaan qoraalka file-ka.
- `Console.WriteLine()` – wuxuu natiijada soo bandhigaa.
- `Close()` – wuxuu xiraa file-ka.

---

## 3. Every File Has Three Main Processes

File Handling wuxuu leeyahay saddex marxaladood:

### Step 1: Open the File

**Open = Creating a connection between the file and the program.**

Af-Soomaali: Waa in program-ku furo file-ka si uu ula shaqeeyo.

Examples:
- `File.CreateText()` – abuura file cusub oo u fura writing.
- `File.AppendText()` – fura file si xog loogu daro dhammaadkiisa.
- `File.OpenText()` – fura file si loo akhriyo.

### Step 2: Process the File

**Process = Performing an operation on the file.**

Af-Soomaali: Waa hawsha file-ka lagu qabanayo.

Waxaa ka mid ah:
- Writing – qoraal gelin.
- Reading – xog akhrin.
- Appending – xog cusub ku darid.
- Deleting – file tirtirid.

### Step 3: Close the File

**Close = Disconnecting the file from the program.**

Af-Soomaali: Marka shaqada la dhammeeyo, file-ka waa in la xiraa si resources-ka loo sii daayo, xogtana si sax ah loo kaydiyo.

Example:

```csharp
sw.Close();
sr.Close();
```

**Recommended method: `using`**

`using` wuxuu file-ka si automatic ah u xiraa marka block-ku dhammaado, xitaa haddii exception dhaco.

```csharp
using (StreamWriter sw = File.CreateText("notes.txt"))
{
    sw.WriteLine("Hello");
} // File-ka halkan ayuu automatic ugu xirmayaa.
```

---

## 4. OPEN THE FILE – Creating or Opening a File

### A. Create a New File – `File.CreateText()`

Waxaa loo isticmaalaa in la abuuro text file cusub.

```csharp
using System.IO;

using (StreamWriter sw = File.CreateText("test.txt"))
{
    // File cusub ayaa la sameeyay.
}
```

**Explanation:**
- `File` – class-ka file operations.
- `CreateText()` – abuura file qoraal ah.
- `StreamWriter` – waxaa loo isticmaalaa in file-ka wax lagu qoro.

> **Important:** Haddii file hore u jiray oo isla magacaas leh, `CreateText()` wuxuu tirtirayaa content-kii hore kadibna file-ka dib ayuu u abuuraa. Ka taxaddar xogta muhiimka ah.

### B. Append a File – `File.AppendText()`

Waxaa loo isticmaalaa in xog cusub lagu daro dhammaadka file hore.

```csharp
using (StreamWriter sw = File.AppendText("test.txt"))
{
    sw.WriteLine("New information");
}
```

**Explanation:**
- `AppendText()` – wuxuu file-ka u furaa in xog lagu daro.
- Xogtii hore ma tirtirayo.
- `WriteLine()` – wuxuu qoraalka cusub geliyaa line cusub.

Haddii file-ku uusan jirin, `AppendText()` wuu abuuri karaa.

### C. Read a File – `File.OpenText()`

Waxaa loo isticmaalaa in file loo furo reading.

```csharp
using (StreamReader sr = File.OpenText("test.txt"))
{
    string data = sr.ReadToEnd();
    Console.WriteLine(data);
}
```

**Explanation:**
- `OpenText()` – wuxuu file-ka u furaa reading.
- `StreamReader` – wuxuu akhriyaa xogta.
- `ReadToEnd()` – wuxuu akhriyaa dhammaan qoraalka.

---

## 5. PROCESS THE FILE

### 5.1 Writing a File – `Write()` and `WriteLine()`

Writing waxaa loo isticmaalaa in qoraal lagu kaydiyo file.

#### `Write()`

Wuxuu qoraa text, laakiin si automatic ah uma bilaabo line cusub.

```csharp
using (StreamWriter sw = File.CreateText("test.txt"))
{
    sw.Write("Hello ");
    sw.Write("Student");
}
```

File content:

```text
Hello Student
```

#### `WriteLine()`

Wuxuu qoraa text kadibna wuxuu bilaabaa line cusub.

```csharp
using (StreamWriter sw = File.CreateText("test.txt"))
{
    sw.WriteLine("First line");
    sw.WriteLine("Second line");
}
```

File content:

```text
First line
Second line
```

**Difference:**
- `Write()` – qoraalka wuxuu ku sii wadaa isla line-ka.
- `WriteLine()` – qoraalka kadib wuxuu u gudbaa line cusub.

### 5.2 Reading a File

C# wuxuu leeyahay dhowr hab oo file loo akhriyo.

#### A. `Read()`

`Read()` wuxuu akhriyaa hal character markiiba. Wuxuu soo celiyaa integer-ka character-ka, wuxuuna soo celiyaa `-1` marka dhammaadka file-ka la gaaro.

```csharp
using (StreamReader sr = File.OpenText("test.txt"))
{
    int character;

    while ((character = sr.Read()) != -1)
    {
        Console.Write((char)character);
    }
}
```

Sharaxaad:
- `sr.Read()` – wuxuu akhriyaa hal character.
- `while` – wuxuu ku celceliyaa inta characters ay jiraan.
- `-1` – wuxuu tilmaamayaa in dhammaadka file-ka la gaaray.
- `(char)character` – integer-ka wuxuu u beddelaa character.

#### B. `ReadLine()`

`ReadLine()` wuxuu akhriyaa hal line markiiba.

```csharp
using (StreamReader sr = File.OpenText("test.txt"))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
```

Sharaxaad:
- `ReadLine()` – wuxuu akhriyaa hal sadar.
- `line` – wuxuu kaydiyaa sadarka la akhriyey.
- `null` – wuxuu tilmaamayaa in line kale uusan jirin.
- `while` – wuxuu akhriyaa dhammaan lines-ka ilaa dhammaadka file-ka.

#### C. `ReadToEnd()`

`ReadToEnd()` wuxuu akhriyaa dhammaan qoraalka file-ka hal mar, adigoon loop qorin.

```csharp
using (StreamReader sr = File.OpenText("test.txt"))
{
    string data = sr.ReadToEnd();

    Console.WriteLine(data);
}
```

Sharaxaad:
- Wuxuu akhriyaa dhammaan content-ka.
- Wuxuu ku kaydiyaa variable-ka `data`.
- Loop looma baahna.
- Waa hab fudud marka aad rabto dhammaan qoraalka.

#### D. `File.ReadAllText()`

`File.ReadAllText()` wuxuu akhriyaa dhammaan qoraalka file-ka isagoo aan u baahnayn inaad adigu samaysato `StreamReader`.

```csharp
string data = File.ReadAllText("test.txt");

Console.WriteLine(data);
```

Sharaxaad:
- `File.ReadAllText()` – wuxuu file-ka oo dhan u akhriyaa string.
- `data` – wuxuu kaydiyaa qoraalka oo dhan.
- Adigu ma qoreysid loop.
- Adigu ma qoreysid `Close()`; method-ku wuxuu maareeyaa furista iyo xirista file-ka.

> **Correction:** `ReadAllText()` ma aha method ka tirsan `String` class. Waa method ka tirsan `System.IO.File` class.

### Reading Methods – Quick Comparison

| Method | Waxa uu akhriyo | Loop |
|---|---|---|
| `Read()` | Hal character | Badanaa haa |
| `ReadLine()` | Hal line | Badanaa haa |
| `ReadToEnd()` | Dhammaan file-ka | Maya |
| `File.ReadAllText()` | Dhammaan file-ka | Maya |

---

## 6. EndOfStream Property

`EndOfStream` waa property ka tirsan `StreamReader`.

Waxay hubisaa in akhristuhu gaaray dhammaadka file-ka iyo in kale.

Waxay soo celisaa laba qiime:

- `True` – dhammaadka file-ka waa la gaaray.
- `False` – weli xog ayaa harsan.

Example:

```csharp
using (StreamReader sr = File.OpenText("test.txt"))
{
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();

        Console.WriteLine(line);
    }
}
```

Sharaxaad:
- `sr.EndOfStream` – wuxuu hubiyaa in dhammaadka la gaaray.
- `!` – macnaheedu waa NOT.
- `!sr.EndOfStream` – loop-ku wuu soconayaa inta aan dhammaadka la gaarin.
- `ReadLine()` – wuxuu akhriyaa line kasta.

**Remember:** `EndOfStream` waa property, ma aha method; sidaas darteed parentheses `()` lama raaciyo.

---

## 7. Delete a File – `File.Delete()`

`File.Delete()` waxaa loo isticmaalaa in file la tirtiro.

```csharp
using System.IO;

string path = "test.txt";

if (File.Exists(path))
{
    File.Delete(path);

    Console.WriteLine("File Deleted Successfully!");
}
else
{
    Console.WriteLine("File Not Found!");
}
```

Sharaxaad:
- `File.Exists()` – wuxuu hubiyaa in file-ku jiro.
- `File.Delete()` – wuxuu tirtiraa file-ka.
- `if` – wuxuu hubiyaa xaaladda.
- `else` – wuxuu shaqeeyaa haddii file-ku uusan jirin.

**Important:** Delete waa hawl tirtiraysa file-ka. Hubi magaca iyo meesha file-ku yaallo ka hor intaadan tirtirin.

---

## 8. Append a File – `Write()` and `WriteLine()`

Append wuxuu xog cusub ku daraa dhammaadka file-ka isaga oo ilaalinaya xogtii hore.

```csharp
using (StreamWriter sw = File.AppendText("test.txt"))
{
    sw.Write("New ");
    sw.WriteLine("Information");
}
```

Haddii file-ku hore u lahaa:

```text
Hello Student
```

Kadib Append, wuxuu noqonayaa:

```text
Hello Student
New Information
```

**Remember:**
- `File.CreateText()` – wuxuu abuuraa file; haddii uu jiro, content-kii hore wuu beddelaa.
- `File.AppendText()` – wuxuu ku daraa xog cusub dhammaadka file-ka.

---

## 9. Close the File – `Close()`

`Close()` waxaa loo isticmaalaa in la xiro StreamWriter ama StreamReader marka hawsha la dhammeeyo.

Example – StreamWriter:

```csharp
StreamWriter sw = new StreamWriter("test.txt");

sw.WriteLine("Hello");

sw.Close();
```

Example – StreamReader:

```csharp
StreamReader sr = new StreamReader("test.txt");

string data = sr.ReadToEnd();

sr.Close();
```

**Why Close the File?**
1. Wuxuu sii daayaa system resources.
2. Wuxuu dhammeeyaa isticmaalka file-ka.
3. Wuxuu caawiyaa in xogta writing-ka la kaydiyo si sax ah.

**Best Practice:** Isticmaal `using` si file-ka automatic loogu xiro.

---

## 10. Complete Console Program – Create, Write, Read, Append and Delete

Program-kan wuxuu isku darayaa hawlaha muhiimka ah ee casharka.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File name
        string path = "students.txt";

        // 1. CREATE AND WRITE
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine("Abdullahi");
            sw.WriteLine("Ahmed");
        }

        Console.WriteLine("File Created and Written!");

        // 2. APPEND
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine("Mohamed");
        }

        Console.WriteLine("New Data Appended!");

        // 3. READ
        using (StreamReader sr = File.OpenText(path))
        {
            string data = sr.ReadToEnd();

            Console.WriteLine("\nFile Content:");
            Console.WriteLine(data);
        }

        // 4. CHECK FILE
        if (File.Exists(path))
        {
            Console.WriteLine("File Exists!");
        }

        // 5. DELETE
        // Uncomment the next two lines if you want to delete the file.
        // File.Delete(path);
        // Console.WriteLine("File Deleted!");
    }
}
```

Expected output:

```text
File Created and Written!
New Data Appended!

File Content:
Abdullahi
Ahmed
Mohamed

File Exists!
```

---

## 11. Important Differences to Remember

| Function / Class | Purpose |
|---|---|
| `StreamWriter` | Writing and appending |
| `StreamReader` | Reading |
| `CreateText()` | Create a text file |
| `AppendText()` | Add text at the end |
| `OpenText()` | Open a text file for reading |
| `Write()` | Write without automatically starting a new line |
| `WriteLine()` | Write and start a new line |
| `Read()` | Read one character |
| `ReadLine()` | Read one line |
| `ReadToEnd()` | Read all remaining text |
| `ReadAllText()` | Read all text using `File` class |
| `EndOfStream` | Check whether the end has been reached |
| `File.Exists()` | Check whether a file exists |
| `File.Delete()` | Delete a file |
| `Close()` | Close the stream |
| `using` | Automatically dispose/close the stream |

---

## 12. Quick Revision Questions

Try answering these questions:

1. What is File Handling?
2. What is the purpose of `StreamWriter`?
3. What is the purpose of `StreamReader`?
4. Which method creates a new text file?
5. Which method appends data to a file?
6. Which method opens a file for reading?
7. What is the difference between `Write()` and `WriteLine()`?
8. What is the difference between `Read()` and `ReadLine()`?
9. What does `ReadToEnd()` do?
10. Is `ReadAllText()` a method of the String class or File class?
11. What is `EndOfStream`?
12. What does `True` mean in `EndOfStream`?
13. Which method deletes a file?
14. Why do we close a file?
15. What are the three main file processes?

### Short Answers

1. Managing files using a program.
2. Writing and appending data.
3. Reading data.
4. `File.CreateText()`.
5. `File.AppendText()`.
6. `File.OpenText()`.
7. `Write()` does not automatically start a new line; `WriteLine()` does.
8. `Read()` reads one character; `ReadLine()` reads one line.
9. Reads all remaining text.
10. `System.IO.File` class.
11. A property that checks whether the end of the stream is reached.
12. The end of the file has been reached.
13. `File.Delete()`.
14. To release resources and finish file access.
15. Open, Process, Close.

---

## 13. Final Summary

Remember these three main ideas:

**1. OPEN**
- `CreateText()`
- `AppendText()`
- `OpenText()`

**2. PROCESS**
- Writing: `Write()`, `WriteLine()`
- Reading: `Read()`, `ReadLine()`, `ReadToEnd()`, `ReadAllText()`
- Appending: `AppendText()`
- Deleting: `File.Delete()`

**3. CLOSE**
- `Close()`
- Or use `using` for automatic closing.

**The most important rule:**
- `StreamWriter` = Write / Append.
- `StreamReader` = Read.
- `File` = Create / Append / Open / Exists / Delete / ReadAllText.
