---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


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



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "labore",
    "value": {}
  },
  {
    "op": "add",
    "path": "labore",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 47,
  "Name": "Pacocha Group",
  "Department": "",
  "OrgNr": "1165929",
  "Number1": "978236",
  "Number2": "1065382",
  "UpdatedDate": "2024-07-03T17:54:08.101208+02:00",
  "CreatedDate": "2000-08-14T17:54:08.101208+02:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "error",
      "Description": "Synchronised transitional solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "error",
      "Description": "Synchronised transitional solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 584,
      "Name": "Huel, Stoltenberg and Botsford",
      "ToolTip": "Nam est et accusamus accusamus ut.",
      "Deleted": false,
      "Rank": 205,
      "Type": "quo",
      "ColorBlock": 283,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2018-07-07T17:54:08.101208+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Bud Ondricka",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ducimus",
      "Description": "User-centric empowering standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ducimus",
      "Description": "User-centric empowering standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vitae",
      "StrippedValue": "voluptas",
      "Description": "Innovative heuristic system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "voluptas",
      "Description": "Innovative heuristic system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "numquam",
      "StrippedValue": "nihil",
      "Description": "Future-proofed 24/7 knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "nihil",
      "Description": "Future-proofed 24/7 knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "Description": "Organized human-resource info-mediaries",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 662,
      "Mrmrs": "qui",
      "Firstname": "Elian",
      "Lastname": "Ledner",
      "MiddleName": "Kerluke Group",
      "Title": "id",
      "Description": "Compatible systematic Graphical User Interface",
      "Email": "marty@wiegandcremin.us",
      "FullName": "Kellen Hyatt",
      "DirectPhone": "289-899-6147",
      "FormalName": "Kemmer LLC",
      "CountryId": 527,
      "ContactId": 108,
      "ContactName": "Reichel-Beahan",
      "Retired": 461,
      "Rank": 40,
      "ActiveInterests": 850,
      "ContactDepartment": "",
      "ContactCountryId": 866,
      "ContactOrgNr": "895964",
      "FaxPhone": "1-905-505-2329 x51284",
      "MobilePhone": "879.789.8614",
      "ContactPhone": "1-672-457-6771 x8317",
      "AssociateName": "Johns-Schimmel",
      "AssociateId": 95,
      "UsePersonAddress": false,
      "ContactFax": "laborum",
      "Kanafname": "earum",
      "Kanalname": "veritatis",
      "Post1": "itaque",
      "Post2": "sequi",
      "Post3": "quia",
      "EmailName": "jose.mills@boyle.ca",
      "ContactFullName": "Mckenna Macejkovic",
      "ActiveErpLinks": 469,
      "TicketPriorityId": 24,
      "SupportLanguageId": 407,
      "SupportAssociateId": 705,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1244360",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "cum",
  "Xstop": false,
  "ActiveInterests": 221,
  "GroupId": 187,
  "ActiveStatusMonitorId": 967,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 910,
  "DbiAgentId": 106,
  "DbiLastSyncronized": "2023-04-05T17:54:08.1168303+02:00",
  "DbiKey": "sequi",
  "DbiLastModified": "2019-08-02T17:54:08.1168303+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 955,
  "ActiveErpLinks": 290,
  "BounceEmails": [
    "brant@lindorn.com",
    "jordon@watsicaconsidine.co.uk"
  ],
  "Domains": [
    "porro",
    "provident"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vivianne Block",
    "SuperOffice:2": "Dorothea Fisher"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "itaque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 720
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```