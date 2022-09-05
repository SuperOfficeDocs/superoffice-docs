---
title: GET Ticket/{id}/Simple
uid: v1TicketEntity_Simple
---

# GET Ticket/{id}/Simple

```http
GET /api/v1/Ticket/{id}/Simple
```

A simple Ticket object.


This is a simpler, smaller variation of the full TicketEntity. Calls the Ticket agent service GetTicket.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Ticket to return. **Required** |



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

TicketEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity found. |
| 404 | Not Found. |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 724,
  "Title": "ut",
  "CreatedAt": "2001-01-30T11:10:53.6132125+01:00",
  "LastChanged": "2016-09-12T11:10:53.6132125+02:00",
  "ReadByOwner": "2006-12-26T11:10:53.6132125+01:00",
  "ReadByCustomer": "2006-03-10T11:10:53.6132125+01:00",
  "FirstReadByUser": "2013-11-28T11:10:53.6132125+01:00",
  "Activate": "2006-09-03T11:10:53.6132125+02:00",
  "ClosedAt": "1996-06-14T11:10:53.6132125+02:00",
  "RepliedAt": "1998-09-20T11:10:53.6132125+02:00",
  "AlertTimeout": "2014-02-18T11:10:53.6132125+01:00",
  "Deadline": "1999-02-10T11:10:53.6132125+01:00",
  "CreatedBy": 348,
  "CreatedByName": "Boehm-Kub",
  "Author": "vero",
  "OwnedBy": 550,
  "OwnedByName": "Erdman, Pollich and Rice",
  "Category": 946,
  "CategoryName": "VIP Customer",
  "CategoryFullname": "VIP Customer",
  "Slevel": "External",
  "Priority": 787,
  "PriorityName": "Bogan, Harber and Kshlerin",
  "BaseStatus": "Active",
  "TicketStatus": 818,
  "TicketStatusDisplayValue": "aspernatur",
  "Origin": "AutoGenerated",
  "CustId": 638,
  "PersonFirstname": "Jefferey",
  "PersonMiddleName": "Metz-Leffler",
  "PersonLastname": "Jenkins",
  "PersonFullname": "et",
  "AlertLevel": 546,
  "ConnectId": 567,
  "ReadStatus": "Green",
  "TimeToReply": 659,
  "RealTimeToReply": 113,
  "TimeToClose": 950,
  "RealTimeToClose": 161,
  "TimeSpentInternally": 954,
  "TimeSpentExternally": 761,
  "TimeSpentQueue": 585,
  "RealTimeSpentInternally": 228,
  "RealTimeSpentExternally": 86,
  "RealTimeSpentQueue": 941,
  "HasAttachment": false,
  "NumReplies": 666,
  "NumMessages": 123,
  "FromAddress": "perspiciatis",
  "ContactId": 751,
  "ContactName": "Schultz, Bartell and Heathcote",
  "OwnedByAssociateId": 523,
  "Language": "quod",
  "Sentiment": 258,
  "SentimentConfidence": 959,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 748
    }
  }
}
```