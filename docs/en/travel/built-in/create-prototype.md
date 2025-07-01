---
uid: create_prototype_builtin
title: Create prototype for built-in travel database
description: Create a prototype for the built-in travel database
author: SuperOffice Product and Engineering
keywords:
date:
content_type: howto
deployment: onsite
platform: win
---

# Create prototype: built-in

To generate an update prototype from the Admin client:

1. Open the **Replication** screen in the Admin client.

2. Click the **Generate prototype** button on the right of the screen.

    If you are using Area Management, there will be a dialog box allowing you to choose the area required.

3. A dialog box opens, asking you to confirm that you want to start prototype generation. Click **OK**.

    The generation is started. A message box displays the progress of the task.

    > [!NOTE]
    > The prototype is saved centrally to the *SO_ARC\TEMPLATE\TRAVEL* folder, with the name **TravelAREA0.DB** if you are using a built-in database or **AREA0.DB** if you are using a Sybase database so that all Travel users use the same prototype. The MSDE database files are located in the **ProtoServerPath** folder. While a prototype is being generated, no one will be able to activate the Travel function.

4. Once the task has been completed, the status message box closes and you are returned to the **Replication** screen. The prototype is now ready for use.
