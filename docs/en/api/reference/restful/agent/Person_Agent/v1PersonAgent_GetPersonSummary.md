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
  "PersonId": 3,
  "Limit": 491
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
      "TicketId": 243,
      "TicketStatus": 461,
      "Title": "accusamus",
      "Registered": "2002-04-16T13:14:00.8450786+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 243,
      "TicketStatus": 461,
      "Title": "accusamus",
      "Registered": "2002-04-16T13:14:00.8450786+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 540,
      "DocumentId": 263,
      "Date": "2011-02-15T13:14:00.8450786+01:00",
      "Description": "User-centric high-level model",
      "Completed": "Completed",
      "Registered": "2011-01-07T13:14:00.8450786+01:00"
    },
    {
      "AppointmentId": 540,
      "DocumentId": 263,
      "Date": "2011-02-15T13:14:00.8450786+01:00",
      "Description": "User-centric high-level model",
      "Completed": "Completed",
      "Registered": "2011-01-07T13:14:00.8450786+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 739,
      "DocumentId": 382,
      "Date": "2014-11-23T13:14:00.8450786+01:00",
      "Description": "Networked system-worthy challenge",
      "Completed": "Completed",
      "Registered": "2019-12-01T13:14:00.8450786+01:00"
    },
    {
      "AppointmentId": 739,
      "DocumentId": 382,
      "Date": "2014-11-23T13:14:00.8450786+01:00",
      "Description": "Networked system-worthy challenge",
      "Completed": "Completed",
      "Registered": "2019-12-01T13:14:00.8450786+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 880,
      "SaleDate": "2008-02-03T13:14:00.8450786+01:00",
      "Probability": 990,
      "Heading": "aut",
      "Amount": 16751.23,
      "Currency": "veniam",
      "AmountInBaseCurrency": 17208.793999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2005-12-03T13:14:00.8450786+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 588,
      "Name": "Gutmann-Walter",
      "CompanyName": "Kutch, Greenfelder and Lind",
      "FirstMessage": "aperiam",
      "LastMessage": "neque",
      "WhenRequested": "2012-12-13T13:14:00.8450786+01:00",
      "WhenEnded": "2006-09-29T13:14:00.8450786+02:00"
    }
  ]
}
```