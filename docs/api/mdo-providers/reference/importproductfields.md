---
uid: importproductfields
title: importproductfields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "importproductfields"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "importproductfields" MDO List
MDO provider for column headers used in import



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportProductFieldsProvider">ImportProductFieldsProvider</see> class.
The name of the MDO list is 'importproductfields'.




## Sample Request

```http!
GET /api/v1/MDOList/importproductfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("importproductfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Product: Name|||
|1|Product: Description|||
|2|Product: Code|||
|3|Product: Unit|||
|4|Product: Subscription|||
|5|Product: Subscription unit|||
|6|Product: Subscription quantity|||
|7|Product: Item number|||
|8|Product: Web address|||
|9|Product: Product category|||
|10|Product: Product family|||
|11|Product: Product type|||
|12|Product: VAT info|||
|13|Product: VAT|||
|14|Product: Cost|||
|15|Product: Unit minimum price|||
|16|Product: List price|||
|17|Product: Extra info|||
|18|Product: In assortment |||
|19|Product: Supplier|||
|20|Product: Supplier's code|||


## Related MDO Lists

* "importproductfieldsheadings"
* "importproductfieldsheadingswithallitem"
* "importproductfieldsheadingswithallitemwithnoselection"
* "importproductfieldsheadingswithnoselection"
* "importproductfieldswithallitem"
* "importproductfieldswithallitemwithnoselection"
* "importproductfieldswithnoselection"
