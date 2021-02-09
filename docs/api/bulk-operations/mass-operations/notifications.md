---
title: Mass Operation Notifications
description: How database table changes are realized.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations
version: 9.2 R04
---

# Mass Operation Notifications

Both extra tables and ordinary system tables can be changed by the mass operations, however, SuperOffice does not currently support webhooks for extra tables. Those table changes are also *not* added to the travel transaction log table.

All other system tables do send out notifications to webhook subscribers, row by row, and each change is logged into travel transaction logged.
