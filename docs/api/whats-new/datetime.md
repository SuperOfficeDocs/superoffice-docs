---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_datetime       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - DateTime # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# DateTime - new from SuperOffice v.7

Up to version 7, we stored date as an integer, 1-1-1970 + n seconds, giving us the "end of the world" in 19.1.2038 at 03:14:07.

Now use the built-in datetime datatype in the database which makes things a lot more legible, and makes it possible to search for things like dateparts (year). NetServer has new low-level functions to do this, not yet used in our own code.
One problem: How do you say "unknown" without saying "NULL"?

The one good thing about the old posix datetime was that there was an obvious "beginning of time" value: 0    Datetime has no such natural starting point; not least because the different databases do not agree. SQL Server says 1.1.1753; Sybase and DB/2 say 1.1.0001; Oracle says 1.1.4712BC

1.1.1760 is a good compromise, and not likely to conflict with a real date, this corresponds to "0" from the date-as-int past
31.12.9999 is DateTime.MaxValue and means "forever". Anything in between is a real date – but the Windows code still works with posix times internally so this means 1970 -> 2038 still applies.

In the code, we convert from 1.1.1760 to 1.1.1970 (c++) or DateTime.MinValue (C\#) automatically. The code and applications dependent on it see no change from what things were like earlier.

Since the C++ still works with posix `date_t` internally, we still have the same limitations. Overcoming these is a big project that relates to all our C++ and Windows GUI code; and it just was not worth the risk and effort in this round.

User-defined fields are not being changed in 7.0 and here Datetime is still mapped to an int.
UnlimitedDate also stays the same, as a string internally (YYYYMMDD).
