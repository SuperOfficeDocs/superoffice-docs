---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

SourceTicketEntityId, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketEntity

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
| CreatedBy | Associate | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 611,
  "TransferMessageIds": [
    710,
    257
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 682,
  "Title": "consequuntur",
  "CreatedAt": "1999-03-05T03:51:28.3652065+01:00",
  "LastChanged": "1996-05-21T03:51:28.3652065+02:00",
  "ReadByOwner": "1996-07-14T03:51:28.3652065+02:00",
  "ReadByCustomer": "2003-01-12T03:51:28.3652065+01:00",
  "FirstReadByOwner": "2014-01-23T03:51:28.3652065+01:00",
  "FirstReadByUser": "2001-02-02T03:51:28.3652065+01:00",
  "Activate": "2012-09-06T03:51:28.3652065+02:00",
  "ClosedAt": "2013-02-28T03:51:28.3652065+01:00",
  "RepliedAt": "2000-08-14T03:51:28.3652065+02:00",
  "AlertTimeout": "2009-12-14T03:51:28.3652065+01:00",
  "Deadline": "2005-02-15T03:51:28.3652065+01:00",
  "CreatedBy": null,
  "Author": "occaecati",
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
      "Position": "officiis",
      "PersonId": 202,
      "Mrmrs": "dolor",
      "Firstname": "Emiliano",
      "Lastname": "Brakus",
      "MiddleName": "Wiegand LLC",
      "Title": "omnis",
      "Description": "Innovative intangible function",
      "Email": "elinor@schroeder.info",
      "FullName": "Ryann Abshire",
      "DirectPhone": "856-578-2156 x684",
      "FormalName": "Gutmann-Frami",
      "CountryId": 718,
      "ContactId": 696,
      "ContactName": "Harvey LLC",
      "Retired": 342,
      "Rank": 144,
      "ActiveInterests": 47,
      "ContactDepartment": "",
      "ContactCountryId": 405,
      "ContactOrgNr": "382235",
      "FaxPhone": "(906)186-3861",
      "MobilePhone": "081-690-3788",
      "ContactPhone": "(580)983-0975",
      "AssociateName": "Farrell-Stehr",
      "AssociateId": 941,
      "UsePersonAddress": false,
      "ContactFax": "ad",
      "Kanafname": "voluptatum",
      "Kanalname": "beatae",
      "Post1": "consequatur",
      "Post2": "id",
      "Post3": "iusto",
      "EmailName": "abe@parkerwalter.uk",
      "ContactFullName": "Zoe Buckridge",
      "ActiveErpLinks": 585,
      "TicketPriorityId": 794,
      "SupportLanguageId": 938,
      "SupportAssociateId": 946,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 221
        }
      }
    }
  ],
  "AlertLevel": 648,
  "ConnectId": 199,
  "ReadStatus": "Green",
  "TimeToReply": 965,
  "RealTimeToReply": 653,
  "TimeToClose": 459,
  "RealTimeToClose": 156,
  "TimeSpentInternally": 448,
  "TimeSpentExternally": 634,
  "TimeSpentQueue": 743,
  "RealTimeSpentInternally": 844,
  "RealTimeSpentExternally": 41,
  "RealTimeSpentQueue": 354,
  "HasAttachment": false,
  "NumReplies": 66,
  "NumMessages": 794,
  "FromAddress": "impedit",
  "Messages": [
    {
      "TicketMessageId": 414,
      "CreatedAt": "2021-03-31T03:51:28.3652065+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloribus",
      "PersonId": 430,
      "PersonFullName": "Princess Mayert",
      "ContactId": 446,
      "ContactName": "Beier, Dare and Rohan",
      "ContactDepartment": "",
      "NumAttachments": 293,
      "EmailHeader": "vernie.boyer@kutch.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 213,
      "SentimentConfidence": 954,
      "CreatedBy": 337,
      "ChangedAt": "2020-02-25T03:51:28.3652065+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 736,
      "Name": "Zemlak, Goldner and Sporer",
      "ToolTip": "Assumenda consequuntur rerum quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    },
    {
      "Id": 736,
      "Name": "Zemlak, Goldner and Sporer",
      "ToolTip": "Assumenda consequuntur rerum quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    }
  ],
  "Language": "in",
  "Sentiment": 369,
  "SentimentConfidence": 251,
  "SuggestedCategoryId": 822,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 304,
  "IconHint": "dolores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "laboriosam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 281
    }
  }
}
```