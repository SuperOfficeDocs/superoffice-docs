---
title: PUT Ticket/{id}
uid: v1TicketEntity_HttpPutSaveTicketEntityWithNotify
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
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
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 749,
  "Title": "non",
  "CreatedAt": "2008-04-14T12:15:27.4666283+02:00",
  "LastChanged": "2014-02-13T12:15:27.4666283+01:00",
  "ReadByOwner": "2021-06-07T12:15:27.4666283+02:00",
  "ReadByCustomer": "1997-11-06T12:15:27.4666283+01:00",
  "FirstReadByOwner": "2010-10-01T12:15:27.4666283+02:00",
  "FirstReadByUser": "2002-07-03T12:15:27.4666283+02:00",
  "Activate": "2005-10-27T12:15:27.4666283+02:00",
  "ClosedAt": "2000-09-08T12:15:27.4666283+02:00",
  "RepliedAt": "2014-03-02T12:15:27.4666283+01:00",
  "AlertTimeout": "2010-11-07T12:15:27.4666283+01:00",
  "Deadline": "2000-05-08T12:15:27.4666283+02:00",
  "CreatedBy": null,
  "Author": "dolorum",
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
      "Position": "et",
      "PersonId": 405,
      "Mrmrs": "cupiditate",
      "Firstname": "Nickolas",
      "Lastname": "D'Amore",
      "MiddleName": "Schmidt Group",
      "Title": "vitae",
      "Description": "Cross-platform needs-based challenge",
      "Email": "buck@connelly.uk",
      "FullName": "Miss Danial Prohaska",
      "DirectPhone": "523-816-9484",
      "FormalName": "Harber Group",
      "CountryId": 515,
      "ContactId": 319,
      "ContactName": "Jerde Group",
      "Retired": 45,
      "Rank": 461,
      "ActiveInterests": 480,
      "ContactDepartment": "",
      "ContactCountryId": 187,
      "ContactOrgNr": "699936",
      "FaxPhone": "889.916.3314",
      "MobilePhone": "(697)506-6926",
      "ContactPhone": "246.047.5926 x0893",
      "AssociateName": "Hartmann-Ullrich",
      "AssociateId": 856,
      "UsePersonAddress": true,
      "ContactFax": "temporibus",
      "Kanafname": "ut",
      "Kanalname": "sint",
      "Post1": "omnis",
      "Post2": "dolorum",
      "Post3": "totam",
      "EmailName": "maxie@beierdibbert.co.uk",
      "ContactFullName": "Broderick Bayer I",
      "ActiveErpLinks": 228,
      "TicketPriorityId": 508,
      "SupportLanguageId": 660,
      "SupportAssociateId": 723,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 701,
  "ConnectId": 837,
  "ReadStatus": "Green",
  "TimeToReply": 951,
  "RealTimeToReply": 432,
  "TimeToClose": 539,
  "RealTimeToClose": 736,
  "TimeSpentInternally": 816,
  "TimeSpentExternally": 649,
  "TimeSpentQueue": 158,
  "RealTimeSpentInternally": 331,
  "RealTimeSpentExternally": 837,
  "RealTimeSpentQueue": 2,
  "HasAttachment": false,
  "NumReplies": 917,
  "NumMessages": 726,
  "FromAddress": "aliquid",
  "Messages": [
    {
      "TicketMessageId": 962,
      "CreatedAt": "2000-05-21T12:15:27.471628+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ducimus",
      "PersonId": 449,
      "PersonFullName": "Mrs. Edmund Mertz",
      "ContactId": 78,
      "ContactName": "Ullrich Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 521,
      "EmailHeader": "heaven@wisoky.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "enim",
      "Sentiment": 154,
      "SentimentConfidence": 820,
      "CreatedBy": 777,
      "ChangedAt": "2021-10-09T12:15:27.4726282+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 921,
      "Name": "Sawayn-D'Amore",
      "ToolTip": "Illum necessitatibus."
    },
    {
      "Id": 921,
      "Name": "Sawayn-D'Amore",
      "ToolTip": "Illum necessitatibus."
    }
  ],
  "Language": "et",
  "Sentiment": 985,
  "SentimentConfidence": 665,
  "SuggestedCategoryId": 764,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 217,
  "IconHint": "esse",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "possimus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 627,
  "Title": "minima",
  "CreatedAt": "1997-07-18T12:15:27.4816279+02:00",
  "LastChanged": "2006-07-24T12:15:27.4816279+02:00",
  "ReadByOwner": "2001-01-04T12:15:27.4816279+01:00",
  "ReadByCustomer": "2007-08-15T12:15:27.4816279+02:00",
  "FirstReadByOwner": "2014-06-16T12:15:27.4816279+02:00",
  "FirstReadByUser": "1999-10-07T12:15:27.4816279+02:00",
  "Activate": "2021-05-24T12:15:27.4816279+02:00",
  "ClosedAt": "2009-04-21T12:15:27.4816279+02:00",
  "RepliedAt": "1995-12-20T12:15:27.4816279+01:00",
  "AlertTimeout": "1997-08-25T12:15:27.4816279+02:00",
  "Deadline": "2022-09-06T12:15:27.4816279+02:00",
  "CreatedBy": null,
  "Author": "aliquid",
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
      "Position": "voluptates",
      "PersonId": 332,
      "Mrmrs": "quo",
      "Firstname": "Coty",
      "Lastname": "Swaniawski",
      "MiddleName": "Hintz, Parisian and Kulas",
      "Title": "nesciunt",
      "Description": "Grass-roots non-volatile core",
      "Email": "dasia@rice.com",
      "FullName": "Jake Runolfsdottir",
      "DirectPhone": "(380)669-1334",
      "FormalName": "Larkin-Heaney",
      "CountryId": 423,
      "ContactId": 413,
      "ContactName": "Hills, Huels and Hansen",
      "Retired": 586,
      "Rank": 554,
      "ActiveInterests": 465,
      "ContactDepartment": "",
      "ContactCountryId": 288,
      "ContactOrgNr": "1771493",
      "FaxPhone": "315.567.1171 x67592",
      "MobilePhone": "(476)028-3200",
      "ContactPhone": "644-652-6444 x206",
      "AssociateName": "DuBuque, Jakubowski and Gibson",
      "AssociateId": 298,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "quas",
      "Kanalname": "dolorum",
      "Post1": "voluptatibus",
      "Post2": "omnis",
      "Post3": "quia",
      "EmailName": "mireille@wisoky.com",
      "ContactFullName": "Vaughn Swaniawski DVM",
      "ActiveErpLinks": 790,
      "TicketPriorityId": 210,
      "SupportLanguageId": 691,
      "SupportAssociateId": 411,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 172
        }
      }
    }
  ],
  "AlertLevel": 820,
  "ConnectId": 619,
  "ReadStatus": "Green",
  "TimeToReply": 133,
  "RealTimeToReply": 383,
  "TimeToClose": 246,
  "RealTimeToClose": 580,
  "TimeSpentInternally": 217,
  "TimeSpentExternally": 633,
  "TimeSpentQueue": 739,
  "RealTimeSpentInternally": 575,
  "RealTimeSpentExternally": 718,
  "RealTimeSpentQueue": 556,
  "HasAttachment": false,
  "NumReplies": 310,
  "NumMessages": 215,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 779,
      "CreatedAt": "2005-11-13T12:15:27.4856307+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "perspiciatis",
      "PersonId": 519,
      "PersonFullName": "Milo McLaughlin",
      "ContactId": 501,
      "ContactName": "Vandervort-Dietrich",
      "ContactDepartment": "",
      "NumAttachments": 721,
      "EmailHeader": "susanna_bednar@pouros.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 80,
      "SentimentConfidence": 691,
      "CreatedBy": 514,
      "ChangedAt": "2022-07-21T12:15:27.4866286+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 167,
      "Name": "Upton-White",
      "ToolTip": "Et quis cumque impedit nam dolorem et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Id": 167,
      "Name": "Upton-White",
      "ToolTip": "Et quis cumque impedit nam dolorem et.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Language": "itaque",
  "Sentiment": 612,
  "SentimentConfidence": 543,
  "SuggestedCategoryId": 626,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 462,
  "IconHint": "suscipit",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 139
    }
  }
}
```