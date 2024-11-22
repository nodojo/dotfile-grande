# NPM Cheat Sheet

### Get help from the command line (*[npm-help](https://docs.npmjs.com/cli/help)*)
```bash
npm help                # show all available options
npm help {command}      # help for a specific command
npm {command} -h        # view the parameters for a command        
```

### Enable command auto-completion 
```bash
npm completion >> ~/.bashrc     # add this line to your .bashrc file
source ~/.bashrc                # reload .bashrc to enable

npm completion >> ~/.zshrc      # add this line to your .zshrc file
source ~/.zshrc                 # reload .zshrc to enable
```

### Working with [.npmrc files](https://docs.npmjs.com/cli/v8/configuring-npm/npmrc)
```bash
npm config edit --global        # open global .npmrc file using powershell
npm config ls -l                # list configs and origins (windows)
```

#### Typical .npmrc locations (windows)

- Global .npmrc:  `C:\Users\%username%\AppData\Roaming\npm\etc\npmrc`
- Per-user .npmrc:  `C:\Users\%username%\.npmrc`
- Built-in .npmrc:  `C:\Program Files\nodejs\node_modules\npm\npmrc`

### Install from various sources (*[npm-install](https://docs.npmjs.com/cli/install.html)*)
```bash
npm install                      # install all packages listed in package.json
npm i                            # alias for npm install

npm i . -g                       # verify package installs and works (before publish)

npm i --production               # install dependencies, omit devDependencies

npm i {package} --save-prod      # install package in dependencies
npm i {package} -P               # shorthand to install package in dependencies
npm i {package} --save-dev       # install package in devDependencies
npm i {package} -D               # shorthand to install package in devDependencies

# note: the order the package name and the flag are in does not effect the command

npm i --save-prod {package}      # install package in dependencies
npm i -P {package}               # shorthand to install package in dependencies
npm i --save-dev {package}       # install package in devDependencies
npm i -D {package}               # shorthand to install package in devDependencies

npm i {package}                  # install a single, specific package
npm i {package} --global         # install globally
npm i {package} -g               # shorthand to install globally
npm i {package}@{version}        # install a specific package version
npm i @{package}                 # scoped npm package

npm i user/repo                  # from a GitHub repo
npm i user/repo#branch           # from a specific branch in a repo
npm i /path/to/repo              # from a repo using absolute path

npm i ./file.tgz                 # local tarball file
npm i https://site.com/file.tgz  # tarball file via HTTP
```

### Uninstall packages (*[npm-uninstall](https://docs.npmjs.com/cli/uninstall)*)
```bash
npm uninstall {package}         # unistall local package
npm uninstall {package} -g      # unistall global package
```

### Test that a package has been properly installed
```bash
node
> require('package-name')    # output any logs / errors from package
> .exit                      # exit node cli
```

### Create a tarball file from a package (*[npm-pack](https://docs.npmjs.com/cli-commands/pack.html)*)
```bash
npm pack

# display report of what will be in the tarball file without actually doing anything
npm pack --dry-run
```

