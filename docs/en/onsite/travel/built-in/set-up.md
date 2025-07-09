---
title: Built-in as Travel database
uid: set_up_built_in_travel
description: Built-in as travel database
author: SuperOffice Product and Engineering
keywords: travel
date:
content_type: howto
deployment: onsite
platform: win
redirect_from: /en/onsite/travel/built-in/index
---

# Built-in as Travel database

## Prerequisites

None

## Automatic setup

[!include[ALT](../includes/local-update.md)]

> [!NOTE]
> The built-in database is a Sybase database engine, so if your anti-virus asks if you want to block it, you need to answer no.

You may add `LocalDbEngineParam=''` to the *SuperOffice.ini* file. If this parameter is not present, it will default to '-c 16m' meaning 16 MB of local cache memory for the database engine.

## Manual setup

The local archivepath defaults to the logged-in user's application data folder:

```text
local_archivepath=C:\Documents and Settings\USER\Local Settings\Application Data\SuperOffice\SO_LOCAL
```

If you want to change the location of the local document archive you may open the *SuperOffice.ini* file and change the `local_archivepath=`.
