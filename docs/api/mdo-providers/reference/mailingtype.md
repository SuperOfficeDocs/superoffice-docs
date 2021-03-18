---
uid: mailingtype
title: mailingtype
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

# "mailingtype" MDO List
Mailing types: Html mail, SMS, Word Document



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingTypeProvider">MailingTypeProvider</see> class.
The name of the MDO list is 'mailingtype'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailingtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|E-mail|||
|2|SMS|||
|3|Document|||


## Related MDO Lists

* "mailingtypeheadings"
* "mailingtypeheadingswithallitem"
* "mailingtypeheadingswithallitemwithnoselection"
* "mailingtypeheadingswithnoselection"
* "mailingtypewithallitem"
* "mailingtypewithallitemwithnoselection"
* "mailingtypewithnoselection"
