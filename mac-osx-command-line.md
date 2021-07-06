<h1><img src="https://cdn.rawgit.com/herrbischoff/awesome-macos-command-line/cab824f0/assets/logo.svg" alt="Awesome macOS Command Line" width="600"></h1>

[https://github.com/herrbischoff/awesome-macos-command-line](herrbischoff/awesome-macos-command-line)


### Google

#### Uninstall Google Update
```sh
~/Library/Google/GoogleSoftwareUpdate/GoogleSoftwareUpdate.bundle/Contents/Resources/ksinstall --nuke
```

### TextEdit

#### Use Plain Text Mode as Default
```sh
defaults write com.apple.TextEdit RichText -int 0
```

### Xcode

#### Install Command Line Tools without Xcode
```sh
xcode-select --install
```

#### Remove All Unavailable Simulators
```sh
xcrun simctl delete unavailable
```

## Dock

#### Add a Stack with Recent Applications
Obsolete since macOS 10.14 (Mojave). See [Show Recent Apps](#show-recent-apps).
```sh
defaults write com.apple.dock persistent-others -array-add '{ "tile-data" = { "list-type" = 1; }; "tile-type" = "recents-tile"; }' && \
killall Dock
```

#### Add a Nameless Stack Folder and Small Spacer
```sh
defaults write com.apple.dock persistent-others -array-add '{ "tile-data" = {}; "tile-type"="small-spacer-tile"; }' && \
killall Dock
```

#### Add a Space
```sh
defaults write com.apple.dock persistent-apps -array-add '{"tile-type"="spacer-tile";}' && \
killall Dock
```

#### Add a Small Space
```sh
defaults write com.apple.dock persistent-apps -array-add '{"tile-type"="small-spacer-tile";}' && \
killall Dock
```

#### Auto Rearrange Spaces Based on Most Recent Use
```sh
# Enable (Default)
defaults write com.apple.dock mru-spaces -bool true && \
killall Dock

# Disable
defaults write com.apple.dock mru-spaces -bool false && \
killall Dock
```

#### Automatically Hide
```sh
# Enable
defaults write com.apple.dock autohide -bool true && \
killall Dock

# Disable (Default)
defaults write com.apple.dock autohide -bool false && \
killall Dock
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

#### Lock the Dock Size
```sh
# Enable
defaults write com.apple.Dock size-immutable -bool yes && \
killall Dock

# Disable (Default)
defaults write com.apple.Dock size-immutable -bool no && \
killall Dock
```

#### Reset Dock
```sh
defaults delete com.apple.dock && \
killall Dock
```

#### Resize
Fully resize your Dock's body. To resize change the `0` value as an integer.
```sh
defaults write com.apple.dock tilesize -int 0 && \
killall Dock
```

#### Scroll Gestures
Use your touchpad or mouse scroll wheel to interact with Dock items. Allows you
to use an upward scrolling gesture to open stacks. Using the same gesture on
applications that are running invokes Exposé/Mission Control.
```sh
# Enable
defaults write com.apple.dock scroll-to-open -bool true && \
killall Dock

# Disable (Default)
defaults write com.apple.dock scroll-to-open -bool false && \
killall Dock
```

#### Set Auto Show/Hide Delay
The float number defines the show/hide delay in ms.
```sh
defaults write com.apple.dock autohide-time-modifier -float 0.4 && \
defaults write com.apple.dock autohide-delay -float 0 && \
killall Dock
```

#### Show Hidden App Icons
```sh
# Enable
defaults write com.apple.dock showhidden -bool true && \
killall Dock

# Disable (Default)
defaults write com.apple.dock showhidden -bool false && \
killall Dock
```

#### Show Only Active Applications
```sh
# Enable
defaults write com.apple.dock static-only -bool true && \
killall Dock

# Disable (Default)
defaults write com.apple.dock static-only -bool false && \
killall Dock
```

#### Show Recent Apps
Setting present since macOS 10.14 (Mojave).
```sh
# Disable
defaults write com.apple.dock show-recents -bool false  && \
killall Dock

# Enable (Default)
defaults write com.apple.dock show-recents -bool true && \
killall Dock
```

#### Single App Mode
When clicking an application icon in the Dock, the respective windows will come
to the front, but all other application windows will be hidden.
```sh
# Enable
defaults write com.apple.dock single-app -bool true && \
killall Dock

# Disable (Default)
defaults write com.apple.dock single-app -bool false && \
killall Dock
```

## Documents

#### Convert File to HTML
Supported formats are plain text, rich text (rtf) and Microsoft Word (doc/docx).
```sh
textutil -convert html file.ext
```


## Files, Disks and Volumes

#### Create an Empty File
Creates an empty 10 gigabyte test file.
```sh
mkfile 10g /path/to/file
```

#### Repair File Permissions
You don't have to use the Disk Utility GUI for this.
```sh
sudo diskutil repairPermissions /
```
> Beginning with OS X 10.11 (El Capitan), system file permissions are
> automatically protected. It's no longer necessary to verify or repair
> permissions with Disk Utility.
> ([Source](https://support.apple.com/en-us/HT201560))

#### Set Boot Volume
```sh
# Up to OS X 10.10 (Yosemite)
bless --mount "/path/to/mounted/volume" --setBoot

# From OS X 10.11 (El Capitan)
sudo systemsetup -setstartupdisk /System/Library/CoreServices
```

#### Show All Attached Disks and Partitions
```sh
diskutil list
```

#### View File System Usage
A continuous stream of file system access info.
```sh
sudo fs_usage
```

### Files and Folders

#### Show All File Extensions
```sh
defaults write -g AppleShowAllExtensions -bool true
```

#### Set Protected Flag
This is equivalent to Finder "Locked" status.
```sh
# Disable (Default)
sudo chflags -R nouchg /path/to/file/or/folder

# Enable
sudo chflags -R uchg /path/to/file/or/folder
```

#### Show Hidden Files
```sh
# Show All
defaults write com.apple.finder AppleShowAllFiles true

# Restore Default File Visibility
defaults write com.apple.finder AppleShowAllFiles false
```

#### Show Full Path in Finder Title
```sh
defaults write com.apple.finder _FXShowPosixPathInTitle -bool true
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

### Layout

#### Show "Quit Finder" Menu Item
Makes possible to see Finder menu item "Quit Finder" with default shortcut
<kbd>Cmd</kbd> + <kbd>Q</kbd>
```sh
# Enable
defaults write com.apple.finder QuitMenuItem -bool true && \
killall Finder

# Disable (Default)
defaults write com.apple.finder QuitMenuItem -bool false && \
killall Finder
```

#### Smooth Scrolling
Useful if you’re on an older Mac that messes up the animation.
```sh
# Disable
defaults write -g NSScrollAnimationEnabled -bool false

# Enable (Default)
defaults write -g NSScrollAnimationEnabled -bool true
```

#### Rubberband Scrolling
```sh
# Disable
defaults write -g NSScrollViewRubberbanding -bool false

# Enable (Default)
defaults write -g NSScrollViewRubberbanding -bool true
```

#### Expand Save Panel by Default
```sh
defaults write -g NSNavPanelExpandedStateForSaveMode -bool true && \
defaults write -g NSNavPanelExpandedStateForSaveMode2 -bool true
```

#### Desktop Icon Visibility
```sh
# Hide Icons
defaults write com.apple.finder CreateDesktop -bool false && \
killall Finder

# Show Icons (Default)
defaults write com.apple.finder CreateDesktop -bool true && \
killall Finder
```

#### Path Bar
```sh
# Show
defaults write com.apple.finder ShowPathbar -bool true

# Hide (Default)
defaults write com.apple.finder ShowPathbar -bool false
```

#### Scrollbar Visibility
Possible values: `WhenScrolling`, `Automatic` and `Always`.
```sh
defaults write -g AppleShowScrollBars -string "Always"
```

#### Status Bar
```sh
# Show
defaults write com.apple.finder ShowStatusBar -bool true

# Hide (Default)
defaults write com.apple.finder ShowStatusBar -bool false
```

#### Save to Disk by Default
Sets default save target to be a local disk, not iCloud.
```sh
defaults write -g NSDocumentSaveNewDocumentsToCloud -bool false
```

#### Set Current Folder as Default Search Scope
```sh
defaults write com.apple.finder FXDefaultSearchScope -string "SCcf"
```

#### Set Default Finder Location to Home Folder
```sh
defaults write com.apple.finder NewWindowTarget -string "PfLo" && \
defaults write com.apple.finder NewWindowTargetPath -string "file://${HOME}"
```

#### Set Sidebar Icon Size
Sets size to 'medium'.
```sh
defaults write -g NSTableViewDefaultSizeMode -int 2
```

### Metadata Files

#### Disable Creation of Metadata Files on Network Volumes
Avoids creation of `.DS_Store` and AppleDouble files.
```sh
defaults write com.apple.desktopservices DSDontWriteNetworkStores -bool true
```

#### Disable Creation of Metadata Files on USB Volumes
Avoids creation of `.DS_Store` and AppleDouble files.
```sh
defaults write com.apple.desktopservices DSDontWriteUSBStores -bool true
```

### Opening Things

#### Change Working Directory to Finder Path
If multiple windows are open, it chooses the top-most one.
```sh
cd "$(osascript -e 'tell app "Finder" to POSIX path of (insertion location as alias)')"
```

#### Open URL
```sh
open https://github.com
```

#### Open File
```sh
open README.md
```

#### Open Applications
You can open applications using `-a`.
```sh
open -a "Google Chrome" https://github.com
```

#### Open Folder
```sh
open /path/to/folder/
```

#### Open Current Folder
```sh
open .
```

## Hardware

### Bluetooth

Up to OS X 10.12 (Sierra) the Bluetooth daemon is named `blued` instead of
`bluetoothd`. You need to adjust the `killall` command accordingly.

```sh
# Status
defaults read /Library/Preferences/com.apple.Bluetooth ControllerPowerState

# Enable (Default)
sudo defaults write /Library/Preferences/com.apple.Bluetooth ControllerPowerState -int 1

# Disable
sudo defaults write /Library/Preferences/com.apple.Bluetooth ControllerPowerState -int 0 && \
sudo killall -HUP bluetoothd
```

### Hardware Information

#### List All Hardware Ports
```sh
networksetup -listallhardwareports
```

#### Remaining Battery Percentage
```sh
pmset -g batt | egrep "([0-9]+\%).*" -o --colour=auto | cut -f1 -d';'
```

#### Remaining Battery Time
```sh
pmset -g batt | egrep "([0-9]+\%).*" -o --colour=auto | cut -f3 -d';'
```

#### Show Connected Device's UDID
```sh
system_profiler SPUSBDataType | sed -n -e '/iPad/,/Serial/p' -e '/iPhone/,/Serial/p'
```

#### Show Current Screen Resolution
```sh
system_profiler SPDisplaysDataType | grep Resolution
```

#### Show CPU Brand String
```sh
sysctl -n machdep.cpu.brand_string
```

### Infrared Receiver

```sh
# Status
defaults read /Library/Preferences/com.apple.driver.AppleIRController DeviceEnabled

# Enable (Default)
defaults write /Library/Preferences/com.apple.driver.AppleIRController DeviceEnabled -int 1

# Disable
defaults write /Library/Preferences/com.apple.driver.AppleIRController DeviceEnabled -int 0
```

### Power Management

#### Prevent System Sleep
Prevent sleep for 1 hour:
```sh
caffeinate -u -t 3600
```

#### Show All Power Management Settings
```sh
sudo pmset -g
```

#### Put Display to Sleep after 15 Minutes of Inactivity
```sh
sudo pmset displaysleep 15
```

#### Put Computer to Sleep after 30 Minutes of Inactivity
```sh
sudo pmset sleep 30
```

#### Check System Sleep Idle Time
```sh
sudo systemsetup -getcomputersleep
```

#### Set System Sleep Idle Time to 60 Minutes
```sh
sudo systemsetup -setcomputersleep 60
```

#### Turn Off System Sleep Completely
```sh
sudo systemsetup -setcomputersleep Never
```

#### Automatic Restart on System Freeze
```sh
sudo systemsetup -setrestartfreeze on
```

#### Chime When Charging
Play iOS charging sound when MagSafe is connected.
```sh
## Up to macOS 10.12 (Sierra)

# Enable
defaults write com.apple.PowerChime ChimeOnAllHardware -bool true && \
open /System/Library/CoreServices/PowerChime.app

# Disable (Default)
defaults write com.apple.PowerChime ChimeOnAllHardware -bool false && \
killall PowerChime
```
```sh
## From macOS 10.13 (High Sierra) on

# Enable (Default)
defaults write com.apple.PowerChime ChimeOnNoHardware -bool false && \
open /System/Library/CoreServices/PowerChime.app

# Disable
defaults write com.apple.PowerChime ChimeOnNoHardware -bool true && \
killall PowerChime
```

## Input Devices

### Keyboard

#### Auto-Correct
```sh
# Disable
defaults write -g NSAutomaticSpellingCorrectionEnabled -bool false

# Enable (Default)
defaults write -g NSAutomaticSpellingCorrectionEnabled -bool true

# Show Status
defaults read -g NSAutomaticSpellingCorrectionEnabled
```

#### Full Keyboard Access
Enable Tab in modal dialogs.
```sh
# Text boxes and lists only (Default)
defaults write NSGlobalDomain AppleKeyboardUIMode -int 0

# All controls
defaults write NSGlobalDomain AppleKeyboardUIMode -int 3
```

#### Key Repeat
Change the "press and hold" behavior.
```sh
# Enable
defaults write -g ApplePressAndHoldEnabled -bool false

# Disable (Default)
defaults write -g ApplePressAndHoldEnabled -bool true
```

#### Key Repeat Rate
Sets a very fast repeat rate, adjust to taste.
```sh
defaults write -g KeyRepeat -int 0.02
```

## Media

### Audio

#### Convert Audio File to iPhone Ringtone
```sh
afconvert input.mp3 ringtone.m4r -f m4af
```

#### Create Audiobook From Text
Uses "Alex" voice, a plain UTF-8 encoded text file for input and AAC output.
```sh
say -v Alex -f file.txt -o "output.m4a"
```

#### Disable Sound Effects on Boot
```sh
sudo nvram SystemAudioVolume=" "
```

#### Mute Audio Output
```sh
osascript -e 'set volume output muted true'
```

#### Set Audio Volume
```sh
osascript -e 'set volume 4'
```

#### Play Audio File
You can play all audio formats that are natively supported by QuickTime.
```sh
afplay -q 1 filename.mp3
```

#### Speak Text with System Default Voice
```sh
say 'All your base are belong to us!'
```

#### Startup Chime
Older Macs:
```sh
# Enable (Default)
sudo nvram BootAudio=%01

# Disable
sudo nvram BootAudio=%00
```

From 2016 models on:
```sh
# Enable
sudo nvram StartupMute=%00

# Disable (Default)
sudo nvram StartupMute=%01
```

### Video

#### Auto-Play Videos in QuickTime Player
```sh
defaults write com.apple.QuickTimePlayerX MGPlayMovieOnOpen 1
```

## Networking

### Bonjour

#### Bonjour Service
```sh
# Disable
sudo defaults write /System/Library/LaunchDaemons/com.apple.mDNSResponder.plist ProgramArguments -array-add "-NoMulticastAdvertisements"

# Enable (Default)
sudo defaults write /System/Library/LaunchDaemons/com.apple.mDNSResponder.plist ProgramArguments -array "/usr/sbin/mDNSResponder" "-launchd"
```

### DHCP

#### Renew DHCP Lease
```sh
sudo ipconfig set en0 DHCP
```

#### Show DHCP Info
```sh
ipconfig getpacket en0
```

### DNS

#### Clear DNS Cache
```sh
sudo dscacheutil -flushcache && \
sudo killall -HUP mDNSResponder
```

### Hostname

#### Set Computer Name/Host Name
```sh
sudo scutil --set ComputerName "newhostname" && \
sudo scutil --set HostName "newhostname" && \
sudo scutil --set LocalHostName "newhostname" && \
sudo defaults write /Library/Preferences/SystemConfiguration/com.apple.smb.server NetBIOSName -string "newhostname"
```

### Network Preferences

#### Network Locations
Switch between network locations created in the Network preference pane.
```sh
# Status
scselect

# Switch Network Location
scselect LocationNameFromStatus
```

#### Set Static IP Address
```sh
networksetup -setmanual "Ethernet" 192.168.2.100 255.255.255.0 192.168.2.1
```

### Networking Tools

#### Ping a Host to See Whether It’s Available
```sh
ping -o github.com
```

#### Troubleshoot Routing Problems
```sh
traceroute github.com
```

### SSH

#### Permanently Add Private Key Passphrase to SSH Agent
> Prior to macOS 10.12 (Sierra), ssh would present a dialog asking for your
> passphrase and would offer the option to store it into the keychain. This UI
> was deprecated some time ago and has been removed.
>
> Instead, a new UseKeychain option was introduced in macOS 10.12 (Sierra)
> allowing users to specify whether they would like for the passphrase to be
> stored in the keychain. This option was enabled by default on macOS 10.12
> (Sierra), which caused all passphrases to be stored in the keychain.
>
> This was not the intended default behavior, so this has been changed in macOS
> 10.12.2.
> ([Source](https://developer.apple.com/library/archive/technotes/tn2449/_index.html))
```sh
ssh-add -K /path/to/private_key
```
Then add to `~/.ssh/config`:
```sh
Host server.example.com
    IdentityFile /path/to/private_key
    UseKeychain yes
```

#### Remote Login
```sh
# Enable
sudo launchctl load -w /System/Library/LaunchDaemons/ssh.plist

# Disable (Default)
sudo launchctl unload -w /System/Library/LaunchDaemons/ssh.plist
```

### TCP/IP

#### Show Application Using a Certain Port
This outputs all applications currently using port 80.
```sh
sudo lsof -i :80
```

#### Show External IP Address
Works if your ISP doesn't replace DNS requests (which it shouldn't).
```sh
dig +short myip.opendns.com @resolver1.opendns.com
```
Alternative that works on all networks.
```sh
curl -s https://api.ipify.org && echo
```

#### Show Network Interface Information
Undocumented flag of the `scutil` command.
```sh
scutil --nwi
```

### TFTP

#### Start Native TFTP Daemon
Files will be served from `/private/tftpboot`.
```sh
sudo launchctl load -F /System/Library/LaunchDaemons/tftp.plist && \
sudo launchctl start com.apple.tftpd
```

### Wi-Fi

#### Join a Wi-Fi Network
```sh
networksetup -setairportnetwork en0 WIFI_SSID WIFI_PASSWORD
```

#### Scan Available Access Points
Create a symbolic link to the airport command for easy access:
```sh
sudo ln -s /System/Library/PrivateFrameworks/Apple80211.framework/Versions/Current/Resources/airport /usr/local/bin/airport
```
Run a wireless scan:
```sh
airport -s
```

#### Show Current SSID
```sh
/System/Library/PrivateFrameworks/Apple80211.framework/Versions/Current/Resources/airport -I | awk '/ SSID/ {print substr($0, index($0, $2))}'
```

#### Show Local IP Address
```sh
ipconfig getifaddr en0
```

#### Show Wi-Fi Connection History
```sh
defaults read /Library/Preferences/SystemConfiguration/com.apple.airport.preferences | grep LastConnected -A 7
```

#### Show Wi-Fi Network Passwords
Exchange SSID with the SSID of the access point you wish to query the password from.
```sh
security find-generic-password -D "AirPort network password" -a "SSID" -gw
```

#### Turn on Wi-Fi Adapter
```sh
networksetup -setairportpower en0 on
```

## Package Managers

- [Fink](http://www.finkproject.org) - The full world of Unix Open Source
  software for Darwin. A little outdated.
- [Homebrew](https://brew.sh) - The missing package manager for OS X. The most
  popular choice.
- [MacPorts](https://www.macports.org) - Compile, install and upgrade either
  command-line, X11 or Aqua based open-source software.

### Homebrew

#### Full Uninstall

```sh
ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/uninstall)"
```


## Printing

#### Clear Print Queue
```sh
cancel -a -
```

#### Expand Print Panel by Default
```sh
defaults write -g PMPrintingExpandedStateForPrint -bool true && \
defaults write -g PMPrintingExpandedStateForPrint2 -bool true
```

#### Quit Printer App After Print Jobs Complete
```sh
defaults write com.apple.print.PrintingPrefs "Quit When Finished" -bool true
```

## Security

### Application Firewall

#### Firewall Service
```sh
# Show Status
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --getglobalstate

# Enable
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --setglobalstate on

# Disable (Default)
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --setglobalstate off
```

#### Add Application to Firewall
```sh
sudo /usr/libexec/ApplicationFirewall/socketfilterfw --add /path/to/file
```

### Gatekeeper

#### Add Gatekeeper Exception
```sh
spctl --add /path/to/Application.app
```

#### Remove Gatekeeper Exception
```sh
spctl --remove /path/to/Application.app
```

#### Manage Gatekeeper
Especially helpful with the annoying macOS 10.15 (Catalina) system popup
blocking execution of non-signed apps.
```sh
# Status
spctl --status

# Enable (Default)
sudo spctl --master-enable

# Disable
sudo spctl --master-disable
```

### Passwords

#### Generate Secure Password and Copy to Clipboard
```sh
LC_ALL=C tr -dc "[:alnum:]" < /dev/urandom | head -c 20 | pbcopy
```

### Physical Access

#### Launch Screen Saver

```sh
# Up to macOS 10.12 (Sierra)
open /System/Library/Frameworks/ScreenSaver.framework/Versions/A/Resources/ScreenSaverEngine.app

# From macOS 10.13 (High Sierra)
/System/Library/CoreServices/ScreenSaverEngine.app/Contents/MacOS/ScreenSaverEngine
```


#### Lock Screen
```sh
/System/Library/CoreServices/Menu\ Extras/User.menu/Contents/Resources/CGSession -suspend
```

#### Screensaver Immediate Lock
```sh
# Status
defaults read com.apple.screensaver askForPasswordDelay

# Enable (Default)
defaults write com.apple.screensaver askForPasswordDelay -int 0

# Disable (Integer = lock delay in seconds)
defaults write com.apple.screensaver askForPasswordDelay -int 10
```

#### Screensaver Password
```sh
# Status
defaults read com.apple.screensaver askForPassword

# Enable
defaults write com.apple.screensaver askForPassword -int 1

# Disable (Default)
defaults write com.apple.screensaver askForPassword -int 0
```

### Privacy Database

The `tccutil` command manages the privacy database, which stores decisions the
user has made about whether apps may access personal data. You need to close
all applications except Terminal before running any of these commands.

```sh
# Full Reset for All Applications
sudo tccutil reset All

# Reset Adress Book Access
sudo tccutil reset AddressBook

# Reset All Permission for Terminal.app
sudo tccutil reset All com.apple.Terminal
```

### Wiping Data

Note: The `srm` command appears to have been removed on MacOS after 10.9. There
is a note on an [Apple support page](https://support.apple.com/en-us/HT201949)
hinting as to why:
> With an SSD drive, Secure Erase and Erasing Free Space are not available in
> Disk Utility. These options are not needed for an SSD drive because a
> standard erase makes it difficult to recover data from an SSD.

#### Securely Remove File
```sh
srm /path/to/file
```

#### Securely Remove Folder
```sh
srm -r /path/to/folder/
```

#### Securely Remove Path (Force)
```sh
srm -rf /path/to/complete/destruction
```


## Search

### Find

#### Recursively Delete .DS_Store Files
```sh
find . -type f -name '.DS_Store' -ls -delete
```

### Locate

#### Build Locate Database
```sh
sudo launchctl load -w /System/Library/LaunchDaemons/com.apple.locate.plist
```

#### Search via Locate
The `-i` modifier makes the search case insensitive.
```sh
locate -i *.jpg
```


## System

### AirDrop

#### AirDrop over Ethernet on Unsupported Macs
```sh
# Enable
defaults write com.apple.NetworkBrowser BrowseAllInterfaces -bool true && \
defaults remove com.apple.NetworkBrowser DisableAirDrop

# Disable (Default)
defaults delete com.apple.NetworkBrowser BrowseAllInterfaces && \
defaults write com.apple.NetworkBrowser DisableAirDrop -bool YES
```

### AppleScript

#### Execute AppleScript
```sh
osascript /path/to/script.scpt
```

### Basics

#### Compare Two Folders
```sh
diff -qr /path/to/folder1 /path/to/folder2
```

#### Copy Large File with Progress
Make sure you have `pv` installed and replace `/dev/rdisk2` with the
appropriate write device or file.
```sh
FILE=/path/to/file.iso pv -s $(du -h $FILE | awk '/.*/ {print $1}') $FILE | sudo dd of=/dev/rdisk2 bs=1m
```

#### Restore Sane Shell
In case your shell session went insane (some script or application turned it
into a garbled mess).
```sh
stty sane
```

#### Restart
```sh
sudo reboot
```

#### Shutdown
```sh
sudo poweroff
```

#### Show Build Number of OS
```sh
sw_vers
```

#### Uptime
How long since your last restart.
```sh
uptime
```

### Clipboard

#### Copy data to Clipboard
```sh
cat whatever.txt | pbcopy
```

#### Convert Clipboard to Plain Text
```sh
pbpaste | textutil -convert txt -stdin -stdout -encoding 30 | pbcopy
```

#### Convert Tabs to Spaces for Clipboard Content
```sh
pbpaste | expand | pbcopy
```

#### Copy data from Clipboard
```sh
pbpaste > whatever.txt
```

#### Sort and Strip Duplicate Lines from Clipboard Content
```sh
pbpaste | sort | uniq | pbcopy
```

### FileVault

#### Automatically Unlock FileVault on Restart
If FileVault is enabled on the current volume, it restarts the system,
bypassing the initial unlock. The command may not work on all systems.
```sh
sudo fdesetup authrestart
```

#### FileVault Service
```sh
# Status
sudo fdesetup status

# Enable
sudo fdesetup enable

# Disable (Default)
sudo fdesetup disable
```

### Information/Reports

#### Generate Advanced System and Performance Report
```sh
sudo sysdiagnose -f ~/Desktop/
```

### Installation

#### Create Bootable Installer
```sh
# macOS 11 (Big Sur)
sudo /Applications/Install\ macOS\ Big\ Sur.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --nointeraction --downloadassets

# macOS 10.15 (Catalina)
sudo /Applications/Install\ macOS\ Catalina.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --nointeraction --downloadassets

# macOS 10.14 (Mojave)
sudo /Applications/Install\ macOS\ Mojave.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --nointeraction --downloadassets

# macOS 10.13 (High Sierra)
sudo /Applications/Install\ macOS\ High\ Sierra.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --applicationpath /Applications/Install\ macOS\ High\ Sierra.app

# macOS 10.12 (Sierra)
sudo /Applications/Install\ macOS\ Sierra.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --applicationpath /Applications/Install\ macOS\ Sierra.app

# OS X 10.11 (El Capitan)
sudo /Applications/Install\ OS\ X\ El\ Capitan.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --applicationpath /Applications/Install\ OS\ X\ El\ Capitan.app

# OS X 10.10 (Yosemite)
sudo /Applications/Install\ OS\ X\ Yosemite.app/Contents/Resources/createinstallmedia --volume /Volumes/USB --applicationpath /Applications/Install\ OS\ X\ Yosemite.app
```

* For confirmation before erasing the drive, remove `–-nointeraction` from the
  command.
* The optional `–-downloadassets` flag is new in macOS 10.14 (Mojave). It
  downloads assets which may be required during installation, like updates.
* The `–-applicationpath` flag is deprecated since macOS 10.14 (Mojave) and
  will throw an error if used.

#### Download Older OS Versions

Version       | Codename      | Download
------------- | ------------- | --------
Mac OS X 10.0 | Cheetah       | n/a
Mac OS X 10.1 | Puma          | n/a
Mac OS X 10.2 | Jaguar        | n/a
Mac OS X 10.3 | Panther       | n/a
Mac OS X 10.4 | Tiger         | n/a
Mac OS X 10.5 | Leopard       | n/a
Mac OS X 10.6 | Snow Leopard  | n/a
Mac OS X 10.7 | Lion          | n/a
OS X 10.8     | Mountain Lion | n/a
OS X 10.9     | Mavericks     | n/a
OS X 10.10    | Yosemite      | [Direct Download](http://updates-http.cdn-apple.com/2019/cert/061-41343-20191023-02465f92-3ab5-4c92-bfe2-b725447a070d/InstallMacOSX.dmg)
OS X 10.11    | El Capitan    | [Direct Download](http://updates-http.cdn-apple.com/2019/cert/061-41424-20191024-218af9ec-cf50-4516-9011-228c78eda3d2/InstallMacOSX.dmg)
macOS 10.12   | Sierra        | [Direct Download](http://updates-http.cdn-apple.com/2019/cert/061-39476-20191023-48f365f4-0015-4c41-9f44-39d3d2aca067/InstallOS.dmg)
macOS 10.13   | High Sierra   | [App Store](https://apps.apple.com/de/app/macos-high-sierra/id1246284741)
macOS 10.14   | Mojave        | [App Store](https://apps.apple.com/de/app/macos-mojave/id1398502828)
macOS 10.15   | Catalina      | [App Store](https://apps.apple.com/de/app/macos-catalina/id1466841314)

### Kernel Extensions

#### Display Status of Loaded Kernel Extensions
```sh
sudo kextstat -l
```

#### Load Kernel Extension
```sh
sudo kextload -b com.apple.driver.ExampleBundle
```

#### Unload Kernel Extensions
```sh
sudo kextunload -b com.apple.driver.ExampleBundle
```

### LaunchAgents

Please see [this file](launchagents.md).


### LaunchServices

#### Rebuild LaunchServices Database
To be independent of OS X version, this relies on `locate` to find
`lsregister`. If you do not have your `locate` database built yet, [do
it](#build-locate-database).
```sh
sudo $(locate lsregister) -kill -seed -r
```

### Login Window

#### Set Login Window Text
```sh
sudo defaults write /Library/Preferences/com.apple.loginwindow LoginwindowText "Your text"
```

### Memory Management

#### Purge memory cache
```sh
sudo purge
```

#### Show Memory Statistics
```sh
# One time
vm_stat

# Table of data, repeat 10 times total, 1 second wait between each poll
vm_stat -c 10 1
```

### Notification Center

#### Notification Center Service
```sh
# Disable
launchctl unload -w /System/Library/LaunchAgents/com.apple.notificationcenterui.plist && \
killall -9 NotificationCenter

# Enable (Default)
launchctl load -w /System/Library/LaunchAgents/com.apple.notificationcenterui.plist
```

### QuickLook

#### Preview via QuickLook
```sh
qlmanage -p /path/to/file
```

### Remote Management

See also: [Apple Remote Desktop](#apple-remote-desktop).

#### Prevent Double Password Entry
When logging into a Mac remotely via Apple Remote Desktop or VNC, you are
sometimes required to enter your password a second time after connecting to the
Mac. While you can disable this behavior, it is explicitly not recommend to
turn this functionality off unless you are certain that no one else will be
able to access your Mac physically when you are away.
```sh
# Disable
sudo defaults write /Library/Preferences/com.apple.RemoteManagement.plist RestoreMachineState -bool no

# Enable (Default)
sudo defaults write /Library/Preferences/com.apple.RemoteManagement.plist RestoreMachineState -bool yes
```

#### Remote Apple Events
```sh
# Status
sudo systemsetup -getremoteappleevents

# Enable
sudo systemsetup -setremoteappleevents on

# Disable (Default)
sudo systemsetup -setremoteappleevents off
```

### Root User

```sh
# Enable
dsenableroot

# Disable (Default)
dsenableroot -d
```

### Safe Mode Boot

```sh
# Status
nvram boot-args

# Enable
sudo nvram boot-args="-x"

# Disable (Default)
sudo nvram boot-args=""
```

### Save Dialogs

Significantly improve the now rather slow animation in save dialogs.

```sh
defaults write NSGlobalDomain NSWindowResizeTime .001
```

### Screenshots

#### Take Delayed Screenshot
Takes a screenshot as JPEG after 3 seconds and displays in Preview.
```sh
screencapture -T 3 -t jpg -P delayedpic.jpg
```

#### Save Screenshots to Given Location
Sets location to `~/Desktop`.
```sh
defaults write com.apple.screencapture location ~/Desktop && \
killall SystemUIServer
```

#### Save Screenshots in Given Format
Sets format to `png`. Other options are `bmp`, `gif`, `jpg`, `jpeg`, `pdf`,
`tiff`.
```sh
defaults write com.apple.screencapture type -string "png"
```

#### Disable Shadow in Screenshots
```sh
defaults write com.apple.screencapture disable-shadow -bool true && \
killall SystemUIServer
```

#### Set Default Screenshot Name
Date and time remain unchanged.
```sh
defaults write com.apple.screencapture name "Example name" && \
killall SystemUIServer
```

### Software Installation

#### Install PKG
```sh
installer -pkg /path/to/installer.pkg -target /
```

### Sidecar

#### Use on Incompatible Macs
This may or may not work, depending on the age of the machine.
```sh
# Enable
defaults write com.apple.sidecar.display AllowAllDevices -bool true && \
defaults write com.apple.sidecar.display hasShownPref -bool true

# Disable (Default)
defaults delete com.apple.sidecar.display
```

### Software Update

#### Ignore Specific Software Update
The identifier can be found via `softwareupdate --list`. In the example below,
being on macOS 10.14 (Mojave), will ignore all update prompts to macOS 10.15
(Catalina), since the latter removes 32-bit support.
```sh
sudo /usr/sbin/softwareupdate --ignore "macOS Catalina"
```

#### Install All Available Software Updates
```sh
sudo softwareupdate -ia
```

#### Set Software Update Check Interval
Set to check daily instead of weekly.
```sh
defaults write com.apple.SoftwareUpdate ScheduleFrequency -int 1
```

#### Show Available Software Updates
```sh
sudo softwareupdate --list
```

#### Set Software Update Server
This should only be done for testing purposes or unmanaged clients. To use
network-wide, either correctly set up DNS along with [Apple SUS
service](http://krypted.com/mac-security/using-the-software-update-service-on-mountain-lion-server/)
and bind your clients via OpenDirectory. Alternatively, use
[Reposado](https://github.com/wdas/reposado) together with correct network DNS
settings to make resolution transparent.
[Margarita](https://github.com/jessepeterson/margarita) looks nice to have as
well.
```sh
# Use own SUS
sudo defaults write /Library/Preferences/com.apple.SoftwareUpdate CatalogURL http://su.example.com:8088/index.sucatalog

# Reset to Apple SUS
sudo defaults delete /Library/Preferences/com.apple.SoftwareUpdate CatalogURL
```

### Software Version

#### Show System Software Version
There are several ways to obtain different levels of detail.
```sh
sw_vers -productVersion
```
```sh
system_profiler SPSoftwareDataType
```
```sh
defaults read loginwindow SystemVersionStampAsString
```

### Spotlight

#### Spotlight Indexing
```sh
# Disable
mdutil -i off -d /path/to/volume

# Enable (Default)
mdutil -i on /path/to/volume
```

#### Erase Spotlight Index and Rebuild
```sh
mdutil -E /path/to/volume
```

#### Search via Spotlight
```sh
mdfind -name 'searchterm'
```

#### Show Spotlight Indexed Metadata
```sh
mdls /path/to/file
```

### System Integrity Protection

Reboot while holding <kbd>Cmd</kbd> + <kbd>R</kbd> and open the Terminal
application. You will need to `reboot` for the commands to take effect.

```sh
# Status
csrutil status

# Enable (Default)
csrutil enable

# Disable
csrutil disable
```

### Date and Time

#### List Available Timezones
```sh
sudo systemsetup -listtimezones
```

#### Set Timezone
```sh
sudo systemsetup -settimezone Europe/Berlin
```

#### Set Clock Using Network Time
```sh
# Status
sudo systemsetup getusingnetworktime

# Enable (Default)
sudo systemsetup setusingnetworktime on

# Disable
sudo systemsetup setusingnetworktime off
```

#### Set Menu Bar Clock Output Format
```sh
# System Preferences > Date & Time > Time options
# Analogue
sudo defaults write com.apple.menuextra.clock IsAnalog -bool true
# Digital (Default)
sudo defaults write com.apple.menuextra.clock IsAnalog -bool false

# System Preferences > Date & Time > Flash the time separators
# Enable
sudo defaults write com.apple.menuextra.clock FlashDateSeparators -bool true
# Disable (Default)
sudo defaults write com.apple.menuextra.clock FlashDateSeparators -bool false

# Thu 18 Aug 23:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM HH:mm:ss"

# Thu 23:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE HH:mm:ss"

# 18 Aug 23:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM HH:mm:ss"

# 23:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "HH:mm:ss"

# Thu 18 Aug 11:46:18 pm
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM h:mm:ss a"


# Thu 11:46:18 pm
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE h:mm:ss a"

# 18 Aug 11:46:18 pm
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM h:mm:ss a"

# 11:46:18 pm
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "h:mm:ss a"

# Thu 18 Aug 11:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM h:mm:ss"

# Thu 11:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE h:mm:ss"

# 18 Aug 11:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM h:mm:ss"

# 11:46:18
# System Preferences > Date & Time > Display time with seconds - Checked [:ss]
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "h:mm:ss"

# Thu 18 Aug 23:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM HH:mm"

# Thu 23:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE HH:mm"

# 18 Aug 23:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM HH:mm"

# 23:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Checked [HH:mm]
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "HH:mm"

# Thu 18 Aug 11:46 pm
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM h:mm a"

# Thu 11:46 pm
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE h:mm a"

# 18 Aug 11:46 pm
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM h:mm a"

# 11:46 pm
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Checked [a]
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "h:mm a"

# Thu 18 Aug 11:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE d MMM h:mm"

# Thu 11:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Checked [EEE]
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "EEE h:mm"

# 18 Aug 11:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Checked [d MMM]
sudo defaults write com.apple.menuextra.clock DateFormat -string "d MMM h:mm"

# 11:46
# System Preferences > Date & Time > Display time with seconds - Unchecked
# System Preferences > Date & Time > Use a 24-hour clock - Unchecked
# System Preferences > Date & Time > Show AM/PM - Unchecked
# System Preferences > Date & Time > Show the day of the week - Unchecked
# System Preferences > Date & Time > Show date - Unchecked
sudo defaults write com.apple.menuextra.clock DateFormat -string "h:mm"

# Apply changes immediately
sudo killall SystemUIServer
```

([Source](https://github.com/tech-otaku/macos-defaults/blob/master/date-time.sh))


## Terminal

#### Ring Terminal Bell
Rings the terminal bell (if enabled) and puts a badge on it.
```sh
tput bel
```

### Alternative Terminals

- [Alacritty](https://github.com/jwilm/alacritty) - Cross-platform,
  GPU-accelerated terminal emulator.
- [iTerm2](https://iterm2.com) - A better Terminal.app.
- [kitty](https://sw.kovidgoyal.net/kitty/) - Modern, GPU-accelerated terminal
  emulator.

### Shells

#### Bash
Install the latest version and set as current user's default shell:
```sh
brew install bash && \
echo $(brew --prefix)/bin/bash | sudo tee -a /etc/shells && \
chsh -s $(brew --prefix)/bin/bash
```

- [Homepage](https://www.gnu.org/software/bash/) - The default shell for OS X
  and most other Unix-based operating systems.
- [Bash-it](https://github.com/Bash-it/bash-it) - Community Bash framework,
  like Oh My Zsh for Bash.

#### fish
Install the latest version and set as current user's default shell:
```sh
brew install fish && \
echo $(brew --prefix)/bin/fish | sudo tee -a /etc/shells && \
chsh -s $(brew --prefix)/bin/fish
```

- [Homepage](http://fishshell.com) - A smart and user-friendly command line
  shell for OS X, Linux, and the rest of the family.
- [The Fishshell Framework](https://github.com/oh-my-fish/oh-my-fish) -
  Provides core infrastructure to allow you to install packages which extend or
  modify the look of your shell.
- [Installation & Configuration
  Tutorial](https://github.com/ellerbrock/fish-shell-setup-osx) - How to Setup
  Fish Shell with Fisherman, Powerline Fonts, iTerm2 and Budspencer Theme on OS
  X.

#### Zsh
Install the latest version and set as current user's default shell:
```sh
brew install zsh && \
sudo sh -c 'echo $(brew --prefix)/bin/zsh >> /etc/shells' && \
chsh -s $(brew --prefix)/bin/zsh
```

- [Homepage](http://www.zsh.org) - Zsh is a shell designed for interactive use,
  although it is also a powerful scripting language.
- [Oh My Zsh](http://ohmyz.sh) - An open source, community-driven framework for
  managing your Zsh configuration.
- [Prezto](https://github.com/sorin-ionescu/prezto) - A speedy Zsh framework.
  Enriches the command line interface environment with sane defaults, aliases,
  functions, auto completion, and prompt themes.
- [zgen](https://github.com/tarjoilija/zgen) - Another open source framework
  for managing your zsh configuration. Zgen will load oh-my-zsh compatible
  plugins and themes and has the advantage of both being faster and
  automatically cloning any plugins used in your configuration for you.

### Terminal Fonts

- [Anonymous Pro](http://www.marksimonson.com/fonts/view/anonymous-pro) - A
  family of four fixed-width fonts designed with coding in mind.
- [Codeface](https://github.com/chrissimpkins/codeface) - A gallery and
  repository of monospaced fonts for developers.
- [DejaVu Sans Mono](https://dejavu-fonts.github.io/) - A font family based on
  the Vera Fonts.
- [Fantasque Sans Mono](https://github.com/belluzj/fantasque-sans) - Designed
  with functionality in mind, and with some wibbly-wobbly handwriting-like
  fuzziness that makes it unassumingly cool.
- [Hack](http://sourcefoundry.org/hack/) - Hack is hand groomed and optically
  balanced to be your go-to code face.
- [Inconsolata](http://levien.com/type/myfonts/inconsolata.html) -  A monospace
  font, designed for code listings and the like.
- [Input](http://input.fontbureau.com) - A flexible system of fonts designed
  specifically for code.
- [Meslo](https://github.com/andreberg/Meslo-Font) - Customized version of
  Apple's Menlo font.
- [Operator Mono](https://www.typography.com/fonts/operator/overview/) - A
  surprisingly usable alternative take on a monospace font (commercial).
- [Powerline Fonts](https://github.com/powerline/fonts) - Repo of patched fonts
  for the Powerline plugin.
- [Source Code Pro](https://adobe-fonts.github.io/source-code-pro/) - A
  monospaced font family for user interfaces and coding environments.


## Glossary

### Mac OS X, OS X, and macOS Version Information

Version                    | Codename           | Release Date       | Most Recent Version
-------------------------- | ------------------ | ------------------ | -------------------------------------
Rhapsody Developer Release | Grail1Z4 / Titan1U | August 31, 1997    | DR2 (May 14, 1998)
Mac OS X Server 1.0        | Hera               | March 16, 1999     | 1.2v3 (October 27, 2000)
Mac OS X Developer Preview | n/a                | March 16, 1999     | DP4 (April 5, 2000)
Mac OS X Public Beta       | Kodiak             | September 13, 2000 | n/a
Mac OS X 10.0              | Cheetah            | March 24, 2001     | 10.0.4 (June 22, 2001)
Mac OS X 10.1              | Puma               | September 25, 2001 | 10.1.5 (June 6, 2002)
Mac OS X 10.2              | Jaguar             | August 24, 2002    | 10.2.8 (October 3, 2003)
Mac OS X 10.3              | Panther            | October 24, 2003   | 10.3.9 (April 15, 2005)
Mac OS X 10.4              | Tiger              | April 29, 2005     | 10.4.11 (November 14, 2007)
Mac OS X 10.5              | Leopard            | October 26, 2007   | 10.5.8 (August 5, 2009)
Mac OS X 10.6              | Snow Leopard       | August 28, 2009    | 10.6.8 v1.1 (July 25, 2011)
Mac OS X 10.7              | Lion               | July 20, 2011      | 10.7.5 (September 19, 2012)
OS X 10.8                  | Mountain Lion      | July 25, 2012      | 10.8.5 (12F45) (October 3, 2013)
OS X 10.9                  | Mavericks          | October 22, 2013   | 10.9.5 (13F1112) (September 18, 2014)
OS X 10.10                 | Yosemite           | October 16, 2014   | 10.10.5 (14F27) (August 13, 2015)
OS X 10.11                 | El Capitan         | September 30, 2015 | 10.11.6 (15G31) (July 18, 2016)
macOS 10.12                | Sierra             | September 20, 2016 | 10.12.6 (16G29) (July 19, 2017)
macOS 10.13                | High Sierra        | September 25, 2017 | 10.13.6 (17G65) (July 9, 2018)
macOS 10.14                | Mojave             | September 24, 2018 | 10.14.6 (18G3020) (January 28, 2020)
macOS 10.15                | Catalina           | October 7, 2019    | 10.15.5 (19F101) (June 1, 2020)



<img src="https://cdn.rawgit.com/herrbischoff/awesome-osx-command-line/master/assets/logo.svg" width="600">

# Functions

> An assorted collection of useful OS X specific Bash-style functions. Part of [Awesome OS X Command Line](https://github.com/herrbischoff/awesome-osx-command-line).

## Table of Contents

- [Developer](#developer)
    - [App Icons](#app-icons)
        - [Create App Icon](#create-app-icon)
    - [Helper Functions](#helper-functions)
        - [Ask User for Password](#ask-user-for-password)

- [Finder](#finder)
    - [Get Path of Frontmost Finder Window](#get-path-of-frontmost-finder-window)
    - [Print Files Selected in Finder](#print-files-selected-in-finder)
    - [Set Current Directory's Finder View to Column View](#set-current-directorys-finder-view-to-column-view)
    - [Set Current Directory's Finder View to Icon View](#set-current-directorys-finder-view-to-icon-view)
    - [Set Current Directory's Finder View to List View](#set-current-directorys-finder-view-to-list-view)


## Developer

### App Icons

#### Create App Icon

Function to quickly create an application icon from 1024px master file.

```bash
function mkicns() {
    if [[ -z "$@" ]]; then
        echo "Input file missing"
    else
        filename=${1%.*}
        mkdir $filename.iconset
        sips -z 16 16   $1 --out $filename.iconset/icon_16x16.png
        sips -z 32 32   $1 --out $filename.iconset/icon_16x16@2x.png
        sips -z 32 32   $1 --out $filename.iconset/icon_32x32.png
        sips -z 64 64   $1 --out $filename.iconset/icon_32x32@2x.png
        sips -z 128 128 $1 --out $filename.iconset/icon_128x128.png
        sips -z 256 256 $1 --out $filename.iconset/icon_128x128@2x.png
        sips -z 256 256 $1 --out $filename.iconset/icon_256x256.png
        sips -z 512 512 $1 --out $filename.iconset/icon_256x256@2x.png
        sips -z 512 512 $1 --out $filename.iconset/icon_512x512.png
        cp $1 $filename.iconset/icon_512x512@2x.png
        iconutil -c icns $filename.iconset
        rm -r $filename.iconset
    fi
}
```

### Helper Functions

#### Ask User for Password

This function will use AppleScript to present a password entry dialog to make
your scripts a little more user friendly.

```bash
function gui_password {
    if [[ -z $1 ]]; then
        gui_prompt="Password:"
    else
        gui_prompt="$1"
    fi
    PW=$(osascript <<EOF
    tell application "System Events"
        activate
        text returned of (display dialog "${gui_prompt}" default answer "" with hidden answer)
    end tell
EOF
    )

    echo -n "${PW}"
}

```

## Finder

### Get Path of Frontmost Finder Window

```bash
function finder_path {
    osascript -e 'tell application "Finder"'\
        -e "if (${1-1} <= (count Finder windows)) then"\
        -e "get POSIX path of (target of window ${1-1} as alias)"\
        -e 'else' \
        -e 'get POSIX path of (desktop as alias)'\
        -e 'end if' \
        -e 'end tell';
}
```

### Print Files Selected in Finder

```bash
selected() {
    osascript <<EOT
        tell application "Finder"
            set theFiles to selection
            set theList to ""
            repeat with aFile in theFiles
                set theList to theList & POSIX path of (aFile as alias) & "\n"
            end repeat
            theList
        end tell
EOT
}
```

### Set Current Directory's Finder View to Column View

```bash
function column_view {
    osascript -e 'set cwd to do shell script "pwd"'\
      -e 'tell application "Finder"'\
      -e "if (${1-1} <= (count Finder windows)) then"\
      -e "set the target of window ${1-1} to (POSIX file cwd) as string"\
      -e "set the current view of the front Finder window to column view"\
      -e 'else' -e "open (POSIX file cwd) as string"\
      -e "set the current view of the front Finder window to column view"\
      -e 'end if' -e 'end tell';
}
```

### Set Current Directory's Finder View to Icon View

```bash
function icon_view {
    osascript -e 'set cwd to do shell script "pwd"'\
      -e 'tell application "Finder"'\
      -e "if (${1-1} <= (count Finder windows)) then"\
      -e "set the target of window ${1-1} to (POSIX file cwd) as string"\
      -e "set the current view of the front Finder window to icon view"\
      -e 'else' -e "open (POSIX file cwd) as string"\
      -e "set the current view of the front Finder window to icon view"\
      -e 'end if' -e 'end tell';
};
```

### Set Current Directory's Finder View to List View

```bash
function list_view {
  osascript -e 'set cwd to do shell script "pwd"'\
    -e 'tell application "Finder"'\
    -e "if (${1-1} <= (count Finder windows)) then"\
    -e "set the target of window ${1-1} to (POSIX file cwd) as string"\
    -e "set the current view of the front Finder window to list view"\
    -e 'else' -e "open (POSIX file cwd) as string"\
    -e "set the current view of the front Finder window to list view"\
    -e 'end if' -e 'end tell';\
}
```


<img src="https://cdn.rawgit.com/herrbischoff/awesome-osx-command-line/master/assets/logo.svg" width="600">

# LaunchAgents

> An assorted collection of useful LaunchAgent examples. Part of [Awesome OS X Command Line](https://github.com/herrbischoff/awesome-osx-command-line).

## Table of Contents

- [Basic Examples](#basic-examples)
- [Homebrew](#homebrew)

## Basic Examples

### Periodical Job Template
Run job every 5 minutes.
```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>Label</key>
    <string>com.example.touchsomefile</string>
    <key>ProgramArguments</key>
    <array>
        <string>touch</string>
        <string>/tmp/helloworld</string>
    </array>
    <key>StartInterval</key>
    <integer>300</integer>
</dict>
</plist>
```

### Periodical via Calendar Interval Job Template
```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>Label</key>
    <string>com.example.touchsomefile</string>
    <key>ProgramArguments</key>
    <array>
        <string>touch</string>
        <string>/tmp/helloworld</string>
    </array>
    <key>StartCalendarInterval</key>
    <dict>
        <key>Minute</key>
        <integer>45</integer>
        <key>Hour</key>
        <integer>13</integer>
        <key>Day</key>
        <integer>7</integer>
    </dict>
</dict>
</plist>
```

### Monitoring Folder Job Template
```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>Label</key>
    <string>com.example.watchhostconfig</string>
    <key>ProgramArguments</key>
    <array>
        <string>syslog</string>
        <string>-s</string>
        <string>-l</string>
        <string>notice</string>
        <string>somebody touched /etc/hostconfig</string>
    </array>
    <key>WatchPaths</key>
    <array>
        <string>/etc/hostconfig</string>
    </array>
</dict>
</plist>
```


## Homebrew

### Periodic Homebrew Update and Upgrade
To leverage the notification system, this agent requires [terminal-notifier](https://github.com/julienXX/terminal-notifier), which can be installed via `brew install terminal-notifier`.
```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>Label</key>
    <string>com.example.homebrew-upgrade</string>
    <key>ProcessType</key>
    <string>Background</string>
    <key>ProgramArguments</key>
    <array>
        <string>/bin/sh</string>
        <string>-c</string>
        <string>/usr/local/bin/brew update &amp;&amp; /usr/local/bin/brew upgrade &amp;&amp; /usr/local/bin/terminal-notifier -title 'Homebrew Upgrader' -message 'Homebrew upgraded!' -appIcon http://cdn.curvve.com/wp-content/uploads/2013/09/homebrew_osx_logo.png</string>
    </array>
    <key>RunAtLoad</key>
    <true/>
    <key>StandardErrorPath</key>
    <string>/tmp/com.example.homebrew-upgrade.stderr</string>
    <key>StandardOutPath</key>
    <string>/tmp/com.example.homebrew-upgrade.stdout</string>
    <key>StartCalendarInterval</key>
    <array>
        <dict>
            <key>Hour</key>
            <integer>8</integer>
        </dict>
    </array>
</dict>
</plist>
```



## Additional commands used during setup

Disable the sound effects on boot
```sh
sudo nvram SystemAudioVolume=" "
```

Menu bar: show battery percentage
```sh
defaults write com.apple.menuextra.battery ShowPercent YES
```

Disable the “Are you sure you want to open this application?” dialog
```sh
defaults write com.apple.LaunchServices LSQuarantine -bool false
```

Automatically illuminate built-in MacBook keyboard in low light
```sh
defaults write com.apple.BezelServices kDim -bool true
```

Turn off keyboard illumination when computer is not used for 5 minutes
```sh
defaults write com.apple.BezelServices kDimTime -int 300
```

Increase sound quality for Bluetooth headphones/headsets
```sh
defaults write com.apple.BluetoothAudioAgent "Apple Bitpool Min (editable)" -int 40
```

Require password immediately after sleep or screen saver begins
```sh
defaults write com.apple.screensaver askForPassword -int 1
defaults write com.apple.screensaver askForPasswordDelay -int 0
```

Save screenshots to the desktop
```sh
defaults write com.apple.screencapture location -string "${HOME}/Desktop"
```

Save screenshots in PNG format (other options: BMP, GIF, JPG, PDF, TIFF)
```sh
defaults write com.apple.screencapture type -string "png"
```

Finder: allow quitting via ⌘ + Q; doing so will also hide desktop icons
```sh
defaults write com.apple.finder QuitMenuItem -bool true
```

When performing a search, search the current folder by default
```sh
defaults write com.apple.finder FXDefaultSearchScope -string "SCcf"
```

Disable the warning when changing a file extension
```sh
defaults write com.apple.finder FXEnableExtensionChangeWarning -bool false
```

Show indicator lights for open applications in the Dock
```sh
defaults write com.apple.dock show-process-indicators -bool true
```

Make Dock icons of hidden applications translucent
```sh
defaults write com.apple.dock showhidden -bool true
```





