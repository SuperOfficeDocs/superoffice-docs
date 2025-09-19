---
title: POST Agents/Ticket/CreateDefaultForTicketType
uid: v1TicketAgent_CreateDefaultForTicketType
generated: true
content_type: reference
---

# POST Agents/Ticket/CreateDefaultForTicketType

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
```

Create default ticket entity for particular TicketType







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType?$select=name,department,category/id
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

TicketTypeId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketTypeId | Integer |  |

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
POST /api/v1/Agents/Ticket/CreateDefaultForTicketType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 58
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 172,
  "Title": "at",
  "CreatedAt": "2014-08-26T03:41:54.2619521+02:00",
  "LastChanged": "2006-07-18T03:41:54.2619521+02:00",
  "ReadByOwner": "2012-12-25T03:41:54.2619521+01:00",
  "ReadByCustomer": "2002-08-11T03:41:54.2619521+02:00",
  "FirstReadByOwner": "2015-01-26T03:41:54.2619521+01:00",
  "FirstReadByUser": "2009-07-11T03:41:54.2619521+02:00",
  "Activate": "2007-06-13T03:41:54.2619521+02:00",
  "ClosedAt": "2016-06-30T03:41:54.2619521+02:00",
  "RepliedAt": "2006-07-07T03:41:54.2619521+02:00",
  "AlertTimeout": "2015-07-26T03:41:54.2619521+02:00",
  "Deadline": "2014-02-25T03:41:54.2619521+01:00",
  "CreatedBy": null,
  "Author": "nemo",
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
      "Position": "similique",
      "PersonId": 858,
      "Mrmrs": "accusamus",
      "Firstname": "Ruthe",
      "Lastname": "Becker",
      "MiddleName": "O'Reilly-Rosenbaum",
      "Title": "fugit",
      "Description": "Multi-channelled web-enabled service-desk",
      "Email": "ulices@reinger.ca",
      "FullName": "Prof. Eliseo Ziemann II",
      "DirectPhone": "(314)806-6867 x34127",
      "FormalName": "Schulist Group",
      "CountryId": 731,
      "ContactId": 392,
      "ContactName": "Conn, Hegmann and Schaden",
      "Retired": 748,
      "Rank": 39,
      "ActiveInterests": 615,
      "ContactDepartment": "",
      "ContactCountryId": 67,
      "ContactOrgNr": "1425029",
      "FaxPhone": "(996)550-9278 x1214",
      "MobilePhone": "1-171-580-2919 x95890",
      "ContactPhone": "(059)183-6576 x087",
      "AssociateName": "Wyman Inc and Sons",
      "AssociateId": 631,
      "UsePersonAddress": true,
      "ContactFax": "quidem",
      "Kanafname": "quod",
      "Kanalname": "natus",
      "Post1": "et",
      "Post2": "vero",
      "Post3": "quas",
      "EmailName": "kristofer.kshlerin@white.us",
      "ContactFullName": "Alanna Fritsch III",
      "ActiveErpLinks": 628,
      "TicketPriorityId": 340,
      "SupportLanguageId": 159,
      "SupportAssociateId": 171,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1043330",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    }
  ],
  "AlertLevel": 619,
  "ConnectId": 406,
  "ReadStatus": "Green",
  "TimeToReply": 406,
  "RealTimeToReply": 877,
  "TimeToClose": 871,
  "RealTimeToClose": 449,
  "TimeSpentInternally": 802,
  "TimeSpentExternally": 579,
  "TimeSpentQueue": 123,
  "RealTimeSpentInternally": 286,
  "RealTimeSpentExternally": 307,
  "RealTimeSpentQueue": 414,
  "TimeSpent": 247,
  "HasAttachment": true,
  "NumReplies": 196,
  "NumMessages": 99,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 529,
      "CreatedAt": "2005-10-01T03:41:54.2775762+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "hic",
      "PersonId": 931,
      "PersonFullName": "Lowell Ledner",
      "ContactId": 479,
      "ContactName": "Conroy LLC",
      "ContactDepartment": "",
      "NumAttachments": 354,
      "EmailHeader": "johnson@marquardtokeefe.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "molestias",
      "Sentiment": 183,
      "SentimentConfidence": 947,
      "CreatedBy": 515,
      "ChangedAt": "2000-09-09T03:41:54.2775762+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 378,
      "Name": "Schamberger, Adams and Nolan",
      "ToolTip": "Cum eaque quod quos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Id": 378,
      "Name": "Schamberger, Adams and Nolan",
      "ToolTip": "Cum eaque quod quos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "Language": "magni",
  "Sentiment": 782,
  "SentimentConfidence": 833,
  "SuggestedCategoryId": 834,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 929,
  "IconHint": "ex",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 449,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "consequuntur",
    "CustomFields2": "ipsam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 645
    }
  }
}
```