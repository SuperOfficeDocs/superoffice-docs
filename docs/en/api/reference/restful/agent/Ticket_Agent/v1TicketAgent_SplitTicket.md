---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
generated: true
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

SourceTicketEntityId, SourceTicketEntityStatusId, SourceTicketEntityActivate, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| SourceTicketEntityStatusId | Integer |  |
| SourceTicketEntityActivate | String |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 341,
  "SourceTicketEntityStatusId": 708,
  "SourceTicketEntityActivate": "2003-09-11T17:54:03.788924+02:00",
  "TransferMessageIds": [
    112,
    450
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 987,
  "Title": "rerum",
  "CreatedAt": "2015-01-03T17:54:03.8045485+01:00",
  "LastChanged": "2004-11-18T17:54:03.8045485+01:00",
  "ReadByOwner": "2017-10-30T17:54:03.8045485+01:00",
  "ReadByCustomer": "2000-08-19T17:54:03.8045485+02:00",
  "FirstReadByOwner": "2012-11-04T17:54:03.8045485+01:00",
  "FirstReadByUser": "2017-10-10T17:54:03.8045485+02:00",
  "Activate": "2015-04-30T17:54:03.8045485+02:00",
  "ClosedAt": "2007-11-14T17:54:03.8045485+01:00",
  "RepliedAt": "2005-04-25T17:54:03.8045485+02:00",
  "AlertTimeout": "2012-07-19T17:54:03.8045485+02:00",
  "Deadline": "2017-01-04T17:54:03.8045485+01:00",
  "CreatedBy": null,
  "Author": "nihil",
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
      "Position": "eius",
      "PersonId": 78,
      "Mrmrs": "veritatis",
      "Firstname": "Cruz",
      "Lastname": "Price",
      "MiddleName": "Ryan-Johns",
      "Title": "aperiam",
      "Description": "Open-source asynchronous leverage",
      "Email": "kale.connelly@bins.com",
      "FullName": "Mrs. Marlen Amiya Spencer Sr.",
      "DirectPhone": "1-425-864-9324",
      "FormalName": "Huels, Graham and Langosh",
      "CountryId": 720,
      "ContactId": 85,
      "ContactName": "Marvin, Terry and Turcotte",
      "Retired": 834,
      "Rank": 328,
      "ActiveInterests": 96,
      "ContactDepartment": "",
      "ContactCountryId": 915,
      "ContactOrgNr": "831503",
      "FaxPhone": "004.115.7166 x4026",
      "MobilePhone": "(792)213-6013 x9536",
      "ContactPhone": "1-916-844-7299 x943",
      "AssociateName": "Wyman, Schimmel and Farrell",
      "AssociateId": 737,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "placeat",
      "Kanalname": "necessitatibus",
      "Post1": "aut",
      "Post2": "at",
      "Post3": "cum",
      "EmailName": "mylene.kerluke@senger.uk",
      "ContactFullName": "Eudora Gladys Wyman Sr.",
      "ActiveErpLinks": 589,
      "TicketPriorityId": 35,
      "SupportLanguageId": 803,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer",
      "PersonNumber": "967134",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "AlertLevel": 979,
  "ConnectId": 649,
  "ReadStatus": "Green",
  "TimeToReply": 605,
  "RealTimeToReply": 134,
  "TimeToClose": 366,
  "RealTimeToClose": 596,
  "TimeSpentInternally": 933,
  "TimeSpentExternally": 264,
  "TimeSpentQueue": 885,
  "RealTimeSpentInternally": 473,
  "RealTimeSpentExternally": 421,
  "RealTimeSpentQueue": 28,
  "TimeSpent": 214,
  "HasAttachment": false,
  "NumReplies": 478,
  "NumMessages": 188,
  "FromAddress": "aperiam",
  "Messages": [
    {
      "TicketMessageId": 4,
      "CreatedAt": "1999-02-03T17:54:03.8045485+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eaque",
      "PersonId": 675,
      "PersonFullName": "Clara Simonis",
      "ContactId": 793,
      "ContactName": "Adams, Feil and Adams",
      "ContactDepartment": "",
      "NumAttachments": 855,
      "EmailHeader": "adelle.wunsch@murazik.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 410,
      "SentimentConfidence": 860,
      "CreatedBy": 130,
      "ChangedAt": "2021-10-04T17:54:03.8045485+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 193,
      "Name": "Beatty Group",
      "ToolTip": "Dicta possimus quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 559
        }
      }
    },
    {
      "Id": 193,
      "Name": "Beatty Group",
      "ToolTip": "Dicta possimus quis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 559
        }
      }
    }
  ],
  "Language": "natus",
  "Sentiment": 433,
  "SentimentConfidence": 789,
  "SuggestedCategoryId": 752,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 816,
  "IconHint": "illum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 976,
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 927
    }
  }
}
```