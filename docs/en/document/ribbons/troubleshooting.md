---
title: Troubleshooting
uid: troubleshooting_ribbons
description: Troubleshooting SuperOffice Ribbons
author: {github-id}
keywords:
topic: howto
envir: onsite
client: win
---

# Troubleshooting SuperOffice Ribbons

## Activate VSTO error messages

SuperOffice Ribbons is build upon Microsoft Office VSTO, and you can turn on troubleshooting on the VSTO. You will then get an error message in the Microsoft Office application that tries to load the add-in:

1. Add a new environment variable: Control Panel > System and Security > System > Advanced System Settings, under System Variables. `VSTO_SUPPRESSDISPLAYALERTS = 0`

    ![x -screenshot][img1]

2. Make sure "LoadBehavior in the window registry is set to "3". This will make sure the Office application will try to start the add-in.

    ![x -screenshot][img2]

3. Start the Microsoft Office application, read the error message that pops up.

    ![x -screenshot][img3]

This example shows it was Office 2007 missing SO Ribbons. The solution is to install Microsoft Visual Studio 2010 Tools for Office Runtime.

(delete the new environment variable added in #1)

## Check the log-files

Both SO Ribbons and MailLink write to log files in the folder *%APPDATA%\SuperOffice*.

<!-- Referenced images -->
[img1]: media/vsto1.png
[img2]: media/vsto2.png
[img3]: media/vsto3.png
