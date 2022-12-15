---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
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

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity |  | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | array |  |


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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    159,
    915
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 993,
  "Title": "quis",
  "CreatedAt": "1996-07-06T02:49:45.5622206+02:00",
  "LastChanged": "2008-05-02T02:49:45.5622206+02:00",
  "ReadByOwner": "2008-12-01T02:49:45.5622206+01:00",
  "ReadByCustomer": "2002-01-29T02:49:45.5622206+01:00",
  "FirstReadByOwner": "2018-04-24T02:49:45.5622206+02:00",
  "FirstReadByUser": "2006-05-05T02:49:45.5622206+02:00",
  "Activate": "1997-05-01T02:49:45.5622206+02:00",
  "ClosedAt": "2012-05-14T02:49:45.5622206+02:00",
  "RepliedAt": "1998-06-28T02:49:45.5622206+02:00",
  "AlertTimeout": "2001-05-14T02:49:45.5622206+02:00",
  "Deadline": "1998-09-11T02:49:45.5622206+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "totam",
      "PersonId": 399,
      "Mrmrs": "enim",
      "Firstname": "Elisabeth",
      "Lastname": "Keeling",
      "MiddleName": "Daniel-Paucek",
      "Title": "explicabo",
      "Description": "Synergized homogeneous internet solution",
      "Email": "keeley.zulauf@framibaumbach.name",
      "FullName": "Pattie Kuhlman",
      "DirectPhone": "1-621-510-7530",
      "FormalName": "Abshire, Krajcik and Batz",
      "CountryId": 123,
      "ContactId": 146,
      "ContactName": "Mosciski Inc and Sons",
      "Retired": 836,
      "Rank": 902,
      "ActiveInterests": 714,
      "ContactDepartment": "",
      "ContactCountryId": 162,
      "ContactOrgNr": "546895",
      "FaxPhone": "1-585-668-8761 x365",
      "MobilePhone": "055-568-2635",
      "ContactPhone": "(377)400-6804",
      "AssociateName": "Bosco Group",
      "AssociateId": 773,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "omnis",
      "Kanalname": "aut",
      "Post1": "id",
      "Post2": "error",
      "Post3": "voluptas",
      "EmailName": "adolf_russel@schneiderbartell.biz",
      "ContactFullName": "Hassie Pfeffer",
      "ActiveErpLinks": 32,
      "TicketPriorityId": 685,
      "SupportLanguageId": 36,
      "SupportAssociateId": 838,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "AlertLevel": 675,
  "ConnectId": 241,
  "ReadStatus": "Green",
  "TimeToReply": 394,
  "RealTimeToReply": 441,
  "TimeToClose": 738,
  "RealTimeToClose": 792,
  "TimeSpentInternally": 67,
  "TimeSpentExternally": 282,
  "TimeSpentQueue": 629,
  "RealTimeSpentInternally": 618,
  "RealTimeSpentExternally": 14,
  "RealTimeSpentQueue": 401,
  "HasAttachment": false,
  "NumReplies": 376,
  "NumMessages": 660,
  "FromAddress": "laboriosam",
  "Messages": [
    {
      "TicketMessageId": 518,
      "CreatedAt": "2009-09-03T02:49:45.5778449+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "repellendus",
      "PersonId": 977,
      "PersonFullName": "Ms. Jeramy Jerrell Kohler",
      "ContactId": 509,
      "ContactName": "Bradtke Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 682,
      "EmailHeader": "alyson_walsh@cormierroberts.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatum",
      "Sentiment": 400,
      "SentimentConfidence": 148,
      "CreatedBy": 319,
      "ChangedAt": "2016-08-31T02:49:45.5778449+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 318,
      "Name": "Dach LLC",
      "ToolTip": "Neque consectetur quod et quia necessitatibus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    },
    {
      "Id": 318,
      "Name": "Dach LLC",
      "ToolTip": "Neque consectetur quod et quia necessitatibus.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    }
  ],
  "Language": "quaerat",
  "Sentiment": 791,
  "SentimentConfidence": 645,
  "SuggestedCategoryId": 503,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 585,
  "IconHint": "et",
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 139
    }
  }
}
```