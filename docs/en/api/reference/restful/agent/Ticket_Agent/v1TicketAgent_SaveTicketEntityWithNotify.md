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
| NewEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| Notify | Boolean |  |

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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
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
  "TicketId": 935,
  "Title": "sit",
  "CreatedAt": "2015-08-13T11:22:39.4769429+02:00",
  "LastChanged": "2018-09-23T11:22:39.4769429+02:00",
  "ReadByOwner": "1996-02-22T11:22:39.4769429+01:00",
  "ReadByCustomer": "2004-03-18T11:22:39.4769429+01:00",
  "FirstReadByOwner": "2006-01-23T11:22:39.4769429+01:00",
  "FirstReadByUser": "1996-12-18T11:22:39.4769429+01:00",
  "Activate": "2009-05-22T11:22:39.4769429+02:00",
  "ClosedAt": "2008-08-26T11:22:39.4769429+02:00",
  "RepliedAt": "1996-01-04T11:22:39.4769429+01:00",
  "AlertTimeout": "2019-01-27T11:22:39.4769429+01:00",
  "Deadline": "2020-03-04T11:22:39.4769429+01:00",
  "CreatedBy": null,
  "Author": "impedit",
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
      "Position": "eos",
      "PersonId": 277,
      "Mrmrs": "id",
      "Firstname": "Caitlyn",
      "Lastname": "Rutherford",
      "MiddleName": "Emmerich, Roob and Bernier",
      "Title": "vel",
      "Description": "Automated solution-oriented utilisation",
      "Email": "carole_gislason@hoppe.name",
      "FullName": "Mariam Kohler",
      "DirectPhone": "(335)119-2390",
      "FormalName": "Mertz-Brakus",
      "CountryId": 202,
      "ContactId": 191,
      "ContactName": "Stiedemann-Ledner",
      "Retired": 720,
      "Rank": 635,
      "ActiveInterests": 703,
      "ContactDepartment": "",
      "ContactCountryId": 518,
      "ContactOrgNr": "964709",
      "FaxPhone": "383-192-2283",
      "MobilePhone": "1-065-035-9621 x0167",
      "ContactPhone": "081.486.6209 x65682",
      "AssociateName": "Kessler-Lesch",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "illo",
      "Kanafname": "ea",
      "Kanalname": "omnis",
      "Post1": "commodi",
      "Post2": "accusamus",
      "Post3": "ut",
      "EmailName": "brenda@hintzcorkery.ca",
      "ContactFullName": "Prof. Garfield Ebert",
      "ActiveErpLinks": 281,
      "TicketPriorityId": 469,
      "SupportLanguageId": 358,
      "SupportAssociateId": 397,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "AlertLevel": 506,
  "ConnectId": 797,
  "ReadStatus": "Green",
  "TimeToReply": 716,
  "RealTimeToReply": 202,
  "TimeToClose": 140,
  "RealTimeToClose": 214,
  "TimeSpentInternally": 863,
  "TimeSpentExternally": 905,
  "TimeSpentQueue": 338,
  "RealTimeSpentInternally": 82,
  "RealTimeSpentExternally": 503,
  "RealTimeSpentQueue": 718,
  "HasAttachment": true,
  "NumReplies": 283,
  "NumMessages": 547,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 23,
      "CreatedAt": "2019-07-11T11:22:39.4769429+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "autem",
      "PersonId": 176,
      "PersonFullName": "Gunnar Parisian",
      "ContactId": 689,
      "ContactName": "Bashirian Group",
      "ContactDepartment": "",
      "NumAttachments": 515,
      "EmailHeader": "murl.kreiger@herman.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "consequatur",
      "Sentiment": 103,
      "SentimentConfidence": 831,
      "CreatedBy": 365,
      "ChangedAt": "2016-11-09T11:22:39.4769429+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 538,
      "Name": "Rolfson-Kutch",
      "ToolTip": "Consequatur et ad.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 192
        }
      }
    },
    {
      "Id": 538,
      "Name": "Rolfson-Kutch",
      "ToolTip": "Consequatur et ad.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 192
        }
      }
    }
  ],
  "Language": "saepe",
  "Sentiment": 161,
  "SentimentConfidence": 921,
  "SuggestedCategoryId": 283,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 820,
  "IconHint": "harum",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 5
    }
  }
}
```