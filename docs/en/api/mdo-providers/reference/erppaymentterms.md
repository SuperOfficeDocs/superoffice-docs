---
uid: erppaymentterms
title: erppaymentterms
keywords: mdoprovider mdo provider erppaymentterms
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "erppaymentterms" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteListsByIdProvider">QuoteListsByIdProvider</see> class.
The name of the MDO list is 'erppaymentterms'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote alternative implies sale id, which tells us which quote connection to get| QuoteAlternativeId|1234|
|Sale to get quotes from which tells us which quote connection to get| SaleId|1234|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/erppaymentterms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erppaymentterms", forceFlatList: true);
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

* "erppaymenttermsheadings"
* "erppaymenttermsheadingswithallitem"
* "erppaymenttermsheadingswithallitemwithnoselection"
* "erppaymenttermsheadingswithnoselection"
* "erppaymenttermswithallitem"
* "erppaymenttermswithallitemwithnoselection"
* "erppaymenttermswithnoselection"
