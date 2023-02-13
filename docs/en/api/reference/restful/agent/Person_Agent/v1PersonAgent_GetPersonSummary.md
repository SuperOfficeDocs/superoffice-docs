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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 203,
  "Limit": 472
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
      "TicketId": 25,
      "TicketStatus": 272,
      "Title": "ab",
      "Registered": "2011-12-09T11:22:38.7427255+01:00",
      "IconHint": "sapiente"
    },
    {
      "TicketId": 25,
      "TicketStatus": 272,
      "Title": "ab",
      "Registered": "2011-12-09T11:22:38.7427255+01:00",
      "IconHint": "sapiente"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 204,
      "DocumentId": 48,
      "Date": "1998-04-24T11:22:38.7427255+02:00",
      "Description": "Robust system-worthy focus group",
      "Completed": "Completed",
      "Registered": "2008-06-01T11:22:38.7427255+02:00"
    },
    {
      "AppointmentId": 204,
      "DocumentId": 48,
      "Date": "1998-04-24T11:22:38.7427255+02:00",
      "Description": "Robust system-worthy focus group",
      "Completed": "Completed",
      "Registered": "2008-06-01T11:22:38.7427255+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 100,
      "DocumentId": 330,
      "Date": "2016-07-08T11:22:38.7427255+02:00",
      "Description": "Devolved encompassing array",
      "Completed": "Completed",
      "Registered": "2015-03-21T11:22:38.7427255+01:00"
    },
    {
      "AppointmentId": 100,
      "DocumentId": 330,
      "Date": "2016-07-08T11:22:38.7427255+02:00",
      "Description": "Devolved encompassing array",
      "Completed": "Completed",
      "Registered": "2015-03-21T11:22:38.7427255+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 12,
      "SaleDate": "2018-01-07T11:22:38.7427255+01:00",
      "Probability": 693,
      "Heading": "in",
      "Amount": 26482.3,
      "Currency": "illum",
      "AmountInBaseCurrency": 31205.237999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2002-02-15T11:22:38.7427255+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 396,
      "Name": "Corwin-Jacobson",
      "CompanyName": "Robel-Ritchie",
      "FirstMessage": "dolores",
      "LastMessage": "eos",
      "WhenRequested": "1997-09-13T11:22:38.7427255+02:00",
      "WhenEnded": "2012-12-28T11:22:38.7427255+01:00"
    }
  ]
}
```