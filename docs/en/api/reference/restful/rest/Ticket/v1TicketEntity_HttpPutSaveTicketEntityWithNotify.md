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
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
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

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 699,
  "Title": "dignissimos",
  "CreatedAt": "2015-12-10T03:31:33.1781336+01:00",
  "LastChanged": "1997-05-30T03:31:33.1781336+02:00",
  "ReadByOwner": "2018-05-30T03:31:33.1781336+02:00",
  "ReadByCustomer": "2023-05-31T03:31:33.1781336+02:00",
  "FirstReadByOwner": "2006-11-04T03:31:33.1781336+01:00",
  "FirstReadByUser": "1998-08-31T03:31:33.1781336+02:00",
  "Activate": "1997-10-06T03:31:33.1781336+02:00",
  "ClosedAt": "2003-02-11T03:31:33.1781336+01:00",
  "RepliedAt": "2017-10-10T03:31:33.1781336+02:00",
  "AlertTimeout": "2012-12-10T03:31:33.1781336+01:00",
  "Deadline": "2021-04-29T03:31:33.1781336+02:00",
  "CreatedBy": null,
  "Author": "illum",
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
      "Position": "hic",
      "PersonId": 742,
      "Mrmrs": "quo",
      "Firstname": "Jammie",
      "Lastname": "Walsh",
      "MiddleName": "Okuneva-Dach",
      "Title": "sed",
      "Description": "Multi-lateral client-server concept",
      "Email": "larry@vonbreitenberg.info",
      "FullName": "Whitney Grady",
      "DirectPhone": "237.644.4477 x744",
      "FormalName": "Stiedemann, Kuvalis and Quigley",
      "CountryId": 174,
      "ContactId": 801,
      "ContactName": "Kunde-Altenwerth",
      "Retired": 724,
      "Rank": 604,
      "ActiveInterests": 127,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "1046036",
      "FaxPhone": "(477)655-7628 x09876",
      "MobilePhone": "929.897.1718 x75814",
      "ContactPhone": "868-794-3063",
      "AssociateName": "Kemmer Group",
      "AssociateId": 229,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "sapiente",
      "Kanalname": "distinctio",
      "Post1": "totam",
      "Post2": "repudiandae",
      "Post3": "aperiam",
      "EmailName": "kaylie_rippin@doylekiehn.com",
      "ContactFullName": "Jaqueline Shields",
      "ActiveErpLinks": 148,
      "TicketPriorityId": 850,
      "SupportLanguageId": 27,
      "SupportAssociateId": 738,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 129,
  "ConnectId": 144,
  "ReadStatus": "Green",
  "TimeToReply": 878,
  "RealTimeToReply": 328,
  "TimeToClose": 667,
  "RealTimeToClose": 486,
  "TimeSpentInternally": 16,
  "TimeSpentExternally": 206,
  "TimeSpentQueue": 347,
  "RealTimeSpentInternally": 594,
  "RealTimeSpentExternally": 703,
  "RealTimeSpentQueue": 549,
  "HasAttachment": false,
  "NumReplies": 114,
  "NumMessages": 310,
  "FromAddress": "aliquid",
  "Messages": [
    {
      "TicketMessageId": 235,
      "CreatedAt": "2019-12-11T03:31:33.1781336+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "corporis",
      "PersonId": 174,
      "PersonFullName": "Miss Clair Lorenzo Herzog",
      "ContactId": 649,
      "ContactName": "Pfeffer, Blick and Ankunding",
      "ContactDepartment": "",
      "NumAttachments": 333,
      "EmailHeader": "dawson@breitenbergkreiger.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "aut",
      "Sentiment": 955,
      "SentimentConfidence": 69,
      "CreatedBy": 842,
      "ChangedAt": "2010-03-25T03:31:33.1781336+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 477,
      "Name": "Torphy, Thompson and Mertz",
      "ToolTip": "Ut corrupti."
    },
    {
      "Id": 477,
      "Name": "Torphy, Thompson and Mertz",
      "ToolTip": "Ut corrupti."
    }
  ],
  "Language": "placeat",
  "Sentiment": 332,
  "SentimentConfidence": 490,
  "SuggestedCategoryId": 786,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 773,
  "IconHint": "consequuntur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "aspernatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 277,
  "Title": "repellat",
  "CreatedAt": "2005-08-11T03:31:33.1781336+02:00",
  "LastChanged": "2015-10-23T03:31:33.1781336+02:00",
  "ReadByOwner": "2001-06-07T03:31:33.1781336+02:00",
  "ReadByCustomer": "2019-04-25T03:31:33.1781336+02:00",
  "FirstReadByOwner": "2022-12-20T03:31:33.1781336+01:00",
  "FirstReadByUser": "2002-01-24T03:31:33.1781336+01:00",
  "Activate": "2005-07-14T03:31:33.1781336+02:00",
  "ClosedAt": "2015-07-14T03:31:33.1781336+02:00",
  "RepliedAt": "2002-08-26T03:31:33.1781336+02:00",
  "AlertTimeout": "2001-03-21T03:31:33.1781336+01:00",
  "Deadline": "1999-08-30T03:31:33.1781336+02:00",
  "CreatedBy": null,
  "Author": "ipsa",
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
      "Position": "ut",
      "PersonId": 470,
      "Mrmrs": "qui",
      "Firstname": "Carroll",
      "Lastname": "Fritsch",
      "MiddleName": "McDermott, Corkery and Roberts",
      "Title": "consequuntur",
      "Description": "Up-sized optimal secured line",
      "Email": "emmalee.gutkowski@bednaranderson.name",
      "FullName": "Miss Yessenia Kertzmann DVM",
      "DirectPhone": "763.101.2760 x635",
      "FormalName": "Predovic Group",
      "CountryId": 288,
      "ContactId": 815,
      "ContactName": "Kohler-Frami",
      "Retired": 998,
      "Rank": 275,
      "ActiveInterests": 385,
      "ContactDepartment": "",
      "ContactCountryId": 714,
      "ContactOrgNr": "987394",
      "FaxPhone": "(603)446-9191 x083",
      "MobilePhone": "255.347.2768 x3666",
      "ContactPhone": "1-084-658-6361 x941",
      "AssociateName": "Upton, Durgan and Hoppe",
      "AssociateId": 882,
      "UsePersonAddress": false,
      "ContactFax": "a",
      "Kanafname": "quia",
      "Kanalname": "aperiam",
      "Post1": "ea",
      "Post2": "sunt",
      "Post3": "eius",
      "EmailName": "kendrick@mills.biz",
      "ContactFullName": "Mr. Dorothea Cassandra Howe",
      "ActiveErpLinks": 353,
      "TicketPriorityId": 296,
      "SupportLanguageId": 908,
      "SupportAssociateId": 564,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "AlertLevel": 952,
  "ConnectId": 637,
  "ReadStatus": "Green",
  "TimeToReply": 890,
  "RealTimeToReply": 487,
  "TimeToClose": 312,
  "RealTimeToClose": 836,
  "TimeSpentInternally": 212,
  "TimeSpentExternally": 410,
  "TimeSpentQueue": 30,
  "RealTimeSpentInternally": 441,
  "RealTimeSpentExternally": 23,
  "RealTimeSpentQueue": 409,
  "HasAttachment": true,
  "NumReplies": 673,
  "NumMessages": 81,
  "FromAddress": "nobis",
  "Messages": [
    {
      "TicketMessageId": 994,
      "CreatedAt": "2007-10-21T03:31:33.1937529+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eligendi",
      "PersonId": 476,
      "PersonFullName": "Mr. Rodger O'Hara PhD",
      "ContactId": 575,
      "ContactName": "Jewess-Wunsch",
      "ContactDepartment": "",
      "NumAttachments": 481,
      "EmailHeader": "albertha@feeney.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magnam",
      "Sentiment": 413,
      "SentimentConfidence": 383,
      "CreatedBy": 246,
      "ChangedAt": "2009-11-19T03:31:33.1937529+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 851,
      "Name": "Wehner Group",
      "ToolTip": "Sed eos dolores voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    },
    {
      "Id": 851,
      "Name": "Wehner Group",
      "ToolTip": "Sed eos dolores voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    }
  ],
  "Language": "voluptatem",
  "Sentiment": 929,
  "SentimentConfidence": 460,
  "SuggestedCategoryId": 659,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 448,
  "IconHint": "fuga",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "accusantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 162
    }
  }
}
```