---
uid: country
title: country
keywords: mdoprovider mdo provider country
description: 
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "country" MDO List
The name of the MDO list is 'country'.




## Sample Request

```http!
GET /api/v1/MDOList/country
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("country", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|4|Afghanistan|||
|248|Åland|||
|8|Albania|||
|12|Algeria|||
|16|American Samoa|||
|20|Andorra|||
|24|Angola|||
|660|Anguilla|||
|10|Antarctica|||
|28|Antigua and Barbuda|||
|32|Argentina|||
|51|Armenia|||
|533|Aruba|||
|36|Australia|||
|40|Austria|||
|31|Azerbaijan|||
|44|Bahamas|||
|48|Bahrain|||
|50|Bangladesh|||
|52|Barbados|||
|112|Belarus|||


## Related MDO Lists

* "countryheadings"
* "countryheadingswithallitem"
* "countryheadingswithallitemwithnoselection"
* "countryheadingswithnoselection"
* "countrywithallitem"
* "countrywithallitemwithnoselection"
* "countrywithnoselection"
