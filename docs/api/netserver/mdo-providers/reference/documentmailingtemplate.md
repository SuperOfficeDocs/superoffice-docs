---
uid: documentmailingtemplate
title: documentmailingtemplate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "documentmailingtemplate"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "documentmailingtemplate" MDO List
Document mailing templates



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentMailingTemplateProvider">DocumentMailingTemplateProvider</see> class.
The name of the MDO list is 'documentmailingtemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/documentmailingtemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("documentmailingtemplate", forceFlatList: true);
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

* "documentmailingtemplateheadings"
* "documentmailingtemplateheadingswithallitem"
* "documentmailingtemplateheadingswithallitemwithnoselection"
* "documentmailingtemplateheadingswithnoselection"
* "documentmailingtemplatewithallitem"
* "documentmailingtemplatewithallitemwithnoselection"
* "documentmailingtemplatewithnoselection"
