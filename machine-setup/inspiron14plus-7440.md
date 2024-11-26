# Inspiron 14 Plus 7440 - Development Setup

## Find & Install Applications

Example: Search ExpressVPN

```
winget search expressvpn
```

```
# OUTPUT

Name       Id                    Version   Source
---------------------------------------------------
ExpressVPN XP9M14XF781P6R        Unknown   msstore
ExpressVPN ExpressVPN.ExpressVPN 12.94.0.2 winget
```

Example: Install ExpressVPN

```
winget install ExpressVPN.ExpressVPN
```

## Installation Scripts

```
# BROWSERS
winget install Google.Chrome             # stable, fully tested - updated every 2-3 weeks
# winget install Google.Chrome.Beta      # new features, minimal risk - updated every week (approx.), generally a month ahead of stable channel 
# winget install Google.Chrome.Dev       # in-progress features, in-progress testing, medium risk - updated 1-2 times weekly
# winget install Google.Chrome.Canary    # bleeding edge, has not been tested, high risk - updated daily
# winget install Mozilla.Firefox
winget install Mozilla.Firefox.DeveloperEdition

# IDE'S
winget install Microsoft.VisualStudio.2022.Professional
winget install Microsoft.VisualStudioCode
winget install Microsoft.SQLServer.2019.Developer
winget install Microsoft.SQLServerManagementStudio

# MISCELLANEOUS
winget install Git.Git
winget install ExpressVPN.ExpressVPN
winget install AgileBits.1Password
winget install Microsoft.Teams
```

## Install NVM for Windows

⚠️ IF NODE.JS IS ALREADY INSTALLED ON YOUR MACHINE, IT MUST BE UNINSTALLED BEFORE PROCEEDING.

1. Navigate to the [nvm-windows](https://github.com/coreybutler/nvm-windows) repository and click `Download Now!`
2. Find the lastest version and click `nvm-setup.exe` to download.
3. Locate and run the installer (`nvm-setup.exe`) you just downloaded.
4. Follow the steps in the installation wizard (using the wizard's default suggestions is typically appropriate).
5. Open (or close and reopen) PowerShell and run `nvm -v` to confirm the installation.

## Resources

- [How I've set up my new Windows development environment in 2022](https://timdeschryver.dev/blog/how-i-have-set-up-my-new-windows-development-environment-in-2022) (10.23.2023)
- [Rebuilding My Windows Development Environment](https://jasontaylor.dev/rebuilding-my-windows-development-environment/) (11.11.2022)
- [NVM for Windows – How to Download and Install Node Version Manager in Windows 10](https://www.freecodecamp.org/news/nvm-for-windows-how-to-download-and-install-node-version-manager-in-windows-10/) (08.11.2022)


