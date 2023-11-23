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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 906,
  "Limit": 808
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
      "TicketId": 125,
      "TicketStatus": 963,
      "Title": "cupiditate",
      "Registered": "2016-11-06T13:38:13.8272279+01:00",
      "IconHint": "distinctio"
    },
    {
      "TicketId": 125,
      "TicketStatus": 963,
      "Title": "cupiditate",
      "Registered": "2016-11-06T13:38:13.8272279+01:00",
      "IconHint": "distinctio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 702,
      "DocumentId": 286,
      "Date": "2022-03-09T13:38:13.8272279+01:00",
      "Description": "Cross-group actuating projection",
      "Completed": "Completed",
      "Registered": "2013-10-06T13:38:13.8272279+02:00"
    },
    {
      "AppointmentId": 702,
      "DocumentId": 286,
      "Date": "2022-03-09T13:38:13.8272279+01:00",
      "Description": "Cross-group actuating projection",
      "Completed": "Completed",
      "Registered": "2013-10-06T13:38:13.8272279+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 627,
      "DocumentId": 823,
      "Date": "2000-08-12T13:38:13.8272279+02:00",
      "Description": "De-engineered global orchestration",
      "Completed": "Completed",
      "Registered": "2009-04-02T13:38:13.8272279+02:00"
    },
    {
      "AppointmentId": 627,
      "DocumentId": 823,
      "Date": "2000-08-12T13:38:13.8272279+02:00",
      "Description": "De-engineered global orchestration",
      "Completed": "Completed",
      "Registered": "2009-04-02T13:38:13.8272279+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 542,
      "SaleDate": "2003-02-05T13:38:13.8272279+01:00",
      "Probability": 987,
      "Heading": "sit",
      "Amount": 10044.47,
      "Currency": "saepe",
      "AmountInBaseCurrency": 9477.216,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-05-23T13:38:13.8272279+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 350,
      "Name": "Casper-Conroy",
      "CompanyName": "O'Kon Inc and Sons",
      "FirstMessage": "tenetur",
      "LastMessage": "ea",
      "WhenRequested": "2018-10-03T13:38:13.8272279+02:00",
      "WhenEnded": "2008-12-26T13:38:13.8272279+01:00"
    }
  ]
}
```