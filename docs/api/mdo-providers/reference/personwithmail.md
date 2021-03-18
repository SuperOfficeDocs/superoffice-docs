---
uid: personwithmail
title: personwithmail
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

# "personwithmail" MDO List
List of persons fetched based on provided criteria
Output is in format: "Person Full Name &lt;person@mail.com&gt;"
Optional: Get multiple emails pr. person. (getallemails)



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonWithMailListProvider">PersonWithMailListProvider</see> class.
The name of the MDO list is 'personwithmail'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return all e-mails, rather just the first rank=1 mail| getallemails|True|





## Sample Request

```http!
GET /api/v1/MDOList/personwithmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personwithmail", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|Admin Adminson <qa.testbruker@superoffice.com>|||
|221|Another Kitty <miau.another@mailinator.com>|||
|22|Arjan Abelsen <qa.testbruker@superoffice.com>|||
|19|Arne Arnesen <qa0@superoffice.com>|||
|10|Arne Arnesen <qa.testbruker@superoffice.com>|||
|21|Arnhild Arvestad <qa.testbruker@superoffice.com>|||
|20|Arnt Arntsen <qa5@superoffice.com>|||
|217|Barbara Manyemails <Barabara.Fish@mailinator.com>|||
|24|Bente Båstad <qa5@superoffice.com>|||
|214|Bil Macher <Bil.Macher@mailinator.com>|||
|26|Bjørge Bastesen <qa5@superoffice.com>|||
|25|Bjørn Bjørnsen <qa5@superoffice.com>|||
|11|Brede Bredesen <qa.testbruker@superoffice.com>|||
|23|Britt Bærum <qa5@superoffice.com>|||
|27|Carl-Oskar Cederström <qa5@superoffice.com>|||
|211|Carol Fishmann <carol.fish.company@mailinator.com>|||
|12|Cato Carlsson <qa.testbruker@superoffice.com>|||
|29|Cecilie Carlsen <qa5@superoffice.com>|||
|28|Cidrik Culien <qa5@superoffice.com>|||
|30|Cigfrid Celetas <qa5@superoffice.com>|||
|216|Damian Odnem <Damian.fish@mailinator.com>|||


## Related MDO Lists

* "personwithmailheadings"
* "personwithmailheadingswithallitem"
* "personwithmailheadingswithallitemwithnoselection"
* "personwithmailheadingswithnoselection"
* "personwithmailwithallitem"
* "personwithmailwithallitemwithnoselection"
* "personwithmailwithnoselection"
