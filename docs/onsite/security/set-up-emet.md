---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: set_up_emet # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Installing Enhanced Mitigation Experience Toolkit (EMET) # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: security
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
so.client: web                  # online, web, win, pocket, or mobile
---

# Installing EMET

**E**nhanced **M**itigation **E**xperience **T**oolkit (EMET) can be downloaded from [technet.microsoft.com][1]
.

The installation is straightforward, continue through the install wizard to complete the installation. Once EMET is installed it can be accessed from the lower right-hand corner. Double-click the icon to open the graphical user interface.

![Click icon in system tray](https://community.superoffice.com/contentassets/ab4f4d869e1f4d1098682b486239202d/emeticon.jpg)

The following changes should be made to the settings:

* Set the “Quick Profile Name” setting to “Maximum Security Settings”.
* Check that the “System Status” box shows the same settings as the screenshot below.

Next we want to use EMET to protect some more applications than those that are protected by default. Depending on which sort of server this is, different settings should be applied. There are setting files available on the website that will protect SuperOffice executables. There are two different files at the moment:

* emet\_config\_CS\_v0.2.xml
* emet\_config\_superoffice\_general\_including\_netserver\_v0.1.xml

This is because Customer Service is packaged into executables and all of these need to be configured to be protected by EMET, the first file addresses this. The second file can be used on web servers in general including the NetServer. It configures EMET to protect IIS in addition to all the default EMET protection rules.

To import the EMET configuration file, simply select “Import” from the menu and choose the XML file configuration file. If there are any errors, it is most likely because EMET did not find the SuperOffice installation at the path that was set in the XML file. To fix this, edit the XML configuration file and make sure that the paths match the installation path of you SuperOffice installation.

![Import the EMET configuration file](https://community.superoffice.com/contentassets/ab4f4d869e1f4d1098682b486239202d/emetenhancedmitigation.jpg)

After setting up the rules, the applications must be restarted for the protection mechanisms to take effect. It is recommended to do a reboot of the server to make sure the rules are properly applied. After rebooting, the EMET GUI should show which processes are running EMET in the “Running Processes” list.

![Running processes](https://community.superoffice.com/contentassets/ab4f4d869e1f4d1098682b486239202d/emetrunningprocesses.jpg)

Repeat this process for the servers that are involved in the SuperOffice installation, for example, file server, database server, NetServer and proxy server.

<!-- Referenced links -->
[1]: https://technet.microsoft.com/en-us/security/jj653751