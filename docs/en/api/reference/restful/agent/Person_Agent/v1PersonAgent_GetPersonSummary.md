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
  "PersonId": 456,
  "Limit": 871
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
      "TicketId": 111,
      "TicketStatus": 140,
      "Title": "facilis",
      "Registered": "2013-01-31T11:44:34.1033545+01:00",
      "IconHint": "nostrum"
    },
    {
      "TicketId": 111,
      "TicketStatus": 140,
      "Title": "facilis",
      "Registered": "2013-01-31T11:44:34.1033545+01:00",
      "IconHint": "nostrum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 576,
      "DocumentId": 7,
      "Date": "1999-11-05T11:44:34.1033545+01:00",
      "Description": "Enhanced object-oriented synergy",
      "Completed": "Completed",
      "Registered": "2020-05-08T11:44:34.1033545+02:00"
    },
    {
      "AppointmentId": 576,
      "DocumentId": 7,
      "Date": "1999-11-05T11:44:34.1033545+01:00",
      "Description": "Enhanced object-oriented synergy",
      "Completed": "Completed",
      "Registered": "2020-05-08T11:44:34.1033545+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 817,
      "DocumentId": 930,
      "Date": "2002-10-13T11:44:34.1033545+02:00",
      "Description": "Total stable time-frame",
      "Completed": "Completed",
      "Registered": "2005-06-20T11:44:34.1033545+02:00"
    },
    {
      "AppointmentId": 817,
      "DocumentId": 930,
      "Date": "2002-10-13T11:44:34.1033545+02:00",
      "Description": "Total stable time-frame",
      "Completed": "Completed",
      "Registered": "2005-06-20T11:44:34.1033545+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 607,
      "SaleDate": "2017-10-15T11:44:34.1033545+02:00",
      "Probability": 275,
      "Heading": "consectetur",
      "Amount": 31098.682,
      "Currency": "dicta",
      "AmountInBaseCurrency": 9674.658,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2002-07-03T11:44:34.1033545+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 132,
      "Name": "Heidenreich LLC",
      "CompanyName": "Hand-Upton",
      "FirstMessage": "laboriosam",
      "LastMessage": "illo",
      "WhenRequested": "2011-10-15T11:44:34.1033545+02:00",
      "WhenEnded": "2020-09-06T11:44:34.1033545+02:00"
    }
  ]
}
```