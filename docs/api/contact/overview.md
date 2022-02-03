---
title: Working with companies
description: The company card uses the contact table and its related tables. There are multiple person records for any contact.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
so.topic: concept
keywords: company, person, contact
---

# Contact

![Company card -screenshot][img2]

The company card uses the `contact` table and its related tables:

![Company tables diagram][img1]

> [!NOTE]
> There are multiple person records for any contact. A classic many-to-one relationship.

* A person can only belong to one contact.
* A contact can have zero or more persons.

It is this relationship that drives the first to fields in the appointment, sale, and document dialogs. Every time you select a new company, the person list below it has to be re-populated.

## Address and phone: owner-id and type

`Address` and `Phone` tables use two fields to determine where they belong: The `owner_id` field refers to a `contact_id` or a `person_id` depending on the `type_idx` field.

The `type_idx` is 1, 2, 16387, or 16388

```SQL
SELECT * FROM address WHERE owner_id < 10
```

| address_id | owner_id | atype_idx | zipcode | city | address1 |
|---|---|---|---|---|---|
| 1 | 1 | 1 | MK16 9PY | Milton Keynes | Suite 114 |
| 3 | 6 | 16387 | 0124 | Oslo | Postboks 1884 Vika |
| 4 | 7 | 16387 | 0167 | Oslo | Wergelandsveien 7 |
| 5 | 3 | 1 | 4770 | Høvåg | Grosøya |
| 6 | 3 | 2 | 0277 | Oslo | Drammensv 211 |
| 7 | 8 | 16387 | 0902 | Oslo | Postboks 131, Kalbakken |
| 8 | 9 | 16387 | 0902 | Oslo | Stålfjæra 27|
| 9 | 4 | 1 | 2016 | Frogner | Duevegen 1 |
| 10 | 4 | 2 | 2016 | Frogner | Trondheimsveien 350 |
| 12 | 5 | 1 | 2061 | Gardermoen | Postboks 150 |

(Result is cropped.)

[Address][11]: `type_idx`

* 1 = Postal (contact)
* 2 = Street (contact)
* 16387 = Private (person)

[Phone][10]: `type_idx`

* 1 = Phone (contact)
* 3 = Fax (contact),
* 16385 = Phone (person)
* 16387 = Fax (person)
* 16388 = Direct (person)
* 16389 = Mobile (person)

So – values of 16384 or above are related to the `person` table, while those below are related to the `contact` table.

So if you wanted to pick up just the fax numbers for contact 123 then your query would be:

```SQL
SELECT * FROM phone WHERE owner_id=123 AND type_idx=3 ORDER BY rank
```

> [!NOTE]
> These are many-to-one relationships, so you can still pick up more than one phone number per owner. Phone numbers are further sorted by rank. For addresses, this is a theoretical proposition. The CRM client will not define more than one address per type for each owner.

## Email and URL

To put together a list of the URLs and e-mails that belong to this contact:

```SQL
SELECT * FROM url WHERE contact_id = 123 ORDER BY rank

SELECT * FROM email WHERE contact_id = 123 ORDER BY rank
```

There may be several URLs all referencing the same `project_id`. This is OK. The URLs will be presented in rank order. The first rank will always be 1.

These are simpler relationships than the owner ID + type relations used on phone and address.

## Person list

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

## Create contacts

You can create a contact at multiple levels of NetServer:

* [Create a contact with raw SQL][9]
* [Create a contact entity][1]
* [Create a contact entity through an entity][2]
* [Create a contact entity through an entity collection][3]
* [Create a contact row][4]
* [Create a contact through row collection (Rows)][5]
* [Create a contact through OSQL][6]

## Get contact entity

You can get a `Contact` entity either by using the classes provided in the entities layer or by using the agents in the services layer.

* [Get a contact through Entities layer][7]
* [Get a contact through Services layer][8]

<!-- Referenced links -->
[1]: entity/create-contact-entity.md
[2]: entity/create-contact-entity-in-entity.md
[3]: entity/create-contact-entity-in-collection.md
[4]: row/create-contact-row.md
[5]: row/create-contact-rows.md
[6]: osql/create-contact-osql.md
[7]: entity/get-contact-via-entities-layer.md
[8]: services/get-contact-via-services-layer.md
[9]: sql/create-contact-sql.md
[10]: ../../../database/docs/tables/phone.md
[11]: ../../../database/docs/tables/address.md

<!-- Referenced images -->
[img1]: media/so-contact.gif
[img2]: media/company-card.png
