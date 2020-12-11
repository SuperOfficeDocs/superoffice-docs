---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: upgrade_to_8_1       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Upgrade to 8.1 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: guide               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite             # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Upgrade to 8.1

From this version, it is required that both Sales and Service is located on the same domain, as seen from the browser. This is because the authentication is done only by Sales.

When upgrading to 8.1, you must deside which domain should be the primary domain where both Sales and Service should be located, as seen from the browser. In our examples, we use socrm.myorganization.com/sales and socrm.myorganization.com/service.

If the two clients are not located on the same webserver, then [Reverse proxy][1] must be set up to redirect the user to the correct location, and the reason for two subfolders is that it is easier to set up reverse proxy (ARR rules) if the clients are located in different folders.

> [!NOTE]
> Moving Sales requires a lot less changes than if you choose to move Service. When you move Sales you may just run the web client installer and after you run the client configuration all is up and running.

If you choose to move Service to the new domain, then there are several database changes that must be done as well. These are documented under [Move Service][2]. Also note that there may be emails out at customers from either support or marketing which have URLs pointing to the old URL, so it is a good idea to consider setting up redirects.

**How will clients know where CRM web is installed for authentication?**

From 8.1 this preference will tell all clients where the Sales Web client is installed. This means that when a un-authorized user tries to access either Sales Web Client or Service, they will be automatially forwarded to the URL added to this preference and after successful authentication they are returned to where they came from.

![x][3]

## Upgrade to 8.1 when using the old Service domain

![Move Sales web client to Service domain][4]

1. Run **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database to 8.1.

2. Run **SuperOffice.CustomerService.exe** to upgrade Service software.

3. Run **SuperOffice web client** **Setup.exe** to install SuperOffice Sales web client on the existing Service domain

4. Run **SuperOffice Product Configuration** to connect to the database upgraded in #1. If you choose to not run separate Netserver WebServices, make sure you tick the option to Expose Netserver WebServices  

![x][5]

5. Start web client to verify it runs correct, go in to Settings and Maintenance and set the new preference **System - Base URL for Web client**

6. Edit config file found in the Service root folder and point nsEndPoint to the **new web clients services url**

7. Run **Upgrade.exe** (as administrator) located in Service programfolder\\bin. The upgrade.exe will among other updates also update the config file found in Service program folder with the new Services endpoint, **Services84**

## Upgrade to 8.1 when using the old Sales domain

![Move Service to Sales web client domain][6]

1. Run **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database to 8.1.

2. Run **SuperOffice web client** **Setup.exe** to upgrade SuperOffice Sales web client to 8.1. Remember to tick **Expose Netserver Webservices** if Service should use the same Webservices as the web client.

3. Start the webclient and set the new Web Base url preference in Settings and Maintenance client.

4. Run **SuperOffice.CustomerService.exe** to install Service software on the same server as web. You must **untick** the "Create IIS web site" or you will get an error since it already exists.

![x][7]

5. Under [Move to new server][2], there are some steps explained to update the database to see the new domain used.
    * Stop the current service and add "frozen" to the config file located in the old Service program folder.
    * Update database table Config and Registry with the new paths.
    * Copy/move attachments/templates and customer senter folders from the old installation to the new
    * Run queries to update the absolute URLs which will be found in the database.
    * Consider if a redirect should be added so customers using old URLs will be redirected correctly to the new.
    * Run `upgrade.exe -d newdomain` to make sure Service is upgraded to 8.1 as well

## Upgrade to 8.1 when choosing a brand new domain for both clients

![Move both Sales web client and Service to a new domain][8]

1. Run **SuperOffice SM.win** **SetupExe.exe** installer to upgrade the server and the database to 8.1.

2. Run **SuperOffice.CustomerService.exe** to Install Service and choose to let the installer create the IIS web site

3. Run **SuperOffice web client** **Setup.exe** to install SuperOffice Sales web client on the newly created Service domain

4. Start the webclient and set the new **Web Base url** preference in Settings and Maintenance client.

5. Under [Move to new server][2] there are some steps explained to update the database to see the new domain used.
    * Stop the current service and add "frozen" to the config file located in the old Service program folder.
    * Update database table Config and Registry with the new paths.
    * Copy/move attachments/templates and customer center folders from the old installation to the new
    * Run queries to update the absolute URLs which will be found in the database.
    * Consider if a redirect should be added so customers using old URLs will be redirected correctly to the new.
    * Run `upgrade.exe -d newdomain` to make sure Service is upgraded to 8.1 as well

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/prepare/security/deploy-securely/setting-up-a-reverse-proxy-on-iis8/
[2]: https://community.superoffice.com/en/technical/documentation/install-upgrade/crm-server/move-to-new-server/#service
[3]: media/baseurl81.png
[4]: media/salestoservice.png
[5]: media/exposenetserverwebservices.png
[6]: media/servicetosales.png
[7]: media/servicenoiis.png
[8]: media/moveboth.png
