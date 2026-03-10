# APBD CW1

## Features
- `GetAverage(int[] grades)` - calculates the average grade for a student
- `GetMax(int[] values)` - returns the maximum value from an array

## Task 5 - Why was this merge not fast-forward?

This merge was not fast-forward because `main` had new commits after `feature-max` was branched off. Since both branches diverged, Git could not simply move the pointer forward and had to create a merge commit instead.
