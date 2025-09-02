---
uid: mailingsubscriptiontype
title: mailingsubscriptiontype
keywords: mdoprovider mdo provider mailingsubscriptiontype
description: Mailing subscription types; Invitations, news, etc
generated: true
content_type: reference
envir: onsite, online
---

# "mailingsubscriptiontype" MDO List
Mailing subscription types; Invitations, news, etc



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingSubscriptionTypeProvider">MailingSubscriptionTypeProvider</see> class.
The name of the MDO list is 'mailingsubscriptiontype'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingsubscriptiontype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailingsubscriptiontype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|(Unspecified)|||
|1|Invitations|||
|2|News|||
|3|Promotions|||
|4|Urgent messages|||


## Related MDO Lists

* "mailingsubscriptiontypeheadings"
* "mailingsubscriptiontypeheadingswithallitem"
* "mailingsubscriptiontypeheadingswithallitemwithnoselection"
* "mailingsubscriptiontypeheadingswithnoselection"
* "mailingsubscriptiontypewithallitem"
* "mailingsubscriptiontypewithallitemwithnoselection"
* "mailingsubscriptiontypewithnoselection"
