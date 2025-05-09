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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=281
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
  "TicketId": 288,
  "Title": "et",
  "CreatedAt": "2019-12-20T16:32:40.2270126+01:00",
  "LastChanged": "2011-03-19T16:32:40.2270126+01:00",
  "ReadByOwner": "2008-10-31T16:32:40.2270126+01:00",
  "ReadByCustomer": "2023-04-06T16:32:40.2270126+02:00",
  "FirstReadByOwner": "1998-03-04T16:32:40.2270126+01:00",
  "FirstReadByUser": "2023-12-30T16:32:40.2270126+01:00",
  "Activate": "2000-08-27T16:32:40.2270126+02:00",
  "ClosedAt": "2021-09-08T16:32:40.2270126+02:00",
  "RepliedAt": "2010-11-18T16:32:40.2270126+01:00",
  "AlertTimeout": "2009-10-13T16:32:40.2270126+02:00",
  "Deadline": "2020-01-26T16:32:40.2270126+01:00",
  "CreatedBy": null,
  "Author": "eius",
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
      "Position": "quia",
      "PersonId": 617,
      "Mrmrs": "animi",
      "Firstname": "Buddy",
      "Lastname": "Witting",
      "MiddleName": "Witting Group",
      "Title": "labore",
      "Description": "Switchable non-volatile task-force",
      "Email": "anika@veum.co.uk",
      "FullName": "Prof. Jeffrey Jennyfer Schulist Jr.",
      "DirectPhone": "1-624-834-9723 x00099",
      "FormalName": "Reilly Group",
      "CountryId": 916,
      "ContactId": 501,
      "ContactName": "Lehner-Emmerich",
      "Retired": 848,
      "Rank": 379,
      "ActiveInterests": 565,
      "ContactDepartment": "",
      "ContactCountryId": 39,
      "ContactOrgNr": "1085139",
      "FaxPhone": "(114)513-5955",
      "MobilePhone": "(743)960-0783 x35762",
      "ContactPhone": "966.667.5886 x7434",
      "AssociateName": "Hahn Group",
      "AssociateId": 142,
      "UsePersonAddress": false,
      "ContactFax": "placeat",
      "Kanafname": "consequuntur",
      "Kanalname": "id",
      "Post1": "similique",
      "Post2": "quisquam",
      "Post3": "id",
      "EmailName": "brent@langoshsatterfield.info",
      "ContactFullName": "Mr. Guy Keaton Shields Sr.",
      "ActiveErpLinks": 654,
      "TicketPriorityId": 646,
      "SupportLanguageId": 307,
      "SupportAssociateId": 958,
      "CategoryName": "VIP Customer",
      "PersonNumber": "956054",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "AlertLevel": 740,
  "ConnectId": 340,
  "ReadStatus": "Green",
  "TimeToReply": 673,
  "RealTimeToReply": 363,
  "TimeToClose": 228,
  "RealTimeToClose": 1000,
  "TimeSpentInternally": 826,
  "TimeSpentExternally": 1001,
  "TimeSpentQueue": 337,
  "RealTimeSpentInternally": 236,
  "RealTimeSpentExternally": 330,
  "RealTimeSpentQueue": 435,
  "TimeSpent": 648,
  "HasAttachment": false,
  "NumReplies": 900,
  "NumMessages": 378,
  "FromAddress": "sed",
  "Messages": [
    {
      "TicketMessageId": 561,
      "CreatedAt": "2024-10-08T16:32:40.2426321+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quasi",
      "PersonId": 264,
      "PersonFullName": "Aurore Buckridge",
      "ContactId": 57,
      "ContactName": "Mills, Buckridge and Sauer",
      "ContactDepartment": "",
      "NumAttachments": 209,
      "EmailHeader": "ernest.keeling@christiansen.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatum",
      "Sentiment": 186,
      "SentimentConfidence": 284,
      "CreatedBy": 996,
      "ChangedAt": "2021-06-11T16:32:40.2426321+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 613,
      "Name": "Ritchie-Moore",
      "ToolTip": "Aperiam similique dolor quo qui explicabo ad aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    },
    {
      "Id": 613,
      "Name": "Ritchie-Moore",
      "ToolTip": "Aperiam similique dolor quo qui explicabo ad aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "Language": "dolores",
  "Sentiment": 193,
  "SentimentConfidence": 397,
  "SuggestedCategoryId": 284,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 218,
  "IconHint": "reiciendis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 460,
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "soluta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 482
    }
  }
}
```