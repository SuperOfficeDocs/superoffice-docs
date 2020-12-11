---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: troubleshooting_ribbons       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Troubleshooting SuperOffice Ribbons # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# Troubleshooting SuperOffice Ribbons

## Activate VSTO error messages

SuperOffice Ribbons is build upon Microsoft Office VSTO, and you can turn on troubleshooting on the VSTO. You will then get an error message in the MS Office application who tries to load the add-in:

1. Add a new environment variable: Control Panel > System and Security > System > Advanced System Settings, under System Variables. `VSTO_SUPPRESSDISPLAYALERTS = 0`

![x][1]

2. Make sure "LoadBehavior in the window registry is set to "3". This will make sure the Office application will try to start the add-in.  

![x][2]

3. Start MS Office-application, read the error message that pops up.

![x][3]

This example shows it was Office 2007 missing SO Ribbons. The solution is to install Microsoft Visual Studio 2010 Tools for Office Runtime.

(delete the new environment variable added in #1)

## Check the log-files

Both SO Ribbons and MailLink write to log files in the folder *%APPDATA%\\SuperOffice*

<!-- Referenced links -->
[1]: media/vsto1.png
[2]: media/vsto2.png
[3]: media/vsto3.png
