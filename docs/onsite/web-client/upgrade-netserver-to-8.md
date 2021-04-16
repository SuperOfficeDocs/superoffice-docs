---
title: upgrade_netserver_to_8
description: Upgrade SuperOffice 7 NetServer to SuperOffice 8 NetServer
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# Upgrade SuperOffice 7 NetServer to SuperOffice 8 NetServer

These are the recommended steps for upgrading from SuperOffice 7 NetServer to SuperOffice 8 NetServer.

## Before you begin

* Considered the [security][1]
* Upgrade your database to version 8 using [Serversetup.exe][2]

If SuperOffice 7 Web runs on Remote NetServer, it is possible to merge Service NetServer and S&M Web NetServer for a more lean administration.

[!include[ALT](../../includes/warn-upgrade-all-to-same-version.md)]

## Upgrade

1. See [system requirements][3] for SuperOffice 8 NetServer
2. Download and unzip the Web installer package on your server
3. Run the Web installer

<!-- Referenced links -->
[1]: ../security/index.md
[2]: ../crm-server/setup-guide.md
[3]: ../requirements/web-client.md
