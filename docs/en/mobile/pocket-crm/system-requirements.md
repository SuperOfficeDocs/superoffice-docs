---
title: System requirements
uid: pocket_crm_system_requirements_onsite
description: System requirements for Pocket CRM mobile client
author: {github-id}
keywords:
topic: reference
envir: onsite
client: pocket
---

# System requirements for Pocket CRM - Onsite

These requirements are specific to Onsite installations of SuperOffice. They supplement the requirements for the [client application][1].

> [!NOTE]
> To be able to use all released features for Pocket CRM, you need to use the direct NetServer connection mode.

## Connection

### NetServer

* For [direct NetServer connection][2], NetServer must be version 8.0 or higher.
* Pocket version 8 running directly with NetServer must have remote web services.

### TLS

* The site must allow TLS 1.0 if you are running on a Pocket CRM version lower than 8.0.32, which was released August 15th 2016.
* From August 15th, 2016 we added support for TLS 1.2 communication protocols between device and server.

## Business card scanner

Business card scanner will work with all SuperOffice versions, both Onsite and Online. It requires the Pocket CRM client to be configured against NetServer (no Pocket server).

## Which Services end-point to use?

Pocket CRM will automatically pick up the correct Services folder.

<!--Referenced links-->
[1]: client-requirements.md
[2]: configure.md
