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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 423,
  "Ticket": {
    "TicketId": 535,
    "Title": "quod",
    "CreatedAt": "2014-08-07T18:25:51.2329408+02:00",
    "LastChanged": "2002-11-01T18:25:51.2329408+01:00",
    "ReadByOwner": "1996-12-14T18:25:51.2329408+01:00",
    "ReadByCustomer": "2001-06-05T18:25:51.2329408+02:00",
    "FirstReadByUser": "2004-01-20T18:25:51.2329408+01:00",
    "Activate": "2000-04-28T18:25:51.2329408+02:00",
    "ClosedAt": "2003-09-04T18:25:51.2329408+02:00",
    "RepliedAt": "2020-03-07T18:25:51.2329408+01:00",
    "AlertTimeout": "2017-05-06T18:25:51.2329408+02:00",
    "Deadline": "2010-05-15T18:25:51.2329408+02:00",
    "CreatedBy": 295,
    "CreatedByName": "Kunde, Lowe and Greenholt",
    "Author": "error",
    "OwnedBy": 375,
    "OwnedByName": "Nienow Group",
    "Category": 604,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 396,
    "PriorityName": "Thiel, Medhurst and Langworth",
    "BaseStatus": "Active",
    "TicketStatus": 654,
    "TicketStatusDisplayValue": "omnis",
    "Origin": "AutoGenerated",
    "CustId": 910,
    "PersonFirstname": "Salvador",
    "PersonMiddleName": "Franecki Inc and Sons",
    "PersonLastname": "Beer",
    "PersonFullname": "ad",
    "AlertLevel": 899,
    "ConnectId": 436,
    "ReadStatus": "Green",
    "TimeToReply": 799,
    "RealTimeToReply": 777,
    "TimeToClose": 295,
    "RealTimeToClose": 742,
    "TimeSpentInternally": 173,
    "TimeSpentExternally": 746,
    "TimeSpentQueue": 692,
    "RealTimeSpentInternally": 49,
    "RealTimeSpentExternally": 244,
    "RealTimeSpentQueue": 920,
    "HasAttachment": false,
    "NumReplies": 666,
    "NumMessages": 189,
    "FromAddress": "consequatur",
    "ContactId": 775,
    "ContactName": "Corwin Group",
    "OwnedByAssociateId": 515,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 590
      }
    }
  },
  "CreatedAt": "2003-02-02T18:25:51.2339401+01:00",
  "CreatedBy": {
    "AssociateId": 88,
    "Name": "Kris, Haley and Schmeler",
    "PersonId": 364,
    "Rank": 100,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 163,
    "FullName": "Ruby Heaney",
    "FormalName": "Willms-Feest",
    "Deleted": false,
    "EjUserId": 242,
    "UserName": "Dooley Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 299
      }
    }
  },
  "Author": "asperiores",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "ratione",
  "TimeSpent": 706,
  "Body": "dicta",
  "HtmlBody": "quia",
  "EmailHeader": "immanuel_oberbrunner@bartolettiwaelchi.biz",
  "DebugInfo": "laboriosam",
  "MailSorter": "corrupti",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "perferendis",
    "PersonId": 392,
    "Mrmrs": "corrupti",
    "Firstname": "Anjali",
    "Lastname": "Crist",
    "MiddleName": "Barrows LLC",
    "Title": "odit",
    "Description": "Ergonomic user-facing flexibility",
    "Email": "shanel@gerhold.ca",
    "FullName": "Miss Jordan Prosacco",
    "DirectPhone": "750.824.3226 x25068",
    "FormalName": "Weissnat, Hammes and Lind",
    "CountryId": 252,
    "ContactId": 97,
    "ContactName": "Nader-Hackett",
    "Retired": 540,
    "Rank": 549,
    "ActiveInterests": 935,
    "ContactDepartment": "",
    "ContactCountryId": 403,
    "ContactOrgNr": "1648065",
    "FaxPhone": "1-703-584-8575 x02522",
    "MobilePhone": "(671)384-8187 x36558",
    "ContactPhone": "1-037-833-6338",
    "AssociateName": "Konopelski-Kutch",
    "AssociateId": 373,
    "UsePersonAddress": false,
    "ContactFax": "nemo",
    "Kanafname": "eaque",
    "Kanalname": "consequatur",
    "Post1": "earum",
    "Post2": "sit",
    "Post3": "est",
    "EmailName": "braden@bartell.biz",
    "ContactFullName": "Creola Feest",
    "ActiveErpLinks": 454,
    "TicketPriorityId": 300,
    "SupportLanguageId": 497,
    "SupportAssociateId": 358,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 33
      }
    }
  },
  "SearchTitle": "nihil",
  "MessageHeaders": [
    {
      "Name": "Morar, Block and Buckridge",
      "Value": "quos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    },
    {
      "Name": "Morar, Block and Buckridge",
      "Value": "quos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "voluptates"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "grow cutting-edge synergies"
      },
      "FieldType": "System.String",
      "FieldLength": 685
    }
  }
}
```