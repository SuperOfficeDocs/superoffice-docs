---
title: GET User/currentPrincipal
uid: v1User_GetCurrentPrincipal
---

# GET User/currentPrincipal

```http
GET /api/v1/User/currentPrincipal
```

Gets the currently logged in user's information, even in Online.


Does not call an agent - just returns the current session info.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RecurrenceInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| Associate | string |  |
| AssociateId | int32 |  |
| IsPerson | bool |  |
| PersonId | int32 |  |
| CountryId | int32 |  |
| HomeCountryId | int32 |  |
| ContactId | int32 |  |
| GroupId | int32 |  |
| BusinessId | int32 |  |
| CategoryId | int32 |  |
| ContactOwner | int32 |  |
| RoleId | int32 |  |
| RoleName | string |  |
| RoleDescription | string |  |
| RoleType | string |  |
| Licenses | array |  |
| FullName | string |  |
| EMailAddress | string |  |
| FunctionRights | array |  |
| EjUserId | int32 |  |
| EjAccessLevel | int32 |  |
| EjUserStatus | string |  |
| ProvidedCredentials | array |  |
| SecondaryGroups | array |  |
| DatabaseContextIdentifier | string |  |
| UserName | string |  |

## Sample request

```http!
GET /api/v1/User/currentPrincipal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "ducimus",
  "AssociateId": 623,
  "IsPerson": false,
  "PersonId": 402,
  "CountryId": 429,
  "HomeCountryId": 873,
  "ContactId": 558,
  "GroupId": 409,
  "BusinessId": 432,
  "CategoryId": 346,
  "ContactOwner": 491,
  "RoleId": 961,
  "RoleName": "Olson, Witting and Heidenreich",
  "RoleDescription": "De-engineered methodical workforce",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 787,
      "OwnerName": "Dicki, Thiel and Schumm",
      "OwnerDescription": "Networked modular initiative",
      "ModuleId": 581,
      "Name": "Luettgen, Stroman and Berge",
      "Description": "Distributed multi-tasking function",
      "Version": "eos",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 320,
      "ExtraInfo": "dignissimos",
      "SortOrder": 382,
      "LicenseNumber": 818,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "1996-03-19T11:22:45.5379661+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "FullName": "Guillermo Olson",
  "EMailAddress": "sunt",
  "FunctionRights": [
    "iste",
    "et"
  ],
  "EjUserId": 497,
  "EjAccessLevel": 929,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "id",
      "SearchName": "Shields, Stamm and Schowalter",
      "DisplayName": "Krajcik-Ernser",
      "CredentialId": 362
    },
    {
      "Type": "id",
      "SearchName": "Shields, Stamm and Schowalter",
      "DisplayName": "Krajcik-Ernser",
      "CredentialId": 362
    }
  ],
  "SecondaryGroups": [
    338,
    460
  ],
  "DatabaseContextIdentifier": "quasi",
  "UserName": "Sporer Inc and Sons"
}
```