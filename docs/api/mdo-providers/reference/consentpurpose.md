---
uid: consentpurpose
title: consentpurpose
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "consentpurpose"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "consentpurpose" MDO List
MDO list provider for ConsentPurpose



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ConsentPurposeProvider">ConsentPurposeProvider</see> class.
The name of the MDO list is 'consentpurpose'.




## Sample Request

```http!
GET /api/v1/MDOList/consentpurpose
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("consentpurpose", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Sales and service|||
|2|E-marketing|||


## Related MDO Lists

* "consentpurposeheadings"
* "consentpurposeheadingswithallitem"
* "consentpurposeheadingswithallitemwithnoselection"
* "consentpurposeheadingswithnoselection"
* "consentpurposewithallitem"
* "consentpurposewithallitemwithnoselection"
* "consentpurposewithnoselection"
