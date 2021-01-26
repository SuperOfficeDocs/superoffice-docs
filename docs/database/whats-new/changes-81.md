---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_80_to_81       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice from 8.0 to 8.1 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Database

New design is one of major changes for SuperOffice 8.1

## Dictionary changes

In SuperOffice 8.0, the dictionary has been changed. The new [CDD (Continuous Database Development)][1] dictionary allows partners and SuperOffice to add and modify tables without rebuilding the entire product.

## New user plans

We have introduced a new user plan. That will give our user an easier understanding of what the user plan is used for and a better use of the licenses. The new user plans are:

* Standard CRM
* Sales
* Marketing
* Service
* Complete  

## New tables

There are several changes in the 8.0 database.  Five new tables are added during the upgrade.

* There is a new table that will support a generic "favorite" (yellow star) functionality across clients.

* We have planned new functionality and there are 4 new tables created for this:
  * Ticket\_Type
  * Ticket\_Relation\_Type
  * Ticket\_Relation\_Action
  * Ticket\_Relation
  These tables support new functionality in Service, where you can define request types, relations between requests of certain types, and actions to be taken.

## New and changed fields on existing tables

We have also added new fields on several tables and increased field length on others.

Read more about changes in the database from [7.5 to 8.0][2].

<!-- Referenced links -->
[1]: ../dictionary/continuousdatabase.md
[2]: changes-75-80.md
