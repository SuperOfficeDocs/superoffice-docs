---
uid: personwithmail
title: personwithmail
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "personwithmail"
so.generated: true
so.date: 03.19.2021
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
|3136|Aaron Ophélie Austin <aaustin3r@wired.com>|||
|15428|Aaron Black <ablackbv@lycos.com>|||
|4783|Aaron Hélèna Bryant <abryantlq@ameblo.jp>|||
|2869|Aaron Marie-noël Carr <acarro4@twitter.com>|||
|14715|Aaron Collins <acollinsju@independent.co.uk>|||
|14719|Aaron Daniels <adanielsjy@google.com.br>|||
|10794|Aaron Annotés Diaz <adiazm1@gmpg.org>|||
|10049|Aaron Fields <afields1c@usda.gov>|||
|15713|Aaron Garcia <agarciajs@w3.org>|||
|14740|Aaron Gonzales <agonzaleskj@google.com.hk>|||
|14102|Aaron Gonzales <agonzales2t@hatena.ne.jp>|||
|3718|Aaron Séréna Graham <agrahamjx@elpais.com>|||
|10344|Aaron Mahélie Green <agreen9j@wufoo.com>|||
|10285|Aaron Hawkins <ahawkins7w@epa.gov>|||
|3826|Aaron Maïlys James <ajamesmx@vistaprint.com>|||
|14469|Aaron Johnson <ajohnsond0@de.vu>|||
|3398|Aaron Johnston <ajohnstonb1@dion.ne.jp>|||
|14251|Aaron Lewis <alewis6y@people.com.cn>|||
|1738|Aaron Faîtes Medina <amedinakh@t-online.de>|||
|11707|Aaron Miller <amillerjm@weibo.com>|||
|11274|Aaron Moore <amoore7l@go.com>|||


## Related MDO Lists

* "personwithmailheadings"
* "personwithmailheadingswithallitem"
* "personwithmailheadingswithallitemwithnoselection"
* "personwithmailheadingswithnoselection"
* "personwithmailwithallitem"
* "personwithmailwithallitemwithnoselection"
* "personwithmailwithnoselection"
