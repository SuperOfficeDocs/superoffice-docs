---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: move_crm_server       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Move SuperOffice CRM Server # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Move SuperOffice CRM Server

When you move SuperOffice CRM Server, there are essentially several parts that may have to be moved. Depending on what should be moved, there are different steps to take into consideration.

## SuperOffice program files

1. Make sure you have the document archive available as a share and set up the ODBC datasource to connect to the existing SuperOffice database. This will ensure that the SuperOffice windows client installer is set up correctly after you have installed the new CRM server. Then run the SuperOffice Server installer on your new server.

2. Install **prerequisites** on this computer if needed.

3. Run **Install the SuperOffice CRM Server**
    * Choose the correct location and when asked to Select ODBC datasource you pick the one that points to your production database. The server setup will notice that this is an existing database and tell you that it will be used "**As is**".

## SuperOffice document archive (so\_arc)

Use file copy to copy the so\_arc with subfolders from the old location to the new location. The new location must be updated in both *SuperOffice.ini* and *web.config* so both SuperOffice windows clients and web clients will keep access to their documents and templates.

### Change details

All SuperOffice Windows users and the impersonate user used in SuperOffice Web configuration must have full control rights for SO Arc folder in the new location.

There are also other 4 places where you will need to make a change to the new SO Arc folder reference for the installation to work.

1. In the *SuperOffice.ini* file (Archivepath line) found in SuperOffice Server installation’s folder.

![imageoa6c9.png][4]

![imagei4ebl.png][5]

2. In *SuperOffice.ini* file (Archivepath line) on all computers which have SuperOffice Windows application installed.

![image7byzr.png][6]

![imageitfv.png][7]

3. In SuperOffice Web application's Product configuration, Document archive section, Archive path location.

![image3bdb8.png][8]

![imageitk5g.png][9]

4. Finally you want to create a new .mst file and remove the old one so that all the new SuperOffice Windows application installations will automatically have the correct SO Arc reference.

![imagep6lxc.png][10]

![image3omzh.png][11]

## SuperOffice database on Microsoft SQL Server or Oracle

If you have access to both the new and the old database server, then using DBsetup to [rebuild][1] the database from old to new datasource is the fastes option.

If you do not have access to the new database server from the old database server, then you may [export][2] the database as an SDA file from DBSetup on the old server and use DBSetup to [import][3] the SDA file.

## SuperOffice Win clients must be updated

If you just change the name/address, you need to refresh *SuperOffice.mst* file with the new server information

