---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: saint_values       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SAINT values # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# SAINT values

Values are much easier than [counters][1]. They are simple binary values - either on or off.

To find all the SAINT values for a particular contact or project, simply search the `StatusValue` table:

```SQL
Select * from statusvalue where contact_id =89
```

![x][img1]

The image that is shown on the contact card is determined by the status definition - and the blob linked to this record.

```SQL
Select * from statusdef where statusdef_id = 7
```

![x][img2]

`isVisual` indicates that a picture is used to mark that the status is active.

The actual picture is found via the blob link table.

<!-- Referenced links -->
[1]: counters.md

<!-- Referenced images -->
[img1]: media/statusvalue.png
[img2]: media/statusdef.png
