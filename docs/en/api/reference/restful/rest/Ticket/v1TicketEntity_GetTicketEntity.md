---
title: GET Ticket/{id}
uid: v1TicketEntity_GetTicketEntity
generated: true
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
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 574,
  "Title": "aut",
  "CreatedAt": "2010-07-17T03:31:33.1625088+02:00",
  "LastChanged": "2004-03-06T03:31:33.1625088+01:00",
  "ReadByOwner": "1999-07-31T03:31:33.1625088+02:00",
  "ReadByCustomer": "2021-07-15T03:31:33.1625088+02:00",
  "FirstReadByOwner": "2021-12-04T03:31:33.1625088+01:00",
  "FirstReadByUser": "2000-09-12T03:31:33.1625088+02:00",
  "Activate": "2008-10-18T03:31:33.1625088+02:00",
  "ClosedAt": "2004-02-11T03:31:33.1625088+01:00",
  "RepliedAt": "2007-02-17T03:31:33.1625088+01:00",
  "AlertTimeout": "2010-07-24T03:31:33.1625088+02:00",
  "Deadline": "1997-03-01T03:31:33.1625088+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "PersonId": 562,
      "Mrmrs": "dicta",
      "Firstname": "Nella",
      "Lastname": "Jast",
      "MiddleName": "Gutmann, Gottlieb and Cruickshank",
      "Title": "commodi",
      "Description": "Fully-configurable attitude-oriented orchestration",
      "Email": "coralie@jenkins.uk",
      "FullName": "Mrs. Immanuel Wilkinson",
      "DirectPhone": "974-426-5493 x945",
      "FormalName": "Huels-Hoeger",
      "CountryId": 640,
      "ContactId": 169,
      "ContactName": "Waelchi-McLaughlin",
      "Retired": 754,
      "Rank": 930,
      "ActiveInterests": 690,
      "ContactDepartment": "",
      "ContactCountryId": 787,
      "ContactOrgNr": "887792",
      "FaxPhone": "(819)855-6499",
      "MobilePhone": "046.224.8153",
      "ContactPhone": "1-649-611-5569 x55345",
      "AssociateName": "Mills-Parker",
      "AssociateId": 486,
      "UsePersonAddress": true,
      "ContactFax": "incidunt",
      "Kanafname": "non",
      "Kanalname": "nihil",
      "Post1": "temporibus",
      "Post2": "voluptates",
      "Post3": "quae",
      "EmailName": "benedict@schaden.info",
      "ContactFullName": "Dr. Ruben Johnson",
      "ActiveErpLinks": 391,
      "TicketPriorityId": 162,
      "SupportLanguageId": 104,
      "SupportAssociateId": 983,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "AlertLevel": 935,
  "ConnectId": 227,
  "ReadStatus": "Green",
  "TimeToReply": 621,
  "RealTimeToReply": 298,
  "TimeToClose": 992,
  "RealTimeToClose": 870,
  "TimeSpentInternally": 488,
  "TimeSpentExternally": 468,
  "TimeSpentQueue": 347,
  "RealTimeSpentInternally": 181,
  "RealTimeSpentExternally": 333,
  "RealTimeSpentQueue": 945,
  "HasAttachment": false,
  "NumReplies": 38,
  "NumMessages": 165,
  "FromAddress": "quibusdam",
  "Messages": [
    {
      "TicketMessageId": 382,
      "CreatedAt": "2020-05-04T03:31:33.1625088+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ea",
      "PersonId": 57,
      "PersonFullName": "Darrell Bode",
      "ContactId": 538,
      "ContactName": "Hickle, Roob and Beatty",
      "ContactDepartment": "",
      "NumAttachments": 445,
      "EmailHeader": "zachery@kunde.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "qui",
      "Sentiment": 726,
      "SentimentConfidence": 314,
      "CreatedBy": 400,
      "ChangedAt": "2003-10-21T03:31:33.1781336+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 926
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 600,
      "Name": "Krajcik, Collier and Lakin",
      "ToolTip": "Accusantium itaque omnis consequatur quia qui dolore qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    },
    {
      "Id": 600,
      "Name": "Krajcik, Collier and Lakin",
      "ToolTip": "Accusantium itaque omnis consequatur quia qui dolore qui.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    }
  ],
  "Language": "eum",
  "Sentiment": 184,
  "SentimentConfidence": 761,
  "SuggestedCategoryId": 833,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 158,
  "IconHint": "omnis",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "tempore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 776
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```