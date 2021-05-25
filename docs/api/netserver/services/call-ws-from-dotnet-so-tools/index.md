---
title: How to call SuperOffice web services from .Net
uid: call_ws_from_dotnet_so_tools
description: How to call SuperOffice web services from .Net with SuperOffice tools
author: {github-id}
so.date:
keywords:
so.topic: guide
---

# How to call SuperOffice web services from .Net with SuperOffice tools

To access SuperOffice web services from .Net using SuperOffice tools, you need the following.

## Required DLLs

When we are using the following set of DLLs, we don’t have to add a web service reference to the application. The `SuperOffice.Services.Proxy` DLL will communicate with the web service that we have specified in our `app.config` file.

* SOCore
* SuperOffice.Services
* SuperOffice.Services.Proxy

![01][img1]

<!-- Referenced images -->
[img1]: media/image001.jpg

## Steps

1. [Configure NetServer for SuperOffice web services][1]
2. [Calling the web service][2] (authenticate and get entity)

<!-- Referenced links -->
[1]: config.md
[2]: calling.md
