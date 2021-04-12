---
uid: emailrecipient
title: emailrecipient
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "emailrecipient"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailrecipient" MDO List
List of most recent e-mail recipients cached for the current user.

List is stored in blob with associate id in blob's extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.EMailRecipientProvider">EMailRecipientProvider</see> class.
The name of the MDO list is 'emailrecipient'.




## Sample Request

```http!
GET /api/v1/MDOList/emailrecipient
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailrecipient", forceFlatList: true);
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

* "emailrecipientheadings"
* "emailrecipientheadingswithallitem"
* "emailrecipientheadingswithallitemwithnoselection"
* "emailrecipientheadingswithnoselection"
* "emailrecipientwithallitem"
* "emailrecipientwithallitemwithnoselection"
* "emailrecipientwithnoselection"
