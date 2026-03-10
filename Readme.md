# APBD CW1

## Features
- `GetAverage(int[] grades)` - calculates the average grade for a student
- `GetMax(int[] values)` - returns the maximum value from an array

## Task 5 - Why was this merge not fast-forward?

A fast-forward merge is only possible when the target branch (`main`) has not diverged from the feature branch — i.e., `main` has no new commits since `feature-max` was created.

In this case, after `feature-max` was branched off, new commits were added directly to `main` (the README commit and the merge commit from `feature-average`). This means both branches diverged from their common ancestor.

Because `main` had its own independent commits, Git could not simply move the branch pointer forward — it had to create a **merge commit** to combine the two divergent histories. That is why `--no-ff` (no fast-forward) was used and a merge commit appears in the history.
