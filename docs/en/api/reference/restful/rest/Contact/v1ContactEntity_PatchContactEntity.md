---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
content_type: reference
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.
NsApiSlow threshold: 2000 ms. Update the Department field to "foo" can be done either as a JSON PATCH:

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "perferendis",
    "value": {}
  },
  {
    "op": "add",
    "path": "perferendis",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 665,
  "Name": "Zemlak, Hackett and Christiansen",
  "Department": "",
  "OrgNr": "555504",
  "Number1": "254465",
  "Number2": "1569294",
  "UpdatedDate": "2006-12-13T02:30:52.4911666+01:00",
  "CreatedDate": "2022-11-27T02:30:52.4911666+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "aperiam",
      "Description": "Customizable optimal methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "aperiam",
      "Description": "Customizable optimal methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 512,
      "Name": "Torphy Inc and Sons",
      "ToolTip": "Dolorem sunt.",
      "Deleted": false,
      "Rank": 902,
      "Type": "eum",
      "ColorBlock": 242,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2024-06-12T02:30:52.4911666+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "exercitationem",
      "Hidden": false,
      "FullName": "Velma Frami",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "nemo",
      "Description": "Realigned 24 hour strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "nemo",
      "Description": "Realigned 24 hour strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "Seamless maximized artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "Seamless maximized artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "architecto",
      "StrippedValue": "sunt",
      "Description": "Public-key homogeneous software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "sunt",
      "Description": "Public-key homogeneous software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    }
  ],
  "Description": "Organic composite artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 253,
      "Mrmrs": "sit",
      "Firstname": "Armando",
      "Lastname": "Kohler",
      "MiddleName": "Greenholt, Dietrich and Conn",
      "Title": "blanditiis",
      "Description": "Diverse client-server interface",
      "Email": "cassie@breitenberg.uk",
      "FullName": "Adrienne Klocko",
      "DirectPhone": "1-006-758-5864 x53176",
      "FormalName": "Mante LLC",
      "CountryId": 528,
      "ContactId": 192,
      "ContactName": "Bins Inc and Sons",
      "Retired": 855,
      "Rank": 663,
      "ActiveInterests": 366,
      "ContactDepartment": "",
      "ContactCountryId": 645,
      "ContactOrgNr": "1351860",
      "FaxPhone": "1-946-020-3358",
      "MobilePhone": "018-728-0055",
      "ContactPhone": "990.471.1062",
      "AssociateName": "Haley, Lynch and Armstrong",
      "AssociateId": 203,
      "UsePersonAddress": true,
      "ContactFax": "quisquam",
      "Kanafname": "sed",
      "Kanalname": "voluptatem",
      "Post1": "ut",
      "Post2": "nihil",
      "Post3": "reprehenderit",
      "EmailName": "dale@schroederschoen.info",
      "ContactFullName": "Sebastian Hane",
      "ActiveErpLinks": 363,
      "TicketPriorityId": 726,
      "SupportLanguageId": 612,
      "SupportAssociateId": 595,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1112530",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": false,
  "ActiveInterests": 1002,
  "GroupId": 720,
  "ActiveStatusMonitorId": 60,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 174,
  "DbiAgentId": 377,
  "DbiLastSyncronized": "2016-11-25T02:30:52.4911666+01:00",
  "DbiKey": "ad",
  "DbiLastModified": "1999-08-06T02:30:52.4911666+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 183,
  "ActiveErpLinks": 753,
  "BounceEmails": [
    "art@johnston.co.uk",
    "dariana_deckow@cronaosinski.ca"
  ],
  "Domains": [
    "corrupti",
    "sint"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Karolann Konopelski DVM",
    "SuperOffice:2": "Miss Bernard Asha Haag"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 272
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```