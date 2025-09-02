---
uid: urlencoding
title: urlencoding
keywords: mdoprovider mdo provider urlencoding
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "urlencoding" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.UrlEncodingProvider">UrlEncodingProvider</see> class.
The name of the MDO list is 'urlencoding'.




## Sample Request

```http!
GET /api/v1/MDOList/urlencoding
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("urlencoding", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|None||None|
|2|ANSI||ANSI|
|3|Unicode||Unicode|


## Related MDO Lists

* "urlencodingheadings"
* "urlencodingheadingswithallitem"
* "urlencodingheadingswithallitemwithnoselection"
* "urlencodingheadingswithnoselection"
* "urlencodingwithallitem"
* "urlencodingwithallitemwithnoselection"
* "urlencodingwithnoselection"
