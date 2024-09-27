<!----------------------------------------------------------
 :::= === :::====  :::====  :::====      ::: :::====
 :::===== :::  === :::  === :::  ===     ::: :::  ===
 ======== ===  === ===  === ===  ===     === ===  ===
 === ==== ===  === ===  === ===  === ==  === ===  ===
 ===  ===  ======  =======   ======  ======   ======
------------------------------------------------------------>
# Go Commands

### Install Go
```
brew install go
```

### Update Go if it's located outside of the GOPATH
```
brew upgrade go
```

### Output Go env variable paths to console
```
go env
```

### Get/Update Go module
```
go get github.com/username/reponame
```

### Run by file name
```
go run main.go
```

### Run all tests
```
go test ./... -v
```

### To fix the error: File is not goimports-ed (goimports)
```
gofmt -w yourfile.go
```

### Find out if the function you're calling is a loop is inlined
```
go build -gcflags -m
```

## Additional Notes

### Enable the use of Go modules in GoLand
```
GoLand > Preferences > Go > Go Modules(vgo)
```

### Force VS Code to reinstall its tools
```
cmd + shift + p
select Go: Install and Update Tools
```
