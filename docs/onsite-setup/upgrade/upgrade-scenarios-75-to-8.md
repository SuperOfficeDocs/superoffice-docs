---
title: upgrade_scenarios_75_to_8
description: Upgrade scenarios
author: {github-id}
keywords:
so.topic: guide
so.envir: onsite
# so.client:
---

# Upgrade scenarios from 7.x to 8

| Current setup | Which guide to use |
|---------------|--------------------|
| SuperOffice 7 Server<br>SuperOffice 7 Windows Clients | Upgrade Windows Client |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Web, and/or<br> SuperOffice 7.5 Windows Clients | Upgrade Win + Web or Web |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Customer Service, and/or<br> SuperOffice 7.5 Windows Clients | Upgrade CS or CS + Windows Client |
| SuperOffice 7.5 Server,<br> SuperOffice 7.5 Customer Service,<br> SuperOffice 7.5 Web, and/or<br> SuperOffice 7.5 Windows Clients | Upgrade Win + Web + CS or Web + CS |
| SuperOffice 7.0 or 7.1 Server | Upgrade 7.0 or 7.1 SuperOffice |

> [!NOTE]
> SuperOffice 8 requires a "full stack" of all main components.<br>If you run an older version then you must upgrade to SuperOffice 7.5 first.<br>The Pocket Server 7 is not needed for SuperOffice 8. Uninstall Pocket Server 7 after the upgrade if it is installed.

## Upgrade Windows Client

**For:**

SuperOffice 7 Server and SuperOffice 7 Windows Clients.

**Actions:**

For all scenarios where the customer does not have Customer Service already installed and configured:

* Find SMTP server to use, and make sure relaying from CS server is enabled
* Set DNS record ready for CS (support.company.com)
* Setup of the first mailbox in CS (to be able to handle bounces)

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows client")
3. [Install SuperOffice 8 Web][3]
4. [Install SuperOffice 8 Service][4]

## Upgrade Win + Web or Web

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Web, and/or SuperOffice 7.5 Windows Clients.

**Actions:**

For all scenarios where the customer does not have Customer Service already installed and configured:

* Find SMTP server to use, and make sure relaying from CS server is enabled
* Set DNS record ready for CS (support.company.com)
* Setup of the first mailbox in CS (to be able to handle bounces)

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade CRM Web][3]
4. [Install Service][4]

## Upgrade CS or CS + Windows client

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Customer Service, and/or SuperOffice 7.5 Windows Clients

**Steps:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade SuperOffice 7.5 NetServer to SuperOffice 8 NetServer][5]
    * If CS runs on Remote NetServer: It it possible to merge CS NetServer and Web NetServer for a more lean administration
4. [Upgrade SuperOffice 7.5 CS to SuperOffice 8 Service][6]
5. [Install SuperOffice 8 Web][3]

## Upgrade Win + Web + CS or Web + CS

**For:**

SuperOffice 7.5 Server, SuperOffice 7.5 Customer Service, SuperOffice 7.5 Web, and/or SuperOffice 7.5 Windows Clients

> [!NOTE]
> SuperOffice 8.1 requires that Web and Service (CS) are [installed in the same domain][7].

**Actions:**

1. [Upgrade CRM Server][1]
2. [Upgrade Windows Clients][2] (only if you are going to use "SuperOffice 8 Windows App")
3. [Upgrade Netserver][5]
    * If CS runs on Remote NetServer: It is possible to merge CS NetServer and Web NetServer for a more lean administration
4. [Upgrade SuperOffice 7 CS to SuperOffice 8 Service][6]
5. [Upgrade Web][3]

## Upgrade 7.0 or 7.1 SuperOffice

**For:**

SuperOffice 7.0 or 7.1 Server

**Actions:**

1. You must upgrade to SuperOffice 7.5 first!
2. Then complete the upgrade to 8.

<!-- Referenced links -->
[1]: ../crm-server/upgrade-to-8.md
[2]: ../win-client/upgrade.md
[3]: ../web-client/upgrade-to-8.md
[4]: ../service/set-up-guide.md
[5]: ../web-client/upgrade-netserver-to-8.md
[6]: ../service/upgrade.md
[7]: upgrade-to-8-1.md
