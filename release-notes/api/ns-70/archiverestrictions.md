---
title: ArchiveRestrictions
uid: whats_new_70_archiverestrictions
description: NetServer 7.0
author: {github-id}
date: 11.05.2016
keywords:
topic: reference
---

# ArchiveRestrictions

There is an implicit «AND» between archive restrictions New in 7: It doesn’t have to be.

* You can say «OR»

* You can add parentheses:

(type = notDone AND activeDate before today)
OR (type = done AND activeDate = today)

This is almost universally supported. Some very special «restrictions», like those used to tell the Participants provider which associates to include (instead of the provider looking them up in the database) don’t support this functionality, as it would be pretty meaningless. But most ordinary restrictions work this way.

![ALT][img1]

<!-- Referenced images -->
[img1]: media/image019.jpg
