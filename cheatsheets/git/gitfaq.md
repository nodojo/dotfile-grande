# Git FAQs

#### [gitfaq - Frequently asked questions about using Git](https://git-scm.com/docs/gitfaq#Documentation/gitfaq.txt)

## [How do I use multiple accounts with the same hosting provider using SSH?](https://git-scm.com/docs/gitfaq#Documentation/gitfaq.txt-HowdoIusemultipleaccountswiththesamehostingproviderusingSSH)

With most hosting providers that support SSH, a single key pair uniquely identifies a user. Therefore, to use multiple accounts, it’s necessary to create a key pair for each account. If you’re using a reasonably modern OpenSSH version, you can create a new key pair with something like `ssh-keygen -t ed25519 -f ~/.ssh/id_committer`. You can then register the public key (in this case, `~/.ssh/id_committer.pub`; note the `.pub`) with the hosting provider.

Most hosting providers use a single SSH account for pushing; that is, all users push to the `git` account (e.g., `git@git.example.org`). If that’s the case for your provider, you can set up multiple aliases in SSH to make it clear which key pair to use. For example, you could write something like the following in `~/.ssh/config`, substituting the proper private key file:

```shell
# This is the account for author on git.example.org.
Host example_author
	HostName git.example.org
	User git
	# This is the key pair registered for author with git.example.org.
	IdentityFile ~/.ssh/id_author
	IdentitiesOnly yes
# This is the account for committer on git.example.org.
Host example_committer
	HostName git.example.org
	User git
	# This is the key pair registered for committer with git.example.org.
	IdentityFile ~/.ssh/id_committer
	IdentitiesOnly yes
```

Then, you can adjust your push URL to use `git@example_author` or `git@example_committer` instead of `git@example.org` (e.g., `git remote set-url git@example_author:org1/project1.git`).
