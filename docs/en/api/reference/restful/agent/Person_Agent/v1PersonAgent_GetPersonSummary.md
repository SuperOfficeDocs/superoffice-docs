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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 5,
  "Limit": 653
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
      "TicketId": 128,
      "TicketStatus": 520,
      "Title": "et",
      "Registered": "2014-07-11T10:17:55.8478039+02:00",
      "IconHint": "magni"
    },
    {
      "TicketId": 128,
      "TicketStatus": 520,
      "Title": "et",
      "Registered": "2014-07-11T10:17:55.8478039+02:00",
      "IconHint": "magni"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 189,
      "DocumentId": 398,
      "Date": "2013-06-09T10:17:55.8478039+02:00",
      "Description": "Reactive interactive groupware",
      "Completed": "Completed",
      "Registered": "2008-11-22T10:17:55.8478039+01:00"
    },
    {
      "AppointmentId": 189,
      "DocumentId": 398,
      "Date": "2013-06-09T10:17:55.8478039+02:00",
      "Description": "Reactive interactive groupware",
      "Completed": "Completed",
      "Registered": "2008-11-22T10:17:55.8478039+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 493,
      "DocumentId": 230,
      "Date": "2015-09-30T10:17:55.8478039+02:00",
      "Description": "Front-line scalable algorithm",
      "Completed": "Completed",
      "Registered": "2002-11-10T10:17:55.8478039+01:00"
    },
    {
      "AppointmentId": 493,
      "DocumentId": 230,
      "Date": "2015-09-30T10:17:55.8478039+02:00",
      "Description": "Front-line scalable algorithm",
      "Completed": "Completed",
      "Registered": "2002-11-10T10:17:55.8478039+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 515,
      "SaleDate": "2018-03-20T10:17:55.8478039+01:00",
      "Probability": 835,
      "Heading": "et",
      "Amount": 6293.072,
      "Currency": "et",
      "AmountInBaseCurrency": 3610.368,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2024-07-19T10:17:55.8478039+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 362,
      "Name": "Eichmann-Koch",
      "CompanyName": "Barrows-Wyman",
      "FirstMessage": "voluptatum",
      "LastMessage": "voluptate",
      "WhenRequested": "2017-12-25T10:17:55.8478039+01:00",
      "WhenEnded": "2020-06-30T10:17:55.8478039+02:00"
    }
  ]
}
```