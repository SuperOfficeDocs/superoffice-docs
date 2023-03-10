---
title: POST Agents/Ticket/CreateDefaultTicketEntity
uid: v1TicketAgent_CreateDefaultTicketEntity
---

# POST Agents/Ticket/CreateDefaultTicketEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/CreateDefaultTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 460,
  "Title": "qui",
  "CreatedAt": "2010-08-23T12:15:20.2627328+02:00",
  "LastChanged": "2020-01-15T12:15:20.2627328+01:00",
  "ReadByOwner": "2020-02-27T12:15:20.2627328+01:00",
  "ReadByCustomer": "2015-04-18T12:15:20.2627328+02:00",
  "FirstReadByOwner": "2001-01-30T12:15:20.2627328+01:00",
  "FirstReadByUser": "2001-08-15T12:15:20.2627328+02:00",
  "Activate": "2018-11-26T12:15:20.2627328+01:00",
  "ClosedAt": "2002-05-27T12:15:20.2627328+02:00",
  "RepliedAt": "2014-02-19T12:15:20.2627328+01:00",
  "AlertTimeout": "2021-01-22T12:15:20.2627328+01:00",
  "Deadline": "2000-06-18T12:15:20.2627328+02:00",
  "CreatedBy": null,
  "Author": "consectetur",
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
      "Position": "doloremque",
      "PersonId": 293,
      "Mrmrs": "non",
      "Firstname": "Christopher",
      "Lastname": "Murray",
      "MiddleName": "Hahn Group",
      "Title": "possimus",
      "Description": "Quality-focused 24/7 artificial intelligence",
      "Email": "mireille.kunde@watsica.ca",
      "FullName": "Mrs. Tianna Selena Adams DVM",
      "DirectPhone": "348.686.7510",
      "FormalName": "Considine, Kuvalis and Schoen",
      "CountryId": 144,
      "ContactId": 538,
      "ContactName": "Mann Inc and Sons",
      "Retired": 72,
      "Rank": 199,
      "ActiveInterests": 286,
      "ContactDepartment": "streamline B2C e-business",
      "ContactCountryId": 28,
      "ContactOrgNr": "1374972",
      "FaxPhone": "1-356-545-4898 x4548",
      "MobilePhone": "1-598-430-1424",
      "ContactPhone": "1-574-655-1538 x29703",
      "AssociateName": "Quitzon Group",
      "AssociateId": 989,
      "UsePersonAddress": false,
      "ContactFax": "dolorum",
      "Kanafname": "dolores",
      "Kanalname": "nobis",
      "Post1": "dolorem",
      "Post2": "ut",
      "Post3": "nesciunt",
      "EmailName": "zetta.hintz@cartwright.info",
      "ContactFullName": "Chanel Watsica",
      "ActiveErpLinks": 275,
      "TicketPriorityId": 739,
      "SupportLanguageId": 997,
      "SupportAssociateId": 15,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "AlertLevel": 392,
  "ConnectId": 475,
  "ReadStatus": "Green",
  "TimeToReply": 357,
  "RealTimeToReply": 82,
  "TimeToClose": 800,
  "RealTimeToClose": 608,
  "TimeSpentInternally": 830,
  "TimeSpentExternally": 111,
  "TimeSpentQueue": 922,
  "RealTimeSpentInternally": 372,
  "RealTimeSpentExternally": 882,
  "RealTimeSpentQueue": 71,
  "HasAttachment": false,
  "NumReplies": 800,
  "NumMessages": 775,
  "FromAddress": "sit",
  "Messages": [
    {
      "TicketMessageId": 83,
      "CreatedAt": "2022-10-03T12:15:20.2667339+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "cum",
      "PersonId": 918,
      "PersonFullName": "Rickey Dibbert",
      "ContactId": 819,
      "ContactName": "Kreiger LLC",
      "ContactDepartment": "",
      "NumAttachments": 295,
      "EmailHeader": "mason.terry@waelchiconnelly.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "delectus",
      "Sentiment": 635,
      "SentimentConfidence": 439,
      "CreatedBy": 579,
      "ChangedAt": "2008-07-21T12:15:20.2677326+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 921,
      "Name": "Bernhard Group",
      "ToolTip": "Quidem quasi perferendis quas rerum accusamus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 872
        }
      }
    },
    {
      "Id": 921,
      "Name": "Bernhard Group",
      "ToolTip": "Quidem quasi perferendis quas rerum accusamus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 872
        }
      }
    }
  ],
  "Language": "ducimus",
  "Sentiment": 386,
  "SentimentConfidence": 545,
  "SuggestedCategoryId": 95,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 706,
  "IconHint": "sit",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "error",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 549
    }
  }
}
```