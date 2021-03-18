---
uid: efd_6
title: efd_6
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

# "efd_6" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_6'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_6
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_6", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Volvo||Volvo|
|2|Saab||Saab|
|3|Chevrolet||Chevrolet|
|4|Ford||Ford|
|5|Cherry||Cherry|
|6|Nio||Nio|
|7|Tesla||Tesla|
|8|Subaru||Subaru|
|9|Toyota||Toyota|
|10|Honda||Honda|


## Related MDO Lists

* "efd_6headings"
* "efd_6headingswithallitem"
* "efd_6headingswithallitemwithnoselection"
* "efd_6headingswithnoselection"
* "efd_6withallitem"
* "efd_6withallitemwithnoselection"
* "efd_6withnoselection"
