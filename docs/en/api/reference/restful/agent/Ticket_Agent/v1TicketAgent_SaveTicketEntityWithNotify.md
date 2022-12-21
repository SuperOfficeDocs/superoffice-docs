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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "NewEntity": null,
  "Notify": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 784,
  "Title": "molestiae",
  "CreatedAt": "2007-09-11T02:49:45.5309702+02:00",
  "LastChanged": "2013-12-24T02:49:45.5309702+01:00",
  "ReadByOwner": "2020-12-28T02:49:45.5309702+01:00",
  "ReadByCustomer": "2022-07-28T02:49:45.5309702+02:00",
  "FirstReadByOwner": "1999-10-21T02:49:45.5309702+02:00",
  "FirstReadByUser": "2012-08-19T02:49:45.5309702+02:00",
  "Activate": "2020-04-24T02:49:45.5309702+02:00",
  "ClosedAt": "2021-09-02T02:49:45.5309702+02:00",
  "RepliedAt": "1997-01-07T02:49:45.5309702+01:00",
  "AlertTimeout": "2008-11-21T02:49:45.5309702+01:00",
  "Deadline": "2017-05-12T02:49:45.5309702+02:00",
  "CreatedBy": null,
  "Author": "soluta",
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
      "Position": "aut",
      "PersonId": 67,
      "Mrmrs": "tempore",
      "Firstname": "Maryjane",
      "Lastname": "Hickle",
      "MiddleName": "Wolf-Lueilwitz",
      "Title": "similique",
      "Description": "De-engineered dynamic moratorium",
      "Email": "dell_graham@shields.ca",
      "FullName": "Domenic Mills",
      "DirectPhone": "764.650.1373 x237",
      "FormalName": "Ankunding-Flatley",
      "CountryId": 302,
      "ContactId": 650,
      "ContactName": "Muller Inc and Sons",
      "Retired": 200,
      "Rank": 806,
      "ActiveInterests": 641,
      "ContactDepartment": "",
      "ContactCountryId": 69,
      "ContactOrgNr": "1510461",
      "FaxPhone": "125.032.3408 x96981",
      "MobilePhone": "(273)843-7766 x0913",
      "ContactPhone": "992-013-9793 x32434",
      "AssociateName": "King, Rice and Dicki",
      "AssociateId": 666,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "et",
      "Kanalname": "consequuntur",
      "Post1": "quis",
      "Post2": "illum",
      "Post3": "recusandae",
      "EmailName": "edythe.gerlach@kihn.uk",
      "ContactFullName": "Miss Palma Aimee Dare IV",
      "ActiveErpLinks": 572,
      "TicketPriorityId": 896,
      "SupportLanguageId": 541,
      "SupportAssociateId": 757,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 582
        }
      }
    }
  ],
  "AlertLevel": 441,
  "ConnectId": 46,
  "ReadStatus": "Green",
  "TimeToReply": 678,
  "RealTimeToReply": 783,
  "TimeToClose": 129,
  "RealTimeToClose": 201,
  "TimeSpentInternally": 55,
  "TimeSpentExternally": 174,
  "TimeSpentQueue": 71,
  "RealTimeSpentInternally": 733,
  "RealTimeSpentExternally": 901,
  "RealTimeSpentQueue": 80,
  "HasAttachment": false,
  "NumReplies": 699,
  "NumMessages": 81,
  "FromAddress": "ratione",
  "Messages": [
    {
      "TicketMessageId": 723,
      "CreatedAt": "2002-03-30T02:49:45.5309702+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "alias",
      "PersonId": 43,
      "PersonFullName": "Miss Mia Upton Jr.",
      "ContactId": 152,
      "ContactName": "Borer-Gerhold",
      "ContactDepartment": "",
      "NumAttachments": 21,
      "EmailHeader": "georgianna_ullrich@kirlin.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "rerum",
      "Sentiment": 166,
      "SentimentConfidence": 176,
      "CreatedBy": 612,
      "ChangedAt": "1997-06-30T02:49:45.5309702+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 274,
      "Name": "McGlynn-Mante",
      "ToolTip": "Voluptates minima dolores quas ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 379
        }
      }
    },
    {
      "Id": 274,
      "Name": "McGlynn-Mante",
      "ToolTip": "Voluptates minima dolores quas ut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 379
        }
      }
    }
  ],
  "Language": "reiciendis",
  "Sentiment": 864,
  "SentimentConfidence": 222,
  "SuggestedCategoryId": 170,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 168,
  "IconHint": "consectetur",
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "ab"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 111
    }
  }
}
```