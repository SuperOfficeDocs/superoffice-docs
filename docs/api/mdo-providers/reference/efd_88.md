---
uid: efd_88
title: efd_88
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

# "efd_88" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_88'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_88
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_88", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Hamburger||Hamburger|
|2|Kebab||Kebab|
|3|Pølse||Pølse|
|4|Pølse med Lompe||Pølse med Lompe|
|5|Gulrøtter||Gulrøtter|


## Related MDO Lists

* "efd_88headings"
* "efd_88headingswithallitem"
* "efd_88headingswithallitemwithnoselection"
* "efd_88headingswithnoselection"
* "efd_88withallitem"
* "efd_88withallitemwithnoselection"
* "efd_88withnoselection"
