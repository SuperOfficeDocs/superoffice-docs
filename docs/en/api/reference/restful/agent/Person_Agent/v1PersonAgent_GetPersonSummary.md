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
  "PersonId": 354,
  "Limit": 670
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
      "TicketId": 188,
      "TicketStatus": 695,
      "Title": "sit",
      "Registered": "2004-06-05T16:00:41.4457134+02:00",
      "IconHint": "error"
    },
    {
      "TicketId": 188,
      "TicketStatus": 695,
      "Title": "sit",
      "Registered": "2004-06-05T16:00:41.4457134+02:00",
      "IconHint": "error"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 781,
      "DocumentId": 453,
      "Date": "2020-09-19T16:00:41.4457134+02:00",
      "Description": "Profound bandwidth-monitored data-warehouse",
      "Completed": "Completed",
      "Registered": "2014-01-22T16:00:41.4457134+01:00"
    },
    {
      "AppointmentId": 781,
      "DocumentId": 453,
      "Date": "2020-09-19T16:00:41.4457134+02:00",
      "Description": "Profound bandwidth-monitored data-warehouse",
      "Completed": "Completed",
      "Registered": "2014-01-22T16:00:41.4457134+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 407,
      "DocumentId": 834,
      "Date": "2015-06-05T16:00:41.4457134+02:00",
      "Description": "Managed foreground strategy",
      "Completed": "Completed",
      "Registered": "2002-03-14T16:00:41.4457134+01:00"
    },
    {
      "AppointmentId": 407,
      "DocumentId": 834,
      "Date": "2015-06-05T16:00:41.4457134+02:00",
      "Description": "Managed foreground strategy",
      "Completed": "Completed",
      "Registered": "2002-03-14T16:00:41.4457134+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 267,
      "SaleDate": "2009-01-26T16:00:41.4457134+01:00",
      "Probability": 764,
      "Heading": "aut",
      "Amount": 30177.286,
      "Currency": "ut",
      "AmountInBaseCurrency": 11367.018,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1999-08-15T16:00:41.4457134+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 56,
      "Name": "Thompson LLC",
      "CompanyName": "Murray-Watsica",
      "FirstMessage": "esse",
      "LastMessage": "et",
      "WhenRequested": "2007-05-21T16:00:41.4457134+02:00",
      "WhenEnded": "1998-03-26T16:00:41.4457134+01:00"
    }
  ]
}
```