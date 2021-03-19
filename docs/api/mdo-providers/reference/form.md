---
uid: form
title: form
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "form"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "form" MDO List
Get all forms with folder hierarchy. Set ExtraInfo to "onlyActive" if you only want to get active forms



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormProvider">FormProvider</see> class.
The name of the MDO list is 'form'.




## Sample Request

```http!
GET /api/v1/MDOList/form
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("form", forceFlatList: true);
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

* "formheadings"
* "formheadingswithallitem"
* "formheadingswithallitemwithnoselection"
* "formheadingswithnoselection"
* "formwithallitem"
* "formwithallitemwithnoselection"
* "formwithnoselection"
