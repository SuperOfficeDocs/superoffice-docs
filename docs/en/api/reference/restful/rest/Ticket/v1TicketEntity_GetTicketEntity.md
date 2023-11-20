---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
generated: true
---

# GET Ticket/{id}

```http
GET /api/v1/Ticket/{id}
```

Gets a TicketEntity object.


Calls the Ticket agent service GetTicketEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Ticket/{id}?$select=name,department,category/id
GET /api/v1/Ticket/{id}?fk=False
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

TicketEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity found. |
| 404 | Not Found. |

### Response body: TicketEntityWithLinks

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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 892,
  "Title": "incidunt",
  "CreatedAt": "1996-11-03T13:38:17.7024252+01:00",
  "LastChanged": "2009-01-27T13:38:17.7024252+01:00",
  "ReadByOwner": "2011-06-04T13:38:17.7024252+02:00",
  "ReadByCustomer": "2004-08-16T13:38:17.7024252+02:00",
  "FirstReadByOwner": "2007-11-14T13:38:17.7024252+01:00",
  "FirstReadByUser": "2009-01-13T13:38:17.7024252+01:00",
  "Activate": "2001-09-13T13:38:17.7024252+02:00",
  "ClosedAt": "2005-03-04T13:38:17.7024252+01:00",
  "RepliedAt": "2003-09-27T13:38:17.7024252+02:00",
  "AlertTimeout": "2014-03-21T13:38:17.7024252+01:00",
  "Deadline": "2003-06-29T13:38:17.7024252+02:00",
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
      "Position": "nisi",
      "PersonId": 777,
      "Mrmrs": "est",
      "Firstname": "Darion",
      "Lastname": "Swift",
      "MiddleName": "Smith-Murray",
      "Title": "sed",
      "Description": "Horizontal responsive moratorium",
      "Email": "lucie_crooks@pouros.biz",
      "FullName": "Dr. Elta Schiller",
      "DirectPhone": "(231)960-5184 x50700",
      "FormalName": "Murray, Adams and Hyatt",
      "CountryId": 667,
      "ContactId": 864,
      "ContactName": "Zulauf, Hoppe and Hudson",
      "Retired": 244,
      "Rank": 478,
      "ActiveInterests": 94,
      "ContactDepartment": "",
      "ContactCountryId": 440,
      "ContactOrgNr": "1431046",
      "FaxPhone": "1-380-136-6548",
      "MobilePhone": "296-432-6102",
      "ContactPhone": "754.026.5619 x14699",
      "AssociateName": "Sipes-Bartoletti",
      "AssociateId": 215,
      "UsePersonAddress": false,
      "ContactFax": "nihil",
      "Kanafname": "quod",
      "Kanalname": "aliquam",
      "Post1": "modi",
      "Post2": "sed",
      "Post3": "sapiente",
      "EmailName": "mireille@goldnerpfannerstill.ca",
      "ContactFullName": "Prof. Vivian Hallie Hessel Jr.",
      "ActiveErpLinks": 535,
      "TicketPriorityId": 651,
      "SupportLanguageId": 325,
      "SupportAssociateId": 735,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "AlertLevel": 166,
  "ConnectId": 40,
  "ReadStatus": "Green",
  "TimeToReply": 204,
  "RealTimeToReply": 614,
  "TimeToClose": 627,
  "RealTimeToClose": 253,
  "TimeSpentInternally": 27,
  "TimeSpentExternally": 14,
  "TimeSpentQueue": 433,
  "RealTimeSpentInternally": 857,
  "RealTimeSpentExternally": 816,
  "RealTimeSpentQueue": 485,
  "TimeSpent": 34,
  "HasAttachment": true,
  "NumReplies": 732,
  "NumMessages": 268,
  "FromAddress": "molestiae",
  "Messages": [
    {
      "TicketMessageId": 582,
      "CreatedAt": "2010-03-08T13:38:17.7024252+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aliquid",
      "PersonId": 307,
      "PersonFullName": "Brian Corwin",
      "ContactId": 685,
      "ContactName": "McKenzie Group",
      "ContactDepartment": "",
      "NumAttachments": 751,
      "EmailHeader": "clinton@boyer.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "porro",
      "Sentiment": 269,
      "SentimentConfidence": 36,
      "CreatedBy": 438,
      "ChangedAt": "2001-12-29T13:38:17.7024252+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 100,
      "Name": "Crist Inc and Sons",
      "ToolTip": "Et doloribus pariatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    },
    {
      "Id": 100,
      "Name": "Crist Inc and Sons",
      "ToolTip": "Et doloribus pariatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "Language": "amet",
  "Sentiment": 480,
  "SentimentConfidence": 847,
  "SuggestedCategoryId": 75,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 112,
  "IconHint": "eum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "debitis",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "eveniet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 809
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```