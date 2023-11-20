---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 625,
  "Limit": 376
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
      "TicketId": 31,
      "TicketStatus": 144,
      "Title": "dolor",
      "Registered": "2010-10-03T13:38:13.3583869+02:00",
      "IconHint": "odit"
    },
    {
      "TicketId": 31,
      "TicketStatus": 144,
      "Title": "dolor",
      "Registered": "2010-10-03T13:38:13.3583869+02:00",
      "IconHint": "odit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 124,
      "DocumentId": 29,
      "Date": "2015-04-16T13:38:13.3583869+02:00",
      "Description": "Decentralized tangible knowledge user",
      "Completed": "Completed",
      "Registered": "2005-05-06T13:38:13.3583869+02:00"
    },
    {
      "AppointmentId": 124,
      "DocumentId": 29,
      "Date": "2015-04-16T13:38:13.3583869+02:00",
      "Description": "Decentralized tangible knowledge user",
      "Completed": "Completed",
      "Registered": "2005-05-06T13:38:13.3583869+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 151,
      "DocumentId": 439,
      "Date": "1998-01-17T13:38:13.3583869+01:00",
      "Description": "Upgradable intangible knowledge base",
      "Completed": "Completed",
      "Registered": "2020-12-09T13:38:13.3583869+01:00"
    },
    {
      "AppointmentId": 151,
      "DocumentId": 439,
      "Date": "1998-01-17T13:38:13.3583869+01:00",
      "Description": "Upgradable intangible knowledge base",
      "Completed": "Completed",
      "Registered": "2020-12-09T13:38:13.3583869+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 362,
      "SaleDate": "2000-03-30T13:38:13.3583869+02:00",
      "Probability": 572,
      "Heading": "aut",
      "Amount": 26400.816,
      "Currency": "quos",
      "AmountInBaseCurrency": 18794.597999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-08-06T13:38:13.3583869+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 220,
      "Name": "Gusikowski, Altenwerth and Homenick",
      "CompanyName": "Oberbrunner, Huels and Koepp",
      "FirstMessage": "aut",
      "LastMessage": "vel",
      "WhenRequested": "2012-01-19T13:38:13.3583869+01:00",
      "WhenEnded": "2021-11-14T13:38:13.3583869+01:00"
    }
  ]
}
```