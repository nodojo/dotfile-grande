# Azure Tips

## Clone repo hosted in Azure using PAT

```
$MyPat = 'yourPat'
$headerValue = "Authorization: Basic " + [Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes(":" + $MyPat))
$env:GIT_AUTH_HEADER = $headerValue

git --config-env=http.extraheader=GIT_AUTH_HEADER clone https://dev.azure.com/yourOrgName/yourProjectName/_git/yourRepoName
```
