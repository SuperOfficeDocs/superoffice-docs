---
title: GET Contact/{id}
id: v1ContactEntity_GetContactEntity
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.

Calls the Contact agent service GetContactEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 06 Feb 2015 09:40:58 G2T

{
  "ContactId": 615,
  "Name": "Sipes, Cartwright and Thiel",
  "Department": "",
  "OrgNr": "930645",
  "Number1": "917912",
  "Number2": "921284",
  "UpdatedDate": "2015-02-06T09:40:58.9373783+01:00",
  "CreatedDate": "1997-03-27T09:40:58.9373783+01:00",
  "Emails": [
    {
      "Value": "corrupti",
      "StrippedValue": "eum",
      "Description": "Down-sized bandwidth-monitored portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "eum",
      "Description": "Down-sized bandwidth-monitored portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 781,
      "Name": "Wilderman-Rohan",
      "ToolTip": "Quas animi eos animi.",
      "Deleted": true,
      "Rank": 490,
      "Type": "cupiditate",
      "ColorBlock": 515,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2003-02-12T09:40:58.9383755+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Federico Rath",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "enim",
      "Description": "Compatible logistical encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "productize scalable markets"
          },
          "FieldType": "System.String",
          "FieldLength": 539
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "enim",
      "Description": "Compatible logistical encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "productize scalable markets"
          },
          "FieldType": "System.String",
          "FieldLength": 539
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ex",
      "StrippedValue": "accusamus",
      "Description": "Progressive client-server time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "accusamus",
      "Description": "Progressive client-server time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nemo",
      "StrippedValue": "in",
      "Description": "Profound bifurcated secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "morph revolutionary bandwidth"
          },
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "in",
      "Description": "Profound bifurcated secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "morph revolutionary bandwidth"
          },
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "Description": "Versatile motivating strategy",
  "UpdatedBy": {
    "AssociateId": 574,
    "Name": "Dickens Inc and Sons",
    "PersonId": 951,
    "Rank": 616,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 498,
    "FullName": "Dr. Kayleigh Dach",
    "FormalName": "Jacobs LLC",
    "Deleted": false,
    "EjUserId": 275,
    "UserName": "Leannon LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 536
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 260,
    "Name": "Pouros LLC",
    "PersonId": 456,
    "Rank": 716,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 926,
    "FullName": "Lilla Gaylord",
    "FormalName": "Upton, Jacobson and Runte",
    "Deleted": false,
    "EjUserId": 720,
    "UserName": "Lehner Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 524
      }
    }
  },
  "Associate": {
    "AssociateId": 689,
    "Name": "Heathcote-Collins",
    "PersonId": 506,
    "Rank": 915,
    "Tooltip": "esse",
    "Type": "AnonymousAssociate",
    "GroupIdx": 164,
    "FullName": "Elroy Bauch",
    "FormalName": "Greenholt-Kohler",
    "Deleted": false,
    "EjUserId": 235,
    "UserName": "Williamson-Nicolas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace open-source initiatives"
        },
        "FieldType": "System.String",
        "FieldLength": 659
      }
    }
  },
  "Business": {
    "Id": 4,
    "Value": "quis",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 746
      }
    }
  },
  "Category": {
    "Id": 184,
    "Value": "ut",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 462
      }
    }
  },
  "Country": {
    "CountryId": 602,
    "Name": "Abbott Inc and Sons",
    "CurrencyId": 260,
    "EnglishName": "Ritchie, Ratke and Torp",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Configurable impactful contingency",
    "OrgNrText": "797937",
    "InterAreaPrefix": "laudantium",
    "DialInPrefix": "quia",
    "ZipPrefix": "accusamus",
    "DomainName": "Brown-Hessel",
    "AddressLayoutId": 382,
    "DomesticAddressLayoutId": 723,
    "ForeignAddressLayoutId": 670,
    "Rank": 815,
    "Tooltip": "blanditiis",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 207
      }
    }
  },
  "Persons": [
    {
      "Position": "tempora",
      "PersonId": 659,
      "Mrmrs": "necessitatibus",
      "Firstname": "Laverne",
      "Lastname": "Powlowski",
      "MiddleName": "Beahan Group",
      "Title": "occaecati",
      "Description": "Realigned asynchronous methodology",
      "Email": "hilbert@swaniawski.co.uk",
      "FullName": "Virgil Mosciski",
      "DirectPhone": "1-571-207-1126",
      "FormalName": "Schneider LLC",
      "CountryId": 317,
      "ContactId": 278,
      "ContactName": "Eichmann Inc and Sons",
      "Retired": 442,
      "Rank": 978,
      "ActiveInterests": 205,
      "ContactDepartment": "",
      "ContactCountryId": 722,
      "ContactOrgNr": "1355223",
      "FaxPhone": "147.102.0526",
      "MobilePhone": "1-880-224-3428 x750",
      "ContactPhone": "345-151-2766 x53157",
      "AssociateName": "Torp, Armstrong and Lubowitz",
      "AssociateId": 668,
      "UsePersonAddress": true,
      "ContactFax": "autem",
      "Kanafname": "eveniet",
      "Kanalname": "autem",
      "Post1": "amet",
      "Post2": "corporis",
      "Post3": "porro",
      "EmailName": "maeve@huel.ca",
      "ContactFullName": "Ayla Feest",
      "ActiveErpLinks": 322,
      "TicketPriorityId": 607,
      "SupportLanguageId": 879,
      "SupportAssociateId": 331,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 322,
  "GroupId": 150,
  "ActiveStatusMonitorId": 926,
  "SupportAssociate": {
    "AssociateId": 246,
    "Name": "Satterfield Group",
    "PersonId": 652,
    "Rank": 308,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 811,
    "FullName": "Mr. Gardner Keeling",
    "FormalName": "Zboncak-Jewess",
    "Deleted": true,
    "EjUserId": 873,
    "UserName": "Bruen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 721
      }
    }
  },
  "TicketPriority": {
    "Id": 349,
    "Value": "vero",
    "Tooltip": "maxime",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 208
      }
    }
  },
  "CustomerLanguage": {
    "Id": 546,
    "Value": "dignissimos",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 521
      }
    }
  },
  "Deleted": 674,
  "DbiAgentId": 496,
  "DbiLastSyncronized": "2018-08-31T09:40:58.9423789+02:00",
  "DbiKey": "ducimus",
  "DbiLastModified": "2019-11-05T09:40:58.9423789+01:00",
  "SupportPerson": {
    "Position": "eum",
    "PersonId": 451,
    "Mrmrs": "consequatur",
    "Firstname": "Dandre",
    "Lastname": "Weimann",
    "MiddleName": "Wolf Group",
    "Title": "itaque",
    "Description": "Total fault-tolerant application",
    "Email": "kaitlin_fahey@doyle.name",
    "FullName": "Dewayne Stehr MD",
    "DirectPhone": "356-073-3745",
    "FormalName": "Mitchell, Purdy and Konopelski",
    "CountryId": 519,
    "ContactId": 971,
    "ContactName": "Will, Sanford and Kirlin",
    "Retired": 6,
    "Rank": 958,
    "ActiveInterests": 192,
    "ContactDepartment": "",
    "ContactCountryId": 646,
    "ContactOrgNr": "853740",
    "FaxPhone": "(484)320-5227 x0067",
    "MobilePhone": "221-441-8220",
    "ContactPhone": "033-238-3635",
    "AssociateName": "Monahan Inc and Sons",
    "AssociateId": 652,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "accusamus",
    "Kanalname": "placeat",
    "Post1": "sint",
    "Post2": "neque",
    "Post3": "ut",
    "EmailName": "hyman_paucek@greenholt.co.uk",
    "ContactFullName": "Santino Weimann",
    "ActiveErpLinks": 475,
    "TicketPriorityId": 128,
    "SupportLanguageId": 710,
    "SupportAssociateId": 1000,
    "CategoryName": "VIP Customer",
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
  "Address": {
    "Wgs84Latitude": 27344.149999999998,
    "Wgs84Longitude": 26623.329999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Abbott, Franecki and Dach",
          "Value": "nisi",
          "Tooltip": "quibusdam",
          "Label": "quos",
          "ValueLength": 144,
          "AddressType": "laborum",
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
              "FieldLength": 319
            }
          }
        }
      ],
      [
        {
          "Name": "Morissette LLC",
          "Value": "repellendus",
          "Tooltip": "quod",
          "Label": "placeat",
          "ValueLength": 826,
          "AddressType": "consequatur",
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
              "FieldLength": 288
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 803
      }
    }
  },
  "Source": 381,
  "ActiveErpLinks": 799,
  "BounceEmails": [
    "jon_rempel@lynchgleason.us",
    "darius.okon@mcclurepredovic.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Leopold Hudson",
    "SuperOffice:2": "Keenan Homenick"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "delectus",
    "CustomFields2": "beatae"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "utilize global e-business"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 266
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```