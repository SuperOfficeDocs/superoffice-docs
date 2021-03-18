---
uid: efd_66
title: efd_66
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

# "efd_66" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_66'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_66
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_66", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Elf||Elf|
|2|Dwarf||Dwarf|
|3|Human||Human|
|4|Orc||Orc|
|5|Goblin||Goblin|


## Related MDO Lists

* "efd_66headings"
* "efd_66headingswithallitem"
* "efd_66headingswithallitemwithnoselection"
* "efd_66headingswithnoselection"
* "efd_66withallitem"
* "efd_66withallitemwithnoselection"
* "efd_66withnoselection"
