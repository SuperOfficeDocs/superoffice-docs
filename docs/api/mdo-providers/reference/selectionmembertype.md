---
uid: selectionmembertype
title: selectionmembertype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectionmembertype"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectionmembertype" MDO List
MDO provider for the selection archive providers types.
The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern;
[TableName]Selection. If the prefix is a known table, the tablename will be added to list with the
TableNumber as the ID.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberTypeList">SelectionMemberTypeList</see> class.
The name of the MDO list is 'selectionmembertype'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmembertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionmembertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|127|Products||quoteline|
|11|Projects||project|
|262|Requests||ticket|
|13|Sales||sale|
|10|Documents||document|
|9|Follow-ups||appointment|
|5|Companies/Contacts||contact|


## Related MDO Lists

* "selectionmembertypeheadings"
* "selectionmembertypeheadingswithallitem"
* "selectionmembertypeheadingswithallitemwithnoselection"
* "selectionmembertypeheadingswithnoselection"
* "selectionmembertypewithallitem"
* "selectionmembertypewithallitemwithnoselection"
* "selectionmembertypewithnoselection"
