---
title: POST Agents/Ticket/SaveTicketEntityWithNotify
uid: v1TicketAgent_SaveTicketEntityWithNotify
---

# POST Agents/Ticket/SaveTicketEntityWithNotify

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
```

Saves a ticket and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify?$select=name,department,category/id
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

NewEntity, Notify 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewEntity |  | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| Notify | bool |  |


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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "NewEntity": null,
  "Notify": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 8,
  "Title": "vitae",
  "CreatedAt": "2017-04-22T11:10:28.2862071+02:00",
  "LastChanged": "2004-12-19T11:10:28.2862071+01:00",
  "ReadByOwner": "2020-07-19T11:10:28.2862071+02:00",
  "ReadByCustomer": "2014-11-04T11:10:28.2862071+01:00",
  "FirstReadByUser": "2003-10-21T11:10:28.2862071+02:00",
  "Activate": "2009-08-29T11:10:28.2862071+02:00",
  "ClosedAt": "2008-07-26T11:10:28.2862071+02:00",
  "RepliedAt": "2011-06-13T11:10:28.2862071+02:00",
  "AlertTimeout": "1997-03-06T11:10:28.2862071+01:00",
  "Deadline": "2012-07-04T11:10:28.2862071+02:00",
  "CreatedBy": null,
  "Author": "adipisci",
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
      "Position": "nesciunt",
      "PersonId": 632,
      "Mrmrs": "ea",
      "Firstname": "Ramona",
      "Lastname": "Leuschke",
      "MiddleName": "Keeling-Turner",
      "Title": "ratione",
      "Description": "De-engineered composite benchmark",
      "Email": "narciso_rolfson@kuhicohara.info",
      "FullName": "Alex Boyer",
      "DirectPhone": "1-120-761-4518 x886",
      "FormalName": "Bogan LLC",
      "CountryId": 12,
      "ContactId": 272,
      "ContactName": "Hermiston, Strosin and Feest",
      "Retired": 948,
      "Rank": 868,
      "ActiveInterests": 583,
      "ContactDepartment": "",
      "ContactCountryId": 935,
      "ContactOrgNr": "749470",
      "FaxPhone": "1-580-998-6828 x402",
      "MobilePhone": "451.167.7548",
      "ContactPhone": "162.100.1335",
      "AssociateName": "Heathcote-Blanda",
      "AssociateId": 755,
      "UsePersonAddress": false,
      "ContactFax": "placeat",
      "Kanafname": "eius",
      "Kanalname": "qui",
      "Post1": "ut",
      "Post2": "et",
      "Post3": "molestias",
      "EmailName": "birdie@schowalter.us",
      "ContactFullName": "Berta Morissette",
      "ActiveErpLinks": 980,
      "TicketPriorityId": 611,
      "SupportLanguageId": 933,
      "SupportAssociateId": 894,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "AlertLevel": 848,
  "ConnectId": 674,
  "ReadStatus": "Green",
  "TimeToReply": 917,
  "RealTimeToReply": 559,
  "TimeToClose": 56,
  "RealTimeToClose": 852,
  "TimeSpentInternally": 63,
  "TimeSpentExternally": 322,
  "TimeSpentQueue": 227,
  "RealTimeSpentInternally": 241,
  "RealTimeSpentExternally": 7,
  "RealTimeSpentQueue": 350,
  "HasAttachment": false,
  "NumReplies": 616,
  "NumMessages": 768,
  "FromAddress": "facere",
  "Messages": [
    {
      "TicketMessageId": 672,
      "CreatedAt": "1999-12-31T11:10:28.2902066+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 215,
      "PersonFullName": "Deion Zboncak",
      "ContactId": 30,
      "ContactName": "Klocko-Dach",
      "ContactDepartment": "",
      "NumAttachments": 656,
      "EmailHeader": "rogers_hammes@robel.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "tempora",
      "Sentiment": 944,
      "SentimentConfidence": 888,
      "CreatedBy": 757,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 325,
      "Name": "Keeling Inc and Sons",
      "ToolTip": "Nam sapiente sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 738
        }
      }
    },
    {
      "Id": 325,
      "Name": "Keeling Inc and Sons",
      "ToolTip": "Nam sapiente sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 738
        }
      }
    }
  ],
  "Language": "incidunt",
  "Sentiment": 964,
  "SentimentConfidence": 48,
  "SuggestedCategoryId": 585,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 617,
  "IconHint": "quia",
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "repudiandae",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 812
    }
  }
}
```