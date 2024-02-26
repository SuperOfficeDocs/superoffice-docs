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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 399,
  "ReadStatus": "Green",
  "CheckEscalating": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 599,
  "Title": "veritatis",
  "CreatedAt": "2016-05-08T10:30:24.8423361+02:00",
  "LastChanged": "2002-09-07T10:30:24.8423361+02:00",
  "ReadByOwner": "2012-12-14T10:30:24.8423361+01:00",
  "ReadByCustomer": "2004-12-10T10:30:24.8423361+01:00",
  "FirstReadByOwner": "1999-07-15T10:30:24.8423361+02:00",
  "FirstReadByUser": "2007-02-13T10:30:24.8423361+01:00",
  "Activate": "2004-07-17T10:30:24.8423361+02:00",
  "ClosedAt": "2001-02-27T10:30:24.8423361+01:00",
  "RepliedAt": "2013-06-03T10:30:24.8423361+02:00",
  "AlertTimeout": "1999-05-11T10:30:24.8423361+02:00",
  "Deadline": "2007-03-09T10:30:24.8423361+01:00",
  "CreatedBy": null,
  "Author": "facere",
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
      "PersonId": 751,
      "Mrmrs": "adipisci",
      "Firstname": "Cordell",
      "Lastname": "Hettinger",
      "MiddleName": "Farrell-Wolff",
      "Title": "pariatur",
      "Description": "Sharable contextually-based support",
      "Email": "florencio@rempel.biz",
      "FullName": "Aurelia Jacobson",
      "DirectPhone": "(582)319-8344 x269",
      "FormalName": "McCullough-Bechtelar",
      "CountryId": 805,
      "ContactId": 768,
      "ContactName": "Strosin, Durgan and Kub",
      "Retired": 437,
      "Rank": 187,
      "ActiveInterests": 773,
      "ContactDepartment": "",
      "ContactCountryId": 188,
      "ContactOrgNr": "1270878",
      "FaxPhone": "1-104-589-6444 x334",
      "MobilePhone": "295.607.2867",
      "ContactPhone": "044.498.1082",
      "AssociateName": "Nitzsche-Zemlak",
      "AssociateId": 346,
      "UsePersonAddress": true,
      "ContactFax": "atque",
      "Kanafname": "ipsa",
      "Kanalname": "odio",
      "Post1": "est",
      "Post2": "velit",
      "Post3": "modi",
      "EmailName": "serenity.moore@kuphalconroy.info",
      "ContactFullName": "Trent Grimes",
      "ActiveErpLinks": 922,
      "TicketPriorityId": 280,
      "SupportLanguageId": 962,
      "SupportAssociateId": 320,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    }
  ],
  "AlertLevel": 823,
  "ConnectId": 11,
  "ReadStatus": "Green",
  "TimeToReply": 116,
  "RealTimeToReply": 548,
  "TimeToClose": 824,
  "RealTimeToClose": 265,
  "TimeSpentInternally": 101,
  "TimeSpentExternally": 759,
  "TimeSpentQueue": 418,
  "RealTimeSpentInternally": 968,
  "RealTimeSpentExternally": 766,
  "RealTimeSpentQueue": 971,
  "TimeSpent": 41,
  "HasAttachment": false,
  "NumReplies": 281,
  "NumMessages": 42,
  "FromAddress": "quidem",
  "Messages": [
    {
      "TicketMessageId": 704,
      "CreatedAt": "2018-12-01T10:30:24.8423361+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 617,
      "PersonFullName": "Tanner Hayes",
      "ContactId": 706,
      "ContactName": "Ondricka, Kling and Gutkowski",
      "ContactDepartment": "",
      "NumAttachments": 207,
      "EmailHeader": "giovani@smithamdooley.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "adipisci",
      "Sentiment": 181,
      "SentimentConfidence": 622,
      "CreatedBy": 979,
      "ChangedAt": "2000-08-23T10:30:24.8423361+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 962
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 491,
      "Name": "Collins, Kutch and Stroman",
      "ToolTip": "Cumque neque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    },
    {
      "Id": 491,
      "Name": "Collins, Kutch and Stroman",
      "ToolTip": "Cumque neque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    }
  ],
  "Language": "consequatur",
  "Sentiment": 921,
  "SentimentConfidence": 916,
  "SuggestedCategoryId": 883,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 766,
  "IconHint": "aut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 598,
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "labore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 86
    }
  }
}
```