---
uid: sale
title: sale
keywords: mdoprovider mdo provider sale
description: List of sales. Skips completed sales SkipCompletedSales userpref is set. Skips sales without quotes if AdditionalInfo contains "hasQuoteOnline=1". Skips sales without stakeholders if AdditionalInfo contains "stakeholderOnly=1". Filter sales according to currency if AdditionalInfo contains "hasCurrency=(currency-id)"
generated: true
content_type: reference
envir: onsite, online
---

# "sale" MDO List
List of sales.
Skips completed sales SkipCompletedSales userpref is set.
Skips sales without quotes if AdditionalInfo contains "hasQuoteOnline=1".
Skips sales without stakeholders if AdditionalInfo contains "stakeholderOnly=1".
Filter sales according to currency if AdditionalInfo contains "hasCurrency=(currency-id)"



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleListProviderOrg">SaleListProviderOrg</see> class.
The name of the MDO list is 'sale'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Only Sales with stakeholders| stakeholderOnly|1|
|Only Sales with quotes| hasQuoteOnly|1|
|Only Sales with currency id = value| hasCurrency|234|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("sale", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SalgAAAA (Arne'S Kebab)||SalgAAAA|
|2|SalgFAAF (Arne'S Kebab)||SalgFAAF|
|3|SalgLAAL (Arne'S Kebab)||SalgLAAL|
|5|SalgWAAW (Yngve'S Fisk & Vilt)||SalgWAAW|
|6|SalgØAAØ (Yngve'S Fisk & Vilt)||SalgØAAØ|
|7|Salg1AA1 (0-Feil Software AS)||Salg1AA1|
|8|Salg6AA6 (0-Feil Software AS)||Salg6AA6|
|10|Salg*AA* (0-Feil Software AS)||Salg*AA*|
|11|SalgBBBB (Arne'S Kebab)||SalgBBBB|
|12|SalgGBBG (Arne'S Kebab)||SalgGBBG|
|13|SalgMBBM (Arne'S Kebab)||SalgMBBM|
|14|SalgRBBR (Yngve'S Fisk & Vilt)||SalgRBBR|
|15|SalgXBBX (Yngve'S Fisk & Vilt)||SalgXBBX|
|16|SalgÅBBÅ (Yngve'S Fisk & Vilt)||SalgÅBBÅ|
|18|Salg7BB7 (0-Feil Software AS)||Salg7BB7|
|19|Salg&BB& (0-Feil Software AS)||Salg&BB&|
|20|Salg<BB< (0-Feil Software AS)||Salg<BB<|
|21|SalgCDDC (Arne'S Kebab)||SalgCDDC|
|23|SalgNDDN (Arne'S Kebab)||SalgNDDN|
|24|SalgSDDS (Yngve'S Fisk & Vilt)||SalgSDDS|
|25|SalgYDDY (Yngve'S Fisk & Vilt)||SalgYDDY|


## Related MDO Lists

* "saleheadings"
* "saleheadingswithallitem"
* "saleheadingswithallitemwithnoselection"
* "saleheadingswithnoselection"
* "salewithallitem"
* "salewithallitemwithnoselection"
* "salewithnoselection"
