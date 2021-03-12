---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pocket_crm_system_requirements_onsite # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: System requirements for Pocket CRM mobile client # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
#so.envir:                      # cloud or onsite
so.client: pocket               # online, web, win, pocket, or mobile
---

# System requirements for Pocket CRM - onsite

These requirements are specific to onsite installations of SuperOffice. They supplement the requirements for the [client application][1].

> [!NOTE]
> To be able to use all released features for Pocket CRM, you need to use the direct NetServer connection mode.

## Connection

### NetServer

* For [direct NetServer connection][2], NetServer must be version 8.0 or higher.
* Pocket version 8 running directly with NetServer must have remote web services.

### TLS

* The site must allow TLS 1.0 if you are running on a Pocket CRM version lower than 8.0.32 which was released August 15th 2016.
* From August 15th, 2016 we added support for TLS 1.2 communication protocols between device and server.

## Business card scanner

Business card scanner will work with all SuperOffice versions, both Onsite and Online. It requires the Pocket CRM client to be configured against NetServer (no Pocket server).

## Which Services end point to use?

[!include[Services end points table](../includes/services-end-points.md)]

Pocket CRM will automatically pick up the correct Services folder.

<!--Referenced links-->
[1]: ../../mobile/pocket-crm/system-requirements.md
[2]: ../../mobile/pocket-crm/configure.md