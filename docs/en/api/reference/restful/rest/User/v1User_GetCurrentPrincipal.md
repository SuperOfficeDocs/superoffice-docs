---
title: GET User/currentPrincipal
uid: v1User_GetCurrentPrincipal
generated: true
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

### Response body: SoPrincipalCarrier

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string | Type of user |
| Associate | string | Associate name (e.g. logon name) for the user |
| AssociateId | int32 | AssociateId for the user. |
| IsPerson | bool | Is this associate a person, and not a resource? |
| PersonId | int32 | Associate's person id |
| CountryId | int32 | Country id for the user. |
| HomeCountryId | int32 | Country id for the user's home country.  This is the default country id when creating new items. |
| ContactId | int32 | Company of the associate's person |
| GroupId | int32 | Associate's group_idx |
| BusinessId | int32 | BusinessIdx for the company that the user belongs to. |
| CategoryId | int32 | CategoryIdx of the company that the user belongs to. |
| ContactOwner | int32 | Owner (AssocaiteId) of the company that the user belongs to. |
| RoleId | int32 | Id of the users role |
| RoleName | string | Name of the users role |
| RoleDescription | string | Descrtiption (e.g. tooltip) for the users role |
| RoleType | string | Type of user. |
| Licenses | array | License granted to the site and user. |
| FullName | string | The Person full name if the associate is a person. Use IsPerson to check |
| EMailAddress | string | The Person e-mail address if the associate is a person. Use IsPerson to check |
| FunctionRights | array | Functional rights for the user.  This array is sorted so a lookup can be performed using {M:System.Array.BinarySearch(System.Array,System.Int32,System.Int32,System.Object)}. |
| EjUserId | int32 | Primary key in eJournal's old user table. |
| EjAccessLevel | int32 | eJournal user access level |
| EjUserStatus | string | eJournal user status |
| ProvidedCredentials | array | The credentials used for authenticating this user. |
| SecondaryGroups | array | Secondary user groups |
| DatabaseContextIdentifier | string | Name of the database context |
| UserName | string | UserName on associatetable. Same as SuperId from Online |

## Sample request

```http!
GET /api/v1/User/currentPrincipal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "Associate": "officiis",
  "AssociateId": 371,
  "IsPerson": false,
  "PersonId": 143,
  "CountryId": 881,
  "HomeCountryId": 517,
  "ContactId": 875,
  "GroupId": 641,
  "BusinessId": 736,
  "CategoryId": 869,
  "ContactOwner": 267,
  "RoleId": 812,
  "RoleName": "Lueilwitz-Lakin",
  "RoleDescription": "Proactive impactful encoding",
  "RoleType": "Anonymous",
  "Licenses": [
    {
      "OwnerId": 719,
      "OwnerName": "O'Conner-Ankunding",
      "OwnerDescription": "Stand-alone analyzing encoding",
      "ModuleId": 234,
      "Name": "Adams-Rohan",
      "Description": "Automated context-sensitive open architecture",
      "Version": "et",
      "LicenseType": "SatelliteLicense",
      "ExtraFlags": 613,
      "ExtraInfo": "dolor",
      "SortOrder": 700,
      "LicenseNumber": 839,
      "IsHidden": false,
      "IsUnrestricted": false,
      "ExpiryDate": "2001-10-16T14:32:12.4114949+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    }
  ],
  "FullName": "Prudence Beahan",
  "EMailAddress": "quaerat",
  "FunctionRights": [
    "beatae",
    "quis"
  ],
  "EjUserId": 253,
  "EjAccessLevel": 713,
  "EjUserStatus": "StatusDeleted",
  "ProvidedCredentials": [
    {
      "Type": "facilis",
      "SearchName": "Stiedemann Inc and Sons",
      "DisplayName": "Considine-Kihn",
      "CredentialId": 89
    },
    {
      "Type": "facilis",
      "SearchName": "Stiedemann Inc and Sons",
      "DisplayName": "Considine-Kihn",
      "CredentialId": 89
    }
  ],
  "SecondaryGroups": [
    550,
    871
  ],
  "DatabaseContextIdentifier": "explicabo",
  "UserName": "Muller Group"
}
```