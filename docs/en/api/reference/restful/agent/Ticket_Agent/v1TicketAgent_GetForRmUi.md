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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 48
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 155,
  "Title": "aspernatur",
  "CreatedAt": "2005-12-07T12:57:35.0864224+01:00",
  "LastChanged": "2005-05-11T12:57:35.0864224+02:00",
  "ReadByOwner": "2005-05-08T12:57:35.0864224+02:00",
  "ReadByCustomer": "2007-02-27T12:57:35.0864224+01:00",
  "FirstReadByOwner": "2009-05-26T12:57:35.0864224+02:00",
  "FirstReadByUser": "2010-12-12T12:57:35.0864224+01:00",
  "Activate": "2006-03-23T12:57:35.0864224+01:00",
  "ClosedAt": "2001-09-04T12:57:35.0864224+02:00",
  "RepliedAt": "2011-08-02T12:57:35.0864224+02:00",
  "AlertTimeout": "2008-11-07T12:57:35.0864224+01:00",
  "Deadline": "2001-09-07T12:57:35.0864224+02:00",
  "CreatedBy": null,
  "Author": "cum",
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
      "Position": "animi",
      "PersonId": 280,
      "Mrmrs": "voluptas",
      "Firstname": "Liliana",
      "Lastname": "Stiedemann",
      "MiddleName": "Ward LLC",
      "Title": "expedita",
      "Description": "Synchronised attitude-oriented Graphical User Interface",
      "Email": "grover@vandervort.biz",
      "FullName": "Ebony Casper III",
      "DirectPhone": "364-145-4210",
      "FormalName": "Little-Ebert",
      "CountryId": 946,
      "ContactId": 373,
      "ContactName": "Raynor LLC",
      "Retired": 926,
      "Rank": 595,
      "ActiveInterests": 67,
      "ContactDepartment": "",
      "ContactCountryId": 161,
      "ContactOrgNr": "1310564",
      "FaxPhone": "1-380-498-7636 x70788",
      "MobilePhone": "206-041-0606",
      "ContactPhone": "083.201.2256 x799",
      "AssociateName": "Waelchi Group",
      "AssociateId": 838,
      "UsePersonAddress": false,
      "ContactFax": "amet",
      "Kanafname": "aliquam",
      "Kanalname": "mollitia",
      "Post1": "harum",
      "Post2": "ut",
      "Post3": "rerum",
      "EmailName": "alek@hettinger.ca",
      "ContactFullName": "Ms. Selina Bradtke",
      "ActiveErpLinks": 804,
      "TicketPriorityId": 237,
      "SupportLanguageId": 471,
      "SupportAssociateId": 619,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "AlertLevel": 794,
  "ConnectId": 482,
  "ReadStatus": "Green",
  "TimeToReply": 768,
  "RealTimeToReply": 752,
  "TimeToClose": 571,
  "RealTimeToClose": 501,
  "TimeSpentInternally": 799,
  "TimeSpentExternally": 267,
  "TimeSpentQueue": 704,
  "RealTimeSpentInternally": 829,
  "RealTimeSpentExternally": 408,
  "RealTimeSpentQueue": 693,
  "TimeSpent": 730,
  "HasAttachment": false,
  "NumReplies": 867,
  "NumMessages": 518,
  "FromAddress": "eveniet",
  "Messages": [
    {
      "TicketMessageId": 321,
      "CreatedAt": "2023-09-22T12:57:35.1020437+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "inventore",
      "PersonId": 962,
      "PersonFullName": "Arvilla Hamill DVM",
      "ContactId": 342,
      "ContactName": "Greenholt Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 325,
      "EmailHeader": "bethel@klocko.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "suscipit",
      "Sentiment": 797,
      "SentimentConfidence": 279,
      "CreatedBy": 713,
      "ChangedAt": "2002-11-05T12:57:35.1020437+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 40,
      "Name": "Langosh LLC",
      "ToolTip": "Voluptatibus rem molestiae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    },
    {
      "Id": 40,
      "Name": "Langosh LLC",
      "ToolTip": "Voluptatibus rem molestiae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    }
  ],
  "Language": "dolor",
  "Sentiment": 494,
  "SentimentConfidence": 749,
  "SuggestedCategoryId": 237,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 817,
  "IconHint": "iure",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 555,
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 10
    }
  }
}
```