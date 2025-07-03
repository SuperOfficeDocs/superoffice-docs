---
uid: help-nl-erp-update-connection
title: ERP-verbinding bewerken
description: Lees hoe u de naam, reikwijdte of configuratie van een bestaande ERP-verbinding in SuperOffice CRM kunt wijzigen.
keywords: ERP-verbinding bewerken, ERP-instellingen wijzigen, ERP-configuratie, sync connector, SuperOffice synchronisatie
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from: /nl/quote/learn/admin/sync/sync-edit-erp-connection
index: true
---

# ERP-verbinding bewerken

U kunt de naam, reikwijdte of configuratiewaarden van een bestaande ERP-verbinding wijzigen.

> [!NOTE]
> Als de verbinding actief is (aangevinkt in de kolom **Actief**), moet u deze tijdelijk deactiveren om configuratiewaarden te wijzigingen. Vergeet niet de verbinding opnieuw te activeren nadat u de configuratie hebt voltooid.

## Stappen

1. In **Instellingen en onderhoud** selecteer in het navigator <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offerte/Synchroniseren**, en open het tabblad **Synchroniseren**.

1. Selecteer de ERP-verbinding en klik op **ERP-verbinding configureren**.

1. Pas de naam of reikwijdte aan zoals nodig.

1. Om connector-specifieke configuratievelden bij te werken:

    1. Schakel het selectievakje **Actief** uit.
    1. Werk de velden bij indien nodig.
    1. Schakel **Actief** in.
    1. Klik op **ERP-verbinding testen** en los eventuele fouten op.

1. Klik op **OK** om op te slaan en het dialoogvenster te sluiten.

1. Als u veldtoewijzingen, standaardwaarden of lijstkoppelingen wilt aanpassen, gebruikt u de knoppen linksonder. Raadpleeg [ERP-verbinding configureren][1] voor gedetailleerde instructies.

## Problemen oplossen

### ERP-verbinding kan niet worden opgeslagen

Als de knop **OK** grijs blijft bij het toevoegen of bewerken van een verbinding:

* Controleer of de verbindingscontrole is geslaagd.
* Zorg ervoor dat alle verplichte configuratievelden zijn ingevuld.
* Controleer of verplichte instellingen (zoals bereik) zijn voltooid.

## Gerelateerde inhoud

* [Een Sync Connector en ERP-verbinding toevoegen][2]
* [Bedrijven, contactpersonen en projecten koppelen aan ERP-actoren][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md
