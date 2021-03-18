---
uid: contactphone
title: contactphone
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

# "contactphone" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactPhoneProvider">ContactPhoneProvider</see> class.
The name of the MDO list is 'contactphone'.




## Sample Request

```http!
GET /api/v1/MDOList/contactphone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contactphone", forceFlatList: true);
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

* "contactphoneheadings"
* "contactphoneheadingswithallitem"
* "contactphoneheadingswithallitemwithnoselection"
* "contactphoneheadingswithnoselection"
* "contactphonewithallitem"
* "contactphonewithallitemwithnoselection"
* "contactphonewithnoselection"
