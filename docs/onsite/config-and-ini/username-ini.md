---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: username_ini       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Username.ini # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Username.ini

*Username.ini* - used by SuperOffice Remote Travel Server (SORTS.exe), created by SuperOffice Remote Travel (SORT.exe)

## Config file to say which additional documents the user wants copied from the central database

![x][1]

*Username.ini* is created by the SuperOffice CRM - Remote travel client, and all settings under My Documents, Other Documents and Exclude list is written to this file. The file is stored in *%localappdata%\\SuperOffice* and when the travel user syncs it is copied to the central archive *\\SO\_Arc\\Wishlist* folder.

![x][2]

> [!NOTE]
> It adds the associate ID when you ask for other users and will check the database for this associate's current user group.<br/>Documents from other users are only copied down to the travel user, not from travel user to central.

SuperOffice Remote Travel Server (SORTS.exe) must be run from the travel gateway to process this file. This will generate the *Copylist-username.txt* file with a list of documents that should be copied to the travel user next time they run the Remote Travel client.

<!-- Referenced links -->
[1]: media/sort.png
[2]: media/sortotherdocuments.png
