---
uid: efd_13
title: efd_13
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

# "efd_13" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_13'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_13
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_13", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Red||Red|
|2|Green||Green|
|3|Blue||Blue|
|4|Purple||Purple|


## Related MDO Lists

* "efd_13headings"
* "efd_13headingswithallitem"
* "efd_13headingswithallitemwithnoselection"
* "efd_13headingswithnoselection"
* "efd_13withallitem"
* "efd_13withallitemwithnoselection"
* "efd_13withnoselection"
