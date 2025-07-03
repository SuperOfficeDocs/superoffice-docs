---
uid: whats-new-70-real-dates
title: Real dates
description: NetServer 7.0
keywords: API changes
author: SuperOffice AS - Product and engineering
date: 11.05.2016
version: 7.0
content_type: release-note
category: api
---

# Real dates

We changed our datetime format from seconds-since-1970 to a real datetime.

So now we can search for dateparts, all the databases support it.

![ALT][img1]

> [!NOTE]
> Using an `ArgumentFunction` means that the return field no longer has a name (it's enclosed by the function). Therefore we use the `Alias.Name` to give it a name that we can then use when calling `Reader.GetInt32()`. You could always use a position index instead, but that makes the code much more fragile in the face of changes.

See the QueryExecutionHelper class for more help.

<!-- Referenced links -->
[img1]: media/image001.jpg
