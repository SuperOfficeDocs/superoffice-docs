---
uid: sale_new
title: sale_new
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "sale_new"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "sale_new" MDO List

List of sales.
Searches sale + company names + person names.

Skips completed sales SkipCompletedSales userpref is set.

Skips sales without quotes if AdditionalInfo contains "hasQuoteOnline=1".

Skips sales without stakeholders if AdditionalInfo contains "stakeholderOnly=1".

Filter sales according to currency if AdditionalInfo contains "hasCurrency=(currency-id)"

Returns sale items only: Id = sale-id, Name = Sale name (company name,dept or project name), Type = "Sale",
ExtraInfo = sale heading name.

Completed/Done sales are marked with stylehint = "deleted_item" (but item.deleted = false)

Not complete Lost/Stalled/Sold sales are marked with corresponding style hints.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleListProvider">SaleListProvider</see> class.
The name of the MDO list is 'sale_new'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Only Sales with stakeholders| stakeholderOnly|1|
|Only Sales with quotes| hasQuoteOnly|1|
|Only Sales with currency id = value| hasCurrency|234|

Separator: ;


## Sample Request

```http!
GET /api/v1/MDOList/sale_new
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("sale_new", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SalgAAAA (Arne'S Kebab, AAvdeling)||SalgAAAA|
|2|SalgFAAF (Arne'S Kebab, AAvdeling)||SalgFAAF|
|3|SalgLAAL (Arne'S Kebab, AAvdeling)|lost|SalgLAAL|
|5|SalgWAAW (Yngve'S Fisk & Vilt, YAvdeling)|sold|SalgWAAW|
|6|SalgØAAØ (Yngve'S Fisk & Vilt, YAvdeling)||SalgØAAØ|
|7|Salg1AA1 (0-Feil Software AS, 0Avdeling)|lost|Salg1AA1|
|8|Salg6AA6 (0-Feil Software AS, 0Avdeling)||Salg6AA6|
|9|Salg%AA% (0-Feil Software AS, 0Avdeling)|sold|Salg%AA%|
|10|Salg*AA* (0-Feil Software AS, 0Avdeling)|lost|Salg*AA*|
|11|SalgBBBB (Arne'S Kebab, AAvdeling)||SalgBBBB|
|12|SalgGBBG (Arne'S Kebab, AAvdeling)|sold|SalgGBBG|
|15|SalgXBBX (Yngve'S Fisk & Vilt, YAvdeling)|lost|SalgXBBX|
|16|SalgÅBBÅ (Yngve'S Fisk & Vilt, YAvdeling)|sold|SalgÅBBÅ|
|19|Salg&BB& (0-Feil Software AS, 0Avdeling)|lost|Salg&BB&|
|20|Salg<BB< (0-Feil Software AS, 0Avdeling)||Salg<BB<|
|21|SalgCDDC (Arne'S Kebab, AAvdeling)|sold|SalgCDDC|
|23|SalgNDDN (Arne'S Kebab, AAvdeling)||SalgNDDN|
|24|SalgSDDS (Yngve'S Fisk & Vilt, YAvdeling)|sold|SalgSDDS|
|25|SalgYDDY (Yngve'S Fisk & Vilt, YAvdeling)||SalgYDDY|
|26|SalgÖDDÖ (Yngve'S Fisk & Vilt, YAvdeling)|lost|SalgÖDDÖ|
|28|Salg8DD8 (0-Feil Software AS, 0Avdeling)|sold|Salg8DD8|

## Related MDO Lists

* "sale_newheadings"
* "sale_newheadingswithallitem"
* "sale_newheadingswithallitemwithnoselection"
* "sale_newheadingswithnoselection"
* "sale_newwithallitem"
* "sale_newwithallitemwithnoselection"
* "sale_newwithnoselection"
