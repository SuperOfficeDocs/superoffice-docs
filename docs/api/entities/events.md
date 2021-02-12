---
# Mandatory fields.
title: entity_events       # (Required) Very important for SEO.
description: Events in Entity objects # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords: hook
so.topic: concept          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Events in Entity objects

Entities trigger two types of events:

* Events triggered when an Entity is saved to the database
* Events raised when related objects are collected for saving

When we are writing our code we can use these events to get callbacks.

## Example

The following example demonstrates how to callback these events.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.Data;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a Contact Entity
  Contact myContact = Contact.GetFromIdxContactId(12);

  //Adding Events
  myContact.OnElementSaved += new OnSaved(myContact_OnElementSaved);
  myContact.OnGetRelatedObjects += new GetRelatedObjects(myContact_OnGetRelatedObjects);
  myContact.Name = "Elan Hop";

  if (myContact.IsDirty)
  {
    //Events are triggered by this call
    myContact.Save();
  }
}
```

## Event handler

After selecting the required event, you can press **Tab** to have intellisense generate the event handler.

The following code shows the handler of the `OnElementSaved` event.

```csharp
voidmyContact_OnElementSaved(INestedPersist element, bool didSucceed)
{
  if (didSucceed)
  {
    MessageBox.Show("New changes are saved");
  }
}
```

If the save was successful, the `didSucceed` parameter is true. If some part of the transaction is failed, the transaction is rolled back, and the parameter is false.

The handler of `OnGetRelatedObjects` event.

```csharp
voidmyContact_OnGetRelatedObjects(List<INestedPersist> relatedObjects)
{
  int count = relatedObjects.Count;
  int j;
  for (j = 0; j <count ; j++)
  {
    MessageBox.Show(relatedObjects[j].ToString());
  }
}
```

In the above example, we have retrieved a `Contact` entity and then made some changes.

When this entity is saved, first the `OnGetRelatedObjects` event is fired. When the `Contact` entity is saved, there are several other objects related to this entity. All those objects are collected and when all related objects have been collected, this event is fired.

From this example, it is clear how certain actions are done in response to certain events. You can use the related-objects event to examine the data that is about to be saved in the related objects.
