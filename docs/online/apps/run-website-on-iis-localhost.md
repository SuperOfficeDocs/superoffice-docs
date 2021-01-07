---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: run_website_on_iis_localhost       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Run a website on your machine, IIS localhost # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Run a website on your machine, IIS localhost

Many web applications are configured to run a website on your machine, IIS localhost.

To make it easier on yourself:

1. Open Visual Studio as an administrator. Your instance of Visual Studio should have **(Administrator)** in the title bar.
2. Let Visual Studio create the site in IIS for you automatically.

![x][img1]

If you open a solution and notice that the project has failed to load, this is probably because your Visual Studio is not run as administrator. Restart the application and select **Run as administrator**.

<!-- Referenced images -->
[1]: media/image014.png
