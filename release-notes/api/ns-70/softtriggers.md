---
title: SoftTriggers
uid: whats_new_70_softtriggers
description: NetServer 7.0
author: {github-id}
date: 11.05.2016
keywords:
topic: reference
---

# SoftTriggers

NetServer has its own OSQL interception system. Used by Sentry, travel transaction logging, free-text index, … You can have one too – on insert/update/delete.

**SoftTrigger** defines a way to set a pre- or post-execution callback, for a specific table.

![ALT][img1]

![ALT][img2]

Your delegate is called before or after execution:

* "Before" is after `TravelTransactionLogger`, `SoundexUpdater`, Sentry, Registered/LastUpdated, and TimeZone have been there. You can change the OSQL (very carefully)

* "After" is, well, after. That would probably be just to log it.

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
