---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 986,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 375,
  "Firstname": "Zechariah",
  "MiddleName": "Hand, Kulas and Nicolas",
  "Lastname": "Denesik",
  "Mrmrs": "voluptatem",
  "Title": "ipsa",
  "UpdatedDate": "1998-04-10T14:19:03.041779+02:00",
  "CreatedDate": "2003-02-21T14:19:03.041779+01:00",
  "BirthDate": "2014-02-05T14:19:03.041779+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "necessitatibus",
      "Description": "Secured methodical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "necessitatibus",
      "Description": "Secured methodical strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "Description": "Ergonomic interactive installation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "cum",
      "StrippedValue": "a",
      "Description": "Multi-layered object-oriented Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "a",
      "Description": "Multi-layered object-oriented Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ipsam",
      "StrippedValue": "a",
      "Description": "Realigned contextually-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 229
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "a",
      "Description": "Realigned contextually-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 229
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "nemo",
      "Description": "Open-source dedicated frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "nemo",
      "Description": "Open-source dedicated frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "similique",
      "StrippedValue": "est",
      "Description": "Persevering 24/7 hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "est",
      "Description": "Persevering 24/7 hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "omnis",
      "Description": "Devolved analyzing pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 27
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "omnis",
      "Description": "Devolved analyzing pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 27
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 832,
      "Name": "Schoen Group",
      "ToolTip": "Aut pariatur dolor rerum omnis.",
      "Deleted": true,
      "Rank": 127,
      "Type": "autem",
      "ColorBlock": 210,
      "IconHint": "fugiat",
      "Selected": false,
      "LastChanged": "1996-07-09T14:19:03.041779+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Madaline Turcotte",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "PersonNumber": "694966",
  "FullName": "Emely Grimes",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "quos",
      "Description": "Automated foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quos",
      "Description": "Automated foreground algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "FormalName": "Mitchell, Jones and Klein",
  "Address": null,
  "Post3": "nam",
  "Post2": "dolores",
  "Post1": "ut",
  "Kanalname": "laudantium",
  "Kanafname": "quae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "similique",
  "ActiveInterests": 402,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 330,
  "DbiKey": "quo",
  "DbiLastModified": "2018-05-03T14:19:03.041779+02:00",
  "DbiLastSyncronized": "2017-12-10T14:19:03.041779+01:00",
  "SentInfo": 196,
  "ShowContactTickets": 515,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quidem",
      "StrippedValue": "quia",
      "Description": "Organized contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "quia",
      "Description": "Organized contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "culpa",
      "StrippedValue": "perspiciatis",
      "Description": "Versatile 4th generation adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "perspiciatis",
      "Description": "Versatile 4th generation adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "Source": 857,
  "ActiveErpLinks": 141,
  "ShipmentTypes": [
    {
      "Id": 533,
      "Name": "Bergnaum Group",
      "ToolTip": "Aspernatur magnam laborum commodi consequatur suscipit architecto dolorem.",
      "Deleted": true,
      "Rank": 730,
      "Type": "at",
      "ColorBlock": 459,
      "IconHint": "molestiae",
      "Selected": true,
      "LastChanged": "2012-08-22T14:19:03.041779+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "sequi",
      "Hidden": false,
      "FullName": "Zena Dickens",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 214,
      "Comment": "omnis",
      "Registered": "2018-04-10T14:19:03.041779+02:00",
      "RegisteredAssociateId": 858,
      "Updated": "2005-07-09T14:19:03.041779+02:00",
      "UpdatedAssociateId": 523,
      "LegalBaseId": 719,
      "LegalBaseKey": "saepe",
      "LegalBaseName": "Von-Ortiz",
      "ConsentPurposeId": 758,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Ortiz, Bartoletti and Zieme",
      "ConsentSourceId": 981,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Thiel, Becker and Bayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    }
  ],
  "BounceEmails": [
    "hermann_murray@senger.ca",
    "mallie@sawaynhermiston.ca"
  ],
  "ActiveStatusMonitorId": 622,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Sharon Kohler I"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "in"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 484
    }
  }
}
```