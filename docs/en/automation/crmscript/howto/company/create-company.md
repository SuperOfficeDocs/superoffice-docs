---
uid: crmscript-create-company
title: Create and update companies
description: How to create and update companies with CRMScript.
keywords: CRMScript, company, organization, contact
author: Bergfrid Skaara Dias
date: 02.21.2022
version: 10
topic: howto
---

# Create and update companies

## Void setValue(String column, String value)

Sets a named field to the given value. Look up names in the [reference section down below](#reference), or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.
>
> You must call `save()` after setting all applicable values to actually create or update the company.

```crmscript
Company c;
c.setValue("name", "SuperOffice");
c.save();
```

## Integer save()

Saves a new or updated company and returns its ID.

```crmscript
Company c;
c.setValue("name", "SuperOffice");
c.setValue("domain", "superoffice.com");
printLine(c.save().toString());
```

## Reference

### Frequently used values

| Parameter | Database field | Description |
|:---|:---|:---|
| name | name | The name of the company |
| phone | phone | The company's phone number |
| domain | company_domain | A display-version of the company's domain |
| priority | ticket_priority | The ID of the default priority for this company.<br>NULL or -1 if not set. |
| language | cust_lang | The ID of the default customer language for this company.<br>NULL or -1 if not set. |

### Connected persons

| Parameter | Database field | Description |
|:---|:---|:---|
| ourContact | associate_id | The ID (`ejuser.id`) of the internal employee handling sale to this company |
| supportAssociateId | supportAssociateId | The ID (`ejuser.id`) or username of the internal employee handling support to this company |
| primContact | supportPerson | The ID (`customer.id`) of the primary contact in this company<br>the counterpart of supportAssociateId |

For a complete list of fields, see the [database reference][2].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Company.setValue(String,String)>
[2]: ../../../../database/tables/contact.md
