---
title: Upgrade
uid: upgrade_service
description: Upgrade SuperOffice Customer Service to SuperOffice Service
author: {github-id}
keywords:
topic: guide
envir: onsite
# client:
---

# Upgrade SuperOffice Customer Service to SuperOffice Service

These are the recommended steps for upgrading SuperOffice Service / Customer Service.

## Before you begin

* Check the [system requirements][3] for SuperOffice Service
* [Upgrade your database][1] using ServerSetup.exe
* Upgrade CRM Win/Web
* [Upgrade the NetServer][2] used by Customer Service
* Download and unzip the Service installer package on your server

[!include[ALT](../../includes/warn-upgrade-all-to-same-version.md)]

**Using remote NetServer web services?**

We recommend using the same NetServer for both CRM Web and Service for a more lean administration.

**Want to use FASTCGI (recommended)?**

You need IIS version 7.5 or a patched version of 7.0. The Microsoft implementation of FastCGI functionality in IIS 7.0 is not correct.

## Step 1 - Run the installer to upgrade the software

1. Run the Customer Service installer.
2. Click the radio button for "Maintain or upgrade an existing instance".
3. Select the particular installation you want to upgrade in the list.
4. Click next.

![x -screenshot][img1]

> [!NOTE]
> When the installer finishes, you will need to run the upgrade.exe command. This must be done after every Customer Service upgrade, and the particulars for upgrading from version 7.5 to version 8.0 are explained in the next section.

### Customer center

When upgrading Service to a new version, your current [Customer center templates][4] will be copied to a new folder called *templates_date_time*.

If you have made customizations to the customer center, you will need to update the current templates folder, which will have the new optimizations, but the standard design.

## Step 2 - Run upgrade.exe to update the database

When the installer is done upgrading the files to version 8.0, you need to run the command [upgrade.exe][5] from a shell prompt.

> [!NOTE]
> The command **upgrade.exe must always be run after an upgrade** as it might perform configuration or data transformation tasks. There is no harm in running upgrade.exe more than once as it will keep tabs on what is done already and what is not.<br>It must be run **with elevated/admin rights**, or you might get errors during the upgrade process because upgrade.exe may not be allowed to do certain changes to the system.

1. Run cmd.exe from the start menu.
    * Make sure the upgrade.exe process is run with elevated/admin rights!
    * You may have to start cmd.exe with a right-click on a shortcut and select run as administrator to achieve this.
2. Navigate to the *bin* directory in the Customer Service installation folder to find and start upgrade.exe.
3. The upgrade.exe program will ask you some questions of which there are 3 main new areas of interest: website name, FastCGI, and attachments (described below).
4. Flush the cache: Navigate to `http://your-site/scripts/rms.exe?action=debug` and click **Flush caches** at the bottom.

![x -screenshot][img2]

### The website name

Upgrade will ask you for the IIS site name and will check to see if it exists. This is not the same as the domain name - it is the name of the site in the IIS manager.

### FastCGI

> [!CAUTION]
> **We recommend you run Customer Service using FastCGI technology.** FastCGI is more efficient and will increase application responsiveness and decrease server load. It requires some additional IIS settings to be done and upgrade.exe will attempt to do this for you. If upgrade.exe encounters problems with your IIS version or administrative privileges, it will try to warn you and offer to abort the upgrade process so you can fix the issue and re-run upgrade.exe. The upgrade.exe program will also tell you if your IIS needs a Microsoft patch or hotfix, and print some URLs of where to download it if necessary.

When using FastCGI, the webserver does not need to start a new process for each request. The process is instead alive in memory for a while retaining some of its data and only needing to process a lot of initialization logic once and not for each request. This significantly improves responsiveness and decreases server load.

There is an additional benefit to using another extension than .exe and that is that Customer Service links in emails, also e-marketing emails, will not be viewed as a potential threat by spam detection filters the same way a .exe file extension URL would.

**The upgrade.exe process will ask if you want to set up FastCGI.** If you choose to do so it will try to configure your IIS site as this can be tedious to do manually as it involves mapping each .exe file to an empty place holder .fcgi file in IIS FastCGI setup. This is done on the IIS site/application level and it's preferable to let upgrade.exe set this up automatically and later change timeout settings, and so on. if one wishes from the IIS manager FastCGI settings section.

After configuring FastCGI, Customer Service will generate URLs that end in .fcgi instead of .exe but the .exe file ending will also work. If you decide you do not want to use FastCGI after all, you can just change a setting in the Registry table in the database. Then the .exe links will be generated instead of .fcgi and everything will work as before.

### Attachments

Upgrade.exe will want to remap attachment files to sub-folders and this might take some time if you have many and/or large files. You can choose to skip this step and run upgrade.exe later if you are not prepared to keep your site down until all your attachment files are moved into place.

The attachment folder can potentially have hundreds of thousands of files, which might make it inefficient and difficult to browse manually with a file manager, and we will now store them in sub-directories with a maximum of 10.000 files in each. Which folder each file is allocated to depends on the file ID number, the first 10.000 numbers go into the first folder, and so on. This means that there may be less than 10.000 files in any attachment sub-folder if some of the IDs are not in use or if an attachment was deleted. You can opt to delay moving the attachments if you expect it to take a lot of time, so you can unfreeze your Customer Service site quicker. Run upgrade.exe later to complete this process.

<!-- Referenced links -->
[1]: ../../onsite/upgrade/75-to-8/crm-server.md
[2]: ../../onsite/upgrade/75-to-8/web-client.md
[3]: ../../onsite/requirements/crm-server.md
[4]: ../../customer-center/templates.md
[5]: ../automated-tasks/upgrade.md

<!-- Referenced images -->
[img1]: media/upgradeservice.png
[img2]: media/capture.png
