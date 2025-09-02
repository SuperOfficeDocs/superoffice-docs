---
uid: country2
title: country2
keywords: mdoprovider mdo provider country2
description: Same as CountryProvider, but with icon hints based on the countrys name.
generated: true
content_type: reference
envir: onsite, online
---

# "country2" MDO List
Same as CountryProvider, but with icon hints based on the countrys name.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.Country2Provider">Country2Provider</see> class.
The name of the MDO list is 'country2'.




## Sample Request

```http!
GET /api/v1/MDOList/country2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("country2", forceFlatList: true);
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

* "country2headings"
* "country2headingswithallitem"
* "country2headingswithallitemwithnoselection"
* "country2headingswithnoselection"
* "country2withallitem"
* "country2withallitemwithnoselection"
* "country2withnoselection"
