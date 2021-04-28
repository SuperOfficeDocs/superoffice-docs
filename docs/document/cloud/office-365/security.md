---
title: office_365_security
description: Office 365 document integration security
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Considerations / security

We currently do not support adding the App to a "Site Collection". The folder needs to be a relative path to the root of the SharePoint site.

## Default access permission on documents

Documents created via SuperOffice that are hosted in SharePoint will be given a default-permission based upon what access rights are set on the SharePoint folder.
