---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
---

# GET Ticket/{id}

```http
GET /api/v1/Ticket/{id}
```

Gets a TicketEntity object.


Calls the Ticket agent service GetTicketEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Ticket/{id}?$select=name,department,category/id
GET /api/v1/Ticket/{id}?fk=True
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

TicketEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity found. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 370,
  "Title": "dolore",
  "CreatedAt": "1998-04-11T02:49:51.5831853+02:00",
  "LastChanged": "1997-07-08T02:49:51.5831853+02:00",
  "ReadByOwner": "2019-12-20T02:49:51.5831853+01:00",
  "ReadByCustomer": "2011-07-07T02:49:51.5831853+02:00",
  "FirstReadByOwner": "1995-12-22T02:49:51.5831853+01:00",
  "FirstReadByUser": "2005-02-12T02:49:51.5831853+01:00",
  "Activate": "2003-04-03T02:49:51.5831853+02:00",
  "ClosedAt": "2014-05-12T02:49:51.5831853+02:00",
  "RepliedAt": "2017-11-03T02:49:51.5831853+01:00",
  "AlertTimeout": "2002-02-20T02:49:51.5831853+01:00",
  "Deadline": "2021-03-22T02:49:51.5831853+01:00",
  "CreatedBy": null,
  "Author": "sit",
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
      "Position": "ipsa",
      "PersonId": 98,
      "Mrmrs": "ratione",
      "Firstname": "Francesca",
      "Lastname": "Hane",
      "MiddleName": "Weber, Lehner and Stehr",
      "Title": "eligendi",
      "Description": "Operative upward-trending success",
      "Email": "delilah@kilbackbalistreri.ca",
      "FullName": "Abbigail Kulas",
      "DirectPhone": "226-727-4936",
      "FormalName": "Stracke LLC",
      "CountryId": 288,
      "ContactId": 740,
      "ContactName": "Mohr Inc and Sons",
      "Retired": 312,
      "Rank": 68,
      "ActiveInterests": 711,
      "ContactDepartment": "",
      "ContactCountryId": 786,
      "ContactOrgNr": "440318",
      "FaxPhone": "040.523.4895 x364",
      "MobilePhone": "1-248-583-7655",
      "ContactPhone": "022.504.1297 x6647",
      "AssociateName": "Abbott-Kihn",
      "AssociateId": 8,
      "UsePersonAddress": true,
      "ContactFax": "velit",
      "Kanafname": "temporibus",
      "Kanalname": "atque",
      "Post1": "sint",
      "Post2": "omnis",
      "Post3": "adipisci",
      "EmailName": "laura@schulist.info",
      "ContactFullName": "Buddy Waters",
      "ActiveErpLinks": 46,
      "TicketPriorityId": 642,
      "SupportLanguageId": 197,
      "SupportAssociateId": 837,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "AlertLevel": 58,
  "ConnectId": 923,
  "ReadStatus": "Green",
  "TimeToReply": 652,
  "RealTimeToReply": 303,
  "TimeToClose": 688,
  "RealTimeToClose": 984,
  "TimeSpentInternally": 708,
  "TimeSpentExternally": 487,
  "TimeSpentQueue": 243,
  "RealTimeSpentInternally": 175,
  "RealTimeSpentExternally": 349,
  "RealTimeSpentQueue": 458,
  "HasAttachment": false,
  "NumReplies": 425,
  "NumMessages": 243,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 727,
      "CreatedAt": "2015-08-11T02:49:51.5831853+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ut",
      "PersonId": 615,
      "PersonFullName": "Mrs. Christine Rachael Beatty",
      "ContactId": 64,
      "ContactName": "Flatley-Torp",
      "ContactDepartment": "",
      "NumAttachments": 725,
      "EmailHeader": "esmeralda.mcdermott@grimes.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "velit",
      "Sentiment": 52,
      "SentimentConfidence": 724,
      "CreatedBy": 773,
      "ChangedAt": "2015-10-22T02:49:51.5831853+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 473,
      "Name": "Hickle-Tillman",
      "ToolTip": "Qui molestias sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 474
        }
      }
    },
    {
      "Id": 473,
      "Name": "Hickle-Tillman",
      "ToolTip": "Qui molestias sint.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 474
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 189,
  "SentimentConfidence": 555,
  "SuggestedCategoryId": 252,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 613,
  "IconHint": "quo",
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 440
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```