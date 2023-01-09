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
| SourceTicketEntityId | Integer |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 961,
  "TransferMessageIds": [
    860,
    640
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 569,
  "Title": "ad",
  "CreatedAt": "2015-05-11T17:37:19.4039758+02:00",
  "LastChanged": "2014-09-17T17:37:19.4039758+02:00",
  "ReadByOwner": "1996-04-17T17:37:19.4039758+02:00",
  "ReadByCustomer": "1998-06-13T17:37:19.4039758+02:00",
  "FirstReadByOwner": "2009-02-23T17:37:19.4039758+01:00",
  "FirstReadByUser": "2007-06-11T17:37:19.4039758+02:00",
  "Activate": "1995-11-04T17:37:19.4039758+01:00",
  "ClosedAt": "2012-01-11T17:37:19.4039758+01:00",
  "RepliedAt": "2010-08-23T17:37:19.4039758+02:00",
  "AlertTimeout": "2021-04-05T17:37:19.4039758+02:00",
  "Deadline": "2014-10-17T17:37:19.4039758+02:00",
  "CreatedBy": null,
  "Author": "natus",
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
      "Position": "eius",
      "PersonId": 889,
      "Mrmrs": "eum",
      "Firstname": "Louisa",
      "Lastname": "Maggio",
      "MiddleName": "Koepp Inc and Sons",
      "Title": "omnis",
      "Description": "Streamlined 6th generation help-desk",
      "Email": "madaline@robelhalvorson.us",
      "FullName": "Audra Larson",
      "DirectPhone": "089.535.1161",
      "FormalName": "Tillman, Rogahn and Thompson",
      "CountryId": 948,
      "ContactId": 53,
      "ContactName": "Kling Group",
      "Retired": 939,
      "Rank": 351,
      "ActiveInterests": 832,
      "ContactDepartment": "architect scalable relationships",
      "ContactCountryId": 818,
      "ContactOrgNr": "967613",
      "FaxPhone": "(684)173-8233 x600",
      "MobilePhone": "474.304.8489",
      "ContactPhone": "1-898-843-9506 x206",
      "AssociateName": "Mraz, Turcotte and Conn",
      "AssociateId": 720,
      "UsePersonAddress": false,
      "ContactFax": "explicabo",
      "Kanafname": "dolorem",
      "Kanalname": "ipsum",
      "Post1": "et",
      "Post2": "et",
      "Post3": "non",
      "EmailName": "rafael.bogisich@lind.ca",
      "ContactFullName": "Deja DuBuque MD",
      "ActiveErpLinks": 467,
      "TicketPriorityId": 618,
      "SupportLanguageId": 905,
      "SupportAssociateId": 605,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "AlertLevel": 938,
  "ConnectId": 557,
  "ReadStatus": "Green",
  "TimeToReply": 214,
  "RealTimeToReply": 64,
  "TimeToClose": 139,
  "RealTimeToClose": 170,
  "TimeSpentInternally": 65,
  "TimeSpentExternally": 485,
  "TimeSpentQueue": 198,
  "RealTimeSpentInternally": 418,
  "RealTimeSpentExternally": 479,
  "RealTimeSpentQueue": 77,
  "HasAttachment": true,
  "NumReplies": 806,
  "NumMessages": 591,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 776,
      "CreatedAt": "2021-02-20T17:37:19.407976+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 757,
      "PersonFullName": "Maud Tremblay",
      "ContactId": 458,
      "ContactName": "Abernathy, Ryan and Schneider",
      "ContactDepartment": "",
      "NumAttachments": 835,
      "EmailHeader": "kristin_hilpert@strosin.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "officia",
      "Sentiment": 18,
      "SentimentConfidence": 495,
      "CreatedBy": 476,
      "ChangedAt": "2000-06-29T17:37:19.4089772+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 551
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 70,
      "Name": "Keebler Inc and Sons",
      "ToolTip": "Labore voluptas dolorem quod.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    },
    {
      "Id": 70,
      "Name": "Keebler Inc and Sons",
      "ToolTip": "Labore voluptas dolorem quod.",
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
  "Language": "dolore",
  "Sentiment": 627,
  "SentimentConfidence": 534,
  "SuggestedCategoryId": 645,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 336,
  "IconHint": "labore",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "dolorem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 83
    }
  }
}
```