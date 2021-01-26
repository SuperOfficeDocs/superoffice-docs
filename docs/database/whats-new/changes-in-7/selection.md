---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_selection       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Selection # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Selection of anything

Database changes:

* changes to the `selectionmember` table
  * added `targetTableId` and `targetRecordId*`, so it can point to anything;
* new fields in `selection` table:
  * `targetTableNumber`, `done`, `combinationtype`, `leftSelectionid`, `rightSelectionId` so you may combine selections

Different types of selections

* Companies/Contacts
* Sales
* Project
* Follow-ups
* Documents
  * Tasks depending on type and selection
  * Categories of selections
  * Both dynamic and static
  * Always a contact archive
  * Group edit
  * Navigate selection

* Work efficient with collections of different entities
* "Transforming selections"
* Closer connection between search and selections
* Use selections as an overview and grouping of activities etc
* Power features on groups of entities
