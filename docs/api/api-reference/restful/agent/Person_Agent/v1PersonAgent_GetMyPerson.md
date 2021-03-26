---
title: POST Agents/Person/GetMyPerson
id: v1PersonAgent_GetMyPerson
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 13,
  "Firstname": "Elizabeth",
  "MiddleName": "Bailey Group",
  "Lastname": "Breitenberg",
  "Mrmrs": "nihil",
  "Title": "rem",
  "UpdatedDate": "2016-03-19T16:48:30.111906+01:00",
  "CreatedDate": "2020-12-24T16:48:30.111906+01:00",
  "BirthDate": "1994-05-11T16:48:30.111906+02:00",
  "CreatedBy": {
    "AssociateId": 896,
    "Name": "Gottlieb, Thiel and Okuneva",
    "PersonId": 438,
    "Rank": 587,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 836,
    "FullName": "Ashleigh Tremblay DVM",
    "FormalName": "Reichel, Senger and Lehner",
    "Deleted": true,
    "EjUserId": 288,
    "UserName": "Altenwerth-Rogahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize impactful users"
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "esse",
      "Description": "Distributed value-added installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize leading-edge solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "esse",
      "Description": "Distributed value-added installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize leading-edge solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "Description": "Synergistic methodical conglomeration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Up-sized neutral implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "est",
      "Description": "Up-sized neutral implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "ut",
      "Description": "Implemented eco-centric success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "ut",
      "Description": "Implemented eco-centric success",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "voluptatum",
      "Description": "Devolved bifurcated alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "voluptatum",
      "Description": "Devolved bifurcated alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ab",
      "StrippedValue": "ipsam",
      "Description": "Synergistic encompassing architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "ipsam",
      "Description": "Synergistic encompassing architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "a",
      "StrippedValue": "dolore",
      "Description": "Automated maximized architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "dolore",
      "Description": "Automated maximized architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    }
  ],
  "Position": {
    "Id": 695,
    "Value": "non",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 188
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 323,
    "Name": "Conn, Spinka and Schulist",
    "PersonId": 428,
    "Rank": 59,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Leonora Towne",
    "FormalName": "Kerluke, Ortiz and Waters",
    "Deleted": true,
    "EjUserId": 462,
    "UserName": "Swift Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 338
      }
    }
  },
  "Contact": {
    "ContactId": 789,
    "Name": "Toy-Luettgen",
    "OrgNr": "907306",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quia",
    "DirectPhone": "835-453-0140 x55775",
    "AssociateId": 220,
    "CountryId": 474,
    "EmailAddress": "isai_shields@kling.info",
    "Kananame": "cum",
    "EmailAddressName": "dustin.thompson@morissette.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lula Kiehn",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "odit",
    "FullName": "Dorris Romaguera",
    "IsOwnerContact": true,
    "ActiveErpLinks": 790,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 808
      }
    }
  },
  "Country": {
    "CountryId": 313,
    "Name": "Kuhlman-Zemlak",
    "CurrencyId": 15,
    "EnglishName": "Leffler, Gerlach and Runolfsdottir",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Robust explicit encryption",
    "OrgNrText": "927329",
    "InterAreaPrefix": "et",
    "DialInPrefix": "architecto",
    "ZipPrefix": "id",
    "DomainName": "Goodwin-Abernathy",
    "AddressLayoutId": 501,
    "DomesticAddressLayoutId": 721,
    "ForeignAddressLayoutId": 562,
    "Rank": 182,
    "Tooltip": "beatae",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 474
      }
    }
  },
  "Interests": [
    {
      "Id": 69,
      "Name": "Ferry LLC",
      "ToolTip": "Occaecati tenetur tempore aut nam pariatur.",
      "Deleted": false,
      "Rank": 167,
      "Type": "illo",
      "ColorBlock": 330,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "2002-10-15T16:48:30.1159361+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "doloribus",
      "Hidden": true,
      "FullName": "Pete Dickinson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    }
  ],
  "PersonNumber": "1559739",
  "FullName": "Gerald Murazik",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "accusamus",
      "StrippedValue": "laboriosam",
      "Description": "Profound uniform Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 480
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "laboriosam",
      "Description": "Profound uniform Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 480
        }
      }
    }
  ],
  "FormalName": "Shields-Schuppe",
  "Address": {
    "Wgs84Latitude": 6484.246,
    "Wgs84Longitude": 1009.1479999999999,
    "LocalizedAddress": [
      [
        {
          "Name": "Franecki, Heidenreich and Fisher",
          "Value": "omnis",
          "Tooltip": "dolor",
          "Label": "amet",
          "ValueLength": 999,
          "AddressType": "itaque",
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
              "FieldLength": 894
            }
          }
        }
      ],
      [
        {
          "Name": "Nikolaus-Emmerich",
          "Value": "ea",
          "Tooltip": "amet",
          "Label": "iusto",
          "ValueLength": 223,
          "AddressType": "fugiat",
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
              "FieldLength": 231
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
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 913
      }
    }
  },
  "Post3": "repudiandae",
  "Post2": "tempore",
  "Post1": "quae",
  "Kanalname": "vero",
  "Kanafname": "molestiae",
  "CorrespondingAssociate": {
    "AssociateId": 812,
    "Name": "Lindgren-Vandervort",
    "PersonId": 990,
    "Rank": 186,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 960,
    "FullName": "Fidel Adams",
    "FormalName": "Harris, Beahan and Hand",
    "Deleted": false,
    "EjUserId": 510,
    "UserName": "Swaniawski-Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 447
      }
    }
  },
  "Category": {
    "Id": 76,
    "Value": "ullam",
    "Tooltip": "placeat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 735
      }
    }
  },
  "Business": {
    "Id": 213,
    "Value": "totam",
    "Tooltip": "a",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 258
      }
    }
  },
  "Associate": {
    "AssociateId": 214,
    "Name": "Ullrich Inc and Sons",
    "PersonId": 343,
    "Rank": 567,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 53,
    "FullName": "Miss Vivianne Feest",
    "FormalName": "Lindgren Inc and Sons",
    "Deleted": true,
    "EjUserId": 552,
    "UserName": "Durgan, Shields and Bauch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace compelling applications"
        },
        "FieldType": "System.String",
        "FieldLength": 552
      }
    }
  },
  "Salutation": "cumque",
  "ActiveInterests": 691,
  "SupportAssociate": {
    "AssociateId": 169,
    "Name": "Rowe LLC",
    "PersonId": 964,
    "Rank": 173,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 522,
    "FullName": "Adela Wehner",
    "FormalName": "Sporer LLC",
    "Deleted": false,
    "EjUserId": 850,
    "UserName": "Mosciski LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 964
      }
    }
  },
  "TicketPriority": {
    "Id": 978,
    "Value": "animi",
    "Tooltip": "sequi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 107
      }
    }
  },
  "CustomerLanguage": {
    "Id": 802,
    "Value": "ad",
    "Tooltip": "ratione",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 151
      }
    }
  },
  "DbiAgentId": 310,
  "DbiKey": "itaque",
  "DbiLastModified": "2015-10-29T16:48:30.1179336+01:00",
  "DbiLastSyncronized": "1997-03-07T16:48:30.1179336+01:00",
  "SentInfo": 122,
  "ShowContactTickets": 424,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 704,
    "UserName": "Bode, Bartell and Carter",
    "PersonId": 713,
    "Rank": 691,
    "Tooltip": "maiores",
    "UserGroupId": 953,
    "EjUserId": 135,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "quisquam",
      "expedita"
    ],
    "CanLogon": false,
    "RoleName": "Purdy-Crist",
    "RoleTooltip": "cumque",
    "UserGroupName": "Schmitt-O'Hara",
    "UserGroupTooltip": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 343
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "ducimus",
      "StrippedValue": "explicabo",
      "Description": "Vision-oriented didactic approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "explicabo",
      "Description": "Vision-oriented didactic approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "numquam",
      "Description": "Ergonomic maximized groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "numquam",
      "Description": "Ergonomic maximized groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "Source": 269,
  "ActiveErpLinks": 149,
  "ShipmentTypes": [
    {
      "Id": 3,
      "Name": "Gorczany-Hodkiewicz",
      "ToolTip": "Quidem qui omnis.",
      "Deleted": true,
      "Rank": 612,
      "Type": "nisi",
      "ColorBlock": 591,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2000-06-18T16:48:30.1189334+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Billy Kerluke",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 415,
      "Comment": "et",
      "Registered": "2016-04-24T16:48:30.1189334+02:00",
      "RegisteredAssociateId": 168,
      "Updated": "2018-08-26T16:48:30.1189334+02:00",
      "UpdatedAssociateId": 532,
      "LegalBaseId": 996,
      "LegalBaseKey": "laudantium",
      "LegalBaseName": "Dicki, Thiel and Wilderman",
      "ConsentPurposeId": 296,
      "ConsentPurposeKey": "accusamus",
      "ConsentPurposeName": "Willms-Barrows",
      "ConsentSourceId": 899,
      "ConsentSourceKey": "cum",
      "ConsentSourceName": "Price Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "BounceEmails": [
    "caesar_schneider@purdy.uk",
    "rosalind.bergnaum@kshlerin.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "474261763",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "veniam"
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
      "FieldLength": 647
    }
  }
}
```