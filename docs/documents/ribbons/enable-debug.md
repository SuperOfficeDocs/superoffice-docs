---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: enable_debug_for_ribbons       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Enable debug for Ribbons # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# Enable debug for Ribbons

As with Mail Link, Ribbons logs to *%AppData%\\SuperOffice* folder. It logs to the *Ribbons.log* file by default.

You may also specify the location for the logfile by setting the logpath in [SuperOffice.ini][1].

Please note that logging for Ribbons is only turned on if both these values are set in SuperOffice.ini:

```text
[Error]  
EnableDebug = 1  
EnableRibbonLog = 1
```

Please note running Ribbon vsto file can cause issues and this should not be done. Read more info on the [Community forum][2].

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/older-versions/documentation-7/SM/winclient/ini-files/superofficeini/
[2]: https://community.superoffice.com/en/technical/Forum/rooms/topic/superoffice-product-group/crm-windows-application/why-we-should-not-run-vsto-installer-manually/