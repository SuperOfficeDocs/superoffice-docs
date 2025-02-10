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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 810,
  "Limit": 171
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
      "TicketId": 769,
      "TicketStatus": 444,
      "Title": "possimus",
      "Registered": "2011-02-01T12:01:28.0878022+01:00",
      "IconHint": "excepturi"
    },
    {
      "TicketId": 769,
      "TicketStatus": 444,
      "Title": "possimus",
      "Registered": "2011-02-01T12:01:28.0878022+01:00",
      "IconHint": "excepturi"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 749,
      "DocumentId": 492,
      "Date": "2014-04-16T12:01:28.0878022+02:00",
      "Description": "Fundamental 3rd generation throughput",
      "Completed": "Completed",
      "Registered": "2002-10-26T12:01:28.0878022+02:00"
    },
    {
      "AppointmentId": 749,
      "DocumentId": 492,
      "Date": "2014-04-16T12:01:28.0878022+02:00",
      "Description": "Fundamental 3rd generation throughput",
      "Completed": "Completed",
      "Registered": "2002-10-26T12:01:28.0878022+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 708,
      "DocumentId": 299,
      "Date": "2008-07-19T12:01:28.0878022+02:00",
      "Description": "Organized foreground product",
      "Completed": "Completed",
      "Registered": "2007-07-21T12:01:28.0878022+02:00"
    },
    {
      "AppointmentId": 708,
      "DocumentId": 299,
      "Date": "2008-07-19T12:01:28.0878022+02:00",
      "Description": "Organized foreground product",
      "Completed": "Completed",
      "Registered": "2007-07-21T12:01:28.0878022+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 374,
      "SaleDate": "2021-07-09T12:01:28.0878022+02:00",
      "Probability": 538,
      "Heading": "rem",
      "Amount": 4400.1359999999995,
      "Currency": "error",
      "AmountInBaseCurrency": 7954.092,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-08-28T12:01:28.0878022+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 427,
      "Name": "Schumm LLC",
      "CompanyName": "Keebler-Sporer",
      "FirstMessage": "accusantium",
      "LastMessage": "ea",
      "WhenRequested": "2009-02-17T12:01:28.0878022+01:00",
      "WhenEnded": "2016-08-04T12:01:28.0878022+02:00"
    }
  ]
}
```