---
uid: faqreplytemplate
title: faqreplytemplate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "faqreplytemplate"
so.generated: true
so.date: 01.23.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "faqreplytemplate" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.FaqReplyTemplateProvider">FaqReplyTemplateProvider</see> class.
The name of the MDO list is 'faqreplytemplate'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Which of the types should be included? Comma separated string with the following choices: faqEntries, replyTemplates, quickReplies. Empty will give everything| resultType||





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
| 2 | Example | | |


## Related MDO Lists

* "faqreplytemplateheadings"
* "faqreplytemplateheadingswithallitem"
* "faqreplytemplateheadingswithallitemwithnoselection"
* "faqreplytemplateheadingswithnoselection"
* "faqreplytemplatewithallitem"
* "faqreplytemplatewithallitemwithnoselection"
* "faqreplytemplatewithnoselection"
