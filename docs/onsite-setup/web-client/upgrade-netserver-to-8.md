---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: upgrade_netserver_to_8       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Upgrade SuperOffice 7 NetServer to SuperOffice 8 NetServer # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Upgrade SuperOffice 7 NetServer to SuperOffice 8 NetServer

These are the recommended steps for upgrading from SuperOffice 7 NetServer to SuperOffice 8 NetServer.

## Before you begin

* Considered the [security][1]
* Upgrade your database to version 8.0 using [Serversetup.exe][2]

If SuperOffice 7 Web runs on Remote NetServer, it is possible to merge CS NetServer and S&M web NetServer for a more lean administration.

[!include[ALT](../includes/warn-upgrade-all-to-same-version.md)]

## Upgrade

1. See [system requirements][3] for SuperOffice8 NetServer
2. Download and unzip the Web installer package on your server
3. Run the [Web installer][4]

<!-- Referenced links -->
[1]: ../security/index.md
[2]: ../crm-server/setup-guide.md
[3]: system-requirements.md
[4]: https://community.superoffice.com/en/technical/documentation/older-versions/documentation-7/SM/sales-marketing-web/install-seven-web/