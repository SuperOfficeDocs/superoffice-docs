---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: design_requirements       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Requirements for user UI and design # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: certification
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud               # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Requirements for user UI and design

Following this style guide will ensure that the application integrates seamlessly with SuperOffice and other partner products. It will be experienced as a member of a product family.

Our experience is that **simple is better and less is more**. However, to make it simple for the user often means (a lot) more work for the programmer.

The importance of providing the same look & feel is often underestimated by programmers when integrating two different applications.

These requirements are not applicable if the application has no user interaction.

## Requirements

* The GUI of your application must adopt the graphical look from SuperOffice CRM when your application adds web-panels or other visual interfaces directly in the SuperOffice application.

## Guidance

Check out our [best practices][1].

GUI elements that don't have a SuperOffice CRM graphical look are permitted as long as the host application is visible outside SuperOffice CRM Online.

<!-- Referenced links -->
[1]: ../best-practices.md