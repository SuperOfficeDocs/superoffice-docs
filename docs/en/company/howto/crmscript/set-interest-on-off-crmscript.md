---
uid: crmscript-set-interests-on-off
title: Set interests
description: How to update interests with CRMScript.
author: Eivind Fasting
so.date: 04.12.2024
keywords: CRMScript, company, interests
so.topic: howto
---

# How to set an interest on or off for a contact (CRMScript)

You can search for an [interest][1] and then set the interest to true or false. Here, we use a CRMScript.

## Code

```crmscript
#setLanguageLevel 4;

Integer contactId = 6;
Integer interestToSelectId = 5;

NSContactAgent contactAgent;
NSContactEntity contactEntity = contactAgent.GetContactEntity(contactId);
NSSelectableMDOListItem[] contactInterests = contactEntity.GetInterests();

for (Integer i = 0; i < contactInterests.length(); i++)
{
  NSSelectableMDOListItem interestsOrHeadings = contactInterests[i];

  if (interestsOrHeadings.GetId() == interestToSelectId)
  {
    interestsOrHeadings.SetSelected(true);
    printLine("InterestId " + interestToSelectId.toString() + " with name: " + interestsOrHeadings.GetName() + " found on root level");
  }

  NSSelectableMDOListItem[] childItems = interestsOrHeadings.GetChildItems();
  for (Integer y = 0; y < childItems.length(); y++) 
  {
    if (childItems[y].GetId() == interestToSelectId)
    {
      childItems[y].SetSelected(true);
      printLine("InterestId " + interestToSelectId.toString() + " with name: " + childItems[y].GetName() + " found as a childInterest under heading: " + interestsOrHeadings.GetName());
    }
  }
  interestsOrHeadings.SetChildItems(childItems);
}

contactEntity.SetInterests(contactInterests);
contactEntity = contactAgent.SaveContactEntity(contactEntity);
```

## Walk-through

In SuperOffice you can define an interest both with and without an heading (an interest can also exists under multiple headings).
Each interest has its unique Id, which we in the example above use to set a specific interestId to true. This way it doesnt matter if you move an interest to a different heading, as the unique id stays consistent.

First of all we need to loop the NSSelectableMDOListItem[] we get back from the GetInterests() method:

```crmscript
NSContactAgent contactAgent;
NSContactEntity contactEntity = contactAgent.GetContactEntity(contactId);
NSSelectableMDOListItem[] contactInterests = contactEntity.GetInterests();
```

In this array we can have interests/items put on the root, without an heading, or we can get an item for the heading which then contains childitems for the actuall interests (nested).

This codeblock is what checks the root:

```crmscript
if (interestsOrHeadings.GetId() == interestToSelectId)
{
    interestsOrHeadings.SetSelected(true);
    printLine("InterestId " + interestToSelectId.toString() + " with name: " + interestsOrHeadings.GetName() + " found on root level");
}
```

While this codeblock gets the childitems for the item/heading and checks each one of the nested items:

```crmscript
 NSSelectableMDOListItem[] childItems = interestsOrHeadings.GetChildItems();
  for (Integer y = 0; y < childItems.length(); y++) 
  {
    if (childItems[y].GetId() == interestToSelectId)
    {
      childItems[y].SetSelected(true);
      printLine("InterestId " + interestToSelectId.toString() + " with name: " + childItems[y].GetName() + " found as a childInterest under heading: " + interestsOrHeadings.GetName());
    }
  }
  interestsOrHeadings.SetChildItems(childItems);
```

> [!NOTE]
> Notice that we also need to SetChildItems back into the interestOrHeadings array

## Reference

<!-- Referenced links -->
[1]: ../../interests.md
