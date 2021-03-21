---
uid: enum-quoteversionstate
title: Enum values for QuoteVersionState
description: Lists the enum values for QuoteVersionState.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# QuoteVersionState Enum

State that this quote version had, right before it was changed to Archived; in this way we can show what happened before the archiving.

* Unknown = 0
* Draft = 1
* DraftNotCalculated = 2
* DraftNeedsApproval = 3
* DraftApproved = 4
* DraftNotApproved = 5
* Sent = 6
* Archived = 7
* Lost = 8
* Sold = 9

## Usage

* [QuoteVersion](../quoteversion.md).State - There may be multiple Versions of a Quote, with one of them active
* [QuoteVersion](../quoteversion.md).ArchivedState - There may be multiple Versions of a Quote, with one of them active
