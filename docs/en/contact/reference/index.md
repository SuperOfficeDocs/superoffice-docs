---
uid: contact-overview
title: Working with persons
description: SuperOffice view of the world and working with persons. The associate database table represents employees, resources, and other users - except for external persons.
keywords: person, contact, associate, blob
author: Bergfrid Skaara Dias
date: 10.25.2024
version: 10
topic: concept
---

# Contact (person)

![Edit person dialog -screenshot][img1]

## SuperOffice view of the world

SuperOffice has five important things:

* **Companies** are in code and database references called *contact*.
* **Associates** are SuperOffice users - employees of the company.
* **Projects** are a type of activity that usually involves several stakeholders and various types of other activities.
* **Activities** are things employees do with companies, contacts, projects, the diary, and sales.
  * Follow-ups
  * Documents
  * Mailings and form submissions
  * Chat sessions
* **Tickets** from Service are linked to persons who may or may not belong to a company.

You can [read more about the main tables][11] in the developer documentation.

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

| Real-world term | UI label | Database table | CRMScript class |
|---|---|---|---|
| company<br>organization | company | contact  | Company |
| person | contact<br>associate | | |
| customer | contact | person | Customer |
| employee | associate | associate | |
| user account | user | ejuser | User |
| database owner | tenant | Company | |

## <a id="associate"></a>Employees (internal)

The **associate** database table represents employees, resources, and other users - except for external persons.

Yet, this table is important for understanding and navigating the relationship between a person and their user account as well as the relationship between employees at the organization running the CRM system and the external parties they interact with.

You may think of associates as the missing link that connects people.

### Associate types

| Value | Type | Description |
|:-:|---|---|
| 0 | Employee | Internal person |
| 1 | Resource | Not a person<br>Disregard `personId` |
| 2 | Anonymous | Not authenticated for SuperOffice |
| 4 | ExternalPerson | External person<br>No calendar |
| 7 | Anonymous | Unknown<br>no person (1) + not authenticated (2) + no calendar (4) |
| 8 | NoSentry | Has full access rights<br>The Sentry mechanism is bypassed |
| 13 | System | System user<br>no person (1) + no calendar (4) + full access/bypass sentry (8) |

### Frequently used values

| Database field | Description |
|:--|:--|
| associate_id | ID (primary key) |
| person_id | The person |
| name | Initials, sign-in name, database user name |
| group_idx | Primary group membership |
| ejuserId | ID of the user account<br>0 if not connected to an account |

### Important timestamps

| Database field | Description |
|:--|:--|
| lastlogin | The last time the associate signed in |
| lastlogout | The last time the associate signed out |
| registered | When the associate was registered |
| updated | The last time the associate was updated |

### Resources

Resources are typically meeting rooms or equipment such as projectors.

| Database field | Description |
|:--|:--|
| isLocation | True if it represents a location |
| locationAddress | The address, if it's a location |

[Database reference][12]

### Associate list and cache

In NetServer when you have a session, the session cache will contain a special cache entry named the **associate cache**. There all the associates listed in the SuperOffice database can be accessed through the cache, which is much faster than retrieving the associates from the database.

The **associate list** is an MDO list type that you can retrieve from the database. It holds all the associates from the SuperOffice database.

[How to get associate list from cache][19]

## <a id="blob"></a>Person picture and BLOBs

Pictures are stored in the BLOB table. The BLOBs are linked to other records in the system using the [BinaryObjectLink table][14].

BLOBs are currently used for four things:

* Pictures on person records
* Pictures on project records
* Flags on country records
* Status monitor pictures

If you add a picture to a person, you must write the picture to the [BinaryObject table][13], and then write the corresponding `BinaryObjectLink` to link the BLOB with the person record.

Without the link record, the picture will not appear.

### BLOB samples

* [Get person image (REST)][21]
* [Update person image (REST)][22]
* [Display person image (ImageUtility)][23]
* [Display image from BLOB table (web services)][24]

## Related content

* [Company - overview][5] (contact table)
* [Documents - overview][1]
* [Follow-ups - overview][2] (appointment table)
* [Projects - overview][3]
* [Sales - overview][4]
* [Working with contacts in CRMScript][10]
* [Working with contacts in web NetServer services and REST][25]
* [Working with contacts at the data layer (entities)][26]
* [Working with contacts using rows][27]
* [Working with contacts in Objectified SQL][28]
* [Raw SQL queries][29]
* [Addresses][6]

<!-- Referenced links -->
[1]: ../../document/index.yml
[2]: ../../diary/index.yml
[3]: ../../project/index.yml
[4]: ../../sale/index.yml
[5]: ../../company/index.yml
[6]: ../../globalization-and-localization/address/index.md

[10]: ../../automation/crmscript/howto/contact/index.md
[11]: ../../database/getting-started/main-tables.md
[12]: ../../database/tables/associate.md
[13]: ../../database/tables/binaryobject.md
[14]: ../../database/tables/binaryobjectlink.md

[19]: ../../api/caching/associate-cache.md
[21]: ../../api/web-services/howto/contact/get-person-image-rest.md
[22]: ../../api/web-services/howto/contact/update-person-image-rest.md
[23]: ../../api/web-services/howto/contact/display-person-image-ws.md
[24]: ../../api/web-services/howto/contact/display-image-from-blob-table-services.md
[25]: ../../api/web-services/howto/contact/index.md
[26]: ../../api/entities/howto/contact/index.md
[27]: ../../api/rows/howto/contact/index.md
[28]: ../../api/osql/howto/contact/index.md
[29]: ../../api/sql/howto/contact/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/edit-person.png
