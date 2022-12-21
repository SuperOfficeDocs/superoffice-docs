---
title: Events in Row objects
uid: row_events
description: Events in Row objects
author: {github-id}
so.date: 11.05.2016
keywords: hook
so.topic: concept
# so.envir:
# so.client:
---

# Events in Row objects

Unlike Entity objects, Row objects have many events.

Here we are using `ContactRow` to demonstrate how events are called back from Row objects. `ContactRow` has about 30 events. For each change in the properties of `ContactRow`, an event is triggered. Therefore there is an event for each field in the `contact` table.

```csharp
using SuperOffice;
using SuperOffice.Data;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a Contact Row
  ContactRow myContactRow = ContactRow.GetFromIdxContactId(122);

  //Generating the events
  myContactRow.OnElementSaved += new OnSaved(myContactRow_OnElementSaved);

  //This is the name field change event
  myContactRow.OnNameChange += new OnFieldChange<string>(myContactRow_OnNameChange);

  //Change the name field
  //Field change event is triggered here
  myContactRow.Name = "Aeron Christopher";

  if (myContactRow.IsDirty)
  {
    // Element save event is triggered here
    myContactRow.Save();
  }
}
```

The syntax of calling events in Row objects is very [similar to that in Entity objects][1]. Thus just as in Entity objects we have retrieved a `ContactRow` with ID 122 and changed its `Name` property. This triggers the `OnNameChange` event. When these changes are saved, the `OnElementSaved` event is fired.

## Event handlers

```csharp
voidmyContactRow_OnNameChange(TableRowBase fieldOwner, string persistedValue, string currentValue, string newValue)
{
  MessageBox.Show("Name Field is changed");
}
```

```csharp
voidmyContactRow_OnElementSaved(INestedPersist element, bool didSucceed)
{
  if (didSucceed)
  {
    MessageBox.Show("Changes are saved");
  }
}
```

The content of this event handler is executed after the elements are saved. The rest of the events in the `ContactRow` work in the same manner.

<!-- Referenced links -->
[1]: ../entities/events.md
