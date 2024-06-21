---
uid: help-da-sync-add-erp-connection
title: Tilføjelse af ERP-link (Sync Connector)
description: Tilføjelse af ERP-link (Sync Connector)
author: SuperOffice RnD
date: 06.29.2022
keywords: tilbud, sync, henvisning, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af ERP-link (Sync Connector)

Hver Quote Connector skal have et ERP-link med konfigurationsinformation for at knytte Sync Connector til SuperOffice.

## Sådan tilføjer du et ERP-link

1. Gå til fanen **Sync** i skærmbilledet Tilbud/Sync.

1. Klik på **Tilføj** nederst på listen **ERP-links**. Dialogboksen **Angiv nyt ERP-link** vises.

1. Indtast navnet på ERP-linket i feltet **Navn**.

1. Vælg ønsket **ERP Sync Connector** på listen. Denne liste er identisk med **Sync Connectors**.

1. Vælg ønsket **Område**:

    * **Alle**: Vælg dette alternativ, hvis alle brugere skal have adgang til og kunne bruge dette ERP-link. Det vil sige, at de kan bruge de prislister, der er tilgængelige via dette link.
    * **Angivne brugere + grupper**: Klik på **Ingen brugere eller grupper er valgt** for at vælge, hvilke brugere og/eller brugergrupper, som skal adgang til denne ERP-link.

1. Under **Konfigurationsfelt** angiver du de ønskede indstillinger. Indholdet i denne liste varierer efter, hvilken type Sync Connector du har valgt.

1. Indtast en beskrivelse af ERP-linket i feltet nederst.

1. Klik på **Test ERP-linket** for at kontrollere, at linket fungerer. Hvis du får en fejlmeddelelse, skal du udbedre problemet, før du kan gå videre.

1. Klik på **OK**. ERP-linket vises på listen **ERP-links**.

    > [!NOTE]
    > Knappen **OK** er deaktiveret helt, indtil testen af ERP-linket er vellykket.

Du skal markere kolonnen **Aktiv** for at aktivere linket, så fanen **ERP** vises i SuperOffice CRM. Før du aktiverer ERP-linket, skal du dog sørge for, at det er konfigureret korrekt:

* Angiv synkroniseringsindstillinger, og vælg hvilke felter der skal vises i søgevinduet og på fanen **ERP**. Se [Konfigurer felttilknytning][1] og [Konfigurer listetilknytning][2].

* [Angiv ønskede standardværdier][3] for felt, der normalt kun har én aktuel værdi, så brugerne slipper for at skulle angive værdi for disse felter.

* [Vælg rækkefølgen på de ERP-felter][4], der vises på fanen ERP i SuperOffice CRM.

* Hvis du bruger flere ERP-forbindelser, kan [du angive prioritet for forbindelser][5].

* [Import af data fra ERP-systemet][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->
