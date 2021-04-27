---
title: Update user-defined field
uid: update_udef_entity
description: How to update a user-defined field
author: {github-id}
so.date:
keywords: udefhelper
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to update a Udef field

The contact has a property named `UdefHelper`, which lets you handle user-defined fields easily.

You can assign or update the values on a user-defined field of a contact via the `UdefLarge` and `UdefSmall` properties. However, it requires you to work with the physical field names such as `string04` which give no meaning and can therefore be tricky. The `UdefHelper` shields the physical field names and lets you work with logical names instead.

## Code

```csharp
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a contact
  Contact contact = Contact.GetFromIdxContactId(37);

  // Update the Udef fields using udefHelper
  // You have to pass the progId which identifies the field to the udefHelper
  contact.UdefHelper["SuperOffice:1"] = "Value 1";
  contact.UdefHelper["SuperOffice:2"] = "Value 2";
  contact.UdefHelper["SuperOffice:3"] = 1234;

  //Save the changes
  contact.Save();
}
```

## Walk-through

In the above example, we refer to a particular user-defined field by using a string called **the progId**. It is stored under the `progId` field of the `udeffield` table. These values stay constant throughout the life of a field even if the name or the type of the field is changed.

If the `progId` is blank, we can assume it to be equal to *"SuperOffice:" + udeffield.identity* (For example, SuperOffice: 1).

**Identity** is a sequence number that is allocated whenever you create a new user-defined field. This is not an ID field, but it remains unchanged between different versions of the same user-defined fields. Just like progId, the identity field also remains a constant throughout the lifetime of a user-defined field.

The main purpose of the `progId` is to facilitate 3rd-party developers to make their fields with a name they can use in their code to find their user-defined fields again.
