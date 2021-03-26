---
title: POST Agents/Ticket/SaveTicketMessageEntity
id: v1TicketAgent_SaveTicketMessageEntity
---

# POST Agents/Ticket/SaveTicketMessageEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
```

Updates the existing TicketMessageEntity or creates a new TicketMessageEntity if the id parameter is empty








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

The TicketMessageEntity to be saved. 

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
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 720,
  "Ticket": {
    "TicketId": 698,
    "Title": "omnis",
    "CreatedAt": "2016-07-25T16:48:30.7959345+02:00",
    "LastChanged": "2001-01-30T16:48:30.7959345+01:00",
    "ReadByOwner": "2019-03-15T16:48:30.7959345+01:00",
    "ReadByCustomer": "1994-06-14T16:48:30.7959345+02:00",
    "FirstReadByUser": "2010-04-29T16:48:30.7959345+02:00",
    "Activate": "2000-02-04T16:48:30.7959345+01:00",
    "ClosedAt": "2013-04-05T16:48:30.7959345+02:00",
    "RepliedAt": "1998-04-15T16:48:30.7959345+02:00",
    "AlertTimeout": "2004-10-29T16:48:30.7959345+02:00",
    "Deadline": "2006-06-10T16:48:30.7959345+02:00",
    "CreatedBy": 960,
    "CreatedByName": "Wuckert Inc and Sons",
    "Author": "et",
    "OwnedBy": 68,
    "OwnedByName": "Carter, Deckow and Welch",
    "Category": 396,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 856,
    "BaseStatus": "Active",
    "TicketStatus": 933,
    "Origin": "AutoGenerated",
    "CustId": 773,
    "CustFirstname": "Jasmin",
    "CustMiddleName": "Gorczany Inc and Sons",
    "CustLastname": "Haag",
    "AlertLevel": 778,
    "ConnectId": 29,
    "ReadStatus": "Green",
    "TimeToReply": 628,
    "RealTimeToReply": 486,
    "TimeToClose": 124,
    "RealTimeToClose": 14,
    "TimeSpentInternally": 692,
    "TimeSpentExternally": 130,
    "TimeSpentQueue": 226,
    "RealTimeSpentInternally": 546,
    "RealTimeSpentExternally": 597,
    "RealTimeSpentQueue": 282,
    "HasAttachment": false,
    "NumReplies": 567,
    "NumMessages": 551,
    "FromAddress": "accusamus",
    "CustFullname": "in",
    "TicketStatusDisplayValue": "id"
  },
  "CreatedAt": "1999-12-27T16:48:30.7959345+01:00",
  "CreatedBy": {
    "AssociateId": 830,
    "Name": "Fadel LLC",
    "PersonId": 406,
    "Rank": 521,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 916,
    "FullName": "Conor Crist",
    "FormalName": "Feil-McClure",
    "Deleted": false,
    "EjUserId": 109,
    "UserName": "Schultz-Dach"
  },
  "Author": "quaerat",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "modi",
  "TimeSpent": 248,
  "Body": "enim",
  "HtmlBody": "aliquid",
  "EmailHeader": "demond@jakubowskigerlach.biz",
  "DebugInfo": "ipsum",
  "MailSorter": "aut",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "odio",
    "PersonId": 373,
    "Mrmrs": "aut",
    "Firstname": "Zack",
    "Lastname": "Green",
    "MiddleName": "Konopelski-Koepp",
    "Title": "id",
    "Description": "Multi-lateral well-modulated pricing structure",
    "Email": "leatha@buckridge.name",
    "FullName": "Jenifer Barton",
    "DirectPhone": "1-072-842-0205 x08322",
    "FormalName": "Stark Group",
    "CountryId": 887,
    "ContactId": 381,
    "ContactName": "Bradtke-Kihn",
    "Retired": 512,
    "Rank": 547,
    "ActiveInterests": 6,
    "ContactDepartment": "",
    "ContactCountryId": 656,
    "ContactOrgNr": "1214830",
    "FaxPhone": "834-818-4816",
    "MobilePhone": "1-336-110-7714",
    "ContactPhone": "528-373-4433 x7305",
    "AssociateName": "Gorczany, Bosco and Champlin",
    "AssociateId": 365,
    "UsePersonAddress": true,
    "ContactFax": "quidem",
    "Kanafname": "porro",
    "Kanalname": "autem",
    "Post1": "autem",
    "Post2": "autem",
    "Post3": "ratione",
    "EmailName": "ewell_franecki@ryan.co.uk",
    "ContactFullName": "Mavis Heidenreich",
    "ActiveErpLinks": 957,
    "TicketPriorityId": 595,
    "SupportLanguageId": 39,
    "SupportAssociateId": 632,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "quia",
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "non"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 189,
  "Ticket": {
    "TicketId": 929,
    "Title": "laborum",
    "CreatedAt": "1995-02-25T16:48:30.8019362+01:00",
    "LastChanged": "2015-04-13T16:48:30.8019362+02:00",
    "ReadByOwner": "2006-03-11T16:48:30.8019362+01:00",
    "ReadByCustomer": "2009-01-09T16:48:30.8019362+01:00",
    "FirstReadByUser": "1999-11-18T16:48:30.8019362+01:00",
    "Activate": "1994-04-25T16:48:30.8019362+02:00",
    "ClosedAt": "2003-02-28T16:48:30.8019362+01:00",
    "RepliedAt": "1999-05-19T16:48:30.8019362+02:00",
    "AlertTimeout": "2014-02-24T16:48:30.8019362+01:00",
    "Deadline": "1995-02-17T16:48:30.8019362+01:00",
    "CreatedBy": 10,
    "CreatedByName": "Thiel, Morissette and Hammes",
    "Author": "occaecati",
    "OwnedBy": 238,
    "OwnedByName": "Ledner LLC",
    "Category": 754,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 604,
    "BaseStatus": "Active",
    "TicketStatus": 265,
    "Origin": "AutoGenerated",
    "CustId": 716,
    "CustFirstname": "Era",
    "CustMiddleName": "Kuphal-Jacobson",
    "CustLastname": "Satterfield",
    "AlertLevel": 879,
    "ConnectId": 604,
    "ReadStatus": "Green",
    "TimeToReply": 80,
    "RealTimeToReply": 850,
    "TimeToClose": 909,
    "RealTimeToClose": 95,
    "TimeSpentInternally": 569,
    "TimeSpentExternally": 259,
    "TimeSpentQueue": 94,
    "RealTimeSpentInternally": 371,
    "RealTimeSpentExternally": 430,
    "RealTimeSpentQueue": 398,
    "HasAttachment": false,
    "NumReplies": 864,
    "NumMessages": 968,
    "FromAddress": "maiores",
    "CustFullname": "nam",
    "TicketStatusDisplayValue": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 224
      }
    }
  },
  "CreatedAt": "2007-01-31T16:48:30.8019362+01:00",
  "CreatedBy": {
    "AssociateId": 91,
    "Name": "Kovacek, Stokes and Kirlin",
    "PersonId": 607,
    "Rank": 987,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 860,
    "FullName": "Ernestina Dach",
    "FormalName": "Ernser, Okuneva and O'Conner",
    "Deleted": true,
    "EjUserId": 829,
    "UserName": "Bartell-Rogahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 741
      }
    }
  },
  "Author": "maxime",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "fuga",
  "TimeSpent": 392,
  "Body": "dolorum",
  "HtmlBody": "incidunt",
  "EmailHeader": "renee.stiedemann@yundt.ca",
  "DebugInfo": "rerum",
  "MailSorter": "ut",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "qui",
    "PersonId": 114,
    "Mrmrs": "velit",
    "Firstname": "Buck",
    "Lastname": "Kilback",
    "MiddleName": "Streich, Brown and Gaylord",
    "Title": "eum",
    "Description": "Re-contextualized 5th generation task-force",
    "Email": "eudora@kassulkereynolds.us",
    "FullName": "Kasey Deckow",
    "DirectPhone": "108.287.7532 x2835",
    "FormalName": "Armstrong, Will and Gusikowski",
    "CountryId": 601,
    "ContactId": 236,
    "ContactName": "Jaskolski Inc and Sons",
    "Retired": 685,
    "Rank": 330,
    "ActiveInterests": 610,
    "ContactDepartment": "",
    "ContactCountryId": 114,
    "ContactOrgNr": "1235034",
    "FaxPhone": "573.838.5136 x23751",
    "MobilePhone": "1-756-318-8577 x28236",
    "ContactPhone": "826.086.3031 x1480",
    "AssociateName": "Bahringer-Brekke",
    "AssociateId": 695,
    "UsePersonAddress": false,
    "ContactFax": "explicabo",
    "Kanafname": "et",
    "Kanalname": "molestiae",
    "Post1": "neque",
    "Post2": "est",
    "Post3": "vero",
    "EmailName": "aaron@kemmermacejkovic.name",
    "ContactFullName": "Tommie Breitenberg I",
    "ActiveErpLinks": 674,
    "TicketPriorityId": 59,
    "SupportLanguageId": 996,
    "SupportAssociateId": 771,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 375
      }
    }
  },
  "SearchTitle": "consequatur",
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "qui"
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
      "FieldType": "System.String",
      "FieldLength": 263
    }
  }
}
```