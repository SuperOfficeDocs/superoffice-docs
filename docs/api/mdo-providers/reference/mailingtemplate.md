---
uid: mailingtemplate
title: mailingtemplate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mailingtemplate"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mailingtemplate" MDO List
General mailing templates



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingTemplateProvider">MailingTemplateProvider</see> class.
The name of the MDO list is 'mailingtemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingtemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailingtemplate", forceFlatList: true);
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

* "mailingtemplateheadings"
* "mailingtemplateheadingswithallitem"
* "mailingtemplateheadingswithallitemwithnoselection"
* "mailingtemplateheadingswithnoselection"
* "mailingtemplatewithallitem"
* "mailingtemplatewithallitemwithnoselection"
* "mailingtemplatewithnoselection"
