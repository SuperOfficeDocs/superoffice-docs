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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 916,
  "Limit": 261
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
      "TicketId": 797,
      "TicketStatus": 540,
      "Title": "commodi",
      "Registered": "2003-04-13T03:51:27.8340855+02:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 797,
      "TicketStatus": 540,
      "Title": "commodi",
      "Registered": "2003-04-13T03:51:27.8340855+02:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 798,
      "DocumentId": 368,
      "Date": "1997-07-21T03:51:27.8340855+02:00",
      "Description": "Centralized solution-oriented intranet",
      "Completed": "Completed",
      "Registered": "2006-08-13T03:51:27.8340855+02:00"
    },
    {
      "AppointmentId": 798,
      "DocumentId": 368,
      "Date": "1997-07-21T03:51:27.8340855+02:00",
      "Description": "Centralized solution-oriented intranet",
      "Completed": "Completed",
      "Registered": "2006-08-13T03:51:27.8340855+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 318,
      "DocumentId": 697,
      "Date": "2005-12-06T03:51:27.8340855+01:00",
      "Description": "Reactive next generation open architecture",
      "Completed": "Completed",
      "Registered": "2009-03-26T03:51:27.8340855+01:00"
    },
    {
      "AppointmentId": 318,
      "DocumentId": 697,
      "Date": "2005-12-06T03:51:27.8340855+01:00",
      "Description": "Reactive next generation open architecture",
      "Completed": "Completed",
      "Registered": "2009-03-26T03:51:27.8340855+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 678,
      "SaleDate": "2007-11-19T03:51:27.8340855+01:00",
      "Probability": 110,
      "Heading": "qui",
      "Amount": 11780.706,
      "Currency": "dolores",
      "AmountInBaseCurrency": 9251.568,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-01-13T03:51:27.8340855+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 594,
      "Name": "Kilback-Dicki",
      "CompanyName": "Green, Cruickshank and Terry",
      "FirstMessage": "quisquam",
      "LastMessage": "qui",
      "WhenRequested": "2015-06-26T03:51:27.8340855+02:00",
      "WhenEnded": "2010-01-23T03:51:27.8340855+01:00"
    }
  ]
}
```