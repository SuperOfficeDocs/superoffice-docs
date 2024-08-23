---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 802,
  "Firstname": "Kyler",
  "MiddleName": "Pfannerstill LLC",
  "Lastname": "Rodriguez",
  "Mrmrs": "eligendi",
  "Title": "voluptas",
  "UpdatedDate": "2018-03-29T13:28:23.1324825+02:00",
  "CreatedDate": "2003-05-09T13:28:23.1324825+02:00",
  "BirthDate": "2021-06-03T13:28:23.1324825+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "earum",
      "Description": "Synergistic global concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "earum",
      "Description": "Synergistic global concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "Description": "Organized demand-driven groupware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "iure",
      "Description": "Extended dynamic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "iure",
      "Description": "Extended dynamic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "illo",
      "Description": "Multi-lateral bifurcated algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "illo",
      "Description": "Multi-lateral bifurcated algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "laudantium",
      "Description": "Operative 6th generation challenge",
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
      "Value": "deleniti",
      "StrippedValue": "laudantium",
      "Description": "Operative 6th generation challenge",
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
  "OfficePhones": [
    {
      "Value": "autem",
      "StrippedValue": "minus",
      "Description": "Adaptive directional adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "minus",
      "Description": "Adaptive directional adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "perspiciatis",
      "Description": "Balanced attitude-oriented portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "perspiciatis",
      "Description": "Balanced attitude-oriented portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
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
      "Id": 171,
      "Name": "Pouros, Leffler and Mitchell",
      "ToolTip": "Sed est sint quaerat assumenda ut facilis eius.",
      "Deleted": true,
      "Rank": 8,
      "Type": "molestias",
      "ColorBlock": 20,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2016-03-20T13:28:23.1324825+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "in",
      "Hidden": true,
      "FullName": "Dr. Stacey Kristy Robel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "PersonNumber": "686751",
  "FullName": "Dorothea Stoltenberg",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "ipsam",
      "Description": "Versatile bi-directional process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "ipsam",
      "Description": "Versatile bi-directional process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "FormalName": "Casper-Gusikowski",
  "Address": null,
  "Post3": "magni",
  "Post2": "neque",
  "Post1": "minima",
  "Kanalname": "qui",
  "Kanafname": "cupiditate",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aut",
  "ActiveInterests": 888,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 162,
  "DbiKey": "id",
  "DbiLastModified": "2009-10-29T13:28:23.1481055+01:00",
  "DbiLastSyncronized": "2010-08-03T13:28:23.1481055+02:00",
  "SentInfo": 622,
  "ShowContactTickets": 474,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "distinctio",
      "StrippedValue": "libero",
      "Description": "Synergistic next generation budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "libero",
      "Description": "Synergistic next generation budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iure",
      "StrippedValue": "rerum",
      "Description": "Multi-layered leading edge capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 227
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "rerum",
      "Description": "Multi-layered leading edge capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 227
        }
      }
    }
  ],
  "Source": 903,
  "ActiveErpLinks": 535,
  "ShipmentTypes": [
    {
      "Id": 34,
      "Name": "Hessel, Schmidt and Herzog",
      "ToolTip": "Voluptas nisi explicabo voluptas.",
      "Deleted": true,
      "Rank": 657,
      "Type": "occaecati",
      "ColorBlock": 775,
      "IconHint": "distinctio",
      "Selected": true,
      "LastChanged": "2018-07-23T13:28:23.1481055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Jaylin Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 961,
      "Comment": "rerum",
      "Registered": "2007-01-01T13:28:23.1481055+01:00",
      "RegisteredAssociateId": 804,
      "Updated": "2006-04-05T13:28:23.1481055+02:00",
      "UpdatedAssociateId": 172,
      "LegalBaseId": 998,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Parisian-Ruecker",
      "ConsentPurposeId": 807,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Runolfsdottir, Howe and Ruecker",
      "ConsentSourceId": 734,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Pouros-Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 741
        }
      }
    }
  ],
  "BounceEmails": [
    "melisa@mrazsanford.co.uk",
    "gregg@blick.co.uk"
  ],
  "ActiveStatusMonitorId": 776,
  "CreatedByFormId": 290,
  "UserDefinedFields": {
    "SuperOffice:1": "311991259",
    "SuperOffice:2": "Dr. Americo Kira Yundt Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "tempora",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 590
    }
  }
}
```