---
uid: get-invitation-services
title: How to get a list of invitations (services)
description: How to get a list of invitations using NetServer services
keywords: diary, calendar, appointment, API, web services, archiveprovider
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
redirect_from: /en/diary/howto/services/get-invitations-services
---

# How to get a list of invitations (services)

The code below is used to retrieve a list of [invitations][1] for a specific associate with [NetServer services][2].

## Code

[!code-csharp[CS](includes/get-invitations-services.cs)]

## Walk-through

In the code, we have used an instance of the [InvitationProvider][3] and some of its methods to restrict and arrange the output returned by the provider.

| Method | Description |
|---|---|
| SetOrderBy | sorts the output by ID |
| SetPageInfo | limits the number of rows returned to the first 100 rows |
| SetDesiredColumns | is used to identify which columns should be returned by the provider |
| SetRestriction | sets the query restriction for the provider |
| GetRows | can be used to retrieve the rows returned by the provider |

The provider returns a collection of `ArchiveRow` types. By looping through each `ArchiveRow` we can get details of an invitation for the associate. The result of executing the above code is shown below.

```text
associate/contactFullName    date        endDate           appointmentId
StateZeroDatabase       [D:07/05/2007]    [D:07/05/2007]    [I:186]
StateZeroDatabase       [D:07/26/2007]    [D:07/26/2007]    [I:179]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:172]
StateZeroDatabase       [D:06/14/2007]    [D:06/14/2007]    [I:161]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:150]
```

<!-- Referenced links -->
[1]: ../../../../diary/learn/invitation/index.md
[2]: ../../index.md
[3]: ../../../archive-providers/reference/invitation.md
