---
uid: mail-link-debug
title: Debug
description: Debug MailLink
keywords: debug MailLink, log_settings.xml, EnableDebug
author: Bergfrid Dias
date: 02.23.2026
content_type: howto
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
deployment: onsite
redirect_from:
  - /en/email/mail-link/debug
index: true
---

# Debug MailLink

If you need to enable debug logging for MailLink, open SuperOffice CRM Options, go to **SuperOffice Account** tab, open **Advanced** settings and tick **Enable debug logging**. You can also open the log file from the same place.

The log file is located at *%appdata%\SuperOffice\MailLink\Log*.

In the same folder, you can also enable debug log by editing the *log_settings.xml* file, set `<EnableDebug>true</EnableDebug>`.
