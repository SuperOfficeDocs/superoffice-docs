---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: debug_maillink # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Debug MailLink # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Debug MailLink

If you need to enable debug logging for Mail Link, open SuperOffice CRM Options, go to SuperOffice Account tab, open Advanced settings and tick Enable debug logging. You can also open the log file from the same place.

Logfile is located at: %appdata%\\SuperOffice\\MailLink\\Log  (both for Windows- and Webusers)  
In same folder you can also enable debug log by edit the **log\_settings.xml** file, set <EnableDebug>**true**</EnableDebug>

![x][1]

<!-- Referenced links -->
[1]: media/maillink---enabledebuglog---web.png
