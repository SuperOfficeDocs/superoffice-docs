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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/TicketMessage/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 691,
  "Ticket": {
    "TicketId": 193,
    "Title": "sint",
    "CreatedAt": "1995-11-06T15:05:42.8776624+01:00",
    "LastChanged": "1997-01-21T15:05:42.8776624+01:00",
    "ReadByOwner": "2015-08-09T15:05:42.8776624+02:00",
    "ReadByCustomer": "2003-11-03T15:05:42.8776624+01:00",
    "FirstReadByUser": "2019-03-03T15:05:42.8776624+01:00",
    "Activate": "2010-03-18T15:05:42.8776624+01:00",
    "ClosedAt": "2008-06-16T15:05:42.8776624+02:00",
    "RepliedAt": "2008-11-10T15:05:42.8776624+01:00",
    "AlertTimeout": "1999-08-26T15:05:42.8776624+02:00",
    "Deadline": "1995-12-24T15:05:42.8776624+01:00",
    "CreatedBy": 94,
    "CreatedByName": "Kautzer-Rosenbaum",
    "Author": "rerum",
    "OwnedBy": 682,
    "OwnedByName": "Jast, Mante and Schneider",
    "Category": 563,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 935,
    "PriorityName": "Cruickshank-Thiel",
    "BaseStatus": "Active",
    "TicketStatus": 541,
    "TicketStatusDisplayValue": "dolorum",
    "Origin": "AutoGenerated",
    "CustId": 503,
    "PersonFirstname": "Ollie",
    "PersonMiddleName": "Ziemann Group",
    "PersonLastname": "Krajcik",
    "PersonFullname": "dicta",
    "AlertLevel": 332,
    "ConnectId": 900,
    "ReadStatus": "Green",
    "TimeToReply": 306,
    "RealTimeToReply": 941,
    "TimeToClose": 568,
    "RealTimeToClose": 340,
    "TimeSpentInternally": 179,
    "TimeSpentExternally": 288,
    "TimeSpentQueue": 755,
    "RealTimeSpentInternally": 907,
    "RealTimeSpentExternally": 886,
    "RealTimeSpentQueue": 783,
    "HasAttachment": true,
    "NumReplies": 116,
    "NumMessages": 383,
    "FromAddress": "quis",
    "ContactId": 71,
    "ContactName": "Lind, Rice and Walter",
    "OwnedByAssociateId": 340,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 658
      }
    }
  },
  "CreatedAt": "2002-01-17T15:05:42.8786645+01:00",
  "CreatedBy": {
    "AssociateId": 590,
    "Name": "Douglas, Koch and Hammes",
    "PersonId": 239,
    "Rank": 907,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 16,
    "FullName": "Maximus Koch",
    "FormalName": "Lynch, Rice and Leuschke",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Lang-Prohaska",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 597
      }
    }
  },
  "Author": "et",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "soluta",
  "TimeSpent": 463,
  "Body": "quibusdam",
  "HtmlBody": "nihil",
  "EmailHeader": "cory@ryan.us",
  "DebugInfo": "aut",
  "MailSorter": "enim",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "culpa",
    "PersonId": 234,
    "Mrmrs": "repellat",
    "Firstname": "Ana",
    "Lastname": "Blick",
    "MiddleName": "Schimmel Inc and Sons",
    "Title": "rerum",
    "Description": "Upgradable zero tolerance attitude",
    "Email": "holly.ferry@yundt.co.uk",
    "FullName": "Israel Torphy",
    "DirectPhone": "1-332-627-7385",
    "FormalName": "Jakubowski, Mraz and Lind",
    "CountryId": 912,
    "ContactId": 379,
    "ContactName": "Mante, Goldner and Sawayn",
    "Retired": 248,
    "Rank": 468,
    "ActiveInterests": 624,
    "ContactDepartment": "",
    "ContactCountryId": 603,
    "ContactOrgNr": "661206",
    "FaxPhone": "1-210-418-7360 x20168",
    "MobilePhone": "471.488.3210 x8863",
    "ContactPhone": "1-768-175-1266",
    "AssociateName": "Nitzsche-Monahan",
    "AssociateId": 251,
    "UsePersonAddress": true,
    "ContactFax": "non",
    "Kanafname": "quo",
    "Kanalname": "assumenda",
    "Post1": "nihil",
    "Post2": "suscipit",
    "Post3": "illum",
    "EmailName": "annabel@ullrich.uk",
    "ContactFullName": "Joannie Kautzer",
    "ActiveErpLinks": 242,
    "TicketPriorityId": 583,
    "SupportLanguageId": 110,
    "SupportAssociateId": 228,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 755
      }
    }
  },
  "SearchTitle": "nostrum",
  "MessageHeaders": [
    {
      "Name": "Bahringer, Adams and Koss",
      "Value": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    },
    {
      "Name": "Bahringer, Adams and Koss",
      "Value": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "temporibus"
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
      "FieldLength": 392
    }
  }
}
```