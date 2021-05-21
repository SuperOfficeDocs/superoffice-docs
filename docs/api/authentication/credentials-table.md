---
title: Credentials table
uid: credentials_table
description: Credentials table
author: {github-id}
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Credentials table

The `Credentials` table stores **outgoing** credentials – such as mail server logins for CRM web. Version 7 introduced **incoming** credentials (password, SID) and tickets as types. Custom plugins can add their own information.

![Credentials Table][img1]

Examples:

| Id | Assoc | Type | SearchName | Secret | ValidFrom | ValidTo | LastUsed |
|---|---|---|---|---|---|---|---|
| 92 | 104 | CRM5/PASSWORD | ADM0 | 7P:DnYq1bcQ9eys2z9WkgpxYBpP63M= | 2010-05-11 00:00:00 | 9999-12-31 23:59:59 | SUPEROFFICE_ASA\marekv on DEV-MAREK-2: SOCRM.exe (Logging in to SuperOffice CRM) |
| 93 | 17 | Ticket | d3989fc9-4d3a-44da-8f5b-85b0456103ef | 7S:IA087dxXBlSDMkRPqbigesOiIQA= | 2010-05-13 07:09:20 | 2010-05-14 13:09:20 | |
| 96 | 105 | ActiveDirectory | S-1-5-21-2132039509-1139229262-60295696-6555 | | 2010-05-14 00:00:00 | 9999-12-31 23:59:59 | |

A checksum column prevents tampering (not shown here) – simply put: change anything important, and the row becomes invalid.

Rows are bound to database. Copying to another database will not work

For the time being, a user can have either password or AD authentication. The database model is not limited, but the software is. Allowing multiple credentials could potentially be quite confusing.

`LastUsed` provides a peek at what is going on and from where. Depending on the application you can get more or less information, and it is updated on every (re)authentication. It’s easy to imagine a "who is on" tool leveraging this info, but remember that the same ticket can be passed to multiple places/apps/processes, so it’s not as detailed as you might want.

<!-- Referenced images -->
[img1]: media/image001.gif
