---
title: Automated tasks ejSender
uid: automated_task_ejsender
description: Automated tasks in Service - ejSender
author: {github-id}
keywords:
so.topic: concept
so.envir: onsite
# so.client:
---

# ejSender

Responsible for sending out Mailings.

**Usage:** `ejSender [OPTION] domain`

**Options:**

* -shipmentId \<id> ID of the shipment. Required
* -timestamp Unix timestamp. Required.
* -senderNr \<sender number> Which sender this ejSender will be.
* -force Force the processes.
* -debug Display debug information.
* -maxDebug Display all debug information (enables debug).
* -doSending Start sending.
* -doPopulate Start populating.
* -about Show about.

Example: `ejSender -shipmentId 1 -timestamp 1464350088 -maxDebug support.yourdomain.com`
