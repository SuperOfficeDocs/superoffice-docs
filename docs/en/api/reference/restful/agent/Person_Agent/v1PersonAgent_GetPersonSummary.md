---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







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
  "PersonId": 194,
  "Limit": 903
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
      "TicketId": 947,
      "TicketStatus": 327,
      "Title": "voluptate",
      "Registered": "2022-01-19T16:32:39.5240522+01:00",
      "IconHint": "corporis"
    },
    {
      "TicketId": 947,
      "TicketStatus": 327,
      "Title": "voluptate",
      "Registered": "2022-01-19T16:32:39.5240522+01:00",
      "IconHint": "corporis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 715,
      "DocumentId": 172,
      "Date": "2017-12-05T16:32:39.5240522+01:00",
      "Description": "Triple-buffered radical function",
      "Completed": "Completed",
      "Registered": "2008-09-29T16:32:39.5240522+02:00"
    },
    {
      "AppointmentId": 715,
      "DocumentId": 172,
      "Date": "2017-12-05T16:32:39.5240522+01:00",
      "Description": "Triple-buffered radical function",
      "Completed": "Completed",
      "Registered": "2008-09-29T16:32:39.5240522+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 925,
      "DocumentId": 81,
      "Date": "2005-09-04T16:32:39.5240522+02:00",
      "Description": "Versatile responsive concept",
      "Completed": "Completed",
      "Registered": "2010-09-22T16:32:39.5240522+02:00"
    },
    {
      "AppointmentId": 925,
      "DocumentId": 81,
      "Date": "2005-09-04T16:32:39.5240522+02:00",
      "Description": "Versatile responsive concept",
      "Completed": "Completed",
      "Registered": "2010-09-22T16:32:39.5240522+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 996,
      "SaleDate": "2006-03-08T16:32:39.5240522+01:00",
      "Probability": 499,
      "Heading": "aliquid",
      "Amount": 2516.602,
      "Currency": "labore",
      "AmountInBaseCurrency": 28908.016,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-08-30T16:32:39.5240522+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 229,
      "Name": "Turner-Ortiz",
      "CompanyName": "Hauck, McKenzie and Weissnat",
      "FirstMessage": "officiis",
      "LastMessage": "sint",
      "WhenRequested": "2014-12-12T16:32:39.5240522+01:00",
      "WhenEnded": "2000-01-24T16:32:39.5240522+01:00"
    }
  ]
}
```