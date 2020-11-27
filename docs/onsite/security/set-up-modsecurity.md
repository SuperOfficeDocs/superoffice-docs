---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: set_up_modsecurity # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Install and configure ModSecurity on Proxy Server for SuperOffice onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: security
so.topic: howto                 # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite            # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Install and configure ModSecurity on Proxy Server

The OWASP ModSecurity Core Rule Set (CRS) is a set of generic attack detection rules for use with [ModSecurity][1] or compatible web application firewalls. The CRS aims to protect web applications from a wide range of attacks, including the OWASP Top Ten, with a minimum of false alerts.

The linked configuration files are tested with ModSecurity v.2.9.2-1 for IIS and the OWASP CRS 2.2.9 configured for SuperOffice 8.1. Other versions may affect false positives, and the configuration file may need to be changed accordingly.

## Before you begin

1. [Download ModSecurity][2].
1. [Download Visual Studio 2013 Runtime][3] (VCredist). Note that there are two versions (64-bit and 32-bit).

## Install

Where: on the server that is functioning as our reverse proxy

1. Install the Visual Studio 2013 Runtime.
1. Install ModSecurity by walking through the installation wizard with the default settings.
1. Open the Windows Event Viewer to confirm the installation went well.

 ![ModSecurity](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/modsecurityevent.jpg)

4. ModSecurity installs for all IIS sites by default. This may break things so you may want to disable it in the beginning. This can be done in the “Configuration Editor” for each site.

![](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/configurationeditor.jpg)

Use “iisreset” to make sure changes are applied.

![IISReset](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/iisreset.jpg)

## Configure ModSecurity to function with SuperOffice

By default, the rule set will trigger some false positives. We are going to disable a few rules to avoid false positives. A file containing the whitelisted rules can be found on the website.

1. Copy the file called *modsecurity\_crs\_70\_superoffice.conf* into the folder *C:\\Program Files\\ModSecurity IIS\\owasp\_crs\\base\_rules*. This is the default installation path for ModSecurity. If you chose something else during the installation, you need to change the path accordingly.

2. Next, we need to make sure the file is loaded. Open the file *C:\\Program Files\\ModSecurity IIS\\modsecurity\_iis.conf* and add the following line to the end of the file:

`Include owasp\_crs\\base\_rules\\modsecurity\_crs\_70\_superoffice.conf`

3. After doing this we need to activate ModSecurity by changing the “enabled” setting to “True” in the “system.webServer/ModSecurity” section of each website you want ModSecurity to run for. Note that these rules are tuned to work with SuperOffice, they may give a lot of false positives if you run them “as-is” for other websites.

![Configuration Editor](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/configurationeditorso.jpg)  

4. Finish the installation by restarting IIS from the command line using “iisreset”:

![IISReset](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/iisreset.jpg)

5. Open up the “Event viewer” in Windows to see that ModSecurity loaded correctly and to see potential attacks that are triggering our Web Application firewall rules. Try browsing through the SuperOffice application and then refresh the “Application” log view to see if there are any warnings. If there are warnings at this stage it indicates that the Web Application Firewall has encountered a false positive.

We should remove this rule’s ID to avoid false positives. In the “Event Viewer”, click on the event and view the “Details tab”. Note the ID of the event and add it to the configuration file we placed at: *C:\\Program Files\\ModSecurity IIS\\owasp\_crs\\base\_rules\\modsecurity\_crs\_70\_superoffice.conf*.

![Event viewer information](https://community.superoffice.com/contentassets/17f457a20e474bb48e214d648c5808c0/eventviewerlog.jpg)

<!-- Referenced links -->
[1]: https://www.modsecurity.org/
[2]: https://www.modsecurity.org/download.html
[3]: http://www.microsoft.com/en-us/download/details.aspx?id=40784