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
POST /api/v1/Agents/Ticket/GetTicketMessageEntity?ticketMessageEntityId=873
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/GetTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 301,
  "Ticket": {
    "TicketId": 249,
    "Title": "ut",
    "CreatedAt": "2017-08-30T16:48:30.8189343+02:00",
    "LastChanged": "2017-06-06T16:48:30.8189343+02:00",
    "ReadByOwner": "2009-04-17T16:48:30.8189343+02:00",
    "ReadByCustomer": "1994-08-23T16:48:30.8189343+02:00",
    "FirstReadByUser": "2014-01-20T16:48:30.8189343+01:00",
    "Activate": "2009-10-14T16:48:30.8189343+02:00",
    "ClosedAt": "2009-07-28T16:48:30.8189343+02:00",
    "RepliedAt": "1995-11-22T16:48:30.8189343+01:00",
    "AlertTimeout": "2001-02-18T16:48:30.8189343+01:00",
    "Deadline": "2011-09-28T16:48:30.8189343+02:00",
    "CreatedBy": 29,
    "CreatedByName": "Waelchi, Baumbach and Klein",
    "Author": "consequatur",
    "OwnedBy": 428,
    "OwnedByName": "Mosciski Inc and Sons",
    "Category": 193,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 16,
    "BaseStatus": "Active",
    "TicketStatus": 435,
    "Origin": "AutoGenerated",
    "CustId": 799,
    "CustFirstname": "Rory",
    "CustMiddleName": "Konopelski-Ortiz",
    "CustLastname": "Grady",
    "AlertLevel": 197,
    "ConnectId": 519,
    "ReadStatus": "Green",
    "TimeToReply": 859,
    "RealTimeToReply": 911,
    "TimeToClose": 330,
    "RealTimeToClose": 913,
    "TimeSpentInternally": 132,
    "TimeSpentExternally": 949,
    "TimeSpentQueue": 36,
    "RealTimeSpentInternally": 510,
    "RealTimeSpentExternally": 496,
    "RealTimeSpentQueue": 748,
    "HasAttachment": true,
    "NumReplies": 701,
    "NumMessages": 347,
    "FromAddress": "voluptatibus",
    "CustFullname": "recusandae",
    "TicketStatusDisplayValue": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 850
      }
    }
  },
  "CreatedAt": "1998-07-22T16:48:30.8199326+02:00",
  "CreatedBy": {
    "AssociateId": 432,
    "Name": "Boehm-Flatley",
    "PersonId": 879,
    "Rank": 358,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 303,
    "FullName": "Mr. Aylin Jacobson",
    "FormalName": "Feeney-Crona",
    "Deleted": false,
    "EjUserId": 521,
    "UserName": "Johns-Grant",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 598
      }
    }
  },
  "Author": "praesentium",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "iusto",
  "TimeSpent": 63,
  "Body": "deleniti",
  "HtmlBody": "et",
  "EmailHeader": "london.glover@daniel.ca",
  "DebugInfo": "est",
  "MailSorter": "suscipit",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "aut",
    "PersonId": 904,
    "Mrmrs": "voluptate",
    "Firstname": "Brycen",
    "Lastname": "Dare",
    "MiddleName": "Renner, Goyette and Mosciski",
    "Title": "qui",
    "Description": "User-centric 24/7 moratorium",
    "Email": "lavinia@yundt.com",
    "FullName": "Beaulah Christiansen",
    "DirectPhone": "1-355-711-2714",
    "FormalName": "Borer-Hauck",
    "CountryId": 327,
    "ContactId": 963,
    "ContactName": "Heller LLC",
    "Retired": 258,
    "Rank": 707,
    "ActiveInterests": 226,
    "ContactDepartment": "",
    "ContactCountryId": 903,
    "ContactOrgNr": "1019900",
    "FaxPhone": "343-843-2062 x0438",
    "MobilePhone": "(171)445-5327",
    "ContactPhone": "(738)367-5577 x31017",
    "AssociateName": "Lueilwitz Group",
    "AssociateId": 959,
    "UsePersonAddress": false,
    "ContactFax": "consequatur",
    "Kanafname": "quasi",
    "Kanalname": "assumenda",
    "Post1": "nam",
    "Post2": "nobis",
    "Post3": "aut",
    "EmailName": "madisyn@stiedemannconn.uk",
    "ContactFullName": "Emilio Schowalter",
    "ActiveErpLinks": 812,
    "TicketPriorityId": 111,
    "SupportLanguageId": 401,
    "SupportAssociateId": 777,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "architect cross-media solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 739
      }
    }
  },
  "SearchTitle": "rerum",
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "voluptatibus"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "revolutionize global methodologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 174
    }
  }
}
```