1. Navigate to the SuperOffice server folder.
2. Run the *SoCreateMST.exe* (`C:\[SuperOffice Server_adress]\`)
3. Press **Load file**.
4. Navigate to SuperOffice.mst package (*SuperOffice.mst* file can be found in the *Client* folder on the server: `C:\[SuperOffice Server_adress]\Client\SuperOffice.mst`).
5. Save the new .Mst file.

All clients must be uninstalled, then run SuperOffice8.exe from the server\\client folder.

## SuperOffice Web and SuperOffice Web services / NetServer

Run SuperOffice Product configuration and update the information either for the Database settings or Document Archive.

![Make sure you update the database settings correct][12]

![Make sure you update the document archive settings correct][13]

## Service

1. Download and run the **SuperOffice.CustomerService.exe** to install on the new server.

> [!WARNING]
> Do NOT run ejTermSetup.exe since you already have Service installed.

2. Download and install **SuperOffice Web services / Netserver**, which is the second option when installing SuperOffice Web client. This is used by Service to connect to the database.

3. Stop the current Service and the eJournal schedule service running the old server. As an extra precaution, edit the config file in the program folder and type "frozen" on a separate line at the bottom. Service will stop working on the old site.

You will need to manually change settings inside the database tables called **Config** and **Registry**.

**In the config table:**

* Make sure all paths are updated correctly to the new location: text\_path, attachment\_path, template\_path and warning.
* Verify the correct URLs to cgi\_url (the external URL) and cgi\_url\_internal.

**In the registry table:**

| Reg\_id | Path to |
|---------|---------|
| 131 | the DBI executable |
| 284 | the ImageResizer executable |
| 22 | the ejOutbox executable |
| 1 | the ejSender executable |
| 245 | the program which performs AD authentication |
| 40 | the LogPath in Service |
| 109 |  www folder, if Service is installed in a sub application called Service, then value here would be set to /Service/ |

**Changing hostname also:**

1. In the Windows registry there is the key that is identical to the hostname that you are running Service on. Make sure it matches new hostname.  The key is: HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Wow6432Node\\SuperOffice Customer Service.
2. Edit the Service website hostname in IIS.
3. Open the database, go to the config table, and edit all the fields containing the old hostname.
4. Open the crontab.txt file, and edit locations containing the old hostname.

4. Copy the Customer Service directory in the old environment over to the new environment. Under this directory you will by default find all of the directories that belong to Service, like attachments, templates and the Customer center.

5. In the root directory you find a **config** file, open this in Notepad or another simple text editor. The **dbDatabase** points to the name of current ODBC source, create a new ODBC connection (32bit) on the new server with the same name that points to the SuperOffice [database][14].

6. Change or verify that the path in **nsEndPoint** points to the new Netserver Web service you set up above. Note: Service supports only http connection to Netserver, https is not supported.

7. Remove "frozen" from config file, so Service will work again.
    * Sometimes it may be advantageous to run C:\\SuperOffice\\Customer Service\\bin\\upgrade.exe -d <hostname> after this move.

8. Inside the database there will be a lot of absolute URLs, pointing to attachments like pictures. To update the database you may run the following queries, replace oldUrl and newUrl with your paths.

[!CAUTION]
> Remember to do a backup before you run queries directly on your database.

```text
update crm7.s_message set html_message = replace(html_message,'://oldurl.no','://new.url.no') where html_message like '%://oldurl.no%'
update crm7.ej_message set html_body = replace(html_body,'://oldurl.no','://new.url.no') where html_body like '%://oldurl.no%'
update crm7.ej_message set body = replace(body,'://oldurl.no','://new.url.no') where body like '%://oldurl.no%'
update crm7.reply_template_body set body_html = replace(body_html,'://oldurl.no','://new.url.no') where body_html like '%://oldurl.no%'
update crm7.ejuser set signature = replace(signature,'://oldurl.no','://new.url.no') where signature like '%://oldurl.no%'
update crm7.ejscript set body = replace(body,'://oldurl.no','://new.url.no') where body like '%://oldurl.no%'
update crm7.screen_definition_action set ejscript_body = replace(ejscript_body,'://oldurl.no','://new.url.no') where ejscript_body like '%://oldurl.no%'

update crm7.KB_ENTRY set question = replace(question,'/scripts/customer.exe/getAttachment','/service/scripts/customer.exe/getAttachment') where question like '%/scripts/customer.exe/getAttachment%'
update crm7.KB_ENTRY set answer = replace(answer,'/scripts/customer.exe/getAttachment','/service/scripts/customer.exe/getAttachment') where answer like '%/scripts/customer.exe/getAttachment%'
```

> [!NOTE]
> The last 2 queries will set the current URLs in FAQ texts if Service have been moved manually to a service sub folder as described [here][15]. Make sure you use the correct extension, customer.fcgi or customer.exe.

## Links in eMarketing messages

All the eMarketing messages sent out before the move will contain links pointing to the old site. There are 2 issues with it:

* When sending out a link, it will have an absolute URL, for example: ``http://cs.mydomain.com/scripts/customer.fcgi?action=...`, so if you move Service to another domain or subfolder, that URL will not be available any more. <br/>To prevent loss of images and attachments in the sent mailings you need to make a redirect on the IIS from the old site to the new hostname. This way images and attachment links are redirected just fine, so mailings don't look crippled in the mail client of the recipient.

* The second issue is with tracked links. A tracked link (also including the unsubscribe link) contains a hashed string which is based on the Customer Center domain. Even if you set up a redirect to catch old URLs, then it will be executed by Service but it will fail on the hash test.<br/>A workaround is to leave the Customer Center on the old URL running, at least till the messages with the tracked links become irrelevant.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/technical/documentation/administration/dbsetup/#rebuild
[2]: https://community.superoffice.com/en/technical/documentation/administration/dbsetup/#export
[3]: https://community.superoffice.com/en/technical/documentation/administration/dbsetup/#export
[4]: media/imageoa6c9.png
[5]: media/imagei4ebl.png
[6]: media/image7byzr.png
[7]: media/imageitfv.png
[8]: media/image3bdb8.png
[9]: media/imageitk5g.png
[10]: media/imagep6lxc.png
[11]: media/image3omzh.png
[12]: media/productconfigurationdbsettings.png
[13]: media/productconfigurationdocumentsettings.png
[14]: https://community.superoffice.com/en/technical/documentation/prepare/prepare-crm-server/prepare-service/#odbc
[15]: https://community.superoffice.com/en/technical/documentation/install-upgrade/service/manual-steps-service/
