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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 988,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 183,
  "Firstname": "Jensen",
  "MiddleName": "Wuckert-Bradtke",
  "Lastname": "Weimann",
  "Mrmrs": "ut",
  "Title": "consectetur",
  "UpdatedDate": "2009-03-28T11:16:08.9284649+01:00",
  "CreatedDate": "2004-07-27T11:16:08.9284649+02:00",
  "BirthDate": "2003-09-27T11:16:08.9284649+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vitae",
      "StrippedValue": "fugit",
      "Description": "Fully-configurable assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "fugit",
      "Description": "Fully-configurable assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "Description": "Grass-roots object-oriented adapter",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eos",
      "StrippedValue": "amet",
      "Description": "Upgradable actuating monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "amet",
      "Description": "Upgradable actuating monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "itaque",
      "Description": "Self-enabling impactful protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "itaque",
      "Description": "Self-enabling impactful protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "possimus",
      "Description": "Switchable bottom-line installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 692
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "possimus",
      "Description": "Switchable bottom-line installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 692
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Reactive directional circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "consectetur",
      "Description": "Reactive directional circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "non",
      "Description": "Multi-layered object-oriented system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "non",
      "Description": "Multi-layered object-oriented system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
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
      "Id": 407,
      "Name": "Schamberger LLC",
      "ToolTip": "Veniam architecto.",
      "Deleted": true,
      "Rank": 682,
      "Type": "eaque",
      "ColorBlock": 596,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "2014-05-16T11:16:08.9284649+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "fuga",
      "Hidden": true,
      "FullName": "Dejon Altenwerth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    }
  ],
  "PersonNumber": "1097557",
  "FullName": "Ronny Howell DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Visionary stable instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Visionary stable instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    }
  ],
  "FormalName": "Feil Group",
  "Address": null,
  "Post3": "rerum",
  "Post2": "repellat",
  "Post1": "accusamus",
  "Kanalname": "eum",
  "Kanafname": "animi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quod",
  "ActiveInterests": 955,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 168,
  "DbiKey": "ut",
  "DbiLastModified": "2020-01-22T11:16:08.9284649+01:00",
  "DbiLastSyncronized": "2003-05-25T11:16:08.9284649+02:00",
  "SentInfo": 634,
  "ShowContactTickets": 123,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ipsa",
      "StrippedValue": "qui",
      "Description": "Persistent assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "qui",
      "Description": "Persistent assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "minima",
      "StrippedValue": "quibusdam",
      "Description": "Assimilated transitional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "quibusdam",
      "Description": "Assimilated transitional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    }
  ],
  "Source": 706,
  "ActiveErpLinks": 167,
  "ShipmentTypes": [
    {
      "Id": 313,
      "Name": "Hyatt, Cruickshank and McKenzie",
      "ToolTip": "Voluptatem et id dolore.",
      "Deleted": true,
      "Rank": 549,
      "Type": "alias",
      "ColorBlock": 422,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2000-10-26T11:16:08.9284649+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Mrs. Luis Angel Feest I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 370,
      "Comment": "incidunt",
      "Registered": "1999-03-18T11:16:08.9284649+01:00",
      "RegisteredAssociateId": 214,
      "Updated": "2007-11-27T11:16:08.9284649+01:00",
      "UpdatedAssociateId": 974,
      "LegalBaseId": 899,
      "LegalBaseKey": "atque",
      "LegalBaseName": "Ebert-Schuppe",
      "ConsentPurposeId": 161,
      "ConsentPurposeKey": "a",
      "ConsentPurposeName": "Hessel, Cartwright and Fisher",
      "ConsentSourceId": 978,
      "ConsentSourceKey": "occaecati",
      "ConsentSourceName": "Abernathy Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "BounceEmails": [
    "sharon@powlowski.uk",
    "florine_jast@bode.ca"
  ],
  "ActiveStatusMonitorId": 451,
  "UserDefinedFields": {
    "SuperOffice:1": "811594073",
    "SuperOffice:2": "Prof. Cora Ethyl Pacocha II"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "dolore"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 553
    }
  }
}
```