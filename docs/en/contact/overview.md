---
uid: contact_overview
title: Working with persons
description: SuperOffice view of the world and working with persons.
author: Bergfrid Skaara Dias
so.date: 14.02.2021
so.topic: concept
keywords: person, contact
---

# Contact (person)

![Edit person dialog -screenshot][img1]

## SuperOffice view of the world

SuperOffice has five important things:

* **Companies** are in code and database references called *contact*.
* **Associates** are SuperOffice users - employees of the company.
* **Projects** are a type of activity that usually involves several stakeholders and various types of other activities.
* **Activities** are things employees do with companies, contacts, projects, the diary, and sales.
  * follow-ups
  * documents
  * mailings and form submissions
  * chat sessions
* **Tickets** from Service are linked to persons who may or may not belong to a company.

You can [read more about the main tables][1] in the developer documentation.

### Business rules

* Activities happen at a particular point in time.
* Sales are expected to be closed on a date in the future.
* Meetings are scheduled for a particular date and time.
* Documents are written on a specific day.
* Activities start on one day and finish on another.
* Time is important for activities.
* Companies and projects are not time-specific but are linked to activities in time.

The appointment table contains foreign keys to all the other important tables, plus a date field (ActiveDate).

### Context-sensitive labels

It is important to keep in mind that there's not a 1:1 mapping of labels and that you have to take context into account.

| Real-world term | UI label  | Database table | CRMScript class |
|-----------------|-----------|----------------|-----------------|
| company<br>organization | company | contact  | Company         |
| person          | contact<br>associate |     |                 |
| customer        | contact   | person         | Customer        |
| employee        | associate | associate      |                 |
| user account    | user      | ejuser         | User            |
| database owner  | tenant    | Company        |                 |

## Contact vs. other entities

* [company][10] (contact table)
* [documents][11]
* [follow-ups][12] (appointment table)
* [projects][13]
* [sales][14]

## API how-tos

* [CRMScript][4]
* [Web services][5]
* [Entities][6]
* [Rows][7]
* [Objectified SQL][8]
* [Raw SQL][9]

## More

* [Pictures are stored in the BLOB table][2]
* [Addresses][3]

<!-- Referenced links -->
[1]: ../database/getting-started/main-tables.md
[2]: blob-pictures.md
[3]: ../globalization-and-localization/address/index.md
[4]: howto/crmscript/index.md
[5]: howto/services/index.md
[6]: howto/entity/index.md
[7]: howto/row/index.md
[8]: howto/osql/index.md
[9]: howto/sql/index.md
[10]: ../company/index.yml
[11]: ../document/index.yml
[12]: ../diary/index.yml
[13]: ../project/index.yml
[14]: ../sale/index.yml

<!-- Referenced images -->
[img1]: ../../media/loc/en/contact/edit-person.png
