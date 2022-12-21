---
title: SAIN values
uid: saint_values
description: SAINT values are simple binary values - either on or off. To find all SAINT values for a contact or project, search the StatusValue table.
author: Bergfrid Dias
so.date: 11.05.2021
keywords: sale, saint, statusvalue, statusdef, isSignalled, isVisual
so.topic: concept
# so.envir:
# so.client:
---

# SAINT values

Values are much easier than [counters][1]. They are simple binary values - either on or off.

To find all the SAINT values for a particular contact or project, simply search the `StatusValue` table:

```SQL
Select * from statusvalue where contact_id =89
```

| StatusValue_id | StatusDef_id | contact_id | person_id | project_id | isSignalled | needsUpdate | registered |
|---|---|---|---|---|---|---|---|
| 3694 | 1 | 89 | 0 | 0 | 1 | 1 | 2021-11-05 15:54:10 |
| 3693 | 7 | 89 | 0 | 0 | 1 | 1 | 2021-11-05 15:54:10 |

The image that is shown on the contact card is determined by the status definition - and the blob linked to this record.

```SQL
Select * from statusdef where statusdef_id = 7
```

| StatusDef_id | isVisual | needsUpdate | rank | deleted | ownerTable | lastGenerated | ... |
|---|---|---|---|---|---|---|---|
| 7 | 1 | 0 | 1 | 0 | 5 | 2021-11-05 15:54:10 | |

`isVisual` indicates that a picture is used to mark that the status is active.

The actual picture is found via the blob link table.

<!-- Referenced links -->
[1]: counters.md
