---
title: Upgrade from 7.x to 8
uid: upgrade_75_to_8
description: Upgrade from 7.x to 8
author: {github-id}
keywords:
topic: guide
envir: onsite
client: web,win
---

# Upgrade from 7.x to 8.0

| Current setup | Which guide to use |
|---------------|--------------------|
| SuperOffice 7.5 Server<br>SuperOffice 7.5 Windows clients | [Upgrade Windows client](#upgrade-windows-client) |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Web, and/or<br> SuperOffice 7.5 Windows clients | [Upgrade Win + Web or Web](#upgrade-win--web-or-web) |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Customer Service, and/or<br> SuperOffice 7.5 Windows clients | [Upgrade CS or CS + Windows client](#upgrade-cs-or-cs--windows-client) |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Customer Service,<br> SuperOffice 7.5 Web, and/or<br> SuperOffice 7.5 Windows clients | [Upgrade Win + Web + CS or Web + CS](#upgrade-win--web--cs-or-web--cs) |
| SuperOffice 7.0 or 7.1 Server | [Upgrade SuperOffice 7.0 or 7.1](#upgrade-superoffice-70-or-71) |

> [!NOTE]
> SuperOffice 8 requires a "full stack" of all main components.<br>If you run an older version then you must upgrade to SuperOffice 7.5 first.<br>The Pocket Server 7 is not needed for SuperOffice 8. Uninstall Pocket Server 7 after the upgrade if it is installed.

## Upgrade Windows client

**For:**

SuperOffice 7.5 Server and SuperOffice 7.5 Windows Clients.

**Actions:**

[!include[ALT](includes/has-no-cs-yet.md)]

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows client")
3. [Install SuperOffice 8 Web][3]
4. [Install SuperOffice 8 Service][4]

## Upgrade Win + Web or Web

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Web, and/or SuperOffice 7.5 Windows clients.

**Actions:**

[!include[ALT](includes/has-no-cs-yet.md)]

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade CRM Web][3]
4. [Install SuperOffice 8 Service][4]

## Upgrade CS or CS + Windows client

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Customer Service, and/or SuperOffice 7.5 Windows clients

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade SuperOffice 7.5 NetServer to SuperOffice 8 NetServer][5]
    * If CS runs on Remote NetServer: It is possible to merge CS NetServer and Web NetServer for a more lean administration
4. [Upgrade SuperOffice 7.5 CS to SuperOffice 8 Service][6]
5. [Install SuperOffice 8 Web][3]

## Upgrade Win + Web + CS or Web + CS

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Customer Service, SuperOffice 7.5 Web, and/or SuperOffice 7.5 Windows clients

> [!NOTE]
> SuperOffice 8.1 requires that Web and Service (CS) are [installed in the same domain][7].

**Actions:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade NetServer][5]
    * If CS runs on Remote NetServer: It is possible to merge CS NetServer and Web NetServer for a more lean administration
4. [Upgrade SuperOffice 7 CS to SuperOffice 8 Service][6]
5. [Upgrade CRM Web][3]

## Upgrade SuperOffice 7.0 or 7.1

**For:**

SuperOffice 7.0 or 7.1 Server

**Actions:**

1. You must upgrade to SuperOffice 7.5 first!
2. Then complete the upgrade to SuperOffice 8.0

<!-- Referenced links -->
[1]: crm-server.md
[2]: win-client.md
[3]: web-client.md
[4]: ../../../service/install/index.md
[5]: netserver.md
[6]: ../../../service/upgrade/index.md
[7]: ../to-81/index.md
