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
  "TicketId": 337,
  "Title": "consequuntur",
  "CreatedAt": "2019-02-26T13:57:19.3283997+01:00",
  "LastChanged": "2011-01-15T13:57:19.3283997+01:00",
  "ReadByOwner": "2018-06-12T13:57:19.3283997+02:00",
  "ReadByCustomer": "2023-03-22T13:57:19.3283997+01:00",
  "FirstReadByOwner": "1998-03-02T13:57:19.3283997+01:00",
  "FirstReadByUser": "1998-09-16T13:57:19.3283997+02:00",
  "Activate": "2015-07-11T13:57:19.3283997+02:00",
  "ClosedAt": "2005-10-23T13:57:19.3283997+02:00",
  "RepliedAt": "2021-02-05T13:57:19.3283997+01:00",
  "AlertTimeout": "2011-01-16T13:57:19.3283997+01:00",
  "Deadline": "2013-10-25T13:57:19.3283997+02:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "Position": "voluptatum",
      "PersonId": 487,
      "Mrmrs": "explicabo",
      "Firstname": "Marcelle",
      "Lastname": "Williamson",
      "MiddleName": "Stanton-Wuckert",
      "Title": "recusandae",
      "Description": "Compatible tertiary contingency",
      "Email": "conner.schaefer@nitzsche.uk",
      "FullName": "Felix Ruecker",
      "DirectPhone": "748.415.7694",
      "FormalName": "Rolfson Inc and Sons",
      "CountryId": 322,
      "ContactId": 734,
      "ContactName": "Ruecker, Bogan and Ziemann",
      "Retired": 382,
      "Rank": 727,
      "ActiveInterests": 854,
      "ContactDepartment": "",
      "ContactCountryId": 891,
      "ContactOrgNr": "1747411",
      "FaxPhone": "1-966-610-5158 x451",
      "MobilePhone": "634.428.1751 x5876",
      "ContactPhone": "(652)532-5010",
      "AssociateName": "Ebert Group",
      "AssociateId": 126,
      "UsePersonAddress": false,
      "ContactFax": "incidunt",
      "Kanafname": "tempora",
      "Kanalname": "sapiente",
      "Post1": "illum",
      "Post2": "nostrum",
      "Post3": "dolorum",
      "EmailName": "beverly@walsh.co.uk",
      "ContactFullName": "Mrs. Kathleen Danielle Kerluke DVM",
      "ActiveErpLinks": 59,
      "TicketPriorityId": 984,
      "SupportLanguageId": 839,
      "SupportAssociateId": 492,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 751,
  "ConnectId": 993,
  "ReadStatus": "Green",
  "TimeToReply": 403,
  "RealTimeToReply": 160,
  "TimeToClose": 931,
  "RealTimeToClose": 841,
  "TimeSpentInternally": 823,
  "TimeSpentExternally": 607,
  "TimeSpentQueue": 591,
  "RealTimeSpentInternally": 3,
  "RealTimeSpentExternally": 160,
  "RealTimeSpentQueue": 833,
  "TimeSpent": 40,
  "HasAttachment": false,
  "NumReplies": 559,
  "NumMessages": 160,
  "FromAddress": "quia",
  "Messages": [
    {
      "TicketMessageId": 575,
      "CreatedAt": "2012-06-28T13:57:19.3283997+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "doloribus",
      "PersonId": 199,
      "PersonFullName": "Enos Harber IV",
      "ContactId": 762,
      "ContactName": "Mante LLC",
      "ContactDepartment": "",
      "NumAttachments": 950,
      "EmailHeader": "delphine.reichert@hansenstark.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "sed",
      "Sentiment": 997,
      "SentimentConfidence": 853,
      "CreatedBy": 777,
      "ChangedAt": "2000-12-03T13:57:19.3283997+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 958,
      "Name": "Kub Inc and Sons",
      "ToolTip": "Possimus quisquam eum molestiae voluptatem quia."
    },
    {
      "Id": 958,
      "Name": "Kub Inc and Sons",
      "ToolTip": "Possimus quisquam eum molestiae voluptatem quia."
    }
  ],
  "Language": "iusto",
  "Sentiment": 567,
  "SentimentConfidence": 972,
  "SuggestedCategoryId": 399,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 466,
  "IconHint": "ea",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "ab"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 590,
  "Title": "odio",
  "CreatedAt": "2020-08-14T13:57:19.3440255+02:00",
  "LastChanged": "2012-06-29T13:57:19.3440255+02:00",
  "ReadByOwner": "1998-08-29T13:57:19.3440255+02:00",
  "ReadByCustomer": "1999-04-15T13:57:19.3440255+02:00",
  "FirstReadByOwner": "2017-01-22T13:57:19.3440255+01:00",
  "FirstReadByUser": "2012-02-29T13:57:19.3440255+01:00",
  "Activate": "2010-07-24T13:57:19.3440255+02:00",
  "ClosedAt": "2009-05-27T13:57:19.3440255+02:00",
  "RepliedAt": "1997-06-11T13:57:19.3440255+02:00",
  "AlertTimeout": "2018-08-13T13:57:19.3440255+02:00",
  "Deadline": "2020-02-05T13:57:19.3440255+01:00",
  "CreatedBy": null,
  "Author": "sequi",
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
      "Position": "quis",
      "PersonId": 756,
      "Mrmrs": "recusandae",
      "Firstname": "Amir",
      "Lastname": "Wisozk",
      "MiddleName": "Halvorson Group",
      "Title": "voluptas",
      "Description": "Switchable exuding info-mediaries",
      "Email": "blaise@kulasnader.name",
      "FullName": "Terrance Grady",
      "DirectPhone": "1-437-727-0725 x903",
      "FormalName": "Zulauf Inc and Sons",
      "CountryId": 224,
      "ContactId": 335,
      "ContactName": "Jaskolski Inc and Sons",
      "Retired": 378,
      "Rank": 960,
      "ActiveInterests": 456,
      "ContactDepartment": "",
      "ContactCountryId": 284,
      "ContactOrgNr": "669623",
      "FaxPhone": "(800)756-7191 x22032",
      "MobilePhone": "364.780.0328",
      "ContactPhone": "1-217-413-7203",
      "AssociateName": "Mayer, Murazik and Corkery",
      "AssociateId": 932,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "veniam",
      "Kanalname": "neque",
      "Post1": "veniam",
      "Post2": "eveniet",
      "Post3": "omnis",
      "EmailName": "guillermo_deckow@doyle.us",
      "ContactFullName": "Berniece Jerde",
      "ActiveErpLinks": 130,
      "TicketPriorityId": 806,
      "SupportLanguageId": 357,
      "SupportAssociateId": 150,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "AlertLevel": 497,
  "ConnectId": 818,
  "ReadStatus": "Green",
  "TimeToReply": 260,
  "RealTimeToReply": 337,
  "TimeToClose": 490,
  "RealTimeToClose": 367,
  "TimeSpentInternally": 300,
  "TimeSpentExternally": 795,
  "TimeSpentQueue": 576,
  "RealTimeSpentInternally": 7,
  "RealTimeSpentExternally": 936,
  "RealTimeSpentQueue": 54,
  "TimeSpent": 89,
  "HasAttachment": true,
  "NumReplies": 343,
  "NumMessages": 354,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 568,
      "CreatedAt": "2009-03-18T13:57:19.3440255+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "repudiandae",
      "PersonId": 34,
      "PersonFullName": "Esperanza Dena Abbott II",
      "ContactId": 471,
      "ContactName": "Wolf, Okuneva and Dickinson",
      "ContactDepartment": "",
      "NumAttachments": 517,
      "EmailHeader": "josiane@kohler.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "quaerat",
      "Sentiment": 353,
      "SentimentConfidence": 843,
      "CreatedBy": 773,
      "ChangedAt": "2009-05-09T13:57:19.3440255+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 790,
      "Name": "Kshlerin-Wilderman",
      "ToolTip": "Inventore voluptatem exercitationem omnis deserunt iste ea nostrum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    },
    {
      "Id": 790,
      "Name": "Kshlerin-Wilderman",
      "ToolTip": "Inventore voluptatem exercitationem omnis deserunt iste ea nostrum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "Language": "aut",
  "Sentiment": 523,
  "SentimentConfidence": 341,
  "SuggestedCategoryId": 506,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 103,
  "IconHint": "laborum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "eveniet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 914
    }
  }
}
```