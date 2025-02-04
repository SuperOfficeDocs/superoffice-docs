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
  "PersonId": 556,
  "Limit": 226
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
      "TicketId": 276,
      "TicketStatus": 38,
      "Title": "consequatur",
      "Registered": "2013-12-19T13:13:23.539495+01:00",
      "IconHint": "velit"
    },
    {
      "TicketId": 276,
      "TicketStatus": 38,
      "Title": "consequatur",
      "Registered": "2013-12-19T13:13:23.539495+01:00",
      "IconHint": "velit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 123,
      "DocumentId": 423,
      "Date": "2007-03-26T13:13:23.539495+02:00",
      "Description": "Proactive fresh-thinking hardware",
      "Completed": "Completed",
      "Registered": "2010-05-31T13:13:23.539495+02:00"
    },
    {
      "AppointmentId": 123,
      "DocumentId": 423,
      "Date": "2007-03-26T13:13:23.539495+02:00",
      "Description": "Proactive fresh-thinking hardware",
      "Completed": "Completed",
      "Registered": "2010-05-31T13:13:23.539495+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 274,
      "DocumentId": 470,
      "Date": "2008-08-22T13:13:23.539495+02:00",
      "Description": "Operative multi-state success",
      "Completed": "Completed",
      "Registered": "2006-07-12T13:13:23.539495+02:00"
    },
    {
      "AppointmentId": 274,
      "DocumentId": 470,
      "Date": "2008-08-22T13:13:23.539495+02:00",
      "Description": "Operative multi-state success",
      "Completed": "Completed",
      "Registered": "2006-07-12T13:13:23.539495+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 166,
      "SaleDate": "2024-05-20T13:13:23.539495+02:00",
      "Probability": 597,
      "Heading": "sunt",
      "Amount": 4017.788,
      "Currency": "eum",
      "AmountInBaseCurrency": 1294.3419999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-07-08T13:13:23.539495+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 456,
      "Name": "Daugherty Group",
      "CompanyName": "Kreiger-Bergstrom",
      "FirstMessage": "est",
      "LastMessage": "labore",
      "WhenRequested": "2019-03-29T13:13:23.539495+01:00",
      "WhenEnded": "2001-08-26T13:13:23.539495+02:00"
    }
  ]
}
```