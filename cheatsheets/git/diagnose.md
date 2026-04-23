# [The Git Commands I Run Before Reading Any Code](https://piechowski.io/post/git-commands-before-reading-code/)

Ally Piechowski · Apr 8, 2026

Five git log commands that diagnose a new codebase before you open a single file: code churn hotspots, bus factor, bug clusters, and crisis patterns.

## What Changes the Most

Run this from `app/` or `src/`, otherwise lockfiles, changelogs, and generated code will dominate the list.

```bash
git log --format=format: --name-only --since="1 year ago" | sort | uniq -c | sort -nr | head -20
```

## Who Built This

Every contributor ranked by commit count.

```bash
git shortlog -sn --no-merges
```

## Where Do Bugs Cluster

Filter commits with bug-related keywords.

```bash
git log -i -E --grep="fix|bug|broken" --name-only --format='' | sort | uniq -c | sort -nr | head -20
```

## Is This Project Accelerating or Dying

Commit count by month, for the entire history of the repo.

```bash
git log --format='%ad' --date=format:'%Y-%m' | sort | uniq -c
```

## How Often Is the Team Firefighting

Revert and hotfix frequency.

```bash
git log --oneline --since="1 year ago" | grep -iE 'revert|hotfix|emergency|rollback'
```
