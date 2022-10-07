# Git Cheatsheet

## List branches

#### List only local branches

```bash
git branch
```

#### List only remote branches

```bash
git branch -r
```

#### List remote and local branches

```bash
git branch -a
```

## Delete branch

#### Delete local branch

```bash
git branch -d branch-name-goes-here
```

#### Delete remote branch

```bash
git push origin --delete branch-name-goes-here
```

## Create branch and push to origin

```bash
git checkout -b branch-name-goes-here
git push -u origin branch-name-goes-here
```

## Display commit logs

#### Display commits on single line with graph of commits on left

```bash
git log --oneline --graph
```

#### Display commits to specific branch (you ARE on branch)

```bash
git log master..
```

#### Display commits to specific branch (you ARE NOT on branch)

```bash
git log master..branch-name-goes-here
```

#### List all local unpushed commits

```bash
git log --branches --not --remotes
```

#### Display previous unpushed commit

```bash
git log origin/master..HEAD
```

## Display commit count by user

```bash
git shortlog -s -n
```

## Manage .gitconfig

#### Locate .gitconfig on Windows

```bash
cd ~
ls -alrt
```

#### Open .gitconfig on Windows

```bash
start ~/.gitconfig
```

#### Add alias to .gitconfig

```bash
git config --global alias.st status
```

#### Add alias containing a space or command line argument to .gitconfig 

```bash
git config --global alias.ci 'commit -v'
```

#### Set git to only push to branch you are on

```bash
git config --global push.default current
```

## Undo commit(s)

#### Undo the last commit

```bash
git reset --hard HEAD^
```

#### Undo the last two commits

```bash
git reset --hard HEAD~2
```

#### Undo then redo a commit

```bash
git reset HEAD~

# make the desired edits

git add .
git commit -c ORIG_HEAD
```

## Rebase on master and update branch with changes from master

```bash
git checkout master && git pull && git checkout branch-name-goes-here && git rebase master
```

## Reset branch to state prior to failed merge

```bash
git reset --merge
```

## Edit message of unpushed commit

```bash
git commit --amend -m 'new message goes here'
```

## Add an existing project to an new repository

1. Create a new repository in GitHub by clicking the `+` symbol in the top right corner and selecting `New Repository`.

2. Name the repository and initialize it without a README or .gitignore file by clicking the `Create repository` button.

3. In the Finder, locate the existing project's `.git` directory and open the file named `config`. The `url` value under `[remote "origin"]` needs to match the `url` of the new repository you've just created.

4. This can be achieved by running the following commands:

```
$ git remote set-url origin {new-repos-ssh}
$ git pull --rebase
```

5. Now set the master branch of the existing project to match the master branch of the new repository and push the project to its new repository:

```
$ git branch --set-upstream-to=origin/master master
$ git pull --rebase
$ git push
```
