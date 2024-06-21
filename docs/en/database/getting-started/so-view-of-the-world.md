---
title: SuperOffice view of the world
uid: so_view_of_the_world
description: SuperOffice view of the world
author: {github-id}
keywords:
topic: concept
# envir:
# client:
---

# SuperOffice view of the world

SuperOffice has 5 important things:

* **Companies** in code and database references referred to as *contact*.
* **Associates** are SuperOffice users - employees of the company.
* **Projects** are a type of activity that usually involves several stakeholders and various types of other activities.
* **Activities** are things employees do with companies, contacts, projects, diary, and sales.
  * appointments of various task types
  * documents
  * mailings and form submissions
  * chat sessions
* **Tickets** from Service are linked to persons who may or may not belong to a company.

[Read more about the main tables][1]

## Business rules

* Activities happen at a particular point in time.
* Sales are expected to be closed on a date in the future.
* Appointments are scheduled for a particular date and time.
* Documents are written on a specific day.
* Activities start on one day and finish on another.
* Time is important for activities.
* Companies and projects are not time-specific, but linked to activities in time.

The appointment table contains foreign keys to all the other important tables, plus a date field (ActiveDate).

## Context-sensitive labels

| Real-world term | UI        | Database table |
|-----------------|-----------|----------------|
| company<br>organization | company | contact  |
| person          | contact<br>associate |     |
| customer        | contact   | person         |
| employee        | associate | associate      |
| user account    | user      | ejuser         |
| database owner  | tenant    | Company        |

<!-- Referenced links -->
[1]: main-tables.md
