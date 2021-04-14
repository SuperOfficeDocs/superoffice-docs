---
title: Debug
uid: debug_maillink
description: Debug MailLink
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# Debug MailLink

If you need to enable debug logging for MailLink, open SuperOffice CRM Options, go to **SuperOffice Account** tab, open **Advanced** settings and tick **Enable debug logging**. You can also open the log file from the same place.

Log file is located at: *%appdata%\\SuperOffice\\MailLink\\Log*  (both for Windows- and Web users.)

In the same folder you can also enable debug log by edit the *log_settings.xml* file, set `<EnableDebug>true</EnableDebug>`

![x][img1]

<!-- Referenced images -->
[img1]: media/maillink-enabledebuglog-web.png
