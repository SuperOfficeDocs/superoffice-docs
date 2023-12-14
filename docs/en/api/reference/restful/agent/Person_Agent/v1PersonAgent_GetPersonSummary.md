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
  "PersonId": 921,
  "Limit": 834
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
      "TicketStatus": 177,
      "Title": "cupiditate",
      "Registered": "2002-01-09T13:57:12.7474482+01:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 125,
      "TicketStatus": 177,
      "Title": "cupiditate",
      "Registered": "2002-01-09T13:57:12.7474482+01:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 229,
      "DocumentId": 616,
      "Date": "1997-12-12T13:57:12.7474482+01:00",
      "Description": "Team-oriented bottom-line forecast",
      "Completed": "Completed",
      "Registered": "2001-05-22T13:57:12.7474482+02:00"
    },
    {
      "AppointmentId": 229,
      "DocumentId": 616,
      "Date": "1997-12-12T13:57:12.7474482+01:00",
      "Description": "Team-oriented bottom-line forecast",
      "Completed": "Completed",
      "Registered": "2001-05-22T13:57:12.7474482+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 835,
      "DocumentId": 203,
      "Date": "2018-05-20T13:57:12.7474482+02:00",
      "Description": "Inverse zero tolerance software",
      "Completed": "Completed",
      "Registered": "2001-04-28T13:57:12.7474482+02:00"
    },
    {
      "AppointmentId": 835,
      "DocumentId": 203,
      "Date": "2018-05-20T13:57:12.7474482+02:00",
      "Description": "Inverse zero tolerance software",
      "Completed": "Completed",
      "Registered": "2001-04-28T13:57:12.7474482+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 733,
      "SaleDate": "2002-05-08T13:57:12.7474482+02:00",
      "Probability": 590,
      "Heading": "alias",
      "Amount": 1642.216,
      "Currency": "dolorem",
      "AmountInBaseCurrency": 5628.664,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-09-04T13:57:12.7474482+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 814,
      "Name": "Bartoletti Inc and Sons",
      "CompanyName": "Christiansen-Greenfelder",
      "FirstMessage": "corrupti",
      "LastMessage": "quia",
      "WhenRequested": "2023-02-03T13:57:12.7474482+01:00",
      "WhenEnded": "2022-03-19T13:57:12.7474482+01:00"
    }
  ]
}
```