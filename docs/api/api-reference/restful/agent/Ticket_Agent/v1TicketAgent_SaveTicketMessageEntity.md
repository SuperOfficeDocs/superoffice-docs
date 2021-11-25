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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 118,
  "Ticket": {
    "TicketId": 995,
    "Title": "dolor",
    "CreatedAt": "2004-11-16T18:28:50.3584417+01:00",
    "LastChanged": "2015-03-26T18:28:50.3584417+01:00",
    "ReadByOwner": "1997-06-13T18:28:50.3584417+02:00",
    "ReadByCustomer": "2007-07-29T18:28:50.3584417+02:00",
    "FirstReadByUser": "2015-11-27T18:28:50.3584417+01:00",
    "Activate": "1997-02-14T18:28:50.3584417+01:00",
    "ClosedAt": "1995-02-28T18:28:50.3584417+01:00",
    "RepliedAt": "2011-03-06T18:28:50.3584417+01:00",
    "AlertTimeout": "2013-03-04T18:28:50.3584417+01:00",
    "Deadline": "2007-09-09T18:28:50.3584417+02:00",
    "CreatedBy": 58,
    "CreatedByName": "Marquardt-Ferry",
    "Author": "voluptatem",
    "OwnedBy": 507,
    "OwnedByName": "Hermann Group",
    "Category": 927,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 734,
    "PriorityName": "Christiansen Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 460,
    "TicketStatusDisplayValue": "perferendis",
    "Origin": "AutoGenerated",
    "CustId": 930,
    "PersonFirstname": "Cullen",
    "PersonMiddleName": "Cronin Inc and Sons",
    "PersonLastname": "Kihn",
    "PersonFullname": "et",
    "AlertLevel": 633,
    "ConnectId": 692,
    "ReadStatus": "Green",
    "TimeToReply": 893,
    "RealTimeToReply": 932,
    "TimeToClose": 79,
    "RealTimeToClose": 138,
    "TimeSpentInternally": 300,
    "TimeSpentExternally": 945,
    "TimeSpentQueue": 241,
    "RealTimeSpentInternally": 26,
    "RealTimeSpentExternally": 873,
    "RealTimeSpentQueue": 34,
    "HasAttachment": false,
    "NumReplies": 72,
    "NumMessages": 254,
    "FromAddress": "excepturi",
    "ContactId": 581,
    "ContactName": "Blick-Weimann",
    "OwnedByAssociateId": 520
  },
  "CreatedAt": "1996-08-26T18:28:50.3584417+02:00",
  "CreatedBy": {
    "AssociateId": 308,
    "Name": "Champlin, Farrell and Kling",
    "PersonId": 83,
    "Rank": 343,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 727,
    "FullName": "Brooke Denesik",
    "FormalName": "Feest, Zemlak and Sporer",
    "Deleted": true,
    "EjUserId": 220,
    "UserName": "Connelly-Leannon"
  },
  "Author": "ratione",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "et",
  "TimeSpent": 848,
  "Body": "eligendi",
  "HtmlBody": "eos",
  "EmailHeader": "virginie_upton@stoltenberg.ca",
  "DebugInfo": "repudiandae",
  "MailSorter": "fugit",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "nisi",
    "PersonId": 401,
    "Mrmrs": "sint",
    "Firstname": "Elisa",
    "Lastname": "Kozey",
    "MiddleName": "Kertzmann Group",
    "Title": "deserunt",
    "Description": "Multi-lateral mission-critical software",
    "Email": "stefan@brown.ca",
    "FullName": "Edmond Bogan",
    "DirectPhone": "121-483-3620",
    "FormalName": "Kilback-Hammes",
    "CountryId": 774,
    "ContactId": 874,
    "ContactName": "Johns-Ledner",
    "Retired": 114,
    "Rank": 826,
    "ActiveInterests": 249,
    "ContactDepartment": "",
    "ContactCountryId": 288,
    "ContactOrgNr": "669362",
    "FaxPhone": "(767)670-2268 x3544",
    "MobilePhone": "1-715-285-2281 x2126",
    "ContactPhone": "053.246.8414 x1008",
    "AssociateName": "Schaefer Inc and Sons",
    "AssociateId": 656,
    "UsePersonAddress": true,
    "ContactFax": "dolor",
    "Kanafname": "dolorem",
    "Kanalname": "aut",
    "Post1": "odio",
    "Post2": "qui",
    "Post3": "aut",
    "EmailName": "jared@west.com",
    "ContactFullName": "Amari Ward",
    "ActiveErpLinks": 728,
    "TicketPriorityId": 445,
    "SupportLanguageId": 851,
    "SupportAssociateId": 838,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "dolore",
  "MessageHeaders": [
    {
      "Name": "Steuber-Hudson",
      "Value": "occaecati"
    },
    {
      "Name": "Steuber-Hudson",
      "Value": "occaecati"
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "ut"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 85,
  "Ticket": {
    "TicketId": 262,
    "Title": "modi",
    "CreatedAt": "2008-01-11T18:28:50.3644119+01:00",
    "LastChanged": "2016-03-24T18:28:50.3644119+01:00",
    "ReadByOwner": "2011-05-12T18:28:50.3644119+02:00",
    "ReadByCustomer": "2000-05-23T18:28:50.3644119+02:00",
    "FirstReadByUser": "2017-10-17T18:28:50.3644119+02:00",
    "Activate": "2018-07-22T18:28:50.3644119+02:00",
    "ClosedAt": "1999-02-19T18:28:50.3644119+01:00",
    "RepliedAt": "2011-06-14T18:28:50.3644119+02:00",
    "AlertTimeout": "1994-11-07T18:28:50.3644119+01:00",
    "Deadline": "2000-04-22T18:28:50.3644119+02:00",
    "CreatedBy": 865,
    "CreatedByName": "Dietrich, Lind and Paucek",
    "Author": "quaerat",
    "OwnedBy": 595,
    "OwnedByName": "Gleichner, Sauer and Lueilwitz",
    "Category": 173,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 446,
    "PriorityName": "Abernathy LLC",
    "BaseStatus": "Active",
    "TicketStatus": 590,
    "TicketStatusDisplayValue": "assumenda",
    "Origin": "AutoGenerated",
    "CustId": 358,
    "PersonFirstname": "Brigitte",
    "PersonMiddleName": "Gleichner, Kuphal and Sauer",
    "PersonLastname": "Buckridge",
    "PersonFullname": "dicta",
    "AlertLevel": 903,
    "ConnectId": 966,
    "ReadStatus": "Green",
    "TimeToReply": 298,
    "RealTimeToReply": 186,
    "TimeToClose": 353,
    "RealTimeToClose": 203,
    "TimeSpentInternally": 177,
    "TimeSpentExternally": 334,
    "TimeSpentQueue": 492,
    "RealTimeSpentInternally": 357,
    "RealTimeSpentExternally": 780,
    "RealTimeSpentQueue": 443,
    "HasAttachment": false,
    "NumReplies": 37,
    "NumMessages": 915,
    "FromAddress": "eveniet",
    "ContactId": 122,
    "ContactName": "Connelly-Jacobi",
    "OwnedByAssociateId": 140,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 405
      }
    }
  },
  "CreatedAt": "1994-12-20T18:28:50.3644119+01:00",
  "CreatedBy": {
    "AssociateId": 390,
    "Name": "Schroeder, Schamberger and Wiza",
    "PersonId": 696,
    "Rank": 656,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 69,
    "FullName": "Einar Bergstrom",
    "FormalName": "Cronin LLC",
    "Deleted": true,
    "EjUserId": 917,
    "UserName": "Ondricka LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 959
      }
    }
  },
  "Author": "quas",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "ut",
  "TimeSpent": 949,
  "Body": "temporibus",
  "HtmlBody": "soluta",
  "EmailHeader": "quinten_grimes@parisian.uk",
  "DebugInfo": "architecto",
  "MailSorter": "reiciendis",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "et",
    "PersonId": 218,
    "Mrmrs": "aperiam",
    "Firstname": "Lawrence",
    "Lastname": "Walter",
    "MiddleName": "Armstrong, Rogahn and Cremin",
    "Title": "dicta",
    "Description": "Programmable non-volatile orchestration",
    "Email": "duane@kreiger.com",
    "FullName": "Robyn Pacocha",
    "DirectPhone": "048.737.4836 x86866",
    "FormalName": "Zulauf, Considine and Kilback",
    "CountryId": 596,
    "ContactId": 528,
    "ContactName": "Runolfsson Group",
    "Retired": 799,
    "Rank": 464,
    "ActiveInterests": 499,
    "ContactDepartment": "",
    "ContactCountryId": 979,
    "ContactOrgNr": "1079883",
    "FaxPhone": "(357)207-7456 x281",
    "MobilePhone": "1-660-616-3038 x680",
    "ContactPhone": "(350)633-3374 x61388",
    "AssociateName": "Schroeder, Schimmel and Schmidt",
    "AssociateId": 276,
    "UsePersonAddress": false,
    "ContactFax": "facere",
    "Kanafname": "qui",
    "Kanalname": "explicabo",
    "Post1": "adipisci",
    "Post2": "molestias",
    "Post3": "et",
    "EmailName": "christelle_osinski@manterosenbaum.com",
    "ContactFullName": "Roxanne Marks",
    "ActiveErpLinks": 48,
    "TicketPriorityId": 50,
    "SupportLanguageId": 398,
    "SupportAssociateId": 474,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 968
      }
    }
  },
  "SearchTitle": "et",
  "MessageHeaders": [
    {
      "Name": "McClure Group",
      "Value": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    },
    {
      "Name": "McClure Group",
      "Value": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "sit"
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
      "FieldLength": 186
    }
  }
}
```