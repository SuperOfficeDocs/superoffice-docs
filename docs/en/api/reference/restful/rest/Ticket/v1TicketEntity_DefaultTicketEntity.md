---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 836,
  "Title": "occaecati",
  "CreatedAt": "2013-07-13T17:37:39.2453036+02:00",
  "LastChanged": "2006-12-30T17:37:39.2453036+01:00",
  "ReadByOwner": "2003-01-19T17:37:39.2453036+01:00",
  "ReadByCustomer": "2006-07-08T17:37:39.2453036+02:00",
  "FirstReadByOwner": "1995-09-11T17:37:39.2453036+02:00",
  "FirstReadByUser": "1998-03-09T17:37:39.2453036+01:00",
  "Activate": "1996-02-17T17:37:39.2453036+01:00",
  "ClosedAt": "2019-02-07T17:37:39.2453036+01:00",
  "RepliedAt": "1999-04-15T17:37:39.2453036+02:00",
  "AlertTimeout": "2010-02-17T17:37:39.2453036+01:00",
  "Deadline": "1999-01-28T17:37:39.2453036+01:00",
  "CreatedBy": null,
  "Author": "vel",
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
      "Position": "voluptatem",
      "PersonId": 631,
      "Mrmrs": "aut",
      "Firstname": "Pearline",
      "Lastname": "Spinka",
      "MiddleName": "Bartell Inc and Sons",
      "Title": "nihil",
      "Description": "Grass-roots national standardization",
      "Email": "elijah_ratke@dickens.ca",
      "FullName": "Keaton Olson",
      "DirectPhone": "1-299-621-9694",
      "FormalName": "Hegmann-Pacocha",
      "CountryId": 584,
      "ContactId": 287,
      "ContactName": "Prohaska-Ruecker",
      "Retired": 260,
      "Rank": 101,
      "ActiveInterests": 978,
      "ContactDepartment": "",
      "ContactCountryId": 680,
      "ContactOrgNr": "1125259",
      "FaxPhone": "1-319-828-3137 x92625",
      "MobilePhone": "278.549.7657 x9963",
      "ContactPhone": "(502)393-0926",
      "AssociateName": "Boehm Group",
      "AssociateId": 484,
      "UsePersonAddress": true,
      "ContactFax": "accusantium",
      "Kanafname": "quia",
      "Kanalname": "omnis",
      "Post1": "officia",
      "Post2": "doloribus",
      "Post3": "animi",
      "EmailName": "jordi@hodkiewicz.com",
      "ContactFullName": "Marcus Charley Upton DVM",
      "ActiveErpLinks": 485,
      "TicketPriorityId": 500,
      "SupportLanguageId": 387,
      "SupportAssociateId": 135,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "AlertLevel": 224,
  "ConnectId": 798,
  "ReadStatus": "Green",
  "TimeToReply": 376,
  "RealTimeToReply": 210,
  "TimeToClose": 922,
  "RealTimeToClose": 186,
  "TimeSpentInternally": 193,
  "TimeSpentExternally": 67,
  "TimeSpentQueue": 351,
  "RealTimeSpentInternally": 477,
  "RealTimeSpentExternally": 963,
  "RealTimeSpentQueue": 452,
  "HasAttachment": true,
  "NumReplies": 398,
  "NumMessages": 670,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 827,
      "CreatedAt": "1996-04-28T17:37:39.2483093+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "vel",
      "PersonId": 969,
      "PersonFullName": "Mr. Eloisa Trantow PhD",
      "ContactId": 187,
      "ContactName": "Konopelski, Koss and Macejkovic",
      "ContactDepartment": "",
      "NumAttachments": 824,
      "EmailHeader": "karlee.heller@carter.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ipsam",
      "Sentiment": 684,
      "SentimentConfidence": 791,
      "CreatedBy": 726,
      "ChangedAt": "2000-02-27T17:37:39.2493086+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 273,
      "Name": "Borer-Roob",
      "ToolTip": "Doloremque nobis provident saepe incidunt voluptatem unde.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 942
        }
      }
    },
    {
      "Id": 273,
      "Name": "Borer-Roob",
      "ToolTip": "Doloremque nobis provident saepe incidunt voluptatem unde.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 942
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 667,
  "SentimentConfidence": 962,
  "SuggestedCategoryId": 254,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 979,
  "IconHint": "est",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "ipsa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 486
    }
  }
}
```