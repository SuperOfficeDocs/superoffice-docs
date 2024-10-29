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
  "PersonId": 492,
  "Limit": 131
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
      "TicketId": 618,
      "TicketStatus": 707,
      "Title": "itaque",
      "Registered": "2000-07-10T13:14:06.2101751+02:00",
      "IconHint": "in"
    },
    {
      "TicketId": 618,
      "TicketStatus": 707,
      "Title": "itaque",
      "Registered": "2000-07-10T13:14:06.2101751+02:00",
      "IconHint": "in"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 293,
      "DocumentId": 156,
      "Date": "2023-10-19T13:14:06.2101751+02:00",
      "Description": "Pre-emptive needs-based success",
      "Completed": "Completed",
      "Registered": "2002-02-23T13:14:06.2101751+01:00"
    },
    {
      "AppointmentId": 293,
      "DocumentId": 156,
      "Date": "2023-10-19T13:14:06.2101751+02:00",
      "Description": "Pre-emptive needs-based success",
      "Completed": "Completed",
      "Registered": "2002-02-23T13:14:06.2101751+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 892,
      "DocumentId": 190,
      "Date": "2006-02-18T13:14:06.2101751+01:00",
      "Description": "Exclusive asynchronous paradigm",
      "Completed": "Completed",
      "Registered": "2016-12-06T13:14:06.2101751+01:00"
    },
    {
      "AppointmentId": 892,
      "DocumentId": 190,
      "Date": "2006-02-18T13:14:06.2101751+01:00",
      "Description": "Exclusive asynchronous paradigm",
      "Completed": "Completed",
      "Registered": "2016-12-06T13:14:06.2101751+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 268,
      "SaleDate": "2003-06-16T13:14:06.2101751+02:00",
      "Probability": 3,
      "Heading": "qui",
      "Amount": 22802.984,
      "Currency": "molestias",
      "AmountInBaseCurrency": 29644.505999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-05-22T13:14:06.2258011+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 959,
      "Name": "Fritsch-Kunze",
      "CompanyName": "Bayer Group",
      "FirstMessage": "maiores",
      "LastMessage": "deserunt",
      "WhenRequested": "2019-05-27T13:14:06.2258011+02:00",
      "WhenEnded": "2019-11-08T13:14:06.2258011+01:00"
    }
  ]
}
```