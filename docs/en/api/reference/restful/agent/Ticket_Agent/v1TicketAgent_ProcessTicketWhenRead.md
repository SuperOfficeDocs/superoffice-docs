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
POST /api/v1/Agents/Ticket/ProcessTicketWhenRead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketEntityId": 298
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 426,
  "Title": "accusantium",
  "CreatedAt": "2001-02-12T11:44:34.8219427+01:00",
  "LastChanged": "2002-01-09T11:44:34.8219427+01:00",
  "ReadByOwner": "1998-06-28T11:44:34.8219427+02:00",
  "ReadByCustomer": "2010-12-18T11:44:34.8219427+01:00",
  "FirstReadByOwner": "2023-09-05T11:44:34.8219427+02:00",
  "FirstReadByUser": "1999-02-19T11:44:34.8219427+01:00",
  "Activate": "2013-11-06T11:44:34.8219427+01:00",
  "ClosedAt": "2023-10-19T11:44:34.8219427+02:00",
  "RepliedAt": "2010-02-05T11:44:34.8219427+01:00",
  "AlertTimeout": "2013-05-27T11:44:34.8219427+02:00",
  "Deadline": "2006-08-04T11:44:34.8219427+02:00",
  "CreatedBy": null,
  "Author": "recusandae",
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
      "Position": "similique",
      "PersonId": 81,
      "Mrmrs": "dicta",
      "Firstname": "Sheila",
      "Lastname": "Reilly",
      "MiddleName": "Schneider, Moore and Hartmann",
      "Title": "commodi",
      "Description": "Customizable modular internet solution",
      "Email": "anya@pourospouros.info",
      "FullName": "Maxie Breitenberg",
      "DirectPhone": "(819)066-3733",
      "FormalName": "Quitzon-Durgan",
      "CountryId": 863,
      "ContactId": 702,
      "ContactName": "Durgan, Wyman and Walsh",
      "Retired": 789,
      "Rank": 138,
      "ActiveInterests": 72,
      "ContactDepartment": "",
      "ContactCountryId": 47,
      "ContactOrgNr": "1340714",
      "FaxPhone": "399.420.7271",
      "MobilePhone": "1-636-377-8698",
      "ContactPhone": "(196)177-1586",
      "AssociateName": "Bahringer-Pagac",
      "AssociateId": 242,
      "UsePersonAddress": true,
      "ContactFax": "numquam",
      "Kanafname": "fugiat",
      "Kanalname": "vel",
      "Post1": "quos",
      "Post2": "dolor",
      "Post3": "consequatur",
      "EmailName": "harmony@feil.biz",
      "ContactFullName": "Verner Gerhold",
      "ActiveErpLinks": 883,
      "TicketPriorityId": 861,
      "SupportLanguageId": 211,
      "SupportAssociateId": 883,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 593
        }
      }
    }
  ],
  "AlertLevel": 703,
  "ConnectId": 719,
  "ReadStatus": "Green",
  "TimeToReply": 724,
  "RealTimeToReply": 75,
  "TimeToClose": 354,
  "RealTimeToClose": 209,
  "TimeSpentInternally": 878,
  "TimeSpentExternally": 764,
  "TimeSpentQueue": 126,
  "RealTimeSpentInternally": 902,
  "RealTimeSpentExternally": 36,
  "RealTimeSpentQueue": 935,
  "TimeSpent": 703,
  "HasAttachment": false,
  "NumReplies": 131,
  "NumMessages": 476,
  "FromAddress": "ut",
  "Messages": [
    {
      "TicketMessageId": 979,
      "CreatedAt": "2019-12-29T11:44:34.8219427+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "hic",
      "PersonId": 407,
      "PersonFullName": "Dexter Goyette DVM",
      "ContactId": 384,
      "ContactName": "Block-Streich",
      "ContactDepartment": "",
      "NumAttachments": 1001,
      "EmailHeader": "fannie.bode@brownhessel.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nemo",
      "Sentiment": 445,
      "SentimentConfidence": 358,
      "CreatedBy": 167,
      "ChangedAt": "1997-01-16T11:44:34.8219427+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 568
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 700,
      "Name": "Lind, Zulauf and Jacobi",
      "ToolTip": "Eos ut autem similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    },
    {
      "Id": 700,
      "Name": "Lind, Zulauf and Jacobi",
      "ToolTip": "Eos ut autem similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    }
  ],
  "Language": "quasi",
  "Sentiment": 263,
  "SentimentConfidence": 758,
  "SuggestedCategoryId": 569,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 698,
  "IconHint": "repudiandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 90,
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 315
    }
  }
}
```