---
uid: amountclass
title: amountclass
keywords: mdoprovider mdo provider amountclass
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "amountclass" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'amountclass'.




## Sample Request

```http!
GET /api/v1/MDOList/amountclass
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("amountclass", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|Extra large|||
|3|Large|||
|2|Medium|||
|1|Small|||


## Related MDO Lists

* "amountclassheadings"
* "amountclassheadingswithallitem"
* "amountclassheadingswithallitemwithnoselection"
* "amountclassheadingswithnoselection"
* "amountclasswithallitem"
* "amountclasswithallitemwithnoselection"
* "amountclasswithnoselection"
