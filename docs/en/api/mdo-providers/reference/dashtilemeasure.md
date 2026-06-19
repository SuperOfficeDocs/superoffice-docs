---
uid: dashtilemeasure
title: dashtilemeasure
keywords: mdoprovider mdo provider dashtilemeasure
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "dashtilemeasure" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashTileMeasureProvider">DashTileMeasureProvider</see> class.
The name of the MDO list is 'dashtilemeasure'.




## Sample Request

```http!
GET /api/v1/MDOList/dashtilemeasure
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashtilemeasure", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_DASHBOARD_MEASURE_NONE]||EnumName=None|
|6|[SR_DASHBOARD_MEASURE_COUNT]||EnumName =Count|
|2|[SR_DASHBOARD_MEASURE_SUM]||EnumName=Sum|
|3|[SR_DASHBOARD_MEASURE_AVERAGE]||EnumName=Average|
|4|[SR_DASHBOARD_MEASURE_MAX]||EnumName=Max|
|5|[SR_DASHBOARD_MEASURE_MIN]||EnumName=Min|


## Related MDO Lists

* "dashtilemeasureheadings"
* "dashtilemeasureheadingswithallitem"
* "dashtilemeasureheadingswithallitemwithnoselection"
* "dashtilemeasureheadingswithnoselection"
* "dashtilemeasurewithallitem"
* "dashtilemeasurewithallitemwithnoselection"
* "dashtilemeasurewithnoselection"
