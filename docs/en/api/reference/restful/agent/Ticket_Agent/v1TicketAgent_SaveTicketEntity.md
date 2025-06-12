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
  "TicketId": 784,
  "Title": "vitae",
  "CreatedAt": "2003-07-07T17:54:03.7264456+02:00",
  "LastChanged": "2019-07-15T17:54:03.7264456+02:00",
  "ReadByOwner": "2007-04-25T17:54:03.7264456+02:00",
  "ReadByCustomer": "2007-07-23T17:54:03.7264456+02:00",
  "FirstReadByOwner": "2003-01-19T17:54:03.7264456+01:00",
  "FirstReadByUser": "2007-07-29T17:54:03.7264456+02:00",
  "Activate": "2023-07-18T17:54:03.7264456+02:00",
  "ClosedAt": "2017-12-21T17:54:03.7264456+01:00",
  "RepliedAt": "2009-06-12T17:54:03.7264456+02:00",
  "AlertTimeout": "2020-09-19T17:54:03.7264456+02:00",
  "Deadline": "2015-11-06T17:54:03.7264456+01:00",
  "CreatedBy": null,
  "Author": "atque",
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
      "Position": "deserunt",
      "PersonId": 608,
      "Mrmrs": "eligendi",
      "Firstname": "Lila",
      "Lastname": "Thompson",
      "MiddleName": "Borer, Windler and Runolfsdottir",
      "Title": "laudantium",
      "Description": "Operative dedicated solution",
      "Email": "rodrigo@caspertremblay.co.uk",
      "FullName": "Dr. Jannie Prosacco DVM",
      "DirectPhone": "(332)659-2760 x3516",
      "FormalName": "Conn-Collier",
      "CountryId": 10,
      "ContactId": 770,
      "ContactName": "Casper Group",
      "Retired": 460,
      "Rank": 716,
      "ActiveInterests": 650,
      "ContactDepartment": "",
      "ContactCountryId": 69,
      "ContactOrgNr": "1740809",
      "FaxPhone": "727.556.9935 x4236",
      "MobilePhone": "649-382-3215 x303",
      "ContactPhone": "(527)598-8128 x04843",
      "AssociateName": "Bradtke Group",
      "AssociateId": 468,
      "UsePersonAddress": false,
      "ContactFax": "blanditiis",
      "Kanafname": "non",
      "Kanalname": "consequatur",
      "Post1": "sed",
      "Post2": "adipisci",
      "Post3": "et",
      "EmailName": "lavonne@roberts.ca",
      "ContactFullName": "Elinor Kaci Nolan I",
      "ActiveErpLinks": 216,
      "TicketPriorityId": 932,
      "SupportLanguageId": 809,
      "SupportAssociateId": 848,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1591601"
    }
  ],
  "AlertLevel": 782,
  "ConnectId": 420,
  "ReadStatus": "Green",
  "TimeToReply": 257,
  "RealTimeToReply": 331,
  "TimeToClose": 579,
  "RealTimeToClose": 141,
  "TimeSpentInternally": 188,
  "TimeSpentExternally": 263,
  "TimeSpentQueue": 737,
  "RealTimeSpentInternally": 550,
  "RealTimeSpentExternally": 42,
  "RealTimeSpentQueue": 13,
  "TimeSpent": 698,
  "HasAttachment": false,
  "NumReplies": 820,
  "NumMessages": 293,
  "FromAddress": "reprehenderit",
  "Messages": [
    {
      "TicketMessageId": 385,
      "CreatedAt": "2016-04-14T17:54:03.7420683+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 105,
      "PersonFullName": "Kiana Reynolds",
      "ContactId": 697,
      "ContactName": "Robel, Kilback and Bradtke",
      "ContactDepartment": "",
      "NumAttachments": 870,
      "EmailHeader": "caleb@bartolettinikolaus.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "minima",
      "Sentiment": 810,
      "SentimentConfidence": 25,
      "CreatedBy": 282,
      "ChangedAt": "2009-04-07T17:54:03.7420683+02:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 250,
      "Name": "Dibbert LLC",
      "ToolTip": "Architecto aut placeat consequuntur aut."
    },
    {
      "Id": 250,
      "Name": "Dibbert LLC",
      "ToolTip": "Architecto aut placeat consequuntur aut."
    }
  ],
  "Language": "architecto",
  "Sentiment": 453,
  "SentimentConfidence": 701,
  "SuggestedCategoryId": 983,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 877,
  "IconHint": "et",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 989,
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "quisquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 80,
  "Title": "est",
  "CreatedAt": "2008-03-06T17:54:03.7420683+01:00",
  "LastChanged": "2024-05-05T17:54:03.7420683+02:00",
  "ReadByOwner": "2014-04-05T17:54:03.7420683+02:00",
  "ReadByCustomer": "2015-01-14T17:54:03.7420683+01:00",
  "FirstReadByOwner": "2002-05-16T17:54:03.7420683+02:00",
  "FirstReadByUser": "2001-06-20T17:54:03.7420683+02:00",
  "Activate": "2011-10-02T17:54:03.7420683+02:00",
  "ClosedAt": "2001-10-20T17:54:03.7420683+02:00",
  "RepliedAt": "2007-03-02T17:54:03.7420683+01:00",
  "AlertTimeout": "2005-05-16T17:54:03.7420683+02:00",
  "Deadline": "2012-09-26T17:54:03.7420683+02:00",
  "CreatedBy": null,
  "Author": "reiciendis",
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
      "Position": "repellendus",
      "PersonId": 697,
      "Mrmrs": "ut",
      "Firstname": "Stephanie",
      "Lastname": "Predovic",
      "MiddleName": "Simonis LLC",
      "Title": "exercitationem",
      "Description": "Reverse-engineered bottom-line contingency",
      "Email": "esta@baileyharber.us",
      "FullName": "Lela Deckow",
      "DirectPhone": "(627)517-3381",
      "FormalName": "Hackett-Krajcik",
      "CountryId": 805,
      "ContactId": 743,
      "ContactName": "Homenick, Ernser and Sporer",
      "Retired": 730,
      "Rank": 735,
      "ActiveInterests": 900,
      "ContactDepartment": "",
      "ContactCountryId": 980,
      "ContactOrgNr": "535286",
      "FaxPhone": "1-286-965-8023",
      "MobilePhone": "1-625-320-5521 x07217",
      "ContactPhone": "1-753-074-2851",
      "AssociateName": "Crist-Gerhold",
      "AssociateId": 353,
      "UsePersonAddress": false,
      "ContactFax": "pariatur",
      "Kanafname": "illum",
      "Kanalname": "rerum",
      "Post1": "veritatis",
      "Post2": "illum",
      "Post3": "quis",
      "EmailName": "piper.welch@heidenreich.info",
      "ContactFullName": "Taya Gorczany",
      "ActiveErpLinks": 504,
      "TicketPriorityId": 338,
      "SupportLanguageId": 681,
      "SupportAssociateId": 947,
      "CategoryName": "VIP Customer",
      "PersonNumber": "499784",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    }
  ],
  "AlertLevel": 646,
  "ConnectId": 338,
  "ReadStatus": "Green",
  "TimeToReply": 164,
  "RealTimeToReply": 573,
  "TimeToClose": 245,
  "RealTimeToClose": 631,
  "TimeSpentInternally": 970,
  "TimeSpentExternally": 86,
  "TimeSpentQueue": 739,
  "RealTimeSpentInternally": 80,
  "RealTimeSpentExternally": 464,
  "RealTimeSpentQueue": 26,
  "TimeSpent": 639,
  "HasAttachment": true,
  "NumReplies": 207,
  "NumMessages": 22,
  "FromAddress": "corrupti",
  "Messages": [
    {
      "TicketMessageId": 52,
      "CreatedAt": "2005-04-07T17:54:03.7420683+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "aut",
      "PersonId": 68,
      "PersonFullName": "Ethyl McClure",
      "ContactId": 557,
      "ContactName": "Rowe-Funk",
      "ContactDepartment": "",
      "NumAttachments": 465,
      "EmailHeader": "dandre@luettgenschmidt.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "commodi",
      "Sentiment": 175,
      "SentimentConfidence": 450,
      "CreatedBy": 295,
      "ChangedAt": "2000-03-09T17:54:03.7420683+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 97
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 230,
      "Name": "Hyatt, Lakin and Thompson",
      "ToolTip": "Ducimus incidunt ea facilis debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    },
    {
      "Id": 230,
      "Name": "Hyatt, Lakin and Thompson",
      "ToolTip": "Ducimus incidunt ea facilis debitis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 115,
  "SentimentConfidence": 735,
  "SuggestedCategoryId": 393,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 83,
  "IconHint": "magni",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 555,
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 3
    }
  }
}
```