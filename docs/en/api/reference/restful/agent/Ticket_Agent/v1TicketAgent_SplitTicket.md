---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
generated: true
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

## Request Body: request 

SourceTicketEntityId, SourceTicketEntityStatusId, SourceTicketEntityActivate, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| SourceTicketEntityStatusId | Integer |  |
| SourceTicketEntityActivate | String |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 956,
  "SourceTicketEntityStatusId": 204,
  "SourceTicketEntityActivate": "2023-02-25T13:13:24.3215767+01:00",
  "TransferMessageIds": [
    901,
    930
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 26,
  "Title": "vitae",
  "CreatedAt": "2011-02-20T13:13:24.3215767+01:00",
  "LastChanged": "2011-02-24T13:13:24.3215767+01:00",
  "ReadByOwner": "2023-02-03T13:13:24.3215767+01:00",
  "ReadByCustomer": "2009-08-31T13:13:24.3215767+02:00",
  "FirstReadByOwner": "2015-05-18T13:13:24.3215767+02:00",
  "FirstReadByUser": "2002-09-24T13:13:24.3215767+02:00",
  "Activate": "2004-07-14T13:13:24.3215767+02:00",
  "ClosedAt": "2003-08-14T13:13:24.3215767+02:00",
  "RepliedAt": "2007-06-23T13:13:24.3215767+02:00",
  "AlertTimeout": "2023-07-30T13:13:24.3215767+02:00",
  "Deadline": "2018-11-17T13:13:24.3215767+01:00",
  "CreatedBy": null,
  "Author": "fugiat",
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
      "Position": "non",
      "PersonId": 800,
      "Mrmrs": "voluptatibus",
      "Firstname": "Conrad",
      "Lastname": "Ryan",
      "MiddleName": "Schroeder Group",
      "Title": "consequuntur",
      "Description": "Organized reciprocal service-desk",
      "Email": "jo_feest@hamillauer.biz",
      "FullName": "Prof. Jessie Cathrine Cormier V",
      "DirectPhone": "1-312-319-4014",
      "FormalName": "Christiansen Inc and Sons",
      "CountryId": 592,
      "ContactId": 438,
      "ContactName": "Hane, Muller and Gerhold",
      "Retired": 265,
      "Rank": 36,
      "ActiveInterests": 475,
      "ContactDepartment": "",
      "ContactCountryId": 379,
      "ContactOrgNr": "624482",
      "FaxPhone": "883-550-7216 x7339",
      "MobilePhone": "(355)788-8981",
      "ContactPhone": "(570)613-9898",
      "AssociateName": "Donnelly, Kuhic and Krajcik",
      "AssociateId": 301,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "alias",
      "Kanalname": "laboriosam",
      "Post1": "nemo",
      "Post2": "cum",
      "Post3": "et",
      "EmailName": "concepcion.koelpin@satterfield.co.uk",
      "ContactFullName": "Magdalen Parker IV",
      "ActiveErpLinks": 731,
      "TicketPriorityId": 741,
      "SupportLanguageId": 916,
      "SupportAssociateId": 306,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    }
  ],
  "AlertLevel": 330,
  "ConnectId": 195,
  "ReadStatus": "Green",
  "TimeToReply": 958,
  "RealTimeToReply": 693,
  "TimeToClose": 407,
  "RealTimeToClose": 982,
  "TimeSpentInternally": 965,
  "TimeSpentExternally": 796,
  "TimeSpentQueue": 173,
  "RealTimeSpentInternally": 211,
  "RealTimeSpentExternally": 285,
  "RealTimeSpentQueue": 215,
  "TimeSpent": 769,
  "HasAttachment": false,
  "NumReplies": 692,
  "NumMessages": 350,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 819,
      "CreatedAt": "2004-02-22T13:13:24.3372006+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "nostrum",
      "PersonId": 226,
      "PersonFullName": "Imelda Lexie Connelly Jr.",
      "ContactId": 354,
      "ContactName": "Weissnat, Ruecker and Grant",
      "ContactDepartment": "",
      "NumAttachments": 566,
      "EmailHeader": "gene_schneider@schmeler.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "laborum",
      "Sentiment": 322,
      "SentimentConfidence": 214,
      "CreatedBy": 738,
      "ChangedAt": "2012-03-27T13:13:24.3372006+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 491,
      "Name": "Gulgowski, Heidenreich and Steuber",
      "ToolTip": "Et nobis similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    },
    {
      "Id": 491,
      "Name": "Gulgowski, Heidenreich and Steuber",
      "ToolTip": "Et nobis similique.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    }
  ],
  "Language": "est",
  "Sentiment": 957,
  "SentimentConfidence": 372,
  "SuggestedCategoryId": 435,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 773,
  "IconHint": "illo",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 422,
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 740
    }
  }
}
```