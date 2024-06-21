---
uid: crmscript-interest-company
title: Set/clear interest on company
description: How to update interests for a company with SuperOffice CRMScript.
keywords: CRMScript, company, interest, GetContactEntity, GetInterests, NSContactAgent, NSContactEntity, NSSelectableMDOListItem
author: Eivind Fasting
date: 04.12.2024
version: 10
topic: howto
---

# Set/clear interest on company

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

In SuperOffice, you can define an interest both with and without a heading (an interest can also exist under multiple headings). Each interest has its unique ID, which we in the example above used to set a specific interestId to true. It doesn't matter if you move an interest to a different heading, as the unique ID stays consistent.

First, we need to loop the `NSSelectableMDOListItem[]` we get back from the `GetInterests()` method:

```crmscript
NSContactAgent contactAgent;
NSContactEntity contactEntity = contactAgent.GetContactEntity(contactId);
NSSelectableMDOListItem[] contactInterests = contactEntity.GetInterests();
```

In this array, we can put interests/items on the root, without a heading, or we can get an item for the heading, which then contains child items for the actual interests (nested).

This code block checks the root:

```crmscript
if (interestsOrHeadings.GetId() == interestToSelectId)
{
  interestsOrHeadings.SetSelected(true);
  printLine("InterestId " + interestToSelectId.toString() + " with name: " + interestsOrHeadings.GetName() + " found on root level");
}
```

Here, we get the child items for the item/heading and check each of the nested items:

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
> We also need to `SetChildItems` back into the `interestOrHeadings` array.

<!-- Referenced links -->
[1]: index.md
