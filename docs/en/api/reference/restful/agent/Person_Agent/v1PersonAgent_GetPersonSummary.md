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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 960,
  "Limit": 636
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
      "TicketId": 147,
      "TicketStatus": 414,
      "Title": "et",
      "Registered": "2011-06-26T12:15:19.7077409+02:00",
      "IconHint": "saepe"
    },
    {
      "TicketId": 147,
      "TicketStatus": 414,
      "Title": "et",
      "Registered": "2011-06-26T12:15:19.7077409+02:00",
      "IconHint": "saepe"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 906,
      "DocumentId": 764,
      "Date": "1998-10-13T12:15:19.7077409+02:00",
      "Description": "Reduced motivating capacity",
      "Completed": "Completed",
      "Registered": "2003-04-05T12:15:19.7077409+02:00"
    },
    {
      "AppointmentId": 906,
      "DocumentId": 764,
      "Date": "1998-10-13T12:15:19.7077409+02:00",
      "Description": "Reduced motivating capacity",
      "Completed": "Completed",
      "Registered": "2003-04-05T12:15:19.7077409+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 204,
      "DocumentId": 659,
      "Date": "2005-12-16T12:15:19.7077409+01:00",
      "Description": "Diverse empowering matrix",
      "Completed": "Completed",
      "Registered": "1996-05-27T12:15:19.7077409+02:00"
    },
    {
      "AppointmentId": 204,
      "DocumentId": 659,
      "Date": "2005-12-16T12:15:19.7077409+01:00",
      "Description": "Diverse empowering matrix",
      "Completed": "Completed",
      "Registered": "1996-05-27T12:15:19.7077409+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 419,
      "SaleDate": "2010-06-23T12:15:19.7077409+02:00",
      "Probability": 191,
      "Heading": "excepturi",
      "Amount": 14027.784,
      "Currency": "perferendis",
      "AmountInBaseCurrency": 19910.302,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-07-25T12:15:19.7077409+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 767,
      "Name": "Stiedemann, Streich and West",
      "CompanyName": "Predovic-Cummings",
      "FirstMessage": "et",
      "LastMessage": "occaecati",
      "WhenRequested": "1998-04-22T12:15:19.7077409+02:00",
      "WhenEnded": "2012-06-21T12:15:19.7077409+02:00"
    }
  ]
}
```