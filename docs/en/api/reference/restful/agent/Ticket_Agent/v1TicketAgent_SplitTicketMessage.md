---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
---

# POST Agents/Ticket/SplitTicketMessage

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage
```

Create new ticket and move/copy data from existing ticket in addition update old message and save new message in a single request.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

SourceTicketMessage, NewTicketEntity, NewTicketMessage, TransferAttachmentsIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketMessage |  | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketEntity |  | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketMessage |  | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| TransferAttachmentsIds | array |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
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

## Sample request

```http!
POST /api/v1/Agents/Ticket/SplitTicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceTicketMessage": null,
  "NewTicketEntity": null,
  "NewTicketMessage": null,
  "TransferAttachmentsIds": [
    282,
    287
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 505,
  "Title": "vel",
  "CreatedAt": "2003-03-19T02:49:45.5622206+01:00",
  "LastChanged": "2017-06-22T02:49:45.5622206+02:00",
  "ReadByOwner": "2011-12-21T02:49:45.5622206+01:00",
  "ReadByCustomer": "2021-12-08T02:49:45.5622206+01:00",
  "FirstReadByOwner": "2013-09-29T02:49:45.5622206+02:00",
  "FirstReadByUser": "2021-07-19T02:49:45.5622206+02:00",
  "Activate": "2005-04-10T02:49:45.5622206+02:00",
  "ClosedAt": "2008-02-22T02:49:45.5622206+01:00",
  "RepliedAt": "2016-10-04T02:49:45.5622206+02:00",
  "AlertTimeout": "1997-12-30T02:49:45.5622206+01:00",
  "Deadline": "2016-01-13T02:49:45.5622206+01:00",
  "CreatedBy": null,
  "Author": "sapiente",
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
      "PersonId": 841,
      "Mrmrs": "exercitationem",
      "Firstname": "Jedidiah",
      "Lastname": "Pollich",
      "MiddleName": "O'Keefe-Heller",
      "Title": "qui",
      "Description": "Programmable executive info-mediaries",
      "Email": "hailee_trantow@macejkovichoppe.com",
      "FullName": "Salvatore Borer",
      "DirectPhone": "761-634-9491 x61606",
      "FormalName": "Bahringer, Doyle and Lakin",
      "CountryId": 116,
      "ContactId": 573,
      "ContactName": "Kshlerin-Hermiston",
      "Retired": 609,
      "Rank": 242,
      "ActiveInterests": 106,
      "ContactDepartment": "",
      "ContactCountryId": 659,
      "ContactOrgNr": "962492",
      "FaxPhone": "(160)130-4371",
      "MobilePhone": "354-528-3357 x384",
      "ContactPhone": "1-615-347-5596",
      "AssociateName": "Beatty-Upton",
      "AssociateId": 742,
      "UsePersonAddress": true,
      "ContactFax": "officiis",
      "Kanafname": "maiores",
      "Kanalname": "ratione",
      "Post1": "magni",
      "Post2": "fuga",
      "Post3": "sed",
      "EmailName": "jacinthe@croninhermann.com",
      "ContactFullName": "Hubert Grady",
      "ActiveErpLinks": 870,
      "TicketPriorityId": 828,
      "SupportLanguageId": 209,
      "SupportAssociateId": 964,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    }
  ],
  "AlertLevel": 203,
  "ConnectId": 693,
  "ReadStatus": "Green",
  "TimeToReply": 86,
  "RealTimeToReply": 345,
  "TimeToClose": 833,
  "RealTimeToClose": 930,
  "TimeSpentInternally": 934,
  "TimeSpentExternally": 441,
  "TimeSpentQueue": 167,
  "RealTimeSpentInternally": 236,
  "RealTimeSpentExternally": 552,
  "RealTimeSpentQueue": 731,
  "HasAttachment": false,
  "NumReplies": 674,
  "NumMessages": 641,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 368,
      "CreatedAt": "2005-12-15T02:49:45.5622206+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptatibus",
      "PersonId": 53,
      "PersonFullName": "Miss Hollie Patsy Balistreri",
      "ContactId": 367,
      "ContactName": "Collier-Rice",
      "ContactDepartment": "",
      "NumAttachments": 301,
      "EmailHeader": "ila@reichertlittel.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptate",
      "Sentiment": 360,
      "SentimentConfidence": 458,
      "CreatedBy": 348,
      "ChangedAt": "2005-04-25T02:49:45.5622206+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 343,
      "Name": "Koepp-O'Reilly",
      "ToolTip": "Deserunt odit eveniet maxime enim.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 609
        }
      }
    },
    {
      "Id": 343,
      "Name": "Koepp-O'Reilly",
      "ToolTip": "Deserunt odit eveniet maxime enim.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 609
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 213,
  "SentimentConfidence": 342,
  "SuggestedCategoryId": 757,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 450,
  "IconHint": "qui",
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 785
    }
  }
}
```