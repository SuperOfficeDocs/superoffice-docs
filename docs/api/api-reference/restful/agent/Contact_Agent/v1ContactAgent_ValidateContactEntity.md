---
title: POST Agents/Contact/ValidateContactEntity
id: v1ContactAgent_ValidateContactEntity
---

# POST Agents/Contact/ValidateContactEntity

```http
POST /api/v1/Agents/Contact/ValidateContactEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ValidateContactEntity?$select=name,department,category/id
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

ContactEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Contact/ValidateContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 482,
    "Name": "Bartoletti-Dibbert",
    "Department": "",
    "OrgNr": "983480",
    "Number1": "431924",
    "Number2": "1763896",
    "UpdatedDate": "2012-11-12T18:28:48.6169524+01:00",
    "CreatedDate": "2014-03-20T18:28:48.6169524+01:00",
    "Emails": [
      {},
      {}
    ],
    "Interests": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "Phones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "Description": "Persevering 6th generation firmware",
    "UpdatedBy": {},
    "CreatedBy": {},
    "Associate": {},
    "Business": {},
    "Category": {},
    "Country": {},
    "Persons": [
      {},
      {}
    ],
    "NoMailing": true,
    "Kananame": "voluptatibus",
    "Xstop": false,
    "ActiveInterests": 948,
    "GroupId": 309,
    "ActiveStatusMonitorId": 801,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 193,
    "DbiAgentId": 370,
    "DbiLastSyncronized": "2016-11-06T18:28:48.6169524+01:00",
    "DbiKey": "beatae",
    "DbiLastModified": "2002-08-07T18:28:48.6169524+02:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 433,
    "ActiveErpLinks": 467,
    "BounceEmails": [
      "nelda.klocko@heller.info",
      "gus@grimes.info"
    ],
    "Domains": [
      "enim",
      "eius"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "335276439",
      "SuperOffice:2": "Naomi Spencer PhD"
    },
    "ExtraFields": {
      "ExtraFields1": "quibusdam",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "ea",
      "CustomFields2": "culpa"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "vero",
  "2": "dolor"
}
```