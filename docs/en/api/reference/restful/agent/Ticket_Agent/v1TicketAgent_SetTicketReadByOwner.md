---
title: POST Agents/Ticket/SetTicketReadByOwner
uid: v1TicketAgent_SetTicketReadByOwner
generated: true
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 190,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 810,
  "Title": "autem",
  "CreatedAt": "1998-09-29T03:31:27.4030353+02:00",
  "LastChanged": "2013-04-24T03:31:27.4030353+02:00",
  "ReadByOwner": "2018-08-05T03:31:27.4030353+02:00",
  "ReadByCustomer": "2011-03-10T03:31:27.4030353+01:00",
  "FirstReadByOwner": "2022-05-12T03:31:27.4030353+02:00",
  "FirstReadByUser": "2007-06-28T03:31:27.4030353+02:00",
  "Activate": "2011-12-24T03:31:27.4030353+01:00",
  "ClosedAt": "2000-01-13T03:31:27.4030353+01:00",
  "RepliedAt": "2016-09-22T03:31:27.4030353+02:00",
  "AlertTimeout": "2021-03-22T03:31:27.4030353+01:00",
  "Deadline": "2013-05-17T03:31:27.4030353+02:00",
  "CreatedBy": null,
  "Author": "nulla",
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
      "Position": "quas",
      "PersonId": 412,
      "Mrmrs": "ab",
      "Firstname": "Dustin",
      "Lastname": "Jenkins",
      "MiddleName": "Murazik-Carroll",
      "Title": "expedita",
      "Description": "Customer-focused neutral moderator",
      "Email": "marisa.toy@hermiston.name",
      "FullName": "Ms. Myah Howe",
      "DirectPhone": "(238)721-4164 x36678",
      "FormalName": "Nienow LLC",
      "CountryId": 254,
      "ContactId": 593,
      "ContactName": "Schaefer-Kuvalis",
      "Retired": 480,
      "Rank": 775,
      "ActiveInterests": 360,
      "ContactDepartment": "",
      "ContactCountryId": 591,
      "ContactOrgNr": "1123600",
      "FaxPhone": "1-374-926-8088 x8318",
      "MobilePhone": "(331)415-6076 x95394",
      "ContactPhone": "1-968-746-4947",
      "AssociateName": "Cormier, Bahringer and Yost",
      "AssociateId": 172,
      "UsePersonAddress": false,
      "ContactFax": "occaecati",
      "Kanafname": "minus",
      "Kanalname": "consequatur",
      "Post1": "placeat",
      "Post2": "mollitia",
      "Post3": "et",
      "EmailName": "maxwell@stokes.info",
      "ContactFullName": "Brionna Pacocha",
      "ActiveErpLinks": 353,
      "TicketPriorityId": 471,
      "SupportLanguageId": 757,
      "SupportAssociateId": 455,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "AlertLevel": 599,
  "ConnectId": 50,
  "ReadStatus": "Green",
  "TimeToReply": 805,
  "RealTimeToReply": 999,
  "TimeToClose": 297,
  "RealTimeToClose": 517,
  "TimeSpentInternally": 960,
  "TimeSpentExternally": 668,
  "TimeSpentQueue": 336,
  "RealTimeSpentInternally": 942,
  "RealTimeSpentExternally": 748,
  "RealTimeSpentQueue": 986,
  "HasAttachment": true,
  "NumReplies": 908,
  "NumMessages": 578,
  "FromAddress": "molestiae",
  "Messages": [
    {
      "TicketMessageId": 97,
      "CreatedAt": "2004-11-25T03:31:27.4030353+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "omnis",
      "PersonId": 840,
      "PersonFullName": "Chase Wiza Sr.",
      "ContactId": 961,
      "ContactName": "Wuckert Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 871,
      "EmailHeader": "adriana_macejkovic@ziemann.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 635,
      "SentimentConfidence": 883,
      "CreatedBy": 482,
      "ChangedAt": "2022-09-13T03:31:27.4030353+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 705,
      "Name": "Yundt-Langosh",
      "ToolTip": "Quibusdam rerum debitis et eaque explicabo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 183
        }
      }
    },
    {
      "Id": 705,
      "Name": "Yundt-Langosh",
      "ToolTip": "Quibusdam rerum debitis et eaque explicabo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 183
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 770,
  "SentimentConfidence": 838,
  "SuggestedCategoryId": 834,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 802,
  "IconHint": "deleniti",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 810
    }
  }
}
```