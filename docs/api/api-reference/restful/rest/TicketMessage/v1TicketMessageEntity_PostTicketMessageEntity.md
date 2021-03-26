---
title: POST TicketMessage
id: v1TicketMessageEntity_PostTicketMessageEntity
---

# POST TicketMessage

```http
POST /api/v1/TicketMessage
```

Creates a new TicketMessageEntity

Calls the Ticket agent service SaveTicketMessageEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/TicketMessage?$select=name,department,category/id
```


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

## Request Body: newEntity  

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



TicketMessageEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/TicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 947,
  "Ticket": {
    "TicketId": 192,
    "Title": "et",
    "CreatedAt": "2002-09-07T09:40:59.8680688+02:00",
    "LastChanged": "2013-02-04T09:40:59.8680688+01:00",
    "ReadByOwner": "2012-02-14T09:40:59.8680688+01:00",
    "ReadByCustomer": "2000-07-15T09:40:59.8680688+02:00",
    "FirstReadByUser": "2007-01-07T09:40:59.8680688+01:00",
    "Activate": "1999-06-08T09:40:59.8680688+02:00",
    "ClosedAt": "2013-07-30T09:40:59.8680688+02:00",
    "RepliedAt": "2004-12-28T09:40:59.8680688+01:00",
    "AlertTimeout": "1995-05-20T09:40:59.8680688+02:00",
    "Deadline": "2003-08-22T09:40:59.8680688+02:00",
    "CreatedBy": 785,
    "CreatedByName": "Nicolas Group",
    "Author": "quaerat",
    "OwnedBy": 345,
    "OwnedByName": "Schimmel Group",
    "Category": 255,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 550,
    "BaseStatus": "Active",
    "TicketStatus": 234,
    "Origin": "AutoGenerated",
    "CustId": 997,
    "CustFirstname": "Rachel",
    "CustMiddleName": "Predovic-Raynor",
    "CustLastname": "Cartwright",
    "AlertLevel": 805,
    "ConnectId": 135,
    "ReadStatus": "Green",
    "TimeToReply": 429,
    "RealTimeToReply": 901,
    "TimeToClose": 159,
    "RealTimeToClose": 474,
    "TimeSpentInternally": 514,
    "TimeSpentExternally": 487,
    "TimeSpentQueue": 1001,
    "RealTimeSpentInternally": 778,
    "RealTimeSpentExternally": 739,
    "RealTimeSpentQueue": 366,
    "HasAttachment": false,
    "NumReplies": 452,
    "NumMessages": 685,
    "FromAddress": "voluptas",
    "CustFullname": "consequatur",
    "TicketStatusDisplayValue": "eum"
  },
  "CreatedAt": "2003-05-14T09:40:59.8680688+02:00",
  "CreatedBy": {
    "AssociateId": 751,
    "Name": "Hettinger, Lebsack and Maggio",
    "PersonId": 802,
    "Rank": 475,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 664,
    "FullName": "Jimmie Fisher",
    "FormalName": "Herzog-Dibbert",
    "Deleted": false,
    "EjUserId": 284,
    "UserName": "Funk-Corwin"
  },
  "Author": "id",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "expedita",
  "TimeSpent": 292,
  "Body": "et",
  "HtmlBody": "quam",
  "EmailHeader": "marvin@lemke.biz",
  "DebugInfo": "voluptatem",
  "MailSorter": "vel",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "hic",
    "PersonId": 444,
    "Mrmrs": "ut",
    "Firstname": "Keyshawn",
    "Lastname": "Cormier",
    "MiddleName": "Welch LLC",
    "Title": "itaque",
    "Description": "Right-sized web-enabled application",
    "Email": "rasheed@haag.co.uk",
    "FullName": "Ms. Ross Senger",
    "DirectPhone": "653.258.8357 x023",
    "FormalName": "Monahan, Krajcik and Bode",
    "CountryId": 93,
    "ContactId": 742,
    "ContactName": "Parisian, Stark and Ernser",
    "Retired": 198,
    "Rank": 340,
    "ActiveInterests": 223,
    "ContactDepartment": "",
    "ContactCountryId": 766,
    "ContactOrgNr": "1017605",
    "FaxPhone": "(610)344-1887 x44563",
    "MobilePhone": "1-225-840-0783 x28311",
    "ContactPhone": "1-582-133-0881",
    "AssociateName": "Volkman, Champlin and Heller",
    "AssociateId": 605,
    "UsePersonAddress": true,
    "ContactFax": "veniam",
    "Kanafname": "odio",
    "Kanalname": "maiores",
    "Post1": "distinctio",
    "Post2": "ratione",
    "Post3": "velit",
    "EmailName": "doyle@rippinreichert.com",
    "ContactFullName": "Ludwig Labadie",
    "ActiveErpLinks": 187,
    "TicketPriorityId": 590,
    "SupportLanguageId": 895,
    "SupportAssociateId": 260,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "accusantium",
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "maxime",
    "CustomFields2": "sint"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 162,
  "Ticket": {
    "TicketId": 861,
    "Title": "itaque",
    "CreatedAt": "2016-03-12T09:40:59.8730656+01:00",
    "LastChanged": "2002-10-20T09:40:59.8730656+02:00",
    "ReadByOwner": "2013-08-10T09:40:59.8730656+02:00",
    "ReadByCustomer": "2013-07-11T09:40:59.8730656+02:00",
    "FirstReadByUser": "2000-02-23T09:40:59.8730656+01:00",
    "Activate": "2010-04-23T09:40:59.8730656+02:00",
    "ClosedAt": "1995-03-09T09:40:59.8730656+01:00",
    "RepliedAt": "1998-04-02T09:40:59.8730656+02:00",
    "AlertTimeout": "2017-12-21T09:40:59.8730656+01:00",
    "Deadline": "2018-12-08T09:40:59.8730656+01:00",
    "CreatedBy": 93,
    "CreatedByName": "King LLC",
    "Author": "distinctio",
    "OwnedBy": 318,
    "OwnedByName": "Gerhold-McDermott",
    "Category": 79,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 967,
    "BaseStatus": "Active",
    "TicketStatus": 959,
    "Origin": "AutoGenerated",
    "CustId": 255,
    "CustFirstname": "Ona",
    "CustMiddleName": "Powlowski Group",
    "CustLastname": "Okuneva",
    "AlertLevel": 644,
    "ConnectId": 628,
    "ReadStatus": "Green",
    "TimeToReply": 866,
    "RealTimeToReply": 929,
    "TimeToClose": 118,
    "RealTimeToClose": 572,
    "TimeSpentInternally": 493,
    "TimeSpentExternally": 984,
    "TimeSpentQueue": 451,
    "RealTimeSpentInternally": 408,
    "RealTimeSpentExternally": 531,
    "RealTimeSpentQueue": 822,
    "HasAttachment": false,
    "NumReplies": 751,
    "NumMessages": 127,
    "FromAddress": "nihil",
    "CustFullname": "qui",
    "TicketStatusDisplayValue": "incidunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 795
      }
    }
  },
  "CreatedAt": "2012-05-08T09:40:59.8740643+02:00",
  "CreatedBy": {
    "AssociateId": 41,
    "Name": "Dare Group",
    "PersonId": 426,
    "Rank": 127,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 211,
    "FullName": "Miss Coby Stiedemann",
    "FormalName": "Mills, Murazik and Schuppe",
    "Deleted": true,
    "EjUserId": 666,
    "UserName": "Wuckert-Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 230
      }
    }
  },
  "Author": "velit",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "dolores",
  "TimeSpent": 794,
  "Body": "ut",
  "HtmlBody": "et",
  "EmailHeader": "guillermo.cartwright@von.uk",
  "DebugInfo": "quo",
  "MailSorter": "ut",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "magni",
    "PersonId": 878,
    "Mrmrs": "sit",
    "Firstname": "Phoebe",
    "Lastname": "Farrell",
    "MiddleName": "Treutel LLC",
    "Title": "inventore",
    "Description": "Self-enabling upward-trending matrix",
    "Email": "erika@schinnerzulauf.info",
    "FullName": "Mrs. Ericka Becker",
    "DirectPhone": "086-327-4270",
    "FormalName": "Koss, Hansen and Altenwerth",
    "CountryId": 402,
    "ContactId": 674,
    "ContactName": "Armstrong-Conroy",
    "Retired": 870,
    "Rank": 110,
    "ActiveInterests": 386,
    "ContactDepartment": "redefine real-time technologies",
    "ContactCountryId": 837,
    "ContactOrgNr": "533960",
    "FaxPhone": "740-762-5411",
    "MobilePhone": "1-405-470-7514 x211",
    "ContactPhone": "1-676-778-2851",
    "AssociateName": "Kohler-Leannon",
    "AssociateId": 282,
    "UsePersonAddress": true,
    "ContactFax": "delectus",
    "Kanafname": "earum",
    "Kanalname": "similique",
    "Post1": "et",
    "Post2": "est",
    "Post3": "ab",
    "EmailName": "brian_medhurst@schuppeprohaska.co.uk",
    "ContactFullName": "Ray Renner",
    "ActiveErpLinks": 343,
    "TicketPriorityId": 257,
    "SupportLanguageId": 232,
    "SupportAssociateId": 578,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 390
      }
    }
  },
  "SearchTitle": "molestias",
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "nisi"
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
      "FieldLength": 663
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```