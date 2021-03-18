---
uid: lists
title: lists
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "lists" MDO List
List provider for the Heading table. While this table looks like an MDO table,
it lacks the standardized grouplink and headinglink companion tables for good reason,
since it is the heading table itself.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ListsListProvider">ListsListProvider</see> class.
The name of the MDO list is 'lists'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted list items| showDeleted|true|
|Include an associate list item| includeAssociate|true|
|Only show user defined lists| onlyUserDefinedLists|false|





## Sample Request

```http!
GET /api/v1/MDOList/lists
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("lists", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|148|Chat Protocols|||
|163|Subscription - Type|||
|164|Privacy - Source|||
|165|Privacy - Legal basis|||
|166|Company - Category family|||
|97|Document - Template|||
|98|General - Resource|||
|152|Company - Category|||
|153|Company - Business|||
|101|General - User group|||
|102|General - Relation|||
|103|Follow-up - Type|||
|104|Follow-up - Priority|||
|154|Company - Interest|||
|155|Contact - Interest|||
|156|Contact - Position|||
|157|Contact - Mr/Mrs|||
|109|Project - Type, Stages|||
|110|Project - Status|||
|111|Project member - Function|||
|112|Selection - Type|||


## Related MDO Lists

* "listsheadings"
* "listsheadingswithallitem"
* "listsheadingswithallitemwithnoselection"
* "listsheadingswithnoselection"
* "listswithallitem"
* "listswithallitemwithnoselection"
* "listswithnoselection"
