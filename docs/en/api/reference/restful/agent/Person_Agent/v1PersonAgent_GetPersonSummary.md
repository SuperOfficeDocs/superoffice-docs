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
  "PersonId": 959,
  "Limit": 575
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
      "TicketId": 602,
      "TicketStatus": 49,
      "Title": "eligendi",
      "Registered": "2011-09-19T02:38:21.6670086+02:00",
      "IconHint": "qui"
    },
    {
      "TicketId": 602,
      "TicketStatus": 49,
      "Title": "eligendi",
      "Registered": "2011-09-19T02:38:21.6670086+02:00",
      "IconHint": "qui"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 204,
      "DocumentId": 48,
      "Date": "2005-06-23T02:38:21.6670086+02:00",
      "Description": "Re-engineered multi-tasking infrastructure",
      "Completed": "Completed",
      "Registered": "2005-03-25T02:38:21.6670086+01:00"
    },
    {
      "AppointmentId": 204,
      "DocumentId": 48,
      "Date": "2005-06-23T02:38:21.6670086+02:00",
      "Description": "Re-engineered multi-tasking infrastructure",
      "Completed": "Completed",
      "Registered": "2005-03-25T02:38:21.6670086+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 163,
      "DocumentId": 587,
      "Date": "2007-01-27T02:38:21.6670086+01:00",
      "Description": "Visionary assymetric local area network",
      "Completed": "Completed",
      "Registered": "1998-10-05T02:38:21.6670086+02:00"
    },
    {
      "AppointmentId": 163,
      "DocumentId": 587,
      "Date": "2007-01-27T02:38:21.6670086+01:00",
      "Description": "Visionary assymetric local area network",
      "Completed": "Completed",
      "Registered": "1998-10-05T02:38:21.6670086+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 114,
      "SaleDate": "2007-06-02T02:38:21.6670086+02:00",
      "Probability": 143,
      "Heading": "voluptatem",
      "Amount": 7737.846,
      "Currency": "necessitatibus",
      "AmountInBaseCurrency": 14761.14,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2024-08-22T02:38:21.6670086+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 509,
      "Name": "Ondricka, Quigley and Upton",
      "CompanyName": "Grady-Bradtke",
      "FirstMessage": "et",
      "LastMessage": "quasi",
      "WhenRequested": "2017-12-07T02:38:21.6670086+01:00",
      "WhenEnded": "2005-02-11T02:38:21.6670086+01:00"
    }
  ]
}
```