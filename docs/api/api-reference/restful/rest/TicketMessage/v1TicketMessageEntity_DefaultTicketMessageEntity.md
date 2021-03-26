---
title: GET TicketMessage/default
id: v1TicketMessageEntity_DefaultTicketMessageEntity
---

# GET TicketMessage/default

```http
GET /api/v1/TicketMessage/default
```

Set default values into a new TicketMessageEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketMessageEntity.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request).



Carrier object for TicketMessageEntity.
Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjMessageId | int32 | The primary key (auto-incremented) |
| Ticket |  | The connected ticket |
| CreatedAt | date-time | When the message was posted. |
| CreatedBy |  | The associate who created this ticket message |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| Slevel | string | The securitylevel of the message. |
| Type | string | The type of the message (plaintext/html). |
| MessageId | string | The X-Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets. |
| TimeSpent | int32 | The time spent (minutes) for this message. |
| Body | string | The textbody for the message. |
| HtmlBody | string | The html body for the message (if any). |
| EmailHeader | string | The email header is saved in this field as raw text |
| DebugInfo | string | The debug info for the message. |
| MailSorter | string | The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&amp;apos;s change every time one changes the mail sorter. :-0 |
| MessageCategory | string | Defines what kind of message this is. |
| Person |  | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/TicketMessage/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 587,
  "Ticket": {
    "TicketId": 120,
    "Title": "odio",
    "CreatedAt": "2013-04-11T09:40:59.8650649+02:00",
    "LastChanged": "1996-03-08T09:40:59.8650649+01:00",
    "ReadByOwner": "2013-08-15T09:40:59.8650649+02:00",
    "ReadByCustomer": "2003-07-23T09:40:59.8650649+02:00",
    "FirstReadByUser": "2000-05-15T09:40:59.8650649+02:00",
    "Activate": "2012-10-09T09:40:59.8650649+02:00",
    "ClosedAt": "2013-01-24T09:40:59.8650649+01:00",
    "RepliedAt": "2000-11-12T09:40:59.8650649+01:00",
    "AlertTimeout": "2003-07-05T09:40:59.8650649+02:00",
    "Deadline": "1994-12-16T09:40:59.8650649+01:00",
    "CreatedBy": 779,
    "CreatedByName": "Blanda-Mann",
    "Author": "temporibus",
    "OwnedBy": 328,
    "OwnedByName": "Langosh-Nicolas",
    "Category": 353,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 597,
    "BaseStatus": "Active",
    "TicketStatus": 624,
    "Origin": "AutoGenerated",
    "CustId": 214,
    "CustFirstname": "Gerardo",
    "CustMiddleName": "Thiel-Cremin",
    "CustLastname": "O'Keefe",
    "AlertLevel": 625,
    "ConnectId": 454,
    "ReadStatus": "Green",
    "TimeToReply": 434,
    "RealTimeToReply": 623,
    "TimeToClose": 918,
    "RealTimeToClose": 155,
    "TimeSpentInternally": 351,
    "TimeSpentExternally": 782,
    "TimeSpentQueue": 101,
    "RealTimeSpentInternally": 217,
    "RealTimeSpentExternally": 140,
    "RealTimeSpentQueue": 899,
    "HasAttachment": true,
    "NumReplies": 224,
    "NumMessages": 710,
    "FromAddress": "distinctio",
    "CustFullname": "adipisci",
    "TicketStatusDisplayValue": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 922
      }
    }
  },
  "CreatedAt": "2020-08-05T09:40:59.8650649+02:00",
  "CreatedBy": {
    "AssociateId": 758,
    "Name": "Volkman Inc and Sons",
    "PersonId": 771,
    "Rank": 807,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 309,
    "FullName": "Caterina Jast I",
    "FormalName": "Steuber Inc and Sons",
    "Deleted": true,
    "EjUserId": 458,
    "UserName": "Frami-Sawayn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 34
      }
    }
  },
  "Author": "ab",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "fugit",
  "TimeSpent": 703,
  "Body": "qui",
  "HtmlBody": "et",
  "EmailHeader": "isabella.rutherford@millerjacobs.ca",
  "DebugInfo": "iusto",
  "MailSorter": "odio",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "eaque",
    "PersonId": 865,
    "Mrmrs": "omnis",
    "Firstname": "Wayne",
    "Lastname": "McLaughlin",
    "MiddleName": "Hackett-Rippin",
    "Title": "architecto",
    "Description": "Team-oriented demand-driven artificial intelligence",
    "Email": "jamey@spencervandervort.name",
    "FullName": "Khalil Casper",
    "DirectPhone": "(810)835-0544 x1221",
    "FormalName": "Olson-Lakin",
    "CountryId": 597,
    "ContactId": 711,
    "ContactName": "Prohaska-Koepp",
    "Retired": 344,
    "Rank": 298,
    "ActiveInterests": 453,
    "ContactDepartment": "",
    "ContactCountryId": 922,
    "ContactOrgNr": "645873",
    "FaxPhone": "446-677-4381 x7436",
    "MobilePhone": "1-723-324-6758 x37743",
    "ContactPhone": "(708)064-4251 x1655",
    "AssociateName": "Brekke LLC",
    "AssociateId": 359,
    "UsePersonAddress": false,
    "ContactFax": "occaecati",
    "Kanafname": "minima",
    "Kanalname": "id",
    "Post1": "aut",
    "Post2": "dignissimos",
    "Post3": "soluta",
    "EmailName": "katrine.wilkinson@kochpfannerstill.com",
    "ContactFullName": "Noemie Crooks",
    "ActiveErpLinks": 788,
    "TicketPriorityId": 79,
    "SupportLanguageId": 358,
    "SupportAssociateId": 74,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 327
      }
    }
  },
  "SearchTitle": "ducimus",
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "consectetur"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "explicabo"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 258
    }
  }
}
```