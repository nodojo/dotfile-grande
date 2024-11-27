# Git Cheat Sheet

## List branches

#### List only local branches

```
git branch
```

#### List only remote branches

```
git branch -r
```

#### List remote and local branches

```
git branch -a
```

## Delete branch

#### Delete local branch

```
git branch -d your-branch-name
```

#### Delete remote branch

```
git push origin --delete your-branch-name
```

## Create branch and set upstream remote

```
git checkout -b your-branch-name
git push -u origin your-branch-name
```

## Update branch with changes from master then rebase

```
git checkout master && git pull && git checkout your-branch-name && git rebase master
```

## Undo / Edit commit(s)

#### Undo the last commit

```
git reset --hard HEAD^
```

#### Undo a completed merge

```
git reset --merge HEAD~1
```

#### Undo the last two commits

```
git reset --hard HEAD~2
```

#### Force push local branch with reverted commit(s) to remote

```
git push origin +HEAD
```

#### Undo then redo a commit

```
git reset HEAD~

# make the desired edits

git add .
git commit -c ORIG_HEAD
```

#### Edit message of unpushed commit

```
git commit --amend -m 'new message goes here'
```

## Display logs

#### Display commits on single line with graph of commits on left

```
git log --oneline --graph
```

#### List all local unpushed commits

```
git log --branches --not --remotes
```

#### Display commit count by user

```
git shortlog -s -n
```

## Manage .gitconfig

#### List configs from global .gitconfig

```
git config --global --list
```

#### List configs and their origin(s)

```
git config --list --show-origin
```

#### Open .gitconfig in Notepad (Windows)

```
start ~/.gitconfig
```

#### Set config so you only push to branch on which you are working

```
git config --global push.default current
```

#### Add alias to .gitconfig

```
git config --global alias.st status                   # this example changes status to st (git status becomes git st)
```

#### Remove alias from .gitconfig

```
git config --global --unset alias.st
```

## Manage remotes

#### Change to a new remote origin (repository) using ssh

```bash
git remote set-url origin git@github.com:repo-name-goes-here
```

#### Verify update by displaying fetch and push origins

```
git remote -v
```

#### [Switching remote URLs from SSH to HTTPS](https://docs.github.com/en/get-started/getting-started-with-git/managing-remote-repositories)

```
git remote -v                                                        # list existing remotes
git remote set-url origin https://github.com/OWNER/REPOSITORY.git    # switch remote from ssh to https
git remote -v                                                        # verify remote has changed
```

## Manage tags

#### List local tags

```
git tag
```

#### Edit tag and create new tag containing your changes

1. Create a new branch from tag

```
git checkout -b your-new-branch-name existing-tag-name
```

2. Make and commit your edits

3. Create a new tag containing your changes

```
git tag -a -m 'new tag message goes here' your-new-tag-name
```

4. Push the newly created tag to the remote repository

```
git push origin your-new-tag-name
```

#### Delete local tag

```
git tag -d your-tag-name
```

#### Delete remote tag

```
git push --delete origin your-tag-name
```

## Remove untracked files from working tree

#### Display what will be removed

```bash
git clean -n
```

#### Remove untracked files

```bash
git clean -f
```

#### Remove untracked files and directories

```bash
git clean -f -d
```

## Stop tracking a file (if it existed before it was added to the .gitignore)

```bash
git rm file-name-goes-here --cached
git commit -m 'stopped tracking file-name-goes-here'
```

## Articles of Interest

- [How to navigate to the earliest commit in a repository](https://stackoverflow.com/a/49647826)

## Resources

- [Git CheatSheet (LeCoupa)](https://github.com/LeCoupa/awesome-cheatsheets/blob/master/tools/git.sh)
- [Bash CheatSheet (LeCoupa)](https://github.com/LeCoupa/awesome-cheatsheets/blob/master/languages/bash.sh)
