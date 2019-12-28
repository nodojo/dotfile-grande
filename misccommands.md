<!----------------------------------------------------------
                                 o                     o
                                <|>                  _<|>_
                                < \
 \o__ __o     o__ __o      o__ __o/    o__ __o         o      o__ __o
  |     |>   /v     v\    /v     |    /v     v\       <|>    /v     v\
 / \   / \  />       <\  />     / \  />       <\      / \   />       <\
 \o/   \o/  \         /  \      \o/  \         /      \o/   \         /
  |     |    o       o    o      |    o       o        |     o       o
 / \   / \   <\__ __/>    <\__  / \   <\__ __/>       < >    <\__ __/>
                                                       |
                                               o__     o
                                               <\__ __/>
------------------------------------------------------------>

# **Miscellaneous Commands**

**Install iTerm2:**
```
$ brew cask iterm2
```

**Install Sublime:**
```
$ brew install subl
```

**Install Docker:**
```
$ brew cask install docker
```

**Source Code Pro Download:**
```
$ brew caskroom/fonts && brew cask install
```

**Take screenshots of a site as its assets are loading (chrome):**
```
Inspect -> Network Tab -> Camera Icon
```

**Paste text without formatting:**
```
cmd + shift + option + v
```

**Fix for Chrome Apps.localized issue in termial**

