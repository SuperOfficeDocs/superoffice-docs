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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "est",
    "value": {
      "value1": {
        "PrimaryKey": 2919,
        "EntityName": "person",
        "personId": 2919,
        "fullName": "Leif Lind"
      },
      "value2": {
        "PrimaryKey": 7892,
        "EntityName": "sale",
        "saleId": 7892,
        "contactId": 7634,
        "name": "Bruen-Gutkowski"
      }
    }
  },
  {
    "op": "add",
    "path": "est",
    "value": {
      "value1": {
        "PrimaryKey": 2919,
        "EntityName": "person",
        "personId": 2919,
        "fullName": "Leif Lind"
      },
      "value2": {
        "PrimaryKey": 7892,
        "EntityName": "sale",
        "saleId": 7892,
        "contactId": 7634,
        "name": "Bruen-Gutkowski"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 220,
  "Firstname": "Eula",
  "MiddleName": "Lowe Group",
  "Lastname": "Jaskolski",
  "Mrmrs": "corrupti",
  "Title": "nobis",
  "UpdatedDate": "1999-03-28T15:05:42.373669+02:00",
  "CreatedDate": "2021-08-05T15:05:42.373669+02:00",
  "BirthDate": "2000-06-06T15:05:42.373669+02:00",
  "CreatedBy": {
    "AssociateId": 580,
    "Name": "Reilly Group",
    "PersonId": 229,
    "Rank": 163,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 389,
    "FullName": "Jena Bednar",
    "FormalName": "Nitzsche-Schmitt",
    "Deleted": true,
    "EjUserId": 645,
    "UserName": "Breitenberg-Klocko",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 760
      }
    }
  },
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "vitae",
      "Description": "Programmable motivating solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "vitae",
      "Description": "Programmable motivating solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "Description": "Quality-focused content-based knowledge user",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "hic",
      "Description": "Persistent actuating secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "hic",
      "Description": "Persistent actuating secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "ipsam",
      "Description": "Synergized global utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "ipsam",
      "Description": "Synergized global utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "maxime",
      "Description": "Innovative multi-state time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "e-enable scalable functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "maxime",
      "Description": "Innovative multi-state time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "e-enable scalable functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "optio",
      "Description": "Diverse incremental installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 452
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "optio",
      "Description": "Diverse incremental installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 452
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vitae",
      "StrippedValue": "ipsam",
      "Description": "Realigned composite forecast",
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
      "Value": "vitae",
      "StrippedValue": "ipsam",
      "Description": "Realigned composite forecast",
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
  "Position": {
    "Id": 205,
    "Value": "cum",
    "Tooltip": "veritatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 950
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 469,
    "Name": "Herzog-Thompson",
    "PersonId": 707,
    "Rank": 831,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 851,
    "FullName": "Trevion Corkery",
    "FormalName": "D'Amore LLC",
    "Deleted": true,
    "EjUserId": 582,
    "UserName": "Padberg-Roberts",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 123
      }
    }
  },
  "Contact": {
    "ContactId": 520,
    "Name": "Aufderhar Inc and Sons",
    "OrgNr": "1186934",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "666.577.3645 x80545",
    "AssociateId": 658,
    "CountryId": 199,
    "EmailAddress": "colton@jakubowski.info",
    "Kananame": "amet",
    "EmailAddressName": "elwin_oconnell@trantow.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jeremie Stark",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Penelope Huels",
    "IsOwnerContact": true,
    "ActiveErpLinks": 440,
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
  "Country": {
    "CountryId": 515,
    "Name": "Schmidt-Lehner",
    "CurrencyId": 654,
    "EnglishName": "Kilback, Mayer and Cartwright",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "User-centric uniform hardware",
    "OrgNrText": "920004",
    "InterAreaPrefix": "aut",
    "DialInPrefix": "omnis",
    "ZipPrefix": "natus",
    "DomainName": "Anderson Group",
    "AddressLayoutId": 927,
    "DomesticAddressLayoutId": 231,
    "ForeignAddressLayoutId": 671,
    "Rank": 410,
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
        "FieldLength": 804
      }
    }
  },
  "Interests": [
    {
      "Id": 800,
      "Name": "Stanton-McDermott",
      "ToolTip": "Explicabo quae id.",
      "Deleted": true,
      "Rank": 909,
      "Type": "perspiciatis",
      "ColorBlock": 158,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2021-02-12T15:05:42.3916323+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Seamus Gutkowski",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 475
        }
      }
    }
  ],
  "PersonNumber": "93147",
  "FullName": "Maxine Lockman",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "sint",
      "Description": "Open-architected motivating service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "sint",
      "Description": "Open-architected motivating service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    }
  ],
  "FormalName": "Volkman, Boyle and Pouros",
  "Address": {
    "Wgs84Latitude": 12485.856,
    "Wgs84Longitude": 25808.489999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Grimes Group",
          "Value": "veniam",
          "Tooltip": "soluta",
          "Label": "voluptatem",
          "ValueLength": 370,
          "AddressType": "totam",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "cultivate mission-critical systems"
              },
              "FieldType": "System.Int32",
              "FieldLength": 388
            }
          }
        }
      ],
      [
        {
          "Name": "Stoltenberg, Stoltenberg and Ruecker",
          "Value": "rem",
          "Tooltip": "pariatur",
          "Label": "et",
          "ValueLength": 398,
          "AddressType": "debitis",
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
              "FieldLength": 266
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "odit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 645
      }
    }
  },
  "Post3": "et",
  "Post2": "et",
  "Post1": "voluptates",
  "Kanalname": "voluptatem",
  "Kanafname": "suscipit",
  "CorrespondingAssociate": {
    "AssociateId": 436,
    "Name": "Effertz, O'Reilly and Schaden",
    "PersonId": 455,
    "Rank": 560,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 521,
    "FullName": "Garett Wuckert",
    "FormalName": "Nienow LLC",
    "Deleted": true,
    "EjUserId": 10,
    "UserName": "Renner LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "drive efficient convergence"
        },
        "FieldType": "System.Int32",
        "FieldLength": 573
      }
    }
  },
  "Category": {
    "Id": 997,
    "Value": "quibusdam",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  },
  "Business": {
    "Id": 480,
    "Value": "unde",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transition back-end mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 351
      }
    }
  },
  "Associate": {
    "AssociateId": 272,
    "Name": "Connelly, Cronin and Moen",
    "PersonId": 845,
    "Rank": 124,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Brent Kohler",
    "FormalName": "Reichert LLC",
    "Deleted": true,
    "EjUserId": 942,
    "UserName": "Lynch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 189
      }
    }
  },
  "Salutation": "magnam",
  "ActiveInterests": 997,
  "SupportAssociate": {
    "AssociateId": 903,
    "Name": "Rolfson Group",
    "PersonId": 223,
    "Rank": 726,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 294,
    "FullName": "Tom Wyman DVM",
    "FormalName": "Skiles Inc and Sons",
    "Deleted": true,
    "EjUserId": 344,
    "UserName": "Jacobs-Hegmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "TicketPriority": {
    "Id": 516,
    "Value": "sint",
    "Tooltip": "quam",
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
  },
  "CustomerLanguage": {
    "Id": 185,
    "Value": "mollitia",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 185
      }
    }
  },
  "DbiAgentId": 746,
  "DbiKey": "in",
  "DbiLastModified": "2000-10-05T15:05:42.3946328+02:00",
  "DbiLastSyncronized": "2004-03-12T15:05:42.3946328+01:00",
  "SentInfo": 390,
  "ShowContactTickets": 519,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 441,
    "UserName": "McLaughlin, Lueilwitz and Wuckert",
    "PersonId": 946,
    "Rank": 349,
    "Tooltip": "non",
    "UserGroupId": 893,
    "EjUserId": 740,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "dolores",
      "necessitatibus"
    ],
    "CanLogon": true,
    "RoleName": "Nader LLC",
    "RoleTooltip": "animi",
    "UserGroupName": "Hauck Inc and Sons",
    "UserGroupTooltip": "veritatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "voluptates",
      "StrippedValue": "fuga",
      "Description": "Customizable hybrid help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "fuga",
      "Description": "Customizable hybrid help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "qui",
      "Description": "Front-line mission-critical artificial intelligence",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 756
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "qui",
      "Description": "Front-line mission-critical artificial intelligence",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 756
        }
      }
    }
  ],
  "Source": 904,
  "ActiveErpLinks": 280,
  "ShipmentTypes": [
    {
      "Id": 841,
      "Name": "Funk-Klein",
      "ToolTip": "Aut sed.",
      "Deleted": true,
      "Rank": 461,
      "Type": "quia",
      "ColorBlock": 942,
      "IconHint": "excepturi",
      "Selected": false,
      "LastChanged": "2011-02-26T15:05:42.3956324+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "commodi",
      "Hidden": true,
      "FullName": "Miss Adolph Purdy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 993,
      "Comment": "omnis",
      "Registered": "2021-06-03T15:05:42.3956324+02:00",
      "RegisteredAssociateId": 364,
      "Updated": "2000-03-22T15:05:42.3956324+01:00",
      "UpdatedAssociateId": 533,
      "LegalBaseId": 251,
      "LegalBaseKey": "explicabo",
      "LegalBaseName": "Cole-Gaylord",
      "ConsentPurposeId": 74,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Blick-Boyle",
      "ConsentSourceId": 193,
      "ConsentSourceKey": "amet",
      "ConsentSourceName": "Hirthe, Lesch and Gerhold",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "BounceEmails": [
    "hertha_predovic@danielkeeling.name",
    "monroe.collier@sanfordabernathy.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Sonia Fritsch",
    "SuperOffice:2": "761754357"
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "perferendis"
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
      "FieldLength": 144
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```