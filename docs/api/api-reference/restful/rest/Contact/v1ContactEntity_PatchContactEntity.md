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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "dolor",
    "value": {
      "value1": {
        "PrimaryKey": 9148,
        "EntityName": "person",
        "personId": 9148,
        "fullName": "Justice Langworth"
      },
      "value2": {
        "PrimaryKey": 1272,
        "EntityName": "sale",
        "saleId": 1272,
        "contactId": 7633,
        "name": "Grady, Cremin and Doyle"
      }
    }
  },
  {
    "op": "add",
    "path": "dolor",
    "value": {
      "value1": {
        "PrimaryKey": 9148,
        "EntityName": "person",
        "personId": 9148,
        "fullName": "Justice Langworth"
      },
      "value2": {
        "PrimaryKey": 1272,
        "EntityName": "sale",
        "saleId": 1272,
        "contactId": 7633,
        "name": "Grady, Cremin and Doyle"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 661,
  "Name": "Jast, Cormier and Kuvalis",
  "Department": "",
  "OrgNr": "402536",
  "Number1": "555571",
  "Number2": "1022990",
  "UpdatedDate": "2007-08-12T09:40:58.9733704+02:00",
  "CreatedDate": "2020-05-14T09:40:58.9733704+02:00",
  "Emails": [
    {
      "Value": "inventore",
      "StrippedValue": "sed",
      "Description": "Programmable assymetric parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "sed",
      "Description": "Programmable assymetric parallelism",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 656,
      "Name": "Kuvalis LLC",
      "ToolTip": "Quia sed cumque pariatur at mollitia.",
      "Deleted": false,
      "Rank": 857,
      "Type": "modi",
      "ColorBlock": 470,
      "IconHint": "dolore",
      "Selected": true,
      "LastChanged": "2005-05-17T09:40:58.9743712+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "cum",
      "Hidden": true,
      "FullName": "Keaton Witting",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "autem",
      "Description": "Reduced local instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 649
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "autem",
      "Description": "Reduced local instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 649
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "consectetur",
      "Description": "Balanced grid-enabled middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "consectetur",
      "Description": "Balanced grid-enabled middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "eum",
      "Description": "Face to face didactic process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "eum",
      "Description": "Face to face didactic process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    }
  ],
  "Description": "Ameliorated exuding forecast",
  "UpdatedBy": {
    "AssociateId": 296,
    "Name": "Reilly, Keeling and Renner",
    "PersonId": 131,
    "Rank": 871,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 153,
    "FullName": "Mrs. Jimmie Lehner",
    "FormalName": "Luettgen LLC",
    "Deleted": true,
    "EjUserId": 61,
    "UserName": "Cartwright, Ullrich and Volkman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 563
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 504,
    "Name": "Stanton LLC",
    "PersonId": 850,
    "Rank": 837,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 290,
    "FullName": "Carrie Langworth II",
    "FormalName": "Von-Pagac",
    "Deleted": true,
    "EjUserId": 24,
    "UserName": "Morissette Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 324
      }
    }
  },
  "Associate": {
    "AssociateId": 611,
    "Name": "Weimann Group",
    "PersonId": 150,
    "Rank": 492,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 201,
    "FullName": "Luz Emmerich",
    "FormalName": "Robel-Weber",
    "Deleted": true,
    "EjUserId": 272,
    "UserName": "Carter-Lindgren",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 239
      }
    }
  },
  "Business": {
    "Id": 68,
    "Value": "aut",
    "Tooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash back-end eyeballs"
        },
        "FieldType": "System.String",
        "FieldLength": 658
      }
    }
  },
  "Category": {
    "Id": 87,
    "Value": "libero",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 32
      }
    }
  },
  "Country": {
    "CountryId": 2,
    "Name": "Leannon-Parisian",
    "CurrencyId": 714,
    "EnglishName": "Feest, Mosciski and Satterfield",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Enhanced hybrid throughput",
    "OrgNrText": "653641",
    "InterAreaPrefix": "et",
    "DialInPrefix": "exercitationem",
    "ZipPrefix": "natus",
    "DomainName": "Pollich, Dicki and Cremin",
    "AddressLayoutId": 281,
    "DomesticAddressLayoutId": 109,
    "ForeignAddressLayoutId": 133,
    "Rank": 798,
    "Tooltip": "suscipit",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 68
      }
    }
  },
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 267,
      "Mrmrs": "voluptas",
      "Firstname": "Tanya",
      "Lastname": "Considine",
      "MiddleName": "Zieme, Boehm and Quigley",
      "Title": "inventore",
      "Description": "Integrated encompassing software",
      "Email": "blake@cormierhackett.uk",
      "FullName": "Gregg Mitchell",
      "DirectPhone": "363-201-3054 x0375",
      "FormalName": "West, Dickinson and Bernhard",
      "CountryId": 574,
      "ContactId": 596,
      "ContactName": "Jacobi LLC",
      "Retired": 491,
      "Rank": 734,
      "ActiveInterests": 299,
      "ContactDepartment": "streamline enterprise channels",
      "ContactCountryId": 84,
      "ContactOrgNr": "1144436",
      "FaxPhone": "1-432-684-1067 x6628",
      "MobilePhone": "322-704-0285 x702",
      "ContactPhone": "(432)101-3540",
      "AssociateName": "Kihn Inc and Sons",
      "AssociateId": 669,
      "UsePersonAddress": false,
      "ContactFax": "delectus",
      "Kanafname": "dolores",
      "Kanalname": "qui",
      "Post1": "dolor",
      "Post2": "ut",
      "Post3": "iusto",
      "EmailName": "favian@durgan.info",
      "ContactFullName": "Dianna Kuhlman",
      "ActiveErpLinks": 519,
      "TicketPriorityId": 634,
      "SupportLanguageId": 231,
      "SupportAssociateId": 828,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quas",
  "Xstop": true,
  "ActiveInterests": 635,
  "GroupId": 214,
  "ActiveStatusMonitorId": 621,
  "SupportAssociate": {
    "AssociateId": 809,
    "Name": "Okuneva, Stracke and Kunde",
    "PersonId": 606,
    "Rank": 195,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Herminia Stracke",
    "FormalName": "Moen-Franecki",
    "Deleted": true,
    "EjUserId": 139,
    "UserName": "Harvey Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  },
  "TicketPriority": {
    "Id": 553,
    "Value": "nihil",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "grow best-of-breed e-markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 923
      }
    }
  },
  "CustomerLanguage": {
    "Id": 768,
    "Value": "quia",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 282
      }
    }
  },
  "Deleted": 368,
  "DbiAgentId": 266,
  "DbiLastSyncronized": "1994-12-29T09:40:58.9783734+01:00",
  "DbiKey": "delectus",
  "DbiLastModified": "2007-08-25T09:40:58.9783734+02:00",
  "SupportPerson": {
    "Position": "veniam",
    "PersonId": 55,
    "Mrmrs": "veritatis",
    "Firstname": "Clarabelle",
    "Lastname": "Feeney",
    "MiddleName": "White Inc and Sons",
    "Title": "libero",
    "Description": "Reverse-engineered bottom-line time-frame",
    "Email": "tiffany@hanenienow.us",
    "FullName": "Kenya Johnston",
    "DirectPhone": "728-186-3081",
    "FormalName": "Hegmann Inc and Sons",
    "CountryId": 120,
    "ContactId": 733,
    "ContactName": "Skiles-Hirthe",
    "Retired": 610,
    "Rank": 114,
    "ActiveInterests": 422,
    "ContactDepartment": "",
    "ContactCountryId": 271,
    "ContactOrgNr": "1229105",
    "FaxPhone": "1-482-206-5328",
    "MobilePhone": "783-756-0618",
    "ContactPhone": "1-503-482-7685",
    "AssociateName": "Nitzsche Inc and Sons",
    "AssociateId": 500,
    "UsePersonAddress": false,
    "ContactFax": "illo",
    "Kanafname": "porro",
    "Kanalname": "voluptas",
    "Post1": "veniam",
    "Post2": "voluptate",
    "Post3": "quia",
    "EmailName": "dulce.lueilwitz@johnson.com",
    "ContactFullName": "Keshawn Roob",
    "ActiveErpLinks": 321,
    "TicketPriorityId": 581,
    "SupportLanguageId": 544,
    "SupportAssociateId": 967,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 203
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 9119.94,
    "Wgs84Longitude": 25119.01,
    "LocalizedAddress": [
      [
        {
          "Name": "Will Inc and Sons",
          "Value": "veniam",
          "Tooltip": "aut",
          "Label": "ducimus",
          "ValueLength": 117,
          "AddressType": "maiores",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "target one-to-one methodologies"
              },
              "FieldType": "System.Int32",
              "FieldLength": 545
            }
          }
        }
      ],
      [
        {
          "Name": "Kub, Ratke and Hyatt",
          "Value": "ullam",
          "Tooltip": "eligendi",
          "Label": "vitae",
          "ValueLength": 994,
          "AddressType": "quae",
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
              "FieldLength": 765
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 333
      }
    }
  },
  "Source": 633,
  "ActiveErpLinks": 87,
  "BounceEmails": [
    "jenifer@braun.com",
    "billy@mcdermottabernathy.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Annamarie Barton DDS",
    "SuperOffice:2": "Haylie Spinka Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "et"
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
      "FieldType": "System.Int32",
      "FieldLength": 977
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```