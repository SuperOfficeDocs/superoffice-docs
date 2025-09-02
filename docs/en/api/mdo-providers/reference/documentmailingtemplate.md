---
uid: documentmailingtemplate
title: documentmailingtemplate
keywords: mdoprovider mdo provider documentmailingtemplate
description: Document mailing templates
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documentmailingtemplate", forceFlatList: true);
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
