# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:Elyana Bekele**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: `File.ReadAllLines` returns a string array. I used it to read all the lines from the csc file and then split by commas then lastly create Habit objects.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: It's important to skip blank lines because they don't have data. If not skipped and attempted to split, it could possibly crash your program or cause errors.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: The purpose of `File.WriteAllLines` is to write all the lines to a file. The arguments it takes are, the file path and an array of strings to save.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: It turns each habit into a string, then puts the strings into an array in-order to be saved.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: It occours when the file doesn't exist or the file path is incorrect.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: This is Beacuse it can only catch the error we know, catching all erros can possibly hide other problems.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. Using LINQ Count()
2. Learning to build a menu and to costumize
3. Editing and Adding to files
**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part of this assignment was making sure the files and the most importantly the formatting were correct.

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 2 hours
- Implementing LoadHabits: 1 hours
- Implementing PrintHabits / PrintSummary: 1 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1 hours
- Testing and debugging: 30 hours
- Writing study notes: 30 hours

**Most time-consuming part:**

Answer: Understanding what to do and how to format correctly.
