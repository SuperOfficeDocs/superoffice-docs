---
title: GetTicketMessageEntity
id: v1TicketAgent_GetTicketMessageEntity
---

# GetTicketMessageEntity

```http
POST /api/v1/Agents/Ticket/GetTicketMessageEntity
```

Gets a TicketMessageEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketMessageEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketMessageEntity?ticketMessageEntityId=335
POST /api/v1/Agents/Ticket/GetTicketMessageEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Ticket/GetTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 140,
  "Ticket": {
    "TicketId": 798,
    "Title": "dolores",
    "CreatedAt": "2020-08-20T14:58:05.3986251+02:00",
    "LastChanged": "1998-07-14T14:58:05.3986251+02:00",
    "ReadByOwner": "2008-09-03T14:58:05.3986251+02:00",
    "ReadByCustomer": "2015-07-09T14:58:05.3986251+02:00",
    "FirstReadByUser": "2013-04-05T14:58:05.3986251+02:00",
    "Activate": "2014-08-09T14:58:05.3986251+02:00",
    "ClosedAt": "2002-11-09T14:58:05.3986251+01:00",
    "RepliedAt": "2008-10-19T14:58:05.3986251+02:00",
    "AlertTimeout": "2002-10-02T14:58:05.3986251+02:00",
    "Deadline": "2015-07-18T14:58:05.3986251+02:00",
    "CreatedBy": 259,
    "CreatedByName": "Fadel-Borer",
    "Author": "saepe",
    "OwnedBy": 179,
    "OwnedByName": "Lemke LLC",
    "Category": 934,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 955,
    "PriorityName": "Schmitt-Jacobson",
    "BaseStatus": "Active",
    "TicketStatus": 488,
    "TicketStatusDisplayValue": "itaque",
    "Origin": "AutoGenerated",
    "CustId": 391,
    "PersonFirstname": "Tito",
    "PersonMiddleName": "Anderson LLC",
    "PersonLastname": "Sauer",
    "PersonFullname": "cumque",
    "AlertLevel": 553,
    "ConnectId": 263,
    "ReadStatus": "Green",
    "TimeToReply": 788,
    "RealTimeToReply": 921,
    "TimeToClose": 766,
    "RealTimeToClose": 138,
    "TimeSpentInternally": 40,
    "TimeSpentExternally": 557,
    "TimeSpentQueue": 902,
    "RealTimeSpentInternally": 306,
    "RealTimeSpentExternally": 549,
    "RealTimeSpentQueue": 111,
    "HasAttachment": true,
    "NumReplies": 757,
    "NumMessages": 203,
    "FromAddress": "necessitatibus",
    "ContactId": 111,
    "ContactName": "Turner-Rempel",
    "OwnedByAssociateId": 202,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 870
      }
    }
  },
  "CreatedAt": "2006-07-01T14:58:05.3986251+02:00",
  "CreatedBy": {
    "AssociateId": 927,
    "Name": "Jacobson Inc and Sons",
    "PersonId": 612,
    "Rank": 328,
    "Tooltip": "dicta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 320,
    "FullName": "Ms. Manuel Hickle",
    "FormalName": "McDermott, Bauch and Hudson",
    "Deleted": true,
    "EjUserId": 131,
    "UserName": "Boyle Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 801
      }
    }
  },
  "Author": "veritatis",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "eveniet",
  "TimeSpent": 584,
  "Body": "voluptatum",
  "HtmlBody": "adipisci",
  "EmailHeader": "otilia.osinski@morar.info",
  "DebugInfo": "possimus",
  "MailSorter": "vitae",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "quod",
    "PersonId": 382,
    "Mrmrs": "repellat",
    "Firstname": "Mittie",
    "Lastname": "Kerluke",
    "MiddleName": "Ledner-Crooks",
    "Title": "velit",
    "Description": "Face to face coherent orchestration",
    "Email": "dena@boscostamm.uk",
    "FullName": "Royce Kutch",
    "DirectPhone": "471-320-4167 x112",
    "FormalName": "Russel-Roob",
    "CountryId": 474,
    "ContactId": 257,
    "ContactName": "O'Connell LLC",
    "Retired": 333,
    "Rank": 663,
    "ActiveInterests": 809,
    "ContactDepartment": "",
    "ContactCountryId": 287,
    "ContactOrgNr": "782977",
    "FaxPhone": "877-734-8202",
    "MobilePhone": "(585)347-8020",
    "ContactPhone": "867.811.3687 x88682",
    "AssociateName": "Stokes Group",
    "AssociateId": 873,
    "UsePersonAddress": true,
    "ContactFax": "doloribus",
    "Kanafname": "architecto",
    "Kanalname": "quisquam",
    "Post1": "voluptatem",
    "Post2": "voluptatem",
    "Post3": "sed",
    "EmailName": "tiara@cormier.uk",
    "ContactFullName": "Therese Herman",
    "ActiveErpLinks": 292,
    "TicketPriorityId": 288,
    "SupportLanguageId": 652,
    "SupportAssociateId": 992,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 559
      }
    }
  },
  "SearchTitle": "architecto",
  "MessageHeaders": [
    {
      "Name": "Moore-McClure",
      "Value": "porro",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    },
    {
      "Name": "Moore-McClure",
      "Value": "porro",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "quia"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "mesh proactive infomediaries"
      },
      "FieldType": "System.String",
      "FieldLength": 424
    }
  }
}
```