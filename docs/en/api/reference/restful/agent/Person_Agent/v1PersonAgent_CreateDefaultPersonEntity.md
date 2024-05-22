---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 718,
  "Firstname": "Davonte",
  "MiddleName": "Cartwright-Fisher",
  "Lastname": "Hirthe",
  "Mrmrs": "enim",
  "Title": "sit",
  "UpdatedDate": "2008-09-14T12:57:34.4147625+02:00",
  "CreatedDate": "2023-12-17T12:57:34.4147625+01:00",
  "BirthDate": "2008-11-16T12:57:34.4147625+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "beatae",
      "StrippedValue": "suscipit",
      "Description": "Re-contextualized impactful toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "suscipit",
      "Description": "Re-contextualized impactful toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 129
        }
      }
    }
  ],
  "Description": "Digitized intermediate emulation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "expedita",
      "StrippedValue": "tempore",
      "Description": "Virtual interactive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 339
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "tempore",
      "Description": "Virtual interactive capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 339
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vero",
      "StrippedValue": "velit",
      "Description": "Seamless tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "velit",
      "Description": "Seamless tangible internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Stand-alone hybrid knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "omnis",
      "Description": "Stand-alone hybrid knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "possimus",
      "Description": "Progressive encompassing hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 801
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "possimus",
      "Description": "Progressive encompassing hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 801
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "natus",
      "StrippedValue": "iusto",
      "Description": "Re-engineered bandwidth-monitored groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "iusto",
      "Description": "Re-engineered bandwidth-monitored groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
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
      "Id": 943,
      "Name": "Walsh-Hirthe",
      "ToolTip": "Et reprehenderit hic.",
      "Deleted": false,
      "Rank": 477,
      "Type": "ex",
      "ColorBlock": 997,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2005-06-02T12:57:34.4147625+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Lukas Schmeler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "PersonNumber": "400447",
  "FullName": "Shanny Nicolas",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "consequuntur",
      "StrippedValue": "est",
      "Description": "Exclusive next generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "est",
      "Description": "Exclusive next generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    }
  ],
  "FormalName": "Schulist Group",
  "Address": null,
  "Post3": "similique",
  "Post2": "placeat",
  "Post1": "quasi",
  "Kanalname": "nemo",
  "Kanafname": "necessitatibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "non",
  "ActiveInterests": 473,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 135,
  "DbiKey": "fugiat",
  "DbiLastModified": "2000-04-30T12:57:34.4147625+02:00",
  "DbiLastSyncronized": "2019-12-25T12:57:34.4147625+01:00",
  "SentInfo": 173,
  "ShowContactTickets": 218,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fuga",
      "StrippedValue": "velit",
      "Description": "User-friendly upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "velit",
      "Description": "User-friendly upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Open-architected tangible moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Open-architected tangible moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "Source": 927,
  "ActiveErpLinks": 762,
  "ShipmentTypes": [
    {
      "Id": 442,
      "Name": "Kemmer Group",
      "ToolTip": "Quis repellendus blanditiis est ut.",
      "Deleted": false,
      "Rank": 309,
      "Type": "error",
      "ColorBlock": 635,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2005-02-25T12:57:34.4147625+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Ms. Baron Bartell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 788,
      "Comment": "nulla",
      "Registered": "2006-02-02T12:57:34.4147625+01:00",
      "RegisteredAssociateId": 46,
      "Updated": "1997-07-10T12:57:34.4147625+02:00",
      "UpdatedAssociateId": 6,
      "LegalBaseId": 574,
      "LegalBaseKey": "minima",
      "LegalBaseName": "Goldner-Schmitt",
      "ConsentPurposeId": 491,
      "ConsentPurposeKey": "libero",
      "ConsentPurposeName": "Towne, Haley and Osinski",
      "ConsentSourceId": 386,
      "ConsentSourceKey": "eos",
      "ConsentSourceName": "Lemke Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "BounceEmails": [
    "adah_morissette@vonkozey.us",
    "aliyah@kulas.uk"
  ],
  "ActiveStatusMonitorId": 159,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Juwan Sabrina Pouros",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "recusandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 519
    }
  }
}
```