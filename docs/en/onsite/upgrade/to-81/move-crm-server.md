---
title: Move CRM Server
uid: move_crm_server
description: Move SuperOffice CRM Server
author: Martin Pavlas
date: 12.08.2021
keywords: upgrade
topic: howto
envir: onsite
# client:
---

# Move SuperOffice CRM Server

When you move SuperOffice CRM Server, there are essentially several parts that may have to be moved. Depending on what should be moved, there are different steps to take into consideration.

## SuperOffice program files

1. Make sure you have the document archive available as a share and set up the ODBC datasource to connect to the existing SuperOffice database. This will ensure that the SuperOffice windows client installer is set up correctly after you have installed the new CRM server. Then run the SuperOffice Server installer on your new server.

2. Install **prerequisites** on this computer if needed.

3. Run **Install the SuperOffice CRM Server**
    * Choose the correct location and when asked to select ODBC datasource, you pick the one that points to your production database. The server setup will notice that this is an existing database and tell you that it will be used **As is**.

## SuperOffice document archive (so_arc)

Use file copy to copy the so_arc with sub-folders from the old location to the new location. The new location must be updated in both *SuperOffice.ini* and *web.config* so both SuperOffice windows clients and web clients will keep access to their documents and templates.

### Change details

All SuperOffice Windows users and the impersonate user used in SuperOffice Web configuration must have full control rights for the SO_Arc folder in the new location.

There are also other 4 places where you will need to make a change to the new SO_Arc folder reference for the installation to work.

1. In the *SuperOffice.ini* file (Archivepath line) found in SuperOffice Server installation’s folder.

    ![imageoa6c9.png -screenshot][img4]

    Open the SuperOffice.ini file and change the Archivepath to the new value.

2. In *SuperOffice.ini* file (Archivepath line) on all computers that have SuperOffice Windows application installed.

    ![image7byzr.png -screenshot][img6]

    Open the SuperOffice.ini file on all client computers and change the Archivepath to the new value.

3. In SuperOffice Web application's Product configuration, Document archive section, Archive path location.

    ![imageitk5g.png -screenshot][img9]

4. Finally you want to create a new .mst file and remove the old one so that all the new SuperOffice Windows application installations will automatically have the correct SO_Arc reference.

    ![imagep6lxc.png -screenshot][img10]

    ![image3omzh.png -screenshot][img1]

## SuperOffice database on Microsoft SQL Server or Oracle

If you have access to both the new and the old database server, then using DBsetup to [rebuild][1] the database from old to new data source is the fastest option.

If you do not have access to the new database server from the old database server, then you may [export][1] the database as an SDA file from DBSetup on the old server and use DBSetup to import the SDA file.

## SuperOffice Win clients must be updated

If you just change the name/address, you need to refresh the *SuperOffice.mst* file with the new server information

1. Navigate to the SuperOffice Server folder.
2. Run the *SoCreateMST.exe*
3. Press **Load file**.
4. Navigate to SuperOffice.mst package (*SuperOffice.mst* file can be found in the *Client* folder on the server: `C:\[SuperOffice Server address]\Client\SuperOffice.mst`).
5. Save the new MST file.

All clients must be uninstalled, then run SuperOffice8.exe from the *server\client* folder.

## SuperOffice Web and SuperOffice web services / NetServer

Run SuperOffice Product configuration and update the information either for the Database settings or Document Archive.

![Make sure you update the database settings correct -screenshot][img2]

![Make sure you update the document archive settings correct -screenshot][img3]

## Service

1. Download and run the **SuperOffice.CustomerService.exe** to install on the new server.

    > [!WARNING]
    > Do NOT run ejTermSetup.exe since you already have Service installed.

2. Download and install **SuperOffice Web services / NetServer**, which is the second option when installing SuperOffice Web client. This is used by Service to connect to the database.

3. Stop the current Service and the eJschedule service running the old server. As an extra precaution, edit the config file in the program folder and type "frozen" on a separate line at the bottom. Service will stop working on the old site.

You will need to manually change settings inside the database tables called **Config** and **Registry**.

**In the config table:**

* Make sure all paths are updated correctly to the new location: *text_path*, *attachment_path*, *template_path* and *warning*.
* Verify the correct URLs to *cgi_url* (the external URL) and *cgi_url_internal*.

**In the registry table:**

| Reg_id | Path to |
|---------|---------|
| 131 | the DBI executable |
| 284 | the ImageResizer executable |
| 22 | the ejOutbox executable |
| 1 | the ejSender executable |
| 245 | the program that performs AD authentication |
| 40 | the LogPath in Service |
| 109 |  www folder, if Service is installed in a sub-application called Service, then value here would be set to /Service/ |

**Changing hostname also:**

1. In the Windows registry there is a key that is identical to the hostname that you are running Service on. Make sure it matches the new hostname. The key is HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\SuperOffice Customer Service.

2. Edit the Service website hostname in IIS.

3. Open the database, go to the config table, and edit all the fields containing the old hostname.

4. Open the crontab.txt file, and edit locations containing the old hostname.

5. Copy the Customer Service directory in the old environment over to the new environment. Under this directory, you will by default find all of the directories that belong to Service, like attachments, templates, and the Customer center.

6. In the root directory you find a **config** file, open this in Notepad or another simple text editor. The **dbDatabase** points to the name of the current ODBC source, create a new ODBC connection (32bit) on the new server with the same name that points to the SuperOffice [database][2].

7. Change or verify that the path in **nsEndPoint** points to the new NetServer web service you set up above.

    > [!NOTE]
    > Service supports only HTTP connection to NetServer, HTTPS is not supported.

8. Remove "frozen" from the config file, so Service will work again.
    * Sometimes it may be advantageous to run `C:\SuperOffice\Customer Service\bin\upgrade.exe -d <hostname>` after this move.

9. Inside the database there will be a lot of absolute URLs, pointing to attachments like pictures. To update the database you may run the following queries, replace oldUrl and newUrl with your paths.

> [!CAUTION]
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
> The last 2 queries will set the current URLs in FAQ texts if Service has been moved manually to a service sub-folder as described [here][3]. Make sure you use the correct extension, customer.fcgi, or customer.exe.

## Links in eMarketing messages

All the eMarketing messages sent out before the move will contain links pointing to the old site. There are 2 issues with it:

* When sending out a link, it will have an absolute URL, for example: `http://cs.mydomain.com/scripts/customer.fcgi?action=...`, so if you move Service to another domain or subfolder, that URL will not be available anymore.

    To prevent loss of images and attachments in the sent mailings you need to make a redirect on the IIS from the old site to the new hostname. This way images and attachment links are redirected just fine, so mailings don't look crippled in the mail client of the recipient.

* The second issue is with tracked links. A tracked link (also including the unsubscribe link) contains a hashed string that is based on the Customer Center domain. Even if you set up a redirect to catch old URLs, then it will be executed by Service but it will fail on the hash test.

    A workaround is to leave the Customer Center on the old URL running, at least till the messages with the tracked links become irrelevant.

<!-- Referenced links -->
[1]: ../../install/database/dbsetup-exe.md
[2]: ../../../service/install/index.md
[3]: ../../../service/install/manual-steps.md

<!-- Referenced images -->
[img1]: media/image3omzh.png
[img2]: media/productconfigurationdbsettings.png
[img3]: media/productconfigurationdocumentsettings.png
[img4]: media/imageoa6c9.png
[img6]: media/image7byzr.png
[img9]: media/imageitk5g.png
[img10]: media/imagep6lxc.png
