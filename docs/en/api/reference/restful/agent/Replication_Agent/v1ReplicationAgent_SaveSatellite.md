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
  "SatelliteId": 10,
  "Created": "2006-12-19T10:17:55.9571855+01:00",
  "CreatedBy": null,
  "Updated": "1998-12-27T10:17:55.9571855+01:00",
  "UpdatedBy": null,
  "Contact": null,
  "Area": null,
  "LicenseOwners": [
    {
      "Name": "Breitenberg, Runolfsson and Zemlak",
      "Description": "Business-focused optimal access",
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
      "Name": "Breitenberg, Runolfsson and Zemlak",
      "Description": "Business-focused optimal access",
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
  "SatelliteId": 731,
  "Created": "1998-08-09T10:17:55.9571855+02:00",
  "CreatedBy": null,
  "Updated": "2008-01-06T10:17:55.9571855+01:00",
  "UpdatedBy": null,
  "Contact": null,
  "Area": null,
  "LicenseOwners": [
    {
      "Name": "Gottlieb Group",
      "Description": "Adaptive human-resource extranet",
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
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Name": "Gottlieb Group",
      "Description": "Adaptive human-resource extranet",
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
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 249
    }
  }
}
```