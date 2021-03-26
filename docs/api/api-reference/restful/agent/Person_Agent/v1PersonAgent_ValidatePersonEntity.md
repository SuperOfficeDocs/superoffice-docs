---
title: POST Agents/Person/ValidatePersonEntity
id: v1PersonAgent_ValidatePersonEntity
---

# POST Agents/Person/ValidatePersonEntity

```http
POST /api/v1/Agents/Person/ValidatePersonEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ValidatePersonEntity?$select=name,department,category/id
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

PersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity |  |  |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Person/ValidatePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": {
    "PersonId": 530,
    "Firstname": "Pietro",
    "MiddleName": "Bashirian, Schuster and Schulist",
    "Lastname": "Koch",
    "Mrmrs": "rerum",
    "Title": "minima",
    "UpdatedDate": "2004-06-28T16:48:30.1999349+02:00",
    "CreatedDate": "1999-07-10T16:48:30.1999349+02:00",
    "BirthDate": "2018-03-21T16:48:30.1999349+01:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Ameliorated scalable website",
    "IsAssociate": false,
    "PrivatePhones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "MobilePhones": [
      {},
      {}
    ],
    "OfficePhones": [
      {},
      {}
    ],
    "OtherPhones": [
      {},
      {}
    ],
    "Position": {},
    "UpdatedBy": {},
    "Contact": {},
    "Country": {},
    "Interests": [
      {},
      {}
    ],
    "PersonNumber": "1163417",
    "FullName": "Alanis Carter",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Lueilwitz-Bailey",
    "Address": {},
    "Post3": "est",
    "Post2": "rem",
    "Post1": "quia",
    "Kanalname": "et",
    "Kanafname": "ab",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "velit",
    "ActiveInterests": 948,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 402,
    "DbiKey": "et",
    "DbiLastModified": "2004-04-01T16:48:30.1999349+02:00",
    "DbiLastSyncronized": "2007-03-19T16:48:30.1999349+01:00",
    "SentInfo": 319,
    "ShowContactTickets": 730,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 484,
    "ActiveErpLinks": 267,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "stephen.breitenberg@pagacjast.ca",
      "jaren_balistreri@connmorar.com"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Caleb Boyer",
      "SuperOffice:2": "9984020"
    },
    "ExtraFields": {
      "ExtraFields1": "perferendis",
      "ExtraFields2": "commodi"
    },
    "CustomFields": {
      "CustomFields1": "vero",
      "CustomFields2": "voluptatem"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "qui",
  "2": "cumque"
}
```