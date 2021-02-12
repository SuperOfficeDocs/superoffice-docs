---
title: whats_new_70_
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# CultureDataFormatter

What does "1,000" mean?

* "one point zero zero zero" ?

* "one thousand" ?

Making everything into a string can be practical, but also disastrous. To avoid misunderstandings, we say  "\[I: 1000\]", which may not be the most elegant format, but it is human-readable and unambiguous.

`CultureDataFormatter`, in *SoCore*, is your friend when faced with such a string

The parsing methods are quite format-tolerant. In addition to strings like "\[I:1234\]", they will also accept simply "1234".

LocalizeXXX methods return formatted strings, using the current culture.  You can selectively encode datetime, date, or time

ArchiveProviders use this format for the DisplayText return value. If you make your own archive provider components, you should do so too

![ALT][img1]

fromInt = "\[I:1234\]"

fromDate = "\[DT:11/12/2010 09:49:35.9227577\]"

![ALT][img2]

localInt = 1234

localDate2 = 12.11.2010 9:49 AM

<!-- Referenced images -->
[img1]: media/image014.jpg
[img2]: media/image015.jpg
