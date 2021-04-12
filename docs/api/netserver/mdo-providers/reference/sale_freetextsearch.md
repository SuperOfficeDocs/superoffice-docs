---
uid: sale_freetextsearch
title: sale_freetextsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "sale_freetextsearch"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "sale_freetextsearch" MDO List
Provider for selecting a Sale.
Does keyword matching and scoring across multiple
string fields. Checks name, description, soundex fields.

User's own sales, recently added + modified sales, sales modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
<para />
Returns sale items only: Id = sale-id, Name = sale name, Type = "Sale", IconHint="deleted_item", ExtraInfo= sale-id
<para />
Completed/Done sales are marked with stylehint = "deleted_item" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleListFreetextSearchProvider">SaleListFreetextSearchProvider</see> class.
The name of the MDO list is 'sale_freetextsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/sale_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("sale_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SalgAAAA (Arne'S Kebab, AAvdeling: Arnhild Arvestad)||SalgAAAA|
|2|SalgFAAF (Arne'S Kebab, AAvdeling: Arjan Abelsen)||SalgFAAF|
|3|SalgLAAL (Arne'S Kebab, AAvdeling)|lost|SalgLAAL|
|5|SalgWAAW (Yngve'S Fisk & Vilt, YAvdeling: Yngve Yssen)|sold|SalgWAAW|
|6|SalgØAAØ (Yngve'S Fisk & Vilt, YAvdeling: Yngvar Ystad)||SalgØAAØ|
|7|Salg1AA1 (0-Feil Software AS, 0Avdeling)|lost|Salg1AA1|
|8|Salg6AA6 (0-Feil Software AS, 0Avdeling)||Salg6AA6|
|9|Salg%AA% (0-Feil Software AS, 0Avdeling)|sold|Salg%AA%|
|10|Salg*AA* (0-Feil Software AS, 0Avdeling)|lost|Salg*AA*|
|11|SalgBBBB (Arne'S Kebab, AAvdeling: Arnhild Arvestad)||SalgBBBB|
|12|SalgGBBG (Arne'S Kebab, AAvdeling: Arjan Abelsen)|sold|SalgGBBG|
|15|SalgXBBX (Yngve'S Fisk & Vilt, YAvdeling: Yngve Yssen)|lost|SalgXBBX|
|16|SalgÅBBÅ (Yngve'S Fisk & Vilt, YAvdeling: Yngvar Ystad)|sold|SalgÅBBÅ|
|19|Salg&BB& (0-Feil Software AS, 0Avdeling)|lost|Salg&BB&|
|20|Salg<BB< (0-Feil Software AS, 0Avdeling)||Salg<BB<|
|21|SalgCDDC (Arne'S Kebab, AAvdeling: Arjan Abelsen)|sold|SalgCDDC|
|23|SalgNDDN (Arne'S Kebab, AAvdeling)||SalgNDDN|
|24|SalgSDDS (Yngve'S Fisk & Vilt, YAvdeling)|sold|SalgSDDS|
|25|SalgYDDY (Yngve'S Fisk & Vilt, YAvdeling)||SalgYDDY|
|26|SalgÖDDÖ (Yngve'S Fisk & Vilt, YAvdeling: Yngvar Ystad)|lost|SalgÖDDÖ|
|28|Salg8DD8 (0-Feil Software AS, 0Avdeling)|sold|Salg8DD8|


## Related MDO Lists

* "sale_freetextsearchheadings"
* "sale_freetextsearchheadingswithallitem"
* "sale_freetextsearchheadingswithallitemwithnoselection"
* "sale_freetextsearchheadingswithnoselection"
* "sale_freetextsearchwithallitem"
* "sale_freetextsearchwithallitemwithnoselection"
* "sale_freetextsearchwithnoselection"
