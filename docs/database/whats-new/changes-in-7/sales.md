---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: changes_7_sales       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Changes in SuperOffice 7 - Sales management # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Sales management

Database change:

## several new lists

(MDO lists with grouplink and headinglink tables)

* [SaleTypeCat][1]
* [SaleType][2]
* [ReasonStalled][3]
* [ReasonSold][4]
* [SaleStakeholder][5]
* [SaleTypeStageLink][6]
* [StakeholderRole][7]

## New tables for suggested document/appointment

* [SuggestedAppointment][8]
* [SuggestedDocument][9]

## New fields in Sale/SaleHist

* saleType\_id
* postitText\_id
* reasonStalled\_id
* reopenDate
* nextDueDate
* nddAppointment\_id
* reasonSold\_id
* saleTypeCat\_id

The motivation behind this is:

* Make a workplace for the sales rep. that really helps him
* Flexible enough for most sales situations
* Collect the right data for analyzing and drilling to enable accurate forecast and the right coaching

Done by:

* Lifting Sale as a main panel, like contact, project, selection and so on
* Introduce type/category of sale opportunities
* Each type of sale may have different sales processes

<!-- Referenced links -->
[1]: ../../tables/saletypecat.md
[2]: ../../tables/saletype.md
[3]: ../../tables/reasonstalled.md
[4]: ../../tables/reasonsold.md
[5]: ../../tables/salestakeholder.md
[6]: ../../tables/saletypestagelink.md
[7]: ../../tables/stakeholderrole.md
[8]: ../../tables/suggestedappointment.md
[9]: ../../tables/suggesteddocument.md
