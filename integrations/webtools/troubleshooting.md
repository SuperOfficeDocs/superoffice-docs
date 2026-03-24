---
uid: webtools-troubleshooting
title: Troubleshooting
description: Troubleshooting WebTools
keywords: WebTools, troubleshooting
author: Jostein K, digitaldiina
date: 03.24.2026
content_type: howto
category: integration
topic: WebTools
language: en
index: true
redirect_from:
  - /en/document/webtools/troubleshooting
  - /en/document/webtools/debug
  - /integrations/webtools/debug
---

# Troubleshooting WebTools

By understanding how SuperOffice WebTools works, it is easier to troubleshoot issues and to have a common ground when reporting and discussing wishes and issues.

## I'm running single sign-on, but the credential window pops up many times

Using single sign-on delegates the authentication to your domain controller (or the component that acts as the authentication server). Authentication will fail if the password on the local machine is different than the password stored centrally (hint: NTLM password hashes). It will also fail if the account has been locked.

## The document dialog opens instead of WebTools when I select document in archive

This is often caused by WebTools not being properly configured. [Enable logging](#logging) to gather diagnostic information.

## Alarms are not working as expected

If alarms are not showing or are showing at the wrong time, check the **WebTools preferences**.

If the option **Show alarm for all appointments *n* minutes before** is enabled in WebTools, this setting overrides the [alarm setting in SuperOffice CRM][1].

To change this:

1. Right-click the WebTools icon in the system tray.

1. Select **Preferences**.

1. Adjust or disable the **Show alarm for all appointments** setting.

## <a id="logging"></a>Logging

Web Extensions depends on a constant connection to the CRM Server to work properly. If you are having connectivity issues, turn on logging to troubleshoot.

### Windows

> [!TIP]
> This is the file support usually will ask for.

1. Open the Registry. The user needs a write permission to the file.

1. Add a new String value under *HKCU\Software\SuperOffice\DocLink*:

    * Value name = **LogFile**
    * Value data = The full path to a log file where it should write diagnostics. User running WebTools needs to have write permission to this file and folder.

> [!NOTE]
> A restart of WebTools is often necessary for applying the registry settings.

![WebTools LogFile -screenshot][img1]

### Mac

1. Click **Go** then **Library**.

    ![WebTools for Mac log file -screenshot][img4]

1. Navigate to *Application Support* folder then *SuperOffice WebTools*. Then create a new text file without an extension, call it *debug* and move it to the folder *SuperOffice WebTools*. Restart WebTools.

    ![WebTools for Mac log file -screenshot][img5]

1. Open a **Console**

    ![WebTools for Mac log file -screenshot][img6]

1. In the console dialog search field fill in **SuperOffice** and click **Save**. The information should be saved in the debugging file. If it doesn't, select all the entries and right-click and click copy then paste it in the debugging file.

    ![WebTools for Mac log file -screenshot][img7]

<!-- Referenced links -->
[1]: ../../docs/en/diary/learn/set-alarm.md

<!-- Referenced images -->
[img1]: media/webtoolslog.png
[img4]: media/imagewukx.png
[img5]: media/imagew1mo6.png
[img6]: media/imagelzq97.png
[img7]: media/imagedo4c.png
