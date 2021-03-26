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
POST /api/v1/Agents/Replication/GetSatellite?satelliteId=199
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 968,
  "Created": "2012-06-08T16:48:30.4889401+02:00",
  "CreatedBy": {
    "AssociateId": 965,
    "Name": "Beer, Weissnat and Greenholt",
    "PersonId": 647,
    "Rank": 804,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 880,
    "FullName": "Thea Hermiston",
    "FormalName": "Zemlak LLC",
    "Deleted": false,
    "EjUserId": 614,
    "UserName": "Dare-Zieme",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 544
      }
    }
  },
  "Updated": "2000-06-01T16:48:30.4889401+02:00",
  "UpdatedBy": {
    "AssociateId": 460,
    "Name": "Toy-Konopelski",
    "PersonId": 534,
    "Rank": 482,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 270,
    "FullName": "Turner Bernhard V",
    "FormalName": "Schaden Inc and Sons",
    "Deleted": true,
    "EjUserId": 905,
    "UserName": "Dietrich-Buckridge",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer synergistic vortals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 968
      }
    }
  },
  "Contact": {
    "ContactId": 447,
    "Name": "Dickens, Rolfson and Torp",
    "OrgNr": "782172",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "1-271-638-4801",
    "AssociateId": 227,
    "CountryId": 859,
    "EmailAddress": "alanna_heathcote@rennerolson.info",
    "Kananame": "praesentium",
    "EmailAddressName": "nichole_wunsch@denesik.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Brannon Breitenberg",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Zane Kihn",
    "IsOwnerContact": false,
    "ActiveErpLinks": 823,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 756
      }
    }
  },
  "Area": {
    "AreaId": 222,
    "Name": "Hayes, Rempel and Hamill",
    "MaxDataAge": 1001,
    "NumberOfUsers": 980,
    "NumberOfLogins": 594,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit granular portals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Herzog, Nitzsche and Koss",
      "Description": "Reduced asynchronous pricing structure",
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
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Name": "Herzog, Nitzsche and Koss",
      "Description": "Reduced asynchronous pricing structure",
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
          "FieldType": "System.Int32",
          "FieldLength": 352
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
      "FieldLength": 420
    }
  }
}
```