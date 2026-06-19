---
uid: selectionmembertype
title: selectionmembertype
keywords: mdoprovider mdo provider selectionmembertype
description: MDO provider for the selection archive providers types. The items will be added by scanning ArchiveProviderFactory.KnownArchiveProviders for this pattern; [TableName]Selection. If the prefix is a known table, the tablename will be added to list with the TableNumber as the ID.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectionmembertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|[SR_SELECTION_APPOINTMENTS]||appointment|
|5|[SR_SELECTION_COMPANIES]||contact|
|10|[SR_SELECTION_DOCUMENTS]||document|
|11|[SR_SELECTION_PROJECTS]||project|
|127|[SR_SELECTION_QUOTELINES]||quoteline|
|13|[SR_SELECTION_SALES]||sale|
|262|[SR_SELECTION_TICKETS]||ticket|


## Related MDO Lists

* "selectionmembertypeheadings"
* "selectionmembertypeheadingswithallitem"
* "selectionmembertypeheadingswithallitemwithnoselection"
* "selectionmembertypeheadingswithnoselection"
* "selectionmembertypewithallitem"
* "selectionmembertypewithallitemwithnoselection"
* "selectionmembertypewithnoselection"
