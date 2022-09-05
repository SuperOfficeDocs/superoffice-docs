---
uid: mailingstatus
title: mailingstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mailingstatus"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mailingstatus" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingStatusProvider">MailingStatusProvider</see> class.
The name of the MDO list is 'mailingstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailingstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Under construction|||
|1|Finished|||
|2|Cancelled|||
|3|Scheduled|||
|4|Started|||
|5|Finished|||
|6|Retrying|||
|7|Populating|||
|8|Deleted|||
|9|Preparing|||
|10|Analyzing selections|||
|11|Aborting|||
|12|Recipient counting error|||
|13|Too many recipients|||


## Related MDO Lists

* "mailingstatusheadings"
* "mailingstatusheadingswithallitem"
* "mailingstatusheadingswithallitemwithnoselection"
* "mailingstatusheadingswithnoselection"
* "mailingstatuswithallitem"
* "mailingstatuswithallitemwithnoselection"
* "mailingstatuswithnoselection"
