---
title: GET Contact/{id}
id: v1ContactEntity_GetContactEntity
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.

Calls the Contact agent service GetContactEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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


## Response: object

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 22 Nov 1995 15:05:41 G11T

{
  "ContactId": 716,
  "Name": "VonRueden, Murray and Buckridge",
  "Department": "",
  "OrgNr": "1517432",
  "Number1": "1803373",
  "Number2": "733644",
  "UpdatedDate": "1995-11-22T15:05:41.8800052+01:00",
  "CreatedDate": "2011-05-02T15:05:41.8800052+02:00",
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "optio",
      "Description": "Down-sized mission-critical installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 763
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "optio",
      "Description": "Down-sized mission-critical installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 763
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 565,
      "Name": "Wolff-Connelly",
      "ToolTip": "Deserunt velit placeat inventore quis vel ullam.",
      "Deleted": false,
      "Rank": 667,
      "Type": "aut",
      "ColorBlock": 140,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "1998-07-10T15:05:41.8800052+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Brooke Wilderman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 744
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "Progressive uniform function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "Progressive uniform function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "aperiam",
      "Description": "Persistent optimal frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "aperiam",
      "Description": "Persistent optimal frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "repellat",
      "Description": "Sharable static definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "repellat",
      "Description": "Sharable static definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    }
  ],
  "Description": "Optional tertiary array",
  "UpdatedBy": {
    "AssociateId": 80,
    "Name": "Koepp Group",
    "PersonId": 643,
    "Rank": 859,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 111,
    "FullName": "Emily Quitzon",
    "FormalName": "Erdman-Dickens",
    "Deleted": false,
    "EjUserId": 69,
    "UserName": "Wilkinson-Dickinson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 110
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 528,
    "Name": "Purdy, Hilpert and Hartmann",
    "PersonId": 551,
    "Rank": 663,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 580,
    "FullName": "Darrick Dach",
    "FormalName": "Marquardt-Bashirian",
    "Deleted": true,
    "EjUserId": 710,
    "UserName": "Kuhn Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 140
      }
    }
  },
  "Associate": {
    "AssociateId": 434,
    "Name": "Weissnat Group",
    "PersonId": 363,
    "Rank": 247,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 56,
    "FullName": "Vada Daugherty",
    "FormalName": "Gibson-Jones",
    "Deleted": false,
    "EjUserId": 39,
    "UserName": "Green-Gusikowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize strategic niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 604
      }
    }
  },
  "Business": {
    "Id": 618,
    "Value": "vitae",
    "Tooltip": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize collaborative methodologies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 335
      }
    }
  },
  "Category": {
    "Id": 111,
    "Value": "illo",
    "Tooltip": "itaque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable wireless paradigms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 684
      }
    }
  },
  "Country": {
    "CountryId": 935,
    "Name": "Smitham LLC",
    "CurrencyId": 952,
    "EnglishName": "Runolfsdottir-Williamson",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Automated client-server concept",
    "OrgNrText": "1696744",
    "InterAreaPrefix": "eveniet",
    "DialInPrefix": "dignissimos",
    "ZipPrefix": "voluptatum",
    "DomainName": "Torphy, Hackett and Deckow",
    "AddressLayoutId": 889,
    "DomesticAddressLayoutId": 846,
    "ForeignAddressLayoutId": 779,
    "Rank": 447,
    "Tooltip": "ut",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 403
      }
    }
  },
  "Persons": [
    {
      "Position": "accusantium",
      "PersonId": 358,
      "Mrmrs": "est",
      "Firstname": "Gino",
      "Lastname": "Feeney",
      "MiddleName": "Green Group",
      "Title": "voluptas",
      "Description": "Horizontal global collaboration",
      "Email": "megane@mclaughlin.info",
      "FullName": "Rosella Wiegand",
      "DirectPhone": "(116)683-5652 x7570",
      "FormalName": "Lynch Group",
      "CountryId": 20,
      "ContactId": 260,
      "ContactName": "Langworth, Jerde and Ankunding",
      "Retired": 878,
      "Rank": 112,
      "ActiveInterests": 348,
      "ContactDepartment": "",
      "ContactCountryId": 961,
      "ContactOrgNr": "1092337",
      "FaxPhone": "138.424.4244 x571",
      "MobilePhone": "1-471-480-5521",
      "ContactPhone": "075.566.1866 x1847",
      "AssociateName": "Dietrich Group",
      "AssociateId": 730,
      "UsePersonAddress": true,
      "ContactFax": "dolorum",
      "Kanafname": "iste",
      "Kanalname": "et",
      "Post1": "blanditiis",
      "Post2": "quas",
      "Post3": "officia",
      "EmailName": "missouri@daniel.biz",
      "ContactFullName": "Russell Kiehn",
      "ActiveErpLinks": 832,
      "TicketPriorityId": 388,
      "SupportLanguageId": 625,
      "SupportAssociateId": 310,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eos",
  "Xstop": true,
  "ActiveInterests": 301,
  "GroupId": 139,
  "ActiveStatusMonitorId": 210,
  "SupportAssociate": {
    "AssociateId": 265,
    "Name": "Corkery Inc and Sons",
    "PersonId": 243,
    "Rank": 709,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 87,
    "FullName": "Raymond Nicolas II",
    "FormalName": "Bernhard Group",
    "Deleted": true,
    "EjUserId": 431,
    "UserName": "Kuvalis, Watsica and Goldner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
      }
    }
  },
  "TicketPriority": {
    "Id": 601,
    "Value": "qui",
    "Tooltip": "nihil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 918
      }
    }
  },
  "CustomerLanguage": {
    "Id": 509,
    "Value": "et",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 647
      }
    }
  },
  "Deleted": 790,
  "DbiAgentId": 61,
  "DbiLastSyncronized": "2003-09-28T15:05:41.8840053+02:00",
  "DbiKey": "illum",
  "DbiLastModified": "1996-11-12T15:05:41.8840053+01:00",
  "SupportPerson": {
    "Position": "accusamus",
    "PersonId": 348,
    "Mrmrs": "sit",
    "Firstname": "Monroe",
    "Lastname": "Lehner",
    "MiddleName": "Kris-Deckow",
    "Title": "est",
    "Description": "Implemented asynchronous protocol",
    "Email": "marcos@hessel.biz",
    "FullName": "Haylie Towne",
    "DirectPhone": "080-678-2714 x221",
    "FormalName": "Wolf Inc and Sons",
    "CountryId": 134,
    "ContactId": 555,
    "ContactName": "Walsh-Conn",
    "Retired": 134,
    "Rank": 831,
    "ActiveInterests": 555,
    "ContactDepartment": "",
    "ContactCountryId": 791,
    "ContactOrgNr": "520367",
    "FaxPhone": "(118)786-5272 x734",
    "MobilePhone": "203.615.2418 x82814",
    "ContactPhone": "1-060-383-2414",
    "AssociateName": "Von-Heidenreich",
    "AssociateId": 240,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "error",
    "Kanalname": "voluptatibus",
    "Post1": "sunt",
    "Post2": "quia",
    "Post3": "eaque",
    "EmailName": "roslyn@rueckerjones.biz",
    "ContactFullName": "Darron Daugherty",
    "ActiveErpLinks": 420,
    "TicketPriorityId": 207,
    "SupportLanguageId": 54,
    "SupportAssociateId": 889,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 666
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 5490.768,
    "Wgs84Longitude": 10937.66,
    "LocalizedAddress": [
      [
        {
          "Name": "Turcotte Inc and Sons",
          "Value": "eligendi",
          "Tooltip": "sunt",
          "Label": "sit",
          "ValueLength": 36,
          "AddressType": "laboriosam",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 576
            }
          }
        }
      ],
      [
        {
          "Name": "Wyman, Fadel and Terry",
          "Value": "qui",
          "Tooltip": "vel",
          "Label": "cum",
          "ValueLength": 860,
          "AddressType": "quas",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 753
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "itaque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 143
      }
    }
  },
  "Source": 202,
  "ActiveErpLinks": 563,
  "BounceEmails": [
    "anibal@lockman.name",
    "clarissa.gusikowski@senger.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "June Dicki",
    "SuperOffice:2": "Colton Leffler"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "deploy world-class relationships"
      },
      "FieldType": "System.String",
      "FieldLength": 305
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```