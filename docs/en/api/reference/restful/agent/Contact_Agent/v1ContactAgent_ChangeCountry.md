---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 982
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 599,
  "Name": "Schneider, Jast and O'Conner",
  "Department": "",
  "OrgNr": "1326004",
  "Number1": "1120648",
  "Number2": "430103",
  "UpdatedDate": "1997-08-18T04:22:26.2621843+02:00",
  "CreatedDate": "2010-09-26T04:22:26.2621843+02:00",
  "Emails": [
    {
      "Value": "distinctio",
      "StrippedValue": "laborum",
      "Description": "Face to face transitional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 842
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "laborum",
      "Description": "Face to face transitional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 842
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 133,
      "Name": "Rodriguez Inc and Sons",
      "ToolTip": "Atque adipisci.",
      "Deleted": false,
      "Rank": 689,
      "Type": "natus",
      "ColorBlock": 436,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2016-10-15T04:22:26.2621843+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Mrs. Dallin Huel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "inventore",
      "Description": "Right-sized non-volatile success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "inventore",
      "Description": "Right-sized non-volatile success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 169
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "quam",
      "Description": "Intuitive holistic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "quam",
      "Description": "Intuitive holistic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "explicabo",
      "StrippedValue": "impedit",
      "Description": "Up-sized leading edge forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "impedit",
      "Description": "Up-sized leading edge forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "Description": "Organized exuding instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 775,
      "Mrmrs": "laudantium",
      "Firstname": "Kara",
      "Lastname": "Balistreri",
      "MiddleName": "Eichmann LLC",
      "Title": "vel",
      "Description": "Stand-alone background functionalities",
      "Email": "cole.beahan@okuneva.ca",
      "FullName": "Gay Huels",
      "DirectPhone": "886.872.3924 x505",
      "FormalName": "Yost, Walker and Wilderman",
      "CountryId": 810,
      "ContactId": 81,
      "ContactName": "Mertz Group",
      "Retired": 376,
      "Rank": 47,
      "ActiveInterests": 98,
      "ContactDepartment": "",
      "ContactCountryId": 188,
      "ContactOrgNr": "482825",
      "FaxPhone": "327.393.0403",
      "MobilePhone": "1-861-251-9337",
      "ContactPhone": "233.089.7824 x599",
      "AssociateName": "Prosacco-McKenzie",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "ullam",
      "Kanalname": "consequatur",
      "Post1": "voluptatem",
      "Post2": "aut",
      "Post3": "reprehenderit",
      "EmailName": "mackenzie.lindgren@schoen.co.uk",
      "ContactFullName": "Rebekah Berge",
      "ActiveErpLinks": 996,
      "TicketPriorityId": 481,
      "SupportLanguageId": 496,
      "SupportAssociateId": 367,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 385
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "placeat",
  "Xstop": false,
  "ActiveInterests": 941,
  "GroupId": 879,
  "ActiveStatusMonitorId": 558,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 946,
  "DbiAgentId": 73,
  "DbiLastSyncronized": "2021-12-04T04:22:26.2778085+01:00",
  "DbiKey": "debitis",
  "DbiLastModified": "2007-02-24T04:22:26.2778085+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 59,
  "ActiveErpLinks": 88,
  "BounceEmails": [
    "liam.kihn@jast.us",
    "malinda.hermiston@von.ca"
  ],
  "Domains": [
    "quaerat",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "701468826",
    "SuperOffice:2": "Green Ernser"
  },
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 197
    }
  }
}
```