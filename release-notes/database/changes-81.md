---
title: Changes in SuperOffice from 8.0 to 8.1
uid: changes_80_to_81
description: Changes in SuperOffice from 8.0 to 8.1
author: {github-id}
keywords: database
topic: reference
envir: onsite
version: 8.1
# client:
---

# Database

The new design is one of the major changes for SuperOffice 8.1.

## Dictionary changes

In SuperOffice 8.1, the dictionary has been changed. The new [CDD (Continuous Database Development)][1] dictionary allows partners and SuperOffice to add and modify tables without rebuilding the entire product.

## New tables

There are several changes in the 8.1 database.  Five new tables are added during the upgrade.

* There is a new table that will support a generic "favorite" (yellow star) functionality across clients.

* We have planned new functionality and there are 4 new tables created for this:
  * `Ticket_Type`
  * `Ticket_Relation_Type`
  * `Ticket_Relation_Action`
  * `Ticket_Relation`

  These tables support new functionality in Service, where you can define request types, relations between requests of certain types, and actions to be taken.

## New and changed fields on existing tables

We have also added new fields on several tables and increased field length on others.

Read more about changes in the database from [7.5 to 8.0][2].

<!-- Referenced links -->
[1]: ../../docs/en/database/dictionary/index.md
[2]: changes-75-80.md
