---
title: POST Agents/Replication/SaveSatellite
id: v1ReplicationAgent_SaveSatellite
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
| SatelliteId | int32 | Primary key |
| Created | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| Contact |  | Carrier object for Contact. Services for the Contact Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| Area |  | Carrier object for Area. Services for the Area Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReplicationAgent">Replication Agent</see>. |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |


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
POST /api/v1/Agents/Replication/SaveSatellite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 532,
  "Created": "2002-06-03T18:28:50.0157624+02:00",
  "CreatedBy": {
    "AssociateId": 407,
    "Name": "Keebler Group",
    "PersonId": 996,
    "Rank": 679,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 570,
    "FullName": "Milo Marquardt",
    "FormalName": "Davis, Schuppe and Spinka",
    "Deleted": true,
    "EjUserId": 219,
    "UserName": "Raynor, Swift and Corkery"
  },
  "Updated": "2004-07-16T18:28:50.0157624+02:00",
  "UpdatedBy": {
    "AssociateId": 995,
    "Name": "Roberts, Lebsack and Kunze",
    "PersonId": 582,
    "Rank": 321,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 68,
    "FullName": "Jessika Schultz",
    "FormalName": "Mraz-Strosin",
    "Deleted": false,
    "EjUserId": 69,
    "UserName": "Prohaska-Wiza"
  },
  "Contact": {
    "ContactId": 785,
    "Name": "Murphy-Bechtelar",
    "OrgNr": "1173672",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "asperiores",
    "DirectPhone": "1-076-285-3528 x807",
    "AssociateId": 855,
    "CountryId": 321,
    "EmailAddress": "robb@beckerryan.info",
    "Kananame": "recusandae",
    "EmailAddressName": "skylar@tremblay.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Deshawn Cummings",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sed",
    "FullName": "May Carter",
    "IsOwnerContact": true,
    "ActiveErpLinks": 687
  },
  "Area": {
    "AreaId": 263,
    "Name": "Johns-Hettinger",
    "MaxDataAge": 736,
    "NumberOfUsers": 31,
    "NumberOfLogins": 719,
    "FreetextEnabeled": false
  },
  "LicenseOwners": [
    {
      "Name": "Renner, Schulist and Kuphal",
      "Description": "Synchronised intermediate conglomeration",
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
      "Name": "Renner, Schulist and Kuphal",
      "Description": "Synchronised intermediate conglomeration",
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

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SatelliteId": 591,
  "Created": "2020-05-16T18:28:50.0206701+02:00",
  "CreatedBy": {
    "AssociateId": 462,
    "Name": "Tremblay-Aufderhar",
    "PersonId": 131,
    "Rank": 673,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 284,
    "FullName": "Krista Goldner",
    "FormalName": "Schamberger, White and Streich",
    "Deleted": false,
    "EjUserId": 714,
    "UserName": "Anderson, Rohan and Ernser",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver vertical e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 876
      }
    }
  },
  "Updated": "2018-06-07T18:28:50.0206701+02:00",
  "UpdatedBy": {
    "AssociateId": 353,
    "Name": "Zemlak-Jacobson",
    "PersonId": 959,
    "Rank": 68,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 929,
    "FullName": "Linwood Altenwerth",
    "FormalName": "Rosenbaum-Koss",
    "Deleted": false,
    "EjUserId": 856,
    "UserName": "Hilll LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 711
      }
    }
  },
  "Contact": {
    "ContactId": 124,
    "Name": "Tromp, Medhurst and Nienow",
    "OrgNr": "526728",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "esse",
    "DirectPhone": "237-776-6741",
    "AssociateId": 214,
    "CountryId": 751,
    "EmailAddress": "angelo@kleinyundt.ca",
    "Kananame": "autem",
    "EmailAddressName": "uriah@skiles.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Imani Kertzmann",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "at",
    "FullName": "Ms. Claudia Daniel",
    "IsOwnerContact": true,
    "ActiveErpLinks": 268,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 93
      }
    }
  },
  "Area": {
    "AreaId": 517,
    "Name": "Vandervort-Wilkinson",
    "MaxDataAge": 540,
    "NumberOfUsers": 534,
    "NumberOfLogins": 222,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 627
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Harris, Rogahn and Zulauf",
      "Description": "Open-source real-time ability",
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
          "FieldLength": 239
        }
      }
    },
    {
      "Name": "Harris, Rogahn and Zulauf",
      "Description": "Open-source real-time ability",
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
          "FieldLength": 239
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
      "FieldLength": 435
    }
  }
}
```