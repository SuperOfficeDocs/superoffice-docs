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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=985
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

Response body: 

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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 312,
  "Title": "labore",
  "CreatedAt": "2004-09-12T02:49:45.4997188+02:00",
  "LastChanged": "2001-05-18T02:49:45.4997188+02:00",
  "ReadByOwner": "2020-05-21T02:49:45.4997188+02:00",
  "ReadByCustomer": "2020-12-30T02:49:45.4997188+01:00",
  "FirstReadByOwner": "2012-08-01T02:49:45.4997188+02:00",
  "FirstReadByUser": "2000-07-10T02:49:45.4997188+02:00",
  "Activate": "1995-11-01T02:49:45.4997188+01:00",
  "ClosedAt": "2013-08-08T02:49:45.4997188+02:00",
  "RepliedAt": "2019-02-05T02:49:45.4997188+01:00",
  "AlertTimeout": "2016-05-08T02:49:45.4997188+02:00",
  "Deadline": "2009-01-25T02:49:45.4997188+01:00",
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
      "Position": "qui",
      "PersonId": 479,
      "Mrmrs": "inventore",
      "Firstname": "Dane",
      "Lastname": "Dooley",
      "MiddleName": "Buckridge Group",
      "Title": "et",
      "Description": "Fully-configurable mission-critical firmware",
      "Email": "evie_metz@cartwright.us",
      "FullName": "Laurianne Stehr",
      "DirectPhone": "(361)933-3007 x448",
      "FormalName": "Jaskolski Inc and Sons",
      "CountryId": 202,
      "ContactId": 823,
      "ContactName": "Brakus, Schroeder and Lemke",
      "Retired": 977,
      "Rank": 833,
      "ActiveInterests": 701,
      "ContactDepartment": "",
      "ContactCountryId": 490,
      "ContactOrgNr": "1434475",
      "FaxPhone": "(112)332-2416 x0023",
      "MobilePhone": "(650)703-1850 x750",
      "ContactPhone": "879-494-6107",
      "AssociateName": "Morissette-Cassin",
      "AssociateId": 903,
      "UsePersonAddress": false,
      "ContactFax": "recusandae",
      "Kanafname": "unde",
      "Kanalname": "aut",
      "Post1": "dolore",
      "Post2": "ratione",
      "Post3": "sit",
      "EmailName": "darron.boyle@stehr.us",
      "ContactFullName": "Eldon Crona",
      "ActiveErpLinks": 827,
      "TicketPriorityId": 35,
      "SupportLanguageId": 474,
      "SupportAssociateId": 593,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "AlertLevel": 351,
  "ConnectId": 558,
  "ReadStatus": "Green",
  "TimeToReply": 408,
  "RealTimeToReply": 618,
  "TimeToClose": 398,
  "RealTimeToClose": 261,
  "TimeSpentInternally": 11,
  "TimeSpentExternally": 852,
  "TimeSpentQueue": 662,
  "RealTimeSpentInternally": 390,
  "RealTimeSpentExternally": 513,
  "RealTimeSpentQueue": 597,
  "HasAttachment": false,
  "NumReplies": 588,
  "NumMessages": 97,
  "FromAddress": "excepturi",
  "Messages": [
    {
      "TicketMessageId": 616,
      "CreatedAt": "2018-03-11T02:49:45.4997188+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "aut",
      "PersonId": 120,
      "PersonFullName": "Juston Hartmann",
      "ContactId": 416,
      "ContactName": "Leuschke-DuBuque",
      "ContactDepartment": "",
      "NumAttachments": 192,
      "EmailHeader": "dina@schultzdaniel.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "illum",
      "Sentiment": 396,
      "SentimentConfidence": 485,
      "CreatedBy": 513,
      "ChangedAt": "2020-06-27T02:49:45.4997188+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 303,
      "Name": "Kemmer Inc and Sons",
      "ToolTip": "Delectus magni delectus illo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 256
        }
      }
    },
    {
      "Id": 303,
      "Name": "Kemmer Inc and Sons",
      "ToolTip": "Delectus magni delectus illo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 256
        }
      }
    }
  ],
  "Language": "rem",
  "Sentiment": 169,
  "SentimentConfidence": 844,
  "SuggestedCategoryId": 329,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 529,
  "IconHint": "omnis",
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "laudantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 155
    }
  }
}
```