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

Response body: 

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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "saepe",
  "AssociateId": 996,
  "IsPerson": false,
  "PersonId": 441,
  "CountryId": 976,
  "HomeCountryId": 116,
  "ContactId": 532,
  "GroupId": 687,
  "BusinessId": 566,
  "CategoryId": 837,
  "ContactOwner": 272,
  "RoleId": 755,
  "RoleName": "Schroeder, Kuhic and Botsford",
  "RoleDescription": "Grass-roots real-time portal",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 162,
      "OwnerName": "Jewess, Kub and Bailey",
      "OwnerDescription": "Universal coherent synergy",
      "ModuleId": 65,
      "Name": "Willms, McGlynn and Schmidt",
      "Description": "Vision-oriented executive initiative",
      "Version": "reprehenderit",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 654,
      "ExtraInfo": "nihil",
      "SortOrder": 691,
      "LicenseNumber": 579,
      "IsHidden": false,
      "IsUnrestricted": true,
      "ExpiryDate": "1999-10-26T02:49:51.844034+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    }
  ],
  "FullName": "Clemmie Collier",
  "EMailAddress": "dolores",
  "FunctionRights": [
    "quo",
    "soluta"
  ],
  "EjUserId": 952,
  "EjAccessLevel": 195,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "non",
      "SearchName": "Lowe Inc and Sons",
      "DisplayName": "Wyman, Considine and Hilpert",
      "CredentialId": 922
    },
    {
      "Type": "non",
      "SearchName": "Lowe Inc and Sons",
      "DisplayName": "Wyman, Considine and Hilpert",
      "CredentialId": 922
    }
  ],
  "SecondaryGroups": [
    873,
    818
  ],
  "DatabaseContextIdentifier": "soluta",
  "UserName": "Hagenes-Wunsch"
}
```