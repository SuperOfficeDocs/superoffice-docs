---
uid: crmscript_class_company
title: Company (class)
description: How to work with companies in CRMScript.
author: Bergfrid Skaara Dias
so.date: 02.21.2022
keywords: CRMScript, company, organization, contact
so.topic: howto
---

# Companies

## Company (class)

The [Company CRMScript class][1] represents the following entities:

* Real-life: a company or organization
* SuperOffice UI: company
* Database table: [contact][5]

> [!WARNING]
> The **company** database table is unrelated to the **Company** CRMScript class. The table should have one row only, containing information about licenses and the owner of the SuperOffice database.
>
> Changing the `company` table will make it **impossible to sign in** for all users. The only fix is to restore the database from backup.

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

See the **connected persons* table for a description of `ourContact` and `primaryContact`.

```crmscript!
Parser p;
Company c;
c.load(2);
c.toParser(p);
printLine(p.getVariable("company.name", 0));
```

> [!TIP]
> Read more about [localized addresses][3].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Company>
[2]: ../../../automation/crmscript/parser-and-templates/reply-template.md
[3]: ../../../globalization-and-localization/address/index.md
[5]: ../../../database/tables/contact.md
