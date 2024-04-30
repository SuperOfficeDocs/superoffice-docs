---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
generated: true
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
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

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |

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
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 972
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 184,
  "Title": "quis",
  "CreatedAt": "2016-03-12T11:44:34.7750774+01:00",
  "LastChanged": "2006-04-26T11:44:34.7750774+02:00",
  "ReadByOwner": "2009-09-02T11:44:34.7750774+02:00",
  "ReadByCustomer": "2012-05-02T11:44:34.7750774+02:00",
  "FirstReadByOwner": "2002-03-04T11:44:34.7750774+01:00",
  "FirstReadByUser": "2000-05-27T11:44:34.7750774+02:00",
  "Activate": "2010-11-17T11:44:34.7750774+01:00",
  "ClosedAt": "2023-06-14T11:44:34.7750774+02:00",
  "RepliedAt": "2005-04-18T11:44:34.7750774+02:00",
  "AlertTimeout": "2024-02-13T11:44:34.7750774+01:00",
  "Deadline": "2019-01-08T11:44:34.7750774+01:00",
  "CreatedBy": null,
  "Author": "fuga",
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
      "Position": "ea",
      "PersonId": 573,
      "Mrmrs": "rem",
      "Firstname": "Isaiah",
      "Lastname": "Wintheiser",
      "MiddleName": "Dibbert, Gutmann and Gottlieb",
      "Title": "assumenda",
      "Description": "Face to face tertiary archive",
      "Email": "claire@runte.ca",
      "FullName": "Miss Kobe Haag MD",
      "DirectPhone": "939.810.1882 x3382",
      "FormalName": "Langworth, Kohler and Beer",
      "CountryId": 848,
      "ContactId": 872,
      "ContactName": "Schulist, Hilll and Beier",
      "Retired": 684,
      "Rank": 933,
      "ActiveInterests": 786,
      "ContactDepartment": "",
      "ContactCountryId": 420,
      "ContactOrgNr": "941086",
      "FaxPhone": "(527)667-9735",
      "MobilePhone": "004.469.4439",
      "ContactPhone": "(744)089-5058",
      "AssociateName": "Spencer-Hansen",
      "AssociateId": 997,
      "UsePersonAddress": false,
      "ContactFax": "praesentium",
      "Kanafname": "qui",
      "Kanalname": "iure",
      "Post1": "sunt",
      "Post2": "dolore",
      "Post3": "et",
      "EmailName": "courtney_quitzon@veumarmstrong.com",
      "ContactFullName": "Dortha Dickens",
      "ActiveErpLinks": 149,
      "TicketPriorityId": 451,
      "SupportLanguageId": 600,
      "SupportAssociateId": 95,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "AlertLevel": 651,
  "ConnectId": 461,
  "ReadStatus": "Green",
  "TimeToReply": 342,
  "RealTimeToReply": 753,
  "TimeToClose": 70,
  "RealTimeToClose": 864,
  "TimeSpentInternally": 259,
  "TimeSpentExternally": 860,
  "TimeSpentQueue": 307,
  "RealTimeSpentInternally": 963,
  "RealTimeSpentExternally": 457,
  "RealTimeSpentQueue": 103,
  "TimeSpent": 817,
  "HasAttachment": false,
  "NumReplies": 809,
  "NumMessages": 746,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 163,
      "CreatedAt": "1997-03-06T11:44:34.7750774+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 856,
      "PersonFullName": "Ms. Nyah Ratke Jr.",
      "ContactId": 266,
      "ContactName": "Dicki-Padberg",
      "ContactDepartment": "",
      "NumAttachments": 322,
      "EmailHeader": "eunice_swaniawski@hahn.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 542,
      "SentimentConfidence": 720,
      "CreatedBy": 971,
      "ChangedAt": "2023-12-25T11:44:34.7750774+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 608,
      "Name": "Collins, Maggio and Wilkinson",
      "ToolTip": "Sapiente perspiciatis itaque architecto neque et aspernatur dolore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    },
    {
      "Id": 608,
      "Name": "Collins, Maggio and Wilkinson",
      "ToolTip": "Sapiente perspiciatis itaque architecto neque et aspernatur dolore.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "Language": "facilis",
  "Sentiment": 601,
  "SentimentConfidence": 709,
  "SuggestedCategoryId": 266,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 403,
  "IconHint": "placeat",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 529,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 768
    }
  }
}
```