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
GET /api/v1/Ticket/{id}?fk=False
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

### Response body: TicketEntityWithLinks

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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 146,
  "Title": "deserunt",
  "CreatedAt": "2009-05-29T03:51:34.0678657+02:00",
  "LastChanged": "2003-02-06T03:51:34.0678657+01:00",
  "ReadByOwner": "2002-08-04T03:51:34.0678657+02:00",
  "ReadByCustomer": "2021-08-01T03:51:34.0678657+02:00",
  "FirstReadByOwner": "2006-07-20T03:51:34.0678657+02:00",
  "FirstReadByUser": "2010-11-10T03:51:34.0678657+01:00",
  "Activate": "2018-11-14T03:51:34.0678657+01:00",
  "ClosedAt": "2000-09-07T03:51:34.0678657+02:00",
  "RepliedAt": "2000-02-01T03:51:34.0678657+01:00",
  "AlertTimeout": "2002-12-05T03:51:34.0678657+01:00",
  "Deadline": "2011-11-28T03:51:34.0678657+01:00",
  "CreatedBy": null,
  "Author": "eos",
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
      "Position": "sunt",
      "PersonId": 738,
      "Mrmrs": "et",
      "Firstname": "Roslyn",
      "Lastname": "Lubowitz",
      "MiddleName": "Swift-Koelpin",
      "Title": "nesciunt",
      "Description": "Profit-focused contextually-based hardware",
      "Email": "seamus.hamill@mertz.co.uk",
      "FullName": "Carolyn Solon Rutherford I",
      "DirectPhone": "1-363-182-4821",
      "FormalName": "Predovic, Bailey and Hudson",
      "CountryId": 892,
      "ContactId": 447,
      "ContactName": "Stehr-Cronin",
      "Retired": 481,
      "Rank": 852,
      "ActiveInterests": 228,
      "ContactDepartment": "",
      "ContactCountryId": 742,
      "ContactOrgNr": "915319",
      "FaxPhone": "(909)662-9490",
      "MobilePhone": "(619)599-0645 x86973",
      "ContactPhone": "1-028-378-9424 x031",
      "AssociateName": "Torp, Grady and Bruen",
      "AssociateId": 782,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "rem",
      "Kanalname": "nesciunt",
      "Post1": "suscipit",
      "Post2": "eaque",
      "Post3": "aut",
      "EmailName": "ezra_jerde@haley.biz",
      "ContactFullName": "Makayla Macejkovic",
      "ActiveErpLinks": 240,
      "TicketPriorityId": 770,
      "SupportLanguageId": 88,
      "SupportAssociateId": 308,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 389
        }
      }
    }
  ],
  "AlertLevel": 617,
  "ConnectId": 987,
  "ReadStatus": "Green",
  "TimeToReply": 971,
  "RealTimeToReply": 275,
  "TimeToClose": 288,
  "RealTimeToClose": 346,
  "TimeSpentInternally": 619,
  "TimeSpentExternally": 952,
  "TimeSpentQueue": 51,
  "RealTimeSpentInternally": 862,
  "RealTimeSpentExternally": 140,
  "RealTimeSpentQueue": 144,
  "HasAttachment": false,
  "NumReplies": 936,
  "NumMessages": 185,
  "FromAddress": "voluptas",
  "Messages": [
    {
      "TicketMessageId": 129,
      "CreatedAt": "2012-10-16T03:51:34.0678657+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "natus",
      "PersonId": 440,
      "PersonFullName": "Crystal Gusikowski",
      "ContactId": 3,
      "ContactName": "Grady-Lesch",
      "ContactDepartment": "",
      "NumAttachments": 772,
      "EmailHeader": "emma.rutherford@jenkinsschowalter.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "incidunt",
      "Sentiment": 97,
      "SentimentConfidence": 955,
      "CreatedBy": 266,
      "ChangedAt": "2022-01-04T03:51:34.0678657+01:00",
      "Badge": "Comment",
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
      "Id": 616,
      "Name": "Terry-Heller",
      "ToolTip": "Nostrum aliquam consectetur sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    },
    {
      "Id": 616,
      "Name": "Terry-Heller",
      "ToolTip": "Nostrum aliquam consectetur sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Language": "et",
  "Sentiment": 818,
  "SentimentConfidence": 277,
  "SuggestedCategoryId": 370,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 728,
  "IconHint": "cum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "harum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 116
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```