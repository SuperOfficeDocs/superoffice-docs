---
uid: mailtemplate
title: mailtemplate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mailtemplate"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mailtemplate" MDO List
List provider for the Mailtemplates.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailTemplateProvider">MailTemplateProvider</see> class.
The name of the MDO list is 'mailtemplate'.




## Sample Request

```http!
GET /api/v1/MDOList/mailtemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailtemplate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|mail.htm|||
|6|E-post|||
|7|E-post SV:|||
|8|E-post VS:|||
|9|Send dok.pr E-post|||
|10|Send dok.pr Faks|||
|17|Quote e-mail|||
|19|Order confirmation e-mail|||
|20|Confirmation - Contact added|||


## Related MDO Lists

* "mailtemplateheadings"
* "mailtemplateheadingswithallitem"
* "mailtemplateheadingswithallitemwithnoselection"
* "mailtemplateheadingswithnoselection"
* "mailtemplatewithallitem"
* "mailtemplatewithallitemwithnoselection"
* "mailtemplatewithnoselection"
