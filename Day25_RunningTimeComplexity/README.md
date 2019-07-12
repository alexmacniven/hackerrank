# Day 25 - Running Time and Complexity

**Challenge:** https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem

Today's challenge was to design an algorithm for evaluating a number as prime.
The algorithm also had to have a complexity of `O(√n)`.

Firstly I developed a brute force approach in `PrintPrime`.
This was a basic attempt at evaluating a number as prime by trying to divide the number `n` by each number less than it excluding 1.
Generally this worked great for smaller values, but as the values increased the running time become noticibly longer.

After some refreshing on the subject, I learnt that a if the square root of a number is prime than the number itself is prime.
This allows the optimised method `PrintPrimev2` with a complexity of `O(√n)` 🎉

## What I learnt
 - Constant, Logarithmic, Linear, Quadriatic complexities
 - Calculating complexity
 - C#'s System.Math.Sqrt