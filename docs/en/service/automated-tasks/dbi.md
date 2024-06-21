---
title: dbi
uid: automated_task_dbi
description: Automated tasks in Service - dbi
author: {github-id}
keywords: service
topic: reference
envir: onsite
# client:
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
