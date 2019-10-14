<!-----------------------------
 ____ ____ ____ ____ ____ ____
||n |||o |||d |||o |||j |||o ||
||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|

------------------------------->

# **From: 25 Linux Commands for System Admins**


**Show information about available commands:**
```
$ man + name_of_program_goes_here

// Examples
$ man ascii                                     // show commands offered for ascii
$ man units                                     // show commands offered for units
$ man man                                       // show commands offered for man
```

**Show how long the system has been running:**
```sh
$ uptime
```

**Show who is logged in to your system and what they are currently doing:**
```sh
$ w
```

**Show username(s) of user(s) currently logged in to your system:**
```sh
$ users
```

**Print username of user you're currently logged in as:**
```sh
$ whoami
```

**Find and output search query along with surrounding text:**
```sh
$ grep

// Examples
$ grep -r "facebook"                            // search recursively
$ grep -r -l "facebook"                         // output filenames instead of text
```

**Reduce length of output (if too verbose):**
```sh
$ less
```

**Provides helpers to display, copy, or combine text:**
```sh
$ cat .gitignore
```

**Print absolute path of current working directory:**
```
$ pwd
```

**Connect to a remote server:**
```sh
$ ssh

// Examples
$ ssh remote_host
$ ssh remote_username@remote_host
```

**Copy files securely and remotely over servers:**
```sh
$ scp
```

**Run any command as a superuser(root):**
```sh
$ sudo
```

**Can be used to perform tasks from various services:**
```sh
$ service

// Example
$ service apache restart
```

**Find files on your system by name:**
```sh
$ locate
```

**Change file permissions:**
```sh
$ chmod
```

**Change ownership of a file to a user or user group:**
```sh
$ chown
```

**Kill a process:**
```sh
$ pkill
```

**Manage cron jobs:**
```
$ crontab
$ crontab -l                                    // List jobs
```

**Assign a shortened name to an existing command:**

**(must be defined in an .--rc file(.bashrc, .zshrc, etc.) to save for later use)*
```
$ alias

// Example
$ alias mycmd='cat requirements.txt'
```

**Output text:**
```
$ echo
```

**Copy string to system clipboard:**
```
$ echo string_to_copy_goes_here | pbcopy
```

**Copy html from webpage to system clipboard:**
```sh
// Example
$ curl https://stackoverflow.com/$ | pbcopy
```

**Compare two file byte by byte:**
```sh
$ cmp

// Example
$ cmp firstfile.txt secondfile.txt
```

**Mount a file system:**
```sh
$ mount
```

**Display the memory map for a process:**
```sh
$ pmap

// Example
$ pmap -x pid_goes_here
```

**Get the PID for a process:**
```sh
$ ps aux | grep process_name_goes_here

// Example
$ ps aux | grep terminal
```

**Download a file from a network*:**
```sh
$ wget

// Example
$ wget path_to_file_goes_here
```

**Display/Configure network's interface:**
```sh
$ ifconfig
```


### **From: 15 Little Known Unix Commands**

**Network diagnostic tool that combines tracerout and ping:**
```sh
$ mtr host_name_goes_here

//Example
$ mtr --report google.com
```

**Omit command from command log in ~/.bash_history:**
```sh
$ space THEN cmd
```

**Generate random numbers or text:**
```sh
$ jot

// Example
$ jot -r number_of_random_numbers_to_display_goes_here number_to_start_on_goes_here
```

**Show the amount of available disk space:**
```sh
$ df
```

**Display a calendar with the current date highlighted:**
```sh
$ cal
```

**Provides a range of utilities (ex: create, copy, merge, display, etc.):**
```sh
$ tac
```

**Repeat a word to the output:**
```sh
$ yes word_to_repeat_goes_here
```

**Add line numbers to terminal output:**
```sh
$ nl

// Example
$ cat .gitconfig | nl
```
