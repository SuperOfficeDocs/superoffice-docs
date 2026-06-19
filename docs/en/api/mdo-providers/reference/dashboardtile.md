---
uid: dashboardtile
title: dashboardtile
keywords: mdoprovider mdo provider dashboardtile
description: MDO list provider for Dashboard tiles If the DashboardTileEntityType parameter is given in the ExtraInfo, only this type will be shown in list, so no tree view in that case. Example - DashboardTileEntityType=Company
generated: true
content_type: reference
envir: onsite, online
---

# "dashboardtile" MDO List
MDO list provider for Dashboard tiles
If the DashboardTileEntityType parameter is given in the ExtraInfo, only this type will be shown in list, so no tree view in that case.
Example: DashboardTileEntityType=Company



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardTileListProvider">DashboardTileListProvider</see> class.
The name of the MDO list is 'dashboardtile'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|DashboardTileEntityType Enum type to filter tiles on| DashboardTileEntityType|Document|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/dashboardtile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboardtile", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1507|[SR_DASHBOARD_AB11EF5074B04E5394D25557FDEAC2B7_CAPTION]|||
|1514|[SR_DASHBOARD_0FE24993089446538C8B467BCA45A45F_CAPTION]|||
|1518|[SR_DASHBOARD_A35E0BA8B7CC495F8AAD808CB20C39C5_CAPTION]|||
|1544|[SR_DASHBOARD_BB2F20C3A06540B2969A378F1DADF157_CAPTION]|||
|1513|[SR_DASHBOARD_CFC2BB01C6C94559BB50CB9BAADD4075_CAPTION]|||
|1543|[SR_DASHBOARD_7C0B9794D6B8483CA3AB8EF75228D139_CAPTION]|||
|1504|[SR_DASHBOARD_D2821A87051F4FF79973A4CBF5215091_CAPTION]|||
|1506|[SR_DASHBOARD_94936296306D4177998B9F84C2F1E15B_CAPTION]|||
|1508|[SR_DASHBOARD_B5B98BF779CF424A912E31561A81C816_CAPTION]|||
|1509|[SR_DASHBOARD_C00164ADA07640E2899A50E8DC4CC94B_CAPTION]|||
|1511|[SR_DASHBOARD_77AAC99958B848E0910FE28837B8F542_CAPTION]|||
|1512|[SR_DASHBOARD_69FD142B4523476E9638634AA64C9904_CAPTION]|||
|1515|[SR_DASHBOARD_4C4DBAE40E964FC99C54A67BE82F420C_CAPTION]|||
|1517|[SR_DASHBOARD_01FB3D99B4FD426AAD00699E2936B0E1_CAPTION]|||
|1521|[SR_DASHBOARD_2A1EB818486747578ECC1CB9FDCCDC3C_CAPTION]|||
|1522|[SR_DASHBOARD_47871CA067FC4AE59D479F5CE5A6FA83_CAPTION]|||
|1523|[SR_DASHBOARD_370D6544181F44FF82475E46EB69258E_CAPTION]|||
|1524|[SR_DASHBOARD_AAA9015B03BB41EAA6B0D50868AEDB84_CAPTION]|||
|1526|[SR_DASHBOARD_A27E020D2B6744908567BCFE7E0B1CE3_CAPTION]|||
|1527|[SR_DASHBOARD_AC5BC5FC64E444399CAB36AB43707026_CAPTION]|||
|1528|[SR_DASHBOARD_C90AB95BCB3142C3A6C2A6A5D6A7564F_CAPTION]|||


## Related MDO Lists

* "dashboardtileheadings"
* "dashboardtileheadingswithallitem"
* "dashboardtileheadingswithallitemwithnoselection"
* "dashboardtileheadingswithnoselection"
* "dashboardtilewithallitem"
* "dashboardtilewithallitemwithnoselection"
* "dashboardtilewithnoselection"
