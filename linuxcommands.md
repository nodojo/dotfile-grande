<!----------------------------------------------------------
 ____ ____ ____ ____ ____ ____
||n |||o |||d |||o |||j |||o ||
||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|
------------------------------------------------------------>

# **Source: 25 Linux Commands for System Admins**

**Show the manual for a command:**
```
$ man + command_name

// Examples:
$ man ascii                             // show manual for ascii command
$ man units                             // show manual for units command
$ man man                               // show manual for man command
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

// Examples:
$ grep -r "facebook"                // search recursively
$ grep -r -l "facebook"             // output filenames instead of text
```

**Reduce length of output (if too verbose):**
```sh
$ less

// Example:
$ ls filename                      // view file with page navigation
```

**Provides helpers to display, copy, or combine text:**
```sh
$ cat

// Example:
$ cat .gitignore                    // output contents of file
```

**Show present working directory:**
```
$ pwd
```

**Connect to a remote server:**
```sh
$ ssh

// Examples:
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

// Example:
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

**Set visibility of a file to hidden:**
```sh
$ chflags hidden {drag file into terminal here and press enter}
```

**Kill a process:**
```sh
$ pkill
```

**Manage cron jobs:**
```
$ crontab
$ crontab -l                        // list jobs
```

**Assign a shortened name to an existing command:**

\*_must be defined in an .--rc file(.bashrc, .zshrc, etc.) to save for later use_
```
$ alias

// Example:
$ alias mycmd='cat requirements.txt'
```

**Output text:**
```
$ echo
```

**Copy string to system clipboard:**
```
$ echo string_to_copy | pbcopy
```

**Copy html from webpage to system clipboard:**
```
// Example:
$ curl https://stackoverflow.com/ | pbcopy
```

**Compare two file byte by byte:**
```sh
$ cmp

// Example:
$ cmp firstfile.txt secondfile.txt
```

**Mount a file system:**
```sh
$ mount
```

**Display the memory map for a process:**
```sh
$ pmap

// Example:
$ pmap -x pid_number
```

**Get the PID for a process:**
```
$ ps aux | grep process_name

// Example:
$ ps aux | grep terminal
```

**Download a file from a network:**
```sh
$ wget

// Example:
$ wget path_to_file
```

**Display/Configure network's interface:**
```sh
$ ifconfig
```

>## **Source: 15 Little Known Unix Commands**

**Network diagnostic tool that combines tracerout and ping:**
```sh
$ mtr host_name

// Example:
$ mtr --report google.com
```

**Omit command from command log in ~/.bash_history:**

\*_Just add a space before the command_
```
$ space command
```

**Generate random numbers or text:**
```sh
$ jot

// Example:
$ jot -r number_of_random_numbers_to_display number_to_start_on
```

**Show disk usage:**
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
$ yes word_to_repeat
```

**Add line numbers to terminal output:**
```
$ nl

// Example:
$ cat .gitconfig | nl
```

### **Source: https://github.com/ericdrowell/CheatSheetWorld/**

>## File System

**List items in current directory:**
```sh
$ ls
```

**List items in current directory and show in long format to see perimissions, size, and modification date:**
```sh
$ ls -l
```

**List all items in current directory, including hidden files:**
```sh
$ ls -a
```

**List all items in current directory and show directories with a slash and executables with a star:**
```sh
$ ls -F
```

**List all items in directory:**
```sh
$ ls directory_name
```

**Move from current directory to child directory":**
```
$ cd child_directory_name
```

**Go up one directory:**
```
$ cd ..
```

**Go to the root directory:**
```
$ cd /
```

**Go to to your home directory:**
```
$ cd ~
```

**Go to the last directory you were just in:**
```
$ cd -
```

**Create directory in current directory:**
```sh
$ mkdir directory_name
```

**Remove file:**
```sh
$ rm file_name
```

**Remove directory recursively:**
```sh
$ rm -r directory_name
```

**Copy file_1 to file_2:**
```sh
$ cp name_of_file_1 name_of_file_2
```

**Copy directory dir_1 to dir_2 recursively:**
```sh
$ cp -r name_of_dir_1 name_of_dir_2
```

**Move (rename) file_1 to file_2:**
```sh
$ mv name_of_file_1 name_of_file
```

**Create symbolic link to file:**
```sh
$ ln -s file_name link
```

**Create or update file:**
```sh
$ touch file_name
```

**Output the first 10 lines of file:**
```sh
$ head file_name
```

**Output the last 10 lines of file:**
```sh
$ tail file_name
```

**Output the contents of file as it grows, starting with the last 10 lines:**
```sh
$ tail -f file_name
```

**Edit file:**
```sh
$ vim file_name
```