* *[Mac terminal Chrome Apps.localized](https://stackoverflow.com/questions/26261427/mac-terminal-chrome-apps-localized)*
```
$ cd /Applications
```

<!----------------------------------------------------------
    from: https://www.code2bits.com/category/homebrew/
------------------------------------------------------------>

**Update Homebrew Casks & Formulae**

* *[How to Update Homebrew Casks & Formulae on macOS](https://www.code2bits.com/how-to-update-homebrew-cask-formula-on-macos/)*
```
$ brew update                   # Fetch latest version of homebrew and formula.
$ brew list                     # List all the installed formulae.
$ brew outdated                 # Show formulae with an updated version available.
$ brew upgrade                  # Upgrade all outdated and unpinned brews.
$ brew upgrade [formula]        # Upgrade only specified brews (even if they are pinned).
$ brew pin [formulae]           # Pin specified formulae (Prevents upgrade - 'brew upgrade').
$ brew info [formulae]          # Display information about formula.
$ brew cleanup                  # Remove any older versions from the cellar.
```

**Install & Manage Visual Studio Code**

* *[How to install Visual Studio Code on macOS using Homebrew](https://www.code2bits.com/how-to-install-visual-studio-code-on-macos-using-homebrew/)*
* *[Visual Studio Code](https://code.visualstudio.com/)*
```
$ brew tap caskroom/cask                # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search visual-studio-code        # Searches all Casks for partial/exact match.
$ brew cask info visual-studio-code     # Displays information about the given Cask
$ brew cask install visual-studio-code  # Install the given cask.
```

**Install & Manage iTerm2**

* *[How to install iTerm2 on macOS using Homebrew](https://www.code2bits.com/how-to-install-iterm2-on-macos-using-homebrew/)*
* *[Wikipedia: iTerm2](https://en.wikipedia.org/wiki/ITerm2)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search iterm2           # Searches all Casks for partial/exact match.
$ brew cask info iterm2        # Displays information about the given Cask.
$ brew cask install iterm2     # Install the given cask.
```

**Install & Manage Docker**

* *[How to install Docker on macOS using Homebrew](https://www.code2bits.com/how-to-install-docker-on-macos-using-homebrew/)*
* *[AWS CLI](https://en.wikipedia.org/wiki/Docker_(software))*
```
$ brew tap caskroom/cask                # Tap the Caskroom/Cask repository from Github using HTTPS.
$ brew search docker                    # Searches all Casks for partial/exact match.
$ brew cask info docker                 # Displays information about the given Cask.
$ brew cask install docker              # Install the given cask.
```

**Install & Manage Go**

* *[How to install Go on macOS using Homebrew](https://www.code2bits.com/how-to-install-go-on-macos-using-homebrew/)*
* *[Golang.org](https://golang.org/doc/)*
```
$ brew search go               # Searches all Casks for partial/exact match.
$ brew info go                 # Displays information about the given formulae.
$ brew install go              # Install the given formulae.
```

**Install & Manage PostgreSQL**

* *[How to install PostgreSQL on macOS using Homebrew](https://www.code2bits.com/how-to-install-postgresql-on-macos-using-homebrew/)*
* *[Wikipedia: PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL)*
```
$ brew search postgresql       # Searches all formulae for partial/exact match.
$ brew info postgresql         # Displays information about the given formulae.
$ brew install postgresql      # Install the given formulae.
```

**Install & Manage MySQL**

* *[How to install MySQL on macOS using Homebrew](https://www.code2bits.com/how-to-install-mysql-on-macos-using-homebrew/)*
* *[Wikipedia: MySQL](https://en.wikipedia.org/wiki/MySQL)*
```
$ brew search mysql            # Searches all formulae for partial/exact match.
$ brew info mysql              # Displays information about the given formulae.
$ brew install mysql           # Install the given formulae.
```

**Install & Manage Redis**

* *[How to install Redis on macOS using Homebrew](https://www.code2bits.com/how-to-install-go-on-macos-using-homebrew/)*
* *[Wikipedia: Redis](https://en.wikipedia.org/wiki/Redis)*
```
$ brew search redis           # Searches all Casks for partial/exact match.
$ brew info redis             # Displays information about the given formulae.
$ brew install redis          # Install the given formulae.
```

**Install & Manage Slack**

* *[How to install Slack on macOS using Homebrew](https://www.code2bits.com/how-to-install-slack-on-macos-using-homebrew/)*
* *[Wikipedia: Slack](https://en.wikipedia.org/wiki/Slack_(software))*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search slack            # Searches all Casks for partial/exact match.
$ brew cask info slack         # Displays information about the given Cask.
$ brew cask install slack      # Install the given cask.
```

**Install & Manage Elasticsearch**

* *[How to install Elasticsearch on macOS using Homebrew](https://www.code2bits.com/how-to-install-elasticsearch-on-macos-using-homebrew/)*
* *[Elasticsearch Documentation](https://www.elastic.co/guide/en/elasticsearch/reference/current/getting-started.html)*
```
$ brew search elasticsearch    # Searches for formula called Elasticsearch.
$ brew info elasticsearch      # Displays information about Elasticsearch.
$ brew install elasticsearch   # Install the Elasticsearch formulae.
```

**Install & Manage Ansible**

* *[How to install Ansible on macOS using Homebrew](https://www.code2bits.com/how-to-install-ansible-on-macos-using-homebrew/)*
* *[Ansible](https://www.ansible.com/overview/how-ansible-works)*
```
$ brew search ansible          # Searches for formula called packetbeat.
$ brew info ansible            # Displays information about packetbeat.
$ brew install ansible         # Install the packetbeat formulae.
```

**Install & Manage Tomcat**

* *[How to install Tomcat on macOS using Homebrew](https://www.code2bits.com/how-to-install-tomcat-on-macos-using-homebrew/)*
* *[Wikipedia: Apache Tomcat](https://en.wikipedia.org/wiki/Apache_Tomcat)*
```
$ brew search tomcat           # Searches for formula called packetbeat.
$ brew info tomcat             # Displays information about packetbeat.
$ brew install tomcat          # Install the packetbeat formulae.
```

**Install & Manage Notion**

* *[How to install Notion on macOS using Homebrew](https://www.code2bits.com/how-to-install-notion-on-macos-using-homebrew/)*
* *[Wikipedia: Notion (app)](https://en.wikipedia.org/wiki/Notion_App)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search notion           # Searches all Casks for partial/exact match.
$ brew info notion             # Displays information about the given Cask.
$ brew install notion          # Install the given cask.
```

**Install & Manage Typora**

* *[How to install Typora on macOS using Homebrew](https://www.code2bits.com/how-to-install-typora-on-macos-using-homebrew/)*
* *[Typora](https://typora.io/)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search typora           # Searches all Casks for partial/exact match.
$ brew cask info typora        # Displays information about the given Cask.
$ brew cask install typora     # Install the given cask.
```

**Install & Manage Spectacle**

* *[How to install Spectacle on macOS using Homebrew](https://www.code2bits.com/how-to-install-spectacle-on-macos-using-homebrew/)*
* *[Spectacle](https://www.spectacleapp.com/)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search spectacle        # Searches all Casks for partial/exact match.
$ brew cask info spectacle     # Displays information about the given Cask.
$ brew cask install spectacle  # Install the given cask.
```

**Install & Manage Grammarly**

* *[How to install Grammarly on macOS using Homebrew](https://www.code2bits.com/how-to-install-grammarly-on-macos-using-homebrew/)*
* *[Wikipedia: Grammarly](https://en.wikipedia.org/wiki/Grammarly)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search grammarly        # Searches all Casks for partial/exact match.
$ brew cask info grammarly     # Displays information about the given Cask.
$ brew cask install grammarly  # Install the given cask.
```

**Install & Manage Postman**

* *[How to install Postman on macOS using Homebrew](https://www.code2bits.com/how-to-install-postman-on-macos-using-homebrew/)*
* *[Postman](https://www.getpostman.com/)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search postman          # Searches all Casks for partial/exact match.
$ brew cask info postman       # Displays information about the given Cask.
$ brew cask install postman    # Install the given cask.
```

**Install & Manage Insomnia**

* *[How to install Insomnia on macOS using Homebrew](https://www.code2bits.com/how-to-install-insomnia-on-macos-using-homebrew/)*
* *[Insomnia](https://support.insomnia.rest/article/11-getting-started)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search insomnia         # Searches all Casks for partial/exact match.
$ brew cask info insomnia      # Displays information about the given Cask.
$ brew cask install insomnia   # Install the given cask.
```

**Install & Manage Evernote**

* *[How to install Evernote on macOS using Homebrew](https://www.code2bits.com/how-to-install-evernote-on-macos-using-homebrew/)*
* *[Wikipedia: Evernote](https://en.wikipedia.org/wiki/Evernote)*
```
$ brew tap caskroom/cask       # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew search evernote         # Searches all Casks for partial/exact match.
$ brew cask info evernote      # Displays information about the given Cask.
$ brew cask install evernote   # Install the given cask.
```