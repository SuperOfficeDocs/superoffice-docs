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
  "TicketId": 256,
  "Title": "dolores",
  "CreatedAt": "2002-01-28T11:22:45.2724513+01:00",
  "LastChanged": "2011-01-17T11:22:45.2724513+01:00",
  "ReadByOwner": "1996-11-06T11:22:45.2724513+01:00",
  "ReadByCustomer": "1997-07-13T11:22:45.2724513+02:00",
  "FirstReadByOwner": "2000-04-30T11:22:45.2724513+02:00",
  "FirstReadByUser": "2009-11-20T11:22:45.2724513+01:00",
  "Activate": "2009-10-20T11:22:45.2724513+02:00",
  "ClosedAt": "2013-01-27T11:22:45.2724513+01:00",
  "RepliedAt": "2005-07-21T11:22:45.2724513+02:00",
  "AlertTimeout": "2004-11-02T11:22:45.2724513+01:00",
  "Deadline": "2001-08-12T11:22:45.2724513+02:00",
  "CreatedBy": null,
  "Author": "maxime",
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
      "PersonId": 190,
      "Mrmrs": "omnis",
      "Firstname": "Kendall",
      "Lastname": "Hessel",
      "MiddleName": "Shields, Wyman and Wilderman",
      "Title": "doloremque",
      "Description": "Innovative systematic complexity",
      "Email": "brandt_schuppe@wilkinsonspencer.name",
      "FullName": "Elise Yundt",
      "DirectPhone": "(025)629-6781 x091",
      "FormalName": "Altenwerth, Torp and Schaefer",
      "CountryId": 957,
      "ContactId": 877,
      "ContactName": "Hagenes, Bechtelar and Mosciski",
      "Retired": 441,
      "Rank": 662,
      "ActiveInterests": 653,
      "ContactDepartment": "",
      "ContactCountryId": 903,
      "ContactOrgNr": "1144464",
      "FaxPhone": "1-120-630-2279",
      "MobilePhone": "293-905-7684",
      "ContactPhone": "(216)325-8692 x9999",
      "AssociateName": "Kuhlman-Parker",
      "AssociateId": 873,
      "UsePersonAddress": false,
      "ContactFax": "reiciendis",
      "Kanafname": "nesciunt",
      "Kanalname": "fugit",
      "Post1": "totam",
      "Post2": "et",
      "Post3": "et",
      "EmailName": "hermann@schroeder.info",
      "ContactFullName": "Prof. Uriel Omer Wintheiser",
      "ActiveErpLinks": 639,
      "TicketPriorityId": 722,
      "SupportLanguageId": 733,
      "SupportAssociateId": 599,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 968,
  "ConnectId": 469,
  "ReadStatus": "Green",
  "TimeToReply": 319,
  "RealTimeToReply": 433,
  "TimeToClose": 81,
  "RealTimeToClose": 11,
  "TimeSpentInternally": 86,
  "TimeSpentExternally": 649,
  "TimeSpentQueue": 110,
  "RealTimeSpentInternally": 255,
  "RealTimeSpentExternally": 840,
  "RealTimeSpentQueue": 763,
  "HasAttachment": true,
  "NumReplies": 169,
  "NumMessages": 363,
  "FromAddress": "ex",
  "Messages": [
    {
      "TicketMessageId": 592,
      "CreatedAt": "2006-05-17T11:22:45.2724513+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "omnis",
      "PersonId": 326,
      "PersonFullName": "Aniyah Immanuel Beer PhD",
      "ContactId": 801,
      "ContactName": "Mante-Goyette",
      "ContactDepartment": "",
      "NumAttachments": 972,
      "EmailHeader": "jaren.mayer@lehnershields.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "omnis",
      "Sentiment": 379,
      "SentimentConfidence": 36,
      "CreatedBy": 477,
      "ChangedAt": "2018-01-12T11:22:45.2724513+01:00"
    }
  ],
  "Tags": [
    {
      "Id": 742,
      "Name": "Marquardt, VonRueden and Towne",
      "ToolTip": "Optio occaecati."
    },
    {
      "Id": 742,
      "Name": "Marquardt, VonRueden and Towne",
      "ToolTip": "Optio occaecati."
    }
  ],
  "Language": "est",
  "Sentiment": 380,
  "SentimentConfidence": 506,
  "SuggestedCategoryId": 470,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 870,
  "IconHint": "voluptas",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "temporibus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 229,
  "Title": "et",
  "CreatedAt": "2008-04-25T11:22:45.2880735+02:00",
  "LastChanged": "1996-05-02T11:22:45.2880735+02:00",
  "ReadByOwner": "2019-07-08T11:22:45.2880735+02:00",
  "ReadByCustomer": "2001-01-05T11:22:45.2880735+01:00",
  "FirstReadByOwner": "1998-09-02T11:22:45.2880735+02:00",
  "FirstReadByUser": "2003-10-21T11:22:45.2880735+02:00",
  "Activate": "2021-02-21T11:22:45.2880735+01:00",
  "ClosedAt": "2022-03-16T11:22:45.2880735+01:00",
  "RepliedAt": "2019-02-09T11:22:45.2880735+01:00",
  "AlertTimeout": "1995-12-14T11:22:45.2880735+01:00",
  "Deadline": "2008-11-23T11:22:45.2880735+01:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "error",
      "PersonId": 16,
      "Mrmrs": "ut",
      "Firstname": "Kaylee",
      "Lastname": "Ortiz",
      "MiddleName": "Boyle, Barton and Brakus",
      "Title": "similique",
      "Description": "Multi-lateral logistical customer loyalty",
      "Email": "davon.oberbrunner@conroy.info",
      "FullName": "Helmer Stroman",
      "DirectPhone": "1-515-873-6631 x09773",
      "FormalName": "Bernier, Roob and Ankunding",
      "CountryId": 802,
      "ContactId": 872,
      "ContactName": "Heidenreich Inc and Sons",
      "Retired": 930,
      "Rank": 44,
      "ActiveInterests": 350,
      "ContactDepartment": "",
      "ContactCountryId": 213,
      "ContactOrgNr": "1445786",
      "FaxPhone": "1-863-352-4296 x8137",
      "MobilePhone": "1-675-720-0066 x223",
      "ContactPhone": "1-333-378-0683",
      "AssociateName": "Baumbach-Vandervort",
      "AssociateId": 87,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "voluptas",
      "Kanalname": "ea",
      "Post1": "et",
      "Post2": "quis",
      "Post3": "ut",
      "EmailName": "donato.fisher@durgan.com",
      "ContactFullName": "Taylor Pierre Braun Jr.",
      "ActiveErpLinks": 1002,
      "TicketPriorityId": 555,
      "SupportLanguageId": 451,
      "SupportAssociateId": 31,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 371
        }
      }
    }
  ],
  "AlertLevel": 158,
  "ConnectId": 9,
  "ReadStatus": "Green",
  "TimeToReply": 632,
  "RealTimeToReply": 836,
  "TimeToClose": 964,
  "RealTimeToClose": 167,
  "TimeSpentInternally": 991,
  "TimeSpentExternally": 958,
  "TimeSpentQueue": 673,
  "RealTimeSpentInternally": 395,
  "RealTimeSpentExternally": 591,
  "RealTimeSpentQueue": 695,
  "HasAttachment": false,
  "NumReplies": 735,
  "NumMessages": 470,
  "FromAddress": "consectetur",
  "Messages": [
    {
      "TicketMessageId": 631,
      "CreatedAt": "2005-05-10T11:22:45.2880735+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 612,
      "PersonFullName": "Dr. Yadira Roberto Considine V",
      "ContactId": 897,
      "ContactName": "Emmerich-Borer",
      "ContactDepartment": "",
      "NumAttachments": 579,
      "EmailHeader": "jordon_lakin@wyman.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 197,
      "SentimentConfidence": 657,
      "CreatedBy": 577,
      "ChangedAt": "1997-07-10T11:22:45.2880735+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 418,
      "Name": "Wunsch, Denesik and Rolfson",
      "ToolTip": "Dolores quia voluptatibus ratione vel expedita vero.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    },
    {
      "Id": 418,
      "Name": "Wunsch, Denesik and Rolfson",
      "ToolTip": "Dolores quia voluptatibus ratione vel expedita vero.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "Language": "numquam",
  "Sentiment": 376,
  "SentimentConfidence": 741,
  "SuggestedCategoryId": 281,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 75,
  "IconHint": "natus",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "ex"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 841
    }
  }
}
```