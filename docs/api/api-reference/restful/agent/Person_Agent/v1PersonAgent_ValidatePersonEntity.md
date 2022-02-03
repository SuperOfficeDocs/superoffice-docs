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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": {
    "PersonId": 244,
    "Firstname": "Clara",
    "MiddleName": "Gleason-Mertz",
    "Lastname": "Carter",
    "Mrmrs": "vel",
    "Title": "est",
    "UpdatedDate": "2019-02-19T18:28:49.4990899+01:00",
    "CreatedDate": "1995-04-12T18:28:49.4990899+02:00",
    "BirthDate": "2017-04-20T18:28:49.4990899+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Customizable multimedia focus group",
    "IsAssociate": true,
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
    "PersonNumber": "384628",
    "FullName": "Mariela Kovacek",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": false,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Tremblay-Schoen",
    "Address": {},
    "Post3": "praesentium",
    "Post2": "neque",
    "Post1": "rerum",
    "Kanalname": "voluptas",
    "Kanafname": "laborum",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "nihil",
    "ActiveInterests": 860,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 999,
    "DbiKey": "mollitia",
    "DbiLastModified": "2014-11-09T18:28:49.5000904+01:00",
    "DbiLastSyncronized": "2005-02-08T18:28:49.5000904+01:00",
    "SentInfo": 441,
    "ShowContactTickets": 684,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 682,
    "ActiveErpLinks": 615,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "august.treutel@runteaufderhar.ca",
      "antonina.batz@skiles.name"
    ],
    "ActiveStatusMonitorId": 971,
    "UserDefinedFields": {
      "SuperOffice:1": "Melba Koepp",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "minima",
      "ExtraFields2": "est"
    },
    "CustomFields": {
      "CustomFields1": "vitae",
      "CustomFields2": "consequuntur"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "voluptate",
  "2": "qui"
}
```