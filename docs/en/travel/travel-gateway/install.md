---
title: install travel gateway
description: Manual install of travel gateway service
author: SuperOffice Product and Engineering
keywords:
date:
content_type: howto
deployment: onsite
platform: win
---

# Manual install of Travel gateway service

The **SoTraGateService.exe** file may be run manually from the command prompt to install the service.

| Parameter | Explanation |
|---|---|
| install | Will install the Travel Gateway Service, but not start it. |
| uninstall | Uninstalls the Travel gateway service. You must exit from Control Panel/Services to complete the uninstallation. |
| souser | Changes the SuperOffice user that executes the tasks. Must be a system user. |

**Additional parameters for install:**

1. Windows user account for the service
2. Password for that account
3. SuperOffice user name
4. SuperOffice password

Example: `SoTraGateService.exe install ".\Administrator" "password" "CRM7" "CRM7myd"`

**Additional parameters for souser:**

1. SuperOffice username
2. SuperOffice password
