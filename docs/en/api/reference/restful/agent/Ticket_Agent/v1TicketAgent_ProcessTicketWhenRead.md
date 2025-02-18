---
title: POST Agents/Ticket/ProcessTicketWhenRead
uid: v1TicketAgent_ProcessTicketWhenRead
generated: true
---

# POST Agents/Ticket/ProcessTicketWhenRead

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
```

When a user view/read a ticket, a number of action should be performed: set read status, escalation handling, remove notifications, etc.


Which actions will be performed depends on owner, caller and configuration






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead?$select=name,department,category/id
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

TicketEntityId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketEntityId | Integer |  |

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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
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
| Messages | array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | array | An array containing the tags assigned to this request |
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SuggestedCategoryId | int32 | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | string | Suggested category from AI |
| OrigHumanCategoryId | int32 | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | string | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 166
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 409,
  "Title": "eius",
  "CreatedAt": "2002-03-04T14:32:04.1240734+01:00",
  "LastChanged": "2004-04-12T14:32:04.1240734+02:00",
  "ReadByOwner": "2014-08-27T14:32:04.1240734+02:00",
  "ReadByCustomer": "2006-07-05T14:32:04.1240734+02:00",
  "FirstReadByOwner": "2024-07-06T14:32:04.1240734+02:00",
  "FirstReadByUser": "2011-08-23T14:32:04.1240734+02:00",
  "Activate": "2004-04-20T14:32:04.1240734+02:00",
  "ClosedAt": "2016-01-19T14:32:04.1240734+01:00",
  "RepliedAt": "2003-03-12T14:32:04.1240734+01:00",
  "AlertTimeout": "2014-03-13T14:32:04.1240734+01:00",
  "Deadline": "2003-07-06T14:32:04.1240734+02:00",
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
      "Position": "odit",
      "PersonId": 749,
      "Mrmrs": "facere",
      "Firstname": "Audie",
      "Lastname": "Gislason",
      "MiddleName": "Terry-McGlynn",
      "Title": "est",
      "Description": "Synergized high-level service-desk",
      "Email": "cary@creminhodkiewicz.name",
      "FullName": "Earline Mallie Altenwerth PhD",
      "DirectPhone": "086-236-1587 x7321",
      "FormalName": "Wyman, Abshire and Olson",
      "CountryId": 15,
      "ContactId": 767,
      "ContactName": "Hirthe Inc and Sons",
      "Retired": 155,
      "Rank": 328,
      "ActiveInterests": 483,
      "ContactDepartment": "",
      "ContactCountryId": 275,
      "ContactOrgNr": "902593",
      "FaxPhone": "704.273.1423 x631",
      "MobilePhone": "1-287-676-8655",
      "ContactPhone": "836.672.6222",
      "AssociateName": "Gleichner, Roob and Turcotte",
      "AssociateId": 333,
      "UsePersonAddress": true,
      "ContactFax": "vitae",
      "Kanafname": "sunt",
      "Kanalname": "tenetur",
      "Post1": "laboriosam",
      "Post2": "aspernatur",
      "Post3": "consequuntur",
      "EmailName": "dessie@reichel.ca",
      "ContactFullName": "Madison Jaeden Berge III",
      "ActiveErpLinks": 895,
      "TicketPriorityId": 979,
      "SupportLanguageId": 567,
      "SupportAssociateId": 190,
      "CategoryName": "VIP Customer",
      "PersonNumber": "451021",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 373
        }
      }
    }
  ],
  "AlertLevel": 922,
  "ConnectId": 927,
  "ReadStatus": "Green",
  "TimeToReply": 683,
  "RealTimeToReply": 876,
  "TimeToClose": 3,
  "RealTimeToClose": 970,
  "TimeSpentInternally": 699,
  "TimeSpentExternally": 690,
  "TimeSpentQueue": 850,
  "RealTimeSpentInternally": 680,
  "RealTimeSpentExternally": 401,
  "RealTimeSpentQueue": 473,
  "TimeSpent": 740,
  "HasAttachment": false,
  "NumReplies": 448,
  "NumMessages": 495,
  "FromAddress": "fugit",
  "Messages": [
    {
      "TicketMessageId": 965,
      "CreatedAt": "1998-02-05T14:32:04.1240734+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 221,
      "PersonFullName": "Maurine Kunde",
      "ContactId": 642,
      "ContactName": "Tillman, Frami and Littel",
      "ContactDepartment": "",
      "NumAttachments": 672,
      "EmailHeader": "brennon@carter.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "in",
      "Sentiment": 244,
      "SentimentConfidence": 35,
      "CreatedBy": 883,
      "ChangedAt": "2022-03-28T14:32:04.1240734+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 978,
      "Name": "Cremin Inc and Sons",
      "ToolTip": "Veniam corporis totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    },
    {
      "Id": 978,
      "Name": "Cremin Inc and Sons",
      "ToolTip": "Veniam corporis totam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    }
  ],
  "Language": "fuga",
  "Sentiment": 724,
  "SentimentConfidence": 908,
  "SuggestedCategoryId": 24,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 1001,
  "IconHint": "ipsa",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 140,
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "ab"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "error"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 540
    }
  }
}
```