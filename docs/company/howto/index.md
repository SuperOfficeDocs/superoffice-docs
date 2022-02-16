---
title: Working with companies
description: The company card uses the contact table and its related tables. There are multiple person records for any contact.
author: Bergfrid Skaara Dias
so.date: 11.02.2021
so.topic: concept
keywords: company, person, contact
---

# Contact

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

## More

* [Address and phone: owner-id and type][10]

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
[10]: ../../globalization-and-localization/address/index.md

<!-- Referenced images -->
