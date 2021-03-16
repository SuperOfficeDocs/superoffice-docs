---
title: get_interests_sql
description: Interests
author: {github-id}
keywords: interests,contact
so.topic: howto

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get interests for contact

**To get a list of interests checked off for a contact:**

```SQL
SELECT * FROM contactinterest WHERE contact_id = 123
```

**To get the names of the checked-off interests for a contact:**

```SQL
SELECT * FROM contactinterest, contint
WHERE contactinterest.contact_id = 123
AND contactinterest.cinterest_idx = contint.contint_id
```

![ContactInterestJoin][img1]

<!-- Referenced images -->
[img1]: media/contact-interest-join.png
