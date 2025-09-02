---
uid: targetmeasurementunit
title: targetmeasurementunit
keywords: mdoprovider mdo provider targetmeasurementunit
description: MeasurementUnits
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("targetmeasurementunit", forceFlatList: true);
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
