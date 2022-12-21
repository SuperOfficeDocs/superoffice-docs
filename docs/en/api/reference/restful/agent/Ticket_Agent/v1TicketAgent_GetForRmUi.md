---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
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

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 |  |


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
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 337
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 968,
  "Title": "consequatur",
  "CreatedAt": "1997-03-23T02:49:45.5153435+01:00",
  "LastChanged": "2009-12-18T02:49:45.5153435+01:00",
  "ReadByOwner": "2013-11-24T02:49:45.5153435+01:00",
  "ReadByCustomer": "2018-11-04T02:49:45.5153435+01:00",
  "FirstReadByOwner": "2015-05-13T02:49:45.5153435+02:00",
  "FirstReadByUser": "2022-09-30T02:49:45.5153435+02:00",
  "Activate": "2004-01-16T02:49:45.5153435+01:00",
  "ClosedAt": "2013-05-09T02:49:45.5153435+02:00",
  "RepliedAt": "2015-05-07T02:49:45.5153435+02:00",
  "AlertTimeout": "2006-01-14T02:49:45.5153435+01:00",
  "Deadline": "2013-03-17T02:49:45.5153435+01:00",
  "CreatedBy": null,
  "Author": "quis",
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
      "Position": "nostrum",
      "PersonId": 239,
      "Mrmrs": "deleniti",
      "Firstname": "Colten",
      "Lastname": "Rowe",
      "MiddleName": "Cassin Inc and Sons",
      "Title": "similique",
      "Description": "Cloned systemic methodology",
      "Email": "kade@prohaska.biz",
      "FullName": "Dr. Delilah Eladio Bauch DDS",
      "DirectPhone": "449.468.6042 x9888",
      "FormalName": "Beier-Parisian",
      "CountryId": 770,
      "ContactId": 507,
      "ContactName": "D'Amore, Wuckert and Smitham",
      "Retired": 298,
      "Rank": 70,
      "ActiveInterests": 784,
      "ContactDepartment": "",
      "ContactCountryId": 105,
      "ContactOrgNr": "911348",
      "FaxPhone": "(731)330-8605",
      "MobilePhone": "1-177-578-8551 x40462",
      "ContactPhone": "378-201-4185 x1908",
      "AssociateName": "Powlowski Inc and Sons",
      "AssociateId": 691,
      "UsePersonAddress": false,
      "ContactFax": "mollitia",
      "Kanafname": "quo",
      "Kanalname": "voluptas",
      "Post1": "cum",
      "Post2": "aperiam",
      "Post3": "minima",
      "EmailName": "van@goodwinwaelchi.ca",
      "ContactFullName": "Kaitlin Welch",
      "ActiveErpLinks": 402,
      "TicketPriorityId": 859,
      "SupportLanguageId": 951,
      "SupportAssociateId": 661,
      "CategoryName": "VIP Customer",
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
  "AlertLevel": 159,
  "ConnectId": 780,
  "ReadStatus": "Green",
  "TimeToReply": 685,
  "RealTimeToReply": 470,
  "TimeToClose": 855,
  "RealTimeToClose": 968,
  "TimeSpentInternally": 580,
  "TimeSpentExternally": 253,
  "TimeSpentQueue": 324,
  "RealTimeSpentInternally": 48,
  "RealTimeSpentExternally": 342,
  "RealTimeSpentQueue": 462,
  "HasAttachment": false,
  "NumReplies": 445,
  "NumMessages": 30,
  "FromAddress": "modi",
  "Messages": [
    {
      "TicketMessageId": 748,
      "CreatedAt": "2001-02-13T02:49:45.5153435+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "est",
      "PersonId": 796,
      "PersonFullName": "Ms. Neoma Jarrod Gleason",
      "ContactId": 612,
      "ContactName": "Hirthe-Runolfsson",
      "ContactDepartment": "",
      "NumAttachments": 14,
      "EmailHeader": "drew@kohler.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "praesentium",
      "Sentiment": 914,
      "SentimentConfidence": 51,
      "CreatedBy": 71,
      "ChangedAt": "2013-09-05T02:49:45.5153435+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 545
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 104,
      "Name": "Altenwerth, Heller and Rodriguez",
      "ToolTip": "Ut sed ut eius magnam facilis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    },
    {
      "Id": 104,
      "Name": "Altenwerth, Heller and Rodriguez",
      "ToolTip": "Ut sed ut eius magnam facilis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    }
  ],
  "Language": "cumque",
  "Sentiment": 502,
  "SentimentConfidence": 590,
  "SuggestedCategoryId": 950,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 37,
  "IconHint": "explicabo",
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "perferendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 747
    }
  }
}
```