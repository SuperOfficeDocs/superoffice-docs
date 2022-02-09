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
GET /api/v1/Contact/{id}?fk=True
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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
Last-Modified: Sat, 13 Mar 2021 18:25:50 G3T

{
  "ContactId": 376,
  "Name": "Franecki Group",
  "Department": "",
  "OrgNr": "268701",
  "Number1": "532720",
  "Number2": "1313394",
  "UpdatedDate": "2021-03-13T18:25:50.2705942+01:00",
  "CreatedDate": "2007-10-04T18:25:50.2705942+02:00",
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered 4th generation support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered 4th generation support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 242,
      "Name": "Marvin-Heaney",
      "ToolTip": "Reiciendis nesciunt consequatur alias voluptatem quia.",
      "Deleted": false,
      "Rank": 83,
      "Type": "vel",
      "ColorBlock": 538,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "1996-03-13T18:25:50.2705942+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Reynold Reilly",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement vertical e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quos",
      "StrippedValue": "laudantium",
      "Description": "Grass-roots disintermediate algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "laudantium",
      "Description": "Grass-roots disintermediate algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Configurable national architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Configurable national architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory motivating success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement proactive metrics"
          },
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptatem",
      "Description": "Mandatory motivating success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement proactive metrics"
          },
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Description": "User-centric optimal success",
  "UpdatedBy": {
    "AssociateId": 634,
    "Name": "Maggio-Schimmel",
    "PersonId": 14,
    "Rank": 463,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 674,
    "FullName": "Mrs. Vern Osinski",
    "FormalName": "Borer Group",
    "Deleted": true,
    "EjUserId": 701,
    "UserName": "Doyle-Strosin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize vertical models"
        },
        "FieldType": "System.String",
        "FieldLength": 640
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 53,
    "Name": "Cruickshank-Weimann",
    "PersonId": 194,
    "Rank": 591,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 356,
    "FullName": "Jerel Stamm",
    "FormalName": "Wisoky, Terry and Weimann",
    "Deleted": true,
    "EjUserId": 340,
    "UserName": "Schimmel, Breitenberg and VonRueden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 763
      }
    }
  },
  "Associate": {
    "AssociateId": 3,
    "Name": "Schneider-Wolff",
    "PersonId": 752,
    "Rank": 709,
    "Tooltip": "culpa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 850,
    "FullName": "Norma Boehm",
    "FormalName": "Zulauf, Hane and Rutherford",
    "Deleted": true,
    "EjUserId": 849,
    "UserName": "Bernhard-Keebler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 374
      }
    }
  },
  "Business": {
    "Id": 103,
    "Value": "rerum",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 389
      }
    }
  },
  "Category": {
    "Id": 662,
    "Value": "autem",
    "Tooltip": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 31
      }
    }
  },
  "Country": {
    "CountryId": 556,
    "Name": "Gaylord-Wiza",
    "CurrencyId": 798,
    "EnglishName": "Considine, Fisher and Lowe",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Fundamental neutral local area network",
    "OrgNrText": "927501",
    "InterAreaPrefix": "autem",
    "DialInPrefix": "qui",
    "ZipPrefix": "soluta",
    "DomainName": "Sporer, Gibson and Funk",
    "AddressLayoutId": 463,
    "DomesticAddressLayoutId": 339,
    "ForeignAddressLayoutId": 525,
    "Rank": 399,
    "Tooltip": "veritatis",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 130,
      "Mrmrs": "dolorem",
      "Firstname": "Giovanni",
      "Lastname": "Pagac",
      "MiddleName": "Cummings, Collier and Schumm",
      "Title": "ab",
      "Description": "Enhanced local circuit",
      "Email": "kyleigh@bradtke.com",
      "FullName": "Ms. Jade Gaylord",
      "DirectPhone": "1-141-778-2624 x6422",
      "FormalName": "Boyer, Cartwright and Nolan",
      "CountryId": 853,
      "ContactId": 475,
      "ContactName": "Kris Group",
      "Retired": 816,
      "Rank": 261,
      "ActiveInterests": 619,
      "ContactDepartment": "extend sticky infrastructures",
      "ContactCountryId": 618,
      "ContactOrgNr": "1497969",
      "FaxPhone": "440-284-7426 x5167",
      "MobilePhone": "(077)575-6535 x27451",
      "ContactPhone": "(155)630-7626 x61121",
      "AssociateName": "Goodwin, Watsica and Buckridge",
      "AssociateId": 240,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "dolor",
      "Kanalname": "distinctio",
      "Post1": "distinctio",
      "Post2": "voluptatem",
      "Post3": "dolorem",
      "EmailName": "green_champlin@kuhlman.co.uk",
      "ContactFullName": "Elfrieda Bradtke PhD",
      "ActiveErpLinks": 538,
      "TicketPriorityId": 433,
      "SupportLanguageId": 118,
      "SupportAssociateId": 446,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sed",
  "Xstop": true,
  "ActiveInterests": 580,
  "GroupId": 982,
  "ActiveStatusMonitorId": 479,
  "SupportAssociate": {
    "AssociateId": 431,
    "Name": "Beatty LLC",
    "PersonId": 363,
    "Rank": 846,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 590,
    "FullName": "Christopher Kiehn",
    "FormalName": "Dickinson LLC",
    "Deleted": false,
    "EjUserId": 27,
    "UserName": "Flatley LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 178
      }
    }
  },
  "TicketPriority": {
    "Id": 783,
    "Value": "voluptatem",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 14
      }
    }
  },
  "CustomerLanguage": {
    "Id": 569,
    "Value": "odit",
    "Tooltip": "id",
    "TableRight": {},
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
  },
  "Deleted": 857,
  "DbiAgentId": 716,
  "DbiLastSyncronized": "2012-01-31T18:25:50.2756241+01:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2002-06-14T18:25:50.2756241+02:00",
  "SupportPerson": {
    "Position": "occaecati",
    "PersonId": 411,
    "Mrmrs": "id",
    "Firstname": "Alba",
    "Lastname": "Torphy",
    "MiddleName": "Schultz, Jenkins and McClure",
    "Title": "id",
    "Description": "Phased motivating implementation",
    "Email": "arely@lowegraham.uk",
    "FullName": "Edmund Emard",
    "DirectPhone": "1-323-476-0416 x6138",
    "FormalName": "Barrows, Greenfelder and Greenholt",
    "CountryId": 160,
    "ContactId": 585,
    "ContactName": "Kuhlman, O'Conner and Howe",
    "Retired": 552,
    "Rank": 283,
    "ActiveInterests": 665,
    "ContactDepartment": "",
    "ContactCountryId": 427,
    "ContactOrgNr": "577660",
    "FaxPhone": "1-105-542-5831",
    "MobilePhone": "868.637.2161",
    "ContactPhone": "875-084-0211 x1503",
    "AssociateName": "Bechtelar LLC",
    "AssociateId": 1000,
    "UsePersonAddress": false,
    "ContactFax": "magnam",
    "Kanafname": "explicabo",
    "Kanalname": "et",
    "Post1": "in",
    "Post2": "sint",
    "Post3": "voluptas",
    "EmailName": "zakary_bruen@bailey.co.uk",
    "ContactFullName": "Alfonso Bednar",
    "ActiveErpLinks": 219,
    "TicketPriorityId": 828,
    "SupportLanguageId": 171,
    "SupportAssociateId": 919,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "revolutionize synergistic channels"
        },
        "FieldType": "System.String",
        "FieldLength": 866
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 12025.158,
    "Wgs84Longitude": 9449.01,
    "LocalizedAddress": [
      [
        {
          "Name": "Veum, Hoeger and Howell",
          "Value": "et",
          "Tooltip": "sapiente",
          "Label": "enim",
          "ValueLength": 596,
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
              "FieldType": "System.String",
              "FieldLength": 393
            }
          }
        }
      ],
      [
        {
          "Name": "Lueilwitz Group",
          "Value": "praesentium",
          "Tooltip": "numquam",
          "Label": "aspernatur",
          "ValueLength": 457,
          "AddressType": "officiis",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "engineer value-added partnerships"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 73
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "explicabo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 372
      }
    }
  },
  "Source": 130,
  "ActiveErpLinks": 587,
  "BounceEmails": [
    "lucie_hegmann@dachrodriguez.name",
    "theo@roberts.ca"
  ],
  "Domains": [
    "in",
    "nihil"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1090879938",
    "SuperOffice:2": "Kali Hamill"
  },
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "occaecati"
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
      "FieldLength": 955
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```