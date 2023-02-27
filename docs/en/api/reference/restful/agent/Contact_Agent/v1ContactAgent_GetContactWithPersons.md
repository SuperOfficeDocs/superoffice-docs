---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 77
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 691,
  "Name": "Lang-Windler",
  "Department": "",
  "OrgNr": "1563082",
  "Number1": "1288440",
  "Number2": "1157666",
  "UpdatedDate": "2009-06-07T14:19:02.9949033+02:00",
  "CreatedDate": "2003-06-03T14:19:02.9949033+02:00",
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "vel",
      "Description": "Multi-channelled interactive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "vel",
      "Description": "Multi-channelled interactive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 234,
      "Name": "DuBuque, Herzog and Herzog",
      "ToolTip": "Officia ad et.",
      "Deleted": false,
      "Rank": 128,
      "Type": "aut",
      "ColorBlock": 587,
      "IconHint": "sequi",
      "Selected": false,
      "LastChanged": "2021-10-12T14:19:02.9949033+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Florence Dietrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "soluta",
      "Description": "Reverse-engineered human-resource model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "soluta",
      "Description": "Reverse-engineered human-resource model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "qui",
      "Description": "Synergized disintermediate core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "qui",
      "Description": "Synergized disintermediate core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "quo",
      "Description": "Business-focused foreground knowledge base",
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
      "Value": "sunt",
      "StrippedValue": "quo",
      "Description": "Business-focused foreground knowledge base",
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
  "Description": "Persevering logistical complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quam",
      "PersonId": 839,
      "Mrmrs": "est",
      "Firstname": "Carol",
      "Lastname": "Conn",
      "MiddleName": "Wiza Group",
      "Title": "sit",
      "Description": "Fully-configurable grid-enabled hardware",
      "Email": "johan_dare@koch.com",
      "FullName": "Janie Murphy",
      "DirectPhone": "065-296-0555 x84158",
      "FormalName": "Willms Group",
      "CountryId": 61,
      "ContactId": 466,
      "ContactName": "Hand, Ziemann and Gutmann",
      "Retired": 736,
      "Rank": 207,
      "ActiveInterests": 208,
      "ContactDepartment": "",
      "ContactCountryId": 960,
      "ContactOrgNr": "1347782",
      "FaxPhone": "(126)214-7740",
      "MobilePhone": "1-846-964-6878 x7953",
      "ContactPhone": "1-824-866-5411 x862",
      "AssociateName": "Mraz Inc and Sons",
      "AssociateId": 244,
      "UsePersonAddress": false,
      "ContactFax": "facere",
      "Kanafname": "neque",
      "Kanalname": "id",
      "Post1": "eum",
      "Post2": "et",
      "Post3": "impedit",
      "EmailName": "bernard_roberts@kutchkihn.com",
      "ContactFullName": "Furman Kuvalis",
      "ActiveErpLinks": 814,
      "TicketPriorityId": 83,
      "SupportLanguageId": 350,
      "SupportAssociateId": 399,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 57
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "eveniet",
  "Xstop": true,
  "ActiveInterests": 22,
  "GroupId": 578,
  "ActiveStatusMonitorId": 119,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 962,
  "DbiAgentId": 1001,
  "DbiLastSyncronized": "2003-09-07T14:19:02.9949033+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2021-02-20T14:19:02.9949033+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 401,
  "ActiveErpLinks": 246,
  "BounceEmails": [
    "kolby@bashirianerdman.ca",
    "orlo_schmitt@kirlin.ca"
  ],
  "Domains": [
    "ad",
    "deleniti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1360327028",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 843
    }
  }
}
```