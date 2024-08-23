---
uid: specifiedmailings
title: specifiedmailings
keywords: mdoprovider mdo provider specifiedmailings
description: Create a list of mailings (flow, form, regular mailing/shipment...), hierarchy optional
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "specifiedmailings" MDO List
Create a list of mailings (flow, form, regular mailing/shipment...), hierarchy optional



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SpecifiedMailingsListProvider">SpecifiedMailingsListProvider</see> class.
The name of the MDO list is 'specifiedmailings'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Only mailings with tracked links| tracked|true|
|Specified shipment configurations, default is the most relevant configurations| configurations||

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/specifiedmailings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("specifiedmailings", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "specifiedmailingsheadings"
* "specifiedmailingsheadingswithallitem"
* "specifiedmailingsheadingswithallitemwithnoselection"
* "specifiedmailingsheadingswithnoselection"
* "specifiedmailingswithallitem"
* "specifiedmailingswithallitemwithnoselection"
* "specifiedmailingswithnoselection"
