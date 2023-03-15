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
  "Associate": "commodi",
  "AssociateId": 831,
  "IsPerson": false,
  "PersonId": 365,
  "CountryId": 347,
  "HomeCountryId": 739,
  "ContactId": 399,
  "GroupId": 828,
  "BusinessId": 269,
  "CategoryId": 51,
  "ContactOwner": 37,
  "RoleId": 746,
  "RoleName": "Moore Group",
  "RoleDescription": "User-friendly disintermediate protocol",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 18,
      "OwnerName": "Donnelly Group",
      "OwnerDescription": "Organic national knowledge base",
      "ModuleId": 434,
      "Name": "Beahan, Zieme and Schmeler",
      "Description": "Profit-focused hybrid framework",
      "Version": "voluptatem",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 652,
      "ExtraInfo": "dolores",
      "SortOrder": 399,
      "LicenseNumber": 944,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "2008-02-22T12:15:27.8016236+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "FullName": "Ms. Frank Susanna Sporer DDS",
  "EMailAddress": "suscipit",
  "FunctionRights": [
    "voluptatem",
    "non"
  ],
  "EjUserId": 689,
  "EjAccessLevel": 567,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "quo",
      "SearchName": "Ortiz Inc and Sons",
      "DisplayName": "Bergstrom, Cassin and Schuster",
      "CredentialId": 310
    },
    {
      "Type": "quo",
      "SearchName": "Ortiz Inc and Sons",
      "DisplayName": "Bergstrom, Cassin and Schuster",
      "CredentialId": 310
    }
  ],
  "SecondaryGroups": [
    576,
    477
  ],
  "DatabaseContextIdentifier": "suscipit",
  "UserName": "Hackett-Rice"
}
```