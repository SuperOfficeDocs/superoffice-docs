---
title: CreateDefaultByContactId
id: v1PersonAgent_CreateDefaultByContactId
---

# CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
```


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

## Request Body: request  

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 974
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 151,
  "Firstname": "Solon",
  "MiddleName": "Keebler-Flatley",
  "Lastname": "Marks",
  "Mrmrs": "ut",
  "Title": "et",
  "UpdatedDate": "2008-02-07T14:58:04.7884296+01:00",
  "CreatedDate": "1996-10-21T14:58:04.7884296+02:00",
  "BirthDate": "2019-04-15T14:58:04.7884296+02:00",
  "CreatedBy": {
    "AssociateId": 919,
    "Name": "Hamill Group",
    "PersonId": 952,
    "Rank": 491,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 899,
    "FullName": "Dianna Bailey",
    "FormalName": "Ernser-Jast",
    "Deleted": false,
    "EjUserId": 832,
    "UserName": "Howe, Hane and Kovacek",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 528
      }
    }
  },
  "Emails": [
    {
      "Value": "neque",
      "StrippedValue": "odit",
      "Description": "Multi-tiered 3rd generation matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate magnetic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "odit",
      "Description": "Multi-tiered 3rd generation matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate magnetic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Description": "Ergonomic grid-enabled archive",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "sit",
      "Description": "Pre-emptive user-facing algorithm",
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
    {
      "Value": "dolorem",
      "StrippedValue": "sit",
      "Description": "Pre-emptive user-facing algorithm",
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
    }
  ],
  "Faxes": [
    {
      "Value": "inventore",
      "StrippedValue": "fuga",
      "Description": "Managed heuristic challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "fuga",
      "Description": "Managed heuristic challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "facere",
      "StrippedValue": "iure",
      "Description": "Virtual motivating instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transition dynamic infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "iure",
      "Description": "Virtual motivating instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transition dynamic infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sit",
      "StrippedValue": "voluptatem",
      "Description": "Centralized fresh-thinking data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 780
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "voluptatem",
      "Description": "Centralized fresh-thinking data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 780
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ea",
      "StrippedValue": "quisquam",
      "Description": "Centralized actuating capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quisquam",
      "Description": "Centralized actuating capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    }
  ],
  "Position": {
    "Id": 557,
    "Value": "a",
    "Tooltip": "error",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 69
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 938,
    "Name": "Renner-Carroll",
    "PersonId": 435,
    "Rank": 629,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 263,
    "FullName": "Delfina Schuster",
    "FormalName": "Trantow-Fay",
    "Deleted": false,
    "EjUserId": 838,
    "UserName": "Schultz Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 842
      }
    }
  },
  "Contact": {
    "ContactId": 464,
    "Name": "Berge Group",
    "OrgNr": "894094",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "in",
    "DirectPhone": "667-246-2517 x16501",
    "AssociateId": 951,
    "CountryId": 375,
    "EmailAddress": "aniyah@hyatt.us",
    "Kananame": "voluptas",
    "EmailAddressName": "constance@ebert.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Obie Dibbert V",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "omnis",
    "FullName": "Bennett Will",
    "IsOwnerContact": false,
    "ActiveErpLinks": 302,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 676
      }
    }
  },
  "Country": {
    "CountryId": 997,
    "Name": "Trantow-Pagac",
    "CurrencyId": 391,
    "EnglishName": "Rippin-Kihn",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Streamlined encompassing installation",
    "OrgNrText": "435530",
    "InterAreaPrefix": "et",
    "DialInPrefix": "repellat",
    "ZipPrefix": "animi",
    "DomainName": "Stokes-Thompson",
    "AddressLayoutId": 612,
    "DomesticAddressLayoutId": 115,
    "ForeignAddressLayoutId": 824,
    "Rank": 680,
    "Tooltip": "aut",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 243
      }
    }
  },
  "Interests": [
    {
      "Id": 653,
      "Name": "Prohaska Inc and Sons",
      "ToolTip": "Cupiditate illo molestias quia aliquid.",
      "Deleted": true,
      "Rank": 334,
      "Type": "quas",
      "ColorBlock": 693,
      "IconHint": "natus",
      "Selected": true,
      "LastChanged": "2006-08-21T14:58:04.7904599+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Rupert Rath",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "PersonNumber": "1377749",
  "FullName": "Ms. Betty Hettinger",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "provident",
      "Description": "Integrated reciprocal matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "provident",
      "Description": "Integrated reciprocal matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "FormalName": "Gislason LLC",
  "Address": {
    "Wgs84Latitude": 31324.329999999998,
    "Wgs84Longitude": 26200.239999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Schowalter LLC",
          "Value": "vel",
          "Tooltip": "et",
          "Label": "vitae",
          "ValueLength": 686,
          "AddressType": "neque",
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
              "FieldLength": 108
            }
          }
        }
      ],
      [
        {
          "Name": "Gislason-Gorczany",
          "Value": "dolores",
          "Tooltip": "ut",
          "Label": "suscipit",
          "ValueLength": 865,
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
              "FieldType": "System.String",
              "FieldLength": 557
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "repellendus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize 24/7 content"
        },
        "FieldType": "System.String",
        "FieldLength": 297
      }
    }
  },
  "Post3": "eos",
  "Post2": "totam",
  "Post1": "nihil",
  "Kanalname": "nesciunt",
  "Kanafname": "natus",
  "CorrespondingAssociate": {
    "AssociateId": 601,
    "Name": "Kulas LLC",
    "PersonId": 279,
    "Rank": 117,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 420,
    "FullName": "Ashton Jacobs",
    "FormalName": "Wisozk-Schamberger",
    "Deleted": true,
    "EjUserId": 479,
    "UserName": "Weissnat-Beahan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 846
      }
    }
  },
  "Category": {
    "Id": 399,
    "Value": "qui",
    "Tooltip": "culpa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 76
      }
    }
  },
  "Business": {
    "Id": 334,
    "Value": "ratione",
    "Tooltip": "aliquid",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 375
      }
    }
  },
  "Associate": {
    "AssociateId": 294,
    "Name": "Harvey Group",
    "PersonId": 49,
    "Rank": 498,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 777,
    "FullName": "Johnpaul Koepp",
    "FormalName": "Schamberger-Maggio",
    "Deleted": false,
    "EjUserId": 471,
    "UserName": "Kling-Kulas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 329
      }
    }
  },
  "Salutation": "est",
  "ActiveInterests": 646,
  "SupportAssociate": {
    "AssociateId": 677,
    "Name": "Jakubowski LLC",
    "PersonId": 979,
    "Rank": 763,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 662,
    "FullName": "Stephania Bechtelar",
    "FormalName": "Kautzer Inc and Sons",
    "Deleted": false,
    "EjUserId": 564,
    "UserName": "Reichel, Herman and Schultz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 614
      }
    }
  },
  "TicketPriority": {
    "Id": 879,
    "Value": "aut",
    "Tooltip": "voluptate",
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
  "CustomerLanguage": {
    "Id": 554,
    "Value": "eum",
    "Tooltip": "nihil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline one-to-one metrics"
        },
        "FieldType": "System.Int32",
        "FieldLength": 407
      }
    }
  },
  "DbiAgentId": 285,
  "DbiKey": "itaque",
  "DbiLastModified": "2016-01-25T14:58:04.7934601+01:00",
  "DbiLastSyncronized": "2000-09-19T14:58:04.7934601+02:00",
  "SentInfo": 446,
  "ShowContactTickets": 5,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 862,
    "UserName": "Treutel-Glover",
    "PersonId": 366,
    "Rank": 885,
    "Tooltip": "debitis",
    "UserGroupId": 924,
    "EjUserId": 252,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ipsa",
      "debitis"
    ],
    "CanLogon": false,
    "RoleName": "Barrows Inc and Sons",
    "RoleTooltip": "et",
    "UserGroupName": "Friesen, Nicolas and Oberbrunner",
    "UserGroupTooltip": "mollitia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 646
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "assumenda",
      "StrippedValue": "fugiat",
      "Description": "Total holistic array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "fugiat",
      "Description": "Total holistic array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "commodi",
      "Description": "Horizontal real-time ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "commodi",
      "Description": "Horizontal real-time ability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 282
        }
      }
    }
  ],
  "Source": 312,
  "ActiveErpLinks": 48,
  "ShipmentTypes": [
    {
      "Id": 103,
      "Name": "Gerlach-Mueller",
      "ToolTip": "Nostrum voluptate.",
      "Deleted": true,
      "Rank": 542,
      "Type": "sunt",
      "ColorBlock": 361,
      "IconHint": "nobis",
      "Selected": false,
      "LastChanged": "2009-09-04T14:58:04.7944599+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Dusty Murazik",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 102
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 839,
      "Comment": "et",
      "Registered": "2021-05-14T14:58:04.7944599+02:00",
      "RegisteredAssociateId": 460,
      "Updated": "2003-04-20T14:58:04.7944599+02:00",
      "UpdatedAssociateId": 733,
      "LegalBaseId": 487,
      "LegalBaseKey": "corrupti",
      "LegalBaseName": "Legros Inc and Sons",
      "ConsentPurposeId": 226,
      "ConsentPurposeKey": "commodi",
      "ConsentPurposeName": "Abernathy-Barton",
      "ConsentSourceId": 80,
      "ConsentSourceKey": "deserunt",
      "ConsentSourceName": "Thiel, Wehner and Collier",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "BounceEmails": [
    "emelia@hackettdamore.com",
    "keira_okeefe@kunde.info"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Alf Von",
    "SuperOffice:2": "Newton Block"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "ex"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "visualize robust schemas"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 879
    }
  }
}
```