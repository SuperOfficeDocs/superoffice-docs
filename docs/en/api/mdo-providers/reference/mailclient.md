---
uid: mailclient
title: mailclient
keywords: mdoprovider mdo provider mailclient
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "mailclient" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailClientProvider">MailClientProvider</see> class.
The name of the MDO list is 'mailclient'.




## Sample Request

```http!
GET /api/v1/MDOList/mailclient
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailclient", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SuperOffice CRM|||
|2|Microsoft Outlook|||


## Related MDO Lists

* "mailclientheadings"
* "mailclientheadingswithallitem"
* "mailclientheadingswithallitemwithnoselection"
* "mailclientheadingswithnoselection"
* "mailclientwithallitem"
* "mailclientwithallitemwithnoselection"
* "mailclientwithnoselection"
