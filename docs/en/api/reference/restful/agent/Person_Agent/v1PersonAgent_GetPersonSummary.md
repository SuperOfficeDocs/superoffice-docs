---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
content_type: reference
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 611,
  "Limit": 725
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 376,
      "TicketStatus": 162,
      "Title": "molestiae",
      "Registered": "2020-08-31T03:40:47.406226+02:00",
      "IconHint": "tempora"
    },
    {
      "TicketId": 376,
      "TicketStatus": 162,
      "Title": "molestiae",
      "Registered": "2020-08-31T03:40:47.406226+02:00",
      "IconHint": "tempora"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 924,
      "DocumentId": 206,
      "Date": "2001-11-19T03:40:47.406226+01:00",
      "Description": "Configurable user-facing project",
      "Completed": "Completed",
      "Registered": "2011-04-20T03:40:47.406226+02:00"
    },
    {
      "AppointmentId": 924,
      "DocumentId": 206,
      "Date": "2001-11-19T03:40:47.406226+01:00",
      "Description": "Configurable user-facing project",
      "Completed": "Completed",
      "Registered": "2011-04-20T03:40:47.406226+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 616,
      "DocumentId": 996,
      "Date": "2023-01-19T03:40:47.406226+01:00",
      "Description": "Automated impactful analyzer",
      "Completed": "Completed",
      "Registered": "2008-03-20T03:40:47.406226+01:00"
    },
    {
      "AppointmentId": 616,
      "DocumentId": 996,
      "Date": "2023-01-19T03:40:47.406226+01:00",
      "Description": "Automated impactful analyzer",
      "Completed": "Completed",
      "Registered": "2008-03-20T03:40:47.406226+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 537,
      "SaleDate": "2017-10-01T03:40:47.406226+02:00",
      "Probability": 559,
      "Heading": "temporibus",
      "Amount": 21637.136,
      "Currency": "nihil",
      "AmountInBaseCurrency": 1845.926,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-06-13T03:40:47.406226+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 839,
      "Name": "White, Christiansen and Robel",
      "CompanyName": "Aufderhar, Keebler and Wolf",
      "FirstMessage": "et",
      "LastMessage": "vel",
      "WhenRequested": "2022-03-16T03:40:47.406226+01:00",
      "WhenEnded": "2025-02-11T03:40:47.406226+01:00"
    }
  ]
}
```