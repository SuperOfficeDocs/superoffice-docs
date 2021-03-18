---
uid: faqreplytemplate
title: faqreplytemplate
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

# "faqreplytemplate" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.FaqReplyTemplateProvider">FaqReplyTemplateProvider</see> class.
The name of the MDO list is 'faqreplytemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/faqreplytemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("faqreplytemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|FAQ|||
|-1|Reply templates|||
|-1|Quick replies|||


## Related MDO Lists

* "faqreplytemplateheadings"
* "faqreplytemplateheadingswithallitem"
* "faqreplytemplateheadingswithallitemwithnoselection"
* "faqreplytemplateheadingswithnoselection"
* "faqreplytemplatewithallitem"
* "faqreplytemplatewithallitemwithnoselection"
* "faqreplytemplatewithnoselection"
