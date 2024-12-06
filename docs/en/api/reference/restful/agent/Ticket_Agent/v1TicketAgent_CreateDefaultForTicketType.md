---
title: POST Agents/Ticket/CreateDefaultForTicketType
uid: v1TicketAgent_CreateDefaultForTicketType
generated: true
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
  "TicketTypeId": 926
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 617,
  "Title": "rerum",
  "CreatedAt": "2016-03-14T10:17:56.2697028+01:00",
  "LastChanged": "2023-10-29T10:17:56.2697028+01:00",
  "ReadByOwner": "2015-05-31T10:17:56.2697028+02:00",
  "ReadByCustomer": "2007-04-19T10:17:56.2697028+02:00",
  "FirstReadByOwner": "2003-04-26T10:17:56.2697028+02:00",
  "FirstReadByUser": "2008-06-02T10:17:56.2697028+02:00",
  "Activate": "2008-12-06T10:17:56.2697028+01:00",
  "ClosedAt": "2017-11-06T10:17:56.2697028+01:00",
  "RepliedAt": "2004-06-06T10:17:56.2697028+02:00",
  "AlertTimeout": "2003-11-29T10:17:56.2697028+01:00",
  "Deadline": "2018-04-02T10:17:56.2697028+02:00",
  "CreatedBy": null,
  "Author": "reprehenderit",
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
      "Position": "id",
      "PersonId": 148,
      "Mrmrs": "architecto",
      "Firstname": "Levi",
      "Lastname": "Schoen",
      "MiddleName": "Casper, Huel and Weimann",
      "Title": "et",
      "Description": "Monitored national contingency",
      "Email": "burdette_harris@fadelkunze.info",
      "FullName": "Duncan Jast",
      "DirectPhone": "1-356-645-9876 x195",
      "FormalName": "Franecki-Schuppe",
      "CountryId": 640,
      "ContactId": 658,
      "ContactName": "Kreiger LLC",
      "Retired": 871,
      "Rank": 270,
      "ActiveInterests": 26,
      "ContactDepartment": "",
      "ContactCountryId": 239,
      "ContactOrgNr": "438987",
      "FaxPhone": "433.554.1383",
      "MobilePhone": "1-859-993-7904",
      "ContactPhone": "(798)588-6522",
      "AssociateName": "Rutherford Inc and Sons",
      "AssociateId": 394,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "omnis",
      "Kanalname": "ut",
      "Post1": "odit",
      "Post2": "nihil",
      "Post3": "in",
      "EmailName": "hector@koeppbotsford.name",
      "ContactFullName": "Dr. Courtney Howell Blick",
      "ActiveErpLinks": 920,
      "TicketPriorityId": 941,
      "SupportLanguageId": 478,
      "SupportAssociateId": 586,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "AlertLevel": 792,
  "ConnectId": 831,
  "ReadStatus": "Green",
  "TimeToReply": 923,
  "RealTimeToReply": 174,
  "TimeToClose": 223,
  "RealTimeToClose": 159,
  "TimeSpentInternally": 590,
  "TimeSpentExternally": 746,
  "TimeSpentQueue": 944,
  "RealTimeSpentInternally": 199,
  "RealTimeSpentExternally": 358,
  "RealTimeSpentQueue": 175,
  "TimeSpent": 327,
  "HasAttachment": true,
  "NumReplies": 566,
  "NumMessages": 562,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 96,
      "CreatedAt": "2022-12-06T10:17:56.2697028+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quaerat",
      "PersonId": 185,
      "PersonFullName": "Elnora Erdman",
      "ContactId": 53,
      "ContactName": "Feil, Trantow and Wuckert",
      "ContactDepartment": "",
      "NumAttachments": 563,
      "EmailHeader": "janick.jacobson@mcculloughzieme.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eius",
      "Sentiment": 296,
      "SentimentConfidence": 598,
      "CreatedBy": 286,
      "ChangedAt": "2004-01-07T10:17:56.2697028+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 343,
      "Name": "Marvin, Thompson and Reinger",
      "ToolTip": "Deleniti id.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    },
    {
      "Id": 343,
      "Name": "Marvin, Thompson and Reinger",
      "ToolTip": "Deleniti id.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    }
  ],
  "Language": "veniam",
  "Sentiment": 189,
  "SentimentConfidence": 882,
  "SuggestedCategoryId": 953,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 245,
  "IconHint": "culpa",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 271,
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "delectus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 781
    }
  }
}
```