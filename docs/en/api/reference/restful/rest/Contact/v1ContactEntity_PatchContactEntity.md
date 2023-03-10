---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
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

## Request Body: changes string

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
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
    "path": "quod",
    "value": {}
  },
  {
    "op": "add",
    "path": "quod",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 433,
  "Name": "Collins, Wilderman and Halvorson",
  "Department": "",
  "OrgNr": "1169804",
  "Number1": "1369043",
  "Number2": "410232",
  "UpdatedDate": "2007-04-23T12:15:26.7216391+02:00",
  "CreatedDate": "2003-05-02T12:15:26.7216391+02:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "earum",
      "Description": "Reverse-engineered user-facing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "earum",
      "Description": "Reverse-engineered user-facing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 306,
      "Name": "Abbott Inc and Sons",
      "ToolTip": "Itaque quibusdam et blanditiis pariatur sunt laudantium.",
      "Deleted": true,
      "Rank": 850,
      "Type": "temporibus",
      "ColorBlock": 424,
      "IconHint": "veritatis",
      "Selected": true,
      "LastChanged": "2014-10-16T12:15:26.7256389+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "nam",
      "Hidden": true,
      "FullName": "Mrs. Rocio Hammes PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "veniam",
      "Description": "Organic bi-directional adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "veniam",
      "Description": "Organic bi-directional adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "voluptatum",
      "Description": "Customizable foreground hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "voluptatum",
      "Description": "Customizable foreground hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "unde",
      "StrippedValue": "sint",
      "Description": "Progressive mobile initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "sint",
      "Description": "Progressive mobile initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    }
  ],
  "Description": "Ergonomic responsive hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 934,
      "Mrmrs": "perspiciatis",
      "Firstname": "Junius",
      "Lastname": "Borer",
      "MiddleName": "Douglas LLC",
      "Title": "facilis",
      "Description": "Operative reciprocal capability",
      "Email": "joannie@hirthe.name",
      "FullName": "Dr. Wilford Gerhold",
      "DirectPhone": "(818)330-8276",
      "FormalName": "Hilpert LLC",
      "CountryId": 142,
      "ContactId": 873,
      "ContactName": "Wilkinson-Vandervort",
      "Retired": 895,
      "Rank": 991,
      "ActiveInterests": 679,
      "ContactDepartment": "",
      "ContactCountryId": 641,
      "ContactOrgNr": "1072771",
      "FaxPhone": "(583)816-1567 x735",
      "MobilePhone": "(367)376-9780 x9723",
      "ContactPhone": "031.301.3061",
      "AssociateName": "King Group",
      "AssociateId": 974,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "consectetur",
      "Kanalname": "ipsum",
      "Post1": "corrupti",
      "Post2": "odit",
      "Post3": "vitae",
      "EmailName": "jason@marvin.biz",
      "ContactFullName": "Mrs. Kacey Ardith Bailey III",
      "ActiveErpLinks": 848,
      "TicketPriorityId": 697,
      "SupportLanguageId": 183,
      "SupportAssociateId": 114,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 93
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "soluta",
  "Xstop": false,
  "ActiveInterests": 2,
  "GroupId": 226,
  "ActiveStatusMonitorId": 914,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 168,
  "DbiAgentId": 544,
  "DbiLastSyncronized": "1999-02-27T12:15:26.7396391+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2006-02-12T12:15:26.7396391+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 422,
  "ActiveErpLinks": 376,
  "BounceEmails": [
    "serena.wilderman@schimmel.info",
    "jada.berge@blanda.us"
  ],
  "Domains": [
    "pariatur",
    "inventore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Brant Eichmann MD",
    "SuperOffice:2": "795702790"
  },
  "ExtraFields": {
    "ExtraFields1": "neque",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "odit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 789
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```