---
uid: salutation
title: salutation
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "salutation"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "salutation" MDO List

GenericMDOProvider reads MDO lists with default settings

Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'salutation'.

## Sample Request

```http!
GET /api/v1/MDOList/salutation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("salutation", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Bedriftsøkonom|||
|19|Diplomingeniør|||
|20|Diplomøkonom|||
|36|Ingeniør|||
|42|Siviløkonom|||

## Related MDO Lists

* "salutationheadings"
* "salutationheadingswithallitem"
* "salutationheadingswithallitemwithnoselection"
* "salutationheadingswithnoselection"
* "salutationwithallitem"
* "salutationwithallitemwithnoselection"
* "salutationwithnoselection"
