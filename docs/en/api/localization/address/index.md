---
uid: localization-address
title: Address formats
description: Localization, address formats
keywords: address, globalization, LocalizedAddress, FormattedAddress
author: Tony Yates
date: 10.09.2025
content_type: concept
category: localization
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: 
  - /en/globalization-and-localization/address/howto/index
  - /en/globalization-and-localization/address/index
language: en
index: true
---

# Address formats

Depending on where you live in the world, a company- or person address can come in various shapes and sizes. SuperOffice supports these various shapes and sizes using address format definitions for each country and region in the database.

## Introduction

Due to the dynamic nature of addresses, address fields in the SuperOffice CRM UI appear differently depending on the selected country for any particular company or person.

Below is an example of six different country formats and how they appear in SuperOffice CRM. It is interesting to note that while the top two are similar, the middle two are also similar but different from the first two. The bottom two are uniquely different from both each other and the other four.

![Address formats -screenshot][img1]

To support multiple address variants, SuperOffice address data structures must be generic, and an address type must be flexible enough to support all the various address formats of the world.

SuperOffice has accomplished supporting multiple country address formats by abstracting the address format from the address data and storing each separately in the database. At runtime, the address format is selected based on the company or contact county information.

## FormattedAddress (NetServer Core)

In NetServer core, the datatype used to express a single address format is `SuperOffice.CRM.Globalization.FormattedAddress` class.

![Localized Address][img2]

A `FormattedAddress` is a collection of `FormattedFields` data types, which contain one or more `IFormattedField` types. Each `IFormattedField` contains the actual address data, among others, three key properties: AddressType, Name, and Value.

## LocalizedAddress (web services)

In the SuperOffice web service API, all address fields are in a structure called `LocalizedAddress`.

![Localized Address][img3]

This is a multi-dimensional array of `LocalizedField`, where the first dimension contains each address line. The second dimension contains each field in that line. Each `LocalizedField` contains, among others, 3 key properties: AddressType, Name, and Value.

## NSLocalizedAddress (CRMScript)

All CRMScript address fields belong to a structure called `NSLocalizedAddress`.

![Localized address][img6]

This is a multi-dimensional array of `NSLocalizedField`:

* The 1st dimension contains each address line.
* The 2nd contains each field in that line.

## AddressType property

`AddressType` determines which type of address a field belongs to, of which there are 3 possibilities:

| Type | Belongs to | Description |
|:---|:---|---|
| ContactPostalAddress | company | a company's postal address |
| ContactStreetAddress | company | a company's physical or visiting address |
| PersonStreetAddress | person | a contact person address |

The first two types correspond to a company address, used to differentiate a company's postal address versus its' physical, or visiting, address. The third address type represents a contact person's address.

## Name and value properties

The `Name` and `Value` properties are just what they sound like. The name is a unique field keyname, and the value is populated with the value from the database.

### Pre-defined address field names

There are two separate groups of fields, one for person and one for company (contact).

| For person | For company    |
|------------|----------------|
| Address1   | PostalAddress1 |
| Address2   | PostalAddress2 |
| Address3   | PostalAddress3 |
| City       | PostalCity     |
| County     | PostalCounty   |
| State      | PostalState    |
| Zipcode    | PostalZipcode  |
|            | StreetAddress1 |
|            | StreetAddress2 |
|            | StreetAddress3 |
|            | StreetCity     |
|            | StreetCounty   |
|            | StreetState    |
|            | StreetZipcode  |

> [!TIP]
> The **Postal** and **Street** prefix reflect the address type (ContactPostalAddress or ContactStreetAddress).

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

[Address][3]: `type_idx`

* 1 = Postal (contact)
* 2 = Street (contact)
* 16387 = Private (person)

[Phone][4]: `type_idx`

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

## Example

For example, the address format of Norway defines 4 lines total. The first and third lines contain just one element, while the second and fourth lines contain two elements.

France, however, has 3 lines total, with the first and second lines containing just one field element and the third line containing two field elements.

<!-- markdownlint-disable MD051 -->
### [NetServer Core](#tab/fieldarray-1)

![Field array elements][img4]

### [Web services](#tab/fieldarray-2)

![Field array elements][img5]

### [CRMScript](#tab/fieldarray-3)

![Field array elements][img7]

***
<!-- markdownlint-restore -->

It is important to understand that some company addresses contain only a postal address while others contain both a postal and street address.

Because line elements are simply array containers, each field has an `AddressType` property that signals whether it pertains to a contact postal or street address, or a person's address.

So how does one go about reading and writing address information using this generic construct?

For NetServer Core, use the [AddressFormatter][1] class
For web services, use the [AddressHelper][2] class

## Available samples

| Task | Available examples |
|---|---|
| Get address | [CRMScript][11]; [web services][13] |
| Set address | [CRMScript][12]; [web services][14] |
| Prevent update | [SQL][15] |

## More

* [ERP Sync engine automatic field mapping][16]
* [Quote connector address provider][17]

<!-- Referenced links -->
[1]: addressformatter.md
[2]: addresshelper.md
[3]: ../../../database/tables/address.md
[4]: ../../../database/tables/phone.md

[11]: ../../../automation/crmscript/howto/address/get-address.md
[12]: ../../../automation/crmscript/howto/address/set-address.md
[13]: ../../web-services/howto/address/get-localized-address.md
[14]: ../../web-services/howto/address/set-localized-address.md
[15]: ../../security/sentry/sql/set-override-sql.md
[16]: ../../plugins/erp-connectors/automatic-field-mapping.md
[17]: ../../plugins/quote-connectors/addresses.md

<!-- Referenced images -->
[img1]: media/combinedaddresslayouts.png
[img2]: media/formattedaddress.png
[img3]: media/formattedfieldarray.png
[img4]: media/localizedaddress.png
[img5]: media/localizedfieldarray.png
[img6]: media/NSLocalizedAddress.png
[img7]: media/NSLocalizedFieldArray.png
