---
uid: ticket_freetextsearch
title: ticket_freetextsearch
keywords: mdoprovider mdo provider ticket_freetextsearch
description: Provider for selecting a Ticket - with contact and person search. Does keyword matching and scoring across multiple string fields. Checks ticket heading, from, author as well as contact, person and project tables. Supports cross-table matching - "Guttorm Teacup" will find tickets from person "Guttorm" with title containing "Teacup".
generated: true
content_type: reference
envir: onsite, online
---

# "ticket_freetextsearch" MDO List
Provider for selecting a Ticket - with contact and person search.
Does keyword matching and scoring across multiple
string fields. Checks ticket heading, from, author as well as contact, person and project tables.
Supports cross-table matching: "Guttorm Teacup" will find tickets from person "Guttorm" with title containing "Teacup".

User's own tickets, recently added + modified tickets, contacts modified or created by user as scored higher.
Matches on word boundaries or at start of field are scored extra highly.


Returns ticket items only: Id = ticket id.
ExtraInfo = person_id, Type = "Ticket", IconHint = "Ticket"
StyleHint = "deleted_item" or "ticketUnread"

Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketListFreetextSearchProvider">TicketListFreetextSearchProvider</see> class.
The name of the MDO list is 'ticket_freetextsearch'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Indicates how to format item name| nameformat|includePersonAndCompany|





## Sample Request

```http!
GET /api/v1/MDOList/ticket_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticket_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SoapUI was here (Frode Freestad (statezerodatabase))|ticketUnread|15|
|2|ATD Process Improvement - invitasjon til å redigere (Arne Arnesen (Amadeus AS, AAvdeling))|deleted_item|19|
|3|Timeplan møter RnD 2016 - invitasjon til å redigere (Arne Arnesen (Amadeus AS, AAvdeling))|deleted_item|19|
|4|Hei (Arnt Arntsen (Amadeus AS, AAvdeling))|deleted_item|20|
|5|Hei (Arnt Arntsen (Amadeus AS, AAvdeling))|deleted_item|20|
|6|Mailing coming up (Arnt Arntsen (Amadeus AS, AAvdeling))|deleted_item|20|
|7|Stian Andre, a few Google+ posts you may like (Arnhild Arvestad (Arne'S Kebab, AAvdeling))|deleted_item|21|
|8|Email from my Outlook (Arnt Arntsen (Amadeus AS, AAvdeling))|deleted_item|20|
|9|The second email (Arnt Arntsen (Amadeus AS, AAvdeling))|deleted_item|20|
|10|Stian Andre, a few Google+ posts you may like (Arnhild Arvestad (Arne'S Kebab, AAvdeling))|deleted_item|21|
|13|Test FAQ relation|ticketUnread|-1|


## Related MDO Lists

* "ticket_freetextsearchheadings"
* "ticket_freetextsearchheadingswithallitem"
* "ticket_freetextsearchheadingswithallitemwithnoselection"
* "ticket_freetextsearchheadingswithnoselection"
* "ticket_freetextsearchwithallitem"
* "ticket_freetextsearchwithallitemwithnoselection"
* "ticket_freetextsearchwithnoselection"