### Using development packages (*[npm-link](https://docs.npmjs.com/cli/link)*)
When developing packages you often want to try them in other projects or run them from any directory (if your application supports it). There’s no need to publish the package to the *[npm registry](https://docs.npmjs.com/using-npm/registry.html)* and install globally – just use:
```bash
cd /test-package
npm link                # global symlink created (in global node_modules)

cd /test-project
npm link helloworld     # install helloworld package via symlink (into project's node_modules)
```
from the package folder. This creates a symlink in the global folder for that package. You will see the reference when using:
```bash
npm list -g --depth=0

# alternate command
npm outdated -g
```
You can now run package from the command line or include it in any project with `require`. Alternatively, you also can declare dependencies by filepath in `package.json` like this:
```javascript
"dependencies": {
  "myproject": "file:../myproject/"
}
```
To refresh a package's symlink connection to a project, run:
```bash
npm rebuild -g
```

### Run scripts defined in package.json (*[npm-scripts](https://docs.npmjs.com/misc/scripts)*)
```javascript
// script examples
"scripts": {
    "test": "echo \"Error: no test specified\" && exit 1",
    "start": "node index.js",
    "echo-hello": "echo \"Hello\"",
    "echo-helloworld": "echo \"Helloworld\"",
    "echo-both": "npm run echo-hello && npm run echo-helloworld",
    "echo-both-in-parallel": "npm run echo-hello & npm run echo-helloworld",
    "echo-packagename": "echo $npm_package_name",
    "echo-myvariable": "echo $npm_package_config_myvariable",
    "echo-passargument": "npm run echo-packagename -- \"hello\"",
    "echo-pipedata": "cat ./package.json | jq .name > package-name.txt"
}
```
```bash
npm run                 # run all scripts
npm run {script-name}   # run a specific script
```

### Update version in package.json and create a git tag automatically (*[npm-version](https://docs.npmjs.com/cli/version)*)
```bash
npm version 1.2.3       # specify the new version (here it is 1.2.3.)
npm version patch       # increment version patch number

# increment patch, create commit message, %s will be replaced with the new version 
npm version patch -m "Upgrade to version %s"
```

### Keep npm updated (*[npm-rebuild](https://docs.npmjs.com/cli/rebuild)*)
```bash
npm -v                  # display npm version number
npm install -g npm      # update npm (if desired)
npm rebuild             # rebuild C++ addons (only on major version changes)
```

### Manage packages (*[npm-ls](https://docs.npmjs.com/cli/ls.html)*, *[npm-prune](https://docs.npmjs.com/cli-commands/prune.html)*, *[npm-dedupe](https://docs.npmjs.com/cli/dedupe)*, *[npm-cache](https://docs.npmjs.com/cli-commands/cache.html)*)
```bash
npm ls                  # list installed packages (extraneous = no longer referenced)
npm ls -g               # list globally installed packages
npm list                # alias for npm ls
npm list --depth=0      # output top-level-only packages (not sub-packages)

npm home {package}      # open a package's homepage
npm docs {package}      # open a package's GitHub repository
npm bugs {package}      # open a package's current list of issues

npm prune               # uninstall all extraneous packages
npm dedupe              # remove duplicate packages from node_modules

npm cache ls            # list packages in cache
npm cache clean -f      # clean npm cache
```

### Updating packages (*[npm-update](https://docs.npmjs.com/cli/update)*)
```bash
npm update              # update all packages, install missing referenced packages
npm update --dev        # update packages reference in devDependencies
npm update -g           # update global installed packages
npm update {package}    # update a specific package
```

### Configure dependency updates (triggered by `npm update`)
- *(default)* The `^` prefix prevents major version changes (allows minor and patch updates).
- The `~` prefix prevents major and minor version changes (allows patch updates).
- If no prefix is used, the package reference in package.json will never update on `npm update`.
```bash
npm config set save-prefix="~"      # set the default prefix to tilde
npm config set save-exact true      # set the default to use exact versions only
```
Alternatively, you can [npm-shrinkwrap](https://docs.npmjs.com/cli/shrinkwrap). This generates a `npm-shrinkwrap.json` file containing the specific versions of the dependencies you’re using. This file is used by default and will override `package.json` when running `npm install`.
```bash
npm shrinkwrap
```

### Locate outdated packages (*[npm-outdated](https://docs.npmjs.com/cli-commands/outdated.html)*)
```bash
npm outdated        # list outdated packages
npm outdated -g     # list outdated packages (including npm itself)
```

### Search published npm packages (*[npm-search](https://docs.npmjs.com/cli-commands/search.html)*)
```bash
npm search {package}    # packages being published to npm can't already exist
```

## Various Resources

*[Specifics of npm's package.json handling](https://docs.npmjs.com/files/package.json.html)*

*[Awesome npm](https://github.com/sindresorhus/awesome-npm)*, *[Awesome Node.js](https://github.com/sindresorhus/awesome-nodejs)*

*[Search packages by quality score](https://npms.io/)*, *[Search packages by Google ranking](http://anvaka.github.io/npmrank/online/)*

*[NPM 7 is now generally available -> breaking changes](https://github.blog/2021-02-02-npm-7-is-now-generally-available/#breaking-changes)*

*[How to find .npmrc file locations](https://weekendprojects.dev/posts/where-to-find-nprc-file-locations/)*

*[How to completely remove node.js from windows](https://www.geeksforgeeks.org/how-to-completely-remove-node-js-from-windows/)*

## Useful [npm Docs](https://docs.npmjs.com/)

*[cli commands](https://docs.npmjs.com/cli/v8/commands)*

*[configuring npm](https://docs.npmjs.com/cli/v8/configuring-npm)*

*[npm configuration](https://docs.npmjs.com/cli/v8/using-npm/config)*

*[npm scripts](https://docs.npmjs.com/cli/v8/using-npm/scripts)*
