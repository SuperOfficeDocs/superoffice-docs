---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
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

SourceTicketEntityId, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | int32 |  |
| TransferMessageIds | array |  |
| NewTicketEntity |  | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |


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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 221,
  "TransferMessageIds": [
    874,
    949
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 656,
  "Title": "deleniti",
  "CreatedAt": "1999-08-05T02:49:45.5465952+02:00",
  "LastChanged": "2015-10-27T02:49:45.5465952+01:00",
  "ReadByOwner": "2002-10-10T02:49:45.5465952+02:00",
  "ReadByCustomer": "1996-05-15T02:49:45.5465952+02:00",
  "FirstReadByOwner": "1995-09-07T02:49:45.5465952+02:00",
  "FirstReadByUser": "2003-09-07T02:49:45.5465952+02:00",
  "Activate": "2021-12-10T02:49:45.5465952+01:00",
  "ClosedAt": "2010-05-30T02:49:45.5465952+02:00",
  "RepliedAt": "2010-12-21T02:49:45.5465952+01:00",
  "AlertTimeout": "2014-10-20T02:49:45.5465952+02:00",
  "Deadline": "2010-01-14T02:49:45.5465952+01:00",
  "CreatedBy": null,
  "Author": "ex",
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
      "Position": "dolores",
      "PersonId": 406,
      "Mrmrs": "id",
      "Firstname": "Anais",
      "Lastname": "Hand",
      "MiddleName": "Boyer-Jakubowski",
      "Title": "temporibus",
      "Description": "Adaptive transitional project",
      "Email": "jaclyn@ankundingvandervort.name",
      "FullName": "Ms. Selmer Roscoe Will V",
      "DirectPhone": "129-183-2726 x856",
      "FormalName": "Feeney, Johnston and Stark",
      "CountryId": 576,
      "ContactId": 779,
      "ContactName": "Raynor-Marks",
      "Retired": 991,
      "Rank": 661,
      "ActiveInterests": 446,
      "ContactDepartment": "",
      "ContactCountryId": 504,
      "ContactOrgNr": "828486",
      "FaxPhone": "1-165-855-5694 x86151",
      "MobilePhone": "485.764.8130 x042",
      "ContactPhone": "323.394.1564",
      "AssociateName": "Hoeger Inc and Sons",
      "AssociateId": 299,
      "UsePersonAddress": true,
      "ContactFax": "illo",
      "Kanafname": "nisi",
      "Kanalname": "necessitatibus",
      "Post1": "sequi",
      "Post2": "ut",
      "Post3": "facilis",
      "EmailName": "jacquelyn@botsfordcarter.com",
      "ContactFullName": "Prof. Magnolia Tyra Kovacek PhD",
      "ActiveErpLinks": 977,
      "TicketPriorityId": 987,
      "SupportLanguageId": 377,
      "SupportAssociateId": 678,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 462
        }
      }
    }
  ],
  "AlertLevel": 650,
  "ConnectId": 465,
  "ReadStatus": "Green",
  "TimeToReply": 414,
  "RealTimeToReply": 167,
  "TimeToClose": 259,
  "RealTimeToClose": 841,
  "TimeSpentInternally": 39,
  "TimeSpentExternally": 588,
  "TimeSpentQueue": 583,
  "RealTimeSpentInternally": 994,
  "RealTimeSpentExternally": 96,
  "RealTimeSpentQueue": 211,
  "HasAttachment": false,
  "NumReplies": 106,
  "NumMessages": 979,
  "FromAddress": "repellat",
  "Messages": [
    {
      "TicketMessageId": 969,
      "CreatedAt": "2013-11-20T02:49:45.5465952+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "neque",
      "PersonId": 278,
      "PersonFullName": "Nettie Gutkowski",
      "ContactId": 240,
      "ContactName": "Fahey Group",
      "ContactDepartment": "",
      "NumAttachments": 907,
      "EmailHeader": "cedrick_predovic@bechtelar.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "earum",
      "Sentiment": 65,
      "SentimentConfidence": 467,
      "CreatedBy": 251,
      "ChangedAt": "2018-12-14T02:49:45.5465952+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 692,
      "Name": "Miller, Jakubowski and O'Kon",
      "ToolTip": "Expedita labore fuga eum distinctio quaerat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    },
    {
      "Id": 692,
      "Name": "Miller, Jakubowski and O'Kon",
      "ToolTip": "Expedita labore fuga eum distinctio quaerat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    }
  ],
  "Language": "maxime",
  "Sentiment": 268,
  "SentimentConfidence": 335,
  "SuggestedCategoryId": 339,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 151,
  "IconHint": "exercitationem",
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 163
    }
  }
}
```