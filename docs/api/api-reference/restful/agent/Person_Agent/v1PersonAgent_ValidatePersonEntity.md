---
title: ValidatePersonEntity
id: v1PersonAgent_ValidatePersonEntity
---

# ValidatePersonEntity

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
    "PersonId": 205,
    "Firstname": "Anjali",
    "MiddleName": "Hodkiewicz, Paucek and Kertzmann",
    "Lastname": "Feil",
    "Mrmrs": "et",
    "Title": "iure",
    "UpdatedDate": "2021-02-04T14:58:04.5824658+01:00",
    "CreatedDate": "2011-08-13T14:58:04.5824658+02:00",
    "BirthDate": "2001-01-14T14:58:04.5824658+01:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Diverse empowering definition",
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
    "PersonNumber": "962726",
    "FullName": "Josiah Renner",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Paucek-Miller",
    "Address": {},
    "Post3": "ut",
    "Post2": "harum",
    "Post1": "repellendus",
    "Kanalname": "esse",
    "Kanafname": "autem",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "a",
    "ActiveInterests": 259,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 636,
    "DbiKey": "similique",
    "DbiLastModified": "2015-01-28T14:58:04.5824658+01:00",
    "DbiLastSyncronized": "2000-01-18T14:58:04.5824658+01:00",
    "SentInfo": 753,
    "ShowContactTickets": 50,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 560,
    "ActiveErpLinks": 954,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "delaney_langworth@hartmann.uk",
      "kaya.turcotte@borer.name"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Maxime McKenzie",
      "SuperOffice:2": "Marquis Jewess"
    },
    "ExtraFields": {
      "ExtraFields1": "atque",
      "ExtraFields2": "quidem"
    },
    "CustomFields": {
      "CustomFields1": "quasi",
      "CustomFields2": "ab"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "officia"
}
```