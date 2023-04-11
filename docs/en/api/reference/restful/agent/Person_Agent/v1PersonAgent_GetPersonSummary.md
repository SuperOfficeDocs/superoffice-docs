---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
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
  "PersonId": 237,
  "Limit": 519
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
      "TicketId": 179,
      "TicketStatus": 565,
      "Title": "delectus",
      "Registered": "2019-10-29T15:29:22.3372681+01:00",
      "IconHint": "libero"
    },
    {
      "TicketId": 179,
      "TicketStatus": 565,
      "Title": "delectus",
      "Registered": "2019-10-29T15:29:22.3372681+01:00",
      "IconHint": "libero"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 14,
      "DocumentId": 248,
      "Date": "2001-02-26T15:29:22.3372681+01:00",
      "Description": "Ameliorated client-driven extranet",
      "Completed": "Completed",
      "Registered": "2000-06-10T15:29:22.3372681+02:00"
    },
    {
      "AppointmentId": 14,
      "DocumentId": 248,
      "Date": "2001-02-26T15:29:22.3372681+01:00",
      "Description": "Ameliorated client-driven extranet",
      "Completed": "Completed",
      "Registered": "2000-06-10T15:29:22.3372681+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 142,
      "DocumentId": 319,
      "Date": "2018-09-15T15:29:22.3372681+02:00",
      "Description": "Progressive grid-enabled collaboration",
      "Completed": "Completed",
      "Registered": "2000-02-24T15:29:22.3372681+01:00"
    },
    {
      "AppointmentId": 142,
      "DocumentId": 319,
      "Date": "2018-09-15T15:29:22.3372681+02:00",
      "Description": "Progressive grid-enabled collaboration",
      "Completed": "Completed",
      "Registered": "2000-02-24T15:29:22.3372681+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 273,
      "SaleDate": "2002-06-08T15:29:22.3372681+02:00",
      "Probability": 848,
      "Heading": "vel",
      "Amount": 19578.097999999998,
      "Currency": "quos",
      "AmountInBaseCurrency": 9762.41,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-07-23T15:29:22.3372681+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 59,
      "Name": "Nader-Hudson",
      "CompanyName": "Goldner-Luettgen",
      "FirstMessage": "ut",
      "LastMessage": "sit",
      "WhenRequested": "2008-03-15T15:29:22.3372681+01:00",
      "WhenEnded": "2017-04-06T15:29:22.3372681+02:00"
    }
  ]
}
```