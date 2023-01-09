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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 116,
  "Title": "ab",
  "CreatedAt": "2005-10-06T17:37:19.2712417+02:00",
  "LastChanged": "2022-04-25T17:37:19.2712417+02:00",
  "ReadByOwner": "2018-08-11T17:37:19.2712417+02:00",
  "ReadByCustomer": "1997-06-08T17:37:19.2712417+02:00",
  "FirstReadByOwner": "2013-08-19T17:37:19.2712417+02:00",
  "FirstReadByUser": "2017-10-18T17:37:19.2712417+02:00",
  "Activate": "2022-04-06T17:37:19.2712417+02:00",
  "ClosedAt": "2010-12-04T17:37:19.2712417+01:00",
  "RepliedAt": "2004-09-24T17:37:19.2712417+02:00",
  "AlertTimeout": "2022-01-18T17:37:19.2712417+01:00",
  "Deadline": "1997-11-23T17:37:19.2712417+01:00",
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
      "Position": "iusto",
      "PersonId": 384,
      "Mrmrs": "doloribus",
      "Firstname": "Stella",
      "Lastname": "Frami",
      "MiddleName": "Hane Group",
      "Title": "magnam",
      "Description": "Versatile encompassing attitude",
      "Email": "sincere@klein.uk",
      "FullName": "Colten Nicolas",
      "DirectPhone": "1-036-327-1781",
      "FormalName": "Barrows, Carter and Vandervort",
      "CountryId": 104,
      "ContactId": 94,
      "ContactName": "Schmitt, Dickinson and Walsh",
      "Retired": 201,
      "Rank": 812,
      "ActiveInterests": 430,
      "ContactDepartment": "",
      "ContactCountryId": 973,
      "ContactOrgNr": "78985",
      "FaxPhone": "1-605-823-8670",
      "MobilePhone": "673-472-2148",
      "ContactPhone": "(680)832-3001",
      "AssociateName": "Balistreri-Hermiston",
      "AssociateId": 478,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "possimus",
      "Kanalname": "sequi",
      "Post1": "eligendi",
      "Post2": "magni",
      "Post3": "aut",
      "EmailName": "octavia_goodwin@weimann.uk",
      "ContactFullName": "Kaelyn Von",
      "ActiveErpLinks": 628,
      "TicketPriorityId": 849,
      "SupportLanguageId": 163,
      "SupportAssociateId": 65,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 204
        }
      }
    }
  ],
  "AlertLevel": 742,
  "ConnectId": 586,
  "ReadStatus": "Green",
  "TimeToReply": 127,
  "RealTimeToReply": 200,
  "TimeToClose": 328,
  "RealTimeToClose": 784,
  "TimeSpentInternally": 268,
  "TimeSpentExternally": 906,
  "TimeSpentQueue": 466,
  "RealTimeSpentInternally": 877,
  "RealTimeSpentExternally": 579,
  "RealTimeSpentQueue": 631,
  "HasAttachment": false,
  "NumReplies": 622,
  "NumMessages": 675,
  "FromAddress": "nemo",
  "Messages": [
    {
      "TicketMessageId": 465,
      "CreatedAt": "2021-07-15T17:37:19.2762425+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 676,
      "PersonFullName": "Herminio Schoen MD",
      "ContactId": 898,
      "ContactName": "Jast, Mueller and Conn",
      "ContactDepartment": "",
      "NumAttachments": 728,
      "EmailHeader": "alayna_goldner@corwin.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "veritatis",
      "Sentiment": 256,
      "SentimentConfidence": 589,
      "CreatedBy": 682,
      "ChangedAt": "2006-12-02T17:37:19.2762425+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 661
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 863,
      "Name": "Runolfsdottir, Wyman and Willms",
      "ToolTip": "Corporis quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    },
    {
      "Id": 863,
      "Name": "Runolfsdottir, Wyman and Willms",
      "ToolTip": "Corporis quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    }
  ],
  "Language": "adipisci",
  "Sentiment": 647,
  "SentimentConfidence": 526,
  "SuggestedCategoryId": 814,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 732,
  "IconHint": "dolor",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 78
    }
  }
}
```