---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 279,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 134,
  "Firstname": "Kiarra",
  "MiddleName": "Fadel-Senger",
  "Lastname": "Ullrich",
  "Mrmrs": "vel",
  "Title": "reprehenderit",
  "UpdatedDate": "2021-08-04T03:45:23.2173332+02:00",
  "CreatedDate": "2016-05-17T03:45:23.2173332+02:00",
  "BirthDate": "2019-02-22T03:45:23.2173332+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Open-source methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Open-source methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    }
  ],
  "Description": "Triple-buffered attitude-oriented data-warehouse",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "omnis",
      "Description": "Reactive user-facing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "omnis",
      "Description": "Reactive user-facing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vero",
      "StrippedValue": "inventore",
      "Description": "Upgradable leading edge local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "inventore",
      "Description": "Upgradable leading edge local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "nesciunt",
      "Description": "Customer-focused zero defect pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "nesciunt",
      "Description": "Customer-focused zero defect pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quia",
      "StrippedValue": "omnis",
      "Description": "Virtual eco-centric conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "omnis",
      "Description": "Virtual eco-centric conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "sed",
      "Description": "Quality-focused intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "sed",
      "Description": "Quality-focused intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
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
      "Id": 208,
      "Name": "Pollich Group",
      "ToolTip": "Consectetur similique aliquam facere incidunt.",
      "Deleted": false,
      "Rank": 359,
      "Type": "repellat",
      "ColorBlock": 350,
      "IconHint": "dolorem",
      "Selected": true,
      "LastChanged": "2014-08-11T03:45:23.2173332+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quod",
      "StyleHint": "facilis",
      "Hidden": false,
      "FullName": "Gabriella Smitham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "PersonNumber": "1531189",
  "FullName": "Marina Casper",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "officia",
      "StrippedValue": "id",
      "Description": "Re-contextualized methodical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "id",
      "Description": "Re-contextualized methodical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    }
  ],
  "FormalName": "Stehr, Mertz and Fay",
  "Address": null,
  "Post3": "hic",
  "Post2": "perspiciatis",
  "Post1": "rerum",
  "Kanalname": "harum",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "possimus",
  "ActiveInterests": 409,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 919,
  "DbiKey": "ea",
  "DbiLastModified": "2003-02-17T03:45:23.2173332+01:00",
  "DbiLastSyncronized": "2014-10-15T03:45:23.2173332+02:00",
  "SentInfo": 412,
  "ShowContactTickets": 718,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ad",
      "StrippedValue": "et",
      "Description": "Adaptive clear-thinking alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "et",
      "Description": "Adaptive clear-thinking alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "nam",
      "Description": "Implemented reciprocal artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "nam",
      "Description": "Implemented reciprocal artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "Source": 722,
  "ActiveErpLinks": 855,
  "ShipmentTypes": [
    {
      "Id": 508,
      "Name": "Halvorson, Lynch and Littel",
      "ToolTip": "Veniam atque mollitia suscipit eligendi.",
      "Deleted": false,
      "Rank": 560,
      "Type": "ea",
      "ColorBlock": 218,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "2016-07-10T03:45:23.2173332+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "recusandae",
      "Hidden": false,
      "FullName": "Miss Alana Ivy Heidenreich V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 143
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 91,
      "Comment": "nulla",
      "Registered": "2019-08-29T03:45:23.2173332+02:00",
      "RegisteredAssociateId": 991,
      "Updated": "2001-09-21T03:45:23.2173332+02:00",
      "UpdatedAssociateId": 680,
      "LegalBaseId": 133,
      "LegalBaseKey": "enim",
      "LegalBaseName": "Daugherty, Rutherford and Gusikowski",
      "ConsentPurposeId": 70,
      "ConsentPurposeKey": "cumque",
      "ConsentPurposeName": "Kuhlman LLC",
      "ConsentSourceId": 573,
      "ConsentSourceKey": "quis",
      "ConsentSourceName": "Murphy LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    }
  ],
  "BounceEmails": [
    "angelica_damore@yundt.co.uk",
    "stone_rodriguez@harvey.name"
  ],
  "ActiveStatusMonitorId": 46,
  "CreatedByFormId": 392,
  "UserDefinedFields": {
    "SuperOffice:1": "Coy McLaughlin",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "corporis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 990
    }
  }
}
```