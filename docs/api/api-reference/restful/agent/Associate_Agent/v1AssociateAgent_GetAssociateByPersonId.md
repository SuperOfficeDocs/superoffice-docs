---
title: POST Agents/Associate/GetAssociateByPersonId
id: v1AssociateAgent_GetAssociateByPersonId
---

# POST Agents/Associate/GetAssociateByPersonId

```http
POST /api/v1/Agents/Associate/GetAssociateByPersonId
```

Returns the associate that belongs to this person if the person is an associate.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Associate/GetAssociateByPersonId?$select=name,department,category/id
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

PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |


## Response: object

Carrier object for Associate.
Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| PersonId | int32 | Owning person record  <para>Use MDO List name "person" to get list items.</para> |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Type | string | User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| GroupIdx | int32 | Primary group membership, see UserGroupLink for secondary memberships |
| FullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| FormalName | string | The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| Deleted | bool | If true, the user is retired and should have no rights, not appear in lists, etc. |
| EjUserId | int32 | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| UserName | string | User name |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Associate/GetAssociateByPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 891
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 569,
  "Name": "Hartmann, Wiza and Conn",
  "PersonId": 911,
  "Rank": 649,
  "Tooltip": "recusandae",
  "Type": "AnonymousAssociate",
  "GroupIdx": 974,
  "FullName": "Bettye Von",
  "FormalName": "Effertz, Hauck and O'Hara",
  "Deleted": true,
  "EjUserId": 708,
  "UserName": "Haley-Ritchie",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 244
    }
  }
}
```