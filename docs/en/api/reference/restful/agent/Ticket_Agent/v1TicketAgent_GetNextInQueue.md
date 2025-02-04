---
title: POST Agents/Ticket/GetNextInQueue
uid: v1TicketAgent_GetNextInQueue
generated: true
---

# POST Agents/Ticket/GetNextInQueue

```http
POST /api/v1/Agents/Ticket/GetNextInQueue
```

Assign a ticket to the caller based on intelligent queue system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetNextInQueue?$select=name,department,category/id
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
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 465,
  "Title": "voluptas",
  "CreatedAt": "2004-08-12T13:13:24.3059557+02:00",
  "LastChanged": "1998-04-28T13:13:24.3059557+02:00",
  "ReadByOwner": "2015-09-10T13:13:24.3059557+02:00",
  "ReadByCustomer": "2023-05-22T13:13:24.3059557+02:00",
  "FirstReadByOwner": "2006-10-21T13:13:24.3059557+02:00",
  "FirstReadByUser": "2002-12-03T13:13:24.3059557+01:00",
  "Activate": "2009-08-19T13:13:24.3059557+02:00",
  "ClosedAt": "1999-08-06T13:13:24.3059557+02:00",
  "RepliedAt": "2002-08-19T13:13:24.3059557+02:00",
  "AlertTimeout": "2017-03-01T13:13:24.3059557+01:00",
  "Deadline": "2011-08-05T13:13:24.3059557+02:00",
  "CreatedBy": null,
  "Author": "voluptas",
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
      "Position": "vero",
      "PersonId": 618,
      "Mrmrs": "est",
      "Firstname": "Laney",
      "Lastname": "Kshlerin",
      "MiddleName": "McLaughlin, Bergnaum and Gusikowski",
      "Title": "quo",
      "Description": "Synchronised even-keeled monitoring",
      "Email": "adolphus@ferry.info",
      "FullName": "Chester Nienow",
      "DirectPhone": "430.673.7730 x8156",
      "FormalName": "Abbott-Bernier",
      "CountryId": 667,
      "ContactId": 169,
      "ContactName": "Beahan-Wilkinson",
      "Retired": 884,
      "Rank": 119,
      "ActiveInterests": 240,
      "ContactDepartment": "",
      "ContactCountryId": 721,
      "ContactOrgNr": "1292839",
      "FaxPhone": "136.036.4420 x22059",
      "MobilePhone": "1-103-359-4210 x37722",
      "ContactPhone": "521-356-8431",
      "AssociateName": "Larkin, Hauck and Leffler",
      "AssociateId": 984,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "earum",
      "Kanalname": "voluptatibus",
      "Post1": "sit",
      "Post2": "blanditiis",
      "Post3": "et",
      "EmailName": "jody_hodkiewicz@gaylord.uk",
      "ContactFullName": "Derick Stiedemann",
      "ActiveErpLinks": 660,
      "TicketPriorityId": 384,
      "SupportLanguageId": 487,
      "SupportAssociateId": 164,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    }
  ],
  "AlertLevel": 285,
  "ConnectId": 890,
  "ReadStatus": "Green",
  "TimeToReply": 86,
  "RealTimeToReply": 959,
  "TimeToClose": 811,
  "RealTimeToClose": 785,
  "TimeSpentInternally": 739,
  "TimeSpentExternally": 976,
  "TimeSpentQueue": 898,
  "RealTimeSpentInternally": 720,
  "RealTimeSpentExternally": 676,
  "RealTimeSpentQueue": 610,
  "TimeSpent": 129,
  "HasAttachment": true,
  "NumReplies": 535,
  "NumMessages": 976,
  "FromAddress": "fuga",
  "Messages": [
    {
      "TicketMessageId": 171,
      "CreatedAt": "2000-03-01T13:13:24.3059557+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "doloremque",
      "PersonId": 668,
      "PersonFullName": "Miss Andre Roob",
      "ContactId": 423,
      "ContactName": "Lind, Klein and Trantow",
      "ContactDepartment": "",
      "NumAttachments": 819,
      "EmailHeader": "jay_rath@kutch.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dolores",
      "Sentiment": 212,
      "SentimentConfidence": 259,
      "CreatedBy": 57,
      "ChangedAt": "2018-04-18T13:13:24.3059557+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 531,
      "Name": "Bernhard Group",
      "ToolTip": "Quisquam quas non quia qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Id": 531,
      "Name": "Bernhard Group",
      "ToolTip": "Quisquam quas non quia qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Language": "nihil",
  "Sentiment": 616,
  "SentimentConfidence": 854,
  "SuggestedCategoryId": 282,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 749,
  "IconHint": "non",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 126,
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "officia"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "minus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 966
    }
  }
}
```