---
uid: selectionmembertypev2
title: selectionmembertypev2
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

# "selectionmembertypev2" MDO List
MDO provider for the selection archive providers types.
The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern;
[TableName]Selection. If the prefix is a known table, the tablename will be added to list with the
TableNumber as the ID.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberTypeListV2">SelectionMemberTypeListV2</see> class.
The name of the MDO list is 'selectionmembertypev2'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmembertypev2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionmembertypev2", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Find Company||contact|
|6|Find Contact||person|
|9|Find Follow-up||appointment|
|13|Find Sale||sale|
|11|Find Project||project|
|23|Find Selection||selection|
|10|Find Document||document|
|127|Find Product||QuoteLine|
|262|Find Request||ticket|


## Related MDO Lists

* "selectionmembertypev2headings"
* "selectionmembertypev2headingswithallitem"
* "selectionmembertypev2headingswithallitemwithnoselection"
* "selectionmembertypev2headingswithnoselection"
* "selectionmembertypev2withallitem"
* "selectionmembertypev2withallitemwithnoselection"
* "selectionmembertypev2withnoselection"
