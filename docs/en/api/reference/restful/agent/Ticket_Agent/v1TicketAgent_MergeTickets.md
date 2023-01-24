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
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    228,
    834
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 553,
  "Title": "animi",
  "CreatedAt": "2007-08-14T11:22:39.523803+02:00",
  "LastChanged": "2003-09-01T11:22:39.523803+02:00",
  "ReadByOwner": "1999-11-18T11:22:39.523803+01:00",
  "ReadByCustomer": "2002-12-13T11:22:39.523803+01:00",
  "FirstReadByOwner": "2016-06-09T11:22:39.523803+02:00",
  "FirstReadByUser": "2011-11-08T11:22:39.523803+01:00",
  "Activate": "1996-10-23T11:22:39.523803+02:00",
  "ClosedAt": "2014-06-19T11:22:39.523803+02:00",
  "RepliedAt": "2003-03-04T11:22:39.523803+01:00",
  "AlertTimeout": "2009-02-24T11:22:39.523803+01:00",
  "Deadline": "2012-03-07T11:22:39.523803+01:00",
  "CreatedBy": null,
  "Author": "similique",
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
      "Position": "asperiores",
      "PersonId": 7,
      "Mrmrs": "porro",
      "Firstname": "Meagan",
      "Lastname": "Bode",
      "MiddleName": "Labadie, Stracke and Rempel",
      "Title": "est",
      "Description": "Future-proofed leading edge time-frame",
      "Email": "edward.collins@abshire.name",
      "FullName": "Prof. Milan Alejandrin Yundt",
      "DirectPhone": "(575)635-5572",
      "FormalName": "Miller-Gerhold",
      "CountryId": 714,
      "ContactId": 283,
      "ContactName": "Lynch, Parisian and Sanford",
      "Retired": 748,
      "Rank": 848,
      "ActiveInterests": 285,
      "ContactDepartment": "",
      "ContactCountryId": 299,
      "ContactOrgNr": "1114400",
      "FaxPhone": "1-329-138-5954 x1748",
      "MobilePhone": "463.115.2052 x408",
      "ContactPhone": "436.211.5574 x6781",
      "AssociateName": "Cremin, Bergnaum and Powlowski",
      "AssociateId": 467,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "quo",
      "Kanalname": "non",
      "Post1": "dolores",
      "Post2": "vel",
      "Post3": "facilis",
      "EmailName": "maximillia@prosacco.info",
      "ContactFullName": "Mr. Monserrat Mayer III",
      "ActiveErpLinks": 401,
      "TicketPriorityId": 292,
      "SupportLanguageId": 972,
      "SupportAssociateId": 104,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    }
  ],
  "AlertLevel": 186,
  "ConnectId": 417,
  "ReadStatus": "Green",
  "TimeToReply": 418,
  "RealTimeToReply": 135,
  "TimeToClose": 513,
  "RealTimeToClose": 374,
  "TimeSpentInternally": 171,
  "TimeSpentExternally": 859,
  "TimeSpentQueue": 20,
  "RealTimeSpentInternally": 554,
  "RealTimeSpentExternally": 24,
  "RealTimeSpentQueue": 655,
  "HasAttachment": true,
  "NumReplies": 430,
  "NumMessages": 870,
  "FromAddress": "quos",
  "Messages": [
    {
      "TicketMessageId": 213,
      "CreatedAt": "2009-04-19T11:22:39.523803+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "culpa",
      "PersonId": 616,
      "PersonFullName": "Karley Mckayla Steuber DDS",
      "ContactId": 563,
      "ContactName": "Thompson, Douglas and Berge",
      "ContactDepartment": "",
      "NumAttachments": 264,
      "EmailHeader": "savanah_spencer@armstrongrunolfsdottir.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nostrum",
      "Sentiment": 487,
      "SentimentConfidence": 800,
      "CreatedBy": 226,
      "ChangedAt": "2007-07-06T11:22:39.523803+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 758
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 236,
      "Name": "Krajcik Group",
      "ToolTip": "Veniam quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Id": 236,
      "Name": "Krajcik Group",
      "ToolTip": "Veniam quia.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Language": "illum",
  "Sentiment": 646,
  "SentimentConfidence": 107,
  "SuggestedCategoryId": 406,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 890,
  "IconHint": "iure",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 902
    }
  }
}
```