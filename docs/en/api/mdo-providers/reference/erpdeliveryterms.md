---
uid: erpdeliveryterms
title: erpdeliveryterms
keywords: mdoprovider mdo provider erpdeliveryterms
description: 
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "erpdeliveryterms" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteListsByIdProvider">QuoteListsByIdProvider</see> class.
The name of the MDO list is 'erpdeliveryterms'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote alternative implies sale id, which tells us which quote connection to get| QuoteAlternativeId|1234|
|Sale to get quotes from which tells us which quote connection to get| SaleId|1234|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/erpdeliveryterms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erpdeliveryterms", forceFlatList: true);
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

* "erpdeliverytermsheadings"
* "erpdeliverytermsheadingswithallitem"
* "erpdeliverytermsheadingswithallitemwithnoselection"
* "erpdeliverytermsheadingswithnoselection"
* "erpdeliverytermswithallitem"
* "erpdeliverytermswithallitemwithnoselection"
* "erpdeliverytermswithnoselection"
