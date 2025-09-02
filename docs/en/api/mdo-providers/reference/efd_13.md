---
uid: efd_13
title: efd_13
keywords: mdoprovider mdo provider efd_13
description: Extra fields dropdown lists. Contains list of string values defined on the extra_field. List names are 'EFD_123' where 123 is the extra field id.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("efd_13", forceFlatList: true);
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

