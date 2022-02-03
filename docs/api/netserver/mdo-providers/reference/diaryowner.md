---
uid: diaryowner
title: diaryowner
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "diaryowner"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "diaryowner" MDO List
List provider that returns diary owners, i.e., our own employees plus resources



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DiaryOwnerMDOProvider">DiaryOwnerMDOProvider</see> class.
The name of the MDO list is 'diaryowner'.




## Sample Request

```http!
GET /api/v1/MDOList/diaryowner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("diaryowner", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0|||
|12|Adm1|||
|13|Adm2|||
|14|Adm3|||
|15|Adm4|||
|16|Adm5|||
|1|Admin Adminson|||
|63|AdmNS02 NetServer|||
|2|Arne Arnesen|||
|3|Brede Bredesen|||
|4|Cato Carlsson|||
|5|Donald Duck|||
|6|Erik Eide|||
|7|Frode Freestad|||
|8|Geir Grønbeck|||
|9|Hans Hansen|||
|10|Ingrid Istad|||
|86|Johan Jensen|||
|87|Kjell Jensen|||
|81|Listadm Listadm|||
|84|Localuser2 Localuser2|||


## Related MDO Lists

* "diaryownerheadings"
* "diaryownerheadingswithallitem"
* "diaryownerheadingswithallitemwithnoselection"
* "diaryownerheadingswithnoselection"
* "diaryownerwithallitem"
* "diaryownerwithallitemwithnoselection"
* "diaryownerwithnoselection"
