---
uid: eventhandlertype
title: eventhandlertype
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

# "eventhandlertype" MDO List
Screen trigger event types: members of <see cref="T:SuperOffice.Data.EventHandlerType" /> enum.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EventHandlerTypeProvider">EventHandlerTypeProvider</see> class.
The name of the MDO list is 'eventhandlertype'.




## Sample Request

```http!
GET /api/v1/MDOList/eventhandlertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("eventhandlertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown||Unknown|
|100|New request||NewTicket|
|101|New request from the customer care center||NewTicketFromCustomerCenter|
|102|New request from e-mail||NewTicketFromEmail|
|103|New request from the customer care center, before saving||NewTicketFromCustomerCenterBeforeSave|
|104|NewTicketFromSpmLink||NewTicketFromSpmLink|
|105|NewNotifyTicketFromForm||NewNotifyTicketFromForm|
|106|NewTicketFromForm||NewTicketFromForm|
|109|TicketSave||TicketSave|
|110|Request closed||TicketClosed|
|111|Request postponed||TicketPostponed|
|112|Request deleted||TicketDeleted|
|113|Request activated (from postponed)||TicketActivated|
|120|Request re-opened||TicketReopened|
|121|Request re-opened from the customer care center||TicketReopenedFromCustomerCenter|
|122|Request re-opened from email||TicketReopenedFromEmail|
|140|Request changed priority||TicketChangedPriority|
|141|Request changed category||TicketChangedCategory|
|142|Request changed owner||TicketChangedOwnedBy|
|143|Request changed primary contact||TicketChangedPrimaryCustomer|
|144|Request changed status||TicketChangedTicketStatus|


## Related MDO Lists

* "eventhandlertypeheadings"
* "eventhandlertypeheadingswithallitem"
* "eventhandlertypeheadingswithallitemwithnoselection"
* "eventhandlertypeheadingswithnoselection"
* "eventhandlertypewithallitem"
* "eventhandlertypewithallitemwithnoselection"
* "eventhandlertypewithnoselection"
