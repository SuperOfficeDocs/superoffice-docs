---
title: access_crmscript
description: Accessing the script from the Customer Centre
author: {github-id}             # Your GitHub alias.
so.date: 09.15.2011
keywords:
so.topic: howto
---

# Accessing the script from the Customer Centre

When you create a script (under **System design > Scripts**), 2 fields allow you to access the script from the Customer Centre: **Include name** and **Key**. They will allow you to identify and authenticate access to the script. The idea is that by knowing these two values, you are allowed to execute the script in the Customer Centre with this URL:

![x][img3]

![x][img4]

As you can see, there are some important parameters to customer.exe:

* `action=safeParse` – This parameter specifies the main method of the Customer Centre, which in this case tells it that we want to execute a custom script.

* `includeId=ejscript-1` – This parameter specifies that we want to execute the script with `Include name` equals *ejscript-1*.

* `key=mySecretKey` – This parameter specifies that the secret key of the script is *mySecretKey*. If it does not match the key of the script, an error will be returned.

* Optionally, you can include `withFrame=1`. This will make the page a part of the Customer Centre default visual look by placing the returned contents inside *framework.html*, just like the other Customer Centre pages.

Additionally, you can include any parameters of your choice in the URL. You can retrieve them inside your ejScript by calling the `getCgiVariable` method. This method will also retrieve any fields sent to this script by any form POST methods, which is what we will use for our custom form.

<!-- Referenced images -->
[img3]: media/image003.gif
[img4]: media/image004.gif
