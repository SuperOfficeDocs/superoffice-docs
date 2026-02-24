---
uid: webtools-debug
title: Debugging WebTools
description: How to debug WebTools
keywords: debug WebTools, DocLink
author: Jostein K, Bergfrid Dias
date: 02.24.2026
content_type: howto
category: integration
topic: WebTools
deployment: onsite
language: en
redirect_from: /en/document/webtools/debug
---

# Debugging WebTools

The Web Extension depends on a constant connection to the CRM Server to work properly. If you are having connectivity issues, turn on logging to troubleshoot.

## LogFile

> [!TIP]
> This is the file support usually will ask for.

1. Open the Registry. The user needs a write permission to the file.
2. Add a new String value under *HKCU\Software\SuperOffice\DocLink*:

    * Value name = **LogFile**
    * Value data = The full path to a log file where it should write diagnostics. User running WebTools needs to have write permission to this file and folder.

![WebTools LogFile -screenshot][img1]

## Get a WebTools for Mac log file

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
