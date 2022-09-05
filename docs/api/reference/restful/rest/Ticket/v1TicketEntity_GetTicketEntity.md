---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
---

# GET Ticket/{id}

```http
GET /api/v1/Ticket/{id}
```

Gets a TicketEntity object.


Calls the Ticket agent service GetTicketEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Ticket/{id}?$select=name,department,category/id
GET /api/v1/Ticket/{id}?fk=False
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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Messages | array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | array | An array containing the tags assigned to this request |
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SuggestedCategoryId | int32 | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | string | Suggested category from AI |
| OrigHumanCategoryId | int32 | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | string | Icon representing ticket's state |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 856,
  "Title": "dolorum",
  "CreatedAt": "1998-09-08T11:10:53.5772076+02:00",
  "LastChanged": "2004-10-29T11:10:53.5772076+02:00",
  "ReadByOwner": "1998-06-10T11:10:53.5772076+02:00",
  "ReadByCustomer": "2010-03-12T11:10:53.5772076+01:00",
  "FirstReadByUser": "2007-05-20T11:10:53.5772076+02:00",
  "Activate": "2017-03-06T11:10:53.5772076+01:00",
  "ClosedAt": "2006-09-26T11:10:53.5772076+02:00",
  "RepliedAt": "2021-10-26T11:10:53.5772076+02:00",
  "AlertTimeout": "1996-05-10T11:10:53.5772076+02:00",
  "Deadline": "2016-09-11T11:10:53.5772076+02:00",
  "CreatedBy": null,
  "Author": "in",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "ab",
      "PersonId": 708,
      "Mrmrs": "officiis",
      "Firstname": "Makenzie",
      "Lastname": "Gottlieb",
      "MiddleName": "Crooks-Crona",
      "Title": "asperiores",
      "Description": "Enterprise-wide holistic core",
      "Email": "aliza@leannonnader.info",
      "FullName": "Clemmie Raynor III",
      "DirectPhone": "(125)867-5505",
      "FormalName": "Skiles, Greenholt and Stokes",
      "CountryId": 19,
      "ContactId": 164,
      "ContactName": "Luettgen-Effertz",
      "Retired": 42,
      "Rank": 593,
      "ActiveInterests": 267,
      "ContactDepartment": "",
      "ContactCountryId": 473,
      "ContactOrgNr": "1572437",
      "FaxPhone": "1-230-560-2099 x11018",
      "MobilePhone": "(625)007-1187 x123",
      "ContactPhone": "353-918-5402 x80189",
      "AssociateName": "Towne-Schroeder",
      "AssociateId": 404,
      "UsePersonAddress": false,
      "ContactFax": "odio",
      "Kanafname": "sint",
      "Kanalname": "non",
      "Post1": "et",
      "Post2": "laboriosam",
      "Post3": "eos",
      "EmailName": "remington@dicki.biz",
      "ContactFullName": "Ezequiel Cronin",
      "ActiveErpLinks": 374,
      "TicketPriorityId": 288,
      "SupportLanguageId": 598,
      "SupportAssociateId": 259,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "AlertLevel": 282,
  "ConnectId": 218,
  "ReadStatus": "Green",
  "TimeToReply": 441,
  "RealTimeToReply": 236,
  "TimeToClose": 560,
  "RealTimeToClose": 397,
  "TimeSpentInternally": 422,
  "TimeSpentExternally": 9,
  "TimeSpentQueue": 151,
  "RealTimeSpentInternally": 63,
  "RealTimeSpentExternally": 677,
  "RealTimeSpentQueue": 485,
  "HasAttachment": true,
  "NumReplies": 708,
  "NumMessages": 798,
  "FromAddress": "voluptates",
  "Messages": [
    {
      "TicketMessageId": 964,
      "CreatedAt": "2018-12-22T11:10:53.5812142+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptatem",
      "PersonId": 138,
      "PersonFullName": "Michele Schowalter",
      "ContactId": 261,
      "ContactName": "Gutmann-Ankunding",
      "ContactDepartment": "",
      "NumAttachments": 963,
      "EmailHeader": "jamaal_morissette@fisher.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "incidunt",
      "Sentiment": 607,
      "SentimentConfidence": 415,
      "CreatedBy": 261,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 413,
      "Name": "Block LLC",
      "ToolTip": "Aspernatur cupiditate minima aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    {
      "Id": 413,
      "Name": "Block LLC",
      "ToolTip": "Aspernatur cupiditate minima aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "Language": "esse",
  "Sentiment": 698,
  "SentimentConfidence": 756,
  "SuggestedCategoryId": 349,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 302,
  "IconHint": "soluta",
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 559
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```