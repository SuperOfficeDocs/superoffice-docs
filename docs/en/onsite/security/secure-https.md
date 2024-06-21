---
title: Securing HTTPS
uid: secure_https_config
description: Securing HTTPS configuration on Windows Server
author: {github-id}
keywords: security
topic: howto
envir: onsite
client: web
---

# Securing HTTPS configuration on Windows Server

To apply the best practice HTTPS configuration on a Windows server, we can run a Powershell script written by NSM (Nasjonal Sikkerhetsmyndighet). This script will make changes to the Windows registry to enable the latest encryption algorithms and disable old and insecure algorithms and ciphers.

1. Unzip the <a href="../../../assets/downloads/u-03_sikring_av_windows_tls.zip" download>u-03_sikring_av_windows_tls.zip</a> file. Then inside the unpacked directory, unzip the second zip file *Schannel.zip* and enter the unpacked directory again. Holding shift and right-clicking will give us a menu where we can open a command window in the current directory.

    > [!NOTE]
    > The following must be done with administrator-level access.

    ![Zip file content -screenshot][img1]

2. Get a Powershell prompt by typing **powershell**. Then import the NSM Powershell module by entering the following commands:

    ```sh
    Import-Module ‘.\\NSM TLS Tools.psm1’ –force
    & ‘.\\Apply NSM Schannel Policy.ps1’
    ```

    ![Powershell -screenshot][img2]

3. Follow the instructions and the script will check for compliance with recommended settings, backup existing settings to a registry file, change the settings to comply, and run a final test.

To read more about the script, what it does and why check out the PDF file in the unzipped directory called *U-03_Sikring_av_Windows_TLS.pdf*.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/schannel.jpg
[img2]: media/powershell.jpg
