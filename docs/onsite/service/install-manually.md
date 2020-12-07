---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: install_service_manually       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Manual steps to install Service # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Manual steps to install Service

From SuperOffice 8.1 both SuperOffice Web and Service must run on the same root domain. It will be easier to create Application Routing Routing rules (ARR) if you do the manual installation and place Service in a sub application.

Installing SuperOffice Sales web client and Service on the same domain under different applications requires some manual steps for Service.

## Install Service

If the IIS web site is not created, first run the installer for Service (SuperOffice.CustomerService.exe) which is the only installer from SuperOffice that will also create the IIS web sites.

If the web site is created, then you may create the application first, and just point the path to the default location for Customer Service: c:\\superoffice

![x][1]

Run the SuperOffice.CustomerService.exe to install the software on the server, default location is c:\\superoffice.

![x][2]

If you upgrade an existing site, do not tick the Create IIS web site since it will cause the installer to fail. , we will create/update the application manually.

![x][3]

Either set up a new application under socrm.myorganization.com for Service or edit the one you created earlier. Point the physical path to the Customer service\\www\\doc folder, in this example it would be **c:\\SuperOffice\\Customer Service\\www\\doc** folder

![x][4]

Below service you also need to add two applications, one for scripts which points to Customer Service\\www\\scripts folder. Make sure it use the same application pool as the Service application.

![x][5]

And one application for csplugins pointing to \\customer service\\www\\csplugins

![x][6]

## Make sure Netserver is available first

You need remote webservices / Netserver installed on the same domain, in this example we have used socrm.myorganization.com/netserver. This is installed by using the [web installer][7] to the Sales web client, and in the product configurator tick the "**Expose Netserver WebServices**" on the Security chapter.

Browse to http://socrm.myorganization.com/Sales/Remote/Services84/Contact.svc to verify before the ejTermSetup.exe is run to prime the database for Service.

 ![x][8]

## Continue with priming the database for Service

ejTermSetup.exe is only run for NEW installations

Now run ejTermSetup found in the Bin folder, when asked for Hostname give the path including the application, socrm.myorganization.com/service which will correctly set the value for database table registry where reg\_id = 109 to /service/

![x][9]

When ejtermsetup later asks for **The full HTTP Path to your server (for URL's)** then just use the hostname without sub application, like http://socrm.myorganization.com. It will in most cases default to the correct URL.

When asked for the **Netserver URL** you give the URL for Netserver created on the same domain. Note: Service does not support https connection to Netserver, so only http is allowed.

From SuperOffice 8.1, all authentication for all clients will be done by the webclient, and after successfully authenicating a sessionkey is stored in browser cookie. This is why Sales and Service must be installed on the same domain.

![x][10]

After completing the ejTermSetup you may start up https://socrm.myorganization.com/service/scripts/rms.fcgi (or.exe) - note that if your screen is completely missing pictures, then it's the reg\_id=109 who has a wrong value.

![x][11]

## Verify the database registry and config table values

If Service is installed in a sub folder of the domain named service, then

select \* from crm7.registry where reg\_id = 109

should have value /service/

![x][12]

select cgi\_bin, cgi\_url, cgi\_url\_internal from crm7.config

![x][13]

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/add-application-1.png
[2]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/run-installer.png
[3]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/uncheck-create-iis-web-site.png
[4]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/change-app-paths.png
[5]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/add-app-scripts.png
[6]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/add-app-csplugins.png
[7]: https://community.superoffice.com/en/technical/documentation/install-upgrade/web/netserver--web-services/
[8]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/verifyremotewebservices.png
[9]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/hostpath-and-odbc.png
[10]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/netserver-url-and-admin.png
[11]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/loginservice.png
[12]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/regid109wrong.png
[13]: https://community.superoffice.com/contentassets/63f7148dd5974ee7a414f67b043489c7/cgibinurlsconfig.png