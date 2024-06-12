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
  "PersonId": 5,
  "Limit": 501
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
      "TicketId": 970,
      "TicketStatus": 319,
      "Title": "vitae",
      "Registered": "2009-05-03T04:22:27.2372418+02:00",
      "IconHint": "quae"
    },
    {
      "TicketId": 970,
      "TicketStatus": 319,
      "Title": "vitae",
      "Registered": "2009-05-03T04:22:27.2372418+02:00",
      "IconHint": "quae"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 500,
      "DocumentId": 428,
      "Date": "2015-08-08T04:22:27.2372418+02:00",
      "Description": "Organized encompassing productivity",
      "Completed": "Completed",
      "Registered": "2003-01-03T04:22:27.2372418+01:00"
    },
    {
      "AppointmentId": 500,
      "DocumentId": 428,
      "Date": "2015-08-08T04:22:27.2372418+02:00",
      "Description": "Organized encompassing productivity",
      "Completed": "Completed",
      "Registered": "2003-01-03T04:22:27.2372418+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 296,
      "DocumentId": 17,
      "Date": "2003-09-11T04:22:27.2372418+02:00",
      "Description": "Multi-lateral composite extranet",
      "Completed": "Completed",
      "Registered": "2014-11-21T04:22:27.2372418+01:00"
    },
    {
      "AppointmentId": 296,
      "DocumentId": 17,
      "Date": "2003-09-11T04:22:27.2372418+02:00",
      "Description": "Multi-lateral composite extranet",
      "Completed": "Completed",
      "Registered": "2014-11-21T04:22:27.2372418+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 606,
      "SaleDate": "1998-10-15T04:22:27.2372418+02:00",
      "Probability": 775,
      "Heading": "quo",
      "Amount": 9157.5479999999989,
      "Currency": "nihil",
      "AmountInBaseCurrency": 2591.8179999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1997-09-18T04:22:27.2372418+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 603,
      "Name": "Dickens-Kihn",
      "CompanyName": "Anderson-Friesen",
      "FirstMessage": "vel",
      "LastMessage": "dolores",
      "WhenRequested": "2023-03-10T04:22:27.2372418+01:00",
      "WhenEnded": "2004-01-02T04:22:27.2372418+01:00"
    }
  ]
}
```