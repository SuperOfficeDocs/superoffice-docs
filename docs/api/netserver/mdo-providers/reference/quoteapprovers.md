---
uid: quoteapprovers
title: quoteapprovers
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quoteapprovers"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quoteapprovers" MDO List
Retrieve the list of all users that can approve quotes



Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteApprovers">QuoteApprovers</see> class.
The name of the MDO list is 'quoteapprovers'.




## Sample Request

```http!
GET /api/v1/MDOList/quoteapprovers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quoteapprovers", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0|||
|1|Admin Adminson|||
|8|Geir Grønbeck|||
|86|Johan Jensen|||
|35|Mar0|||
|17|Sal0|||
|61|SalNS00 NetServer|||
|29|Ser0|||
|23|Tje0|||


## Related MDO Lists

* "quoteapproversheadings"
* "quoteapproversheadingswithallitem"
* "quoteapproversheadingswithallitemwithnoselection"
* "quoteapproversheadingswithnoselection"
* "quoteapproverswithallitem"
* "quoteapproverswithallitemwithnoselection"
* "quoteapproverswithnoselection"
