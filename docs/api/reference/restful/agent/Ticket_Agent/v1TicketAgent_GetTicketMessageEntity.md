---
title: POST Agents/Ticket/GetTicketMessageEntity
id: v1TicketAgent_GetTicketMessageEntity
---

# POST Agents/Ticket/GetTicketMessageEntity

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
POST /api/v1/Agents/Ticket/GetTicketMessageEntity?ticketMessageEntityId=540
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
  "EjMessageId": 143,
  "Ticket": {
    "TicketId": 320,
    "Title": "et",
    "CreatedAt": "1996-06-21T18:28:50.3974156+02:00",
    "LastChanged": "1995-08-30T18:28:50.3974156+02:00",
    "ReadByOwner": "2001-06-06T18:28:50.3974156+02:00",
    "ReadByCustomer": "1998-10-18T18:28:50.3974156+02:00",
    "FirstReadByUser": "2006-01-08T18:28:50.3974156+01:00",
    "Activate": "2010-01-14T18:28:50.3974156+01:00",
    "ClosedAt": "2018-05-29T18:28:50.3974156+02:00",
    "RepliedAt": "1995-03-25T18:28:50.3974156+01:00",
    "AlertTimeout": "1997-04-26T18:28:50.3974156+02:00",
    "Deadline": "1997-02-05T18:28:50.3974156+01:00",
    "CreatedBy": 413,
    "CreatedByName": "Halvorson Group",
    "Author": "nostrum",
    "OwnedBy": 327,
    "OwnedByName": "Olson Inc and Sons",
    "Category": 198,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 406,
    "PriorityName": "Langosh, Wyman and Wunsch",
    "BaseStatus": "Active",
    "TicketStatus": 202,
    "TicketStatusDisplayValue": "molestiae",
    "Origin": "AutoGenerated",
    "CustId": 196,
    "PersonFirstname": "Jamil",
    "PersonMiddleName": "VonRueden Group",
    "PersonLastname": "Jacobs",
    "PersonFullname": "velit",
    "AlertLevel": 230,
    "ConnectId": 2,
    "ReadStatus": "Green",
    "TimeToReply": 769,
    "RealTimeToReply": 899,
    "TimeToClose": 781,
    "RealTimeToClose": 78,
    "TimeSpentInternally": 79,
    "TimeSpentExternally": 328,
    "TimeSpentQueue": 103,
    "RealTimeSpentInternally": 171,
    "RealTimeSpentExternally": 54,
    "RealTimeSpentQueue": 658,
    "HasAttachment": true,
    "NumReplies": 671,
    "NumMessages": 391,
    "FromAddress": "illum",
    "ContactId": 332,
    "ContactName": "King-Sanford",
    "OwnedByAssociateId": 775,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 807
      }
    }
  },
  "CreatedAt": "1998-08-02T18:28:50.3984152+02:00",
  "CreatedBy": {
    "AssociateId": 408,
    "Name": "Hayes Group",
    "PersonId": 272,
    "Rank": 465,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 638,
    "FullName": "Miss Sydney Ullrich",
    "FormalName": "Bradtke Inc and Sons",
    "Deleted": true,
    "EjUserId": 454,
    "UserName": "Schinner, Weimann and Hickle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 750
      }
    }
  },
  "Author": "tempora",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "aut",
  "TimeSpent": 226,
  "Body": "accusantium",
  "HtmlBody": "dolore",
  "EmailHeader": "clemens.kovacek@von.ca",
  "DebugInfo": "perspiciatis",
  "MailSorter": "tempore",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "pariatur",
    "PersonId": 895,
    "Mrmrs": "totam",
    "Firstname": "Travon",
    "Lastname": "DuBuque",
    "MiddleName": "Beatty, Ratke and Jenkins",
    "Title": "quod",
    "Description": "Future-proofed grid-enabled process improvement",
    "Email": "darrick_hauck@mclaughlin.us",
    "FullName": "Isaias Herman",
    "DirectPhone": "(416)401-6011 x043",
    "FormalName": "Krajcik, Adams and Kuvalis",
    "CountryId": 317,
    "ContactId": 571,
    "ContactName": "Smith-Abshire",
    "Retired": 312,
    "Rank": 759,
    "ActiveInterests": 337,
    "ContactDepartment": "",
    "ContactCountryId": 513,
    "ContactOrgNr": "992012",
    "FaxPhone": "1-547-344-6351 x6640",
    "MobilePhone": "1-747-747-5705 x48814",
    "ContactPhone": "(163)556-0182 x0635",
    "AssociateName": "Kuhn Inc and Sons",
    "AssociateId": 854,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "repudiandae",
    "Kanalname": "aut",
    "Post1": "voluptas",
    "Post2": "doloribus",
    "Post3": "omnis",
    "EmailName": "carmela@lindabbott.co.uk",
    "ContactFullName": "Elisha Bode",
    "ActiveErpLinks": 467,
    "TicketPriorityId": 644,
    "SupportLanguageId": 816,
    "SupportAssociateId": 197,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 367
      }
    }
  },
  "SearchTitle": "aperiam",
  "MessageHeaders": [
    {
      "Name": "Bogan-Orn",
      "Value": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    },
    {
      "Name": "Bogan-Orn",
      "Value": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "sint"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "strategize user-centric architectures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 998
    }
  }
}
```