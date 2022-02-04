---
uid: pricelist
title: pricelist
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "pricelist"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "pricelist" MDO List
List of pricelists from the PriceList table.
Supported values in the AdditionalInfo:
<list type="bullet"><item><term>all</term><description>true|false. If true is specified, inactive items is also returned.</description></item><item><term>QuoteConnectionId</term><description>Gets items for a specific Quote connection. If not specified, only SuperOffice pricelists (where IsErpCopy=false) will be returned.</description></item></list><example>AdditionalInfo string: "all=true&amp;QuoteConnectionId=2"</example>



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PriceListProvider">PriceListProvider</see> class.
The name of the MDO list is 'pricelist'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return all pricelists, not just the active ones| all|True|
|Return only pricelists on the given connection| quoteconnectionid|123|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/pricelist
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("pricelist", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|10 års priser (NOK)||NOK|
|9|10 års priser (NOK)||NOK|
|4|Gammel prisliste (NOK)||NOK|
|3|Julepriser (NOK)||NOK|
|8|Old pricelist (USD)||USD|
|5|Prices for 10 years (USD)||USD|
|7|Xmas pricelist (USD)||USD|


## Related MDO Lists

* "pricelistheadings"
* "pricelistheadingswithallitem"
* "pricelistheadingswithallitemwithnoselection"
* "pricelistheadingswithnoselection"
* "pricelistwithallitem"
* "pricelistwithallitemwithnoselection"
* "pricelistwithnoselection"
