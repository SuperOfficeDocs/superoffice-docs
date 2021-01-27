---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: putting_together_a_company       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Putting together a company # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Putting together a company

The company card uses the `Contact` table and its related tables:

![Company tables][img1]

> [!NOTE]
> There are multiple Person records for any contact. A classic many-to-one relationship.

* A Person can only belong to one Contact.
* A Contact can have zero or more Persons.

It is this relationship that drives the first to fields in the appointment, sale, and document dialogs. Every time you select a new company, the person list below it has to be re-populated.

## Address and Phone: owner-id and type

`Address` and `Phone` tables use two fields to determine where they belong: The `owner_id` field refers to a `contact_id` or a `person_id` depending on the `type_idx` field.

The `type_idx` is 1, 2, 16387, or 16388

```SQL
SELECT * FROM address WHERE owner_id < 10
```

![select-address][img2]

[Address][1]: `type_idx`

* 1 = Postal (contact)
* 2 = Street (contact)
* 16387 = Private (person)

[Phone][2]: `type_idx`

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

<!-- Referenced links -->
[1]: ../tables/address.md
[2]: ../tables/phone.md

<!-- Referenced images -->
[img1]: media/so-contact.gif
[img2]: media/select-address.gif
