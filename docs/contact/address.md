---
title: Address and phone
description: Address and phone; owner-id and type
author: Bergfrid Skaara Dias
so.date: 15.02.2021
so.topic: concept
keywords: address, company, person, contact
---

# Address and phone

Addresses are commonly formatted according to local conventions.

Due to the dynamic nature of addresses, address fields in the SuperOffice UI appear differently depending on the selected country for any particular [company][4] or [person][5].

## Address formats

## Owner-id and type

The `Address` and `Phone` tables use two fields to determine where they belong: The `owner_id` field refers to a `contact_id` or a `person_id` depending on the `type_idx` field.

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

<!-- Referenced links -->
[1]: ../database/tables/address.md
[2]: ../database/tables/phone.md
[3]: https://help.superoffice.com/Documentation/Help/EN/CRM/UserHelp/index.htm#t=StandardCRM%2Fchap03%2FAddress_formats_for_different_countries.htm
[4]: ../company/howto/crmscript/company.md
[5]: howto/crmscript/customer.md

<!-- Referenced images -->
