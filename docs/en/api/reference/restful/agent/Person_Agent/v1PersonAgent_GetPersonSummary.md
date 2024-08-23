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
  "PersonId": 672,
  "Limit": 753
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
      "TicketId": 937,
      "TicketStatus": 10,
      "Title": "eveniet",
      "Registered": "2020-11-03T13:28:23.2262104+01:00",
      "IconHint": "quibusdam"
    },
    {
      "TicketId": 937,
      "TicketStatus": 10,
      "Title": "eveniet",
      "Registered": "2020-11-03T13:28:23.2262104+01:00",
      "IconHint": "quibusdam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 994,
      "DocumentId": 290,
      "Date": "2001-06-12T13:28:23.2262104+02:00",
      "Description": "Cloned coherent system engine",
      "Completed": "Completed",
      "Registered": "2003-07-21T13:28:23.2262104+02:00"
    },
    {
      "AppointmentId": 994,
      "DocumentId": 290,
      "Date": "2001-06-12T13:28:23.2262104+02:00",
      "Description": "Cloned coherent system engine",
      "Completed": "Completed",
      "Registered": "2003-07-21T13:28:23.2262104+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 618,
      "DocumentId": 155,
      "Date": "2014-07-09T13:28:23.2262104+02:00",
      "Description": "Programmable value-added capability",
      "Completed": "Completed",
      "Registered": "2015-11-08T13:28:23.2262104+01:00"
    },
    {
      "AppointmentId": 618,
      "DocumentId": 155,
      "Date": "2014-07-09T13:28:23.2262104+02:00",
      "Description": "Programmable value-added capability",
      "Completed": "Completed",
      "Registered": "2015-11-08T13:28:23.2262104+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 25,
      "SaleDate": "1998-06-09T13:28:23.2262104+02:00",
      "Probability": 753,
      "Heading": "laborum",
      "Amount": 8593.428,
      "Currency": "harum",
      "AmountInBaseCurrency": 8584.026,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-10-12T13:28:23.2262104+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 787,
      "Name": "Stoltenberg-Hessel",
      "CompanyName": "Daniel, Rau and Kiehn",
      "FirstMessage": "voluptatum",
      "LastMessage": "dicta",
      "WhenRequested": "2024-07-08T13:28:23.2262104+02:00",
      "WhenEnded": "2014-07-12T13:28:23.2262104+02:00"
    }
  ]
}
```