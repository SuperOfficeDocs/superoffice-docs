---
uid: crmscript
title: crmscript
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

# "crmscript" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.CRMScriptProvider">CRMScriptProvider</see> class.
The name of the MDO list is 'crmscript'.




## Sample Request

```http!
GET /api/v1/MDOList/crmscript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("crmscript", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|16|Add project member|||
|15|Create appointment|||
|9|Create contact|||
|7|Create person|||
|2|Create request|||
|14|Create sale|||
|10|Edit contact|||
|8|Edit person|||
|3|Edit request|||
|11|Load contact|||
|4|Load person|||
|12|Load reply template|||
|6|Load request|||
|5|Send email|||
|13|Trigger response|||
|1|Callback script for compact mode|||


## Related MDO Lists

* "crmscriptheadings"
* "crmscriptheadingswithallitem"
* "crmscriptheadingswithallitemwithnoselection"
* "crmscriptheadingswithnoselection"
* "crmscriptwithallitem"
* "crmscriptwithallitemwithnoselection"
* "crmscriptwithnoselection"
