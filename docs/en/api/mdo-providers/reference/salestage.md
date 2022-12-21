---
uid: salestage
title: salestage
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "salestage"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "salestage" MDO List

Provider for selecting a stage. AdditionalInfo is used as criteria to filter stages based on SaleType.

Sold(-2) and Lost(-1) items are appended  at the end of the list.
<para />
AdditionalInfo "SaleTypeID=123&amp;GetDeletedStages=true&amp;HideOptionalRows=false&amp;GetDeletedStageLinks=true"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleStageProvider">SaleStageProvider</see> class.
The name of the MDO list is 'salestage'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Sale type to get stages for| SaleTypeID|1234|
|Include deleted stages| GetDeletedStages|True|
|Filter out deleted sale stage links| GetDeletedStageLinks|False|
|Filter out optional stages| HideOptionalRows|False|

Separator: &

## Sample Request

```http!
GET /api/v1/MDOList/salestage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("salestage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|Første møte||IsDeleted=False&Probability=20&SaleTypeStageLinkId=1|
|1|Sendt tilbud||IsDeleted=False&Probability=30&SaleTypeStageLinkId=2|
|5|Andre møte||IsDeleted=False&Probability=50&SaleTypeStageLinkId=3|
|2|Sluttforhandlinger||IsDeleted=False&Probability=80&SaleTypeStageLinkId=4|
|3|Muntlig aksept||IsDeleted=False&Probability=90&SaleTypeStageLinkId=5|
|-2|Sold||Probability=100|
|-1|Lost||Probability=0|

## Related MDO Lists

* "salestageheadings"
* "salestageheadingswithallitem"
* "salestageheadingswithallitemwithnoselection"
* "salestageheadingswithnoselection"
* "salestagewithallitem"
* "salestagewithallitemwithnoselection"
* "salestagewithnoselection"
