---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 643
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 928,
  "Firstname": "Kallie",
  "MiddleName": "O'Reilly Group",
  "Lastname": "Jones",
  "Mrmrs": "vel",
  "Title": "aliquid",
  "UpdatedDate": "2013-03-10T14:19:03.8113757+01:00",
  "CreatedDate": "2018-03-05T14:19:03.8113757+01:00",
  "BirthDate": "2002-07-12T14:19:03.8113757+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "est",
      "Description": "Balanced bottom-line attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "est",
      "Description": "Balanced bottom-line attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "Description": "Persevering neutral Graphical User Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "velit",
      "Description": "Total value-added parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "velit",
      "Description": "Total value-added parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "cumque",
      "Description": "Reverse-engineered grid-enabled middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "cumque",
      "Description": "Reverse-engineered grid-enabled middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolore",
      "StrippedValue": "beatae",
      "Description": "Reactive bifurcated Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "beatae",
      "Description": "Reactive bifurcated Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "sapiente",
      "Description": "Profit-focused 24 hour budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "sapiente",
      "Description": "Profit-focused 24 hour budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "porro",
      "Description": "Cloned fresh-thinking model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "porro",
      "Description": "Cloned fresh-thinking model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
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
      "Id": 759,
      "Name": "Zemlak-Grady",
      "ToolTip": "Sed non voluptatibus totam eius.",
      "Deleted": false,
      "Rank": 276,
      "Type": "aut",
      "ColorBlock": 885,
      "IconHint": "nihil",
      "Selected": true,
      "LastChanged": "1996-05-27T14:19:03.8270007+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "ducimus",
      "Hidden": true,
      "FullName": "Mr. Briana Jany Kerluke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "PersonNumber": "1009300",
  "FullName": "Sydnie Payton Ratke III",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "rerum",
      "Description": "Intuitive reciprocal software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "rerum",
      "Description": "Intuitive reciprocal software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "FormalName": "Treutel, Klocko and Mitchell",
  "Address": null,
  "Post3": "quam",
  "Post2": "ut",
  "Post1": "ut",
  "Kanalname": "et",
  "Kanafname": "repudiandae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "asperiores",
  "ActiveInterests": 836,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 182,
  "DbiKey": "harum",
  "DbiLastModified": "2016-03-09T14:19:03.8270007+01:00",
  "DbiLastSyncronized": "2002-01-26T14:19:03.8270007+01:00",
  "SentInfo": 1000,
  "ShowContactTickets": 900,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptas",
      "StrippedValue": "cupiditate",
      "Description": "Mandatory reciprocal core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "cupiditate",
      "Description": "Mandatory reciprocal core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "voluptatibus",
      "Description": "Seamless discrete forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "voluptatibus",
      "Description": "Seamless discrete forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Source": 324,
  "ActiveErpLinks": 387,
  "ShipmentTypes": [
    {
      "Id": 670,
      "Name": "Schinner Group",
      "ToolTip": "Vero impedit ea.",
      "Deleted": true,
      "Rank": 698,
      "Type": "ut",
      "ColorBlock": 866,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2020-01-12T14:19:03.8270007+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "natus",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Prof. Earlene Monty Goodwin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 33
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 463,
      "Comment": "quibusdam",
      "Registered": "2004-01-26T14:19:03.8270007+01:00",
      "RegisteredAssociateId": 526,
      "Updated": "2011-05-04T14:19:03.8270007+02:00",
      "UpdatedAssociateId": 655,
      "LegalBaseId": 38,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Abshire Inc and Sons",
      "ConsentPurposeId": 256,
      "ConsentPurposeKey": "deleniti",
      "ConsentPurposeName": "Dooley, Braun and Wehner",
      "ConsentSourceId": 853,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Rowe, Prohaska and King",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    }
  ],
  "BounceEmails": [
    "kale@padberg.name",
    "eve@gislasonstehr.name"
  ],
  "ActiveStatusMonitorId": 617,
  "UserDefinedFields": {
    "SuperOffice:1": "1878329779",
    "SuperOffice:2": "Annamarie Schuppe"
  },
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "doloribus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 327
    }
  }
}
```