---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

The TicketEntity to be saved. 

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 810,
  "Title": "deleniti",
  "CreatedAt": "1999-07-04T13:28:23.8666889+02:00",
  "LastChanged": "2014-08-15T13:28:23.8666889+02:00",
  "ReadByOwner": "2009-11-02T13:28:23.8666889+01:00",
  "ReadByCustomer": "2020-10-08T13:28:23.8666889+02:00",
  "FirstReadByOwner": "2007-05-03T13:28:23.8666889+02:00",
  "FirstReadByUser": "2014-08-29T13:28:23.8666889+02:00",
  "Activate": "2016-01-24T13:28:23.8666889+01:00",
  "ClosedAt": "2020-12-18T13:28:23.8666889+01:00",
  "RepliedAt": "2009-08-03T13:28:23.8666889+02:00",
  "AlertTimeout": "1997-05-23T13:28:23.8666889+02:00",
  "Deadline": "2021-02-23T13:28:23.8666889+01:00",
  "CreatedBy": null,
  "Author": "autem",
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
      "Position": "quasi",
      "PersonId": 953,
      "Mrmrs": "nulla",
      "Firstname": "Leif",
      "Lastname": "Gleichner",
      "MiddleName": "Klocko LLC",
      "Title": "molestiae",
      "Description": "Fundamental uniform archive",
      "Email": "luther_collier@stokeshane.ca",
      "FullName": "Stuart Joelle Langworth V",
      "DirectPhone": "(542)044-7814 x4511",
      "FormalName": "Jacobi, Jaskolski and Denesik",
      "CountryId": 754,
      "ContactId": 383,
      "ContactName": "Waters LLC",
      "Retired": 277,
      "Rank": 719,
      "ActiveInterests": 346,
      "ContactDepartment": "",
      "ContactCountryId": 572,
      "ContactOrgNr": "1016610",
      "FaxPhone": "049-632-0409 x96307",
      "MobilePhone": "(422)657-6931",
      "ContactPhone": "1-174-728-8947 x2392",
      "AssociateName": "Rodriguez-Bruen",
      "AssociateId": 720,
      "UsePersonAddress": false,
      "ContactFax": "porro",
      "Kanafname": "voluptatem",
      "Kanalname": "et",
      "Post1": "et",
      "Post2": "illum",
      "Post3": "explicabo",
      "EmailName": "bill_donnelly@hirthe.info",
      "ContactFullName": "Janet O'Hara",
      "ActiveErpLinks": 978,
      "TicketPriorityId": 338,
      "SupportLanguageId": 273,
      "SupportAssociateId": 514,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 809,
  "ConnectId": 401,
  "ReadStatus": "Green",
  "TimeToReply": 834,
  "RealTimeToReply": 199,
  "TimeToClose": 1001,
  "RealTimeToClose": 119,
  "TimeSpentInternally": 518,
  "TimeSpentExternally": 207,
  "TimeSpentQueue": 159,
  "RealTimeSpentInternally": 100,
  "RealTimeSpentExternally": 915,
  "RealTimeSpentQueue": 97,
  "TimeSpent": 595,
  "HasAttachment": false,
  "NumReplies": 636,
  "NumMessages": 228,
  "FromAddress": "sequi",
  "Messages": [
    {
      "TicketMessageId": 902,
      "CreatedAt": "2019-06-16T13:28:23.8666889+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptate",
      "PersonId": 714,
      "PersonFullName": "Mr. Elsa Effie Breitenberg",
      "ContactId": 903,
      "ContactName": "Greenfelder-Strosin",
      "ContactDepartment": "",
      "NumAttachments": 777,
      "EmailHeader": "geovanny.harber@gorczany.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magnam",
      "Sentiment": 786,
      "SentimentConfidence": 682,
      "CreatedBy": 783,
      "ChangedAt": "2002-12-22T13:28:23.8666889+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 766,
      "Name": "Stark LLC",
      "ToolTip": "Dolores culpa."
    },
    {
      "Id": 766,
      "Name": "Stark LLC",
      "ToolTip": "Dolores culpa."
    }
  ],
  "Language": "quibusdam",
  "Sentiment": 882,
  "SentimentConfidence": 232,
  "SuggestedCategoryId": 846,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 132,
  "IconHint": "optio",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 259,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "similique"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 405,
  "Title": "eaque",
  "CreatedAt": "2017-06-25T13:28:23.8823119+02:00",
  "LastChanged": "2023-10-19T13:28:23.8823119+02:00",
  "ReadByOwner": "2005-05-04T13:28:23.8823119+02:00",
  "ReadByCustomer": "2013-03-01T13:28:23.8823119+01:00",
  "FirstReadByOwner": "2007-02-08T13:28:23.8823119+01:00",
  "FirstReadByUser": "2009-02-18T13:28:23.8823119+01:00",
  "Activate": "2018-03-12T13:28:23.8823119+01:00",
  "ClosedAt": "2002-11-29T13:28:23.8823119+01:00",
  "RepliedAt": "2023-02-03T13:28:23.8823119+01:00",
  "AlertTimeout": "2005-06-08T13:28:23.8823119+02:00",
  "Deadline": "2009-11-06T13:28:23.8823119+01:00",
  "CreatedBy": null,
  "Author": "laudantium",
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
      "Position": "recusandae",
      "PersonId": 786,
      "Mrmrs": "consequuntur",
      "Firstname": "Colten",
      "Lastname": "Marquardt",
      "MiddleName": "Franecki LLC",
      "Title": "quos",
      "Description": "Cross-group national capacity",
      "Email": "matt_harvey@fahey.us",
      "FullName": "Chyna Veum I",
      "DirectPhone": "(696)743-0836 x93002",
      "FormalName": "Murazik-Veum",
      "CountryId": 28,
      "ContactId": 551,
      "ContactName": "Collier-Lockman",
      "Retired": 125,
      "Rank": 321,
      "ActiveInterests": 261,
      "ContactDepartment": "",
      "ContactCountryId": 37,
      "ContactOrgNr": "1500896",
      "FaxPhone": "141.369.3625",
      "MobilePhone": "(943)303-4323",
      "ContactPhone": "(018)817-3426",
      "AssociateName": "Spencer Inc and Sons",
      "AssociateId": 485,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "ullam",
      "Kanalname": "quaerat",
      "Post1": "dolor",
      "Post2": "qui",
      "Post3": "voluptatum",
      "EmailName": "jena.maggio@windler.ca",
      "ContactFullName": "Evans Heaney",
      "ActiveErpLinks": 134,
      "TicketPriorityId": 509,
      "SupportLanguageId": 453,
      "SupportAssociateId": 885,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "AlertLevel": 279,
  "ConnectId": 68,
  "ReadStatus": "Green",
  "TimeToReply": 619,
  "RealTimeToReply": 470,
  "TimeToClose": 495,
  "RealTimeToClose": 657,
  "TimeSpentInternally": 473,
  "TimeSpentExternally": 100,
  "TimeSpentQueue": 576,
  "RealTimeSpentInternally": 345,
  "RealTimeSpentExternally": 312,
  "RealTimeSpentQueue": 591,
  "TimeSpent": 962,
  "HasAttachment": true,
  "NumReplies": 574,
  "NumMessages": 624,
  "FromAddress": "nulla",
  "Messages": [
    {
      "TicketMessageId": 615,
      "CreatedAt": "1999-08-03T13:28:23.8823119+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "et",
      "PersonId": 169,
      "PersonFullName": "Pink Hoppe",
      "ContactId": 783,
      "ContactName": "Luettgen, Rodriguez and Beahan",
      "ContactDepartment": "",
      "NumAttachments": 498,
      "EmailHeader": "kelvin.macejkovic@kiehn.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "praesentium",
      "Sentiment": 330,
      "SentimentConfidence": 780,
      "CreatedBy": 32,
      "ChangedAt": "2005-02-15T13:28:23.8823119+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 12,
      "Name": "Cremin-Ziemann",
      "ToolTip": "Vel rerum iure delectus ex in sit veniam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    },
    {
      "Id": 12,
      "Name": "Cremin-Ziemann",
      "ToolTip": "Vel rerum iure delectus ex in sit veniam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "Language": "eos",
  "Sentiment": 303,
  "SentimentConfidence": 538,
  "SuggestedCategoryId": 520,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 849,
  "IconHint": "dolores",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 649,
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "ipsum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 458
    }
  }
}
```