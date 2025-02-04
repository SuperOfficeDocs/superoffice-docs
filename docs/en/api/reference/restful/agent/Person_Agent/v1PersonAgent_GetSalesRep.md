---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.


If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Effertz, Littel and DuBuque",
  "PersonFirstname": "Maureen",
  "PersonLastname": "Grant",
  "EmailAddress": "marietta.hansen@shanahan.co.uk",
  "PhoneNumber": "1491058"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 297,
  "Firstname": "Johann",
  "MiddleName": "Pfannerstill-Keebler",
  "Lastname": "Morissette",
  "Mrmrs": "illum",
  "Title": "incidunt",
  "UpdatedDate": "2009-02-08T13:13:23.4613875+01:00",
  "CreatedDate": "2020-02-05T13:13:23.4613875+01:00",
  "BirthDate": "1997-12-08T13:13:23.4613875+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "eius",
      "Description": "Reverse-engineered neutral product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "eius",
      "Description": "Reverse-engineered neutral product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    }
  ],
  "Description": "Cross-platform tertiary initiative",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "officiis",
      "StrippedValue": "voluptate",
      "Description": "Front-line explicit capacity",
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
      "Value": "officiis",
      "StrippedValue": "voluptate",
      "Description": "Front-line explicit capacity",
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
  "Faxes": [
    {
      "Value": "saepe",
      "StrippedValue": "eum",
      "Description": "Polarised value-added circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "eum",
      "Description": "Polarised value-added circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "optio",
      "StrippedValue": "at",
      "Description": "Customer-focused asynchronous encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "at",
      "Description": "Customer-focused asynchronous encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "eveniet",
      "Description": "Upgradable 6th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "eveniet",
      "Description": "Upgradable 6th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "quae",
      "Description": "Future-proofed demand-driven project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "quae",
      "Description": "Future-proofed demand-driven project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
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
      "Id": 753,
      "Name": "Upton, Franecki and Bernhard",
      "ToolTip": "Velit esse consequatur ut accusantium et nostrum.",
      "Deleted": false,
      "Rank": 60,
      "Type": "id",
      "ColorBlock": 315,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2003-03-08T13:13:23.4613875+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Junius Keebler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "PersonNumber": "1460783",
  "FullName": "Mrs. Jayne Emiliano Satterfield",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "eos",
      "Description": "Multi-tiered hybrid pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "eos",
      "Description": "Multi-tiered hybrid pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "FormalName": "Robel, Wunsch and Bechtelar",
  "Address": null,
  "Post3": "sed",
  "Post2": "culpa",
  "Post1": "blanditiis",
  "Kanalname": "ipsam",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "deleniti",
  "ActiveInterests": 52,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 682,
  "DbiKey": "eveniet",
  "DbiLastModified": "1999-04-17T13:13:23.4769463+02:00",
  "DbiLastSyncronized": "2009-10-11T13:13:23.4769463+02:00",
  "SentInfo": 509,
  "ShowContactTickets": 130,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "hic",
      "StrippedValue": "maiores",
      "Description": "Quality-focused neutral open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "maiores",
      "Description": "Quality-focused neutral open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "ut",
      "Description": "Horizontal impactful budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "ut",
      "Description": "Horizontal impactful budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Source": 48,
  "ActiveErpLinks": 513,
  "ShipmentTypes": [
    {
      "Id": 42,
      "Name": "Kerluke-Considine",
      "ToolTip": "Rerum nostrum magnam aperiam et magni maxime fugiat.",
      "Deleted": false,
      "Rank": 808,
      "Type": "velit",
      "ColorBlock": 541,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2017-04-29T13:13:23.4769463+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Maryjane Satterfield DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 130
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 7,
      "Comment": "quos",
      "Registered": "2002-02-23T13:13:23.4769463+01:00",
      "RegisteredAssociateId": 301,
      "Updated": "2016-06-29T13:13:23.4769463+02:00",
      "UpdatedAssociateId": 707,
      "LegalBaseId": 71,
      "LegalBaseKey": "earum",
      "LegalBaseName": "Hahn LLC",
      "ConsentPurposeId": 595,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "Schuster LLC",
      "ConsentSourceId": 122,
      "ConsentSourceKey": "rem",
      "ConsentSourceName": "Osinski, Lockman and Wolff",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "BounceEmails": [
    "robin.graham@lindgren.name",
    "gustave_will@kemmer.name"
  ],
  "ActiveStatusMonitorId": 883,
  "CreatedByFormId": 854,
  "UserDefinedFields": {
    "SuperOffice:1": "Marlin Veum",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 293
    }
  }
}
```