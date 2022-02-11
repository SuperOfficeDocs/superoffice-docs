---
title: POST Agents/Contact/GetContactSummary
id: v1ContactAgent_GetContactSummary
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

## Request Body: request  

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| Limit | int32 |  |


## Response: object

Summary of contact with recent activities, chats, and requests included.



Carrier object for ContactSummary.
Services for the ContactSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 764,
  "Limit": 624
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 128,
    "Name": "Hirthe, Bayer and Harvey",
    "OrgNr": "1576650",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "numquam",
    "DirectPhone": "543-358-3340 x6634",
    "AssociateId": 136,
    "CountryId": 593,
    "EmailAddress": "denis@paucek.co.uk",
    "Kananame": "laboriosam",
    "EmailAddressName": "elaina@kirlin.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rosa Walsh",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ipsa",
    "FullName": "Deangelo Bauch V",
    "IsOwnerContact": false,
    "ActiveErpLinks": 509,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "strategize one-to-one web-readiness"
        },
        "FieldType": "System.String",
        "FieldLength": 203
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 287,
      "TicketStatus": 677,
      "Title": "in",
      "Registered": "2007-06-15T18:28:48.6159294+02:00"
    },
    {
      "TicketId": 287,
      "TicketStatus": 677,
      "Title": "in",
      "Registered": "2007-06-15T18:28:48.6159294+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 596,
      "DocumentId": 705,
      "Date": "2011-06-06T18:28:48.6159294+02:00",
      "Description": "Enhanced attitude-oriented leverage",
      "Completed": "Completed",
      "Registered": "2014-08-19T18:28:48.6159294+02:00"
    },
    {
      "AppointmentId": 596,
      "DocumentId": 705,
      "Date": "2011-06-06T18:28:48.6159294+02:00",
      "Description": "Enhanced attitude-oriented leverage",
      "Completed": "Completed",
      "Registered": "2014-08-19T18:28:48.6159294+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 968,
      "DocumentId": 498,
      "Date": "1996-04-09T18:28:48.6159294+02:00",
      "Description": "Ergonomic systemic groupware",
      "Completed": "Completed",
      "Registered": "2019-05-21T18:28:48.6159294+02:00"
    },
    {
      "AppointmentId": 968,
      "DocumentId": 498,
      "Date": "1996-04-09T18:28:48.6159294+02:00",
      "Description": "Ergonomic systemic groupware",
      "Completed": "Completed",
      "Registered": "2019-05-21T18:28:48.6159294+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 416,
      "SaleDate": "2000-06-24T18:28:48.6159294+02:00",
      "Probability": 212,
      "Heading": "itaque",
      "Amount": 16807.642,
      "Currency": "earum",
      "AmountInBaseCurrency": 24288.5,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-12-20T18:28:48.6159294+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 960,
      "Name": "Gutmann LLC",
      "CompanyName": "Haley Inc and Sons",
      "FirstMessage": "distinctio",
      "LastMessage": "eos",
      "WhenRequested": "2009-03-30T18:28:48.6159294+02:00",
      "WhenEnded": "1995-08-21T18:28:48.6159294+02:00"
    }
  ]
}
```