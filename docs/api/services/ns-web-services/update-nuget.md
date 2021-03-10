---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: update_nuget       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Upgrade version of SuperOffice NuGet # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Upgrade version of SuperOffice NuGet

**Pre-requisites:**

* You have downloaded the new NuGet package.

**To update:**

1. Copy your *app/web.config* file.

2. Run the NuGet update:

    `Update-Package <package_name>`

3. Restore the *web.config* file from the backup you just created.

During an upgrade, the NuGet packages **will overwrite** certain SuperOffice sections in the configuration files!
