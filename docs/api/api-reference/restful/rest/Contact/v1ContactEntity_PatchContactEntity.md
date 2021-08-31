---
title: PATCH Contact/{id}
id: v1ContactEntity_PatchContactEntity
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "occaecati",
    "value": {
      "value1": {
        "PrimaryKey": 8601,
        "EntityName": "person",
        "personId": 8601,
        "fullName": "Lawson Walter"
      },
      "value2": {
        "PrimaryKey": 7458,
        "EntityName": "sale",
        "saleId": 7458,
        "contactId": 6314,
        "name": "Kuvalis-Miller"
      }
    }
  },
  {
    "op": "add",
    "path": "occaecati",
    "value": {
      "value1": {
        "PrimaryKey": 8601,
        "EntityName": "person",
        "personId": 8601,
        "fullName": "Lawson Walter"
      },
      "value2": {
        "PrimaryKey": 7458,
        "EntityName": "sale",
        "saleId": 7458,
        "contactId": 6314,
        "name": "Kuvalis-Miller"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 677,
  "Name": "Mohr Group",
  "Department": "",
  "OrgNr": "1021959",
  "Number1": "393783",
  "Number2": "1814312",
  "UpdatedDate": "1996-11-01T15:05:41.9490099+01:00",
  "CreatedDate": "1995-01-04T15:05:41.9490099+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "modi",
      "Description": "Streamlined mission-critical structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "strategize B2C technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "modi",
      "Description": "Streamlined mission-critical structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "strategize B2C technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 500,
      "Name": "Torphy, Predovic and Abbott",
      "ToolTip": "Repudiandae minus illum molestiae.",
      "Deleted": false,
      "Rank": 950,
      "Type": "accusantium",
      "ColorBlock": 19,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2008-02-14T15:05:41.9500072+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Sammie Labadie",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 303
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "quod",
      "Description": "Enterprise-wide fresh-thinking definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quod",
      "Description": "Enterprise-wide fresh-thinking definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "rerum",
      "Description": "Customer-focused static infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "rerum",
      "Description": "Customer-focused static infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "eos",
      "Description": "Focused assymetric benchmark",
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
    {
      "Value": "dolores",
      "StrippedValue": "eos",
      "Description": "Focused assymetric benchmark",
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
    }
  ],
  "Description": "Cross-platform discrete adapter",
  "UpdatedBy": {
    "AssociateId": 836,
    "Name": "Sawayn LLC",
    "PersonId": 555,
    "Rank": 774,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 315,
    "FullName": "Adolf Rempel",
    "FormalName": "Okuneva, Olson and Kuhlman",
    "Deleted": true,
    "EjUserId": 608,
    "UserName": "Collins-Kunze",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace mission-critical models"
        },
        "FieldType": "System.String",
        "FieldLength": 296
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 720,
    "Name": "Fisher Inc and Sons",
    "PersonId": 867,
    "Rank": 304,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 46,
    "FullName": "Walter Romaguera",
    "FormalName": "Kreiger, Schamberger and Goyette",
    "Deleted": true,
    "EjUserId": 407,
    "UserName": "Brakus LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 886
      }
    }
  },
  "Associate": {
    "AssociateId": 336,
    "Name": "Pfeffer-Koelpin",
    "PersonId": 362,
    "Rank": 68,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 128,
    "FullName": "Miss Sallie Kassulke",
    "FormalName": "Williamson Group",
    "Deleted": false,
    "EjUserId": 685,
    "UserName": "Hoeger-Langworth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 838
      }
    }
  },
  "Business": {
    "Id": 302,
    "Value": "consectetur",
    "Tooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 969
      }
    }
  },
  "Category": {
    "Id": 224,
    "Value": "quae",
    "Tooltip": "vero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 354
      }
    }
  },
  "Country": {
    "CountryId": 684,
    "Name": "Kuhn-Wolff",
    "CurrencyId": 111,
    "EnglishName": "Parisian Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Streamlined global installation",
    "OrgNrText": "1688591",
    "InterAreaPrefix": "fuga",
    "DialInPrefix": "voluptas",
    "ZipPrefix": "omnis",
    "DomainName": "Collier-Hoppe",
    "AddressLayoutId": 304,
    "DomesticAddressLayoutId": 883,
    "ForeignAddressLayoutId": 462,
    "Rank": 878,
    "Tooltip": "recusandae",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 963
      }
    }
  },
  "Persons": [
    {
      "Position": "dolorum",
      "PersonId": 279,
      "Mrmrs": "quia",
      "Firstname": "Eveline",
      "Lastname": "Beatty",
      "MiddleName": "Runolfsson-Torp",
      "Title": "voluptatum",
      "Description": "Customizable even-keeled migration",
      "Email": "carmen@schultz.com",
      "FullName": "Eli Gerhold V",
      "DirectPhone": "1-216-805-1766 x313",
      "FormalName": "Kutch-Zboncak",
      "CountryId": 368,
      "ContactId": 501,
      "ContactName": "Jacobson Inc and Sons",
      "Retired": 524,
      "Rank": 318,
      "ActiveInterests": 513,
      "ContactDepartment": "scale compelling functionalities",
      "ContactCountryId": 779,
      "ContactOrgNr": "1221492",
      "FaxPhone": "670-757-7332",
      "MobilePhone": "708-528-1778 x1167",
      "ContactPhone": "726-107-3245",
      "AssociateName": "O'Hara-Hermiston",
      "AssociateId": 543,
      "UsePersonAddress": false,
      "ContactFax": "inventore",
      "Kanafname": "et",
      "Kanalname": "iusto",
      "Post1": "sunt",
      "Post2": "sapiente",
      "Post3": "quae",
      "EmailName": "antonette_miller@wisokyjacobi.co.uk",
      "ContactFullName": "Magnus Champlin",
      "ActiveErpLinks": 210,
      "TicketPriorityId": 748,
      "SupportLanguageId": 425,
      "SupportAssociateId": 750,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 150,
  "GroupId": 183,
  "ActiveStatusMonitorId": 791,
  "SupportAssociate": {
    "AssociateId": 431,
    "Name": "Orn, Deckow and Balistreri",
    "PersonId": 257,
    "Rank": 497,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 929,
    "FullName": "Mr. Marlon Will",
    "FormalName": "Bahringer-Gutmann",
    "Deleted": false,
    "EjUserId": 817,
    "UserName": "Barrows Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 665
      }
    }
  },
  "TicketPriority": {
    "Id": 751,
    "Value": "ex",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 603
      }
    }
  },
  "CustomerLanguage": {
    "Id": 341,
    "Value": "quidem",
    "Tooltip": "quo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 600
      }
    }
  },
  "Deleted": 971,
  "DbiAgentId": 905,
  "DbiLastSyncronized": "2004-11-25T15:05:41.9620049+01:00",
  "DbiKey": "omnis",
  "DbiLastModified": "2017-07-06T15:05:41.9620049+02:00",
  "SupportPerson": {
    "Position": "numquam",
    "PersonId": 368,
    "Mrmrs": "in",
    "Firstname": "Berry",
    "Lastname": "Beahan",
    "MiddleName": "Goldner LLC",
    "Title": "architecto",
    "Description": "Organic clear-thinking knowledge user",
    "Email": "gladys.hermann@mills.co.uk",
    "FullName": "Mrs. Josiah Dietrich",
    "DirectPhone": "170-781-3108",
    "FormalName": "Kuhlman Inc and Sons",
    "CountryId": 320,
    "ContactId": 364,
    "ContactName": "Wisoky Group",
    "Retired": 951,
    "Rank": 328,
    "ActiveInterests": 47,
    "ContactDepartment": "",
    "ContactCountryId": 513,
    "ContactOrgNr": "986854",
    "FaxPhone": "401.237.8083 x471",
    "MobilePhone": "635.307.8227",
    "ContactPhone": "1-357-863-5335",
    "AssociateName": "Abbott-Schaden",
    "AssociateId": 617,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "itaque",
    "Kanalname": "sunt",
    "Post1": "officia",
    "Post2": "est",
    "Post3": "aut",
    "EmailName": "madyson@gleichner.com",
    "ContactFullName": "Mrs. Alysha Beatty",
    "ActiveErpLinks": 225,
    "TicketPriorityId": 89,
    "SupportLanguageId": 956,
    "SupportAssociateId": 528,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 396
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 24570.559999999998,
    "Wgs84Longitude": 24539.219999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Green, Nader and Wilderman",
          "Value": "ipsa",
          "Tooltip": "quidem",
          "Label": "exercitationem",
          "ValueLength": 328,
          "AddressType": "tempora",
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
              "FieldLength": 628
            }
          }
        }
      ],
      [
        {
          "Name": "Morar-Welch",
          "Value": "eius",
          "Tooltip": "pariatur",
          "Label": "error",
          "ValueLength": 991,
          "AddressType": "incidunt",
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
              "FieldLength": 51
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate frictionless deliverables"
        },
        "FieldType": "System.String",
        "FieldLength": 238
      }
    }
  },
  "Source": 864,
  "ActiveErpLinks": 821,
  "BounceEmails": [
    "anibal.murray@cassin.info",
    "rosario@gerlachkreiger.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Sophia Kertzmann",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "accusamus"
  },
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
      "FieldLength": 601
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```