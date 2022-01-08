2015 MacBook Pro Setup Steps


# System Preferences


## General

- Set `Appearance: Dark`

## Dock & Menu Bar

- Set `Position on screen: left`
- Check `Automatically hide and show the Dock`
- Uncheck `Show recent applications in Dock`

## Security & Privacy

- Change `Require password __ after sleep or screen saver begins` to `1 minute`
- Set `Allow apps downloaded from` to `App Store and identified developers`
- Turn FileVault On (makes sure SSD is securely encrypted)
- Turn Firewall On (extra security measure)

## Bluetooth

- check `Show Bluetooth in menu bar`

## Keyboard

- Uncheck `Correct spelling automatically`
- Uncheck `Capitalize words automatically`
- Uncheck `Add period with double-space`
- Uncheck `Use smart quotes and dashes`

## Trackpad

- Uncheck `Scroll direction: Natural`

## Mouse

- Uncheck `Scroll direction: Natural`

## Sharing

- Change computer name
- Make sure all file sharing is disabled

## Desktop & Screen Saver

- Set desktop background to persist after reboot
  - Open mission control and add a screen (should have two screens, Desktop1 and Desktop2)
  - Select the newly created screen (Desktop2)
  - Right click and select `Change Desktop Background...`
  - Set the image or color for the background and close System Preferences
  - Open mission control and close the screen Desktop1
  - Reboot and test

## Finder

Preferences
- General
  - Set `New finder windows show` to open in your home directory
- Sidebar
  - Check/Uncheck to customize sidebar items

Defaults
- Show path bar
```sh
defaults write com.apple.finder ShowPathbar -bool true
```
- Show status bar
```sh
defaults write com.apple.finder ShowStatusBar -bool true
```
- Show full path in Finder title
```sh
defaults write com.apple.finder _FXShowPosixPathInTitle -bool true
```
- Enable quit Finder with default shortcut
<kbd>Cmd</kbd> + <kbd>Q</kbd>
```sh
defaults write com.apple.finder QuitMenuItem -bool true && \
killall Finder
```

#### Icon Bounce
Global setting whether Dock icons should bounce when the respective application
demands your attention.
```sh
# Enable (Default)
defaults write com.apple.dock no-bouncing -bool true && \
killall Dock

# Disable
defaults write com.apple.dock no-bouncing -bool false && \
killall Dock
```

#### Set Protected Flag
This is equivalent to Finder "Locked" status.
```sh
# Disable (Default)
sudo chflags -R nouchg /path/to/file/or/folder

# Enable
sudo chflags -R uchg /path/to/file/or/folder
```

#### Toggle Folder Visibility in Finder
By default, the `~/Library` folder is hidden. You can easily show it again. The
same method works with all other folders.
```sh
# Hidden (Default)
chflags hidden ~/Library

# Visible
chflags nohidden ~/Library
```

#### Disable Sound Effects on Boot
```sh
sudo nvram SystemAudioVolume=" "
```

## User Defaults

- Show Library folder
```sh
chflags nohidden ~/Library
```
- Prevent left/right swipe through history in Chrome
```sh
defaults write com.google.Chrome AppleEnableSwipeNavigateWithScrolls -bool false
```
- Disable repeating keys by pressing and holding down keys
```sh
defaults write NSGlobalDomain ApplePressAndHoldEnabled -bool false
```
- Change the default folder for screenshots
  - Create a folder to store screenshots
  - example path: /Users/macuser/Desktop/desktop-folder/
```sh
mkdir -p /path/to/screenshots/
```
  - Then run the following command
```sh
defaults write com.apple.screencapture location /path/to/screenshots/ && killall SystemUIServer
```


# Xcode

