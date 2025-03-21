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
POST /api/v1/Agents/Ticket/SetTicketReadByOwner
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 813,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 191,
  "Title": "quia",
  "CreatedAt": "2020-03-07T14:13:41.4695613+01:00",
  "LastChanged": "2021-05-28T14:13:41.4695613+02:00",
  "ReadByOwner": "1997-10-27T14:13:41.4695613+01:00",
  "ReadByCustomer": "2015-06-17T14:13:41.4695613+02:00",
  "FirstReadByOwner": "2023-08-22T14:13:41.4695613+02:00",
  "FirstReadByUser": "2010-06-29T14:13:41.4695613+02:00",
  "Activate": "2011-06-06T14:13:41.4695613+02:00",
  "ClosedAt": "2014-12-24T14:13:41.4695613+01:00",
  "RepliedAt": "2014-10-16T14:13:41.4695613+02:00",
  "AlertTimeout": "2019-05-08T14:13:41.4695613+02:00",
  "Deadline": "2006-04-26T14:13:41.4695613+02:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "Position": "aliquam",
      "PersonId": 338,
      "Mrmrs": "ad",
      "Firstname": "Margret",
      "Lastname": "Jacobi",
      "MiddleName": "Kassulke-Tremblay",
      "Title": "fugiat",
      "Description": "Business-focused zero defect implementation",
      "Email": "dock@millerdavis.name",
      "FullName": "Trevor Leannon",
      "DirectPhone": "779.295.4396 x23960",
      "FormalName": "Gutkowski, Bahringer and Blick",
      "CountryId": 23,
      "ContactId": 674,
      "ContactName": "Feest Group",
      "Retired": 829,
      "Rank": 669,
      "ActiveInterests": 223,
      "ContactDepartment": "",
      "ContactCountryId": 625,
      "ContactOrgNr": "1216308",
      "FaxPhone": "1-257-531-0880 x209",
      "MobilePhone": "424-842-5886",
      "ContactPhone": "366-675-6556",
      "AssociateName": "Marquardt, Cartwright and Walter",
      "AssociateId": 171,
      "UsePersonAddress": true,
      "ContactFax": "doloremque",
      "Kanafname": "harum",
      "Kanalname": "consectetur",
      "Post1": "sapiente",
      "Post2": "est",
      "Post3": "molestiae",
      "EmailName": "vicenta@schulistdavis.biz",
      "ContactFullName": "Vernice Deckow",
      "ActiveErpLinks": 208,
      "TicketPriorityId": 412,
      "SupportLanguageId": 105,
      "SupportAssociateId": 737,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1521566",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    }
  ],
  "AlertLevel": 416,
  "ConnectId": 367,
  "ReadStatus": "Green",
  "TimeToReply": 968,
  "RealTimeToReply": 615,
  "TimeToClose": 494,
  "RealTimeToClose": 765,
  "TimeSpentInternally": 879,
  "TimeSpentExternally": 475,
  "TimeSpentQueue": 705,
  "RealTimeSpentInternally": 584,
  "RealTimeSpentExternally": 1001,
  "RealTimeSpentQueue": 551,
  "TimeSpent": 663,
  "HasAttachment": false,
  "NumReplies": 491,
  "NumMessages": 88,
  "FromAddress": "ad",
  "Messages": [
    {
      "TicketMessageId": 210,
      "CreatedAt": "2006-01-10T14:13:41.4851827+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quos",
      "PersonId": 908,
      "PersonFullName": "Dr. Reggie O'Kon",
      "ContactId": 333,
      "ContactName": "Okuneva, Bogan and Brown",
      "ContactDepartment": "",
      "NumAttachments": 782,
      "EmailHeader": "isabelle@lebsackwuckert.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 749,
      "SentimentConfidence": 772,
      "CreatedBy": 522,
      "ChangedAt": "2008-09-26T14:13:41.4851827+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 528,
      "Name": "Purdy-Kihn",
      "ToolTip": "Nesciunt atque dicta sapiente sequi minus sit eius.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    },
    {
      "Id": 528,
      "Name": "Purdy-Kihn",
      "ToolTip": "Nesciunt atque dicta sapiente sequi minus sit eius.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "Language": "id",
  "Sentiment": 919,
  "SentimentConfidence": 655,
  "SuggestedCategoryId": 465,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 396,
  "IconHint": "officiis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 479,
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 36
    }
  }
}
```