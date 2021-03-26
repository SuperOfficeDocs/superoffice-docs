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
  "SatelliteId": 509,
  "Created": "2009-10-28T16:48:30.4809396+01:00",
  "CreatedBy": {
    "AssociateId": 186,
    "Name": "Dibbert Inc and Sons",
    "PersonId": 48,
    "Rank": 751,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 985,
    "FullName": "Henry McCullough",
    "FormalName": "Legros Inc and Sons",
    "Deleted": true,
    "EjUserId": 933,
    "UserName": "Ortiz-Lemke"
  },
  "Updated": "2009-05-06T16:48:30.4809396+02:00",
  "UpdatedBy": {
    "AssociateId": 431,
    "Name": "Kemmer-Steuber",
    "PersonId": 432,
    "Rank": 299,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 251,
    "FullName": "Tyler Heathcote",
    "FormalName": "Adams-Mraz",
    "Deleted": true,
    "EjUserId": 227,
    "UserName": "Hamill Group"
  },
  "Contact": {
    "ContactId": 459,
    "Name": "Walker-Kunde",
    "OrgNr": "527858",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "provident",
    "DirectPhone": "776-557-1247",
    "AssociateId": 237,
    "CountryId": 74,
    "EmailAddress": "camila@smithamwatsica.co.uk",
    "Kananame": "perspiciatis",
    "EmailAddressName": "gianni@luettgen.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Floyd Howell",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "asperiores",
    "FullName": "General Friesen",
    "IsOwnerContact": true,
    "ActiveErpLinks": 62
  },
  "Area": {
    "AreaId": 596,
    "Name": "Howell, Ryan and Donnelly",
    "MaxDataAge": 908,
    "NumberOfUsers": 753,
    "NumberOfLogins": 433,
    "FreetextEnabeled": false
  },
  "LicenseOwners": [
    {
      "Name": "Koch-Rutherford",
      "Description": "Synchronised cohesive knowledge user",
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
      "Name": "Koch-Rutherford",
      "Description": "Synchronised cohesive knowledge user",
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
  "SatelliteId": 439,
  "Created": "1995-11-06T16:48:30.48494+01:00",
  "CreatedBy": {
    "AssociateId": 936,
    "Name": "Schaefer, Spinka and Tromp",
    "PersonId": 841,
    "Rank": 600,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 417,
    "FullName": "Ms. Merlin Herman",
    "FormalName": "Cormier Inc and Sons",
    "Deleted": false,
    "EjUserId": 592,
    "UserName": "Wisozk-Jacobi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "Updated": "1997-09-10T16:48:30.48494+02:00",
  "UpdatedBy": {
    "AssociateId": 599,
    "Name": "Zulauf, King and Schultz",
    "PersonId": 688,
    "Rank": 12,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 315,
    "FullName": "Zoila Mayer",
    "FormalName": "Raynor, Hintz and Hilpert",
    "Deleted": true,
    "EjUserId": 385,
    "UserName": "Schaefer-Raynor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 360
      }
    }
  },
  "Contact": {
    "ContactId": 967,
    "Name": "Schimmel LLC",
    "OrgNr": "1075856",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "animi",
    "DirectPhone": "827.678.4705",
    "AssociateId": 993,
    "CountryId": 250,
    "EmailAddress": "liana.considine@hartmann.co.uk",
    "Kananame": "aut",
    "EmailAddressName": "erika.feeney@faheymueller.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Griffin Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptate",
    "FullName": "Mrs. Marisol Reilly",
    "IsOwnerContact": false,
    "ActiveErpLinks": 218,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 369
      }
    }
  },
  "Area": {
    "AreaId": 718,
    "Name": "Dare-Hilpert",
    "MaxDataAge": 547,
    "NumberOfUsers": 317,
    "NumberOfLogins": 406,
    "FreetextEnabeled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 338
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "O'Kon-Mann",
      "Description": "Multi-layered didactic database",
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
          "FieldLength": 132
        }
      }
    },
    {
      "Name": "O'Kon-Mann",
      "Description": "Multi-layered didactic database",
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
          "FieldLength": 132
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
      "FieldLength": 611
    }
  }
}
```