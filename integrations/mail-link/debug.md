---
uid: mail-link-debug
title: Debug Mail Link
description: Learn how to enable debug logging for SuperOffice Mail Link and locate the log file.
keywords: debug MailLink, log_settings.xml, EnableDebug
author: digitaldiina
date: 03.17.2026
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

# Debug Mail Link

If you need to enable debug logging for Mail Link, open SuperOffice CRM Options, go to **SuperOffice Account** tab, open **Advanced** settings and select **Enable debug logging**. You can also open the log file from the same place.

The log file is located at *%appdata%\SuperOffice\MailLink\Log*.

In the same folder, you can also enable debug log by editing the *log_settings.xml* file, set `<EnableDebug>true</EnableDebug>`.
