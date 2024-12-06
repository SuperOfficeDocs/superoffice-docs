---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
generated: true
---

# PUT Ticket/{id}

```http
PUT /api/v1/Ticket/{id}
```

Saves a ticket and performs any user notifications






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity id to update **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
PUT /api/v1/Ticket/{id}?notify=False
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

## Request Body: entity 

The ticket to save 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer | The primary key (auto-incremented) |
| Title | String | The title of the ticket. |
| CreatedAt | String | When the ticket was created. |
| LastChanged | String | The last time the ticket was modified. |
| ReadByOwner | String | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | String | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | String | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | String | The datetime for when the ticket first was read by a user. |
| Activate | String | When the ticket should be activated, if it is postponed. |
| ClosedAt | String | When the ticket was closed. |
| RepliedAt | String | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | String | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | String | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | String | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | String | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | String | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | String | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | Array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | Integer | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | Integer | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | String | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | Integer | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | Integer | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | Integer | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | Integer | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | Integer | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | Integer | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | Integer | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | Integer | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| TimeSpent | Integer | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| HasAttachment | Boolean | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | Integer | The number of replies (messages) to the customer for this request. |
| NumMessages | Integer | The total number of messages for this request. |
| FromAddress | String | The from-address used when this ticket got created, e.g. by email |
| Messages | Array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | Array | An array containing the tags assigned to this request |
| Language | String | The language of the first external message |
| Sentiment | Integer | The sentiment index of the last external message |
| SentimentConfidence | Integer | The sentiment confidence of the last external message |
| SuggestedCategoryId | Integer | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | String | Suggested category from AI |
| OrigHumanCategoryId | Integer | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | String | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | Integer | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
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
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 358,
  "Title": "at",
  "CreatedAt": "2013-08-10T10:18:00.7543503+02:00",
  "LastChanged": "2009-06-29T10:18:00.7543503+02:00",
  "ReadByOwner": "2015-09-08T10:18:00.7543503+02:00",
  "ReadByCustomer": "2012-12-02T10:18:00.7543503+01:00",
  "FirstReadByOwner": "2016-12-23T10:18:00.7543503+01:00",
  "FirstReadByUser": "2017-09-28T10:18:00.7543503+02:00",
  "Activate": "2019-09-29T10:18:00.7543503+02:00",
  "ClosedAt": "2008-05-04T10:18:00.7543503+02:00",
  "RepliedAt": "2012-06-12T10:18:00.7543503+02:00",
  "AlertTimeout": "2002-04-28T10:18:00.7543503+02:00",
  "Deadline": "2004-04-29T10:18:00.7543503+02:00",
  "CreatedBy": null,
  "Author": "totam",
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
      "Position": "vitae",
      "PersonId": 204,
      "Mrmrs": "quas",
      "Firstname": "Madalyn",
      "Lastname": "Cruickshank",
      "MiddleName": "Medhurst, Lynch and Gerlach",
      "Title": "qui",
      "Description": "Integrated intangible help-desk",
      "Email": "max_fay@greenfeldermurphy.ca",
      "FullName": "Ricardo Ankunding",
      "DirectPhone": "1-314-084-2085",
      "FormalName": "Schamberger, Runolfsdottir and Eichmann",
      "CountryId": 315,
      "ContactId": 559,
      "ContactName": "Gutmann Group",
      "Retired": 864,
      "Rank": 261,
      "ActiveInterests": 870,
      "ContactDepartment": "",
      "ContactCountryId": 253,
      "ContactOrgNr": "428479",
      "FaxPhone": "1-654-167-7238 x70615",
      "MobilePhone": "(857)451-6655 x720",
      "ContactPhone": "946.734.8406",
      "AssociateName": "Jewess Inc and Sons",
      "AssociateId": 656,
      "UsePersonAddress": false,
      "ContactFax": "quam",
      "Kanafname": "qui",
      "Kanalname": "aut",
      "Post1": "numquam",
      "Post2": "maxime",
      "Post3": "laboriosam",
      "EmailName": "verona.cremin@schmidtsimonis.co.uk",
      "ContactFullName": "Wendell Frederick Bailey PhD",
      "ActiveErpLinks": 921,
      "TicketPriorityId": 918,
      "SupportLanguageId": 457,
      "SupportAssociateId": 178,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 875,
  "ConnectId": 17,
  "ReadStatus": "Green",
  "TimeToReply": 225,
  "RealTimeToReply": 63,
  "TimeToClose": 311,
  "RealTimeToClose": 476,
  "TimeSpentInternally": 231,
  "TimeSpentExternally": 743,
  "TimeSpentQueue": 3,
  "RealTimeSpentInternally": 632,
  "RealTimeSpentExternally": 178,
  "RealTimeSpentQueue": 457,
  "TimeSpent": 569,
  "HasAttachment": false,
  "NumReplies": 627,
  "NumMessages": 531,
  "FromAddress": "odio",
  "Messages": [
    {
      "TicketMessageId": 245,
      "CreatedAt": "2019-02-24T10:18:00.7543503+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "aut",
      "PersonId": 266,
      "PersonFullName": "Keshaun Cruickshank",
      "ContactId": 866,
      "ContactName": "Lehner-Kuvalis",
      "ContactDepartment": "",
      "NumAttachments": 809,
      "EmailHeader": "brooklyn@koelpinpouros.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quia",
      "Sentiment": 93,
      "SentimentConfidence": 721,
      "CreatedBy": 855,
      "ChangedAt": "2001-06-03T10:18:00.7543503+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 527,
      "Name": "Bernier, Bergnaum and Murazik",
      "ToolTip": "Sit laudantium."
    },
    {
      "Id": 527,
      "Name": "Bernier, Bergnaum and Murazik",
      "ToolTip": "Sit laudantium."
    }
  ],
  "Language": "commodi",
  "Sentiment": 346,
  "SentimentConfidence": 476,
  "SuggestedCategoryId": 783,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 308,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 118,
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "unde"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 221,
  "Title": "necessitatibus",
  "CreatedAt": "2006-04-26T10:18:00.7543503+02:00",
  "LastChanged": "2012-09-15T10:18:00.7543503+02:00",
  "ReadByOwner": "2020-01-02T10:18:00.7543503+01:00",
  "ReadByCustomer": "2021-04-03T10:18:00.7543503+02:00",
  "FirstReadByOwner": "2006-09-20T10:18:00.7543503+02:00",
  "FirstReadByUser": "1999-09-26T10:18:00.7543503+02:00",
  "Activate": "2003-09-19T10:18:00.7543503+02:00",
  "ClosedAt": "2012-03-19T10:18:00.7543503+01:00",
  "RepliedAt": "2015-04-23T10:18:00.7543503+02:00",
  "AlertTimeout": "2009-12-06T10:18:00.7543503+01:00",
  "Deadline": "2015-10-13T10:18:00.7543503+02:00",
  "CreatedBy": null,
  "Author": "numquam",
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
      "Position": "aliquid",
      "PersonId": 187,
      "Mrmrs": "reiciendis",
      "Firstname": "Amy",
      "Lastname": "Ondricka",
      "MiddleName": "Parker LLC",
      "Title": "quibusdam",
      "Description": "Ameliorated tertiary function",
      "Email": "tanya@hamillschuppe.com",
      "FullName": "Dr. Nedra Bayer",
      "DirectPhone": "928-929-5270",
      "FormalName": "Gislason Group",
      "CountryId": 726,
      "ContactId": 682,
      "ContactName": "Watsica, Feest and Goldner",
      "Retired": 728,
      "Rank": 241,
      "ActiveInterests": 355,
      "ContactDepartment": "",
      "ContactCountryId": 750,
      "ContactOrgNr": "1089059",
      "FaxPhone": "1-143-212-3118",
      "MobilePhone": "(518)559-5064 x56831",
      "ContactPhone": "1-136-322-6326",
      "AssociateName": "Murazik, Ratke and Swaniawski",
      "AssociateId": 369,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "natus",
      "Kanalname": "veritatis",
      "Post1": "ea",
      "Post2": "libero",
      "Post3": "itaque",
      "EmailName": "elyse_wunsch@skilesfarrell.us",
      "ContactFullName": "Mrs. Miracle Herman PhD",
      "ActiveErpLinks": 594,
      "TicketPriorityId": 567,
      "SupportLanguageId": 252,
      "SupportAssociateId": 960,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    }
  ],
  "AlertLevel": 13,
  "ConnectId": 956,
  "ReadStatus": "Green",
  "TimeToReply": 56,
  "RealTimeToReply": 260,
  "TimeToClose": 211,
  "RealTimeToClose": 901,
  "TimeSpentInternally": 45,
  "TimeSpentExternally": 169,
  "TimeSpentQueue": 99,
  "RealTimeSpentInternally": 676,
  "RealTimeSpentExternally": 281,
  "RealTimeSpentQueue": 790,
  "TimeSpent": 772,
  "HasAttachment": false,
  "NumReplies": 652,
  "NumMessages": 696,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 729,
      "CreatedAt": "2002-12-15T10:18:00.7699763+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 459,
      "PersonFullName": "Ardella Von",
      "ContactId": 846,
      "ContactName": "Gislason-Sipes",
      "ContactDepartment": "",
      "NumAttachments": 72,
      "EmailHeader": "lexie@treutel.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eum",
      "Sentiment": 421,
      "SentimentConfidence": 437,
      "CreatedBy": 747,
      "ChangedAt": "2003-02-16T10:18:00.7699763+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 679
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 467,
      "Name": "Gerlach, Ritchie and Gleason",
      "ToolTip": "Quod praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    },
    {
      "Id": 467,
      "Name": "Gerlach, Ritchie and Gleason",
      "ToolTip": "Quod praesentium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    }
  ],
  "Language": "laborum",
  "Sentiment": 272,
  "SentimentConfidence": 534,
  "SuggestedCategoryId": 330,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 419,
  "IconHint": "error",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 306,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "corrupti"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 907
    }
  }
}
```