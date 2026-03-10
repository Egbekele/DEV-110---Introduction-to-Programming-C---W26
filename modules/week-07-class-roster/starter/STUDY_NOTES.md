# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name: Elyana Bekele**

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays mean two arrays that both store similar data in the same index. For example, in this assignment both rosterNames and rosterCredits belong to the same student because they both have the same index.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: The purpose of count is to keep track of how many students are stored in the roster.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: I used count in loops when I needed to copy the roster and when printing. I used count in loops instead of using the full array length so the program only loops through the students that were added to the roster and ignores empty spaces in the array.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: I printed the class roster using a foreach loop by building an array of roster lines and then I used a foreach loop to print line by line.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: I sorted the roster while keeping names and credits aligned by copying the used part of the roster into new arrays and also using Array.Sort so the names and credits stay aligned.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Using a for loop
2. Using a foreach loop
3. Using a count
4. Using Array.Sort
5. Using switch cases more

**Which loop felt most natural to use and why?**

Answer: I would say for loop since we have been using it lately.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning the arrays/menu: [1 hours]
- Input validation: [1 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging always takes the most time because sometimes you misspell a couple things.

## Reflection

**What would you do differently next time?**

Answer: I would say maybe playing around with different ranges or adding more options to practice more.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: Using both for and foreach improved my understanding of arrays because for is helpful to use when you need indexes to access each array elements, and foreach is helpful when you need to go through each value.
