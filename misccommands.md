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
$ brew tap caskroom/cask        # Tap the Caskroom/Cask GitHub repo. using HTTPS.
$ brew list                     # List all the installed formulae.
$ brew outdated                 # Show formulae with an updated version available.
$ brew upgrade                  # Upgrade all outdated and unpinned brews.
$ brew upgrade [formula]        # Upgrade only specified brews (even if they are pinned).
$ brew pin [formulae]           # Pin specified formulae (Prevents upgrade - 'brew upgrade').
$ brew info [formulae]          # Display information about formula.
$ brew cleanup                  # Remove any older versions from the cellar.
```

**Install & Manage Google Chrome**

* *[How to install Google Chrome on macOS using Homebrew](https://www.code2bits.com/how-to-install-chrome-on-macos-using-homebrew/)*
* *[Google Chrome](https://en.wikipedia.org/wiki/Google_Chrome)*
```
$ brew search google-chrome             # Searches all Casks for partial/exact match.
$ brew cask info google-chrome          # Displays information about the given Cask.
$ brew cask install google-chrome       # Install the given cask.
```

**Install & Manage Firefox**

* *[How to install Firefox on macOS using Homebrew](https://www.code2bits.com/how-to-install-firefox-on-macos-using-homebrew/)*
* *[Wikipedia: Firefox](https://en.wikipedia.org/wiki/Firefox)*
```
$ brew search firefox                   # Searches all Casks for partial/exact match.
$ brew cask info firefox                # Displays information about the given Cask.
$ brew cask install firefox             # Install the given cask.
```

**Install & Manage Visual Studio Code**

* *[How to install Visual Studio Code on macOS using Homebrew](https://www.code2bits.com/how-to-install-visual-studio-code-on-macos-using-homebrew/)*
* *[Visual Studio Code](https://code.visualstudio.com/)*
```
$ brew search visual-studio-code        # Searches all Casks for partial/exact match.
$ brew cask info visual-studio-code     # Displays information about the given Cask.
$ brew cask install visual-studio-code  # Install the given cask.
```

**Install & Manage WebStorm**

* *[How to install WebStorm on macOS using Homebrew](https://www.code2bits.com/how-to-install-webstorm-on-macos-using-homebrew/)*
* *[WebStorm](https://www.jetbrains.com/webstorm/)*
```
$ brew search webstorm        # Searches all Casks for partial/exact match.
$ brew cask info webstorm     # Displays information about the given Cask.
$ brew cask install webstorm  # Install the given cask.
```

**Install & Manage iTerm2**

* *[How to install iTerm2 on macOS using Homebrew](https://www.code2bits.com/how-to-install-iterm2-on-macos-using-homebrew/)*
* *[Wikipedia: iTerm2](https://en.wikipedia.org/wiki/ITerm2)*
```
$ brew search iterm2           # Searches all Casks for partial/exact match.
$ brew cask info iterm2        # Displays information about the given Cask.
$ brew cask install iterm2     # Install the given cask.
```

**Install & Manage Git**

* *[How to install Git on macOS using Homebrew](https://www.code2bits.com/how-to-install-git-on-macos-using-homebrew/)*
* *[Wikipedia: Git](https://en.wikipedia.org/wiki/Git)*
```
$ brew search git             # Searches all formulae for partial/exact match.
$ brew info git               # Displays information about the given formulae.
$ brew install git            # Install the given formulae.
```

**Install & Manage Docker**

* *[How to install Docker on macOS using Homebrew](https://www.code2bits.com/how-to-install-docker-on-macos-using-homebrew/)*
* *[AWS CLI](https://en.wikipedia.org/wiki/Docker_(software))*
```
$ brew search docker          # Searches all Casks for partial/exact match.
$ brew cask info docker       # Displays information about the given Cask.
$ brew cask install docker    # Install the given cask.
```

**Install & Manage Node.js**

* *[How to install Node.js on macOS using Homebrew](https://www.code2bits.com/how-to-install-node-on-macos-using-homebrew/)*
* *[Node.js](https://nodejs.org/en/)*
```
$ brew search node             # Searches all formulae for partial/exact match.
$ brew info node               # Displays information about the given formulae.
$ brew install node            # Install the given formulae.
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

