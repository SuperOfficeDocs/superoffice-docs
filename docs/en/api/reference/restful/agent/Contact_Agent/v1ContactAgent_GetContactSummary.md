---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
content_type: reference
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
  "ContactId": 742,
  "Limit": 206
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
      "TicketId": 619,
      "TicketStatus": 469,
      "Title": "ipsam",
      "Registered": "2018-03-16T11:24:47.8126691+01:00",
      "IconHint": "veniam"
    },
    {
      "TicketId": 619,
      "TicketStatus": 469,
      "Title": "ipsam",
      "Registered": "2018-03-16T11:24:47.8126691+01:00",
      "IconHint": "veniam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 831,
      "DocumentId": 423,
      "Date": "2020-10-11T11:24:47.8126691+02:00",
      "Description": "Switchable interactive hierarchy",
      "Completed": "Completed",
      "Registered": "2013-04-15T11:24:47.8126691+02:00"
    },
    {
      "AppointmentId": 831,
      "DocumentId": 423,
      "Date": "2020-10-11T11:24:47.8126691+02:00",
      "Description": "Switchable interactive hierarchy",
      "Completed": "Completed",
      "Registered": "2013-04-15T11:24:47.8126691+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 180,
      "DocumentId": 362,
      "Date": "2023-08-20T11:24:47.8126691+02:00",
      "Description": "Multi-lateral asynchronous architecture",
      "Completed": "Completed",
      "Registered": "2014-05-11T11:24:47.8126691+02:00"
    },
    {
      "AppointmentId": 180,
      "DocumentId": 362,
      "Date": "2023-08-20T11:24:47.8126691+02:00",
      "Description": "Multi-lateral asynchronous architecture",
      "Completed": "Completed",
      "Registered": "2014-05-11T11:24:47.8126691+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 251,
      "SaleDate": "2025-05-31T11:24:47.8126691+02:00",
      "Probability": 341,
      "Heading": "suscipit",
      "Amount": 2930.29,
      "Currency": "recusandae",
      "AmountInBaseCurrency": 31148.825999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-01-12T11:24:47.8126691+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 542,
      "Name": "Pollich, Wintheiser and Simonis",
      "CompanyName": "Sanford-Weber",
      "FirstMessage": "quia",
      "LastMessage": "voluptas",
      "WhenRequested": "2018-06-10T11:24:47.8126691+02:00",
      "WhenEnded": "2015-09-07T11:24:47.8126691+02:00"
    }
  ]
}
```