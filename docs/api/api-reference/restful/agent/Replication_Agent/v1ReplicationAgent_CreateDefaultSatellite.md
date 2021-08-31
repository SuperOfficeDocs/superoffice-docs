---
title: CreateDefaultSatellite
id: v1ReplicationAgent_CreateDefaultSatellite
---

# CreateDefaultSatellite

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
  "SatelliteId": 271,
  "Created": "2010-07-20T14:58:05.0294654+02:00",
  "CreatedBy": {
    "AssociateId": 627,
    "Name": "Gibson-Pollich",
    "PersonId": 973,
    "Rank": 287,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 404,
    "FullName": "Connor Will DVM",
    "FormalName": "Mante-Stiedemann",
    "Deleted": false,
    "EjUserId": 408,
    "UserName": "Keebler LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 198
      }
    }
  },
  "Updated": "2005-03-29T14:58:05.0294654+02:00",
  "UpdatedBy": {
    "AssociateId": 733,
    "Name": "Dietrich LLC",
    "PersonId": 13,
    "Rank": 746,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 291,
    "FullName": "Marshall Wintheiser",
    "FormalName": "Kuhn Inc and Sons",
    "Deleted": false,
    "EjUserId": 519,
    "UserName": "Schmidt LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 448
      }
    }
  },
  "Contact": {
    "ContactId": 863,
    "Name": "Wolf, Zemlak and Wuckert",
    "OrgNr": "1016740",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "animi",
    "DirectPhone": "171.472.3231 x328",
    "AssociateId": 357,
    "CountryId": 535,
    "EmailAddress": "vallie@ebertbruen.com",
    "Kananame": "nesciunt",
    "EmailAddressName": "perry@olson.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tara Gottlieb",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "itaque",
    "FullName": "Mr. Ezra Medhurst",
    "IsOwnerContact": false,
    "ActiveErpLinks": 87,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 266
      }
    }
  },
  "Area": {
    "AreaId": 421,
    "Name": "Bashirian-Nicolas",
    "MaxDataAge": 447,
    "NumberOfUsers": 919,
    "NumberOfLogins": 736,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 878
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Bahringer-O'Reilly",
      "Description": "Quality-focused motivating architecture",
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
          "FieldLength": 165
        }
      }
    },
    {
      "Name": "Bahringer-O'Reilly",
      "Description": "Quality-focused motivating architecture",
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
          "FieldLength": 165
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
      "FieldLength": 358
    }
  }
}
```