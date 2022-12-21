---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 841,
  "Title": "officiis",
  "CreatedAt": "2022-06-10T02:49:45.4684728+02:00",
  "LastChanged": "1997-06-07T02:49:45.4684728+02:00",
  "ReadByOwner": "2003-08-28T02:49:45.4684728+02:00",
  "ReadByCustomer": "2004-11-06T02:49:45.4684728+01:00",
  "FirstReadByOwner": "2018-12-03T02:49:45.4684728+01:00",
  "FirstReadByUser": "2007-08-23T02:49:45.4684728+02:00",
  "Activate": "1997-12-10T02:49:45.4684728+01:00",
  "ClosedAt": "1999-07-12T02:49:45.4684728+02:00",
  "RepliedAt": "2021-04-30T02:49:45.4684728+02:00",
  "AlertTimeout": "2008-09-01T02:49:45.4684728+02:00",
  "Deadline": "2010-07-23T02:49:45.4684728+02:00",
  "CreatedBy": null,
  "Author": "consectetur",
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
      "PersonId": 588,
      "Mrmrs": "beatae",
      "Firstname": "Arianna",
      "Lastname": "Wintheiser",
      "MiddleName": "Blick, Oberbrunner and Pfeffer",
      "Title": "nihil",
      "Description": "Automated eco-centric artificial intelligence",
      "Email": "laverne@block.name",
      "FullName": "Ms. Lue Crona DVM",
      "DirectPhone": "(123)974-9945 x568",
      "FormalName": "Rodriguez LLC",
      "CountryId": 97,
      "ContactId": 120,
      "ContactName": "O'Conner LLC",
      "Retired": 815,
      "Rank": 859,
      "ActiveInterests": 326,
      "ContactDepartment": "",
      "ContactCountryId": 68,
      "ContactOrgNr": "673205",
      "FaxPhone": "863.218.8651 x96301",
      "MobilePhone": "950.178.8326 x389",
      "ContactPhone": "046.882.3859",
      "AssociateName": "Doyle LLC",
      "AssociateId": 154,
      "UsePersonAddress": false,
      "ContactFax": "cum",
      "Kanafname": "qui",
      "Kanalname": "amet",
      "Post1": "est",
      "Post2": "qui",
      "Post3": "aut",
      "EmailName": "jay.heaney@dare.co.uk",
      "ContactFullName": "Prof. Jasmin Wisozk",
      "ActiveErpLinks": 645,
      "TicketPriorityId": 977,
      "SupportLanguageId": 1002,
      "SupportAssociateId": 222,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 758,
  "ConnectId": 465,
  "ReadStatus": "Green",
  "TimeToReply": 641,
  "RealTimeToReply": 519,
  "TimeToClose": 40,
  "RealTimeToClose": 55,
  "TimeSpentInternally": 929,
  "TimeSpentExternally": 360,
  "TimeSpentQueue": 152,
  "RealTimeSpentInternally": 98,
  "RealTimeSpentExternally": 538,
  "RealTimeSpentQueue": 31,
  "HasAttachment": false,
  "NumReplies": 100,
  "NumMessages": 126,
  "FromAddress": "itaque",
  "Messages": [
    {
      "TicketMessageId": 458,
      "CreatedAt": "2014-11-02T02:49:45.4684728+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eligendi",
      "PersonId": 334,
      "PersonFullName": "Lamont Cremin",
      "ContactId": 896,
      "ContactName": "Boehm, Lynch and Grimes",
      "ContactDepartment": "cultivate virtual relationships",
      "NumAttachments": 392,
      "EmailHeader": "thalia_gerlach@zboncak.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "occaecati",
      "Sentiment": 208,
      "SentimentConfidence": 13,
      "CreatedBy": 406,
      "ChangedAt": "2000-07-21T02:49:45.4684728+02:00"
    }
  ],
  "Tags": [
    {
      "Id": 470,
      "Name": "Adams Group",
      "ToolTip": "Illum ex ad id."
    },
    {
      "Id": 470,
      "Name": "Adams Group",
      "ToolTip": "Illum ex ad id."
    }
  ],
  "Language": "non",
  "Sentiment": 790,
  "SentimentConfidence": 179,
  "SuggestedCategoryId": 843,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 784,
  "IconHint": "unde",
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "voluptates"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 528,
  "Title": "est",
  "CreatedAt": "2016-01-21T02:49:45.4684728+01:00",
  "LastChanged": "2014-06-30T02:49:45.4684728+02:00",
  "ReadByOwner": "1998-03-06T02:49:45.4684728+01:00",
  "ReadByCustomer": "1998-04-21T02:49:45.4684728+02:00",
  "FirstReadByOwner": "1997-07-28T02:49:45.4684728+02:00",
  "FirstReadByUser": "2005-04-11T02:49:45.4684728+02:00",
  "Activate": "2015-01-13T02:49:45.4684728+01:00",
  "ClosedAt": "2000-10-13T02:49:45.4684728+02:00",
  "RepliedAt": "2006-11-02T02:49:45.4684728+01:00",
  "AlertTimeout": "2007-07-30T02:49:45.4684728+02:00",
  "Deadline": "2019-08-02T02:49:45.4684728+02:00",
  "CreatedBy": null,
  "Author": "totam",
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
      "PersonId": 436,
      "Mrmrs": "velit",
      "Firstname": "Faye",
      "Lastname": "Bauch",
      "MiddleName": "Deckow Group",
      "Title": "molestiae",
      "Description": "Cloned responsive challenge",
      "Email": "jaida@spinka.info",
      "FullName": "Delpha Cummerata",
      "DirectPhone": "1-631-416-0757 x34897",
      "FormalName": "Lowe Inc and Sons",
      "CountryId": 567,
      "ContactId": 557,
      "ContactName": "Considine LLC",
      "Retired": 106,
      "Rank": 482,
      "ActiveInterests": 146,
      "ContactDepartment": "",
      "ContactCountryId": 170,
      "ContactOrgNr": "412266",
      "FaxPhone": "1-564-908-5423 x2969",
      "MobilePhone": "693.379.9388 x86980",
      "ContactPhone": "962-631-0297 x246",
      "AssociateName": "Hudson-Mosciski",
      "AssociateId": 843,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "ratione",
      "Kanalname": "cupiditate",
      "Post1": "aut",
      "Post2": "aliquam",
      "Post3": "incidunt",
      "EmailName": "ebba@sanfordtromp.biz",
      "ContactFullName": "Marty Will",
      "ActiveErpLinks": 217,
      "TicketPriorityId": 978,
      "SupportLanguageId": 155,
      "SupportAssociateId": 41,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    }
  ],
  "AlertLevel": 623,
  "ConnectId": 272,
  "ReadStatus": "Green",
  "TimeToReply": 790,
  "RealTimeToReply": 856,
  "TimeToClose": 213,
  "RealTimeToClose": 861,
  "TimeSpentInternally": 808,
  "TimeSpentExternally": 757,
  "TimeSpentQueue": 832,
  "RealTimeSpentInternally": 711,
  "RealTimeSpentExternally": 200,
  "RealTimeSpentQueue": 457,
  "HasAttachment": false,
  "NumReplies": 87,
  "NumMessages": 369,
  "FromAddress": "vel",
  "Messages": [
    {
      "TicketMessageId": 330,
      "CreatedAt": "2003-12-02T02:49:45.4840951+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "voluptate",
      "PersonId": 207,
      "PersonFullName": "Zachary Schmidt",
      "ContactId": 923,
      "ContactName": "Beatty-Zemlak",
      "ContactDepartment": "",
      "NumAttachments": 821,
      "EmailHeader": "quincy_dare@ondricka.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "non",
      "Sentiment": 191,
      "SentimentConfidence": 391,
      "CreatedBy": 499,
      "ChangedAt": "2001-01-20T02:49:45.4840951+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 531,
      "Name": "Waelchi-Johnson",
      "ToolTip": "Dicta ut laboriosam sunt consequatur optio sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Id": 531,
      "Name": "Waelchi-Johnson",
      "ToolTip": "Dicta ut laboriosam sunt consequatur optio sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Language": "beatae",
  "Sentiment": 626,
  "SentimentConfidence": 539,
  "SuggestedCategoryId": 819,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 420,
  "IconHint": "fuga",
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 964
    }
  }
}
```