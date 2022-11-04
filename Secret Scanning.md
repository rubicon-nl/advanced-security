# Secret Scanning

## Introduction

Secret scanning is meant to prevent the exposure of secrets within a respository.  
[There is currently a beta for push protection, which prevents a push containing a secret.](https://docs.github.com/en/enterprise-cloud@latest/code-security/secret-scanning/protecting-pushes-with-secret-scanning)  
Resolving issues with blocked pushes is [explained as well.](https://docs.github.com/en/enterprise-cloud@latest/code-security/secret-scanning/pushing-a-branch-blocked-by-push-protection)

## Example
Add the following to a piece of code.  
This should be detected as an Azure DevOps PAT.
```nsmoqn7zrdew3mp37vjmuvd2dmujayqeir2qfhtw6rmkhdu67mfq```
