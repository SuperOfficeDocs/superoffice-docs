---
uid: webtools-install
title: Install WebTools
description: "How to install WebTools per user."
keywords: WebTools, TrayApp
author: Hans Oluf Waaler
date: 10.13.2016
content_type: howto
category: integration
topic: WebTools
audience: person
audience_tooltip: SuperOffice CRM
language: en
redirect_from: /en/document/webtools/install
index: true
---

# Install WebTools per user

## Pre-requisites

WebTools currently uses .NET Framework 4.7.2, which will be installed if it is not detected on the system.

Administrative privileges are not required for the user. If you are not the administrator, you get WebTools installed in *c:\users\\\<yourname>\appdata\local\SuperOffice*.

## Download and install onsite

1. When you download WebTools from a SuperOffice installation, the downloaded file has a name in form of `SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffice&un=souser-­-.exe`.  The contents after `--` is the configuration directive.

2. The WebTools installer executes the command (without brackets):

    `SuperOffice.TrayApp.Client.exe /autoconfig:[installer_name]`

## Example

This example configures the WebTools installation to connect to `https://superoffice/superoffice/`.

The full command given to *SuperOffice.TrayApp.Client.exe* in this example is:

`SuperOffice.TrayApp.Client.exe /autoconfig:"SuperOffice.Web.Tools--u=https%3a%2f%2fsuperoffice%3a443%2fSuperOffice%2f&cn=SuperOffic­e&un=souser--.exe"`
