#100DaysOfCode Learning Using C#

**Main target:** **_To Complete And Get Full Understanding Of The Fundamentals Of C# Programming Language_**

| Start Date    | End Date       |
| ------------- | -------------- |
| 5th Jan. 2021 | 15th Apr. 2021 |
| Tuesday       | Thursday       |

### Preparation Stages
| Start Date     | End Date       |
| -------------- | -------------- |
| 28th Dec. 2021 | 31st Dec. 2021 |
| Monday         | Thursday       |

## Goals

- Make habit of coding daily & learn everyday
- Learn C# for deeper knowledge
- Make some real world projects for my portfolio

## Log

### 28th Dec. 2020 | Monday

**Preparation Stage Day 1 Progress**:
**Setting Up Git And GitHub**
- Preparation stage to me was a challenge on it own, possibly gaining knowledge and understanding the basics of Git and GitHub.
  With few days to get involved were some free youtube videos below for Git and GitHub I took path in to earn such knowledge and understanding.

**Link to work:**
- Mosh Hamedani's [Git Tutorial For Beginners: Learn Git In 1 Hour](https://youtu.be/8JJ101D3knE)
- KodeKloud's [Git Basics For DevOps Beginner](https://youtu.be/Lr7sYCrhxE0)
- @en1tan [100DaysOfCode README Template](https://github.com/en1tan/100-days-csharp)

**New thing(s) learnt:**
- Git and Git commands.
- GitHub's Repository.
- SSH Key Authentication For GitHub.
 
**Thoughts:**
- First stage has been great so far as i got myself creating my first GitHub Repository and authenticating with SSH Key.
- Using the Git commands has been really helpful as in remotely working to my GitHub Repository as i hope to create, access and modify more files ahead of new projects created.
---


## Log

### 29th Dec. 2020 | Tuesday
**Preparation Stage Day 2 Progress**:
**Setting Up My Environment**
- I made few google researches and found Visual Studio Code as an ideal environment to start with preparation day 2.
- Installation went smooth with extra command line works for the installation of .NET onto my linux machine
- No much time wasted after .NET, very eager to start up getting through with basic tutorials on the Microsoft webpage
  and YES! FINALLY! the output was "Hello, World!".
- With VScode as my editor and following .NET tutorial, i edited the Program.cs file in the myApp dotnet folder,run it and gave same output as in the tutorial.
```c#
using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
        }
    }
}
```

**Link to work:**
- [VScode](https://code.visualstudio.com/)
- [.NET Linux Installation](https://docs.microsoft.com/en-gb/dotnet/core/install/linux)
- [Intro. To .NET Tutorials](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro)

**New thing(s) learnt:**
- Installed VScode.
- Installed Dotnet.
- Created and Run Console App Using below dotnet commands.
```
dotnet new console -o myApp
cd myApp
dotnet run
```
- Got familiar with some dotnet commands.

**Thoughts:**
- The feeling when you finally see the legendary "Hello, World!" on your terminal console and editing it to output other messages  should be a smile
  and yes, that was a big smile on my face as i finally made progress to tell the computer to output what i want.
  That alone is an inspiration to continue my challenges ahead.
---


## Log

### 30th Dec. 2020 | Wednesday
**Preparation Stage Day 3 Progress**:
**Learning To Style With MarkDown**
- I decided to make the readme file look attracting in reading by following up a tutorial made by a Boss friend @en1tan .
- Made corrections to this repository which was earlier giving me errors as i tried to push  the readme file to an unexisting repository though thinking i did create earlier.
- Successfully made a push to this main repository and continued styling with the styling.

**Link to work:**
- [Basics Of Github & Markdown By x1k](https://youtu.be/3GVRtOi-GIM)

**New thing(s) learnt:**
- Styling with md codes.
- Using other useful Git commands.

**Thoughts:**
- Luckily i made it by correcting the error which was preventing me from using some git commands.
- The styling is awesome now.
---


## Log

### 31st Dec. 2020 | Thursday
### Part 1

**Preparation Stage Day 4 Progress**:
**Setting Up Environment On Mobile**
- Final day of my preparation,i noticed there was the need to fully to bring coding to myself anywhere i am without my laptop.
  My mobile device should get the job done as it was not easy to setup C# programming environment on the mobile device, learnt it was something to do with coreclr failing to build on Android.
- The ideal choice was Mono which runs .NET on Android.
- Got my Termux set to install Mono by following guide made by @IanusInferus

**Link to work:**
- [Build Mono And MsBuild On Termux](https://github.com/IanusInferus/termux-mono)
- [Termux(Linux Environment And Android Terminal)](https://github.com/termux/termux-app)
- [C# Shell (C# Offline Compiler)](https://play.google.com/store/apps/details?id=com.radinc.csharpshell)

**New thing(s) learnt:**
- Installed Mono And MsBuild On Termux
- Built and Executed C# Programming files with commands like:
```
mono
msbuild
mcs
csc
```

**Thoughts:**
- Being able to build and run C# programs on my mobile device is a plus to keep the challenge running.
- There was another good app(linked above) natively supported to run C# programs on your mobile device,tried using and was good too though i will stick to Mono on Termux as my primary compiler and editor(nano/vim) on mobile device.
---


## Log

### 31st Dec. 2020 | Thursday
### Part 2

**Preparation Stage Day 4 Progress**:
**Styling Termux With Oh My Zsh**
- Working on the termux as far as git is concerned, found a git styling plugin that looks prettier on termux terminal.
  Though needs to install zsh.
```bash
pkg install zsh
```

### Preview

| ScreenShot |
| ---------- |
| ![url](images/oh_my_zsh_termux.png) |

**Link to work:**
- [oh-my-zsh](https://ohmyz.sh)
- Simple script to install oh-my-zsh in Termux.
  - [Termux OMZ](https://github.com/adi1090x/termux-omz/blob/master/README.md)

---



## Log

### 5th Jan. 2021 | Tuesday

**Challenge  Day 1 Progress**:
- A quick start to the introduction to C# programming.
 ( The C# Language itself and the .NET Platform.)
- How the C# codes get compiled and executed. 


**New thing(s) learnt:**
- Output codes of .NET programs are compiled to MSIL (Microsoft Intermediate Language)
  which are controlled executed by the CLR (Common Language Runtime)

**Thoughts:**
- This has helped me to Know and understand how C# codes are compiled and executed to run on most operating systems.

---



## Log

### 6th Jan. 2021 | Wednesday

**Challenge  Day 2 Progress**:
- Primitive types and declaring variables.
- Constant `const `  keyword and other reserved keywords used in C# programming.
- Rules to follow when declaring an identifier (variable).

**New thing(s) learnt
- Learnt the common used Primitive types in C# with their C# Type, .NET Type, Memory Allocation and their Ranges.
  | C# Type | .NET Type | Mermory Allocation(Byte) |
  |-------- | --------- | ---- |
  | byte    | Byte      | 1    |
  | short   | Int16     | 2    |
  | int     | Int32     | 4    |
  | long    | Int64     | 8    |
  | float   | Single    | 4    |
  | double  | Double    | 8    |
  | decimal | Decimal   | 16   |
  | char    | Char      | 2    |
  | bool    | Boolean   | 1    |

- A C# keyword can be used as an identifier by prefixing it with @
  - char @int;
- To be able to use a declared variable, it has to be assigned with a value.
  - int number = 45;
- C# types are converted to its .NET types equivalents during compilation.

**Thoughts:**
- Had a great day understanding both C# and .NET types which i spent much time getting their differences as at time taken for both to successfully compile.
  Maybe i will be noticing much difference in compilation time when i start coding alot.

---



## Log

### 7th Jan. 2021 | Thursday

**Challenge  Day 3 Progress**:
- Continueing with primitive types and variable declaration, today was very practical.

**New thing(s) learnt**:
- Overflow
- Declaring variables with and without the `var` keyword
- MinValue and MaxValue of data types

**Link to work:**
- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day3)

**Thoughts:**
- I had to exceed the Maximum Value of a specific data type and the compiler was brave enough to successfully compile my code without any errors but wasn't pleased with the output `0` and such output I learnt is called `overflow` .
- Instead of specifying data types for your variables, the `var` keyword is there to save you from wrong data type declaration on variables.
- Worry of overflow? Yes, C# compiler does not check overflows by default, it has the `checked` keyword to manually do that yourself.
- To stop this overflow which the compiler doesn't check by default, I used the `checked` keyword and got my program crashed with an exception thrown. No more worries of overflows again.
- Another to talk about is string(another topic to learn) formatting,really liked how to put everything together in quotes.
- By default, the c# compiler treats real numbers as double data types.
  Appending an `f` to your float data type variables fixes it as well as appending `m` to your decimal data type variables.

---



## Log

### 8th Jan. 2021 | Friday
**Challenge Day 4 Progress**:
**Type Conversion**

**New thing(s) learnt**
- Implicit type Conversion
- Explicit type Conversion (casting)
- Conversation between non compatible types

**Link to work:**
- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day4)

**Thoughts**
- Using the `try` and `catch` block, it was easy to handle exceptions throw by the compiler.
- When copying a byte value to an int , the runtime prefixes that value with a bunch of zeros which prevents data loss.
- `Convert` class and `Parse` were helpful in converting other non compatible types.
---



## Log

### 9th Jan. 2021 | Saturday
**Challenge Day 5 Progress**:
**Operators**

**New thing(s) learnt**
- Arithmetic Operators  `+` , `-` , `*` , `/` , `%`
 - Increment `++`
 - Decrement `--`
- Comparison Operators `==` , `<` ,
`>` , `<=` 
, `>=` , `!=`

**Link to work:**
- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/1b55369d1d47b5818d524bd72c629f330b5c8170/projects/day5)

**Thought**
- Two ways to use increment and decrement operators.
Either Prefixing as in `number++` or Postfixing as `++number`
---



## Log

### 10th Jan. 2021 | Sunday
**Challenge Day 6 Progress**:
**Continuation on Operators**

**New thing(s) learnt**
- Assignment `=` , `+=` , `-=` , `*=` , `/=`
- Logical `&&` , `||` , `!`

**Link to work:**
- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day6)

**Thought**
- Comparison and logical operators return `True` or `False` and are used in mostly `conditional statements` which i can't wait to get my skills to that level.
- Really excited so far with my progress.
---



## Log

### 11th Jan. 2021 | Monday
**Challenge Day 7 Progress**:
**String Concatenation**

**New thing(s) learnt**
- Using the arithmetic operator `+` on strings.

**Link to work:**
[Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day7)

**Thought**
- The `+` operator not just for arithmetic but can be used to combine strings together.
---



## Log

### 12th Jan. 2021 | Tuesday
**Challenge Day 8 Progress**:
**Reading User Input**

**New thing(s) learnt**
- Collecting and storing input data.
- `Console.ReadLine()` method.

**Link to work:**
[Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day8)

**Though**
- So far, i am able to interact with the console and retrieve data inputs as well as storing such data in a variable.
---



## Log

### 13th Jan. 2021 | Wednesday
**Challenge Day 9 Progress**:


**Converting User Input**
- Using some `System.Convert` class methods.


**New things learnt**
- `Convert.ToInt32()`
- `Convert.ToDouble()`
- `Convert.ToDecimal()`


**Link to work:**
- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day9)


**Thought**
- Numeric values from user input are also returned as characters of string by the `Console.ReadLine()` method.
- Arithmetic cannot be done on such returned values unless i typecast ReadLine with preferred Converting method.
---



## Log

### 14th Jan. 2021 | Thursday

**Challenge Day 10 Progress:***

**Intro. To Class**


**New thing(s) learnt:**

- Access Modifiers
- Class fields and properties
- Objects (Instances) of a class


**Link to work:**

- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day10)


**Thought:**

- We use the `new` keyword to create an instance from a class.
---



## Log

### 15th Jan. 2021 | Friday

**Challenge Day 11 Progess**

- Continuation of introduction to class.

**New thing(s) learnt:**

- Static Methods.


**Link to work:**

- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day11)


**Thought:**

- For static methods, we don't need to create any object of the class to be used.
---



## Log

### 16th Jan. 2021 | Saturday

**Challenge Day 12 Progess**

- Intro. To Array


**New Thing(s) Learnt:**

- Declaring Arrays
- Initializing Arrays
- Accessing Array Elements


**Link To Work:**

- [Project](https://www.github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day12)


**Thoughts:**
- Arrays are allocated memories during their declarations with the `new` keyword.
- Accessing elements of an array is done by using their specific array indexes starting from 0.
---



## Log

### 17th Jan. 2021 | Sunday

**Challenge Day 13 Progess**

- Strings


**New Thing(s) Learnt:**

- Creating strings.
  - Using string literal.
  - Using string concatenation.

**Link To Project:**

- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day13)


**Thought:**

- Strings are sequence of characters.
- Strings are enclosed in double quotes `" "`
- The `string` keyword is a class in the `System` namespace
---



## Log

### 18th Jan. 2021 | Monday

**Challenge Day 14 Progess**

- Strings Continuation


**New Thing(s) Learnt:**

- Creating strings.
  - Using string methods

**Link To Project:**

- [Project](https://github.com/coachadebi/100daysofcodingCsharp/tree/main/projects/day14)


**Thought:**

- Strings are immunatable.
