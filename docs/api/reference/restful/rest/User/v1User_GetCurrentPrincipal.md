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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "ipsam",
  "AssociateId": 889,
  "IsPerson": false,
  "PersonId": 375,
  "CountryId": 891,
  "HomeCountryId": 514,
  "ContactId": 507,
  "GroupId": 754,
  "BusinessId": 323,
  "CategoryId": 541,
  "ContactOwner": 953,
  "RoleId": 665,
  "RoleName": "Kiehn, Deckow and Hand",
  "RoleDescription": "Devolved transitional system engine",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 715,
      "OwnerName": "Halvorson Group",
      "OwnerDescription": "Phased stable task-force",
      "ModuleId": 722,
      "Name": "Gusikowski-Koss",
      "Description": "Integrated leading edge matrices",
      "Version": "impedit",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 759,
      "ExtraInfo": "autem",
      "SortOrder": 986,
      "LicenseNumber": 402,
      "IsHidden": false,
      "IsUnrestricted": true,
      "ExpiryDate": "2008-07-29T11:10:53.8642128+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "FullName": "Gilberto Schmitt",
  "EMailAddress": "ut",
  "FunctionRights": [
    "modi",
    "amet"
  ],
  "EjUserId": 912,
  "EjAccessLevel": 756,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "hic",
      "SearchName": "Thompson-Sipes",
      "DisplayName": "Boehm, Orn and Bauch",
      "CredentialId": 572
    },
    {
      "Type": "hic",
      "SearchName": "Thompson-Sipes",
      "DisplayName": "Boehm, Orn and Bauch",
      "CredentialId": 572
    }
  ],
  "SecondaryGroups": [
    483,
    82
  ],
  "DatabaseContextIdentifier": "delectus",
  "UserName": "Kemmer-Kutch"
}
```