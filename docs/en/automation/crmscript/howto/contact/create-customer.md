---
uid: crmscript-create-customer
title: Create and update customers
description: How to create and update customers with CRMScript.
keywords: CRMScript, customer, person, contact
author: Bergfrid Skaara Dias
date: 15.02.2021
version: 10
topic: howto
---

# Create and update customers

## Void setValue(String field, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference][1].

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs.
>
> You must call `save()` after setting all applicable values to actually create or update the customer.

```crmscript
Customer c;
c.setValue("name", "John");
c.save();
```

## Void removeEmail(String email)

Removes the email address from the customer.

> [!NOTE]
> You must call `save()` to do the action.

```crmscript
Customer c;
c.load(4);
c.removeEmail(duplicate@superoffice.com");
c.save();
```

## Integer save()

Saves a new or updated customer and returns its ID.

* If the ID is set before calling `save()`, it's an update.
* If the ID is empty, it's a create.

```crmscript
Customer c;
c.setValue("firstname", "Sarah");
printLine(c.save().toString());
```

## Integer save(String p_gdprSourceKey)

A variant of `save()` that includes the source key for the *StoreAndProcess* consent. These keys can be found in the consent system.

## Reference

### Frequently used values

| Parameter | Db field | Description |
|:--|:--|:--|
| firstname     | firstname        | The first name of the person |
| lastname      | lastname         | The last name of the person |
| title         | title            | Title |
| person_number | person_number    | Alphanumeric ID |
| phone         | phone            | Phone number |
| username<br>password |           | For the external web |
| email         | Email            | 1 or more |
| company       | contact          | The ID of the related company |
| priority      | ticketPriorityId | The ID of the customer's priority |
| language      | cust_lang        | The ID of the default customer language for this company.<br>NULL or -1 if not set. |

### Connected persons

| Parameter | Db field | Description |
|:--|:--|:--|
| ourContact         | associate_id       | The ID (`ejuser.id`) or username of the internal employee handling sale to this company |
| supportAssociateId | supportAssociateId | The ID (`ejuser.id`) or username of the internal employee handling support to this company|

For a complete list of fields, see the [database reference][2].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Customer.setValue(String,String)>
[2]: ../../../../database/tables/person.md
