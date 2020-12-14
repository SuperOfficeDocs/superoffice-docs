---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: secure_https_config # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Securing HTTPS configuration on Windows Server # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: security
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite               # cloud or onsite
so.client: web               # online, web, win, pocket, or mobile
---

# Securing HTTPS configuration on Windows Server

To apply the best practice HTTPS configuration on a Windows server, we can run a Powershell script written by NSM (Nasjonal Sikkerhetsmyndighet). This script will make changes to the Windows registry in order to enable the latest encryption algorithms and disable old and insecure algorithms and ciphers.

[Download the script from NSMs website][1]

1. Unzip the first ZIP file. Then inside the unpacked directory, unzip the second ZIP file *Schannel.zip* and enter the unpacked directory again. Holding shift and right-clicking gives us a menu where we can open a command window in the current directory.

> [!NOTE]
> The following must be done with administrator level-access.

![Zip file content][img1]

2. Get a Powershell prompt by typing **powershell**. Then import the NSM Powershell module by entering the following commands:

```sh
Import-Module ‘.\\NSM TLS Tools.psm1’ –force
& ‘.\\Apply NSM Schannel Policy.ps1’
```

![Powershell][img2]

3. Follow the instructions and the script will check for compliance with recommended settings, backup existing settings to a registry file, change the settings to comply and run a final test.

To read more about the script, what it does and why, check out the PDF file in the unzipped directory called *U-03\_Sikring\_av\_Windows\_TLS.pdf*.

<!-- Referenced links -->
[1]: https://www.nsm.stat.no/globalassets/dokumenter/veiledninger/systemteknisk-sikkerhet/u-03\_sikring\_av\_windows\_tls.zip

<!-- Referenced images -->
[img1]: media/schannel.jpg
[img2]: media/powershell.jpg