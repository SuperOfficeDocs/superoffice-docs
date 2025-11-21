---
uid: automated-tasks
title: Automated tasks
description: Automated tasks in Service
keywords: automated tasks
author: SuperOffice Product and Engineering
date: 11.21.2025
content_type: concept
deployment: onsite
category: Service
redirect_from: /en/service/automated-tasks/
---

# Automated tasks in Service

In Service, several tasks are automated and run on a set schedule on the server. These tasks are carried out by the executables located in the *bin* folder of your Service installation.

Here, we cover the most used executables and how to debug them. In addition to the parameters provided for the executables, they all take the parameter `--help` to display more information.

If you want to store the output of running the executable in the command line to a file, add `>> <filename>` at the end of the command. Keep in mind that all output will be in the log file and will not be shown in the command prompt.

Example: `ejournalCron -maxdebug >> ejournalcronlog.txt`

## List of executables

* [dbi][1]
* [ejournalCron][2]
* [ejOutbox][3]
* [ejSender][4]
* [ejTermSetup][5]
* [importMail][6]
* [upgrade][7]

<!-- Referenced links-->
[1]: dbi.md
[2]: ejournalcron.md
[3]: ejoutbox.md
[4]: ejsender.md
[5]: ejtermsetup.md
[6]: importmail.md
[7]: upgrade.md
