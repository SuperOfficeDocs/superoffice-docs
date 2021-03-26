---
title: GET Person/{id}
id: v1PersonEntity_GetPersonEntity
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.

Calls the Person agent service GetPersonEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the PersonEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Person/{id}?$select=name,department,category/id
GET /api/v1/Person/{id}?fk=False
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

The Person Service. The service implements all services working with the Person object.



PersonEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 304 | PersonEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 16 May 2007 09:40:59 G5T

{
  "PersonId": 562,
  "Firstname": "Aliya",
  "MiddleName": "Ferry-Wisoky",
  "Lastname": "Howell",
  "Mrmrs": "quae",
  "Title": "dolor",
  "UpdatedDate": "2007-05-16T09:40:59.3266656+02:00",
  "CreatedDate": "2015-03-05T09:40:59.3266656+01:00",
  "BirthDate": "2019-08-27T09:40:59.3266656+02:00",
  "CreatedBy": {
    "AssociateId": 813,
    "Name": "Schumm, Labadie and Morar",
    "PersonId": 937,
    "Rank": 625,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 582,
    "FullName": "Theron Stoltenberg",
    "FormalName": "Franecki, Cole and Cummings",
    "Deleted": false,
    "EjUserId": 223,
    "UserName": "Kovacek Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 277
      }
    }
  },
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "ratione",
      "Description": "Programmable motivating instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "ratione",
      "Description": "Programmable motivating instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 697
        }
      }
    }
  ],
  "Description": "Inverse local circuit",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "id",
      "StrippedValue": "vero",
      "Description": "Automated intangible methodology",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 928
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "vero",
      "Description": "Automated intangible methodology",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 928
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "eos",
      "Description": "Multi-lateral composite adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "eos",
      "Description": "Multi-lateral composite adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Distributed clear-thinking contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Distributed clear-thinking contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "sint",
      "Description": "Mandatory intermediate portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "sint",
      "Description": "Mandatory intermediate portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "harum",
      "StrippedValue": "suscipit",
      "Description": "Profound leading edge info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "suscipit",
      "Description": "Profound leading edge info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    }
  ],
  "Position": {
    "Id": 141,
    "Value": "sint",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 749
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 859,
    "Name": "Wilderman, Labadie and Bernier",
    "PersonId": 612,
    "Rank": 946,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 83,
    "FullName": "Wanda Rosenbaum I",
    "FormalName": "Smitham Group",
    "Deleted": false,
    "EjUserId": 674,
    "UserName": "Hilll, Brown and Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix distributed e-services"
        },
        "FieldType": "System.String",
        "FieldLength": 413
      }
    }
  },
  "Contact": {
    "ContactId": 16,
    "Name": "Heller Group",
    "OrgNr": "1503342",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ipsa",
    "DirectPhone": "688-451-4687 x4887",
    "AssociateId": 490,
    "CountryId": 804,
    "EmailAddress": "selena_osinski@kohlermante.ca",
    "Kananame": "consequuntur",
    "EmailAddressName": "arvel.keebler@mertz.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Billie Terry",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "a",
    "FullName": "Sandy Hamill",
    "IsOwnerContact": true,
    "ActiveErpLinks": 933,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 187
      }
    }
  },
  "Country": {
    "CountryId": 21,
    "Name": "Dibbert Inc and Sons",
    "CurrencyId": 371,
    "EnglishName": "Fahey LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Networked homogeneous info-mediaries",
    "OrgNrText": "1014471",
    "InterAreaPrefix": "similique",
    "DialInPrefix": "rerum",
    "ZipPrefix": "quo",
    "DomainName": "Barrows-Paucek",
    "AddressLayoutId": 655,
    "DomesticAddressLayoutId": 846,
    "ForeignAddressLayoutId": 988,
    "Rank": 286,
    "Tooltip": "ratione",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 63
      }
    }
  },
  "Interests": [
    {
      "Id": 901,
      "Name": "Goyette-McKenzie",
      "ToolTip": "Aspernatur autem eaque.",
      "Deleted": true,
      "Rank": 628,
      "Type": "natus",
      "ColorBlock": 415,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2018-11-05T09:40:59.328665+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "doloremque",
      "Hidden": true,
      "FullName": "Jerrold Hayes",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend revolutionary metrics"
          },
          "FieldType": "System.String",
          "FieldLength": 484
        }
      }
    }
  ],
  "PersonNumber": "1010376",
  "FullName": "Alba Graham",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quos",
      "StrippedValue": "inventore",
      "Description": "Exclusive directional local area network",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "inventore",
      "Description": "Exclusive directional local area network",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "FormalName": "Hudson-Mills",
  "Address": {
    "Wgs84Latitude": 918.262,
    "Wgs84Longitude": 23269.95,
    "LocalizedAddress": [
      [
        {
          "Name": "Sawayn Inc and Sons",
          "Value": "perferendis",
          "Tooltip": "tenetur",
          "Label": "nihil",
          "ValueLength": 918,
          "AddressType": "non",
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
              "FieldLength": 234
            }
          }
        }
      ],
      [
        {
          "Name": "Lind Inc and Sons",
          "Value": "et",
          "Tooltip": "possimus",
          "Label": "vel",
          "ValueLength": 690,
          "AddressType": "in",
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
              "FieldLength": 504
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "distinctio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 669
      }
    }
  },
  "Post3": "suscipit",
  "Post2": "facilis",
  "Post1": "et",
  "Kanalname": "porro",
  "Kanafname": "nesciunt",
  "CorrespondingAssociate": {
    "AssociateId": 302,
    "Name": "Kuhn-Renner",
    "PersonId": 542,
    "Rank": 192,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 269,
    "FullName": "Eloise Senger",
    "FormalName": "Koss LLC",
    "Deleted": true,
    "EjUserId": 965,
    "UserName": "Sauer-Terry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 927
      }
    }
  },
  "Category": {
    "Id": 907,
    "Value": "fugit",
    "Tooltip": "ipsam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "Business": {
    "Id": 625,
    "Value": "suscipit",
    "Tooltip": "sapiente",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 852
      }
    }
  },
  "Associate": {
    "AssociateId": 270,
    "Name": "Baumbach, Lang and Conn",
    "PersonId": 174,
    "Rank": 497,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 302,
    "FullName": "Alize Kshlerin",
    "FormalName": "Schoen, Nicolas and Homenick",
    "Deleted": true,
    "EjUserId": 599,
    "UserName": "Kuvalis, Weber and Zemlak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 191
      }
    }
  },
  "Salutation": "alias",
  "ActiveInterests": 475,
  "SupportAssociate": {
    "AssociateId": 314,
    "Name": "Jast, Rice and Nolan",
    "PersonId": 883,
    "Rank": 395,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Karine Armstrong",
    "FormalName": "McCullough-Kris",
    "Deleted": true,
    "EjUserId": 477,
    "UserName": "Monahan LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 4
      }
    }
  },
  "TicketPriority": {
    "Id": 54,
    "Value": "et",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 989
      }
    }
  },
  "CustomerLanguage": {
    "Id": 464,
    "Value": "placeat",
    "Tooltip": "molestiae",
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
  "DbiAgentId": 601,
  "DbiKey": "reprehenderit",
  "DbiLastModified": "1994-06-27T09:40:59.3316655+02:00",
  "DbiLastSyncronized": "2014-09-17T09:40:59.3316655+02:00",
  "SentInfo": 907,
  "ShowContactTickets": 26,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 707,
    "UserName": "Stoltenberg, Waelchi and Herzog",
    "PersonId": 438,
    "Rank": 974,
    "Tooltip": "eum",
    "UserGroupId": 774,
    "EjUserId": 20,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "nihil",
      "assumenda"
    ],
    "CanLogon": true,
    "RoleName": "Wiegand Group",
    "RoleTooltip": "omnis",
    "UserGroupName": "Treutel Inc and Sons",
    "UserGroupTooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 385
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "rerum",
      "StrippedValue": "voluptatem",
      "Description": "Face to face uniform application",
      "TableRight": {},
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
    },
    {
      "Value": "rerum",
      "StrippedValue": "voluptatem",
      "Description": "Face to face uniform application",
      "TableRight": {},
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
  "InternetPhones": [
    {
      "Value": "totam",
      "StrippedValue": "eos",
      "Description": "Networked client-driven strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "eos",
      "Description": "Networked client-driven strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "Source": 293,
  "ActiveErpLinks": 611,
  "ShipmentTypes": [
    {
      "Id": 156,
      "Name": "Wintheiser-O'Reilly",
      "ToolTip": "Veritatis sint doloremque.",
      "Deleted": false,
      "Rank": 390,
      "Type": "harum",
      "ColorBlock": 358,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "1994-12-13T09:40:59.3326652+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Columbus Huel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 127,
      "Comment": "autem",
      "Registered": "2011-08-19T09:40:59.3326652+02:00",
      "RegisteredAssociateId": 932,
      "Updated": "1994-01-06T09:40:59.3326652+01:00",
      "UpdatedAssociateId": 698,
      "LegalBaseId": 950,
      "LegalBaseKey": "consequatur",
      "LegalBaseName": "Stokes LLC",
      "ConsentPurposeId": 343,
      "ConsentPurposeKey": "nihil",
      "ConsentPurposeName": "Connelly Group",
      "ConsentSourceId": 317,
      "ConsentSourceKey": "doloribus",
      "ConsentSourceName": "Donnelly, Harvey and Block",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    }
  ],
  "BounceEmails": [
    "sammie_bauch@beckerkreiger.us",
    "durward@upton.ca"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Osborne Crooks",
    "SuperOffice:2": "626441063"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "exercitationem"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "incentivize innovative architectures"
      },
      "FieldType": "System.String",
      "FieldLength": 29
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```