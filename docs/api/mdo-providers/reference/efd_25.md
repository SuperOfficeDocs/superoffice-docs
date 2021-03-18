---
uid: efd_25
title: efd_25
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

# "efd_25" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_25'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_25
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_25", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Black||Black|
|2|White||White|
|3|Transparent||Transparent|


## Related MDO Lists

* "efd_25headings"
* "efd_25headingswithallitem"
* "efd_25headingswithallitemwithnoselection"
* "efd_25headingswithnoselection"
* "efd_25withallitem"
* "efd_25withallitemwithnoselection"
* "efd_25withnoselection"
