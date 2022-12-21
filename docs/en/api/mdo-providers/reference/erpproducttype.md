---
uid: erpproducttype
title: erpproducttype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "erpproducttype"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "erpproducttype" MDO List

Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;.
Consider using "QM_"+&lt;sale_id&gt;+&lt;list name&gt; instead if you can.

See the remarks on <see cref="T:SuperOffice.CRM.Lists.QuoteListsByNameProvider" /> for an overview of Quote List dispatching, which is fairly complex.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteListsByIdProvider">QuoteListsByIdProvider</see> class.
The name of the MDO list is 'erpproducttype'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Quote alternative implies sale id, which tells us which quote connection to get| QuoteAlternativeId|1234|
|Sale to get quotes from which tells us which quote connection to get| SaleId|1234|

Separator: &

## Sample Request

```http!
GET /api/v1/MDOList/erpproducttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("erpproducttype", forceFlatList: true);
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

* "erpproducttypeheadings"
* "erpproducttypeheadingswithallitem"
* "erpproducttypeheadingswithallitemwithnoselection"
* "erpproducttypeheadingswithnoselection"
* "erpproducttypewithallitem"
* "erpproducttypewithallitemwithnoselection"
* "erpproducttypewithnoselection"
