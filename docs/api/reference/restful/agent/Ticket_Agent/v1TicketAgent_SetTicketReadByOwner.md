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
| TicketEntityId | int32 |  |
| ReadStatus | string |  |
| CheckEscalating | bool |  |


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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 465,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 77,
  "Title": "illo",
  "CreatedAt": "2015-03-24T02:49:45.5153435+01:00",
  "LastChanged": "2003-04-05T02:49:45.5153435+02:00",
  "ReadByOwner": "2019-08-29T02:49:45.5153435+02:00",
  "ReadByCustomer": "1996-10-22T02:49:45.5153435+02:00",
  "FirstReadByOwner": "2006-04-10T02:49:45.5153435+02:00",
  "FirstReadByUser": "2005-01-02T02:49:45.5153435+01:00",
  "Activate": "1999-10-16T02:49:45.5153435+02:00",
  "ClosedAt": "2000-10-28T02:49:45.5153435+02:00",
  "RepliedAt": "2015-08-07T02:49:45.5153435+02:00",
  "AlertTimeout": "2021-07-11T02:49:45.5153435+02:00",
  "Deadline": "2022-06-02T02:49:45.5153435+02:00",
  "CreatedBy": null,
  "Author": "asperiores",
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
      "PersonId": 651,
      "Mrmrs": "vero",
      "Firstname": "Sibyl",
      "Lastname": "Macejkovic",
      "MiddleName": "Collins-King",
      "Title": "dolore",
      "Description": "Upgradable global info-mediaries",
      "Email": "evalyn.pollich@beermertz.uk",
      "FullName": "Lambert Simonis",
      "DirectPhone": "1-278-808-4940 x611",
      "FormalName": "Heaney Inc and Sons",
      "CountryId": 539,
      "ContactId": 709,
      "ContactName": "Nikolaus-Wintheiser",
      "Retired": 620,
      "Rank": 255,
      "ActiveInterests": 399,
      "ContactDepartment": "",
      "ContactCountryId": 692,
      "ContactOrgNr": "305465",
      "FaxPhone": "550-233-0083",
      "MobilePhone": "530.704.6769",
      "ContactPhone": "454.795.0575 x547",
      "AssociateName": "Keeling Inc and Sons",
      "AssociateId": 513,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "qui",
      "Kanalname": "cumque",
      "Post1": "consequuntur",
      "Post2": "ut",
      "Post3": "provident",
      "EmailName": "deshaun.mcdermott@pouros.name",
      "ContactFullName": "Miss Dorcas Delilah Aufderhar II",
      "ActiveErpLinks": 386,
      "TicketPriorityId": 346,
      "SupportLanguageId": 39,
      "SupportAssociateId": 917,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    }
  ],
  "AlertLevel": 522,
  "ConnectId": 613,
  "ReadStatus": "Green",
  "TimeToReply": 55,
  "RealTimeToReply": 516,
  "TimeToClose": 380,
  "RealTimeToClose": 923,
  "TimeSpentInternally": 233,
  "TimeSpentExternally": 521,
  "TimeSpentQueue": 47,
  "RealTimeSpentInternally": 973,
  "RealTimeSpentExternally": 776,
  "RealTimeSpentQueue": 790,
  "HasAttachment": false,
  "NumReplies": 190,
  "NumMessages": 494,
  "FromAddress": "aliquam",
  "Messages": [
    {
      "TicketMessageId": 322,
      "CreatedAt": "1997-09-04T02:49:45.5153435+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quod",
      "PersonId": 983,
      "PersonFullName": "Reyes Daniel",
      "ContactId": 996,
      "ContactName": "Schimmel-Romaguera",
      "ContactDepartment": "",
      "NumAttachments": 380,
      "EmailHeader": "kenna_lynch@larson.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 203,
      "SentimentConfidence": 79,
      "CreatedBy": 911,
      "ChangedAt": "2006-08-31T02:49:45.5309702+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 35,
      "Name": "Reilly Inc and Sons",
      "ToolTip": "Blanditiis maiores quis et sit tempore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    },
    {
      "Id": 35,
      "Name": "Reilly Inc and Sons",
      "ToolTip": "Blanditiis maiores quis et sit tempore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    }
  ],
  "Language": "consequatur",
  "Sentiment": 824,
  "SentimentConfidence": 766,
  "SuggestedCategoryId": 460,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 61,
  "IconHint": "sed",
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 329
    }
  }
}
```