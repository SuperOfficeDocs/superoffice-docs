---
title: Debug
uid: debug_maillink
description: Debug MailLink
author: Bergfrid Dias
date: 12.16.2011
keywords: MailLink, debug, log_settings.xml, EnableDebug
topic: howto
envir: onsite
---

# Debug MailLink

If you need to enable debug logging for MailLink, open SuperOffice CRM Options, go to **SuperOffice Account** tab, open **Advanced** settings and tick **Enable debug logging**. You can also open the log file from the same place.

The log file is located at *%appdata%\SuperOffice\MailLink\Log*  (both for Windows- and Web users.)

In the same folder, you can also enable debug log by editing the *log_settings.xml* file, set `<EnableDebug>true</EnableDebug>`

![Enable debug logging for MailLink -screenshot][img1]

<!-- Referenced images -->
[img1]: media/maillink-enabledebuglog-web.png
