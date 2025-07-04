---
uid: saintsalestatus
title: saintsalestatus
keywords: mdoprovider mdo provider saintsalestatus
description: This SoList provider generates the sale status list for the Saint criteria. This is a simple, hard-coded list corresponding to the status field of the <see cref="!:SuperOffice.CRM.Rows.Sale" /> table.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "saintsalestatus" MDO List
This SoList provider generates the sale status list for the Saint criteria. This is a simple, hard-coded list corresponding
to the status field of the <see cref="!:SuperOffice.CRM.Rows.Sale" /> table.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintSaleStatusProvider">SaintSaleStatusProvider</see> class.
The name of the MDO list is 'saintsalestatus'.




## Sample Request

```http!
GET /api/v1/MDOList/saintsalestatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saintsalestatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|1|Open|||
|3|Lost|||
|2|Sold|||
|4|Stalled|||


## Related MDO Lists

* "saintsalestatusheadings"
* "saintsalestatusheadingswithallitem"
* "saintsalestatusheadingswithallitemwithnoselection"
* "saintsalestatusheadingswithnoselection"
* "saintsalestatuswithallitem"
* "saintsalestatuswithallitemwithnoselection"
* "saintsalestatuswithnoselection"
