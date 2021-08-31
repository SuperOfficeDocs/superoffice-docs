---
title: GetSatellite
id: v1ReplicationAgent_GetSatellite
---

# GetSatellite

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
POST /api/v1/Agents/Replication/GetSatellite?satelliteId=428
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 451,
  "Created": "2008-08-19T14:58:05.0906295+02:00",
  "CreatedBy": {
    "AssociateId": 647,
    "Name": "Barton-Jaskolski",
    "PersonId": 664,
    "Rank": 163,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Lelah Littel",
    "FormalName": "Farrell Group",
    "Deleted": false,
    "EjUserId": 156,
    "UserName": "Heidenreich, Dickinson and Johnston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 727
      }
    }
  },
  "Updated": "2006-11-01T14:58:05.0916288+01:00",
  "UpdatedBy": {
    "AssociateId": 31,
    "Name": "Tremblay-Hane",
    "PersonId": 169,
    "Rank": 541,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 835,
    "FullName": "Ms. Alexander Zulauf",
    "FormalName": "Trantow LLC",
    "Deleted": true,
    "EjUserId": 645,
    "UserName": "Rolfson-Bergnaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 607
      }
    }
  },
  "Contact": {
    "ContactId": 102,
    "Name": "Ernser Inc and Sons",
    "OrgNr": "1493767",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "facere",
    "DirectPhone": "323-030-6045 x6384",
    "AssociateId": 786,
    "CountryId": 257,
    "EmailAddress": "ethyl@wintheiser.name",
    "Kananame": "odio",
    "EmailAddressName": "nettie.borer@mcglynn.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jermaine Hansen",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "in",
    "FullName": "Misty Homenick",
    "IsOwnerContact": false,
    "ActiveErpLinks": 913,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 355
      }
    }
  },
  "Area": {
    "AreaId": 696,
    "Name": "Kuhic Group",
    "MaxDataAge": 602,
    "NumberOfUsers": 832,
    "NumberOfLogins": 790,
    "FreetextEnabeled": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 628
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Gorczany-Friesen",
      "Description": "User-friendly client-driven alliance",
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
            "Reason": "empower vertical vortals"
          },
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    },
    {
      "Name": "Gorczany-Friesen",
      "Description": "User-friendly client-driven alliance",
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
            "Reason": "empower vertical vortals"
          },
          "FieldType": "System.String",
          "FieldLength": 439
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
      "FieldLength": 120
    }
  }
}
```