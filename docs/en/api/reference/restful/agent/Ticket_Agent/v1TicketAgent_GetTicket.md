---
title: POST Agents/Ticket/GetTicket
uid: v1TicketAgent_GetTicket
generated: true
content_type: reference
---

# POST Agents/Ticket/GetTicket

```http
POST /api/v1/Agents/Ticket/GetTicket
```

Gets a Ticket object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketId | int32 | **Required** The identifier of the Ticket object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicket?ticketId=91
POST /api/v1/Agents/Ticket/GetTicket?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Ticket

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy | int32 | The id of the user who created the ticket. 1 (system user) if the ticket was created externally |
| CreatedByName | string | Initials, also login name, possibly database user name |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | int32 | The id of the user who owns the ticket. 1 (system user) if the ticket is unassigned. |
| OwnedByName | string | Initials, also login name, possibly database user name |
| Category | int32 | The id of the category a ticket is in. |
| CategoryName | string | The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| CategoryFullname | string | The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | int32 | The reference to the ticket_priority table. |
| PriorityName | string | The name of the priority. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted |
| TicketStatus | int32 | User defined ticket status |
| TicketStatusDisplayValue | string | Get the display name of the ticket status. |
| Origin | string | What is the origin of this ticket |
| CustId | int32 | The reference to the customer. NULL or -1 if ticket is not connected to customer. |
| PersonFirstname | string | First name |
| PersonMiddleName | string | Middle name or 'van' etc. |
| PersonLastname | string | Last name |
| PersonFullname | string | Get the full name for the primary person (customer) |
| AlertLevel | int32 | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | int32 | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | string | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | int32 | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | int32 | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | int32 | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | int32 | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | int32 | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | int32 | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | int32 | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | int32 | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| HasAttachment | bool | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | int32 | The number of replies (messages) to the customer for this request. |
| NumMessages | int32 | The total number of messages for this request. |
| FromAddress | string | The from-address used when this ticket got created, e.g. by email |
| ContactId | int32 | The company of the person in the cust_id field, if that person belongs to a company |
| ContactName | string | The name of the connected contact |
| OwnedByAssociateId | int32 | The associate id of the owner of the ticket. |
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SaleId | int32 | Reference to sale table |
| ProjectId | int32 | Reference to project table |
| SaleHeading | string | The heading of the connected sale |
| ProjectName | string | The name of the connected project |
| FormSubmissionId | int32 | If this ticket was created from a form submission, this field will point to that record |
| TicketTypeId | int32 | The id of the Request Type |
| TicketTypeName | string | The name of the Request Type |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 237,
  "Title": "ut",
  "CreatedAt": "1998-11-11T03:41:54.1682108+01:00",
  "LastChanged": "2002-12-01T03:41:54.1682108+01:00",
  "ReadByOwner": "2014-04-15T03:41:54.1682108+02:00",
  "ReadByCustomer": "2004-09-11T03:41:54.1682108+02:00",
  "FirstReadByUser": "2006-11-21T03:41:54.1682108+01:00",
  "Activate": "2000-09-09T03:41:54.1682108+02:00",
  "ClosedAt": "2020-09-12T03:41:54.1682108+02:00",
  "RepliedAt": "1999-05-22T03:41:54.1682108+02:00",
  "AlertTimeout": "2009-12-30T03:41:54.1682108+01:00",
  "Deadline": "2005-08-08T03:41:54.1682108+02:00",
  "CreatedBy": 594,
  "CreatedByName": "Witting LLC",
  "Author": "vero",
  "OwnedBy": 783,
  "OwnedByName": "Hessel, Shields and Jerde",
  "Category": 772,
  "CategoryName": "VIP Customer",
  "CategoryFullname": "VIP Customer",
  "Slevel": "External",
  "Priority": 19,
  "PriorityName": "Schumm, Schamberger and Goyette",
  "BaseStatus": "Active",
  "TicketStatus": 505,
  "TicketStatusDisplayValue": "et",
  "Origin": "AutoGenerated",
  "CustId": 364,
  "PersonFirstname": "Linwood",
  "PersonMiddleName": "Watsica Inc and Sons",
  "PersonLastname": "Crist",
  "PersonFullname": "recusandae",
  "AlertLevel": 153,
  "ConnectId": 818,
  "ReadStatus": "Green",
  "TimeToReply": 6,
  "RealTimeToReply": 148,
  "TimeToClose": 96,
  "RealTimeToClose": 582,
  "TimeSpentInternally": 178,
  "TimeSpentExternally": 548,
  "TimeSpentQueue": 741,
  "RealTimeSpentInternally": 186,
  "RealTimeSpentExternally": 345,
  "RealTimeSpentQueue": 603,
  "TimeSpent": 412,
  "HasAttachment": true,
  "NumReplies": 900,
  "NumMessages": 103,
  "FromAddress": "ducimus",
  "ContactId": 760,
  "ContactName": "Ziemann LLC",
  "OwnedByAssociateId": 795,
  "Language": "quam",
  "Sentiment": 646,
  "SentimentConfidence": 975,
  "SaleId": 789,
  "ProjectId": 100,
  "SaleHeading": "minima",
  "ProjectName": "DuBuque, Howe and Denesik",
  "FormSubmissionId": 173,
  "TicketTypeId": 670,
  "TicketTypeName": "Schroeder, Balistreri and Gaylord",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 24
    }
  }
}
```