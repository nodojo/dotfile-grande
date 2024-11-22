# MongoDB Cheat Sheet

## Install MongoDB on macOS

1. Tap the [MongoDB Homebrew Tap](https://github.com/mongodb/homebrew-brew) to download the official Homebrew formula for MongoDB and the Database Tools:

  ```
  brew tap mongodb/brew
  ```

2. Install MongoDB Community Edition ([*docs*](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-os-x/)):

  ```
  brew install mongodb-community
  ```

## Run MongoDB Community Edition

You can run MongoDB as a macOS service using brew, or you can run MongoDB manually as a background process
([*docs*](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-os-x/#run-mongodb-community-edition)).
It is recommended to run MongoDB as a macOS service, as doing so sets the correct system
[ulimit](https://www.mongodb.com/docs/manual/tutorial/install-mongodb-on-os-x/) values automatically.

⚠️ *These instructions assume you intend to use the default settings.*

#### Run MongoDB as macOS service (recommended)

- Run MongoDB (i.e. the [mongod](https://www.mongodb.com/docs/manual/reference/program/mongod/#mongodb-binary-bin.mongod) process):

  ```
  brew services start mongodb-community
  ```

- Stop MongoDB (a `mongod`) that is running:

  ```
  brew services stop mongodb-community
  ```

- To verify MongoDB is running:

  ```
  brew services list
  ```

  **NOTE:** You should see the service `mongodb-community` listed as `started`. You can also view the log file to see the current status of your `mongod` process: `/usr/local/var/log/mongodb/mongo.log`.

## Resources

 - [MongoDB Manual](https://www.mongodb.com/docs/manual/)
 - [mongod - MongoDB Package Component](https://www.mongodb.com/docs/manual/reference/program/mongod/)
 - [MongoDB Database Tools](https://www.mongodb.com/docs/database-tools/)
 - [MongoDB Atlas](https://www.mongodb.com/docs/atlas/)
