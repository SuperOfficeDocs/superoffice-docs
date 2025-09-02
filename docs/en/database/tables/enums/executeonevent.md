---
uid: enum-executeonevent
title: Enum values for ExecuteOnEvent
description: Lists the enum values for ExecuteOnEvent.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# ExecuteOnEvent Enum

Events that cause automatic execution of this app

| Name | Value | Description |
|------|-------|-------------|
|Never|0|This application is never executed automatically|
|Logon|1|Execute this application during logon|
|Logoff|2|Execute this application before logoff|
|LocalUpdate|3|Execute this application before a local update (start travelling)|
|Wait|16384|When executing this application, wait for it to start|

## Usage

* [ExtApp](../extapp.md).executeOnEvent - ExtApp list table. Applications startable from SuperOffice
