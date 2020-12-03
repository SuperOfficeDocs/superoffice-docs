---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: office_365_security       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Office 365 document integration security  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: article               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online             # online, web, win, pocket, or mobile
---

# Considerations / security

We currently do not support adding the App to a "Site Collection". The folder needs to be a relative path to the root of the SharePoint site.

## Default access permission on documents

Documents created via SuperOffice which are hosted in SharePoint will be given a default-permission based upon what access rights are set on the SharePoint folder.
