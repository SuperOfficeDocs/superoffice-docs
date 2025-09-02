---
uid: personwithmail
title: personwithmail
keywords: mdoprovider mdo provider personwithmail
description: List of persons fetched based on provided criteria Output is in format - "Person Full Name &lt;person@mail.com&gt;" Optional - Get multiple emails pr. person. (getallemails)
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personwithmail", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|Admin Adminson <qa.testbruker@superoffice.com>||associate_id=1&contact_id=2|
|221|Another Kitty <miau.another@mailinator.com>||contact_id=125|
|22|Arjan Abelsen <qa.testbruker@superoffice.com>||associate_id=90&contact_id=4|
|19|Arne Arnesen <qa0@superoffice.com>||contact_id=3|
|10|Arne Arnesen <qa.testbruker@superoffice.com>||associate_id=2&contact_id=2|
|21|Arnhild Arvestad <qa.testbruker@superoffice.com>||contact_id=4|
|20|Arnt Arntsen <qa5@superoffice.com>||contact_id=3|
|217|Barbara Manyemails <Barabara.Fish@mailinator.com>||contact_id=124|
|24|Bente Båstad <qa5@superoffice.com>||contact_id=6|
|214|Bil Macher <Bil.Macher@mailinator.com>||contact_id=124|
|26|Bjørge Bastesen <qa5@superoffice.com>||contact_id=5|
|25|Bjørn Bjørnsen <qa5@superoffice.com>||contact_id=5|
|11|Brede Bredesen <qa.testbruker@superoffice.com>||associate_id=3&contact_id=2|
|23|Britt Bærum <qa5@superoffice.com>||contact_id=6|
|27|Carl-Oskar Cederström <qa5@superoffice.com>||contact_id=8|
|211|Carol Fishmann <carol.fish.company@mailinator.com>||contact_id=124|
|12|Cato Carlsson <qa.testbruker@superoffice.com>||associate_id=4&contact_id=2|
|29|Cecilie Carlsen <qa5@superoffice.com>||contact_id=7|
|28|Cidrik Culien <qa5@superoffice.com>||contact_id=8|
|30|Cigfrid Celetas <qa5@superoffice.com>||contact_id=7|
|216|Damian Odnem <Damian.fish@mailinator.com>||contact_id=124|


## Related MDO Lists

* "personwithmailheadings"
* "personwithmailheadingswithallitem"
* "personwithmailheadingswithallitemwithnoselection"
* "personwithmailheadingswithnoselection"
* "personwithmailwithallitem"
* "personwithmailwithallitemwithnoselection"
* "personwithmailwithnoselection"
