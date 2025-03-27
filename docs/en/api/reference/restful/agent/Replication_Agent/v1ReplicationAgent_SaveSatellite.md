---
title: POST Agents/Replication/SaveSatellite
uid: v1ReplicationAgent_SaveSatellite
generated: true
---

# POST Agents/Replication/SaveSatellite

```http
POST /api/v1/Agents/Replication/SaveSatellite
```

Updates the existing Satellite or creates a new Satellite if the id parameter is empty


## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.







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

## Request Body: entity 

The Satellite to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SatelliteId | Integer | Primary key |
| Created | String | Registered when  in UTC. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Updated | String | Last updated when  in UTC. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Contact | Contact | Carrier object for Contact. Services for the Contact Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| Area | Area | Carrier object for Area. Services for the Area Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReplicationAgent">Replication Agent</see>. |
| LicenseOwners | Array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Satellite

| Property Name | Type |  Description |
|----------------|------|--------------|
| SatelliteId | int32 | Primary key |
| Created | date-time | Registered when  in UTC. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| Contact | Contact | Carrier object for Contact. Services for the Contact Carrier is available from the Contact Agent. |
| Area | Area | Carrier object for Area. Services for the Area Carrier is available from the Replication Agent. |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Replication/SaveSatellite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 788,
  "Created": "2004-10-27T02:38:21.8076201+02:00",
  "CreatedBy": null,
  "Updated": "2017-12-30T02:38:21.8076201+01:00",
  "UpdatedBy": null,
  "Contact": null,
  "Area": null,
  "LicenseOwners": [
    {
      "Name": "Metz-Kihn",
      "Description": "Re-engineered systemic toolset",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    },
    {
      "Name": "Metz-Kihn",
      "Description": "Re-engineered systemic toolset",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 415,
  "Created": "2003-02-16T02:38:21.8076201+01:00",
  "CreatedBy": null,
  "Updated": "2004-03-23T02:38:21.8076201+01:00",
  "UpdatedBy": null,
  "Contact": null,
  "Area": null,
  "LicenseOwners": [
    {
      "Name": "O'Reilly, Kautzer and Hansen",
      "Description": "Cross-platform homogeneous intranet",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    },
    {
      "Name": "O'Reilly, Kautzer and Hansen",
      "Description": "Cross-platform homogeneous intranet",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 689
    }
  }
}
```