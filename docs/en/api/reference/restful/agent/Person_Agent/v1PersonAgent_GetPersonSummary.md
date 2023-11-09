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
  "PersonId": 374,
  "Limit": 849
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
      "TicketId": 643,
      "TicketStatus": 646,
      "Title": "qui",
      "Registered": "2017-02-25T11:06:35.0520659+01:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 643,
      "TicketStatus": 646,
      "Title": "qui",
      "Registered": "2017-02-25T11:06:35.0520659+01:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 858,
      "DocumentId": 462,
      "Date": "2013-06-22T11:06:35.0520659+02:00",
      "Description": "Right-sized analyzing infrastructure",
      "Completed": "Completed",
      "Registered": "1996-09-23T11:06:35.0520659+02:00"
    },
    {
      "AppointmentId": 858,
      "DocumentId": 462,
      "Date": "2013-06-22T11:06:35.0520659+02:00",
      "Description": "Right-sized analyzing infrastructure",
      "Completed": "Completed",
      "Registered": "1996-09-23T11:06:35.0520659+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 147,
      "DocumentId": 34,
      "Date": "2003-02-05T11:06:35.0520659+01:00",
      "Description": "Ergonomic reciprocal artificial intelligence",
      "Completed": "Completed",
      "Registered": "2014-06-23T11:06:35.0520659+02:00"
    },
    {
      "AppointmentId": 147,
      "DocumentId": 34,
      "Date": "2003-02-05T11:06:35.0520659+01:00",
      "Description": "Ergonomic reciprocal artificial intelligence",
      "Completed": "Completed",
      "Registered": "2014-06-23T11:06:35.0520659+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 61,
      "SaleDate": "2023-03-22T11:06:35.0520659+01:00",
      "Probability": 25,
      "Heading": "minus",
      "Amount": 11257.328,
      "Currency": "est",
      "AmountInBaseCurrency": 15472.557999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-11-22T11:06:35.0520659+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 451,
      "Name": "Kassulke-Mraz",
      "CompanyName": "Schuppe, Emard and Reilly",
      "FirstMessage": "hic",
      "LastMessage": "aut",
      "WhenRequested": "2023-07-12T11:06:35.0520659+02:00",
      "WhenEnded": "2009-01-14T11:06:35.0520659+01:00"
    }
  ]
}
```