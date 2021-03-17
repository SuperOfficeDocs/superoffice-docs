---
title: changes_in_7       
description: What's new in the SuperOffice 7 database
author: {github-id}             # Your GitHub alias.
keywords:
---

# What's new in the SuperOffice 7 database

SuperOffice 7 introduced a lot of changes to the database as we merged CS and SM features.

## Longer fields

* Contact name & department are extended to 220
* Project.name, selection.name, document.header
* Address fields  \[80\]
* Phone number - The search algorithm has been changed to handle arbitrarily long numbers, with more-or-less the same results. There is no practical limit to the phone number length anymore.
* Userpreference section, key, value -
  * preference values are now 2k, so the old hack that put long values into the text table is gone. Existing rows are converted during upgrade.
* URL is no longer split into two fields, there is just one, 1k long field; that should be enough

We now use nvarchar(max) instead of text as our large-string datatype. This is more efficient and functionally much more compatible and capable datatype.

This will not make the database bigger unless the new space is actually used. SQL Server has a mechanism to put long strings into out-of-record pages so the max record limit is waived.

**We have extended just about all fields that needed or looked like they might need it. Further extensions are still possible between alpha and beta; after that – finito.**

SQL Server has a little-publicized limitation: Index nodes cannot be more than 900 bytes (even in 2008)
A unicode string consumes 2 bytes/char

A multi-field index creates nodes from the sum of all fields

And – so – if name + department (which have a combined index) become more than 900 bytes of actual content, save fails
For the most popular field combinations, we have limited the size; and it does not happen on Oracle.
If you introduce new combined indexes as part of some optimization, bear this in mind. The 900-byte limit is there.

## Obsolete fields and tables

We had multiple obsolete tables that have either become obsolete or that were designed but never taken into use.
There were also some obsolete fields, which have been removed. This changes the field IDs (we had to change reporter priming data) but has no other ill consequences.

The obsolete tables have been replaced by new tables, as far as possible (there were more obsolete tables than new tables in SuperOffice 7). The remainders are single-field tables in the dictionary, but they are not physically created in the database. This keeps the table numbers unchanged

Keeping the table numbers unchanged is important to avoid breaking or remapping relations.

From 7.5 on, we won’t add tables or fields until we know for sure that we need them, what you see in the database is all in use.

## Sales management

Database change:

## several new lists

(MDO lists with grouplink and headinglink tables)

* [SaleTypeCat][1]
* [SaleType][2]
* [ReasonStalled][3]
* [ReasonSold][4]
* [SaleStakeholder][5]
* [SaleTypeStageLink][6]
* [StakeholderRole][7]

## New tables for suggested document/appointment

* [SuggestedAppointment][8]
* [SuggestedDocument][9]

## New fields in Sale/SaleHist

* `saleType_id`
* `postitText_id`
* `reasonStalled_id`
* `reopenDate`
* `nextDueDate`
* `nddAppointment_id`
* `reasonSold_id`
* `saleTypeCat_id`

The motivation behind this is:

* Make a workplace for the sales rep. that really helps him
* Flexible enough for most sales situations
* Collect the right data for analyzing and drilling to enable accurate forecast and the right coaching

Done by:

* Lifting Sale as a main panel, like contact, project, selection, and so on
* Introduce type/category of sale opportunities
* Each type of sale may have different sales processes

## Selection of anything

Database changes:

* changes to the `selectionmember` table
  * added `targetTableId` and `targetRecordId*`, so it can point to anything

* new fields in `selection` table:
  * `targetTableNumber`, `done`, `combinationtype`, `leftSelectionid`, `rightSelectionId` so you may combine selections

## Customer Service

Service (formerly known as Customer Service or eJournal) was merged into the database with SuperOffice version 7.0
DB integration is gone; you can edit contact and person records in each system and directly see the changes in the other
eJournal can insert person records with `contact_id` = 0; these are invisible in CRM

A Customer Service user is an associate but has an extra record in the table ejuser`.

<!-- Referenced links -->
[1]: ../tables/saletypecat.md
[2]: ../tables/saletype.md
[3]: ../tables/reasonstalled.md
[4]: ../tables/reasonsold.md
[5]: ../tables/salestakeholder.md
[6]: ../tables/saletypestagelink.md
[7]: ../tables/stakeholderrole.md
[8]: ../tables/suggestedappointment.md
[9]: ../tables/suggesteddocument.md
