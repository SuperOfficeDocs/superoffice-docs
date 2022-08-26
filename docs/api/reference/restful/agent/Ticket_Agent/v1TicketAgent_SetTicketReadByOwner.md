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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 708,
  "ReadStatus": "Green",
  "CheckEscalating": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 846,
  "Title": "impedit",
  "CreatedAt": "2004-09-24T11:10:28.2686934+02:00",
  "LastChanged": "2010-08-11T11:10:28.2686934+02:00",
  "ReadByOwner": "2019-03-18T11:10:28.2686934+01:00",
  "ReadByCustomer": "2019-06-28T11:10:28.2686934+02:00",
  "FirstReadByUser": "2003-03-08T11:10:28.2686934+01:00",
  "Activate": "2021-02-11T11:10:28.2686934+01:00",
  "ClosedAt": "1996-08-25T11:10:28.2686934+02:00",
  "RepliedAt": "1999-03-10T11:10:28.2686934+01:00",
  "AlertTimeout": "2004-03-15T11:10:28.2686934+01:00",
  "Deadline": "2017-07-27T11:10:28.2686934+02:00",
  "CreatedBy": null,
  "Author": "assumenda",
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
      "Position": "officia",
      "PersonId": 439,
      "Mrmrs": "labore",
      "Firstname": "Jerod",
      "Lastname": "Haley",
      "MiddleName": "Beer, Skiles and Smitham",
      "Title": "perspiciatis",
      "Description": "Open-architected hybrid implementation",
      "Email": "kendrick@volkmanheathcote.us",
      "FullName": "Porter Hilll",
      "DirectPhone": "639-611-2887",
      "FormalName": "Reinger Group",
      "CountryId": 147,
      "ContactId": 903,
      "ContactName": "Langworth, Goodwin and Treutel",
      "Retired": 919,
      "Rank": 313,
      "ActiveInterests": 793,
      "ContactDepartment": "",
      "ContactCountryId": 987,
      "ContactOrgNr": "600728",
      "FaxPhone": "384.965.7041 x8447",
      "MobilePhone": "526-021-9804 x0219",
      "ContactPhone": "605-983-9884",
      "AssociateName": "Zieme-Davis",
      "AssociateId": 951,
      "UsePersonAddress": true,
      "ContactFax": "recusandae",
      "Kanafname": "mollitia",
      "Kanalname": "tenetur",
      "Post1": "mollitia",
      "Post2": "iste",
      "Post3": "rerum",
      "EmailName": "liam@harrisbosco.ca",
      "ContactFullName": "Miss Isaias Ruecker",
      "ActiveErpLinks": 767,
      "TicketPriorityId": 184,
      "SupportLanguageId": 239,
      "SupportAssociateId": 498,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 593
        }
      }
    }
  ],
  "AlertLevel": 20,
  "ConnectId": 740,
  "ReadStatus": "Green",
  "TimeToReply": 805,
  "RealTimeToReply": 93,
  "TimeToClose": 106,
  "RealTimeToClose": 641,
  "TimeSpentInternally": 387,
  "TimeSpentExternally": 408,
  "TimeSpentQueue": 880,
  "RealTimeSpentInternally": 910,
  "RealTimeSpentExternally": 81,
  "RealTimeSpentQueue": 464,
  "HasAttachment": false,
  "NumReplies": 422,
  "NumMessages": 840,
  "FromAddress": "veritatis",
  "Messages": [
    {
      "TicketMessageId": 688,
      "CreatedAt": "2007-08-08T11:10:28.2782212+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "iure",
      "PersonId": 675,
      "PersonFullName": "Kira Samara Rutherford Sr.",
      "ContactId": 321,
      "ContactName": "Bechtelar-Gleichner",
      "ContactDepartment": "",
      "NumAttachments": 944,
      "EmailHeader": "bryana@prosaccoschuster.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sunt",
      "Sentiment": 113,
      "SentimentConfidence": 601,
      "CreatedBy": 743,
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
  "Tags": [
    {
      "Id": 118,
      "Name": "Bruen-Gutkowski",
      "ToolTip": "Corrupti fugit itaque porro adipisci quis odio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "Id": 118,
      "Name": "Bruen-Gutkowski",
      "ToolTip": "Corrupti fugit itaque porro adipisci quis odio.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Language": "voluptas",
  "Sentiment": 761,
  "SentimentConfidence": 633,
  "SuggestedCategoryId": 978,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 102,
  "IconHint": "ut",
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "harum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 651
    }
  }
}
```