* *[How to install Redis on macOS using Homebrew](https://www.code2bits.com/how-to-install-redis-on-macos-using-homebrew/)*
* *[Wikipedia: Redis](https://en.wikipedia.org/wiki/Redis)*
```
$ brew search redis           # Searches all Casks for partial/exact match.
$ brew info redis             # Displays information about the given formulae.
$ brew install redis          # Install the given formulae.
```

**Install & Manage MongoDB**

* *[How to install MongoDB on macOS using Homebrew](https://www.code2bits.com/how-to-install-mongodb-on-macos-using-homebrew/)*
* *[MongoDB](https://www.mongodb.com/what-is-mongodb)*
```
$ brew search mongodb        # Searches all formulae for partial/exact match.
$ brew info mongodb          # Displays information about the given formulae.
$ brew install mongodb       # Install the given formulae.
```

**Run MongoDB (steps 1-4)**

* *[How to run MongoDB on macOS using Homebrew](https://www.code2bits.com/how-to-run-mongodb-on-macos-using-homebrew/)*

***1. Configure MongoDB***
```
$ sudo mkdir -p /data/db                # Create data directory to write data files.
$ sudo chown $USER /data/db             # Update permissions to access directory.
```
***2. Start MongoDB***
```
$ mongod                                # Start MongoDB.
$ mongod --dbpath "/new/db/path"        # Specify directory if different than above.
```
***3. Stop & Start MongoDB as Background Service***
```
$ brew services list | grep mongodb     # List running processes & filter on MongoDB.
$ brew services start mongodb           # Set MongoDB to register & start on login.
$ brew services stop mongodb            # Set MongoDB to unregister & stop on login.
```
***4. Access MongoDB Shell***
```
$ mongo                                 # Start the Mongo shell.
```

**Install & Manage Neo4j**

* *[How to install Neo4j on macOS using Homebrew](https://www.code2bits.com/how-to-install-neo4j-on-macos-using-homebrew/)*
* *[Wikipedia: Neo4j](https://en.wikipedia.org/wiki/Neo4j)*
```
$ brew search neo4j          # Searches for formula called neo4j
$ brew info neo4j            # Displays information about neo4j
$ brew install neo4j         # Install the neo4j formulae.
```

**Install & Manage AWS CLI**

* *[How to install AWS CLI on macOS using Homebrew](https://www.code2bits.com/how-to-install-awscli-on-macos-using-homebrew/)*
* *[Wikipedia: Redis](https://aws.amazon.com/cli/)*
```
$ brew search awscli         # Searches all formulae for partial/exact match.
$ brew info awscli           # Displays information about the given formulae.
$ brew install awscli        # Install the given formulae.
```

**Install & Manage cURL**

* *[How to install cURL on macOS using Homebrew](https://www.code2bits.com/how-to-install-curl-on-macos-using-homebrew/)*
* *[Wikipedia: cURL](https://en.wikipedia.org/wiki/CURL)*
```
$ brew search curl          # Searches all Casks for partial/exact match.
$ brew info curl            # Displays information about the given formulae.
$ brew install curl         # Install the given formulae.
```

**Install & Manage Slack**

* *[How to install Slack on macOS using Homebrew](https://www.code2bits.com/how-to-install-slack-on-macos-using-homebrew/)*
* *[Wikipedia: Slack](https://en.wikipedia.org/wiki/Slack_(software))*
```
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
$ brew search notion           # Searches all Casks for partial/exact match.
$ brew info notion             # Displays information about the given Cask.
$ brew install notion          # Install the given cask.
```

**Install & Manage Typora**

* *[How to install Typora on macOS using Homebrew](https://www.code2bits.com/how-to-install-typora-on-macos-using-homebrew/)*
* *[Typora](https://typora.io/)*
```
$ brew search typora           # Searches all Casks for partial/exact match.
$ brew cask info typora        # Displays information about the given Cask.
$ brew cask install typora     # Install the given cask.
```

**Install & Manage Spectacle**

* *[How to install Spectacle on macOS using Homebrew](https://www.code2bits.com/how-to-install-spectacle-on-macos-using-homebrew/)*
* *[Spectacle](https://www.spectacleapp.com/)*
```
$ brew search spectacle        # Searches all Casks for partial/exact match.
$ brew cask info spectacle     # Displays information about the given Cask.
$ brew cask install spectacle  # Install the given cask.
```

**Install & Manage Grammarly**

* *[How to install Grammarly on macOS using Homebrew](https://www.code2bits.com/how-to-install-grammarly-on-macos-using-homebrew/)*
* *[Wikipedia: Grammarly](https://en.wikipedia.org/wiki/Grammarly)*
```
$ brew search grammarly        # Searches all Casks for partial/exact match.
$ brew cask info grammarly     # Displays information about the given Cask.
$ brew cask install grammarly  # Install the given cask.
```

**Install & Manage Postman**

* *[How to install Postman on macOS using Homebrew](https://www.code2bits.com/how-to-install-postman-on-macos-using-homebrew/)*
* *[Postman](https://www.getpostman.com/)*
```
$ brew search postman          # Searches all Casks for partial/exact match.
$ brew cask info postman       # Displays information about the given Cask.
$ brew cask install postman    # Install the given cask.
```

**Install & Manage Insomnia**

* *[How to install Insomnia on macOS using Homebrew](https://www.code2bits.com/how-to-install-insomnia-on-macos-using-homebrew/)*
* *[Insomnia](https://support.insomnia.rest/article/11-getting-started)*
```
$ brew search insomnia         # Searches all Casks for partial/exact match.
$ brew cask info insomnia      # Displays information about the given Cask.
$ brew cask install insomnia   # Install the given cask.
```

**Install & Manage Evernote**

* *[How to install Evernote on macOS using Homebrew](https://www.code2bits.com/how-to-install-evernote-on-macos-using-homebrew/)*
* *[Wikipedia: Evernote](https://en.wikipedia.org/wiki/Evernote)*
```
$ brew search evernote         # Searches all Casks for partial/exact match.
$ brew cask info evernote      # Displays information about the given Cask.
$ brew cask install evernote   # Install the given cask.
```

 **Install & Manage iStat Menu**

* *[How to install iStat Menu on macOS using Homebrew](https://www.code2bits.com/how-to-install-istat-menu-on-macos-using-homebrew/)*
* *[iStat Menu](https://bjango.com/mac/istatmenus/)*
```
$ brew search istat-menus       # Searches all Casks for partial/exact match.
$ brew cask info istat-menus    # Displays information about the given Cask.
$ brew cask install istat-menus # Install the given cask.
```

**Install & Manage Wireshark**

* *[How to install Wireshark on macOS using Homebrew](https://www.code2bits.com/how-to-install-wireshark-on-macos-using-homebrew/)*
* *[Wikipedia: Wireshark](https://en.wikipedia.org/wiki/Wireshark)*
```
$ brew search wireshark        # Searches all Casks for partial/exact match.
$ brew cask info wireshark     # Displays information about the given Cask.
$ brew cask install wireshark  # Install the given cask.
```

**Install & Manage DiffMerge**

* *[How to install DiffMerge on macOS using Homebrew](https://www.code2bits.com/how-to-install-diffmerge-on-macos-using-homebrew/)*
* *[DiffMerge](https://sourcegear.com/diffmerge/)*
```
$ brew search diffmerge       # Searches all Casks for partial/exact match.
$ brew cask info diffmerge    # Displays information about the given Cask.
$ brew cask install diffmerge # Install the given cask.
```

**Install & Manage Logstash**

* *[How to install Logstash on macOS using Homebrew](https://www.code2bits.com/how-to-install-logstash-on-macos-using-homebrew/)*
* *[Logstash Documentation](https://www.elastic.co/guide/en/logstash/current/introduction.html)*
```
$ brew search logstash       # Searches for formula called logstash.
$ brew info logstash         # Displays information about logstash.
$ brew install logstash      # Install the logstash formulae.
```

**Install & Manage Kibana**

* *[How to install Kibana on macOS using Homebrew](https://www.code2bits.com/how-to-install-kibana-on-macos-using-homebrew/)*
* *[Kibana Documentation](https://www.elastic.co/guide/en/kibana/current/introduction.html)*
```
$ brew search kibana       # Searches for formula called kibana.
$ brew info kibana         # Displays information about kibana.
$ brew install kibana      # Install the kibana formulae.
```