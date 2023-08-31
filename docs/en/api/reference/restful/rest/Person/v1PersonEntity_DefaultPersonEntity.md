---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.







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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 16 Jan 2012 03:31:32 G1T

{
  "PersonId": 754,
  "Firstname": "Anissa",
  "MiddleName": "Dach, Heathcote and Gislason",
  "Lastname": "Borer",
  "Mrmrs": "dolorem",
  "Title": "et",
  "UpdatedDate": "2012-01-16T03:31:32.6445204+01:00",
  "CreatedDate": "2020-05-18T03:31:32.6445204+02:00",
  "BirthDate": "2011-12-11T03:31:32.6445204+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "odio",
      "StrippedValue": "sit",
      "Description": "Re-contextualized homogeneous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "sit",
      "Description": "Re-contextualized homogeneous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    }
  ],
  "Description": "Monitored directional analyzer",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "accusamus",
      "Description": "Enterprise-wide holistic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "accusamus",
      "Description": "Enterprise-wide holistic neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Sharable systematic projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Sharable systematic projection",
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
  "MobilePhones": [
    {
      "Value": "impedit",
      "StrippedValue": "accusamus",
      "Description": "Versatile bandwidth-monitored protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "accusamus",
      "Description": "Versatile bandwidth-monitored protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ipsum",
      "StrippedValue": "culpa",
      "Description": "Vision-oriented clear-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "culpa",
      "Description": "Vision-oriented clear-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Fully-configurable grid-enabled workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Fully-configurable grid-enabled workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
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
      "Id": 155,
      "Name": "Muller, Brown and Goodwin",
      "ToolTip": "Et cupiditate officia nulla reiciendis.",
      "Deleted": false,
      "Rank": 899,
      "Type": "repudiandae",
      "ColorBlock": 259,
      "IconHint": "facere",
      "Selected": false,
      "LastChanged": "2020-09-18T03:31:32.6445204+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Wilfred Harris MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "PersonNumber": "1837283",
  "FullName": "Rebekah Muller IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "eaque",
      "Description": "Progressive static conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "eaque",
      "Description": "Progressive static conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 364
        }
      }
    }
  ],
  "FormalName": "Crona LLC",
  "Address": null,
  "Post3": "corrupti",
  "Post2": "molestias",
  "Post1": "quidem",
  "Kanalname": "facere",
  "Kanafname": "dolores",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "id",
  "ActiveInterests": 135,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 943,
  "DbiKey": "in",
  "DbiLastModified": "1998-04-26T03:31:32.6445204+02:00",
  "DbiLastSyncronized": "2018-04-24T03:31:32.6445204+02:00",
  "SentInfo": 643,
  "ShowContactTickets": 596,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ducimus",
      "StrippedValue": "aut",
      "Description": "Future-proofed client-driven matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "aut",
      "Description": "Future-proofed client-driven matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "aliquam",
      "Description": "Cross-platform systemic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "aliquam",
      "Description": "Cross-platform systemic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "Source": 90,
  "ActiveErpLinks": 414,
  "ShipmentTypes": [
    {
      "Id": 173,
      "Name": "Schulist-Goldner",
      "ToolTip": "In nobis dolores excepturi adipisci esse aliquid harum.",
      "Deleted": true,
      "Rank": 844,
      "Type": "distinctio",
      "ColorBlock": 961,
      "IconHint": "nam",
      "Selected": false,
      "LastChanged": "2017-02-06T03:31:32.6445204+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ilene Botsford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 531,
      "Comment": "molestias",
      "Registered": "1999-11-01T03:31:32.6445204+01:00",
      "RegisteredAssociateId": 200,
      "Updated": "2003-02-26T03:31:32.6445204+01:00",
      "UpdatedAssociateId": 676,
      "LegalBaseId": 324,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Bauch Inc and Sons",
      "ConsentPurposeId": 113,
      "ConsentPurposeKey": "vel",
      "ConsentPurposeName": "Schneider-Lemke",
      "ConsentSourceId": 26,
      "ConsentSourceKey": "reprehenderit",
      "ConsentSourceName": "Mohr-Johnson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "BounceEmails": [
    "braeden_heidenreich@wardrosenbaum.ca",
    "josie.yundt@feeney.ca"
  ],
  "ActiveStatusMonitorId": 944,
  "UserDefinedFields": {
    "SuperOffice:1": "Casey Hegmann V",
    "SuperOffice:2": "Miss Mustafa Louvenia Welch DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "eius"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 425
    }
  }
}
```