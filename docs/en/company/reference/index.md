---
uid: company-reference
title: Working with companies
description: The company card uses the contact table and its related tables. There are multiple person records for any contact.
keywords: company, person, contact, interest, contactinterest, ContInt
author: Bergfrid Skaara Dias
date: 10.22.2024
version: 10
topic: reference
audience: api
audience_tooltip: SuperOffice APIs and database
---

# Working with companies in API

![Company card -screenshot][img2]

**Companies** are in code and database references called *contact*. Use the context to determine whether *contact* denotes a real-life company or person. [Read more about the SuperOffice view of the world][31].

[!include[Don't change company table](../../includes/warn-company-table.md)]

## Company vs. other entities

The company card uses the [contact][1] table and its related tables:

![Company tables diagram][img1]

There are multiple `person` records for any `contact`. A classic many-to-one relationship.

* A **person** can only belong to one **contact**.
* A **contact** can have zero or more **persons**.

It is this relationship that drives the first to fields in the follow-up, sale, and document dialogs. Every time you select a new company, the person list below it has to be re-populated.

### Person list

To get the list of persons under a contact:

```SQL
SELECT * FROM person WHERE contact_id = 123 ORDER BY rank
```

## Rows and entities

A `ContactRow` refers to a row in the `contact` database table. Therefore, it consists of basic data types supported by SQL.

The `Rows` type consists of a collection of rows such as `ContactRows` type consists of a collection of `ContactRow` types.

The `ContactEntity` represents a business object. It contains a set of properties bundled up as a single unit representing a particular business object. Entities contain properties of different data types such as properties of basic data types like int, string, boolean, entities, entity arrays, EntityElement, and LocalizedField.

> [!NOTE]
> The `Person` property of the `ContactEntity` is a *read-only* `Person` item and not a `PersonEntity`.

### Get contact entity

You can get a `Contact` entity either by using the [classes provided in the entities layer][21] or by using the [agents in the services layer][13].

## Create contact

* [Create contact (REST)][11]
* [Create contact WebApi agents][12]

## Interests

![Interest tab on Contact card -screenshot][img3]

Interests are stored on contacts and persons - there are two separate sets of interests and a separate set of link tables.

![InterestLinkTable diagram][img4]

The link table ([contactinterest][3]) allows a single contact to have zero or more interests checked off.

The [ContInt][2] table is an **MDO table**, so interests can be grouped and organized under headings. The position under a heading does not matter to the linkage to a contact.

```SQL
SELECT * FROM contint
```

| ContInt_id | name | rank | tooltip | deleted | registered | registered_associate_id |
|---|---|---|---|---|---|---|
| 854 | Hansa | 136 | Hansa | 0 | 28.10.2021 13.14:59 | 94 |
| 855 | IFS | 137 | IFS | 0 | 28.10.2021 13.18:17 | 94 |
| 856 | Agresso | 133 | Agresso | 0 | 28.10.2021 13.19:23 | 94 |
| 857 | AS400 | 134 | AS400 | 0 | 28.10.2021 13.20:22 | 94 |

```SQL
SELECT * FROM contactinterest
```

| contactinterest_id | contact_id | cinterest_idx | startDate | endDate | flags | registered |
|---|---|---|---|---|---|---|
| 53459 | 1 | 594 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 53640 | 1 | 1569 | | 31.12.2021 02:13:49 | 0 | 28.10.2021 13.14:59 |
| 45770 | 4 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |
| 45259 | 9 | 965 | | 31.12.2021 02:13:49| 0 | 28.10.2021 13.14:59 |

You can extend the list of interests for a contact by creating and adding a new interest to that list.

### Contact cached value

The `contact` table has a counter field that stores the number of active interests. This field is used to cache the count. It is updated whenever the user edits the company. The field is used to quickly check whether the interests tab needs to indicate the presence of interests or not.

### Interest code examples

* [List interests - services][16]
* [Set interest on/off - services][17]
* [ContInt MDO provider][4]

## Email and URL

To put together a list of the URLs and emails that belong to a contact:

```SQL
SELECT * FROM url WHERE contact_id = 123 ORDER BY rank

SELECT * FROM email WHERE contact_id = 123 ORDER BY rank
```

There may be several URLs all referencing the same `project_id`. This is OK. The URLs will be presented in rank order. The first rank will always be 1.

These are simpler relationships than the owner ID + type relations used on phone and address.

## CategoryList

The category list is used to classify a contact. The `Contact.Category_id` refers to an item on this list.

There are several methods of getting a category list:

* [ListAgent][14]
* [MDOAgent][15]

> [!NOTE]
> All list objects in the NetServer services API have a common interface. They can be accessed or modified using a ListAgent or an MDOAgent. The MDO agent provides a generic mechanism for reading lists. The List agent provides a strongly types API that is simpler to program with.

Explore the options and select the most appropriate method for your application. Consider using the [CategoryCache][29].

## Related content

* [Associates][33]
* [Contacts - overview][5] (person table)
* [Documents - overview][6]
* [Follow-ups - overview][7] (appointment table)
* [Projects - overview][8]
* [Sales - overview][9]
* [Address and phone: owner-id and type][30]
* [Working with companies in CRMScript][32]
* [Working with companies in web NetServer services and REST][10]
* [Working with companies at the data layer (entities)][20]
* [Working with companies using rows][25]
* [Working with companies in Objectified SQL][26]
* [Raw SQL queries][27]

<!-- Referenced links -->
[1]: ../../database/tables/contact.md
[2]: ../../database/tables/contint.md
[3]: ../../database/tables/contactinterest.md
[4]: ../../api/mdo-providers/reference/ContInt.md

[5]: ../../contact/index.yml
[6]: ../../document/index.yml
[7]: ../../diary/index.yml
[8]: ../../project/index.yml
[9]: ../../sale/index.yml

[10]: ../../api/web-services/howto/company/index.md
[11]: ../../api/web-services/howto/company/create-contact-rest.md
[12]: ../../api/web-services/howto/company/create-contact-webapi-agents.md
[13]: ../../api/web-services/howto/company/get-contact-via-services-layer.md
[14]: ../../api/web-services/howto/company/get-catlist-listagent.md
[15]: ../../api/web-services/howto/company/get-catlist-mdoagent.md
[16]: ../../api/web-services/howto/company/get-interests-for-contact-services.md
[17]: ../../api/web-services/howto/company/set-interest-on-off-services.md

[20]: ../../api/entities/howto/company/index.md
[21]: ../../api/entities/howto/company/get-contact-via-entities-layer.md
[25]: ../../api/rows/howto/company/index.md
[26]: ../../api/osql/howto/company/index.md
[27]: ../../api/sql/howto/company/index.md

[29]: ../../api/caching/category-cache.md

[30]: ../../globalization-and-localization/address/index.md
[31]: ../../automation/crmscript/overview/index.md
[32]: ../../automation/crmscript/howto/company/index.md
[33]: ../../contact/reference/index.md#associate

<!-- Referenced images -->
[img1]: media/so-contact.gif
[img2]: media/company-card.png
[img3]: media/contact-interests.png
[img4]: media/interestlink-table.png
