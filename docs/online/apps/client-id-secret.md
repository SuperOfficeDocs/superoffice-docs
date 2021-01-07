---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: client_id_secret       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Client ID and secret # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: credentials
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Client ID and secret

The client ID and client secret are your application's credentials.

## Partner Identifiers

Partner applications have two unique identifiers: `ApplicationIdentifier` (client ID) and `ApplicationToken` (client secret). The latter is considered a password and must be stored as such.

### Client ID - ApplicationIdentifier

Uniquely identifies the application used, and used by the SuperOffice CRM Online to know where to redirect a user.

### Client secret - ApplicationToken

Must be supplied when invoking any of the SuperOffice CRM Online web services.
