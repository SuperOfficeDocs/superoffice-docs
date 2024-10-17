---
uid: crmscript-class-company
title: Company (class)
description: How to work with companies in CRMScript.
keywords: CRMScript, company, organization, contact
author: Bergfrid Skaara Dias
date: 02.21.2022
version: 10
topic: reference
---

# Working with companies in CRMScript

## Company (class)

The [Company CRMScript class][1] represents the following entities:

* Real-life: a company or organization
* SuperOffice UI: company
* Database table: [contact][4]

The **company** database table is unrelated to the **Company** CRMScript class. The table should have one row only, containing information about licenses and the owner of the SuperOffice database.

[!include[Don't change company table](../../../../includes/warn-company-table.md)]

## Parser variables

Calling `toParser()` will load the following fields and make them available to [templates][2]:

* company.id
* company.name
* company.note
* company.domain
* company.phone
* company.fax
* company.adr
* company.ourContact
* company.primaryContact.id
* company.primaryContact.email

See the [connected persons][5] table for a description of `ourContact` and `primaryContact`.

```crmscript!
Parser p;
Company c;
c.load(2);
c.toParser(p);
printLine(p.getVariable("company.name", 0));
```

> [!TIP]
> Read more about [localized addresses][3].

## How-to

* [Create company][6]
* [Get company][7]
* [Get activities][8]

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Company>
[2]: ../request/reply-templates.md
[3]: ../../../../globalization-and-localization/address/index.md
[4]: ../../../../database/tables/contact.md
[5]: create-company.md#connected-persons
[6]: create-company.md
[7]: get-company.md
[8]: get-activities.md
