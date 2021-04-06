---
uid: crmscript_udef_tutorial
title: User-defined fields
author:
so.date:
keywords: udefagent,crmscript
so.topic: tutorial
---

# NSUserDefinedFieldInfoAgent

In this sample, we are looking up UDEF fields on a person, and we want to know metadata about those fields, such as the type and tooltip.

1. Retrieve the metadata for UDEFs on persons.
2. Use this when we look up the UDEF fields on a person entity.

## Code

```crmscript!
NSUserDefinedFieldInfoAgent udefAgent;

NSUserDefinedFieldInfo[] udefInfoList = udefAgent.GetUserDefinedFieldList(8);

Map udefIndex;

for (Integer c = 0; c < udefInfoList.length(); c++)
  udefIndex.insert(udefInfoList[c].GetProgId(), c.toString());

Integer personId = 123;

NSPersonAgent personAgent;

NSPersonEntity person = personAgent.GetPersonEntity(personId);

Map personUdefs = person.GetUserDefinedFields();

for (personUdefs.first(); !personUdefs.eof(); personUdefs.next())
{
  NSUserDefinedFieldInfo udefInfo = udefInfoList[udefIndex.get(personUdefs.getKey()).toInteger()];

  Integer type = udefInfo.GetFieldType();
  String tooltip = udefInfo.GetTooltip();
  Integer length = udefInfo.GetTextLength();
}
```

## Walk-through

We use `NSUserDefinedFieldInfoAgent.GetUserDefinedFieldList` to get the field list.

* Contact = 7
* Person = 8
* Project = 9
* Sale = 10
* Appointment = 12
* Document = 13

Since we get the udef progid from the person entity, we put it in a map so we can easily look up the index from a progid like this:

```crmscript
udefInfoList[udefIndex.get(the progid).toInteger()]
```

The progid is the key, the field value is the value.

**Field types:**

* 0 = leadtext only
* 1 = Edit
* 2 = CheckBox
* 3 = dropdown
* 4 = listbox
