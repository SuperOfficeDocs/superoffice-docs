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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 817
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 998,
  "Title": "magni",
  "CreatedAt": "2008-06-02T16:00:42.1643851+02:00",
  "LastChanged": "1996-11-01T16:00:42.1643851+01:00",
  "ReadByOwner": "2005-12-08T16:00:42.1643851+01:00",
  "ReadByCustomer": "2015-12-09T16:00:42.1643851+01:00",
  "FirstReadByOwner": "2000-08-26T16:00:42.1643851+02:00",
  "FirstReadByUser": "2010-08-02T16:00:42.1643851+02:00",
  "Activate": "2020-03-04T16:00:42.1643851+01:00",
  "ClosedAt": "2007-07-04T16:00:42.1643851+02:00",
  "RepliedAt": "2016-01-21T16:00:42.1643851+01:00",
  "AlertTimeout": "2016-10-11T16:00:42.1643851+02:00",
  "Deadline": "2015-01-07T16:00:42.1643851+01:00",
  "CreatedBy": null,
  "Author": "autem",
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
      "Position": "ad",
      "PersonId": 48,
      "Mrmrs": "quam",
      "Firstname": "Grace",
      "Lastname": "Dibbert",
      "MiddleName": "Graham-Vandervort",
      "Title": "et",
      "Description": "User-centric reciprocal workforce",
      "Email": "toby@leschrussel.com",
      "FullName": "Dr. Alyce Labadie",
      "DirectPhone": "(401)762-8310 x7532",
      "FormalName": "Altenwerth-Abbott",
      "CountryId": 247,
      "ContactId": 434,
      "ContactName": "Goldner, Rolfson and Thiel",
      "Retired": 169,
      "Rank": 43,
      "ActiveInterests": 550,
      "ContactDepartment": "",
      "ContactCountryId": 7,
      "ContactOrgNr": "1142986",
      "FaxPhone": "(230)807-0476 x4889",
      "MobilePhone": "1-772-604-2609",
      "ContactPhone": "(767)034-6410 x2939",
      "AssociateName": "Roberts, Jenkins and Bosco",
      "AssociateId": 227,
      "UsePersonAddress": true,
      "ContactFax": "quo",
      "Kanafname": "consectetur",
      "Kanalname": "occaecati",
      "Post1": "et",
      "Post2": "saepe",
      "Post3": "illum",
      "EmailName": "esther_marquardt@king.ca",
      "ContactFullName": "Fae Mante",
      "ActiveErpLinks": 361,
      "TicketPriorityId": 129,
      "SupportLanguageId": 939,
      "SupportAssociateId": 260,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "AlertLevel": 608,
  "ConnectId": 836,
  "ReadStatus": "Green",
  "TimeToReply": 612,
  "RealTimeToReply": 710,
  "TimeToClose": 102,
  "RealTimeToClose": 905,
  "TimeSpentInternally": 687,
  "TimeSpentExternally": 939,
  "TimeSpentQueue": 576,
  "RealTimeSpentInternally": 454,
  "RealTimeSpentExternally": 455,
  "RealTimeSpentQueue": 343,
  "HasAttachment": false,
  "NumReplies": 750,
  "NumMessages": 572,
  "FromAddress": "omnis",
  "Messages": [
    {
      "TicketMessageId": 711,
      "CreatedAt": "2012-03-07T16:00:42.1800144+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "omnis",
      "PersonId": 475,
      "PersonFullName": "Hilton Zulauf",
      "ContactId": 837,
      "ContactName": "Kreiger, Quitzon and Nitzsche",
      "ContactDepartment": "",
      "NumAttachments": 95,
      "EmailHeader": "carli_schaden@ratkequitzon.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "reiciendis",
      "Sentiment": 881,
      "SentimentConfidence": 108,
      "CreatedBy": 600,
      "ChangedAt": "2010-01-26T16:00:42.1800144+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 819,
      "Name": "Schneider, Stiedemann and Hills",
      "ToolTip": "Dolore ea harum doloremque dolores laudantium quibusdam sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Id": 819,
      "Name": "Schneider, Stiedemann and Hills",
      "ToolTip": "Dolore ea harum doloremque dolores laudantium quibusdam sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "Language": "ipsum",
  "Sentiment": 934,
  "SentimentConfidence": 340,
  "SuggestedCategoryId": 673,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 122,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 476
    }
  }
}
```