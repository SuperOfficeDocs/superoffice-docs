---
title: interests
description: Contact interests
author: {github-id}
so.date: 05.11.2016
keywords: interest, contact
so.topic: concept
# so.envir:
# so.client:
---

# Interests

![ContactInterests][img1]

Interests are stored on contacts and persons - there are 2 separate sets of interests and a separate set of link tables.

![InterestLinkTable][img2]

The link table (`ContactInterest`) allows a single contact to have zero or more interests checked off.

The `ContInt` table is an MDO table, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a contact.

```SQL
SELECT * FROM contint
```

![InterestsTable][img3]

```SQL
SELECT * FROM contactinterest
```

![ContIntLinkTable][img4]

You can extend the list of interests for a contact by creating and adding a new interest to that list.

## Contact cached value

The Contact table has a counter field that stores the number of active interests.

This field is used to cache the count. It is updated whenever the user edits the company.

The field is used to quickly check whether the interests tab needs to indicate the presence of interests or not.

<!-- Referenced images -->
[img1]: media/contact-interests.png
[img2]: media/interestlink-table.png
[img3]: media/interests-table.png
[img4]: media/contintlink-table.png
