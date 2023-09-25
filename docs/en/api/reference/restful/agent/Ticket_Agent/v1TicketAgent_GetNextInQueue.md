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

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetNextInQueue
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 651,
  "Title": "ut",
  "CreatedAt": "2018-03-10T03:24:48.4560256+01:00",
  "LastChanged": "2014-12-08T03:24:48.4560256+01:00",
  "ReadByOwner": "2007-01-03T03:24:48.4560256+01:00",
  "ReadByCustomer": "2011-07-07T03:24:48.4560256+02:00",
  "FirstReadByOwner": "2005-05-23T03:24:48.4560256+02:00",
  "FirstReadByUser": "2022-06-27T03:24:48.4560256+02:00",
  "Activate": "1997-04-08T03:24:48.4560256+02:00",
  "ClosedAt": "2016-12-19T03:24:48.4560256+01:00",
  "RepliedAt": "2015-10-20T03:24:48.4560256+02:00",
  "AlertTimeout": "2008-09-09T03:24:48.4560256+02:00",
  "Deadline": "2019-08-18T03:24:48.4560256+02:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "PersonId": 808,
      "Mrmrs": "sit",
      "Firstname": "Guillermo",
      "Lastname": "Lind",
      "MiddleName": "Hermann, Nikolaus and Hudson",
      "Title": "ea",
      "Description": "Triple-buffered exuding paradigm",
      "Email": "tracy@casper.us",
      "FullName": "Mrs. Jessica Torphy MD",
      "DirectPhone": "(719)013-2383",
      "FormalName": "Douglas-Pfeffer",
      "CountryId": 658,
      "ContactId": 647,
      "ContactName": "Cole, Russel and Osinski",
      "Retired": 323,
      "Rank": 842,
      "ActiveInterests": 637,
      "ContactDepartment": "",
      "ContactCountryId": 742,
      "ContactOrgNr": "907611",
      "FaxPhone": "371-200-4291",
      "MobilePhone": "995-544-6622",
      "ContactPhone": "731-029-6804",
      "AssociateName": "Will-Bernhard",
      "AssociateId": 142,
      "UsePersonAddress": true,
      "ContactFax": "quaerat",
      "Kanafname": "autem",
      "Kanalname": "voluptatem",
      "Post1": "quod",
      "Post2": "expedita",
      "Post3": "magnam",
      "EmailName": "frederik@hagenes.co.uk",
      "ContactFullName": "Prof. Shanelle Jason Grant DVM",
      "ActiveErpLinks": 890,
      "TicketPriorityId": 1000,
      "SupportLanguageId": 696,
      "SupportAssociateId": 329,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "AlertLevel": 281,
  "ConnectId": 7,
  "ReadStatus": "Green",
  "TimeToReply": 49,
  "RealTimeToReply": 58,
  "TimeToClose": 902,
  "RealTimeToClose": 957,
  "TimeSpentInternally": 882,
  "TimeSpentExternally": 821,
  "TimeSpentQueue": 341,
  "RealTimeSpentInternally": 87,
  "RealTimeSpentExternally": 980,
  "RealTimeSpentQueue": 20,
  "TimeSpent": 832,
  "HasAttachment": false,
  "NumReplies": 837,
  "NumMessages": 203,
  "FromAddress": "hic",
  "Messages": [
    {
      "TicketMessageId": 690,
      "CreatedAt": "1998-06-12T03:24:48.4560256+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 916,
      "PersonFullName": "Domenico Gutmann",
      "ContactId": 257,
      "ContactName": "Schmitt Group",
      "ContactDepartment": "",
      "NumAttachments": 118,
      "EmailHeader": "tremayne@beattyemmerich.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 628,
      "SentimentConfidence": 806,
      "CreatedBy": 858,
      "ChangedAt": "2014-12-29T03:24:48.4560256+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 948
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 813,
      "Name": "Rogahn Inc and Sons",
      "ToolTip": "Consequuntur itaque voluptate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    },
    {
      "Id": 813,
      "Name": "Rogahn Inc and Sons",
      "ToolTip": "Consequuntur itaque voluptate.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 909,
  "SentimentConfidence": 180,
  "SuggestedCategoryId": 560,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 604,
  "IconHint": "optio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "ipsum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 961
    }
  }
}
```