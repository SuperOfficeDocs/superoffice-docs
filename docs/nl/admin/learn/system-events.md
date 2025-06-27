---
uid: help-nl-system-events
title: Systeemgebeurtenissen
description: Systeemgebeurtenissen
author: SuperOffice RnD
date: 06.29.2022
keywords: gebeurtenis
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Systeemgebeurtenissen

De volgende typen gebeurtenissen worden gestart vanuit de verschillende schermen in Instellingen en onderhoud:

* **UDefRebuild**, waarvan er verschillende typen zijn: de opmaak voor door gebruikers gedefinieerde velden wordt bijgewerkt en de door gebruikers gedefinieerde velden zijn niet toegankelijk terwijl deze gebeurtenis plaatsvindt.

    > [!NOTE]
    > U moet deze gebeurtenis niet annuleren vanuit de lijst **Systeemmeldingen**.

* **FreetextRebuild**: de vrije tekst-index wordt gegenereerd en gebruikers kunnen de freevrije tekst niet gebruiken terwijl de generatie aan de gang is.

* **PrototypeRebuild**: er wordt een Travel-prototype gegenereerd. De Travel-functies zijn niet toegankelijk terwijl deze gebeurtenis plaatsvindt.

    > [!NOTE]
    > In noodgevallen kunt u zowel **FreetextRebuild** als **PrototypeRebuild** annuleren via de lijst **Systeemmeldingen**.

* **ROURebuild**: tellers of statuscontroles worden opnieuw gegenereerd. Statusafbeeldingen, het tabblad **Statistieken** en tellers zijn niet beschikbaar terwijl de gebeurtenis plaatsvindt. (Voor statuscontroles is een [aparte licentie nodig][2].)

U kunt de volgende typen gebeurtenissen starten vanaf het licentiescherm in het tabblad **Status**:

* **Geen aanmelding**: Selecteer deze gebeurtenis om te voorkomen dat wordt aangemeld tijdens het bijwerken van server of database, periodiek onderhoud, etc.
* **Geen vrije tekst**: Selecteer deze gebeurtenis om de omvang van de uitgaande Travel-database te beperken.
* **Geen Travel**: Selecteer deze gebeurtenis om Travel uit te schakelen. Dit kan van pas komen tijdens grote systeem-upgrades, ter voorkoming van problemen met synchronisatie van terugkerende Travel-gebruikers.
* **Bericht van de dag**: Selecteer deze gebeurtenis om ervoor te zorgen dat belangrijke berichten worden weergegeven aan iedere gebruiker die zich aanmeldt bij SuperOffice CRM (en na een vertraging van een paar minuten aan alle gebruikers die zich al hadden aangemeld).

[!include[Terminate events](includes/note-terminate-event.md)]

## Gerelateerde inhoud

* [Systeemgebeurtenissen toevoegen][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
