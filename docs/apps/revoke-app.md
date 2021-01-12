---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: revoke_app       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Revoke access given to an app # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Revoke access given to an app

Revoking access to an application is a manual procedure. It will sever the connection between the application and a database tenant. It will not remove any data from the database.

The revocation must be done by the customer's tenant administrator.

1. Sign in to the [App Store][1].
2. Locate the application you want to revoke access to.
3. Click **Report a problem** and tell us that you no longer want this application to have access to your tenant.
4. If provided, use the application's **Uninstall** to remove the configuration (such as user-defined fields and web panels).

<!-- Referenced links -->
[1]: http://online.superoffice.com/appstore