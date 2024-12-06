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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 475,
  "Title": "officia",
  "CreatedAt": "2006-06-21T10:17:56.1759487+02:00",
  "LastChanged": "2007-02-16T10:17:56.1759487+01:00",
  "ReadByOwner": "1999-07-17T10:17:56.1759487+02:00",
  "ReadByCustomer": "2006-01-11T10:17:56.1759487+01:00",
  "FirstReadByOwner": "1998-07-22T10:17:56.1759487+02:00",
  "FirstReadByUser": "1999-12-21T10:17:56.1759487+01:00",
  "Activate": "2020-11-24T10:17:56.1759487+01:00",
  "ClosedAt": "2006-12-16T10:17:56.1759487+01:00",
  "RepliedAt": "1998-07-07T10:17:56.1759487+02:00",
  "AlertTimeout": "2002-07-17T10:17:56.1759487+02:00",
  "Deadline": "2019-11-19T10:17:56.1759487+01:00",
  "CreatedBy": null,
  "Author": "ratione",
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
      "Position": "voluptas",
      "PersonId": 368,
      "Mrmrs": "iure",
      "Firstname": "Jeramy",
      "Lastname": "Predovic",
      "MiddleName": "Reichert-Jacobs",
      "Title": "dolores",
      "Description": "Reduced responsive initiative",
      "Email": "mekhi_hermiston@nienow.uk",
      "FullName": "Ernest Barton",
      "DirectPhone": "(334)976-0784",
      "FormalName": "Klein, Leffler and Koss",
      "CountryId": 784,
      "ContactId": 96,
      "ContactName": "Parker, Armstrong and Dietrich",
      "Retired": 666,
      "Rank": 366,
      "ActiveInterests": 388,
      "ContactDepartment": "",
      "ContactCountryId": 208,
      "ContactOrgNr": "970483",
      "FaxPhone": "010.373.8264",
      "MobilePhone": "864.880.4997 x66230",
      "ContactPhone": "1-809-704-2203 x372",
      "AssociateName": "Williamson, Marks and Lindgren",
      "AssociateId": 232,
      "UsePersonAddress": true,
      "ContactFax": "quisquam",
      "Kanafname": "et",
      "Kanalname": "officiis",
      "Post1": "et",
      "Post2": "et",
      "Post3": "voluptatem",
      "EmailName": "cortez@stehr.info",
      "ContactFullName": "Aleen McCullough",
      "ActiveErpLinks": 82,
      "TicketPriorityId": 924,
      "SupportLanguageId": 265,
      "SupportAssociateId": 91,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 540,
  "ConnectId": 699,
  "ReadStatus": "Green",
  "TimeToReply": 802,
  "RealTimeToReply": 525,
  "TimeToClose": 518,
  "RealTimeToClose": 19,
  "TimeSpentInternally": 768,
  "TimeSpentExternally": 137,
  "TimeSpentQueue": 587,
  "RealTimeSpentInternally": 407,
  "RealTimeSpentExternally": 619,
  "RealTimeSpentQueue": 2,
  "TimeSpent": 402,
  "HasAttachment": false,
  "NumReplies": 751,
  "NumMessages": 68,
  "FromAddress": "nulla",
  "Messages": [
    {
      "TicketMessageId": 759,
      "CreatedAt": "2018-06-13T10:17:56.1759487+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "amet",
      "PersonId": 452,
      "PersonFullName": "Bonnie Wuckert",
      "ContactId": 536,
      "ContactName": "Bartell Group",
      "ContactDepartment": "",
      "NumAttachments": 999,
      "EmailHeader": "marcia_cronin@feil.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "possimus",
      "Sentiment": 377,
      "SentimentConfidence": 508,
      "CreatedBy": 651,
      "ChangedAt": "2017-08-17T10:17:56.1759487+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 504,
      "Name": "Okuneva-O'Keefe",
      "ToolTip": "Non et nulla est explicabo dolore."
    },
    {
      "Id": 504,
      "Name": "Okuneva-O'Keefe",
      "ToolTip": "Non et nulla est explicabo dolore."
    }
  ],
  "Language": "sunt",
  "Sentiment": 478,
  "SentimentConfidence": 226,
  "SuggestedCategoryId": 178,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 386,
  "IconHint": "consequatur",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 137,
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "illo"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "odio"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 979,
  "Title": "dignissimos",
  "CreatedAt": "2015-04-29T10:17:56.1915748+02:00",
  "LastChanged": "2007-04-04T10:17:56.1915748+02:00",
  "ReadByOwner": "2011-09-15T10:17:56.1915748+02:00",
  "ReadByCustomer": "2012-12-09T10:17:56.1915748+01:00",
  "FirstReadByOwner": "2024-01-08T10:17:56.1915748+01:00",
  "FirstReadByUser": "2013-10-15T10:17:56.1915748+02:00",
  "Activate": "2007-11-10T10:17:56.1915748+01:00",
  "ClosedAt": "2014-03-21T10:17:56.1915748+01:00",
  "RepliedAt": "2000-04-25T10:17:56.1915748+02:00",
  "AlertTimeout": "1998-01-10T10:17:56.1915748+01:00",
  "Deadline": "2018-09-02T10:17:56.1915748+02:00",
  "CreatedBy": null,
  "Author": "asperiores",
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
      "Position": "quisquam",
      "PersonId": 491,
      "Mrmrs": "cum",
      "Firstname": "Haley",
      "Lastname": "Goyette",
      "MiddleName": "Ernser-Farrell",
      "Title": "occaecati",
      "Description": "Mandatory multi-state protocol",
      "Email": "michaela.quigley@green.com",
      "FullName": "Dr. Marcella Bashirian MD",
      "DirectPhone": "1-242-687-3047 x3806",
      "FormalName": "Johnston-Kuhic",
      "CountryId": 764,
      "ContactId": 726,
      "ContactName": "Blanda-Gibson",
      "Retired": 294,
      "Rank": 699,
      "ActiveInterests": 382,
      "ContactDepartment": "",
      "ContactCountryId": 783,
      "ContactOrgNr": "543320",
      "FaxPhone": "1-002-748-8249 x2501",
      "MobilePhone": "1-074-882-2215 x643",
      "ContactPhone": "997.829.6745 x0164",
      "AssociateName": "Moore, Sawayn and Leannon",
      "AssociateId": 124,
      "UsePersonAddress": true,
      "ContactFax": "officiis",
      "Kanafname": "nemo",
      "Kanalname": "totam",
      "Post1": "ut",
      "Post2": "earum",
      "Post3": "eligendi",
      "EmailName": "aron_denesik@mosciski.us",
      "ContactFullName": "Miss Cali Donnelly",
      "ActiveErpLinks": 791,
      "TicketPriorityId": 855,
      "SupportLanguageId": 569,
      "SupportAssociateId": 389,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "AlertLevel": 15,
  "ConnectId": 696,
  "ReadStatus": "Green",
  "TimeToReply": 190,
  "RealTimeToReply": 412,
  "TimeToClose": 660,
  "RealTimeToClose": 14,
  "TimeSpentInternally": 800,
  "TimeSpentExternally": 317,
  "TimeSpentQueue": 677,
  "RealTimeSpentInternally": 256,
  "RealTimeSpentExternally": 21,
  "RealTimeSpentQueue": 509,
  "TimeSpent": 382,
  "HasAttachment": true,
  "NumReplies": 795,
  "NumMessages": 719,
  "FromAddress": "deserunt",
  "Messages": [
    {
      "TicketMessageId": 454,
      "CreatedAt": "2021-07-09T10:17:56.1915748+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "earum",
      "PersonId": 786,
      "PersonFullName": "Ruthe Lubowitz",
      "ContactId": 458,
      "ContactName": "Barrows-Larson",
      "ContactDepartment": "",
      "NumAttachments": 54,
      "EmailHeader": "bernard.breitenberg@heathcote.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "perspiciatis",
      "Sentiment": 44,
      "SentimentConfidence": 150,
      "CreatedBy": 534,
      "ChangedAt": "2008-02-21T10:17:56.1915748+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 673,
      "Name": "Jakubowski, Hartmann and Barrows",
      "ToolTip": "Labore ratione laborum rerum ipsa voluptatem omnis voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    },
    {
      "Id": 673,
      "Name": "Jakubowski, Hartmann and Barrows",
      "ToolTip": "Labore ratione laborum rerum ipsa voluptatem omnis voluptas.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    }
  ],
  "Language": "enim",
  "Sentiment": 275,
  "SentimentConfidence": 458,
  "SuggestedCategoryId": 509,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 804,
  "IconHint": "cumque",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 360,
  "ExtraFields": {
    "ExtraFields1": "earum",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 154
    }
  }
}
```