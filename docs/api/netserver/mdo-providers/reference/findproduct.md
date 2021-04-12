---
uid: findproduct
title: findproduct
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "findproduct"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "findproduct" MDO List
QuickSearch for the Add Quote Line dialog, where a single-line user input is passed to the
correct QuoteConnection FindProduct method, and results are returned in a standard or specified format back.
The format can be specified by setting a columnLayout part in the extrainfo. For example "columnLayout=Code\tName\tUnitListPrice\tQuantityUnit"



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FindProduct">FindProduct</see> class.
The name of the MDO list is 'findproduct'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Alternative links to a quote, which tells us which quote connection to use| QuoteAlternativeId|123|
|Pricelist to restrict search to| erpPricelistKey|PL123|
|Named column layout| columnLayout|layout123|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/findproduct
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("findproduct", forceFlatList: true);
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

* "findproductheadings"
* "findproductheadingswithallitem"
* "findproductheadingswithallitemwithnoselection"
* "findproductheadingswithnoselection"
* "findproductwithallitem"
* "findproductwithallitemwithnoselection"
* "findproductwithnoselection"
