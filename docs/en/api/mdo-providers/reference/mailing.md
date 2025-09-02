---
uid: mailing
title: mailing
keywords: mdoprovider mdo provider mailing
description: All mailings - history ids
generated: true
content_type: reference
envir: onsite, online
---

# "mailing" MDO List
All mailings - history ids



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingProvider">MailingProvider</see> class.
The name of the MDO list is 'mailing'.




## Sample Request

```http!
GET /api/v1/MDOList/mailing
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailing", forceFlatList: true);
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

* "mailingheadings"
* "mailingheadingswithallitem"
* "mailingheadingswithallitemwithnoselection"
* "mailingheadingswithnoselection"
* "mailingwithallitem"
* "mailingwithallitemwithnoselection"
* "mailingwithnoselection"
