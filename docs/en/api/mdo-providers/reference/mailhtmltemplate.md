---
uid: mailhtmltemplate
title: mailhtmltemplate
keywords: mdoprovider mdo provider mailhtmltemplate
description: List provider for the Mailtemplates.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "mailhtmltemplate" MDO List
List provider for the Mailtemplates.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailHtmlTemplateProvider">MailHtmlTemplateProvider</see> class.
The name of the MDO list is 'mailhtmltemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/mailhtmltemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailhtmltemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|6|E-post|||
|23|Cancelled meeting|||
|22|Changed meeting|||
|21|New meeting|||


## Related MDO Lists

* "mailhtmltemplateheadings"
* "mailhtmltemplateheadingswithallitem"
* "mailhtmltemplateheadingswithallitemwithnoselection"
* "mailhtmltemplateheadingswithnoselection"
* "mailhtmltemplatewithallitem"
* "mailhtmltemplatewithallitemwithnoselection"
* "mailhtmltemplatewithnoselection"
