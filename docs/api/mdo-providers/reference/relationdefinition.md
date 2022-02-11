---
uid: relationdefinition
title: relationdefinition
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "relationdefinition"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationdefinition" MDO List
The name of the MDO list is 'relationdefinition'.




## Sample Request

```http!
GET /api/v1/MDOList/relationdefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationdefinition", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|arbeidet før for|||
|1|eier|||
|2|er en personlig venn av|||
|6|er i familie med|||
|7|kjenner|||
|3|leier inn|||
|9|Link to document|||
|8|Link to follow-up|||
|10|Link to sale|||
|5|sitter i styret hos|||


## Related MDO Lists

* "relationdefinitionheadings"
* "relationdefinitionheadingswithallitem"
* "relationdefinitionheadingswithallitemwithnoselection"
* "relationdefinitionheadingswithnoselection"
* "relationdefinitionwithallitem"
* "relationdefinitionwithallitemwithnoselection"
* "relationdefinitionwithnoselection"
