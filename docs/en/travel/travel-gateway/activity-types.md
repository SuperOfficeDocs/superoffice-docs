---
uid: activity_types
description: Activity types for scheduling
author: SuperOffice Product and Engineering
keywords:
date:
content_type: reference
deployment: onsite
platform: win
---

# Activity types for scheduling

* **Log in** – OBSOLETE, we do this for each task there. The gateway can remain open permanently. If the program is not signed on, the sign-on is done automatically when an activity runs.

* **Log out** – OBSOLETE, we do this for each task there. If you want Gateway to sign off once a task has been completed. Gateway doesn’t need to be signed on permanently.

* **Read updates** – when you want to specify that SuperOffice CRM should read updates (UP files) residing in a particular user’s Travel folder on the server.

* **Write updates** – when you want SuperOffice CRM  to create an update log (DWN file) for a specified user.

* **Generate new Prototype** – when you want to generate a new prototype for a particular area. It is a good idea to run this outside normal office hours because local updates cannot be run while the prototype is being generated.

* **Read updates from all users** – when you want to read in all UP-files residing in users’ Travel folders on the server.

* **Write updates to all users** – when you want to write new DWN files for all active Travel users.

* **Generate Prototypes for all areas** – when using SuperOffice Area Management and you want to create prototypes for all areas.

* **Execute program/batch file** – when you want SuperOffice Travel Gateway to run a backup or a BAT file to copy files and so on.

* **Create signal file** – when you want to create a file named SIGNAL.DAT in a specified folder. This option is used to initiate a further instance of SuperOffice Travel Gateway.

* **Remote Travel Server** – runs Remote Travel Server, which is the program that receives and processes the lists of required documents created by Remote Travel Client (on the local PC). For example, you can specify that Remote Travel Client should retrieve all documents for a particular company. On the server-side, a search is run that corresponds to the client’s specified criteria and finds which documents should be transferred. Remote Travel Server should be run just before or just after you have read or written updates for Remote Travel users. There is no comparable function serving the satellites.

* **Regenerate all counters** – automatically regenerate all counters (SAINT)

* **Regenerate all statuses** – automatically regenerate all statuses (SAINT)

* **Synchronize with ERP** – If you are running ERP sync you need this task for the synchronization to run. This will perform one complete synchronization cycle against any linked ERP system.
