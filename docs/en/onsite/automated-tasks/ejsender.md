---
uid: automated-task-ejsender
title: Automated tasks ejSender
description: Automated tasks in Service - ejSender
keywords: ejsender
author: SuperOffice Product and Engineering
date: 11.21.2025
content_type: reference
deployment: onsite
category: Service
redirect_from: /en/service/automated-tasks/ejsender
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
