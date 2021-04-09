---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_oracle_db  # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Create new Oracle database for SuperOffice onsite # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a new Oracle database

Are you going to run SuperOffice on an Oracle database, follow these steps to set up the target database.

## Oracle - setting up the server

Please refer to the documentation provided by Oracle for a description on how to install the Oracle server.

### Considerations

If your Oracle server is going to serve other databases than the SuperOffice database, you might want to create an own Oracle instance (SID) for the SuperOffice database, or it will be enough to just place the SuperOffice data into a separate tablespace. What you decide on depends on how your server is going to be maintained, and we don't have any preferences one way or another. We do recommend that you at least create a separate tablespace for the SuperOffice data.

There are some parameters that you only can set during the installation of the server (or creation of the SID), and these should be considered changed during the installation of your Oracle server. The best examples of this is:

* National Language Support
* Code page or Character sets
* Database Block size

## Preparing the Oracle database

Because customers are sure to have database policies and opinions that we don’t know about, installation on an Oracle server should be done by the customers’ resident DBA. However, if a SuperOffice consultant does do the installation, it is recommended to use the Database Configuration Assistant (DCA).

In the DCA, choose the **Custom Database** template to avoid installing numerous options and sample data. Then specify passwords, file storage, and so forth. Turn off Oracle Text, OLAP, Spatial, Data Mining, Ultra Search, and other unused things, unless you specifically need them. These options take up disk space, ram, CPU, and can decrease overall database performance.

In step 10, 4 tabs, you get to the interesting parts. As for **Memory** and **Sizing**, set those to what you think is best.  For character sets, Oracle has two character set concepts: database character set and national character set. When you need to set up Unicode on Oracle, please read this first. The default is Code page 1252 ISO-Latin.

To support Unicode, select the **Use Unicode (AL32UTF8)** option. Choose **AL16UTF8** as the National character set. If you choose UTF8, you may run into problems when storing long Chinese texts in appointment descriptions. Please also take note how the representation surfaces. VARCHAR is limited to 4000 bytes, which is 2000 characters in UTF16, or anywhere from 4000 to 1300  in UTF8. You could choose the **Custom** option for the database character set, but you risk being told (later on) that your choice was illegal.

## Creating the SuperOffice tablespace

Create a tablespace with a descriptive name such as `SuperOffice_DATA` and create a datafile called *SUPEROFF.ORA* (or some other descriptive name). The size should be 200 Mb, and we recommend that you turn on the autoextend options.

### Creating the CRM7 user

You now have to create the user who is going to be the owner of all tables used by SuperOffice.

> [!WARNING]
> If you delete this user after SuperOffice is installed, all SuperOffice data will be deleted.

1. Set the following values on the **General** tab:

| Parameter | Value |
|-----------|-------|
| Name | CRM7 |
| Profile | Default |
| Password | YourSecurePassword |
| Default tablespace | `SuperOffice_DATA` |
| Temporary tablespace | `TEMPORARY_DATA` |
| Status | Unlocked |

> [!NOTE]
> You may call the CRM7 user anything you want, this is just an example. 

2. Move to the **Roles/Privileges** tab and grant the following roles:

* CONNECT with Admin Option
* DBA with Admin Option

### Set Open Cursors

The maximum number of Open Cursors depends on the memory available. To run SuperOffice, Open Cursors must be at least 1000.

To set the number of open cursors: `OPEN_CURSORS = 1000`

### Tuning Parameters

There are many opinions on how to tune your Oracle server to perform optimal. Our opinion is that in general the more memory installed and allocated to your Oracle server, the better it will perform.

These parameters can be set using the **Oracle Enterprise Manager Console**.

**Parameters optimal for a normal SuperOffice installation:**

| Parameter | Value |
|-----------|-------|
| Open\_cursors | 1000 |
| Shared\_pool\_size | 9000000 |
| Db\_block\_size | 4096 |
| Db\_block\_buffer | 200  Db\_block\_size |
| Log\_buffer | 32768 |
| Dml\_locks | 250 |
| Sort\_area\_size | 65536 |
| Processes | 150|
| Db\_file\_multiblock\_readcount | 16 |

> [!NOTE]
> `Db_block_size` can only be set when the database is created.

### Table spaces

Temporary tablespace is hard-coded to be: `TEMPORARY_DATA`
Default tablespace is not hard -coded. Give the name you want.

Make sure the CRM7 user has this as "Default tablespace".

All Oracle users created by SuperOffice will have Default and Temporary tablespace set to SYSTEM. The fact that Temporary tablespace is set to *system* for a huge amount of users, may result in that the Tablespace `SYSTEM` will eventually go full. To avoid this please update the tablespace settings for each Oracle-user that is created, using the Storage Manager.

A tablespace with this name has to exist to run SuperOffice.

1. Save and close the file  
1. Restart "Oracle Service" and "Oracle Start" to initialize the new settings.
1. To check the new settings start "Instance Manager" and look into "Initialisation Parameters".

All Oracle users created by SuperOffice will have Default and Temporary tablespace set to `SYSTEM`. The fact that Temporary tablespace is set to *system* for a huge amount of users, may result in that the Tablespace `SYSTEM` will eventually go full. To avoid this please update the tablespace settings for each Oracle-user that is created, using the Storage Manager.

### When configuring an Oracle database using DbSetup/ServerSetup

The configuration program reads Default and Temp TableSpace names from *SUPEROFFICE.INI*

```text
[Oracle]
DefaultTableSpace=USERS
TemporaryTableSpace=TEMP
```

This is useful if you have a non-standard Oracle database server.

Users created by the setup program (and the web maintenance client later on) will use these settings to define the Oracle tablespace names that the users are granted access to.

### Oracle 18c compatibility

[!include[ALT](../compatibility/includes/oracle-18c-drivers.md)]