---
title: POST Agents/Ticket/CreateDefaultTicketMessageEntity
id: v1TicketAgent_CreateDefaultTicketMessageEntity
---

# POST Agents/Ticket/CreateDefaultTicketMessageEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultTicketMessageEntity
```

Set default values into a new TicketMessageEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Ticket/CreateDefaultTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 171,
  "Ticket": {
    "TicketId": 303,
    "Title": "quaerat",
    "CreatedAt": "2014-10-26T16:48:30.7929356+01:00",
    "LastChanged": "2006-01-10T16:48:30.7929356+01:00",
    "ReadByOwner": "2007-05-17T16:48:30.7929356+02:00",
    "ReadByCustomer": "2007-10-15T16:48:30.7929356+02:00",
    "FirstReadByUser": "2002-12-17T16:48:30.7929356+01:00",
    "Activate": "2015-10-08T16:48:30.7929356+02:00",
    "ClosedAt": "1994-11-29T16:48:30.7929356+01:00",
    "RepliedAt": "1998-04-04T16:48:30.7929356+02:00",
    "AlertTimeout": "2006-11-20T16:48:30.7929356+01:00",
    "Deadline": "2006-12-10T16:48:30.7929356+01:00",
    "CreatedBy": 596,
    "CreatedByName": "Abshire, Cronin and Predovic",
    "Author": "ipsam",
    "OwnedBy": 318,
    "OwnedByName": "Goodwin-Gaylord",
    "Category": 765,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 353,
    "BaseStatus": "Active",
    "TicketStatus": 884,
    "Origin": "AutoGenerated",
    "CustId": 328,
    "CustFirstname": "Brody",
    "CustMiddleName": "Schinner Inc and Sons",
    "CustLastname": "Hackett",
    "AlertLevel": 935,
    "ConnectId": 674,
    "ReadStatus": "Green",
    "TimeToReply": 154,
    "RealTimeToReply": 704,
    "TimeToClose": 598,
    "RealTimeToClose": 554,
    "TimeSpentInternally": 481,
    "TimeSpentExternally": 193,
    "TimeSpentQueue": 848,
    "RealTimeSpentInternally": 608,
    "RealTimeSpentExternally": 152,
    "RealTimeSpentQueue": 974,
    "HasAttachment": false,
    "NumReplies": 363,
    "NumMessages": 248,
    "FromAddress": "cum",
    "CustFullname": "et",
    "TicketStatusDisplayValue": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 402
      }
    }
  },
  "CreatedAt": "1999-09-27T16:48:30.7929356+02:00",
  "CreatedBy": {
    "AssociateId": 430,
    "Name": "Price-Flatley",
    "PersonId": 726,
    "Rank": 425,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 685,
    "FullName": "Leora Reichel",
    "FormalName": "Schinner, Bergnaum and Von",
    "Deleted": true,
    "EjUserId": 202,
    "UserName": "Beahan LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 946
      }
    }
  },
  "Author": "quam",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "repellat",
  "TimeSpent": 304,
  "Body": "quia",
  "HtmlBody": "quos",
  "EmailHeader": "shannon_kreiger@swift.co.uk",
  "DebugInfo": "veritatis",
  "MailSorter": "itaque",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "tenetur",
    "PersonId": 283,
    "Mrmrs": "sit",
    "Firstname": "Kayla",
    "Lastname": "Casper",
    "MiddleName": "Sauer-Crona",
    "Title": "qui",
    "Description": "Face to face fault-tolerant process improvement",
    "Email": "sylvan@wiegand.us",
    "FullName": "Loyal Grady",
    "DirectPhone": "1-474-712-8570 x000",
    "FormalName": "Hilll Group",
    "CountryId": 102,
    "ContactId": 571,
    "ContactName": "Mraz-McKenzie",
    "Retired": 178,
    "Rank": 30,
    "ActiveInterests": 754,
    "ContactDepartment": "",
    "ContactCountryId": 345,
    "ContactOrgNr": "509263",
    "FaxPhone": "145-440-3088",
    "MobilePhone": "1-155-627-5513 x2825",
    "ContactPhone": "1-367-571-5365 x35520",
    "AssociateName": "Cole, Morar and Okuneva",
    "AssociateId": 469,
    "UsePersonAddress": false,
    "ContactFax": "corporis",
    "Kanafname": "iure",
    "Kanalname": "atque",
    "Post1": "rerum",
    "Post2": "culpa",
    "Post3": "autem",
    "EmailName": "maxime_haag@boylemaggio.ca",
    "ContactFullName": "Stewart Cruickshank DVM",
    "ActiveErpLinks": 220,
    "TicketPriorityId": 994,
    "SupportLanguageId": 410,
    "SupportAssociateId": 184,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower front-end channels"
        },
        "FieldType": "System.String",
        "FieldLength": 741
      }
    }
  },
  "SearchTitle": "voluptas",
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "delectus"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "mesh killer architectures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 939
    }
  }
}
```