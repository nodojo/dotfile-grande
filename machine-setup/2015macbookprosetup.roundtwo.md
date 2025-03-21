2015 MacBook Pro Quick Setup

# System Preferences

## Dock & Menu Bar

Automatically hide and show the Dock
```sh
defaults write com.apple.dock autohide -bool true && \
killall Dock
```

Disable showing recently used applications in the Dock
```sh
defaults write com.apple.dock show-recents -bool false  && \
killall Dock
```

## Keyboard

Disable auto-correct
```sh
defaults write NSGlobalDomain NSAutomaticSpellingCorrectionEnabled -bool false
```

Disable automatic capitalization
```sh
defaults write NSGlobalDomain NSAutomaticCapitalizationEnabled -bool false
```

Disable automatic period substitution
```sh
defaults write NSGlobalDomain NSAutomaticPeriodSubstitutionEnabled -bool false
```

Disable the "press and hold" behavior
```sh
defaults write -g ApplePressAndHoldEnabled -bool true
```

## Desktop & Screen Saver

Set desktop background to persist after reboot

1. Open mission control and add a screen (should have two screens, Desktop1 and Desktop2)
2. Select the newly created screen (Desktop2)
3. Right click and select `Change Desktop Background...`
4. Set the image or color for the background and close System Preferences
5. Open mission control and close the screen Desktop1
6. Reboot and test

## Security

Display status of FileVault service
```sh
sudo fdesetup status
```

Enable FileVault service
```sh
sudo fdesetup enable
```

Display status of Firewall service
```sh
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --getglobalstate
```

Enable Firewall service
```sh
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --setglobalstate on
```

## Finder

Enable quit Finder with default shortcut
<kbd>Cmd</kbd> + <kbd>Q</kbd>
```sh
defaults write com.apple.finder QuitMenuItem -bool true && \
killall Finder
```
**todo: retake screenshots with show path in title set to false**

Show path bar
```sh
defaults write com.apple.finder ShowPathbar -bool true
```

<img width="738" alt="showpathbar" src="https://user-images.githubusercontent.com/52790569/148661175-921affd6-b7de-417e-911c-478c9aeee873.png">

Show status bar
```sh
defaults write com.apple.finder ShowStatusBar -bool true
```

<img width="738" alt="showstatusbar" src="https://user-images.githubusercontent.com/52790569/148661183-27fe6f16-6bc3-41e5-9d0e-0c8aa3898e4a.png">

Set the current folder as default search scope
```sh
defaults write com.apple.finder FXDefaultSearchScope -string "SCcf"
```

Set the default Finder location to the home folder
```sh
defaults write com.apple.finder NewWindowTarget -string "PfLo" && \
defaults write com.apple.finder NewWindowTargetPath -string "file://${HOME}"
```

Set sidebar icon size to medium
```sh
defaults write -g NSTableViewDefaultSizeMode -int 2
```

## Miscellaneous

Save to disk by default (not iCloud)
```sh
defaults write -g NSDocumentSaveNewDocumentsToCloud -bool false
```

Set computer name/host name
```sh
sudo scutil --set ComputerName "newhostname" && \
sudo scutil --set HostName "newhostname" && \
sudo scutil --set LocalHostName "newhostname" && \
sudo defaults write /Library/Preferences/SystemConfiguration/com.apple.smb.server NetBIOSName -string "newhostname"
```

Set static IP address
```sh
networksetup -setmanual "Ethernet" 192.168.2.100 255.255.255.0 192.168.2.1
```

Ping a host to test availability
```sh
ping -o github.com
```

Recursively delete `.DS_Store` files
```sh
find . -type f -name '.DS_Store' -ls -delete
```

Add custom message to login screen
```sh
sudo defaults write /Library/Preferences/com.apple.loginwindow LoginwindowText "Your Message"
```

Change login screen background
```sh
sudo defaults write /Library/Preferences/com.apple.loginwindow DesktopPicture "/Library/Desktop Pictures/Aqua Blue.jpg"
```

## Install Homebrew

```sh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install.sh)"
```

## Install commands for desired applications

```sh
brew install --cask 1password
brew install --cask expressvpn
brew install --cask firefox
brew install --cask google-chrome
brew install --cask iterm2
brew install --cask libreoffice
brew install --cask slack
brew install --cask spectacle
brew install --cask visual-studio-code
brew install --cask vlc

brew install git
brew install zsh
```

## Node.js

Install node version manager (nvm)

```sh
curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.38.0/install.sh | bash
```

Reload iTerm and check nvm, npm, and node installations

```sh
nvm --version
```

```sh
node -v && npm -v
```
