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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
    "path": "impedit",
    "value": {
      "value1": {
        "PrimaryKey": 1311,
        "EntityName": "sale",
        "saleId": 1311,
        "contactId": 672,
        "name": "Casper, Zieme and Cartwright"
      },
      "value2": {
        "PrimaryKey": 2172,
        "EntityName": "sale",
        "saleId": 2172,
        "contactId": 340,
        "name": "Abbott-Watsica"
      }
    }
  },
  {
    "op": "add",
    "path": "impedit",
    "value": {
      "value1": {
        "PrimaryKey": 1311,
        "EntityName": "sale",
        "saleId": 1311,
        "contactId": 672,
        "name": "Casper, Zieme and Cartwright"
      },
      "value2": {
        "PrimaryKey": 2172,
        "EntityName": "sale",
        "saleId": 2172,
        "contactId": 340,
        "name": "Abbott-Watsica"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 749,
  "Name": "Quitzon LLC",
  "Department": "",
  "OrgNr": "1441811",
  "Number1": "530581",
  "Number2": "1320786",
  "UpdatedDate": "2015-01-31T18:25:50.308594+01:00",
  "CreatedDate": "2004-06-06T18:25:50.308594+02:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "molestias",
      "Description": "Distributed optimizing collaboration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "molestias",
      "Description": "Distributed optimizing collaboration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 86,
      "Name": "Sawayn, Roob and Johnson",
      "ToolTip": "Qui labore numquam eligendi quia necessitatibus odit.",
      "Deleted": true,
      "Rank": 822,
      "Type": "praesentium",
      "ColorBlock": 180,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2009-09-21T18:25:50.3096203+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Elena Auer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 110
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "vitae",
      "Description": "Ameliorated contextually-based initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "vitae",
      "Description": "Ameliorated contextually-based initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "error",
      "StrippedValue": "quis",
      "Description": "Focused object-oriented project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "quis",
      "Description": "Focused object-oriented project",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "dicta",
      "Description": "Visionary assymetric throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "dicta",
      "Description": "Visionary assymetric throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "Description": "Vision-oriented 6th generation support",
  "UpdatedBy": {
    "AssociateId": 626,
    "Name": "Cremin-Heidenreich",
    "PersonId": 269,
    "Rank": 358,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 926,
    "FullName": "Odie Weber",
    "FormalName": "Graham, Hamill and Stracke",
    "Deleted": true,
    "EjUserId": 53,
    "UserName": "Hilll, Pfeffer and Dibbert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 245
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 835,
    "Name": "Lynch-Wisozk",
    "PersonId": 566,
    "Rank": 43,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 644,
    "FullName": "Faye Prohaska",
    "FormalName": "Brekke Inc and Sons",
    "Deleted": false,
    "EjUserId": 319,
    "UserName": "Corwin Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 660
      }
    }
  },
  "Associate": {
    "AssociateId": 948,
    "Name": "Lesch Group",
    "PersonId": 193,
    "Rank": 216,
    "Tooltip": "vero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 580,
    "FullName": "Ms. Verlie DuBuque",
    "FormalName": "Konopelski, Hammes and Watsica",
    "Deleted": false,
    "EjUserId": 64,
    "UserName": "Heidenreich, Kuhn and Gerhold",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 37
      }
    }
  },
  "Business": {
    "Id": 259,
    "Value": "et",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 932
      }
    }
  },
  "Category": {
    "Id": 741,
    "Value": "molestiae",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 720
      }
    }
  },
  "Country": {
    "CountryId": 18,
    "Name": "Kuhic Group",
    "CurrencyId": 629,
    "EnglishName": "McCullough, Davis and Price",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Persistent stable definition",
    "OrgNrText": "1368700",
    "InterAreaPrefix": "veritatis",
    "DialInPrefix": "illum",
    "ZipPrefix": "ut",
    "DomainName": "Oberbrunner LLC",
    "AddressLayoutId": 21,
    "DomesticAddressLayoutId": 541,
    "ForeignAddressLayoutId": 584,
    "Rank": 774,
    "Tooltip": "ea",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 828
      }
    }
  },
  "Persons": [
    {
      "Position": "molestias",
      "PersonId": 549,
      "Mrmrs": "libero",
      "Firstname": "Trudie",
      "Lastname": "Lebsack",
      "MiddleName": "Monahan Inc and Sons",
      "Title": "et",
      "Description": "Future-proofed client-server service-desk",
      "Email": "sigrid_zemlak@mohr.ca",
      "FullName": "Buck Bayer",
      "DirectPhone": "372-780-5704",
      "FormalName": "Corwin Group",
      "CountryId": 447,
      "ContactId": 976,
      "ContactName": "Mann Inc and Sons",
      "Retired": 889,
      "Rank": 236,
      "ActiveInterests": 591,
      "ContactDepartment": "",
      "ContactCountryId": 716,
      "ContactOrgNr": "1566752",
      "FaxPhone": "(117)803-5612 x31757",
      "MobilePhone": "617-525-5382 x275",
      "ContactPhone": "1-057-173-8035 x48255",
      "AssociateName": "Gottlieb-Graham",
      "AssociateId": 452,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "quis",
      "Kanalname": "perspiciatis",
      "Post1": "dolores",
      "Post2": "omnis",
      "Post3": "vel",
      "EmailName": "dominic@raynor.biz",
      "ContactFullName": "Howell King",
      "ActiveErpLinks": 653,
      "TicketPriorityId": 699,
      "SupportLanguageId": 273,
      "SupportAssociateId": 94,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 433,
  "GroupId": 258,
  "ActiveStatusMonitorId": 526,
  "SupportAssociate": {
    "AssociateId": 949,
    "Name": "Marquardt-Heathcote",
    "PersonId": 768,
    "Rank": 459,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 718,
    "FullName": "Wyman Kling",
    "FormalName": "Batz, Lueilwitz and Marvin",
    "Deleted": true,
    "EjUserId": 736,
    "UserName": "Torp LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 609
      }
    }
  },
  "TicketPriority": {
    "Id": 823,
    "Value": "est",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 773
      }
    }
  },
  "CustomerLanguage": {
    "Id": 869,
    "Value": "consequatur",
    "Tooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 377
      }
    }
  },
  "Deleted": 435,
  "DbiAgentId": 377,
  "DbiLastSyncronized": "2007-10-02T18:25:50.3146243+02:00",
  "DbiKey": "sed",
  "DbiLastModified": "2008-09-24T18:25:50.3146243+02:00",
  "SupportPerson": {
    "Position": "nisi",
    "PersonId": 698,
    "Mrmrs": "quidem",
    "Firstname": "Johan",
    "Lastname": "Dietrich",
    "MiddleName": "Crooks Inc and Sons",
    "Title": "fuga",
    "Description": "User-centric composite data-warehouse",
    "Email": "waylon@dach.com",
    "FullName": "Naomi Keeling",
    "DirectPhone": "(587)700-8270 x86026",
    "FormalName": "DuBuque, Lakin and Hermiston",
    "CountryId": 954,
    "ContactId": 82,
    "ContactName": "Brown-Funk",
    "Retired": 403,
    "Rank": 741,
    "ActiveInterests": 562,
    "ContactDepartment": "",
    "ContactCountryId": 77,
    "ContactOrgNr": "1189081",
    "FaxPhone": "778.243.0466 x31116",
    "MobilePhone": "1-448-734-7875 x33441",
    "ContactPhone": "008-233-3737 x2328",
    "AssociateName": "Donnelly Inc and Sons",
    "AssociateId": 654,
    "UsePersonAddress": false,
    "ContactFax": "consectetur",
    "Kanafname": "sunt",
    "Kanalname": "repellat",
    "Post1": "et",
    "Post2": "hic",
    "Post3": "sit",
    "EmailName": "kacie@bechtelar.uk",
    "ContactFullName": "Bianka Cormier",
    "ActiveErpLinks": 149,
    "TicketPriorityId": 398,
    "SupportLanguageId": 574,
    "SupportAssociateId": 246,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 6571.998,
    "Wgs84Longitude": 10856.176,
    "LocalizedAddress": [
      [
        {
          "Name": "Padberg, Nolan and Kautzer",
          "Value": "praesentium",
          "Tooltip": "voluptatem",
          "Label": "aut",
          "ValueLength": 539,
          "AddressType": "quisquam",
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
              "FieldLength": 910
            }
          }
        }
      ],
      [
        {
          "Name": "Lehner, Bode and Rohan",
          "Value": "ipsa",
          "Tooltip": "repellat",
          "Label": "animi",
          "ValueLength": 283,
          "AddressType": "laboriosam",
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
              "FieldLength": 354
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "eligendi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 236
      }
    }
  },
  "Source": 614,
  "ActiveErpLinks": 245,
  "BounceEmails": [
    "orland.lueilwitz@welch.us",
    "perry_gleichner@daviskoelpin.ca"
  ],
  "Domains": [
    "architecto",
    "velit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "2050630339"
  },
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "omnis"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "architect customized web-readiness"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 479
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```