[Xcode](https://developer.apple.com/xcode/) is an integrated development environment for macOS containing a suite of software development tools developed by Apple for developing software for macOS, iOS, watchOS and tvOS.

Download and install it from the App Store or from [Apple's website](https://developer.apple.com/xcode/).

Install Xcode command line tools:

```sh
xcode-select --install
```

Agree to Xcode license without opening the application

```sh
sudo xcodebuild -license
```

It'll prompt you to install the command line tools. Follow the instructions and you'll have Xcode and Xcode command line tools both installed.


# Homebrew

To install Homebrew run the following in a terminal:

```sh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install.sh)"
```

hit **Enter**, and follow the steps on the screen.

### Setting up your `PATH`

To make the Homebrew-installed programs available in your shell, you need to add
your Homebrew installation location to your `$PATH`. This is done for you already on
macOS 10.14 Mojave and newer. For older versions of macOS, do the following:

You change your path by adding `/usr/local/bin` to your `PATH` environment variable.
This can be done on a per-user basis by adjusting `PATH` in your `~/.bash_profile`.
To do this, run:

```sh
echo 'PATH="/usr/local/bin:$PATH"' >> ~/.bash_profile
```

(If you're using `zsh`, you should do this for `~/.zshrc` in addition to
`~/.bash_profile`.)

Alternatively, you can also insert `/usr/local/bin` before the first line of
`/etc/paths` to change the global default paths order, for all users and all
major shells. An admin password will be required if you modify the file.

Then, to be able to use `brew` you need to start a new terminal session. After that
you should make sure everything is working by running:

```sh
brew doctor
```

If everything is good, you should see no warnings, and a message that you are
"ready to brew!".


# Homebrew-Cask

### App Suggestions

```sh
brew install --cask \
    1password \
    docker \
    firefox \
    google-chrome \
    postman \
    slack \
    visual-studio-code \
    vlc
```

```sh
brew install --cask spectacle
```


# iTerm2

[iTerm2](http://www.iterm2.com/) is an open source replacement for Apple's Terminal. It's highly customizable and comes with a lot of useful features.

## Installation

Use [Homebrew](https://sourabhbajaj.com/mac-setup/Homebrew/) to download and install:

```sh
brew install --cask iterm2
```


# zsh

The Z shell (also known as `zsh`) is a Unix shell that is built on top of `bash`
(the default shell for macOS) with additional features. It's recommended to use
`zsh` over `bash`. It's also highly recommended to install a framework with
`zsh` as it makes dealing with configuration, plugins and themes a lot nicer.

We've also included an `env.sh` file where we store our aliases, exports, path
changes etc. We put this in a separate file to not pollute our main
configuration file too much. This file is found in the bottom of this page.

Install `zsh` using Homebrew:

```sh
brew install zsh
```

Now you should install a framework, we recommend to use [Oh My Zsh](https://github.com/robbyrussell/oh-my-zsh)
or [Prezto](https://github.com/sorin-ionescu/prezto). **Note that you should
pick one of them, not use both.**

The configuration file for `zsh` is called `.zshrc` and lives in your home
folder (`~/.zshrc`).

## Oh My Zsh

[Oh My Zsh](https://github.com/robbyrussell/oh-my-zsh) is an open source,
community-driven framework for managing your `zsh` configuration. It comes
with a bunch of features out of the box and improves your terminal experience.

Install Oh My Zsh:

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/robbyrussell/oh-my-zsh/master/tools/install.sh)"
```

The installation script should set `zsh` to your default shell, but if it
doesn't you can do it manually:

```sh
chsh -s $(which zsh)
```

## Clone theme

[https://github.com/bhilburn/powerlevel9k](bhilburn/powerlevel9k)

```sh
git clone https://github.com/bhilburn/powerlevel9k.git ~/.oh-my-zsh/custom/themes/powerlevel9k
```

[https://github.com/ryanoasis/nerd-fonts](ryanoasis/nerd-fonts)

```sh
git clone --depth 1 git@github.com:ryanoasis/nerd-fonts.git
cd nerd-fonts
./install.sh
```

### Configuration

The out-of-the-box configuration is usable but you probably want to customise
it to suit your needs. The [Official Wiki](https://github.com/robbyrussell/oh-my-zsh/wiki)
contains a lot of useful information if you want to deep dive into what you
can do with Oh My Zsh, but we'll cover the basics here.

To apply the changes you make you need to either **start new shell instance**
or run:

```sh
source ~/.zshrc
```

#### Plugins

Add plugins to your shell by adding the name of the plugin to the `plugin`
array in your `.zshrc`.

```sh
plugins=(git colored-man-pages colorize pip python brew osx zsh-syntax-highlighting zsh-autosuggestions)
```

You'll find a list of all plugins on the [Oh My Zsh Wiki](https://github.com/robbyrussell/oh-my-zsh/wiki/Plugins).
Note that adding plugins can cause your shell startup time to increase.

#### Themes

Changing theme is as simple as changing a string in your configuration file.
The default theme is `robbyrussell`. Just change that value to change theme,
and don't forget to apply your changes.

```sh
ZSH_THEME=pygmalion
```

You'll find a list of themes with screenshots on the
[Oh My Zsh Wiki](https://github.com/robbyrussell/oh-my-zsh/wiki/themes).


# Git and GitHub

What's a developer without [Git](http://git-scm.com/)? To install, run:

```sh
brew install git
```

When done, to test that it installed properly you can run:

```sh
git --version
```

And `which git` should output `/usr/local/bin/git`.

Next, we'll define your Git user (should be the same name and email you use for [GitHub](https://github.com/)):

```sh
git config --global user.name "Your Name Here"
git config --global user.email "your_email@youremail.com"
```

They will get added to your `.gitconfig` file.

To push code to your GitHub repositories, we will use the recommended HTTPS method. There are also instructions for using SSH. To prevent `git` from asking for your username and password every time you push a commit you can cache your credentials by running the following command, as described in the [instructions](https://help.github.com/articles/caching-your-github-password-in-git/).

```sh
git config --global credential.helper osxkeychain
```

## Using HTTPS for GitHub (recommended)

These instructions are from [the official documentation](https://help.github.com/en/github/using-git/which-remote-url-should-i-use#cloning-with-https-urls-recommended).

### Clone repositories using HTTPS

After creating a new repo on GitHub, clone it using:

```sh
git clone https://github.com/<username>/<repo-name>.git
```

\- if you had initialized with a README.

If you did not, follow the instructions in the section below.

### Set up a new or existing repo with HTTPS for GitHub

If you are setting up a new repo, add at least one file and commit first. Then, configure the remote and push to GitHub by running:

```sh
git remote add origin https://github.com/<username>/<repo-name>.git
git push -u origin master
```

## SSH Config for GitHub

These instructions are for those who wish to use SSH and not HTTPS, and are from [the official documentation](https://help.github.com/articles/generating-ssh-keys).

### Check for existing SSH keys

First check for existing SSH keys on your computer by running:

```sh
ls -al ~/.ssh
# Lists the files in your .ssh directory, if they exist
```

Check the directory listing to see if you have files named either `id_rsa.pub` or `id_dsa.pub`. If you don't have either of those files then read on, otherwise skip the next section.

### Generate a new SSH key

If you don't have an SSH key you need to generate one. To do that you need to run the commands below, and make sure to substitute the placeholder with your email. The default settings are preferred, so when you're asked to enter a file in which to save the key, just press Enter to continue.

```sh
ssh-keygen -t rsa -C "your_email@example.com"
# Creates a new ssh key, using the provided email as a label
```

### Add your SSH key to the ssh-agent

Run the following commands to add your SSH key to the `ssh-agent`.

```sh
eval "$(ssh-agent -s)"
```

If you're running macOS Sierra 10.12.2 or later, you will need to modify your `~/.ssh/config` file to automatically load keys into the ssh-agent and store passphrases in your keychain:

```ssh-config
Host *
  AddKeysToAgent yes
  UseKeychain yes
  IdentityFile ~/.ssh/id_rsa
```

No matter what operating system version you run you need to run this command to complete this step:

```sh
ssh-add -K ~/.ssh/id_rsa
```

### Adding a new SSH key to your GitHub account

The last step is to let GitHub know about your SSH key so GitHub can recognize you. Run this command to copy your key to your clipboard:

```sh
pbcopy < ~/.ssh/id_rsa.pub
```

Then go to GitHub and [input your new SSH key](https://github.com/settings/ssh/new). Paste your key in the "Key" text-box and pick a name that represents the computer you're currently using.

We are now ready to use SSH with GitHub!

### Clone repositories using SSH

After creating a new repo on GitHub, clone it using

```sh
git clone git@github.com:<username>/<repo-name>.git
```

\- if you had initialized with a README.

If you did not, follow the instructions in the section below.

### Set up a new or existing repo with SSH for GitHub

If you are setting up a new repo, add at least one file and commit first. Then, configure the remote and push to GitHub by running:

```sh
git remote add origin git@github.com:<username>/<repo-name>.git
git push -u origin master
```


# Visual Studio Code

[Visual Studio Code](https://code.visualstudio.com/) is a lightweight code editor with support for many programming languages through [extensions](https://code.visualstudio.com/docs/editor/extension-gallery)

## Installation

To install the latest version, use Homebrew:

```sh
brew install --cask visual-studio-code
```

## macOS integration

Launch VS Code from the [command line](https://code.visualstudio.com/docs/setup/mac#_launching-from-the-command-line).

After that, you can launch VS Code from your terminal:

* `code .` will open VS Code in the current directory
* `code myfile.txt` will open `myfile.txt` in VS Code

## Useful Extensions

### Python

* [Python](https://marketplace.visualstudio.com/items?itemName=ms-python.python) - Python code highlighting

  To enable auto-formatting on "Save", i.e. `⌘ + S`, configure the following:

  1. Change the default formatter to `Black` instead of `Autopep8`. Critical to avoid large diffs. Go to _Preferences_ -> _User Settings_ and update the setting `python.formatter.provider` to `Black`

  2. Enable `Format on Save` Setting: _Editor: Format On Save_ setting on _Code_ -> _Preferences_ -> _Settings_

### JavaScript

* [ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint
) - Useful to check JavaScript errors and helps in auto-formatting the code
* [Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode
) - JavaScript code formatter

### SQL

* [PostgreSQL formatter](https://marketplace.visualstudio.com/items?itemName=bradymholt.pgformatter)

### Markdown

* [Markdown Preview](https://marketplace.visualstudio.com/items?itemName=shd101wyy.markdown-preview-enhanced) - Read Markdown files in VSCode

### GitLens

* [GitLens](https://marketplace.visualstudio.com/items?itemName=eamodio.gitlens
) - Supercharge the Git capabilities built into VSCode

### Docker

* [Docker](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker) - Create, manage, and debug images from within VSCode

### JSON

* [Paste JSON as Code](https://marketplace.visualstudio.com/items?itemName=quicktype.quicktype) - Infers types from sample JSON data, then outputs strongly typed models and serializers for working with that data in your desired programming language

### Live Server

* [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer) - Launches a local development server with live reloading for both static and dynamic

### VS Code Icons

* [vscode-icons](https://marketplace.visualstudio.com/items?itemName=vscode-icons-team.vscode-icons) - Adds unique icons to distinguish different file extensions (easier to glance through your directories)


# PostgreSQL

PostgreSQL is an open source relational database management system (RDBMS). It is the default database for macOS server.

## Installation

```sh
brew install postgres
```

After this, we can test the installation status by checking the version of installed PostgreSQL

```sh
postgres -V
```

## Usage

### Start PostgreSQL server

```sh
pg_ctl -D /usr/local/var/postgres start
```

Or you can start the PostgreSQL server and have it start up at login automatically

```sh
brew services start postgresql
```

### Stop PostgreSQL server

```sh
pg_ctl -D /usr/local/var/postgres stop
```

To make it stop starting up automatically at login

```sh
brew services stop postgresql
```

### Restart PostgreSQL server

```sh
pg_ctl -D /usr/local/var/postgres restart
```

Or if you're using `homebrew`

```sh
brew services restart postgresql
```

### Start PostgreSQL console

```sh
psql
```

### GUI tool

We can use `psequel` a free GUI tool for managing the local and remote PostgreSQL databases

Install `psequel` using `homebrew`

```sh
brew install psequel
```


# Node.js

Install node version manager (nvm)
```sh
curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.38.0/install.sh | bash
```

Reload iTerm and check installation
```sh
nvm --version
```


# Security and Safety

A development machine should be secured against threads as well as any other machine \(or even _especially_ a development machine\). Therefore we will setup

* a virus scanner
* a firewall
* disk encryption

## Virus Scanner

Head over to [Avira](https://www.avira.com/), download and install their latest free package.

## Firewall

This one is a bit controversial. If you do not install software which allows network access of any kind, skip it. If you run potentially vulnerable software you don't want to be accessed from other machines, consider turning the built-in firewall on. This particularly applies if you develop network software.

To turn the built-in firewall on:

1. Choose Apple menu \(\) &gt; System Preferences, then click Security & Privacy.
2. Click the Firewall tab.
3. Click the Lock button, then enter an administrator name and password.
4. Click Turn On Firewall.
5. Click Firewall Options.
6. Uncheck 'Automatically allow signed software to receive incoming connections'.

The last step disables automatic access for software from the App Store. From now on you can either add \(dis\)allowed programs to the list within the Firewall Options or just click on Allow\/Deny, if you get a popup asking you if a specific software may be accessed.

## Disk Encryption

Another controversial point. If you have a desktop machine in a secured building, you probably do not need disk encryption. If you travel a lot and take your notebook with you \(including all your source codes\), you might consider travelling with disk encryption enabled.

The following steps were taken from the [official apple support page](https://support.apple.com/en-us/HT204837) on this:

1. Choose Apple menu \(\) &gt; System Preferences, then click Security & Privacy.
2. Click the FileVault tab.
3. Click the Lock button, then enter an administrator name and password.
4. Click Turn On FileVault.
5. Follow the instructions. In my opinion you should create a local and offline possibility to disable encryption, when you are asked how to regain access in case of anything.