**Create an alias for a command:**
```
$ alias name 'command'
```

>## System

**Shut down machine:**
```sh
$ shutdown
```

**Restart machine:**
```sh
$ reboot
```

**Show the current date and time:**
```sh
$ date
```

**Display information about user:**
```sh
$ finger user
```

**Show directory space usage:**
```sh
$ du
```

**Show memory and swap usage:**
```sh
$ free
```

**Show possible locations of app:**
```sh
$ whereis app
```

**Show which app will be run by default:**
```
$ which app
```

>## Process Management

**Display your currently active processes:**
```sh
$ ps
```

**Display all running processes:**
```sh
$ top
```

**Kill process with the PID:**
```
$ kill pid
```

**Force kill process with the PID:**
```
$ kill -9 pid
```

> ## Permissions

**List items in current directory and show permissions:**
```sh
$ ls -l
```

**Change permissions of file to `ugo` - `u` is the user's permissions, `g` is the group's permissions, and `o` is everyone else's permissions. The values of `u`, `g`, and `o` can be any number between 0 and 7:**
```
$ chmod ugo_number file_name

// Definitions of ugo numbers:
    7                               // full permissions
    6                               // read and write only
    5                               // read and execute only
    4                               // read only
    3                               // write and execute only
    2                               // write only
    1                               // execute only
    0                               // no permissions

// Examples:
$ chmod 600 file_name               // read & write - good for files
$ chmod 700 file_name               // read, write, & execute - good for scripts
$ chmod 644 file_name               // read & write (everyone else can read) - good for web pages
$ chmod 755 file_name               // read, write, & execute (everyone else can read & execute) - good for programs you want to share
```

**Download a file:**
```sh
$ curl file_name
```

**Secure copy a file from remote server to a directory on your machine:**
```sh
$ scp user@host:file_name directory_name
```

**Secure copy a file from your machine to a directory on a remote server:**
```sh
$ scp file_name user@host:directory_name
```

**Secure copy the directory dir from remote server to the directory dir on your machine:**
```sh
$ scp -r user@host:directory_from_remote_server directory_on_your_machine
```

**Connect to host as user:**
```sh
$ ssh user@host
```

**Connect to host on port as user:**
```sh
$ ssh -p port user@host
```

**Add your key to host for user to enable a keyed or passwordless login:**
```sh
$ ssh-copy-id user@host
```

**Ping host and output results:**
```sh
$ ping host
```

**Get information for domain:**
```sh
$ whois domain
```

**Get DNS information for domain:**
```sh
$ dig domain
```

**Do a reverse lookup for a host:**
```sh
$ dig -x host
```

**List all processes running on port `1337`:**
```sh
$ lsof -i tcp:1337
```

>## Searching

**Search for pattern in files:**
```sh
$ grep pattern files
```

**Search recursively for pattern in the directory named `dir`:**
```sh
$ grep -r pattern dir
```

**Search recursively for pattern in the directory named `dir` and show the line number found:**
```sh
$ grep -rn pattern dir
```

**Search recursively for pattern in the directory named `dir` and only search in files with .ext extension:**
```sh
$ grep -r pattern dir --include='*.ext
```

**Search for pattern in the output of command:**
```
$ command | grep pattern
```

**Find all instances of a file in real system:**
```sh
$ find file_name
```

**Find all instances of a file using indexed database built from the updatedb command. Much faster than find:**
```sh
$ locate file_name
```

**Find all occurrences of day in a file and replace them with night - `s` means substitude and `g` means global - `sed` also supports regular expressions:**
```sh
$ sed -i 's/day/night/g' file_name
```

>## Compression

**Create a tar named `file.tar` containing files:**
```sh
$ tar cf file.tar files
```

**Extract the files from `file.tar`:**
```sh
$ tar xf file.tar
```

**Create a tar with gzip compression:**
```sh
$ tar czf file.tar.gz files
```

**Extract a tar using gzip:**
```sh
$ tar xzf file.tar.gz
```

**Compresses file and renames it to `file.gz`:**
```sh
$ gzip file
```

**Decompresses `file.gz` back to file:**
```sh
$ gzip -d file.gz
```

>## Shortcuts

**Move cursor to beginning of line:**
```
ctrl + a
```

**Move cursor to end of line:**
```
ctrl + f
```

**Move cursor forward 1 word:**
```
alt + f
```

**Move cursor backward 1 word:**
```sh
alt + b
```

<!-- NEW MATERIAL - FROM NOTEBOOK -->

**Prevent mac from sleeping**
```sh
$ pmset noidle
// or...
$ caffeinate
```

## Resources

- [An A-Z Index of the Linux command line: bash + utilities](https://ss64.com/bash/)
