---
title: Install
uid: install_webtools
description:
author: Hans Oluf Waaler
keywords:
so.topic: howto
so.date: 10.13.2016
so.envir: onsite
---

# Install Web Tools per user

## Pre-requisites

Web Tools currently uses .NET Framework 4.5, which will be installed if it is not detected on the system.

Administrative privileges are not required for the user. If you are not the administrator, you get Web Tools installed in *c:\users\<yourname>\appdata\local\SuperOffice*.

## Download and install

1. When you download Web Tools from a SuperOffice installation, the downloaded file has a name in form of `SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffice&un=souser-­-.exe`.  The contents after `--` is the configuration directive.

2. The Web Tools installer executes the command (without brackets):

    `SuperOffice.TrayApp.Client.exe /autoconfig:[installer_name]`

## Example

This example configures the Web Tool installation to connect to `https://superoffice/superoffice/`.

The full command given to *SuperOffice.TrayApp.Client.exe** in this example is:

`SuperOffice.TrayApp.Client.exe /autoconfig:"SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffic­e&un=souser--.exe"`
