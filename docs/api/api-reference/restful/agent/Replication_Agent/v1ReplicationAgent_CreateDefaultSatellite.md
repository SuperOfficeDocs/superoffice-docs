---
title: POST Agents/Replication/CreateDefaultSatellite
id: v1ReplicationAgent_CreateDefaultSatellite
---

# POST Agents/Replication/CreateDefaultSatellite

```http
POST /api/v1/Agents/Replication/CreateDefaultSatellite
```

Set default values into a new Satellite.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.






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

Carrier object for Satellite.
Services for the Satellite Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReplicationAgent">Replication Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SatelliteId | int32 | Primary key |
| Created | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Contact |  | Carrier object for Contact. Services for the Contact Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| Area |  | Carrier object for Area. Services for the Area Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReplicationAgent">Replication Agent</see>. |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Replication/CreateDefaultSatellite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 916,
  "Created": "2005-06-15T18:28:50.0141324+02:00",
  "CreatedBy": {
    "AssociateId": 323,
    "Name": "Rippin LLC",
    "PersonId": 376,
    "Rank": 459,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 557,
    "FullName": "Margaretta Nienow",
    "FormalName": "Schaden Inc and Sons",
    "Deleted": false,
    "EjUserId": 206,
    "UserName": "Labadie LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 272
      }
    }
  },
  "Updated": "2014-06-04T18:28:50.0141324+02:00",
  "UpdatedBy": {
    "AssociateId": 883,
    "Name": "Thompson, Lemke and Kuphal",
    "PersonId": 913,
    "Rank": 787,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Kellie Nitzsche",
    "FormalName": "Gleichner, Keeling and Rowe",
    "Deleted": true,
    "EjUserId": 239,
    "UserName": "Pouros LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 465
      }
    }
  },
  "Contact": {
    "ContactId": 408,
    "Name": "Baumbach Group",
    "OrgNr": "1285774",
    "Department": "incubate enterprise vortals",
    "URL": "http://www.example.com/",
    "City": "illo",
    "DirectPhone": "731.407.5461",
    "AssociateId": 845,
    "CountryId": 518,
    "EmailAddress": "alexie.dickens@gaylordmarvin.ca",
    "Kananame": "vel",
    "EmailAddressName": "shaina@funkkuhn.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Pearlie Howe",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "placeat",
    "FullName": "Louisa Langworth",
    "IsOwnerContact": false,
    "ActiveErpLinks": 546,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 689
      }
    }
  },
  "Area": {
    "AreaId": 35,
    "Name": "Hartmann LLC",
    "MaxDataAge": 265,
    "NumberOfUsers": 893,
    "NumberOfLogins": 388,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 933
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Jacobi-Gulgowski",
      "Description": "Adaptive solution-oriented encoding",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    },
    {
      "Name": "Jacobi-Gulgowski",
      "Description": "Adaptive solution-oriented encoding",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    }
  ],
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
      "FieldType": "System.String",
      "FieldLength": 675
    }
  }
}
```