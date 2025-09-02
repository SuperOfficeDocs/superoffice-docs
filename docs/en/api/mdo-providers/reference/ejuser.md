---
uid: ejuser
title: ejuser
keywords: mdoprovider mdo provider ejuser
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ejuser" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.EjUserProvider">EjUserProvider</see> class.
The name of the MDO list is 'ejuser'.




## Sample Request

```http!
GET /api/v1/MDOList/ejuser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ejuser", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|67|Sal0||associateId=17|
|66|Adm6||associateId=106|
|29|Ser0||associateId=29|
|30|Ser1||associateId=30|
|31|Ser2||associateId=31|
|32|Ser3||associateId=32|
|33|Ser4||associateId=33|
|34|Ser5||associateId=34|
|42|SerNS03 NetServer||associateId=64|
|43|TjeNS04 NetServer||associateId=65|
|61|Tjeneste Sjef||associateId=99|
|2|Tje0||associateId=23|
|4|Tje1||associateId=24|
|9|Tje2||associateId=25|
|10|Tje3||associateId=26|
|11|Tje4||associateId=27|
|12|Tje5||associateId=28|


## Related MDO Lists

* "ejuserheadings"
* "ejuserheadingswithallitem"
* "ejuserheadingswithallitemwithnoselection"
* "ejuserheadingswithnoselection"
* "ejuserwithallitem"
* "ejuserwithallitemwithnoselection"
* "ejuserwithnoselection"
