---
title: crmscript-class-company
description: Company (class)
author:
so.date:
keywords:
so.topic:
---

# Company (class)

The **Company** CRMScript class represents the following entities:

* Real-life: a company or organization
* SuperOffice UI: company
* Database table: contact

> [!WARN]
> The **company** database table is unrelated to the **Company** CRMScript class. The table should have 1 row only, containing information about licenses and the owner of the SuperOffice database. Changing the **company** table will make it **impossible to sign in** for all users. The only fix is to restore the database from backup.

## Create and update companies

### Void setValue(String column, String value)

Sets a named field to the given value. Look up names in the reference section down below, or check out the [class reference](https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/EJScript-Classes-Company-setValue.htm).

> [!NOTE]
> Both parameters are strings! Remember to use quotes even for IDs. <br />
> You must call `save()` after setting all applicable values to actually create or update the company.

```crmscript
Company c;
c.setValue("name", "SuperOffice");
c.save();
```

### Integer save()

Saves a new or updated company and returns its ID.

```crmscript
Company c;
c.setValue("name", "SuperOffice");
c.setValue("domain", "superoffice.com");
printLine(c.save().toString());
```

## Get company info

You can access a company in 3 ways. Each will return **false** if the company is unknown.

### Bool load(Integer id)

Brings up the company with the given ID. This is always the 1st step when you want to do anything with an existing company.

```crmscript
Company c;
c.load(2);
```

### Bool loadFromAgentAndKey(Integer agent, String key)

Brings up the company owned by the agent and matching the external key.

> [!CAUTION]
> `loadFromAgentAndKey()`might overwrite existing values!

### Bool findFromDomain(String domain)

Brings up the company based on its domain.

```crmscript
Company c;
c.findFromDomain("superoffice.com");
```

### String getValue(String colName)

Fetches the value from a named field. Look up names in the reference section down below.

```crmscript!
Company c;
c.load(2);
print(c.getValue("name"));
```

## Security

Don't assume that a user has access to everything. It is good practice to look up access rights before revealing or altering company information.

### Bool checkTableRights(String tableRight)

`checkTableRights()` determines whether the current user has access to a company.

Access pertains to 1 of the following tasks:

* select
* update
* insert

```crmscript!
Company c;
c.load(2);

Bool b = c.checkTableRights("select");
printLine(b.toString());
```

### Bool checkFieldRights(String field, String fieldRight)

`checkFieldRights()` determines whether the current user has access to a field.

Access pertains to 1 of the following tasks:

* read
* write

```crmscript
Company c;
c.load(2);

Bool b = c.checkFieldRights("contact", "read");
print(b.toString());
```

## Parser variables

Calling `toParser()` will load the following fields and make them available to [templates](../parser-and-templates/reply-template.md):

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
> Read more about [localized addresses](./addresses.md).

## Activities

You can also use the [contact agent](../ns-agents-and-carriers.md) to check what's going on.

### GetMyActiveContacts

Here we get all activities that happened the last week for companies tied to the currently signed-in user.

You can filter by category and action type.

> [!TIP]
> Set the start time to a future date to get all activities since the last sign-in.

```crmscript!
NSContactAgent contactAgent;

DateTime start;
Integer[] categories; // ignore filter

NSContactActivity[] activities = contactAgent.GetMyActiveContacts(start.addDay(-7), categories, 63);

for (Integer i = 0; i < activities.length(); i++) {
  NSContactActivity a = activities[i];
  printLine("At " + a.GetActionTime().toString() + ", " + a.GetActivityPersonName() + " did something to " + a.GetName());
}
```

### NSContactSummary GetContactSummary(Integer contactId, Integer limit)

Get a summary of a company's recent activity.

```crmscript!
Integer contactId = 2;
NSContactAgent agent;

NSContactSummary summary = agent.GetContactSummary(contactId, -1);

NSActivitySummaryItem[] followups = summary.GetFollowups();

for (Integer i = 0; i < followups.length(); i++) {
  printLine(followups[i].GetDate().toString());
}
```

> [!TIP]
> You can explore other collections in the activity summary too.

## Reference

### Frequently used values

| Parameter    | Db field        | Description                               |
|:-------------|:----------------|:------------------------------------------|
| name         | name            | The name of the company                   |
| phone        | phone           | The company's phone number                |
| domain       | company_domain  | A display-version of the company's domain |
| priority     | ticket_priority | The ID of the default priority for this company.<br />NULL or -1 if not set. |
| language     | cust_lang       | The ID of the default customer language for this company.<br/>NULL or -1 if not set. |

### Connected persons

| Parameter          | Db field           | Description                                                       |
|:-------------------|:-------------------|:------------------------------------------------------------------|
| ourContact         | associate_id       | The ID (`ejuser.id`) of the internal employee handling sale to this company |
| supportAssociateId | supportAssociateId | The ID (`ejuser.id`) or username of the internal employee handling support to this company |
| primContact        | supportPerson      | The ID (`customer.id`) of the primary contact in this company<br/>the counterpart of supportAssociateId |

For a complete list of fields, see the [database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-contact.htm).

### Action types

| Value | Description        |
|:-----:|:-------------------|
| 1     | created            |
| 2     | updated            |
| 4     | new activity       |
| 8     | activity completed |
| 16    | person added       |
| 32    | person updated     |

> [!TIP]
> To request more than 1 action type, summarize the values. **63** means **include all**.
