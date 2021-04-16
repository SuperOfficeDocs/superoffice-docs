---
title: Install CRM Server
uid: crm_server_setup_guide
description: CRM Server setup guide
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# CRM Server setup guide

> [!NOTE]
> You need a running SuperOffice CRM Server before you install the other clients.  

## Prepare CRM server

### Prepare the program files folder

This is where the server software will be installed. By default, we put this in *c:\program files\SuperOffice\SuperOffice Server*. Here you will find the tools for database maintenance (*Dbsetup.exe*) and create and edit the install files (*SoCreateMST.exe*).

In *SuperOffice Server* we also create a subfolder called *Client*, which must be available for all users who want to install the Win client. We recommend you share the Client folder and not the SuperOffice Server folder.

### Prepare the document archive folder

This folder is the central document archive, and all users must have access to this location via the application.

For Win app users, this folder must be shared, the user must be able to create and edit folders and files.

### Prepare IIS web server

* [Guide][1]

### Prepare the database

* [Guide][2]

### Prepare Win client computer

* [Guide][3]

## Prepare for Service

* [Guide][4]

## Install CRM Server

* [Guide][5]

## Install Windows client (optional)

* [Guide][6]

## Install SuperOffice Web

* [Guide][7]

## Install NetServer web services

* [Guide][8]

<!-- Referenced links -->
[1]: iis/index.md
[2]: database/index.md
[3]: win-client/prepare-server.md
[4]: ../../service/install/index.md
[5]: server/index.md
[6]: win-client/index.md
[7]: web-client/index.md
[8]: netserver/index.md
