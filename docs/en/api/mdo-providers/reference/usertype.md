---
uid: usertype
title: usertype
keywords: mdoprovider mdo provider usertype
description: Simple, hard-coded provider for the associate type - Employee, ExternalPerson, Resource, Anonymous, System, Invalid User Type
generated: true
content_type: reference
envir: onsite, online
---

# "usertype" MDO List
Simple, hard-coded provider for the associate type: Employee, ExternalPerson, Resource, Anonymous, System, Invalid User Type



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AssociateTypeListProvider">AssociateTypeListProvider</see> class.
The name of the MDO list is 'usertype'.




## Sample Request

```http!
GET /api/v1/MDOList/usertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("usertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Associate|||
|4|External|||
|1|Resource|||
|7|Anonymous|||
|13|System|||
|-1|Not a user|||


## Related MDO Lists

* "usertypeheadings"
* "usertypeheadingswithallitem"
* "usertypeheadingswithallitemwithnoselection"
* "usertypeheadingswithnoselection"
* "usertypewithallitem"
* "usertypewithallitemwithnoselection"
* "usertypewithnoselection"
