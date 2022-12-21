---
uid: targetmeasurementunit
title: targetmeasurementunit
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "targetmeasurementunit"
so.generated: true
so.date: 11.29.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "targetmeasurementunit" MDO List
MeasurementUnits



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TargetMeasurementUnitProvider">TargetMeasurementUnitProvider</see> class.
The name of the MDO list is 'targetmeasurementunit'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|The entity type. (Sale, Project, Selection, etc.)| TargetEntityType||
|TargetListField| The list field||

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/targetmeasurementunit
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("targetmeasurementunit", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Amount|||
|2|Count|||
|3|Profit|||


## Related MDO Lists

* "targetmeasurementunitheadings"
* "targetmeasurementunitheadingswithallitem"
* "targetmeasurementunitheadingswithallitemwithnoselection"
* "targetmeasurementunitheadingswithnoselection"
* "targetmeasurementunitwithallitem"
* "targetmeasurementunitwithallitemwithnoselection"
* "targetmeasurementunitwithnoselection"
