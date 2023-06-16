---
uid: enum-quoteversionstate
title: Enum values for QuoteVersionState
description: Lists the enum values for QuoteVersionState.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# QuoteVersionState Enum

State that this quote version had, right before it was changed to Archived; in this way we can show what happened before the archiving.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|State unknown|
|Draft|1|Draft that has been calculated, and ERP has verified it as OK|
|DraftNotCalculated|2|This is a draft that has not been calculated, prices and other attributes may be 'invalid' relative to ERP system rules|
|DraftNeedsApproval|3|Draft has been checked, and there was a problem that needs (human) approval|
|DraftApproved|4|Draft with potential problems has been human-approved|
|DraftNotApproved|5|Draft has been checked, there was a problem, and (human) approval was NOT granted|
|Sent|6|Sent to customer, and is now a legally binding document|
|Archived|7|Archived - previous state saved in ArchivedState, newer versions exist|
|Lost|8|Version was rejected be the customer - we lost the sale|
|Sold|9|Quote was accepted and the sale is 'Sold'|

## Usage

* [QuoteVersion](../quoteversion.md).State - There may be multiple Versions of a Quote, with one of them active
* [QuoteVersion](../quoteversion.md).ArchivedState - There may be multiple Versions of a Quote, with one of them active
