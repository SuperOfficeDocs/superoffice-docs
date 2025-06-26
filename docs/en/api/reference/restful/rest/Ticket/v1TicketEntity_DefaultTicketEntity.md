---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 428,
  "Title": "et",
  "CreatedAt": "2007-02-25T03:45:28.670306+01:00",
  "LastChanged": "2009-07-03T03:45:28.670306+02:00",
  "ReadByOwner": "2014-10-10T03:45:28.670306+02:00",
  "ReadByCustomer": "2003-07-02T03:45:28.670306+02:00",
  "FirstReadByOwner": "2017-01-31T03:45:28.670306+01:00",
  "FirstReadByUser": "2004-03-16T03:45:28.670306+01:00",
  "Activate": "2014-05-12T03:45:28.670306+02:00",
  "ClosedAt": "2009-06-08T03:45:28.670306+02:00",
  "RepliedAt": "2002-10-20T03:45:28.670306+02:00",
  "AlertTimeout": "1999-05-02T03:45:28.670306+02:00",
  "Deadline": "1999-01-25T03:45:28.670306+01:00",
  "CreatedBy": null,
  "Author": "ratione",
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
      "Position": "laborum",
      "PersonId": 552,
      "Mrmrs": "nihil",
      "Firstname": "Kailee",
      "Lastname": "Herzog",
      "MiddleName": "Olson Inc and Sons",
      "Title": "eum",
      "Description": "Managed composite time-frame",
      "Email": "samson@romaguera.us",
      "FullName": "Meaghan Hickle",
      "DirectPhone": "754-804-2662 x5967",
      "FormalName": "Anderson LLC",
      "CountryId": 862,
      "ContactId": 298,
      "ContactName": "Spencer-Koepp",
      "Retired": 137,
      "Rank": 101,
      "ActiveInterests": 384,
      "ContactDepartment": "",
      "ContactCountryId": 190,
      "ContactOrgNr": "1874912",
      "FaxPhone": "(236)691-3103 x435",
      "MobilePhone": "(032)184-4172 x5318",
      "ContactPhone": "783.643.7932 x25673",
      "AssociateName": "Wunsch-Kohler",
      "AssociateId": 592,
      "UsePersonAddress": true,
      "ContactFax": "corporis",
      "Kanafname": "autem",
      "Kanalname": "itaque",
      "Post1": "odit",
      "Post2": "est",
      "Post3": "alias",
      "EmailName": "damian@mosciski.com",
      "ContactFullName": "Gianni Sanford I",
      "ActiveErpLinks": 409,
      "TicketPriorityId": 594,
      "SupportLanguageId": 174,
      "SupportAssociateId": 375,
      "CategoryName": "VIP Customer",
      "PersonNumber": "397658",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    }
  ],
  "AlertLevel": 341,
  "ConnectId": 807,
  "ReadStatus": "Green",
  "TimeToReply": 780,
  "RealTimeToReply": 874,
  "TimeToClose": 425,
  "RealTimeToClose": 390,
  "TimeSpentInternally": 434,
  "TimeSpentExternally": 307,
  "TimeSpentQueue": 919,
  "RealTimeSpentInternally": 810,
  "RealTimeSpentExternally": 742,
  "RealTimeSpentQueue": 437,
  "TimeSpent": 293,
  "HasAttachment": false,
  "NumReplies": 121,
  "NumMessages": 227,
  "FromAddress": "repellendus",
  "Messages": [
    {
      "TicketMessageId": 415,
      "CreatedAt": "2010-03-27T03:45:28.670306+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "consequatur",
      "PersonId": 69,
      "PersonFullName": "Jermain Franecki",
      "ContactId": 746,
      "ContactName": "Pfannerstill, Spinka and Friesen",
      "ContactDepartment": "",
      "NumAttachments": 154,
      "EmailHeader": "tyshawn_bartoletti@marksraynor.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "enim",
      "Sentiment": 902,
      "SentimentConfidence": 338,
      "CreatedBy": 91,
      "ChangedAt": "2000-11-27T03:45:28.670306+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 191
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 864,
      "Name": "Schaefer, Barton and Leffler",
      "ToolTip": "Repudiandae molestiae est vitae illo nostrum repellendus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    },
    {
      "Id": 864,
      "Name": "Schaefer, Barton and Leffler",
      "ToolTip": "Repudiandae molestiae est vitae illo nostrum repellendus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 448,
  "SentimentConfidence": 281,
  "SuggestedCategoryId": 891,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 571,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 852,
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "tempora"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 547
    }
  }
}
```