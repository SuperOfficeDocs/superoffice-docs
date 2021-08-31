---
title: CreateDefaultTicketMessageEntity
id: v1TicketAgent_CreateDefaultTicketMessageEntity
---

# CreateDefaultTicketMessageEntity

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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/CreateDefaultTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 437,
  "Ticket": {
    "TicketId": 744,
    "Title": "molestias",
    "CreatedAt": "2020-03-21T14:58:05.3556086+01:00",
    "LastChanged": "1994-07-29T14:58:05.3556086+02:00",
    "ReadByOwner": "2008-03-16T14:58:05.3556086+01:00",
    "ReadByCustomer": "2012-06-27T14:58:05.3556086+02:00",
    "FirstReadByUser": "2003-06-26T14:58:05.3556086+02:00",
    "Activate": "2006-04-02T14:58:05.3556086+02:00",
    "ClosedAt": "1998-06-09T14:58:05.3556086+02:00",
    "RepliedAt": "1998-12-01T14:58:05.3556086+01:00",
    "AlertTimeout": "2020-06-12T14:58:05.3556086+02:00",
    "Deadline": "2003-05-18T14:58:05.3556086+02:00",
    "CreatedBy": 102,
    "CreatedByName": "Pacocha-Muller",
    "Author": "modi",
    "OwnedBy": 74,
    "OwnedByName": "Parisian Inc and Sons",
    "Category": 105,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 985,
    "PriorityName": "Braun, McDermott and Brakus",
    "BaseStatus": "Active",
    "TicketStatus": 92,
    "TicketStatusDisplayValue": "qui",
    "Origin": "AutoGenerated",
    "CustId": 225,
    "PersonFirstname": "Jasmin",
    "PersonMiddleName": "Mante-Kuphal",
    "PersonLastname": "Greenholt",
    "PersonFullname": "et",
    "AlertLevel": 152,
    "ConnectId": 112,
    "ReadStatus": "Green",
    "TimeToReply": 875,
    "RealTimeToReply": 688,
    "TimeToClose": 507,
    "RealTimeToClose": 256,
    "TimeSpentInternally": 572,
    "TimeSpentExternally": 699,
    "TimeSpentQueue": 57,
    "RealTimeSpentInternally": 58,
    "RealTimeSpentExternally": 150,
    "RealTimeSpentQueue": 64,
    "HasAttachment": true,
    "NumReplies": 406,
    "NumMessages": 24,
    "FromAddress": "ut",
    "ContactId": 233,
    "ContactName": "Koch Inc and Sons",
    "OwnedByAssociateId": 742,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate innovative channels"
        },
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  },
  "CreatedAt": "2001-11-18T14:58:05.3556086+01:00",
  "CreatedBy": {
    "AssociateId": 780,
    "Name": "Barrows-Watsica",
    "PersonId": 994,
    "Rank": 871,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 333,
    "FullName": "Broderick Barton",
    "FormalName": "Kemmer-Sipes",
    "Deleted": true,
    "EjUserId": 74,
    "UserName": "Macejkovic-Williamson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 141
      }
    }
  },
  "Author": "natus",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "inventore",
  "TimeSpent": 517,
  "Body": "sit",
  "HtmlBody": "quo",
  "EmailHeader": "davonte@cremintremblay.us",
  "DebugInfo": "maxime",
  "MailSorter": "officiis",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "est",
    "PersonId": 373,
    "Mrmrs": "quia",
    "Firstname": "Joe",
    "Lastname": "Schmidt",
    "MiddleName": "Rau, Ondricka and Smith",
    "Title": "dolorum",
    "Description": "Front-line eco-centric productivity",
    "Email": "dorcas@schneider.co.uk",
    "FullName": "Piper Schroeder",
    "DirectPhone": "(356)302-2531 x0280",
    "FormalName": "Mante-Lynch",
    "CountryId": 50,
    "ContactId": 198,
    "ContactName": "Schamberger-Stamm",
    "Retired": 576,
    "Rank": 499,
    "ActiveInterests": 408,
    "ContactDepartment": "",
    "ContactCountryId": 915,
    "ContactOrgNr": "69214",
    "FaxPhone": "(852)411-0255",
    "MobilePhone": "1-881-683-0214 x653",
    "ContactPhone": "(401)043-1521 x40483",
    "AssociateName": "Glover-Jenkins",
    "AssociateId": 623,
    "UsePersonAddress": false,
    "ContactFax": "necessitatibus",
    "Kanafname": "dolorem",
    "Kanalname": "dolores",
    "Post1": "autem",
    "Post2": "unde",
    "Post3": "ut",
    "EmailName": "larue_baumbach@gleason.us",
    "ContactFullName": "Mckayla Wisoky",
    "ActiveErpLinks": 134,
    "TicketPriorityId": 922,
    "SupportLanguageId": 871,
    "SupportAssociateId": 112,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 264
      }
    }
  },
  "SearchTitle": "qui",
  "MessageHeaders": [
    {
      "Name": "O'Kon Group",
      "Value": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    },
    {
      "Name": "O'Kon Group",
      "Value": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "consequatur"
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
      "FieldLength": 428
    }
  }
}
```