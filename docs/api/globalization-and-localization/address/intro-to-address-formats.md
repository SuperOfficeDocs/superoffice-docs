---
title: globalization_addressformatter
description: Localization, address formats
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
so.topic: concept
keywords:
---

# Address formats

Depending on where you live in the world, a company- or person address can come in various shapes and sizes. SuperOffice supports these various shapes and sizes using address format definitions for each country and region in the database.

## Introduction

Due to the dynamic nature of addresses, address fields in the SuperOffice CRM UI appear differently depending on the selected country for any particular company or person.

Below is an example of six different country formats and how they appear in SuperOffice CRM. It is interesting to note that while the top two are similar, the middle two are also similar but different from the first two. The bottom two are uniquely different from both each other and the other four.

![Address formats][img1]

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

## AddressType property

`AddressType` determines which type of address a field belongs to, of which there are 3 possibilities:

* ContactPostalAddress
* ContactStreetAddress
* PersonStreetAddress

The first two types correspond to a company address, used to differentiate a company's postal address versus its' physical, or visiting, address. The third address type represents a contact person's address.

## Name and value properties

The `Name` and `Value` properties are just what they sound like. The name is a unique field keyname, and the value is populated with the value from the database.

## Example

For example, the address format of Norway defines 4 lines total. The first and third lines contain just one element, while the second and fourth lines containing two elements.

France, however, has 3 lines total, with the first and second lines containing just one field element and the third line containing two field elements.

### [NetServer Core](#tab/fieldarray-1)

![Field array elements][img4]

### [Web services](#tab/fieldarray-2)

![Field array elements][img5]

***

It is important to understand that some company addresses contain only a postal address while others contain both a postal and street address.

Because line elements are simply array containers, each field has an `AddressType` property that signals whether it pertains to a contact postal or street address, or a person's address.

So how does one go about reading and writing address information using this generic construct?

For NetServer Core, use the [AddressFormatter][1] class
For web services, use the [AddressHelper][2] class

<!-- Referenced links -->
[1]: addressformatter.md
[2]: addresshelper.md

<!-- Referenced images -->
[img1]: media/combinedaddresslayouts.png
[img2]: media/formattedaddress.png
[img3]: media/formattedfieldarray.png
[img4]: media/localizedaddress.png
[img5]: media/localizedfieldarray.png
