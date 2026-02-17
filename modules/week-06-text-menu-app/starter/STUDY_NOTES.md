# Week 6: Text Menu App - Study Notes

**Name:* Elyana Bekele*

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop is different from a while loop because it always runs at least one time before it checks the condition while, a while loop checks the condition before it runs. Do-while is best when is used to get an input from the user.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I used a do-while loop for the section that implements input validation. I used used it here because to keep the loop going until it lands on input thats vaild within the range I set.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while loop for the main menu, in-order to keep it looping until the user chooses option 6, which is the exit. The reason I did this is that it lets the user have multiple rounds of choosing different options without restarting every time.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I didn't use a for loop in this program because I felt like it wasn't necessary. For this program, the repetition happens based on the user's input, and for which do-while is best.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I created the helper method for input validation because it keeps the code neat and easier to read but it also avoids repeating TryParse and re-prompting logic.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I validated the menu choice (1-6) by using ReadIntInRange method to prompt the user for input within the range it was set. Then used do-while loop to make sure the value was within the set range.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I handled invalid inputs by using int.TryParse and also double.TryParse. So, if TryParse fails, then it would return false, but the loop doesn't end; it continues until the user enters a valid number.


## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used Trim, ToUpper, Split, Join, string.Formatting, to say a few.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: I used all four string methods, Equals with StringComparison, Substring, EndsWith, and IndexOf

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: The difference between string concatenation and interpolation is, string concatenation uses + to combine strings but interpolation uses $ with a variable inside of curly brace {}.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. I leared about how to use do-while
2. I learned how to use Split / Join
3. I also learned how to use PadLeft and PadRight
4. I learned to format and align
5. I learned about Contains

**Which loop felt most natural to use and why?**

Answer: I would say do-while because I read up on it a few times

## Time Spent

**Total time:** [6.5 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1.5 hours]
- String formatting: [1 hours]
- Testing and debugging: [1.5 hours]
- Writing documentation: [1.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging, because of misspells.

## Reflection

**What would you do differently next time?**

Answer: I would want to test each of the options step by step then to build it all at once.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using the different loops helped me improve my understanding because each one has it's own specific purpose depending on the type of repetition. For example, you use do-while for input, while for menu repetition, and "for" for counting iterations.
