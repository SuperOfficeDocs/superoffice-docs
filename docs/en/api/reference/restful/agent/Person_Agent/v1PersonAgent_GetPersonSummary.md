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
  "PersonId": 816,
  "Limit": 692
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
      "TicketId": 218,
      "TicketStatus": 82,
      "Title": "quibusdam",
      "Registered": "2020-05-17T03:44:52.8551792+02:00",
      "IconHint": "omnis"
    },
    {
      "TicketId": 218,
      "TicketStatus": 82,
      "Title": "quibusdam",
      "Registered": "2020-05-17T03:44:52.8551792+02:00",
      "IconHint": "omnis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 122,
      "DocumentId": 666,
      "Date": "2022-08-17T03:44:52.8551792+02:00",
      "Description": "Devolved 24/7 customer loyalty",
      "Completed": "Completed",
      "Registered": "2014-09-16T03:44:52.8551792+02:00"
    },
    {
      "AppointmentId": 122,
      "DocumentId": 666,
      "Date": "2022-08-17T03:44:52.8551792+02:00",
      "Description": "Devolved 24/7 customer loyalty",
      "Completed": "Completed",
      "Registered": "2014-09-16T03:44:52.8551792+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 811,
      "DocumentId": 644,
      "Date": "1997-12-28T03:44:52.8551792+01:00",
      "Description": "Stand-alone exuding portal",
      "Completed": "Completed",
      "Registered": "2023-08-13T03:44:52.8551792+02:00"
    },
    {
      "AppointmentId": 811,
      "DocumentId": 644,
      "Date": "1997-12-28T03:44:52.8551792+01:00",
      "Description": "Stand-alone exuding portal",
      "Completed": "Completed",
      "Registered": "2023-08-13T03:44:52.8551792+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 66,
      "SaleDate": "2014-06-19T03:44:52.8551792+02:00",
      "Probability": 656,
      "Heading": "quo",
      "Amount": 10906.32,
      "Currency": "non",
      "AmountInBaseCurrency": 30481.284,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-10-20T03:44:52.8551792+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 686,
      "Name": "Ebert-Hills",
      "CompanyName": "Gleichner-Tromp",
      "FirstMessage": "aperiam",
      "LastMessage": "quas",
      "WhenRequested": "2019-07-15T03:44:52.8551792+02:00",
      "WhenEnded": "2000-07-02T03:44:52.8551792+02:00"
    }
  ]
}
```