---
title: importMail
uid: automated_task_importmail
description: Automated tasks in Service - importMail
author: {github-id}
keywords: service
topic: reference
envir: onsite
# client:
---

# importMail

Responsible for importing mail into Service.

**Usage:** `importMail [OPTION] domain`

**Options:**

* **-force** Try to import all mails.
* **-debug** Display debug information.
* **-maxdebug** Display all debug information (enables debug).
* **-interactive** Confirm each mail import.
* **-socketdebug** Debug socket activity (lots!).
* **-delay** Delay import for a random number of seconds.
* **-noinbox** Do not import inbox files.
* **-file** Import from a file.
* **-filter** Set `mail_in_filter.id`. Required together with file.
* **-about** Show about.

**Example:** `importMail -file "C:\Customer Service\text\Inbox\inbox.298231" -filter 13 support.yourdomain.com`
