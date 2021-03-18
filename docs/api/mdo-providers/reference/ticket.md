---
uid: ticket
title: ticket
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

# "ticket" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketListProvider">TicketListProvider</see> class.
The name of the MDO list is 'ticket'.




## Sample Request

```http!
GET /api/v1/MDOList/ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticket", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SoapUI was here (Frode Freestad: statezerodatabase)|||
|2|ATD Process Improvement - invitasjon til å redigere (Arne Arnesen: Amadeus AS, AAvdeling)|||
|3|Timeplan møter RnD 2016 - invitasjon til å redigere (Arne Arnesen: Amadeus AS, AAvdeling)|||
|4|Hei (Arnt Arntsen: Amadeus AS, AAvdeling)|||
|5|Hei (Arnt Arntsen: Amadeus AS, AAvdeling)|||
|6|Mailing coming up (Arnt Arntsen: Amadeus AS, AAvdeling)|||
|7|Stian Andre, a few Google+ posts you may like (Arnhild Arvestad: Arne'S Kebab, AAvdeling)|||
|8|Email from my Outlook (Arnt Arntsen: Amadeus AS, AAvdeling)|||
|9|The second email (Arnt Arntsen: Amadeus AS, AAvdeling)|||
|10|Stian Andre, a few Google+ posts you may like (Arnhild Arvestad: Arne'S Kebab, AAvdeling)|||
|13|Test FAQ relation ()|||


## Related MDO Lists

* "ticketheadings"
* "ticketheadingswithallitem"
* "ticketheadingswithallitemwithnoselection"
* "ticketheadingswithnoselection"
* "ticketwithallitem"
* "ticketwithallitemwithnoselection"
* "ticketwithnoselection"
