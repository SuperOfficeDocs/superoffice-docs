---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
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
| ContactId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 904,
  "Limit": 189
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 318,
      "TicketStatus": 499,
      "Title": "illum",
      "Registered": "2003-11-26T11:22:37.7585887+01:00",
      "IconHint": "sapiente"
    },
    {
      "TicketId": 318,
      "TicketStatus": 499,
      "Title": "illum",
      "Registered": "2003-11-26T11:22:37.7585887+01:00",
      "IconHint": "sapiente"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 606,
      "DocumentId": 327,
      "Date": "2008-03-06T11:22:37.7585887+01:00",
      "Description": "Down-sized logistical paradigm",
      "Completed": "Completed",
      "Registered": "2012-07-16T11:22:37.7585887+02:00"
    },
    {
      "AppointmentId": 606,
      "DocumentId": 327,
      "Date": "2008-03-06T11:22:37.7585887+01:00",
      "Description": "Down-sized logistical paradigm",
      "Completed": "Completed",
      "Registered": "2012-07-16T11:22:37.7585887+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 547,
      "DocumentId": 354,
      "Date": "1996-02-14T11:22:37.7585887+01:00",
      "Description": "Future-proofed web-enabled superstructure",
      "Completed": "Completed",
      "Registered": "2010-06-16T11:22:37.7585887+02:00"
    },
    {
      "AppointmentId": 547,
      "DocumentId": 354,
      "Date": "1996-02-14T11:22:37.7585887+01:00",
      "Description": "Future-proofed web-enabled superstructure",
      "Completed": "Completed",
      "Registered": "2010-06-16T11:22:37.7585887+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 959,
      "SaleDate": "2021-07-18T11:22:37.7585887+02:00",
      "Probability": 335,
      "Heading": "voluptate",
      "Amount": 17691.43,
      "Currency": "provident",
      "AmountInBaseCurrency": 17008.218,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1995-10-14T11:22:37.7585887+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 736,
      "Name": "Lockman-Shanahan",
      "CompanyName": "Osinski-Braun",
      "FirstMessage": "vel",
      "LastMessage": "tempora",
      "WhenRequested": "2022-11-21T11:22:37.7585887+01:00",
      "WhenEnded": "2004-04-11T11:22:37.7585887+02:00"
    }
  ]
}
```