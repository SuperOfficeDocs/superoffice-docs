---
title: PATCH Person/{id}
id: v1PersonEntity_PatchPersonEntity
---

# PATCH Person/{id}

```http
PATCH /api/v1/Person/{id}
```

Update a PersonEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IPersonAgent} service SavePersonEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Person/{id}?$select=name,department,category/id
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

The Person Service. The service implements all services working with the Person object.



PersonEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity  updated. |
| 404 | PersonEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "et",
    "value": {
      "value1": {
        "PrimaryKey": 735,
        "EntityName": "person",
        "personId": 735,
        "fullName": "Kelli Jacobson"
      },
      "value2": {
        "PrimaryKey": 1272,
        "EntityName": "sale",
        "saleId": 1272,
        "contactId": 3748,
        "name": "Gerlach-Wisozk"
      }
    }
  },
  {
    "op": "add",
    "path": "et",
    "value": {
      "value1": {
        "PrimaryKey": 735,
        "EntityName": "person",
        "personId": 735,
        "fullName": "Kelli Jacobson"
      },
      "value2": {
        "PrimaryKey": 1272,
        "EntityName": "sale",
        "saleId": 1272,
        "contactId": 3748,
        "name": "Gerlach-Wisozk"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 902,
  "Firstname": "Imogene",
  "MiddleName": "Armstrong, Breitenberg and Yundt",
  "Lastname": "Champlin",
  "Mrmrs": "quibusdam",
  "Title": "sapiente",
  "UpdatedDate": "1999-03-16T09:40:59.3696654+01:00",
  "CreatedDate": "1999-08-28T09:40:59.3696654+02:00",
  "BirthDate": "2002-09-21T09:40:59.3696654+02:00",
  "CreatedBy": {
    "AssociateId": 47,
    "Name": "Brekke LLC",
    "PersonId": 405,
    "Rank": 474,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 761,
    "FullName": "Trinity Bartell",
    "FormalName": "Bogisich-Boyle",
    "Deleted": false,
    "EjUserId": 684,
    "UserName": "Graham-Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 764
      }
    }
  },
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "enim",
      "Description": "Ergonomic coherent focus group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "enim",
      "Description": "Ergonomic coherent focus group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "Description": "Re-engineered reciprocal neural-net",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "animi",
      "StrippedValue": "consequatur",
      "Description": "Diverse clear-thinking time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 809
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "consequatur",
      "Description": "Diverse clear-thinking time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 809
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iusto",
      "StrippedValue": "qui",
      "Description": "Ergonomic 24/7 definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "qui",
      "Description": "Ergonomic 24/7 definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "totam",
      "Description": "Face to face logistical complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "totam",
      "Description": "Face to face logistical complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "officiis",
      "StrippedValue": "quia",
      "Description": "Assimilated modular matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "quia",
      "Description": "Assimilated modular matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "sequi",
      "Description": "Synergistic attitude-oriented standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "sequi",
      "Description": "Synergistic attitude-oriented standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    }
  ],
  "Position": {
    "Id": 31,
    "Value": "possimus",
    "Tooltip": "minus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 694
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 334,
    "Name": "Goldner, Gulgowski and Murazik",
    "PersonId": 93,
    "Rank": 924,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 101,
    "FullName": "Darryl Hodkiewicz",
    "FormalName": "O'Keefe LLC",
    "Deleted": true,
    "EjUserId": 716,
    "UserName": "Hermann Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize next-generation metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "Contact": {
    "ContactId": 898,
    "Name": "Greenholt, Hegmann and Kirlin",
    "OrgNr": "923855",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "non",
    "DirectPhone": "177.675.7247 x1652",
    "AssociateId": 338,
    "CountryId": 421,
    "EmailAddress": "cesar.sawayn@hermiston.biz",
    "Kananame": "aut",
    "EmailAddressName": "ottis@nitzsche.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tristin Veum",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aut",
    "FullName": "Eleazar Konopelski",
    "IsOwnerContact": true,
    "ActiveErpLinks": 658,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "Country": {
    "CountryId": 632,
    "Name": "Buckridge Group",
    "CurrencyId": 942,
    "EnglishName": "Howell-Roberts",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Organic solution-oriented initiative",
    "OrgNrText": "198139",
    "InterAreaPrefix": "quas",
    "DialInPrefix": "magni",
    "ZipPrefix": "voluptas",
    "DomainName": "Crooks Group",
    "AddressLayoutId": 370,
    "DomesticAddressLayoutId": 862,
    "ForeignAddressLayoutId": 318,
    "Rank": 297,
    "Tooltip": "facere",
    "Deleted": false,
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
  "Interests": [
    {
      "Id": 592,
      "Name": "Batz Group",
      "ToolTip": "Cumque omnis natus.",
      "Deleted": false,
      "Rank": 374,
      "Type": "reiciendis",
      "ColorBlock": 43,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2020-02-05T09:40:59.3716654+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Mauricio Funk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 640
        }
      }
    }
  ],
  "PersonNumber": "31938",
  "FullName": "Tomasa Barton",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "numquam",
      "Description": "Programmable dynamic forecast",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "numquam",
      "Description": "Programmable dynamic forecast",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    }
  ],
  "FormalName": "Schaden-Pollich",
  "Address": {
    "Wgs84Latitude": 667.542,
    "Wgs84Longitude": 31299.257999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Lemke-Schmitt",
          "Value": "nisi",
          "Tooltip": "optio",
          "Label": "sapiente",
          "ValueLength": 922,
          "AddressType": "aliquid",
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
              "FieldLength": 501
            }
          }
        }
      ],
      [
        {
          "Name": "Nikolaus, Conn and Smitham",
          "Value": "deleniti",
          "Tooltip": "esse",
          "Label": "ut",
          "ValueLength": 623,
          "AddressType": "at",
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
              "FieldLength": 744
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 253
      }
    }
  },
  "Post3": "totam",
  "Post2": "facere",
  "Post1": "ut",
  "Kanalname": "aut",
  "Kanafname": "doloribus",
  "CorrespondingAssociate": {
    "AssociateId": 383,
    "Name": "Pacocha, Quitzon and Hand",
    "PersonId": 714,
    "Rank": 929,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 958,
    "FullName": "Ms. Fiona Wintheiser",
    "FormalName": "Labadie-Wyman",
    "Deleted": false,
    "EjUserId": 378,
    "UserName": "Kilback, Bernhard and McGlynn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 663
      }
    }
  },
  "Category": {
    "Id": 540,
    "Value": "quia",
    "Tooltip": "error",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 744
      }
    }
  },
  "Business": {
    "Id": 792,
    "Value": "nulla",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 680
      }
    }
  },
  "Associate": {
    "AssociateId": 952,
    "Name": "Schaefer-Doyle",
    "PersonId": 763,
    "Rank": 315,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 935,
    "FullName": "Ashlee Nader",
    "FormalName": "Crist Inc and Sons",
    "Deleted": false,
    "EjUserId": 430,
    "UserName": "Berge LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 890
      }
    }
  },
  "Salutation": "error",
  "ActiveInterests": 71,
  "SupportAssociate": {
    "AssociateId": 182,
    "Name": "Paucek, Keeling and Greenfelder",
    "PersonId": 399,
    "Rank": 62,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 240,
    "FullName": "Miss Madelyn Carroll",
    "FormalName": "Vandervort, O'Keefe and Crona",
    "Deleted": true,
    "EjUserId": 691,
    "UserName": "Hoeger, Hartmann and Lebsack",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 905
      }
    }
  },
  "TicketPriority": {
    "Id": 524,
    "Value": "quae",
    "Tooltip": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 360
      }
    }
  },
  "CustomerLanguage": {
    "Id": 795,
    "Value": "magnam",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 368
      }
    }
  },
  "DbiAgentId": 850,
  "DbiKey": "inventore",
  "DbiLastModified": "2011-07-10T09:40:59.3746795+02:00",
  "DbiLastSyncronized": "2014-11-10T09:40:59.3746795+01:00",
  "SentInfo": 561,
  "ShowContactTickets": 457,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 252,
    "UserName": "Heller-Vandervort",
    "PersonId": 61,
    "Rank": 224,
    "Tooltip": "aut",
    "UserGroupId": 353,
    "EjUserId": 22,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "similique",
      "autem"
    ],
    "CanLogon": true,
    "RoleName": "Stoltenberg-Waelchi",
    "RoleTooltip": "ducimus",
    "UserGroupName": "Effertz-Considine",
    "UserGroupTooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 170
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "atque",
      "StrippedValue": "placeat",
      "Description": "Multi-tiered secondary superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "placeat",
      "Description": "Multi-tiered secondary superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eaque",
      "StrippedValue": "repellat",
      "Description": "Streamlined responsive system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "repellat",
      "Description": "Streamlined responsive system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "Source": 639,
  "ActiveErpLinks": 601,
  "ShipmentTypes": [
    {
      "Id": 932,
      "Name": "Gulgowski, DuBuque and Kub",
      "ToolTip": "Eveniet mollitia dolorem.",
      "Deleted": true,
      "Rank": 940,
      "Type": "delectus",
      "ColorBlock": 819,
      "IconHint": "voluptatibus",
      "Selected": false,
      "LastChanged": "2018-05-28T09:40:59.3756658+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "modi",
      "Hidden": true,
      "FullName": "Mr. Krystina Bernhard",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 712,
      "Comment": "eligendi",
      "Registered": "1998-10-24T09:40:59.3756658+02:00",
      "RegisteredAssociateId": 771,
      "Updated": "2007-03-05T09:40:59.3756658+01:00",
      "UpdatedAssociateId": 694,
      "LegalBaseId": 965,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Berge-Steuber",
      "ConsentPurposeId": 209,
      "ConsentPurposeKey": "officiis",
      "ConsentPurposeName": "Kreiger, Green and Borer",
      "ConsentSourceId": 701,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Quigley, Effertz and Feeney",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "BounceEmails": [
    "tyreek@farrell.name",
    "jana_connelly@schillerleuschke.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1841892980",
    "SuperOffice:2": "Dr. Brice Cole"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "quidem"
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
      "FieldLength": 40
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```