---
title: GET User/currentPrincipal
id: v1User_GetCurrentPrincipal
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
GET /api/v1/User/currentPrincipal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "quo",
  "AssociateId": 566,
  "IsPerson": true,
  "PersonId": 657,
  "CountryId": 327,
  "HomeCountryId": 47,
  "ContactId": 328,
  "GroupId": 923,
  "BusinessId": 376,
  "CategoryId": 581,
  "ContactOwner": 909,
  "RoleId": 698,
  "RoleName": "Rempel LLC",
  "RoleDescription": "Optional bottom-line knowledge user",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 652,
      "OwnerName": "Ratke-Wisoky",
      "OwnerDescription": "Horizontal fresh-thinking success",
      "ModuleId": 359,
      "Name": "Bosco, Predovic and Goodwin",
      "Description": "Realigned web-enabled matrix",
      "Version": "iusto",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 90,
      "ExtraInfo": "quae",
      "SortOrder": 735,
      "LicenseNumber": 752,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "2001-02-22T18:25:51.5531211+01:00",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "FullName": "Colten Miller",
  "EMailAddress": "qui",
  "FunctionRights": [
    "repellat",
    "perferendis"
  ],
  "EjUserId": 246,
  "EjAccessLevel": 441,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "eum",
      "SearchName": "Gutkowski, Dicki and Roberts",
      "DisplayName": "Gleichner-Dooley",
      "CredentialId": 307
    },
    {
      "Type": "eum",
      "SearchName": "Gutkowski, Dicki and Roberts",
      "DisplayName": "Gleichner-Dooley",
      "CredentialId": 307
    }
  ],
  "SecondaryGroups": [
    63,
    252
  ],
  "DatabaseContextIdentifier": "sint",
  "UserName": "Terry, Fritsch and Mitchell"
}
```