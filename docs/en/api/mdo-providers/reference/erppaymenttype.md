---
uid: erppaymenttype
title: erppaymenttype
keywords: mdoprovider mdo provider erppaymenttype
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "erppaymenttype" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteListsByIdProvider">QuoteListsByIdProvider</see> class.
The name of the MDO list is 'erppaymenttype'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote alternative implies sale id, which tells us which quote connection to get| QuoteAlternativeId|1234|
|Sale to get quotes from which tells us which quote connection to get| SaleId|1234|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/erppaymenttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erppaymenttype", forceFlatList: true);
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

* "erppaymenttypeheadings"
* "erppaymenttypeheadingswithallitem"
* "erppaymenttypeheadingswithallitemwithnoselection"
* "erppaymenttypeheadingswithnoselection"
* "erppaymenttypewithallitem"
* "erppaymenttypewithallitemwithnoselection"
* "erppaymenttypewithnoselection"
