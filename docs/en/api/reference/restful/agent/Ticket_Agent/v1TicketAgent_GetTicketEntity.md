---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=119
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 63,
  "Title": "qui",
  "CreatedAt": "2006-01-24T17:37:19.3312421+01:00",
  "LastChanged": "2007-01-09T17:37:19.3312421+01:00",
  "ReadByOwner": "2017-09-12T17:37:19.3312421+02:00",
  "ReadByCustomer": "2004-03-02T17:37:19.3312421+01:00",
  "FirstReadByOwner": "1999-05-29T17:37:19.3312421+02:00",
  "FirstReadByUser": "2010-06-30T17:37:19.3312421+02:00",
  "Activate": "2007-01-16T17:37:19.3312421+01:00",
  "ClosedAt": "2000-06-23T17:37:19.3312421+02:00",
  "RepliedAt": "2001-01-21T17:37:19.3312421+01:00",
  "AlertTimeout": "2011-11-09T17:37:19.3312421+01:00",
  "Deadline": "1999-08-21T17:37:19.3312421+02:00",
  "CreatedBy": null,
  "Author": "nobis",
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
      "Position": "in",
      "PersonId": 435,
      "Mrmrs": "in",
      "Firstname": "Dasia",
      "Lastname": "Schumm",
      "MiddleName": "Lind Inc and Sons",
      "Title": "occaecati",
      "Description": "Diverse fresh-thinking complexity",
      "Email": "payton@hintz.com",
      "FullName": "Kimberly Luettgen",
      "DirectPhone": "1-473-220-0796 x905",
      "FormalName": "Murray Inc and Sons",
      "CountryId": 509,
      "ContactId": 281,
      "ContactName": "Barton-Mayer",
      "Retired": 979,
      "Rank": 1001,
      "ActiveInterests": 671,
      "ContactDepartment": "",
      "ContactCountryId": 105,
      "ContactOrgNr": "954685",
      "FaxPhone": "777.837.8403 x529",
      "MobilePhone": "580-649-7270",
      "ContactPhone": "798.021.3341",
      "AssociateName": "Batz-Keebler",
      "AssociateId": 483,
      "UsePersonAddress": true,
      "ContactFax": "omnis",
      "Kanafname": "molestias",
      "Kanalname": "praesentium",
      "Post1": "cum",
      "Post2": "praesentium",
      "Post3": "nobis",
      "EmailName": "michale_wiza@rueckerstark.com",
      "ContactFullName": "Ignacio Stokes",
      "ActiveErpLinks": 310,
      "TicketPriorityId": 873,
      "SupportLanguageId": 231,
      "SupportAssociateId": 182,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    }
  ],
  "AlertLevel": 308,
  "ConnectId": 765,
  "ReadStatus": "Green",
  "TimeToReply": 35,
  "RealTimeToReply": 310,
  "TimeToClose": 727,
  "RealTimeToClose": 887,
  "TimeSpentInternally": 953,
  "TimeSpentExternally": 836,
  "TimeSpentQueue": 382,
  "RealTimeSpentInternally": 607,
  "RealTimeSpentExternally": 788,
  "RealTimeSpentQueue": 710,
  "HasAttachment": false,
  "NumReplies": 206,
  "NumMessages": 660,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 118,
      "CreatedAt": "2012-06-30T17:37:19.3352406+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 580,
      "PersonFullName": "Kieran Harvey Jr.",
      "ContactId": 542,
      "ContactName": "Bogan Group",
      "ContactDepartment": "",
      "NumAttachments": 176,
      "EmailHeader": "camren@lynch.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 651,
      "SentimentConfidence": 928,
      "CreatedBy": 741,
      "ChangedAt": "2008-01-26T17:37:19.3362423+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 36,
      "Name": "Pfannerstill-Schneider",
      "ToolTip": "Qui molestiae eum reprehenderit eos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    },
    {
      "Id": 36,
      "Name": "Pfannerstill-Schneider",
      "ToolTip": "Qui molestiae eum reprehenderit eos.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 555
        }
      }
    }
  ],
  "Language": "aspernatur",
  "Sentiment": 434,
  "SentimentConfidence": 674,
  "SuggestedCategoryId": 617,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 971,
  "IconHint": "dolores",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 875
    }
  }
}
```