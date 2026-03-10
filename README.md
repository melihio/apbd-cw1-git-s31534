# APBD CW1

## Features
- `GetAverage(int[] grades)` - calculates the average grade for a student
- `GetMax(int[] values)` - returns the maximum value from an array
- `GetMin(int[] values)` - returns the minimum value from an array

## Task 5 - Why was this merge not fast-forward?

This merge was not fast-forward because `main` had new commits after `feature-max` was branched off. Since both branches diverged, Git could not simply move the pointer forward and had to create a merge commit instead.

## Task 6 - Merge vs Rebase

**Merge** preserves the full history of both branches and creates a merge commit, showing exactly when and how branches were combined. The history is non-linear.

**Rebase** rewrites the feature branch commits on top of `main`, producing a clean linear history with no merge commit. After rebasing, the merge into `main` becomes a fast-forward.
