# Miscellaneous macOS commands

### Delete all .DS_Store files from your machine

This command resets the folder settings across the entire machine. When the command completes, the view options you set by clicking "Use as Defaults" will be applied globally. This prevents individually set folder options from overriding the options you've set as your defaults.

```sh
sudo find / -name .DS_Store -delete; killall Finder
```

## Resources

- [An A-Z Index of Apple macOS (bash) commands](https://ss64.com/mac/index.html)
