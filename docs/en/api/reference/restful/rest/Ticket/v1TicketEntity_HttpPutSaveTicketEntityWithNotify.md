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
PUT /api/v1/Ticket/{id}?notify=True
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
  "TicketId": 558,
  "Title": "sapiente",
  "CreatedAt": "1998-06-17T14:13:49.3212069+02:00",
  "LastChanged": "2001-04-11T14:13:49.3212069+02:00",
  "ReadByOwner": "2022-06-11T14:13:49.3212069+02:00",
  "ReadByCustomer": "2005-09-23T14:13:49.3212069+02:00",
  "FirstReadByOwner": "2018-02-18T14:13:49.3212069+01:00",
  "FirstReadByUser": "2019-02-24T14:13:49.3212069+01:00",
  "Activate": "1998-04-02T14:13:49.3212069+02:00",
  "ClosedAt": "2003-01-17T14:13:49.3212069+01:00",
  "RepliedAt": "2003-03-04T14:13:49.3212069+01:00",
  "AlertTimeout": "2024-11-20T14:13:49.3212069+01:00",
  "Deadline": "2018-02-20T14:13:49.3212069+01:00",
  "CreatedBy": null,
  "Author": "necessitatibus",
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
      "Position": "cupiditate",
      "PersonId": 963,
      "Mrmrs": "explicabo",
      "Firstname": "Ashley",
      "Lastname": "Gutmann",
      "MiddleName": "Kiehn Inc and Sons",
      "Title": "id",
      "Description": "Ameliorated methodical info-mediaries",
      "Email": "braeden@steuber.us",
      "FullName": "Dr. Leonardo Ward Ledner",
      "DirectPhone": "(812)358-0914",
      "FormalName": "Hermann-Wiegand",
      "CountryId": 721,
      "ContactId": 907,
      "ContactName": "Barrows LLC",
      "Retired": 671,
      "Rank": 212,
      "ActiveInterests": 945,
      "ContactDepartment": "maximize clicks-and-mortar markets",
      "ContactCountryId": 638,
      "ContactOrgNr": "1132026",
      "FaxPhone": "536-227-5463 x704",
      "MobilePhone": "(542)817-1489",
      "ContactPhone": "(253)312-0958 x147",
      "AssociateName": "Orn-Swaniawski",
      "AssociateId": 11,
      "UsePersonAddress": false,
      "ContactFax": "dicta",
      "Kanafname": "ea",
      "Kanalname": "placeat",
      "Post1": "quam",
      "Post2": "vel",
      "Post3": "voluptatem",
      "EmailName": "keanu.stoltenberg@lakin.biz",
      "ContactFullName": "Zaria Bernier",
      "ActiveErpLinks": 34,
      "TicketPriorityId": 615,
      "SupportLanguageId": 98,
      "SupportAssociateId": 324,
      "CategoryName": "VIP Customer",
      "PersonNumber": "815614"
    }
  ],
  "AlertLevel": 517,
  "ConnectId": 253,
  "ReadStatus": "Green",
  "TimeToReply": 147,
  "RealTimeToReply": 170,
  "TimeToClose": 389,
  "RealTimeToClose": 642,
  "TimeSpentInternally": 837,
  "TimeSpentExternally": 259,
  "TimeSpentQueue": 728,
  "RealTimeSpentInternally": 625,
  "RealTimeSpentExternally": 719,
  "RealTimeSpentQueue": 948,
  "TimeSpent": 452,
  "HasAttachment": false,
  "NumReplies": 582,
  "NumMessages": 193,
  "FromAddress": "optio",
  "Messages": [
    {
      "TicketMessageId": 373,
      "CreatedAt": "2004-12-24T14:13:49.3212069+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptates",
      "PersonId": 25,
      "PersonFullName": "Loyal Quigley",
      "ContactId": 476,
      "ContactName": "Mayert, Weimann and Tromp",
      "ContactDepartment": "",
      "NumAttachments": 328,
      "EmailHeader": "hope@heidenreich.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 325,
      "SentimentConfidence": 783,
      "CreatedBy": 662,
      "ChangedAt": "2005-02-17T14:13:49.3212069+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 879,
      "Name": "Gutmann, Heller and Jewess",
      "ToolTip": "Ipsam quia suscipit."
    },
    {
      "Id": 879,
      "Name": "Gutmann, Heller and Jewess",
      "ToolTip": "Ipsam quia suscipit."
    }
  ],
  "Language": "explicabo",
  "Sentiment": 277,
  "SentimentConfidence": 682,
  "SuggestedCategoryId": 743,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 44,
  "IconHint": "dicta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 49,
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "rem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 274,
  "Title": "corrupti",
  "CreatedAt": "2006-07-18T14:13:49.3368278+02:00",
  "LastChanged": "2002-01-27T14:13:49.3368278+01:00",
  "ReadByOwner": "2019-10-04T14:13:49.3368278+02:00",
  "ReadByCustomer": "1999-03-07T14:13:49.3368278+01:00",
  "FirstReadByOwner": "2001-11-04T14:13:49.3368278+01:00",
  "FirstReadByUser": "2007-10-23T14:13:49.3368278+02:00",
  "Activate": "2002-10-27T14:13:49.3368278+01:00",
  "ClosedAt": "2019-12-14T14:13:49.3368278+01:00",
  "RepliedAt": "2000-09-05T14:13:49.3368278+02:00",
  "AlertTimeout": "2009-12-31T14:13:49.3368278+01:00",
  "Deadline": "2015-12-20T14:13:49.3368278+01:00",
  "CreatedBy": null,
  "Author": "excepturi",
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
      "Position": "modi",
      "PersonId": 509,
      "Mrmrs": "quia",
      "Firstname": "Darren",
      "Lastname": "Cartwright",
      "MiddleName": "Kemmer Inc and Sons",
      "Title": "dignissimos",
      "Description": "Expanded directional knowledge base",
      "Email": "soledad.cummings@rogahn.co.uk",
      "FullName": "Filomena Kertzmann",
      "DirectPhone": "624.953.5041",
      "FormalName": "Hammes Group",
      "CountryId": 218,
      "ContactId": 143,
      "ContactName": "Cronin LLC",
      "Retired": 676,
      "Rank": 1000,
      "ActiveInterests": 121,
      "ContactDepartment": "",
      "ContactCountryId": 807,
      "ContactOrgNr": "761919",
      "FaxPhone": "997-441-2276 x931",
      "MobilePhone": "037.818.7762 x648",
      "ContactPhone": "1-957-004-2909 x578",
      "AssociateName": "Morar Inc and Sons",
      "AssociateId": 20,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "debitis",
      "Kanalname": "et",
      "Post1": "quia",
      "Post2": "illum",
      "Post3": "nam",
      "EmailName": "dasia_bechtelar@swift.us",
      "ContactFullName": "Dr. Vidal Sawayn",
      "ActiveErpLinks": 429,
      "TicketPriorityId": 759,
      "SupportLanguageId": 101,
      "SupportAssociateId": 721,
      "CategoryName": "VIP Customer",
      "PersonNumber": "460691",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "AlertLevel": 152,
  "ConnectId": 265,
  "ReadStatus": "Green",
  "TimeToReply": 334,
  "RealTimeToReply": 327,
  "TimeToClose": 610,
  "RealTimeToClose": 892,
  "TimeSpentInternally": 86,
  "TimeSpentExternally": 437,
  "TimeSpentQueue": 446,
  "RealTimeSpentInternally": 402,
  "RealTimeSpentExternally": 824,
  "RealTimeSpentQueue": 93,
  "TimeSpent": 648,
  "HasAttachment": false,
  "NumReplies": 245,
  "NumMessages": 111,
  "FromAddress": "dolores",
  "Messages": [
    {
      "TicketMessageId": 15,
      "CreatedAt": "2024-02-21T14:13:49.3368278+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ea",
      "PersonId": 576,
      "PersonFullName": "Miss Tiara Murphy Nader",
      "ContactId": 784,
      "ContactName": "Reynolds Group",
      "ContactDepartment": "",
      "NumAttachments": 375,
      "EmailHeader": "dakota.lockman@mcdermott.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 482,
      "SentimentConfidence": 656,
      "CreatedBy": 788,
      "ChangedAt": "2017-04-16T14:13:49.3368278+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 142,
      "Name": "Rodriguez-Watsica",
      "ToolTip": "Repellat voluptas fugiat atque molestiae voluptate et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    },
    {
      "Id": 142,
      "Name": "Rodriguez-Watsica",
      "ToolTip": "Repellat voluptas fugiat atque molestiae voluptate et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    }
  ],
  "Language": "deserunt",
  "Sentiment": 788,
  "SentimentConfidence": 924,
  "SuggestedCategoryId": 859,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 861,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 503,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 996
    }
  }
}
```