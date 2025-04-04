---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
---

# POST Agents/Ticket/GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=39
POST /api/v1/Agents/Ticket/GetTicketEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 59,
  "Title": "praesentium",
  "CreatedAt": "2009-07-25T13:14:01.4725571+02:00",
  "LastChanged": "2018-02-21T13:14:01.4725571+01:00",
  "ReadByOwner": "2005-12-22T13:14:01.4725571+01:00",
  "ReadByCustomer": "2022-05-23T13:14:01.4725571+02:00",
  "FirstReadByOwner": "2016-08-14T13:14:01.4725571+02:00",
  "FirstReadByUser": "2006-12-04T13:14:01.4725571+01:00",
  "Activate": "2016-11-15T13:14:01.4725571+01:00",
  "ClosedAt": "1999-04-09T13:14:01.4725571+02:00",
  "RepliedAt": "1998-10-05T13:14:01.4725571+02:00",
  "AlertTimeout": "2017-09-16T13:14:01.4725571+02:00",
  "Deadline": "2009-10-25T13:14:01.4725571+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "quae",
      "PersonId": 699,
      "Mrmrs": "nostrum",
      "Firstname": "Gust",
      "Lastname": "Kutch",
      "MiddleName": "Hyatt, Quigley and Runolfsdottir",
      "Title": "eos",
      "Description": "Vision-oriented radical architecture",
      "Email": "jaron@dicki.name",
      "FullName": "Dr. Foster Hackett III",
      "DirectPhone": "430.464.3465",
      "FormalName": "Beahan Inc and Sons",
      "CountryId": 519,
      "ContactId": 913,
      "ContactName": "Kub-Swaniawski",
      "Retired": 605,
      "Rank": 996,
      "ActiveInterests": 950,
      "ContactDepartment": "",
      "ContactCountryId": 914,
      "ContactOrgNr": "310584",
      "FaxPhone": "896-954-3610",
      "MobilePhone": "1-105-858-8972",
      "ContactPhone": "886-555-1171",
      "AssociateName": "Ward Group",
      "AssociateId": 924,
      "UsePersonAddress": false,
      "ContactFax": "temporibus",
      "Kanafname": "facilis",
      "Kanalname": "nisi",
      "Post1": "cum",
      "Post2": "animi",
      "Post3": "deleniti",
      "EmailName": "victoria@legros.info",
      "ContactFullName": "Rhiannon Maggio",
      "ActiveErpLinks": 74,
      "TicketPriorityId": 670,
      "SupportLanguageId": 567,
      "SupportAssociateId": 226,
      "CategoryName": "VIP Customer",
      "PersonNumber": "555581",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "AlertLevel": 229,
  "ConnectId": 91,
  "ReadStatus": "Green",
  "TimeToReply": 363,
  "RealTimeToReply": 792,
  "TimeToClose": 175,
  "RealTimeToClose": 977,
  "TimeSpentInternally": 843,
  "TimeSpentExternally": 45,
  "TimeSpentQueue": 207,
  "RealTimeSpentInternally": 299,
  "RealTimeSpentExternally": 675,
  "RealTimeSpentQueue": 674,
  "TimeSpent": 793,
  "HasAttachment": false,
  "NumReplies": 875,
  "NumMessages": 304,
  "FromAddress": "culpa",
  "Messages": [
    {
      "TicketMessageId": 63,
      "CreatedAt": "2014-02-10T13:14:01.4725571+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "iusto",
      "PersonId": 912,
      "PersonFullName": "Tevin Beier",
      "ContactId": 133,
      "ContactName": "Davis Inc and Sons",
      "ContactDepartment": "facilitate scalable experiences",
      "NumAttachments": 277,
      "EmailHeader": "monty@klein.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 399,
      "SentimentConfidence": 941,
      "CreatedBy": 764,
      "ChangedAt": "2012-08-13T13:14:01.4725571+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 845,
      "Name": "Miller, Schmeler and Hammes",
      "ToolTip": "Quas sint sed dignissimos dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    },
    {
      "Id": 845,
      "Name": "Miller, Schmeler and Hammes",
      "ToolTip": "Quas sint sed dignissimos dignissimos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    }
  ],
  "Language": "assumenda",
  "Sentiment": 726,
  "SentimentConfidence": 877,
  "SuggestedCategoryId": 583,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 721,
  "IconHint": "earum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 772,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "exercitationem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 831
    }
  }
}
```