---
title: POST Agents/Replication/GetSatellite
id: v1ReplicationAgent_GetSatellite
---

# POST Agents/Replication/GetSatellite

```http
POST /api/v1/Agents/Replication/GetSatellite
```

Gets a Satellite object.



## Online Restricted: ## The Replication agent is not available in Online by default. Not available in Online. Only used on-site.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| satelliteId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Replication/GetSatellite?satelliteId=533
POST /api/v1/Agents/Replication/GetSatellite?$select=name,department,category/id
```


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
POST /api/v1/Agents/Replication/GetSatellite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 973,
  "Created": "2016-10-30T18:28:50.0266978+01:00",
  "CreatedBy": {
    "AssociateId": 768,
    "Name": "Brakus-Reynolds",
    "PersonId": 633,
    "Rank": 646,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 54,
    "FullName": "Felipe Heathcote",
    "FormalName": "Morissette-Smith",
    "Deleted": true,
    "EjUserId": 363,
    "UserName": "Harber-Haag",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 25
      }
    }
  },
  "Updated": "2013-06-23T18:28:50.0266978+02:00",
  "UpdatedBy": {
    "AssociateId": 615,
    "Name": "Walsh, O'Keefe and Volkman",
    "PersonId": 554,
    "Rank": 984,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 894,
    "FullName": "Mercedes Ziemann",
    "FormalName": "Oberbrunner-Smith",
    "Deleted": true,
    "EjUserId": 85,
    "UserName": "Hirthe Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 872
      }
    }
  },
  "Contact": {
    "ContactId": 770,
    "Name": "Thiel-Lockman",
    "OrgNr": "1059998",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "doloremque",
    "DirectPhone": "621-738-6485",
    "AssociateId": 653,
    "CountryId": 638,
    "EmailAddress": "magnolia.pfeffer@vonwaters.biz",
    "Kananame": "quis",
    "EmailAddressName": "alta@hayes.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Anjali Howe",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "praesentium",
    "FullName": "Laurine Erdman",
    "IsOwnerContact": true,
    "ActiveErpLinks": 739,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable cross-platform relationships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 133
      }
    }
  },
  "Area": {
    "AreaId": 787,
    "Name": "Dach Group",
    "MaxDataAge": 153,
    "NumberOfUsers": 794,
    "NumberOfLogins": 395,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 97
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Barrows LLC",
      "Description": "Optional tertiary model",
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
          "FieldLength": 397
        }
      }
    },
    {
      "Name": "Barrows LLC",
      "Description": "Optional tertiary model",
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
          "FieldLength": 397
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
      "FieldType": "System.Int32",
      "FieldLength": 489
    }
  }
}
```