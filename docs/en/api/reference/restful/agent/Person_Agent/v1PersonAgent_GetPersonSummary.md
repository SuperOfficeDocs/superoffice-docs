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
  "PersonId": 589,
  "Limit": 710
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
      "TicketId": 364,
      "TicketStatus": 438,
      "Title": "dolorem",
      "Registered": "2018-08-09T23:03:56.5351219+02:00",
      "IconHint": "autem"
    },
    {
      "TicketId": 364,
      "TicketStatus": 438,
      "Title": "dolorem",
      "Registered": "2018-08-09T23:03:56.5351219+02:00",
      "IconHint": "autem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 390,
      "DocumentId": 532,
      "Date": "2015-05-29T23:03:56.5351219+02:00",
      "Description": "Monitored didactic firmware",
      "Completed": "Completed",
      "Registered": "2006-08-12T23:03:56.5351219+02:00"
    },
    {
      "AppointmentId": 390,
      "DocumentId": 532,
      "Date": "2015-05-29T23:03:56.5351219+02:00",
      "Description": "Monitored didactic firmware",
      "Completed": "Completed",
      "Registered": "2006-08-12T23:03:56.5351219+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 231,
      "DocumentId": 870,
      "Date": "2008-06-14T23:03:56.5351219+02:00",
      "Description": "Universal bandwidth-monitored utilisation",
      "Completed": "Completed",
      "Registered": "2008-10-10T23:03:56.5351219+02:00"
    },
    {
      "AppointmentId": 231,
      "DocumentId": 870,
      "Date": "2008-06-14T23:03:56.5351219+02:00",
      "Description": "Universal bandwidth-monitored utilisation",
      "Completed": "Completed",
      "Registered": "2008-10-10T23:03:56.5351219+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 456,
      "SaleDate": "2007-07-21T23:03:56.5351219+02:00",
      "Probability": 232,
      "Heading": "numquam",
      "Amount": 23432.917999999998,
      "Currency": "dolores",
      "AmountInBaseCurrency": 17926.48,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-02-17T23:03:56.5351219+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 584,
      "Name": "Marquardt LLC",
      "CompanyName": "Kunze-Gutmann",
      "FirstMessage": "at",
      "LastMessage": "laboriosam",
      "WhenRequested": "2005-01-06T23:03:56.5351219+01:00",
      "WhenEnded": "2012-06-13T23:03:56.5351219+02:00"
    }
  ]
}
```