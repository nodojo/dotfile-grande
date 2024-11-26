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
