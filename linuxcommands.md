<!-----------------------------
 ____ ____ ____ ____ ____ ____
||n |||o |||d |||o |||j |||o ||
||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|

------------------------------->

# **From: 25 Linux Commands for System Admins**

### **Show information about available commands**
-------------------------------------------------------------
- $ man `<excutablename>`
- $ man ascii       // show commands offered for ascii
- $ man units       // show commands offered for units
- $ man man         // show commands offered for man

### **Show how long the system has been running**
-------------------------------------------------------------
- $ uptime

### **Show who is logged in to your system and what they are currently doing**
-------------------------------------------------------------
- $ w

### **Show username(s) of user(s) currently logged in to your system**
-------------------------------------------------------------
- $ users

### **Print username of user you're currently logged in as**
-------------------------------------------------------------
- $ whoami

### **Find and output search query along with surrounding text**
-------------------------------------------------------------
- $ grep
- $ grep -r "facebook"      // search recursively
- $ grep -r -l "facebook"   // output filenames instead of text

### **Reduce length of output (if too verbose)**
-------------------------------------------------------------
- $ less

### **Provides helpers to display, copy, or combine text**
-------------------------------------------------------------
- $ cat .gitignore

### **Print absolute path of current working directory**
-------------------------------------------------------------
- $ pwd

### **Connect to a remote server**
-------------------------------------------------------------
- $ ssh
- $ ssh remote_host
- $ ssh remote_username@remote_host

### **Copy files securely and remotely over servers**
-------------------------------------------------------------
- $ scp

### **Run any command as a superuser(root)**
-------------------------------------------------------------
- $ sudo

### **Can be used to perform tasks from various services**
-------------------------------------------------------------
- $ service
- $ service apache restart

### **Find files on your system by name**
-------------------------------------------------------------
- $ locate

### **Change file permissions**
-------------------------------------------------------------
- $ chmod

### **Change ownership of a file to a user or user group**
-------------------------------------------------------------
- $ chown

### **Kill a process**
-------------------------------------------------------------
- $ pkill

### **Manage cron jobs**
-------------------------------------------------------------
- $ crontab
- $ crontab -l

### **Assign a shortened name to an existing command**
-------------------------------------------------------------
- $ alias
- $ alias mycmd='cat requirements.txt'

 *(must be defined in an .--rc file(.bashrc, .zshrc, etc.) to save for later use)*

 ### **Output text**
-------------------------------------------------------------
- $ echo

 ### **Compare two file byte by byte**
-------------------------------------------------------------
- $ cmp
- $ cmp firstfile.txt secondfile.txt

 ### **Mount a file system**
-------------------------------------------------------------
- $ mount

 ### **Display the memory map for a process**
-------------------------------------------------------------
- $ pmap
- $ pmap -x `<pid>`

 ### **Get a process' id (pid)**
-------------------------------------------------------------
- $ ps aux | grep `<processname>`

 ### **Download a file from a network**
-------------------------------------------------------------
- $ wget
- $ wget `<pathtofile>`

 ### **Display/Configure network's interface**
-------------------------------------------------------------
- $ ifconfing