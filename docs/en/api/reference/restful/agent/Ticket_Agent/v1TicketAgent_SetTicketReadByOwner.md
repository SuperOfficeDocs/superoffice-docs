---
title: POST Agents/Ticket/SetTicketReadByOwner
uid: v1TicketAgent_SetTicketReadByOwner
---

# POST Agents/Ticket/SetTicketReadByOwner

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
```

Set the ReadByOwner status for a ticket.


It will only have an effect if the calling user is the same as the owner of the ticket






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetTicketReadByOwner?$select=name,department,category/id
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

TicketEntityId, ReadStatus, CheckEscalating 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |
| ReadStatus | String |  |
| CheckEscalating | Boolean |  |

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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 927,
  "ReadStatus": "Green",
  "CheckEscalating": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 790,
  "Title": "ipsum",
  "CreatedAt": "2005-01-04T17:37:19.3582419+01:00",
  "LastChanged": "2014-12-07T17:37:19.3582419+01:00",
  "ReadByOwner": "1998-06-13T17:37:19.3582419+02:00",
  "ReadByCustomer": "1998-09-07T17:37:19.3582419+02:00",
  "FirstReadByOwner": "1998-02-26T17:37:19.3582419+01:00",
  "FirstReadByUser": "2009-01-04T17:37:19.3582419+01:00",
  "Activate": "2017-07-02T17:37:19.3582419+02:00",
  "ClosedAt": "2012-05-04T17:37:19.3582419+02:00",
  "RepliedAt": "2016-08-27T17:37:19.3582419+02:00",
  "AlertTimeout": "2004-05-06T17:37:19.3582419+02:00",
  "Deadline": "2016-12-20T17:37:19.3582419+01:00",
  "CreatedBy": null,
  "Author": "non",
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
      "Position": "quia",
      "PersonId": 538,
      "Mrmrs": "consequatur",
      "Firstname": "Earnest",
      "Lastname": "Tromp",
      "MiddleName": "Pouros, Schamberger and Welch",
      "Title": "tempora",
      "Description": "Cloned tertiary portal",
      "Email": "graciela@schadenweber.biz",
      "FullName": "Ulices Streich",
      "DirectPhone": "328.603.4936",
      "FormalName": "Howe-Pagac",
      "CountryId": 855,
      "ContactId": 230,
      "ContactName": "Moen-Raynor",
      "Retired": 555,
      "Rank": 124,
      "ActiveInterests": 519,
      "ContactDepartment": "",
      "ContactCountryId": 934,
      "ContactOrgNr": "1359478",
      "FaxPhone": "1-262-036-0322",
      "MobilePhone": "(996)137-6023 x2661",
      "ContactPhone": "415-424-7446 x037",
      "AssociateName": "Frami-Purdy",
      "AssociateId": 51,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "explicabo",
      "Kanalname": "quod",
      "Post1": "enim",
      "Post2": "molestias",
      "Post3": "nihil",
      "EmailName": "ken_doyle@wilkinson.name",
      "ContactFullName": "Dr. Cesar Margarete Friesen I",
      "ActiveErpLinks": 637,
      "TicketPriorityId": 6,
      "SupportLanguageId": 418,
      "SupportAssociateId": 348,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    }
  ],
  "AlertLevel": 180,
  "ConnectId": 703,
  "ReadStatus": "Green",
  "TimeToReply": 105,
  "RealTimeToReply": 71,
  "TimeToClose": 593,
  "RealTimeToClose": 78,
  "TimeSpentInternally": 919,
  "TimeSpentExternally": 440,
  "TimeSpentQueue": 813,
  "RealTimeSpentInternally": 632,
  "RealTimeSpentExternally": 216,
  "RealTimeSpentQueue": 315,
  "HasAttachment": true,
  "NumReplies": 368,
  "NumMessages": 126,
  "FromAddress": "earum",
  "Messages": [
    {
      "TicketMessageId": 554,
      "CreatedAt": "2008-10-29T17:37:19.3632419+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 183,
      "PersonFullName": "Collin Romaguera III",
      "ContactId": 864,
      "ContactName": "Beahan-Haley",
      "ContactDepartment": "",
      "NumAttachments": 254,
      "EmailHeader": "jabari@hahnsawayn.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "repellat",
      "Sentiment": 527,
      "SentimentConfidence": 114,
      "CreatedBy": 711,
      "ChangedAt": "2000-07-01T17:37:19.3632419+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 366,
      "Name": "Langworth LLC",
      "ToolTip": "Exercitationem et delectus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "Id": 366,
      "Name": "Langworth LLC",
      "ToolTip": "Exercitationem et delectus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "Language": "minus",
  "Sentiment": 428,
  "SentimentConfidence": 527,
  "SuggestedCategoryId": 779,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 487,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 171
    }
  }
}
```