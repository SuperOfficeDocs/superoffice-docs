---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: config_faq # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Configure FAQ entries # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id} # Your GitHub alias.
keywords:
so.topic: howto # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir: # cloud or onsite
# so.client: # online, web, win, pocket, or mobile
---

# Configure FAQ entries

To enable the comment field inside the Customer Center for your FAQ entries, you need to change REGISTRY table in SuperOffice CRM database.

> [!NOTE]
> It is not recommend make changes directly on database without a backup available. If you make a mistake, this backup must be restored.

To enable comments:

1. Run the following query first: `select * from crm7.registry where reg_id in (198, 199)`
If nothing is returned by this query, first go to your Customer center and FAQs and the registry keys will be populated.

![x][img1]

2. Now you can change comment field access. Below are possible options:
    * 0 = none
    * 1 = customer (these are people that are logged in to the customer portal)
    * 2 = all - also anonymous users

3. After you enable these settings you will see the comments show up

![x][img2]

> [!NOTE]
> If you use SuperOffice Online you need to contact [support][1].

## More access controll on FAQ entries

By default, you may specify that a FAQ or a folder of FAQs may be accessed by to everyone, to registered customers, to internal users or private.

You may also control access to a FAQ folder by adding a small script that is evaluated in the "Access Control" under Setup FAQ folder. This script has access to all data for the logged in contact, and contact person's name and must return the value "1" in order for access to be granted to the folder.

**To return a value in the scripting language as used syntax:**

`% RETURN: "1"%`

### Available fields

**For contact:**'

* customer.id
* customer.name
* customer.bestName
* customer.firstname
* customer.lastname
* customer.phone
* customer.cellphone
* customer.note
* customer.username
* customer.password
* customer.email

**For company:**

* company.id
* company.name
* company.note
* company.domain
* company.phone
* company.fax
* company.adr

In addition, all extra fields for contactperson are available via "customer." plus the name of the extra field eg. "customer.MyExtraField", and similarly for the company: "company.ExtraField". Boolean field has the value "1" when they are true.

Example, a boolean field is created on the customer, called `x_access`. When tick, the user will get access:

```text
%IF:customer.x\_access="1"%
%RETURN:"1"%
%ENDIF%
```

<!-- Referenced links -->
[1]: http://support.superoffice.com/

<!-- Referenced images -->
[img1]: media/reg_id198_199.png
[img2]: media/comments.png
