---
uid: customobjectrelation
title: customobjectrelation
keywords: mdoprovider mdo provider customobjectrelation
description: MDO list provider for custom object relations Custom object's name is passed as additionalInfo parameter
generated: true
content_type: reference
envir: onsite, online
---

# "customobjectrelation" MDO List
MDO list provider for custom object relations
Custom object's name is passed as additionalInfo parameter



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CustomObjectRelationProvider">CustomObjectRelationProvider</see> class.
The name of the MDO list is 'customobjectrelation'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Custom object's name| name|y_customobject|





## Sample Request

```http!
GET /api/v1/MDOList/customobjectrelation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("customobjectrelation", forceFlatList: true);
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

* "customobjectrelationheadings"
* "customobjectrelationheadingswithallitem"
* "customobjectrelationheadingswithallitemwithnoselection"
* "customobjectrelationheadingswithnoselection"
* "customobjectrelationwithallitem"
* "customobjectrelationwithallitemwithnoselection"
* "customobjectrelationwithnoselection"
