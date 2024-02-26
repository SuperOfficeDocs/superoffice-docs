---
uid: y_equipment
title: y_equipment
keywords: mdoprovider mdo provider y_equipment
description: Extra tables lists. List names are 'y_xyz' - based on the custom table name. Contents of the list are based on the display_field for the table
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "y_equipment" MDO List
Extra tables lists. List names are 'y_xyz' - based on the custom table name.
Contents of the list are based on the display_field for the table



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraTableDropdownProvider">ExtraTableDropdownProvider</see> class.
The name of the MDO list is 'y_equipment'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Create hierarchical dropdown.| hierarchy|False|
|Use name from a display field. Otherwise, if it's setup, a name from full name field will be used.| shortNames|False|
|Show all custom table dropdown values immediately. If not, no values will be shown until a search is executed.| useDropDown|False|





## Sample Request

```http!
GET /api/v1/MDOList/y_equipment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("y_equipment", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Screwdriver|||
|2|Incom T-65 X-Wing|||
|3|Sienar TIE Fighter|||

