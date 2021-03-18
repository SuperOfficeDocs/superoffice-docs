---
uid: y_rental
title: y_rental
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "y_rental" MDO List
Extra tables lists. List names are 'y_xyz' - based on the custom table name.
Contents of the list are based on the display_field for the table



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ExtraTableDropdownProvider">ExtraTableDropdownProvider</see> class.
The name of the MDO list is 'y_rental'.




## Sample Request

```http!
GET /api/v1/MDOList/y_rental
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("y_rental", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|1/15/1998|||
|3|11/8/2016|||
|5|9/9/2018|||
|1|9/30/2019|||
|2|11/14/2019|||


## Related MDO Lists

* "y_rentalheadings"
* "y_rentalheadingswithallitem"
* "y_rentalheadingswithallitemwithnoselection"
* "y_rentalheadingswithnoselection"
* "y_rentalwithallitem"
* "y_rentalwithallitemwithnoselection"
* "y_rentalwithnoselection"
