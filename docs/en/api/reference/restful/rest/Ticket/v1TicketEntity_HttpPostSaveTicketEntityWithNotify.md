---
title: POST Ticket
uid: v1TicketEntity_HttpPostSaveTicketEntityWithNotify
generated: true
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
POST /api/v1/Ticket?notify=True
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 875,
  "Title": "ut",
  "CreatedAt": "1997-01-31T11:16:14.24609+01:00",
  "LastChanged": "2000-05-20T11:16:14.24609+02:00",
  "ReadByOwner": "2011-05-09T11:16:14.24609+02:00",
  "ReadByCustomer": "2023-11-05T11:16:14.24609+01:00",
  "FirstReadByOwner": "2013-09-14T11:16:14.24609+02:00",
  "FirstReadByUser": "2022-05-06T11:16:14.24609+02:00",
  "Activate": "1998-11-09T11:16:14.24609+01:00",
  "ClosedAt": "1999-05-21T11:16:14.24609+02:00",
  "RepliedAt": "2010-07-28T11:16:14.24609+02:00",
  "AlertTimeout": "2022-07-24T11:16:14.24609+02:00",
  "Deadline": "2015-05-16T11:16:14.24609+02:00",
  "CreatedBy": null,
  "Author": "aspernatur",
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
      "Position": "totam",
      "PersonId": 995,
      "Mrmrs": "perspiciatis",
      "Firstname": "George",
      "Lastname": "Kemmer",
      "MiddleName": "Schneider-O'Keefe",
      "Title": "hic",
      "Description": "Reverse-engineered non-volatile analyzer",
      "Email": "emilie_schamberger@muller.biz",
      "FullName": "Rebeca Krajcik",
      "DirectPhone": "058.596.7149",
      "FormalName": "Paucek, Hills and Beahan",
      "CountryId": 692,
      "ContactId": 524,
      "ContactName": "Von, Mitchell and Schneider",
      "Retired": 600,
      "Rank": 458,
      "ActiveInterests": 871,
      "ContactDepartment": "",
      "ContactCountryId": 799,
      "ContactOrgNr": "1591533",
      "FaxPhone": "1-811-959-1426 x2739",
      "MobilePhone": "1-865-982-2904 x087",
      "ContactPhone": "381-549-0766",
      "AssociateName": "D'Amore-Walker",
      "AssociateId": 726,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "ut",
      "Kanalname": "tenetur",
      "Post1": "neque",
      "Post2": "voluptate",
      "Post3": "porro",
      "EmailName": "monroe_rippin@cormier.info",
      "ContactFullName": "Malvina Collier",
      "ActiveErpLinks": 482,
      "TicketPriorityId": 692,
      "SupportLanguageId": 504,
      "SupportAssociateId": 984,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 982,
  "ConnectId": 319,
  "ReadStatus": "Green",
  "TimeToReply": 702,
  "RealTimeToReply": 409,
  "TimeToClose": 459,
  "RealTimeToClose": 142,
  "TimeSpentInternally": 688,
  "TimeSpentExternally": 300,
  "TimeSpentQueue": 533,
  "RealTimeSpentInternally": 720,
  "RealTimeSpentExternally": 142,
  "RealTimeSpentQueue": 64,
  "TimeSpent": 696,
  "HasAttachment": false,
  "NumReplies": 185,
  "NumMessages": 241,
  "FromAddress": "autem",
  "Messages": [
    {
      "TicketMessageId": 791,
      "CreatedAt": "2005-01-31T11:16:14.24609+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "vel",
      "PersonId": 147,
      "PersonFullName": "Leo Jules Deckow IV",
      "ContactId": 190,
      "ContactName": "Marquardt-Bernier",
      "ContactDepartment": "",
      "NumAttachments": 820,
      "EmailHeader": "mozell_crona@kub.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 731,
      "SentimentConfidence": 622,
      "CreatedBy": 548,
      "ChangedAt": "2004-06-26T11:16:14.24609+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 574,
      "Name": "Feeney, Herzog and Robel",
      "ToolTip": "Non est ut consequatur reiciendis quidem."
    },
    {
      "Id": 574,
      "Name": "Feeney, Herzog and Robel",
      "ToolTip": "Non est ut consequatur reiciendis quidem."
    }
  ],
  "Language": "et",
  "Sentiment": 236,
  "SentimentConfidence": 358,
  "SuggestedCategoryId": 808,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 298,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 818,
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "eveniet"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 272,
  "Title": "quia",
  "CreatedAt": "2011-04-02T11:16:14.2617167+02:00",
  "LastChanged": "2020-09-15T11:16:14.2617167+02:00",
  "ReadByOwner": "2017-12-01T11:16:14.2617167+01:00",
  "ReadByCustomer": "2018-10-18T11:16:14.2617167+02:00",
  "FirstReadByOwner": "2000-05-18T11:16:14.2617167+02:00",
  "FirstReadByUser": "2004-02-04T11:16:14.2617167+01:00",
  "Activate": "2011-10-01T11:16:14.2617167+02:00",
  "ClosedAt": "2009-12-15T11:16:14.2617167+01:00",
  "RepliedAt": "2003-08-24T11:16:14.2617167+02:00",
  "AlertTimeout": "2021-12-24T11:16:14.2617167+01:00",
  "Deadline": "2008-01-14T11:16:14.2617167+01:00",
  "CreatedBy": null,
  "Author": "distinctio",
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
      "Position": "quidem",
      "PersonId": 582,
      "Mrmrs": "occaecati",
      "Firstname": "Bulah",
      "Lastname": "Kiehn",
      "MiddleName": "Harris-Boyer",
      "Title": "est",
      "Description": "Self-enabling radical strategy",
      "Email": "tevin.donnelly@altenwerth.co.uk",
      "FullName": "Ezequiel Schultz",
      "DirectPhone": "(844)630-5363 x156",
      "FormalName": "Brown Inc and Sons",
      "CountryId": 402,
      "ContactId": 303,
      "ContactName": "Krajcik-Dooley",
      "Retired": 388,
      "Rank": 889,
      "ActiveInterests": 308,
      "ContactDepartment": "",
      "ContactCountryId": 678,
      "ContactOrgNr": "663155",
      "FaxPhone": "(046)387-6614",
      "MobilePhone": "858.431.8212 x2177",
      "ContactPhone": "806-323-4781",
      "AssociateName": "O'Kon, Beatty and Davis",
      "AssociateId": 491,
      "UsePersonAddress": true,
      "ContactFax": "iure",
      "Kanafname": "autem",
      "Kanalname": "architecto",
      "Post1": "eos",
      "Post2": "fugit",
      "Post3": "voluptatem",
      "EmailName": "winifred@kautzerbraun.com",
      "ContactFullName": "Dr. Sallie Emilio Jones",
      "ActiveErpLinks": 364,
      "TicketPriorityId": 859,
      "SupportLanguageId": 560,
      "SupportAssociateId": 478,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 95
        }
      }
    }
  ],
  "AlertLevel": 35,
  "ConnectId": 537,
  "ReadStatus": "Green",
  "TimeToReply": 17,
  "RealTimeToReply": 271,
  "TimeToClose": 521,
  "RealTimeToClose": 458,
  "TimeSpentInternally": 131,
  "TimeSpentExternally": 302,
  "TimeSpentQueue": 102,
  "RealTimeSpentInternally": 934,
  "RealTimeSpentExternally": 321,
  "RealTimeSpentQueue": 689,
  "TimeSpent": 891,
  "HasAttachment": true,
  "NumReplies": 725,
  "NumMessages": 172,
  "FromAddress": "nulla",
  "Messages": [
    {
      "TicketMessageId": 684,
      "CreatedAt": "1999-02-25T11:16:14.2617167+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quia",
      "PersonId": 451,
      "PersonFullName": "Vince Delaney Schowalter III",
      "ContactId": 373,
      "ContactName": "Davis LLC",
      "ContactDepartment": "",
      "NumAttachments": 874,
      "EmailHeader": "shanie_balistreri@hyattaltenwerth.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "nisi",
      "Sentiment": 257,
      "SentimentConfidence": 121,
      "CreatedBy": 84,
      "ChangedAt": "2009-07-27T11:16:14.2617167+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 734,
      "Name": "Cronin, Fay and Mante",
      "ToolTip": "Ducimus omnis dolor at voluptatem doloremque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    },
    {
      "Id": 734,
      "Name": "Cronin, Fay and Mante",
      "ToolTip": "Ducimus omnis dolor at voluptatem doloremque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    }
  ],
  "Language": "quo",
  "Sentiment": 834,
  "SentimentConfidence": 138,
  "SuggestedCategoryId": 478,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 497,
  "IconHint": "labore",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 133,
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 904
    }
  }
}
```