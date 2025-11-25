---
uid: automated-task-dbi
title: dbi
description: Automated tasks in Service - dbi
keywords: dbi
author: SuperOffice Product and Engineering
date: 11.21.2025
content_type: reference
deployment: onsite
category: service
redirect_from: /en/service/automated-tasks/dbi
---

# dbi

Used for executing your dbi tasks. Can be executed with parameters to see more debug information.

**Usage:** `dbi [OPTION] <domain>`

**Options:**

* -force Try to run all schedules.
* -debug Display debug information.
* -asap \<id> Run dbi schedule \<id> as soon as possible.
* -param \<name>=\<value> Set a dbi parameter from command line.
* -maxDebug Display all debug information (enables debug).
* -dump Dump XML package to console.
* -convert \<id> Convert external datasource to DBI Agent.
* -about Show about.

Example: `dbi -asap 12 -force -debug support.yourdomain.com`
