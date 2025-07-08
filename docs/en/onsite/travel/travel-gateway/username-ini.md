---
title: Username.ini
uid: username_ini
description: Username.ini
author: SuperOffice Product and Engineering
keywords:
content_type: reference
---

# Username.ini

*Username.ini* - used by SuperOffice Remote Travel Server (SORTS.exe), created by SuperOffice Remote Travel (SORT.exe)

## Config file to say which additional documents the user wants to copy from the central database

![x -screenshot][img1]

*Username.ini* is created by the SuperOffice CRM - Remote travel client, and all settings under My Documents, Other Documents, and Exclude list are written to this file. The file is stored in *%localappdata%\SuperOffice* and when the travel user syncs it is copied to the central archive *SO_Arc\Wishlist* folder.

![x -screenshot][img2]

> [!NOTE]
> It adds the associate ID when you ask for other users and will check the database for this associate's current user group.
>
> Documents from other users are only copied down to the travel user, not from a Travel user to central.

SuperOffice Remote Travel Server (SORTS.exe) must be run from the travel gateway to process this file. This will generate the *Copylist-username.txt* file with a list of documents that should be copied to the travel user next time they run the Remote Travel client.

<!-- Referenced images -->
[img1]: media/sort.png
[img2]: media/sortotherdocuments.png
