---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: zip_on_rest       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: ZIP compression on REST # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ZIP compression on REST

Since SuperOffice 8.5 R01 we added support for ZIP compression on REST API.

This can be utilized by Pocket CRM client which has now support for REST to be able to offer compression and thus higher speed in its contact with NetServer.

To be able to use IIS dynamic compression, you will need:

* Pocket client >= 9.0.4
* Netserver >= 8.5.7066 (8.5 R01)

Basic Authentication needs to be disabled on the IIS web site. SuperOffice Web installer will do it for you since 8.1 R02.

These new features should work in both Online and Onsite, and Onsite remote installations as long as site is correctly configured, and minimum versions are met.

## How to enable json compression on web servers

1. Add/install required server role in Server Manager console.

![image0yyx.png][1]

2. Enable dynamic content compression in IIS on server level.

* In IIS Manager click on the server name and choose Compression from the IIS section.

![imagehqgzohc.png][2]

3. Configure compression for content type JSON.

* In IIS Manager click on the server name and choose Configuration Editor from the Management section. From the drop down list on the top of the page select system.webServer and under that httpCompression.
* Find the dynamicTypes option and click Edit item from the Actions menu on the right hand side.
* In the new dialog click Add in the Actions menu, set Enabled to True and to the mimeType enter “application/json”.

![imageeahwm.png][3]

Now the REST calls will be compressed.

<!-- Referenced links -->
[1]: media/image0yyx.png
[2]: media/imagehqgzohc.png
[3]: media/imageeahwm.png
