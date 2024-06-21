---
uid: crmscript-forms
title: Forms
description: Working with forms in CRMScript.
keywords: marketing, form, form action, submission
author: Bergfrid Skaara Dias, Christian Mogensen
date: 03.20.2024
version: 10
topic: howto
---

# Forms

Forms can be processed automatically, manually, or a combination of both. This is specified as [form actions][1].

A form can have multiple actions. One of them is **Execute CRMScript**. If selected, form fields are added as input data to the script set run when submissions of this form are processed (automatically or manually).

The `EventData` instance will contain several input values, where the key is the form field's label. If the form has company or contact fields, these trigger matching against the database, and the input values `contactId` and `personId` are available.

## Update company name with form value

```crmscript
EventData ed = getEventData();
Map m = ed.getInputValues();
String contactId = m.get("contactId");
String companyName = m.get("Company - Name");

NSContactAgent agent;
NSContactEntity contact = agent.GetContactEntity(contactId.toInteger());
contact.Name = companyName;
agent.SaveContactEntity(contact);
```

<!-- Referenced links -->
[1]: ../../../../marketing/forms/learn/define-form-actions.md
