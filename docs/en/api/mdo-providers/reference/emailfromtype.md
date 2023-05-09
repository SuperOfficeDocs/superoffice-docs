---
uid: emailfromtype
title: emailfromtype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "emailfromtype"
so.generated: true
so.date: 05.09.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailfromtype" MDO List
MDO provider for the EmailFromType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailFromTypeProvider">EmailFromTypeProvider</see> class.
The name of the MDO list is 'emailfromtype'.




## Sample Request

```http!
GET /api/v1/MDOList/emailfromtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailfromtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Always use:|||
|1|Use our contact where specified, otherwise use:|||
|2|Use our support contact where specified, otherwise use:|||


## Related MDO Lists

* "emailfromtypeheadings"
* "emailfromtypeheadingswithallitem"
* "emailfromtypeheadingswithallitemwithnoselection"
* "emailfromtypeheadingswithnoselection"
* "emailfromtypewithallitem"
* "emailfromtypewithallitemwithnoselection"
* "emailfromtypewithnoselection"
