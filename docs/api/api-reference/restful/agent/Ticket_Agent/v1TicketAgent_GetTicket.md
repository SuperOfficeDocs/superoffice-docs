---
title: POST Agents/Ticket/GetTicket
id: v1TicketAgent_GetTicket
---

# POST Agents/Ticket/GetTicket

```http
POST /api/v1/Agents/Ticket/GetTicket
```

Gets a Ticket object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicket?ticketId=390
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


## Response: object

The ticket carrier is used for representing a service request.



Carrier object for Ticket.
Services for the Ticket Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted |
| TicketStatus | int32 | User defined ticket status |
| Origin | string | What is the origin of this ticket |
| CustId | int32 | The reference to the customer. NULL or -1 if ticket is not connected to customer. |
| CustFirstname | string | First name |
| CustMiddleName | string | Middle name or 'van' etc. |
| CustLastname | string | Last name |
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
| CustFullname | string | Get the full name for the primary customer |
| TicketStatusDisplayValue | string | Get the display name of the ticket status. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/GetTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 294,
  "Title": "excepturi",
  "CreatedAt": "2015-12-06T16:48:30.8239346+01:00",
  "LastChanged": "2007-06-15T16:48:30.8239346+02:00",
  "ReadByOwner": "2018-06-22T16:48:30.8239346+02:00",
  "ReadByCustomer": "1994-01-02T16:48:30.8239346+01:00",
  "FirstReadByUser": "2018-02-26T16:48:30.8239346+01:00",
  "Activate": "2001-03-20T16:48:30.8239346+01:00",
  "ClosedAt": "2015-01-21T16:48:30.8239346+01:00",
  "RepliedAt": "2018-09-25T16:48:30.8239346+02:00",
  "AlertTimeout": "1995-03-13T16:48:30.8239346+01:00",
  "Deadline": "1996-06-06T16:48:30.8239346+02:00",
  "CreatedBy": 814,
  "CreatedByName": "Feeney, Schaden and Doyle",
  "Author": "reprehenderit",
  "OwnedBy": 210,
  "OwnedByName": "Wyman, Purdy and Zboncak",
  "Category": 737,
  "CategoryName": "VIP Customer",
  "CategoryFullname": "VIP Customer",
  "Slevel": "External",
  "Priority": 892,
  "BaseStatus": "Active",
  "TicketStatus": 448,
  "Origin": "AutoGenerated",
  "CustId": 175,
  "CustFirstname": "Dana",
  "CustMiddleName": "Greenfelder Group",
  "CustLastname": "Bayer",
  "AlertLevel": 206,
  "ConnectId": 175,
  "ReadStatus": "Green",
  "TimeToReply": 64,
  "RealTimeToReply": 849,
  "TimeToClose": 317,
  "RealTimeToClose": 623,
  "TimeSpentInternally": 356,
  "TimeSpentExternally": 115,
  "TimeSpentQueue": 818,
  "RealTimeSpentInternally": 143,
  "RealTimeSpentExternally": 270,
  "RealTimeSpentQueue": 794,
  "HasAttachment": true,
  "NumReplies": 411,
  "NumMessages": 832,
  "FromAddress": "id",
  "CustFullname": "et",
  "TicketStatusDisplayValue": "sed",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 91
    }
  }
}
```