# APBD CW1

## Features
- `GetAverage()` - returns average grade of all students
- `GetMax()` - returns the highest grade
- `GetMin()` - returns the lowest grade

## Task 5 - Why was this merge not fast-forward?

After `feature-max` was created, new commits were added to `main` as well. So both branches moved forward from the same point. Git couldn't just move the pointer, it had to create a merge commit to join them.

## Task 6 - Merge vs Rebase

With merge, both branch histories stay visible and a merge commit is created. You can see when branches split and joined.

With rebase, the feature branch commits get replayed on top of main so the history looks like everything was done in a straight line. After rebasing, the merge into main is just a fast-forward.

## Questions

**1. When does Git do a fast-forward and when does it create a merge commit?**

Fast-forward happens when the target branch has no new commits since the feature branch was created - git just moves the pointer forward. If both branches have new commits (diverged), git has to create a merge commit to combine them.

**2. What is the practical difference between merge and rebase?**

Merge keeps the real history including when things were branched off. Rebase makes the history cleaner/linear but rewrites commits. I'd use rebase for local cleanup before pushing and merge when integrating into main to keep track of what came from where.

**3. How was the conflict resolved in this repository?**

`feature-conflict` renamed the `sum` variable to `total` in `GetAverage`. On `main`, the same method was rewritten using LINQ. When merging, git didn't know which version to keep. I kept the LINQ version from `main` since it does the same thing in fewer lines.
