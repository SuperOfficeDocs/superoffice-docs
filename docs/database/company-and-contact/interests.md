---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: interests       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Interests # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Interests

![ContactInterests][img1]

Interests are stored on Contacts and Persons - there are two separate sets of interests, and a separate set of link tables.

![InterestLinkTable][img2]

The link table (`ContactInterest`) allows a single contact to have zero, one or more interests checked off.

The `ContInt` table is an MDO table, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a contact.

```sql
SELECT * FROM contint
```

![InterestsTable][img3]

```sql
SELECT * FROM contactinterest
```

![ContIntLinkTable][img4]

## Get interests for contact

To get a list of interests checked off for a contact:

```sql
SELECT * FROM contactinterest WHERE contact\_id = 123
```

To get the names of the checked off interests for a contact:

```sql
SELECT * FROM contactinterest, contint
WHERE contactinterest.contact_id = 123
AND contactinterest.cinterest_idx = contint.contint_id
```

![ContactInterestJoin][img5]

## Contact cached value

The Contact table has a counter field that stores the number of active interests.

This field is used to cache the count. It is updated whenever the user edits the company.

The field is used to quickly check whether the interests tab needs to indicate the presence of interests or not.

<!-- Referenced images -->
[img1]: media/contact-interests.png
[img2]: media/interestlink-table.png
[img3]: media/interests-table.png
[img4]: media/contintlink-table.png
[img5]: media/contact-interest-join.png
