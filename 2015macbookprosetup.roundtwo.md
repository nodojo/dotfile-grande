2015 MacBook Pro Quick Setup

# System Preferences

## Desktop & Screen Saver

Set desktop background to persist after reboot

1. Open mission control and add a screen (should have two screens, Desktop1 and Desktop2)
2. Select the newly created screen (Desktop2)
3. Right click and select `Change Desktop Background...`
4. Set the image or color for the background and close System Preferences
5. Open mission control and close the screen Desktop1
6. Reboot and test

Set background image for login screen (macOS Monterey)

1. System Preferences > Security & Privacy > FileVault > Turn Off FileVault
2. Desktop & Screen Saver > Change background to background of your choosing, or change to another and change back
3. Apple menu > Lock screen >> background should be the one you've chosen
4. Turn FileVault back on

## Finder

Enable quit Finder with default shortcut
<kbd>Cmd</kbd> + <kbd>Q</kbd>
```sh
defaults write com.apple.finder QuitMenuItem -bool true && \
killall Finder
```

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
