---
title: superoffice_crm_globalization 
description: SuperOffice.CRM.Globalization namespace
author: {github-id}             # Your GitHub alias.
so.date: 04.08.2018
so.topic: reference
keywords:
---

# SuperOffice.CRM.Globalization namespace

The classes in this namespace act as helper classes for formatting different types of data to localized standards.

## AddressData

This class acts as a facade for the address row of the address table. This facade will enable the `AddressFormatter` class to access the address row in the table.

## AddressFormat

This class will interpret the address format table for us. This class will have all the fields of the tale as properties so by filling them we are filling the address formatter table. By using this class we can make our own address format and use it to formatting of our address.

## AddressFormatter

This class will [format an address of a contact or a person][1] for us. This class exposes two important methods that are dedicated to formatting the address of a person and an address of a contact.

## ContactNameFormatter

This class implements methods that will enable us to format the name of a contact depending on a given culture.

## CultureDataFormatter

This is a helper class designed to [encode, parse and reformat culturally sensitive data types][2] between an application server without culture knowledge, and a front-end with such knowledge. The problem that we face is for example if we want to show some culture data as a tooltip in the frontend, so when the server process the data to be shown it does not know the culture of the frontend.

This class implements methods that can be used in a situation like this and format the culture data for us before showing them on the frontend.

## PersonNameFormatter

This class is a helper class that implements methods to [format the names of a person to a given culture][3].

## PhoneFormatter

This class is a helper class that will serve the purpose of [formatting the phone number of a contact or a person][4] to a given culture.

<!-- Referenced links -->
[1]: addressformatter.md
[2]: culturedataformatter.md
[3]: personnameformatter.md
[4]: phoneformatter.md
