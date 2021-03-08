---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: service_time_zones       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Time zones in Service # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Time zones in Service

Earlier, there was a setting on the users in Service enabling to set a timezone which was used when displaying and inputing datetimes.

In 8.4 R02, this setting has been removed. Instead we use the "Preferred time zone" preference in Web Admin, found under "Default values".

Existing settings on the users in Service will NOT be migrated to the "Preferred time zone" preference.

So this results in two scenarios:

* If you have set a time zone in Service but not a "Preferred time zone" in Web Admin then you will have to add it manually for the user.
* If you have NOT set a time zone in Service but a user has a "Preferred time zone" set then Service dates will now start respecting this.
