---
uid: crmscript_class_customer
title: Customer (class)
description: The CRMScript customer class and how to create and update customers; get customer info; look up customers; list interests for a person
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: CRMScript, customer, person, contact
so.topic: concept
---

# Customer (class)

The **Customer** CRMScript class represents the following entities:

* Real-life: a customer (person) that may or may not work for a company or organization
* SuperOffice UI: contact
* Database table: person

> [!NOTE]
> All associates (internal employees) have a corresponding person record.

## Create and update customers

### Void setValue(String field, String value)

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

### Void removeEmail(String email)

Removes the email address from the customer.

> [!NOTE]
> You must call `save()` to do the action.

```crmscript
Customer c;
c.load(4);
c.removeEmail(duplicate@superoffice.com");
c.save();
```

### Integer save()

Saves a new or updated customer and returns its ID.

* If the ID is set before calling `save()`, it's an update.
* If the ID is empty, it's a create.

```crmscript
Customer c;
c.setValue("firstname", "Sarah");
printLine(c.save().toString());
```

### Integer save(String p_gdprSourceKey)

A variant of `save()` that includes the source key for the *StoreAndProcess* consent. These keys can be found in the consent system.

## Get customer info

### Bool load(Integer id)

Brings up the customer with the given ID. This is always the 1st step when you want to do anything with an existing customer.

```crmscript
Customer c;
c.load(2);
```

### Bool loadFromAgentAndKey(Integer agent, String key)

Brings up the customer that is owned by the agent and matches the external key.

> [!CAUTION]
> `loadFromAgentAndKey()` might overwrite existing values!

### String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
Customer c;
c.load(7);
print(c.getValue("firstname"));
```

## Look up customers

### Bool findFromEmail(String email)

Looks up a customer in the primary database based on an email address.

```crmscript
Customer c;
printLine(c.findFromEmail("jean-luc@superoffice.com").toString());
```

### Bool findExternallyFromEmail(String email)

Same as `findFromEmail()`, but looks in external data sources.

### Bool findExternallyFromEmail(String email, Integer extTable)

A variant of `findExternallyFromEmail()` that limits the look-up to 1 specific source.

### Bool findFromCellphone(String cellphone)

Looks up a customer in the primary database based on a cellphone number.

```crmscript
Customer c;
printLine(c.findFromCellphone("12345678").toString());
```

### Integer findExternallyFromKey(Integer table, String key)

Looks up a customer in an external data source (`ext_table.id`) based on its primary key.

* If a match is found in the local proxy, the customer is loaded.
* Otherwise, if a match is found externally, a proxy is created and saved.

### Integer findFromAgentAndKey(Integer agent, String key)

Looks up a customer that is owned by the agent and matches the external key.

Returns the ID of the customer from the database, or -1 if not found.

## Security

Don't assume that a user has access to everything. It is good practice to look up access rights before revealing or altering information about a person.

### Bool checkTableRights(String tableRight)

`checkTableRights()` determines whether the current user has access to a customer (person).

Access pertains to 1 of the following tasks:

* select
* update
* insert

```crmscript!
Customer c;
c.load(5);

Bool b = c.checkTableRights("select");
printLine(b.toString());
```

### Bool checkFieldRights(String field, String fieldRight)

checkFieldRights()` determines whether the current user has access to a field.

Access pertains to 1 of the following tasks:

* read
* write

```crmscript
Customer c;
c.load(5);

Bool b = c.checkFieldRights("person", "read");
print(b.toString());
```

## User experience

### String makeSalutation()

`makeSalutation()` creates a greeting appropriate for the customer. The string can be used at the beginning of a document or email.

```crmscript!
Customer c;
c.load(3);
printLine(c.makeSalutation());
```

### Void login()

Creates a valid session for the current customer.

To get the session key created by `login()`, call `getValue("loginSessionKey")`.

```crmscript!
Customer c;
c.load(7);
c.login();
printLine(c.getValue("loginSessionKey"));
c.logout();
```

### Void logout()

Logs out a customer.

## Parser variables

Calling `toParser()` will load fields, prefix them with *customer*, and make them available to [templates][2].

> [!NOTE]
> Repeated calls will overwrite rather than append the values in the Parser instance.

```crmscript!
Parser p;
Customer c;
c.load(4);
c.toParser(p);
printLine(p.getVariable("customer.name", 0));
```

## List interests for a person

```crmscript!
Void viewPersonInterests(Integer personId) {
  NSPersonAgent personAgent;
  NSPersonEntity p = personAgent.GetPersonEntity(personId);

  NSSelectableMDOListItem[] interests = p.GetInterests();

  for (Integer i = 0; i < interests.length(); i++) {
    printLine(interests[i].GetName());
  }
}

viewPersonInterests(5);
```

> [!TIP]
> To print only the selected interests, add a condition: `if (interests[i].GetSelected())`.

## Reference

### Frequently used values

| Parameter     | Db field         | Description                       |
|:--------------|:-----------------|:----------------------------------|
| firstname     | firstname        | The first name of the person      |
| lastname      | lastname         | The last name of the person       |
| title         | title            | Title                             |
| person_number | person_number    | Alphanumeric ID                   |
| phone         | phone            | Phone number                      |
| username<br>password |          | For the external web.             |
| email         | Email            | 1 or more                         |
| company       | contact          | The ID of the related company     |
| priority      | ticketPriorityId | The ID of the customer's priority |
| language      | cust_lang        | The ID of the default customer language for this company.<br>NULL or -1 if not set. |

### Connected persons

| Parameter          | Db field           | Description                                                       |
|:-------------------|:-------------------|:------------------------------------------------------------------|
| ourContact         | associate_id       | The ID (`ejuser.id`) or username of the internal employee handling sale to this company |
| supportAssociateId | supportAssociateId | The ID (`ejuser.id`) or username of the internal employee handling support to this company|

For a complete list of fields, see the [database reference][3].

<!-- Referenced links -->
[1]: <xref:CRMScript.Native.Customer.setValue(String,String)>
[2]: ../parser-and-templates/reply-template.md
[3]: ../../../database/docs/tables/person.md
