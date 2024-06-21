---
title: Debug
uid: webtools-debug
description: How to debug WebTools
author: Jostein K, Bergfrid Dias
date: 01.23.2024
keywords: debug, WebTools
topic: howto
envir: onsite
---

# Debugging WebTools

The Web Extension depends on a constant connection to the CRM Server to work properly. If you are having connectivity issues, there are a few things you may do to troubleshoot.

## Open the WebTools Connectivity diagnostics page

This is available on the same URL as your CRM web client, typically `http://socrm.myorganization.com/SuperOffice/WebToolsDiagnostics.aspx`.

From 8.0 SR1 and CRM Online 8.0 R14, we check the last active computer and open the document there.

> [!NOTE]
> If you are using SuperOffice Onsite and have **not yet upgraded to SuperOffice 8.0 SR1 or higher**: If the same user is connected more than once, via different computers, then we don't know which one to open the document on. This means that if you have been working from your home computer, but you are now connected from your office computer, the document you just asked to open may have been opened at home instead.

## Turn on logging

### LogFile

> [!TIP]
> This is the file support usually will ask for.

1. Open the Registry. The user needs a write permission to the file.
2. Add a new String value under *HKCU\Software\SuperOffice\DocLink*:

    * Value name = **LogFile**
    * Value data = The full path to a log file where it should write diagnostics. User running WebTools needs to have write permission to this file and folder.

![WebTools LogFile -screenshot][img1]

### Get a WebTools for Mac log file

1. Click **Go** then **Library**.

    ![WebTools for Mac log file -screenshot][img4]

2. Navigate to *Application Support* folder then *SuperOffice WebTools*. Then create a new text file without an extension, call it *debug* and move it to the folder *SuperOffice WebTools*. Restart WebTools.

    ![WebTools for Mac log file -screenshot][img5]

3. Open a **Console**

    ![WebTools for Mac log file -screenshot][img6]

4. In the console dialog search field fill in **SuperOffice** and click **Save**. The information should be saved in the debugging file. If it doesn’t, select all the entries and right-click and click copy then paste it in the debugging file.

    ![WebTools for Mac log file -screenshot][img7]

<!-- Referenced images -->
[img1]: media/webtoolslog.png
[img4]: media/imagewukx.png
[img5]: media/imagew1mo6.png
[img6]: media/imagelzq97.png
[img7]: media/imagedo4c.png
