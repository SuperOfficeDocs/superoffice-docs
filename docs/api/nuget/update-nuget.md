---
title: Upgrade version of SuperOffice NuGet
uid: update_nuget
description: Upgrade version of SuperOffice NuGet
author: Tony Yates
keywords:
so.topic: howto
so.envir:
so.client:
---

# Upgrade version of SuperOffice NuGet

## Pre-requisites

* You have downloaded the new NuGet package.

> [!NOTE]
> During an upgrade, the NuGet packages **will overwrite** certain SuperOffice sections in the configuration files!

## To update

1. Copy your *app/web.config* file.

2. Run the NuGet update:

    `Update-Package <package_name>`

3. Restore the *web.config* file from the backup you just created.
