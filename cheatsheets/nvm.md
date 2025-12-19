# NVM Cheat Sheet

Display active Node version

```node
node --version
```

Install a Node version

```node
nvm install 20.18.0
```

Install latest stable Node version

```node
nvm install --lts
```

Select Node version to use

```node
nvm use 20.18.0
```

Set Node version as default (this persists the version between shell sessions)

```node
nvm alias default 20.18.0
```

List all remotely available Node versions

```node
nvm ls-remote
```

List all Node versions available locally (already installed on your machine)

```node
nvm ls
```

Remove a locally installed Node version

```node
nvm uninstall 20.18.0
```

