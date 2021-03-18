---
uid: efd_44
title: efd_44
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

# "efd_44" MDO List
Extra fields dropdown lists. Contains list of string values defined on the extra_field.
List names are 'EFD_123' where 123 is the extra field id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraFieldsDropdownProvider">ExtraFieldsDropdownProvider</see> class.
The name of the MDO list is 'efd_44'.




## Sample Request

```http!
GET /api/v1/MDOList/efd_44
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("efd_44", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Pink||Pink|
|2|Orange||Orange|
|3|Yellow||Yellow|
|4|Polkadot||Polkadot|


## Related MDO Lists

* "efd_44headings"
* "efd_44headingswithallitem"
* "efd_44headingswithallitemwithnoselection"
* "efd_44headingswithnoselection"
* "efd_44withallitem"
* "efd_44withallitemwithnoselection"
* "efd_44withnoselection"
