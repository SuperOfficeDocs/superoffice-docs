---
title: Upgrade to 9 or 10
uid: upgrade_to_9
description: Upgrade to 9 or 10
author: Martin Pavlas
date: 12.08.2021
keywords: upgrade
topic: howto
envir: onsite
# client:
version: 9, 10
---

# Upgrade to SuperOffice 9 or 10

You can upgrade to SuperOffice 9 or 10 from SuperOffice 8.0 or newer. The recommended installation scenarios and setup requirements are the same as from SuperOffice 8.1.

[!include[ALT](../../includes/warn-win-client-discontinued.md)]

> [!NOTE]
> Microsoft .NET 4.8 is required for SuperOffice 9 or newer.
>
> The installer will handle the installation of .NET 4.8 for you, but some clients may like to pre-install it themselves.

## Upgrade from SuperOffice 8.0

If you are running SuperOffice 8.0 you need to make sure the full stack of SuperOffice applications (SuperOffice Server, SuperOffice Web, and SuperOffice Service) is installed. You also need to [move all products under one domain][1], as seen from the browser. It might be beneficial to [upgrade to SuperOffice 8.1][1] first and follow the corresponding guides for different installation scenarios.

## Upgrade from SuperOffice 8.1 or newer

SuperOffice 8.1 or newer installation has already the full stack of SuperOffice applications installed and it is running under one domain which makes it easier to upgrade.

### 1. Upgrade SuperOffice 8 Server

Run *SetupExe.exe* from *SnMWin_ADMIN* installation file to upgrade the database and the server files. The installation wizard will guide you through the process and will ask you for the SuperOffice administrator's credentials as well as for the system user's credentials. You may tick the checkbox 'This is a temporary test upgrade' not to change your license to version 9 or 10 yet in our central license system. This way you can try the upgrade as many times as you want without influencing your production database.

Once the server is upgraded, you can run the *SuperOffice9.exe* (or *SuperOffice10.exe* for SuperOffice 10) file found in the *SuperOffice Server\Client* folder. This will install SuperOffice Win Admin, Reporter Studio, and SuperOffice Travel gateway.

### 2. Upgrade SuperOffice 8 Web

SuperOffice Web is upgraded by running *Setup.exe* from *SnMWeb* installation file. The setup can upgrade both NetServer and SuperOffice Web files.

[!include[Remote NetServer](../../includes/remote-netserver-web.md)]

### 3. Upgrade SuperOffice 8 Service

SuperOffice Service is upgraded by running the *SuperOffice.CustomerService.exe* file from the *CS* installation folder. After the Service program files are upgraded you need to run *upgrade.exe* to upgrade Service's database values.

### 4. Uninstall SuperOffice 8 Win clients

If you used SuperOffice 8 Win app, it needs to be uninstalled from all clients. SuperOffice Win app has been discontinued since SuperOffice 9.

SuperOffice administrators may want to install on their PCs SuperOffice Win Admin, Reporter Studio, and Travel Gateway by running *SuperOffice9.exe* (or *SuperOffice10.exe* for SuperOffice 10) file from the *Client* folder on the SuperOffice Server.

<!-- Referenced links -->
[1]: ../to-81/index.md
