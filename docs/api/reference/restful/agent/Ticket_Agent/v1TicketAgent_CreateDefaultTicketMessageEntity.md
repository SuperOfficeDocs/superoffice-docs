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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 831,
  "Ticket": {
    "TicketId": 611,
    "Title": "ut",
    "CreatedAt": "2017-04-13T18:28:50.3554446+02:00",
    "LastChanged": "1995-07-22T18:28:50.3554446+02:00",
    "ReadByOwner": "2009-02-15T18:28:50.3554446+01:00",
    "ReadByCustomer": "1999-10-13T18:28:50.3554446+02:00",
    "FirstReadByUser": "2001-04-26T18:28:50.3554446+02:00",
    "Activate": "1997-07-30T18:28:50.3554446+02:00",
    "ClosedAt": "2005-11-02T18:28:50.3554446+01:00",
    "RepliedAt": "2010-12-28T18:28:50.3554446+01:00",
    "AlertTimeout": "2000-08-07T18:28:50.3554446+02:00",
    "Deadline": "2009-07-25T18:28:50.3554446+02:00",
    "CreatedBy": 178,
    "CreatedByName": "Sawayn, Anderson and Koepp",
    "Author": "ad",
    "OwnedBy": 924,
    "OwnedByName": "Donnelly-Pfannerstill",
    "Category": 178,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 112,
    "PriorityName": "Lakin-Dickinson",
    "BaseStatus": "Active",
    "TicketStatus": 762,
    "TicketStatusDisplayValue": "rerum",
    "Origin": "AutoGenerated",
    "CustId": 678,
    "PersonFirstname": "Cameron",
    "PersonMiddleName": "Gibson Group",
    "PersonLastname": "Wolff",
    "PersonFullname": "rerum",
    "AlertLevel": 293,
    "ConnectId": 622,
    "ReadStatus": "Green",
    "TimeToReply": 325,
    "RealTimeToReply": 218,
    "TimeToClose": 399,
    "RealTimeToClose": 887,
    "TimeSpentInternally": 863,
    "TimeSpentExternally": 985,
    "TimeSpentQueue": 39,
    "RealTimeSpentInternally": 723,
    "RealTimeSpentExternally": 908,
    "RealTimeSpentQueue": 275,
    "HasAttachment": true,
    "NumReplies": 215,
    "NumMessages": 994,
    "FromAddress": "ex",
    "ContactId": 197,
    "ContactName": "Powlowski Group",
    "OwnedByAssociateId": 640,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 49
      }
    }
  },
  "CreatedAt": "2004-07-06T18:28:50.3564422+02:00",
  "CreatedBy": {
    "AssociateId": 994,
    "Name": "Frami Inc and Sons",
    "PersonId": 908,
    "Rank": 696,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 738,
    "FullName": "Cruz Mueller",
    "FormalName": "Rau Group",
    "Deleted": false,
    "EjUserId": 40,
    "UserName": "Herzog, Weber and Balistreri",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 775
      }
    }
  },
  "Author": "ea",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "accusantium",
  "TimeSpent": 351,
  "Body": "accusamus",
  "HtmlBody": "autem",
  "EmailHeader": "aaron@jenkinscormier.info",
  "DebugInfo": "laudantium",
  "MailSorter": "et",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "repudiandae",
    "PersonId": 673,
    "Mrmrs": "voluptatum",
    "Firstname": "Martina",
    "Lastname": "Price",
    "MiddleName": "Spinka, Moore and Lang",
    "Title": "placeat",
    "Description": "Object-based assymetric info-mediaries",
    "Email": "samson_hilpert@weberwaters.us",
    "FullName": "Mr. Ubaldo Schaefer",
    "DirectPhone": "117.152.0834",
    "FormalName": "Lowe-Turcotte",
    "CountryId": 938,
    "ContactId": 181,
    "ContactName": "Stroman, Simonis and Veum",
    "Retired": 67,
    "Rank": 371,
    "ActiveInterests": 251,
    "ContactDepartment": "",
    "ContactCountryId": 115,
    "ContactOrgNr": "1147516",
    "FaxPhone": "833-368-7536",
    "MobilePhone": "120.452.1758 x63120",
    "ContactPhone": "1-785-686-8058 x1851",
    "AssociateName": "Rippin Inc and Sons",
    "AssociateId": 892,
    "UsePersonAddress": false,
    "ContactFax": "ab",
    "Kanafname": "nobis",
    "Kanalname": "voluptates",
    "Post1": "laboriosam",
    "Post2": "incidunt",
    "Post3": "quaerat",
    "EmailName": "melisa@wuckert.info",
    "ContactFullName": "Mr. Jefferey Gleichner",
    "ActiveErpLinks": 935,
    "TicketPriorityId": 894,
    "SupportLanguageId": 642,
    "SupportAssociateId": 104,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 714
      }
    }
  },
  "SearchTitle": "ratione",
  "MessageHeaders": [
    {
      "Name": "Nitzsche LLC",
      "Value": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    },
    {
      "Name": "Nitzsche LLC",
      "Value": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 486
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "dolores"
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
      "FieldLength": 378
    }
  }
}
```