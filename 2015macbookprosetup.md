2015 MacBook Pro Setup Steps


# System Preferences


## General

- Set `Appearance: Dark`

## Dock & Menu Bar

- Set `Position on screen: left`
- Check `Automatically hide and showthe Dock`
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

## User Defaults

- Show Library folder
```sh
chflags nohidden ~/Library
```
- Prevent left/right swipe through history in Chrome
```sh
defaults write com.google.Chrome AppleEnableSwipeNavigateWithScrolls -bool false
```
- Enable repeating keys by pressing and holding down keys
```sh
defaults write NSGlobalDomain ApplePressAndHoldEnabled -bool false
```
- Change the default folder for screenshots
  - Create a folder to store screenshots
```sh
mkdir -p /path/to/screenshots/    # example path: /Users/macuser/Desktop/desktop-folder/
```
  - Then run the following command
```sh
defaults write com.apple.screencapture location /path/to/screenshots/ && killall SystemUIServer
```

# Xcode

[Xcode](https://developer.apple.com/xcode/) is an integrated development environment for macOS containing a suite of software development tools developed by Apple for developing software for macOS, iOS, watchOS and tvOS.

Download and install it from the App Store or from [Apple's website](https://developer.apple.com/xcode/).

For installing Xcode command line tools run:

```sh
xcode-select --install
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

# Node.js

Install node version manager (nvm)
```sh
curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.38.0/install.sh | bash
```

Reload iTerm and check installation
```sh
nvm --version
```
