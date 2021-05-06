---
title: Prepare CRM Server computer
uid: prepare_crm_server
description: Prepare CRM Server computer
author: {github-id}
keywords: install
so.topic: howto
so.envir: onsite
so.client:
---

# Prepare CRM Server computer

1. Prepare the program files folder

    This is where the server software will be installed. By default, we put this in *c:\program files\SuperOffice\SuperOffice Server*. Here you will find the tools for database maintenance (*Dbsetup.exe*) and create and edit the install files (*SoCreateMST.exe*).

    In *SuperOffice Server* we also create a subfolder called *Client*, which must be available for all users who want to install the Win client. We recommend you share the Client folder and not the SuperOffice Server folder.

2. Prepare the document archive folder

    This folder is the central document archive, and all users must have access to this location via the application. For Win app users, this folder must be shared, the user must be able to create and edit folders and files.

3. [Prepare IIS web server][1]

4. [Prepare the database][2]

***

[Next (Web)][12] | [Next (Win)][14] | [Back to guide][13]

<!-- Referenced links -->
[1]: ../iis/index.md
[2]: ../database/index.md
[12]: ../../../service/install/prepare.md
[13]: ../guide.md
[14]: ../win-client/prepare-client.md

<!-- Referenced images -->
