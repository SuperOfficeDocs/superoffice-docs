---
uid: whats-new-70-archiverestrictions
title: ArchiveRestrictions
description: NetServer 7.0
keywords: API changes
author: SuperOffice AS - Product and Engineering
date: 11.05.2016
version: 7.0
content_type: release-note
category: api
---

# ArchiveRestrictions

There is an implicit "AND" between archive restrictions New in 7: It doesn't have to be.

* You can say "OR"

* You can add parentheses:

(type = notDone AND activeDate before today)
OR (type = done AND activeDate = today)

This is almost universally supported. Some very special "restrictions", like those used to tell the Participants provider which associates to include (instead of the provider looking them up in the database) don't support this functionality, as it would be pretty meaningless. But most ordinary restrictions work this way.

![ALT][img1]

<!-- Referenced images -->
[img1]: media/image019.jpg
