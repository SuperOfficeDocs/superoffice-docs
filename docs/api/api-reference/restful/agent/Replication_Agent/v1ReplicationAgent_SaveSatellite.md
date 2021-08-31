---
title: SaveSatellite
id: v1ReplicationAgent_SaveSatellite
---

# SaveSatellite

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
  "SatelliteId": 434,
  "Created": "2018-04-04T14:58:05.081629+02:00",
  "CreatedBy": {
    "AssociateId": 839,
    "Name": "Spencer-Trantow",
    "PersonId": 732,
    "Rank": 155,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 42,
    "FullName": "Ms. Queen Walsh",
    "FormalName": "Fadel-Kub",
    "Deleted": true,
    "EjUserId": 931,
    "UserName": "Kessler Inc and Sons"
  },
  "Updated": "2014-07-18T14:58:05.081629+02:00",
  "UpdatedBy": {
    "AssociateId": 769,
    "Name": "Gaylord, Rogahn and Bashirian",
    "PersonId": 383,
    "Rank": 41,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 352,
    "FullName": "Mohamed Bashirian",
    "FormalName": "Greenfelder, Lang and McGlynn",
    "Deleted": false,
    "EjUserId": 267,
    "UserName": "Pfeffer Group"
  },
  "Contact": {
    "ContactId": 361,
    "Name": "Jast, Bartell and VonRueden",
    "OrgNr": "1170627",
    "Department": "whiteboard turn-key action-items",
    "URL": "http://www.example.com/",
    "City": "eveniet",
    "DirectPhone": "(305)615-5427 x160",
    "AssociateId": 420,
    "CountryId": 683,
    "EmailAddress": "tommie_blick@treutel.biz",
    "Kananame": "quia",
    "EmailAddressName": "valentine@ortiz.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Reba Breitenberg",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aut",
    "FullName": "Aubree Berge",
    "IsOwnerContact": true,
    "ActiveErpLinks": 908
  },
  "Area": {
    "AreaId": 694,
    "Name": "Spinka-Davis",
    "MaxDataAge": 712,
    "NumberOfUsers": 10,
    "NumberOfLogins": 483,
    "FreetextEnabeled": false
  },
  "LicenseOwners": [
    {
      "Name": "Hoppe, Ziemann and Nienow",
      "Description": "Organized modular hierarchy",
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
      "Name": "Hoppe, Ziemann and Nienow",
      "Description": "Organized modular hierarchy",
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
  "SatelliteId": 380,
  "Created": "1994-05-14T14:58:05.0866289+02:00",
  "CreatedBy": {
    "AssociateId": 57,
    "Name": "Crooks-Harber",
    "PersonId": 985,
    "Rank": 518,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 201,
    "FullName": "Rocio Maggio",
    "FormalName": "Beahan LLC",
    "Deleted": false,
    "EjUserId": 3,
    "UserName": "Schroeder, Hintz and Barrows",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash mission-critical interfaces"
        },
        "FieldType": "System.Int32",
        "FieldLength": 627
      }
    }
  },
  "Updated": "2019-11-01T14:58:05.0866289+01:00",
  "UpdatedBy": {
    "AssociateId": 388,
    "Name": "Adams, Gorczany and Kautzer",
    "PersonId": 46,
    "Rank": 820,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 45,
    "FullName": "Hardy Davis",
    "FormalName": "Walter-Jacobson",
    "Deleted": true,
    "EjUserId": 820,
    "UserName": "Bode Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 29
      }
    }
  },
  "Contact": {
    "ContactId": 113,
    "Name": "Mayer Group",
    "OrgNr": "1240851",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vel",
    "DirectPhone": "726.042.2868",
    "AssociateId": 618,
    "CountryId": 234,
    "EmailAddress": "reuben_hirthe@hermanwyman.uk",
    "Kananame": "odio",
    "EmailAddressName": "guadalupe_runolfsdottir@white.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Russell Hickle",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aspernatur",
    "FullName": "Ms. Raul Reichert",
    "IsOwnerContact": false,
    "ActiveErpLinks": 667,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  },
  "Area": {
    "AreaId": 881,
    "Name": "Rolfson-Zemlak",
    "MaxDataAge": 573,
    "NumberOfUsers": 933,
    "NumberOfLogins": 119,
    "FreetextEnabeled": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 635
      }
    }
  },
  "LicenseOwners": [
    {
      "Name": "Bernier-Schaden",
      "Description": "Ergonomic eco-centric core",
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
          "FieldLength": 867
        }
      }
    },
    {
      "Name": "Bernier-Schaden",
      "Description": "Ergonomic eco-centric core",
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
          "FieldLength": 867
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
      "FieldLength": 634
    }
  }
}
```