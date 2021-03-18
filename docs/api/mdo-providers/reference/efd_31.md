---
uid: efd_31
title: efd_31
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

# "efd_31" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_31'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_31
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_31", forceFlatList: true);
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
|5|Orange||Orange|
|6|Sparkles||Sparkles|
|7|Black||Black|
|8|White||White|
|9|Grey||Grey|


## Related MDO Lists

* "efd_31headings"
* "efd_31headingswithallitem"
* "efd_31headingswithallitemwithnoselection"
* "efd_31headingswithnoselection"
* "efd_31withallitem"
* "efd_31withallitemwithnoselection"
* "efd_31withnoselection"
