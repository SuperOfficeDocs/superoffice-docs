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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketId": 678,
  "Title": "sapiente",
  "CreatedAt": "1998-01-08T10:30:32.5605542+01:00",
  "LastChanged": "2017-03-31T10:30:32.5605542+02:00",
  "ReadByOwner": "2003-01-28T10:30:32.5605542+01:00",
  "ReadByCustomer": "2019-01-20T10:30:32.5605542+01:00",
  "FirstReadByOwner": "2022-11-30T10:30:32.5605542+01:00",
  "FirstReadByUser": "2004-07-22T10:30:32.5605542+02:00",
  "Activate": "2018-04-29T10:30:32.5605542+02:00",
  "ClosedAt": "2000-09-24T10:30:32.5605542+02:00",
  "RepliedAt": "2021-07-06T10:30:32.5605542+02:00",
  "AlertTimeout": "2014-04-30T10:30:32.5605542+02:00",
  "Deadline": "2008-07-29T10:30:32.5605542+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "Position": "cum",
      "PersonId": 902,
      "Mrmrs": "dolorem",
      "Firstname": "Misty",
      "Lastname": "Fay",
      "MiddleName": "Bode, Veum and Konopelski",
      "Title": "recusandae",
      "Description": "Down-sized scalable circuit",
      "Email": "shea@greenfelder.info",
      "FullName": "Teagan Barton",
      "DirectPhone": "(480)208-4210 x23953",
      "FormalName": "Ferry Group",
      "CountryId": 995,
      "ContactId": 512,
      "ContactName": "Marquardt LLC",
      "Retired": 112,
      "Rank": 563,
      "ActiveInterests": 453,
      "ContactDepartment": "",
      "ContactCountryId": 300,
      "ContactOrgNr": "557529",
      "FaxPhone": "711-426-9548",
      "MobilePhone": "1-420-260-4871 x614",
      "ContactPhone": "398.319.1680 x01399",
      "AssociateName": "Klein LLC",
      "AssociateId": 248,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "quos",
      "Kanalname": "facilis",
      "Post1": "illum",
      "Post2": "delectus",
      "Post3": "reprehenderit",
      "EmailName": "janick@walter.biz",
      "ContactFullName": "Nadia Emmerich",
      "ActiveErpLinks": 667,
      "TicketPriorityId": 838,
      "SupportLanguageId": 741,
      "SupportAssociateId": 826,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 660,
  "ConnectId": 955,
  "ReadStatus": "Green",
  "TimeToReply": 836,
  "RealTimeToReply": 252,
  "TimeToClose": 390,
  "RealTimeToClose": 468,
  "TimeSpentInternally": 988,
  "TimeSpentExternally": 22,
  "TimeSpentQueue": 144,
  "RealTimeSpentInternally": 724,
  "RealTimeSpentExternally": 644,
  "RealTimeSpentQueue": 900,
  "TimeSpent": 333,
  "HasAttachment": false,
  "NumReplies": 521,
  "NumMessages": 451,
  "FromAddress": "delectus",
  "Messages": [
    {
      "TicketMessageId": 115,
      "CreatedAt": "2015-02-10T10:30:32.5605542+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "non",
      "PersonId": 164,
      "PersonFullName": "Miss Stella Colby Kreiger",
      "ContactId": 408,
      "ContactName": "Connelly Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 838,
      "EmailHeader": "paige@reichert.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "similique",
      "Sentiment": 929,
      "SentimentConfidence": 865,
      "CreatedBy": 554,
      "ChangedAt": "2019-04-21T10:30:32.5605542+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 876,
      "Name": "Streich, Frami and DuBuque",
      "ToolTip": "Enim dolor."
    },
    {
      "Id": 876,
      "Name": "Streich, Frami and DuBuque",
      "ToolTip": "Enim dolor."
    }
  ],
  "Language": "eos",
  "Sentiment": 854,
  "SentimentConfidence": 616,
  "SuggestedCategoryId": 267,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 635,
  "IconHint": "repudiandae",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 930,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "illo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 55,
  "Title": "voluptatibus",
  "CreatedAt": "2006-09-10T10:30:32.5762271+02:00",
  "LastChanged": "2019-06-12T10:30:32.5762271+02:00",
  "ReadByOwner": "2016-11-17T10:30:32.5762271+01:00",
  "ReadByCustomer": "2018-01-30T10:30:32.5762271+01:00",
  "FirstReadByOwner": "2011-03-01T10:30:32.5762271+01:00",
  "FirstReadByUser": "2014-12-10T10:30:32.5762271+01:00",
  "Activate": "2005-06-03T10:30:32.5762271+02:00",
  "ClosedAt": "2014-01-15T10:30:32.5762271+01:00",
  "RepliedAt": "2010-05-17T10:30:32.5762271+02:00",
  "AlertTimeout": "2021-03-26T10:30:32.5762271+01:00",
  "Deadline": "1998-04-06T10:30:32.5762271+02:00",
  "CreatedBy": null,
  "Author": "nostrum",
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
      "PersonId": 197,
      "Mrmrs": "dolor",
      "Firstname": "Lucienne",
      "Lastname": "McGlynn",
      "MiddleName": "Graham-Hudson",
      "Title": "veniam",
      "Description": "Virtual assymetric adapter",
      "Email": "arno_beier@keeling.us",
      "FullName": "Daphnee Krajcik",
      "DirectPhone": "507.862.9724",
      "FormalName": "Kuhlman LLC",
      "CountryId": 514,
      "ContactId": 450,
      "ContactName": "Schoen-Hintz",
      "Retired": 349,
      "Rank": 848,
      "ActiveInterests": 314,
      "ContactDepartment": "",
      "ContactCountryId": 944,
      "ContactOrgNr": "1794344",
      "FaxPhone": "1-276-982-6564",
      "MobilePhone": "111.614.0750 x450",
      "ContactPhone": "1-569-920-4277 x21952",
      "AssociateName": "Reinger Inc and Sons",
      "AssociateId": 200,
      "UsePersonAddress": false,
      "ContactFax": "vero",
      "Kanafname": "qui",
      "Kanalname": "exercitationem",
      "Post1": "suscipit",
      "Post2": "et",
      "Post3": "voluptate",
      "EmailName": "neal@franeckimayer.info",
      "ContactFullName": "Mrs. Wade Emmerich DDS",
      "ActiveErpLinks": 406,
      "TicketPriorityId": 902,
      "SupportLanguageId": 467,
      "SupportAssociateId": 274,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    }
  ],
  "AlertLevel": 268,
  "ConnectId": 780,
  "ReadStatus": "Green",
  "TimeToReply": 982,
  "RealTimeToReply": 490,
  "TimeToClose": 696,
  "RealTimeToClose": 911,
  "TimeSpentInternally": 249,
  "TimeSpentExternally": 484,
  "TimeSpentQueue": 562,
  "RealTimeSpentInternally": 835,
  "RealTimeSpentExternally": 101,
  "RealTimeSpentQueue": 353,
  "TimeSpent": 21,
  "HasAttachment": false,
  "NumReplies": 539,
  "NumMessages": 676,
  "FromAddress": "quas",
  "Messages": [
    {
      "TicketMessageId": 920,
      "CreatedAt": "2017-11-15T10:30:32.5762271+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ipsa",
      "PersonId": 568,
      "PersonFullName": "Jamarcus Lockman",
      "ContactId": 844,
      "ContactName": "Graham-Cormier",
      "ContactDepartment": "",
      "NumAttachments": 395,
      "EmailHeader": "carlee_hintz@kreiger.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 250,
      "SentimentConfidence": 996,
      "CreatedBy": 681,
      "ChangedAt": "2018-04-03T10:30:32.5762271+02:00",
      "Badge": "Comment",
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
  "Tags": [
    {
      "Id": 783,
      "Name": "Parker, Welch and Ortiz",
      "ToolTip": "Dicta id qui non deserunt facilis sapiente.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    },
    {
      "Id": 783,
      "Name": "Parker, Welch and Ortiz",
      "ToolTip": "Dicta id qui non deserunt facilis sapiente.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    }
  ],
  "Language": "magnam",
  "Sentiment": 189,
  "SentimentConfidence": 30,
  "SuggestedCategoryId": 560,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 774,
  "IconHint": "doloremque",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 532,
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 597
    }
  }
}
```