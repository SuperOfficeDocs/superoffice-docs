---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
content_type: reference
---

# POST Ticket

```http
POST /api/v1/Ticket
```

Saves a ticket and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notifications will be sent |

```http
POST /api/v1/Ticket?notify=False
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

## Request Body: newEntity 

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
POST /api/v1/Ticket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 854,
  "Title": "excepturi",
  "CreatedAt": "2017-06-14T03:47:00.316185+02:00",
  "LastChanged": "2008-09-01T03:47:00.316185+02:00",
  "ReadByOwner": "2016-10-19T03:47:00.316185+02:00",
  "ReadByCustomer": "2019-06-24T03:47:00.316185+02:00",
  "FirstReadByOwner": "2005-08-20T03:47:00.316185+02:00",
  "FirstReadByUser": "2006-02-22T03:47:00.316185+01:00",
  "Activate": "2001-12-29T03:47:00.316185+01:00",
  "ClosedAt": "2018-09-02T03:47:00.316185+02:00",
  "RepliedAt": "2008-06-09T03:47:00.316185+02:00",
  "AlertTimeout": "2001-07-09T03:47:00.316185+02:00",
  "Deadline": "2003-02-14T03:47:00.316185+01:00",
  "CreatedBy": null,
  "Author": "sunt",
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
      "Position": "distinctio",
      "PersonId": 964,
      "Mrmrs": "aut",
      "Firstname": "Dewayne",
      "Lastname": "Grady",
      "MiddleName": "O'Keefe-Runolfsson",
      "Title": "est",
      "Description": "Digitized even-keeled synergy",
      "Email": "danny.nienow@lefflerwindler.co.uk",
      "FullName": "Charlotte Corwin",
      "DirectPhone": "(032)798-2149",
      "FormalName": "Anderson-Johnson",
      "CountryId": 898,
      "ContactId": 123,
      "ContactName": "Hahn, Dickens and Toy",
      "Retired": 881,
      "Rank": 143,
      "ActiveInterests": 622,
      "ContactDepartment": "",
      "ContactCountryId": 359,
      "ContactOrgNr": "1162834",
      "FaxPhone": "966.885.4851",
      "MobilePhone": "1-010-206-3022 x243",
      "ContactPhone": "511.818.8938",
      "AssociateName": "Bradtke Group",
      "AssociateId": 251,
      "UsePersonAddress": true,
      "ContactFax": "rerum",
      "Kanafname": "voluptas",
      "Kanalname": "quia",
      "Post1": "illo",
      "Post2": "esse",
      "Post3": "quo",
      "EmailName": "jayda_greenfelder@ziemespencer.com",
      "ContactFullName": "Mrs. Marielle Abbott III",
      "ActiveErpLinks": 208,
      "TicketPriorityId": 754,
      "SupportLanguageId": 713,
      "SupportAssociateId": 886,
      "CategoryName": "VIP Customer",
      "PersonNumber": "636008"
    }
  ],
  "AlertLevel": 714,
  "ConnectId": 939,
  "ReadStatus": "Green",
  "TimeToReply": 496,
  "RealTimeToReply": 886,
  "TimeToClose": 795,
  "RealTimeToClose": 96,
  "TimeSpentInternally": 698,
  "TimeSpentExternally": 990,
  "TimeSpentQueue": 771,
  "RealTimeSpentInternally": 222,
  "RealTimeSpentExternally": 935,
  "RealTimeSpentQueue": 434,
  "TimeSpent": 392,
  "HasAttachment": false,
  "NumReplies": 213,
  "NumMessages": 530,
  "FromAddress": "soluta",
  "Messages": [
    {
      "TicketMessageId": 363,
      "CreatedAt": "2024-12-17T03:47:00.316185+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quae",
      "PersonId": 964,
      "PersonFullName": "Mr. Rosella Yundt",
      "ContactId": 117,
      "ContactName": "Gottlieb-Sporer",
      "ContactDepartment": "",
      "NumAttachments": 670,
      "EmailHeader": "ransom_toy@wolff.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "officia",
      "Sentiment": 706,
      "SentimentConfidence": 59,
      "CreatedBy": 73,
      "ChangedAt": "2015-11-16T03:47:00.316185+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 107,
      "Name": "Dooley Group",
      "ToolTip": "Praesentium asperiores quas aperiam consequuntur."
    },
    {
      "Id": 107,
      "Name": "Dooley Group",
      "ToolTip": "Praesentium asperiores quas aperiam consequuntur."
    }
  ],
  "Language": "beatae",
  "Sentiment": 116,
  "SentimentConfidence": 865,
  "SuggestedCategoryId": 432,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 836,
  "IconHint": "dicta",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 990,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "pariatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 745,
  "Title": "est",
  "CreatedAt": "2012-03-13T03:47:00.316185+01:00",
  "LastChanged": "2022-01-23T03:47:00.316185+01:00",
  "ReadByOwner": "2019-11-05T03:47:00.316185+01:00",
  "ReadByCustomer": "2002-07-31T03:47:00.316185+02:00",
  "FirstReadByOwner": "2016-11-11T03:47:00.316185+01:00",
  "FirstReadByUser": "1999-07-31T03:47:00.316185+02:00",
  "Activate": "2021-07-24T03:47:00.316185+02:00",
  "ClosedAt": "2019-01-18T03:47:00.316185+01:00",
  "RepliedAt": "2003-12-23T03:47:00.316185+01:00",
  "AlertTimeout": "2008-09-25T03:47:00.316185+02:00",
  "Deadline": "2018-06-28T03:47:00.316185+02:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "Position": "sapiente",
      "PersonId": 399,
      "Mrmrs": "illo",
      "Firstname": "Molly",
      "Lastname": "Mueller",
      "MiddleName": "Morar Inc and Sons",
      "Title": "ab",
      "Description": "Quality-focused optimal utilisation",
      "Email": "maiya.gutmann@altenwerth.biz",
      "FullName": "Julius Zulauf",
      "DirectPhone": "1-462-844-5661",
      "FormalName": "Skiles, Stanton and Satterfield",
      "CountryId": 273,
      "ContactId": 390,
      "ContactName": "Rippin-Eichmann",
      "Retired": 585,
      "Rank": 119,
      "ActiveInterests": 206,
      "ContactDepartment": "",
      "ContactCountryId": 470,
      "ContactOrgNr": "281800",
      "FaxPhone": "276.505.0015 x27906",
      "MobilePhone": "(293)578-0875",
      "ContactPhone": "(079)664-7689 x286",
      "AssociateName": "Wolf-Braun",
      "AssociateId": 764,
      "UsePersonAddress": false,
      "ContactFax": "vero",
      "Kanafname": "eum",
      "Kanalname": "aliquid",
      "Post1": "sunt",
      "Post2": "fugiat",
      "Post3": "vero",
      "EmailName": "itzel.spinka@goyettekling.ca",
      "ContactFullName": "Mr. Ryleigh Wintheiser",
      "ActiveErpLinks": 908,
      "TicketPriorityId": 725,
      "SupportLanguageId": 449,
      "SupportAssociateId": 968,
      "CategoryName": "VIP Customer",
      "PersonNumber": "417209",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "AlertLevel": 999,
  "ConnectId": 481,
  "ReadStatus": "Green",
  "TimeToReply": 270,
  "RealTimeToReply": 532,
  "TimeToClose": 424,
  "RealTimeToClose": 36,
  "TimeSpentInternally": 932,
  "TimeSpentExternally": 817,
  "TimeSpentQueue": 284,
  "RealTimeSpentInternally": 574,
  "RealTimeSpentExternally": 906,
  "RealTimeSpentQueue": 25,
  "TimeSpent": 558,
  "HasAttachment": true,
  "NumReplies": 888,
  "NumMessages": 882,
  "FromAddress": "quasi",
  "Messages": [
    {
      "TicketMessageId": 795,
      "CreatedAt": "2015-11-14T03:47:00.3318094+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eligendi",
      "PersonId": 913,
      "PersonFullName": "Zetta Gottlieb",
      "ContactId": 157,
      "ContactName": "Deckow-Jaskolski",
      "ContactDepartment": "",
      "NumAttachments": 450,
      "EmailHeader": "alex.rath@mcclurerohan.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "vel",
      "Sentiment": 4,
      "SentimentConfidence": 489,
      "CreatedBy": 527,
      "ChangedAt": "1998-06-24T03:47:00.3318094+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 359,
      "Name": "DuBuque Inc and Sons",
      "ToolTip": "Et et sed aut omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    },
    {
      "Id": 359,
      "Name": "DuBuque Inc and Sons",
      "ToolTip": "Et et sed aut omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "Language": "assumenda",
  "Sentiment": 224,
  "SentimentConfidence": 774,
  "SuggestedCategoryId": 604,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 793,
  "IconHint": "sed",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 95,
  "ExtraFields": {
    "ExtraFields1": "error",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 79
    }
  }
}
```