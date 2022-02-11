---
uid: udlist
title: udlist
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "udlist"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "udlist" MDO List
MDO Provider for 'user-defined' lists, i.e., those that reside in the UDList table. Mandatory additionalInfo is the
udListId, which identifies the actual sublist. There is also a dynamic provider that will make a provider called
'udlist&lt;id&gt;, for instance udlist123, where the sublist id is part of the name. Nice if you are in a situation
where you can only get a list name and not the additionalInfo as a separate parameter.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UdListMDOProvider">UdListMDOProvider</see> class.
The name of the MDO list is 'udlist'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|UD List id| |1234|





## Sample Request

```http!
GET /api/v1/MDOList/udlist
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udlist", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "udlistheadings"
* "udlistheadingswithallitem"
* "udlistheadingswithallitemwithnoselection"
* "udlistheadingswithnoselection"
* "udlistwithallitem"
* "udlistwithallitemwithnoselection"
* "udlistwithnoselection"
