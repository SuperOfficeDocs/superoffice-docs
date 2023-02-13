---
uid: mailingsubscriptiontype
title: mailingsubscriptiontype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mailingsubscriptiontype"
so.generated: true
so.date: 01.23.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailingsubscriptiontype", forceFlatList: true);
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
