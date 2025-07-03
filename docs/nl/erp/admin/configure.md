---
uid: help-nl-erp-configure
title: ERP-verbinding configureren
description: Configureer de synchronisatie tussen SuperOffice CRM en uw ERP-systeem door velden toe te wijzen, standaardwaarden in te stellen en ERP-verbindingen te prioriteren.
keywords: ERP-verbinding, synchronisatie configureren, veldtoewijzing, lijsttoewijzing, standaardwaarden, ERP-velden rangschikken, synchronisatieprioriteit instellen, ERP-verbinding bewerken, SuperOffice ERP-integratie, ERP-tabblad, sync connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from:
  - /nl/quote/learn/admin/sync/sync-configure-default-values
  - /nl/quote/learn/admin/sync/sync-configure-field-allocation
  - /nl/quote/learn/admin/sync/sync-configure-list-mapping
  - /nl/quote/learn/admin/sync/sync-rank-fields-shown-in-erp-tab
  - /nl/quote/learn/admin/sync/sync-set-sync-priority
index: true
---

# ERP-verbinding configureren

Nadat u een ERP-verbinding hebt toegevoegd, moet u configureren hoe gegevens worden gesynchroniseerd tussen SuperOffice en het ERP-systeem. Dit doet u via de knoppen onderaan het tabblad **Synchroniseren** in het scherm Offerte/Synchroniseren.

![ERP-verbindingenlijst met opties onderaan -screenshot][img1]

## Veldtoewijzing

Bij veldtoewijzing bepaalt u welke ERP-velden overeenkomen met welke SuperOffice-velden en hoe de gegevens tussen beide systemen vloeien. De beschikbare ERP-actors en ERP-velden worden geleverd door de sync connector en verschillen mogelijk per ERP-systeem. U kunt de synchronisatierichting instellen en bepalen welke velden worden weergegeven in het zoekvenster en op het **ERP**-tabblad in SuperOffice CRM.

1. Selecteer de ERP-verbinding en klik op **Toewijzingen** linksonder in het scherm.

    Het dialoogvenster **Toewijzingen** wordt geopend en toont tabbladen voor de beschikbare ERP-actors (zoals Klant, Leverancier, Contactpersoon of Project).

1. Selecteer het tabblad voor de actor die u wilt configureren.

1. Vink **Synchroniseer ERP-"[actor]" met SuperOffice-"[entiteit]"** aan om synchronisatie in te schakelen.

1. Geef voor elk ERP-veld in de lijst op:

    * **SuperOffice-veld:** Welk SuperOffice-veld moet worden gekoppeld aan het ERP-veld.
    * **Richting:** Richting van de synchronisatie instellen. Gebruik **&gt;** voor ERP naar SuperOffice, **&lt;** voor SuperOffice naar ERP, of **&lt; &gt;** voor tweerichtingssynchronisatie.

        De richtingspictogrammen hebben drie statussen:
        * **Grijs:** Uitgeschakeld. Selecteer eerst een SuperOffice-veld.
        * **Wit:** Ingeschakeld, maar niet geselecteerd.
        * **Blauw:** Geselecteerd.

    * **Weergeven in zoekopdracht:** Aanvinken als het veld zichtbaar moet zijn in zoekresultaten.
    * **Weergeven in ERP-tabblad:** Aanvinken als het veld zichtbaar moet zijn op het **ERP**-tabblad in SuperOffice CRM (bedrijf, persoon en project).

        Als een veld al wordt gesynchroniseerd, is weergave op het **ERP**-tabblad doorgaans niet nodig.

    ![Veldtoewijzing ERP configureren -screenshot][img2]

1. Herhaal deze stappen voor andere actors indien nodig.

1. Klik op **Gereed** wanneer u klaar bent.

U kunt nu doorgaan met lijsttoewijzing, standaardwaarden of het rangschikken van velden, of de verbinding activeren als verdere configuratie niet nodig is.

## <a id="list-mapping"></a>Lijsttoewijzing

Als u lijstvelden hebt toegewezen, zoals categorie of status, moet u ook de afzonderlijke lijstitems toewijzen tussen het ERP-systeem en SuperOffice.

1. Selecteer de ERP-verbinding en klik op **Lijsttoewijzing** linksonder in het scherm.

1. Selecteer een lijst in het dialoogvenster. De overeenkomstige ERP- en CRM-items worden weergegeven.

    Als er geen lijsten worden weergegeven, controleer dan of de relevante velden zijn toegewezen in het dialoogvenster **Veldtoewijzing**.

1. Wijs voor elk ERP-item het overeenkomende CRM-item toe.

    Elk ERP-item kan slechts aan één CRM-item worden toegewezen. Dubbele toewijzingen worden rood weergegeven. Kies **(Geen selectie)** om een ERP-item niet toe te wijzen.

1. Herhaal dit voor alle relevante lijsten.

1. Klik op **Opslaan** en activeer de ERP-verbinding als er geen verdere configuratie nodig is.

## <a id="defaults"></a>Standaardwaarden voor synchronisatie

Standaardwaarden helpen om handmatige gegevensinvoer te verminderen voor velden die meestal een vaste of voorspelbare waarde hebben. Dit is vooral handig bij het importeren van grote hoeveelheden gegevens of wanneer gebruikers telkens dezelfde waarde moeten invoeren of een vakje moeten aanvinken dat altijd actief moet zijn.

1. Selecteer de ERP-verbinding en klik op **Standaardwaarden** linksonder in het scherm.

1. Selecteer in het dialoogvenster het tabblad voor de actor waarvoor u standaardwaarden wilt configureren.

    ![Standaardwaarden voor synchronisatie configureren -screenshot][img3]

1. Klik op **Toevoegen** om een nieuwe standaardwaarde te definiëren. Het dialoogvenster **Standaardwaarden voor synchronisatie toevoegen** wordt geopend.

1. In het dialoogvenster:

    * **ERP-veld:** Selecteer het veld waarvoor u een standaardwaarde wilt instellen.

    Kies vervolgens hoe dit veld zich moet gedragen:

    * **Standaardwaarde instellen:** Pas automatisch een specifieke waarde toe tijdens de synchronisatie. U moet een waarde invoeren.
    * **Gebruiker om waarde vragen:** Laat de gebruiker handmatig een waarde invoeren.
    * **Verplicht – gebruiker moet waarde invullen:** Vereist dat een waarde wordt opgegeven. U moet hierbij ook een van bovenstaande opties kiezen.

    ![Standaardwaarde voor synchronisatie toevoegen -screenshot][img4]

1. Klik op **OK** om op te slaan.

1. Herhaal indien nodig om meerdere standaardwaarden toe te voegen.

## <a id="rank"></a>Velden rangschikken die worden weergegeven op ERP-tabblad

Stel de volgorde in van velden die worden weergegeven op het **ERP**-tabblad van de schermen Bedrijf, Persoon en Project. Alle beschikbare velden worden hier weergegeven, maar alleen velden die zijn gemarkeerd voor weergave verschijnen daadwerkelijk op het tabblad.

1. Selecteer de ERP-verbinding en klik op **Velden rangschikken** linksonder in het scherm.

1. Selecteer in het dialoogvenster het tabblad voor de actor waarvoor u de volgorde wilt instellen.

    Alle beschikbare velden worden weergegeven, ook de velden die niet zichtbaar zijn op het **ERP**-tabblad.

    ![ERP-velden rangschikken -screenshot][img5]

1. Selecteer een veld en gebruik <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> om de volgorde aan te passen.

1. Herhaal dit voor andere actors indien nodig.

1. Klik op **Gereed** om uw wijzigingen op te slaan.

## <a id="priority"></a>Synchronisatieprioriteit instellen

Als meerdere ERP-verbindingen tegelijkertijd actief zijn, kunt u aangeven welke verbinding prioriteit moet krijgen bij zware gegevensverwerking.

1. Klik op **Synchronisatieprioriteit instellen** onderaan de lijst **ERP-verbindingen**.

1. Selecteer in het dialoogvenster een verbinding.

1. Gebruik <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> en <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> om de verbinding omhoog of omlaag te verplaatsen.

1. Klik op **Gereed** om op te slaan.

## Problemen oplossen

### ERP-verbinding kan niet worden geactiveerd

Als de ERP-verbinding niet kan worden geactiveerd, controleer dan de veldtoewijzing:

* Verplichte velden moeten een synchronisatierichting hebben.
* Eventuele configuratiefouten geven een duidelijke foutbericht.
* U moet deze corrigeren voordat u de verbinding activeert.

### Richtingspijlen zijn niet beschikbaar

Als de richtingspijlen grijs blijven, zelfs na het selecteren van een SuperOffice-veld, kan dat de volgende oorzaken hebben:

* Het veld kan niet worden gesynchroniseerd (bijvoorbeeld een ID-veld of alleen-lezen gegevens).
* Het veld is ongeldig voor de geselecteerde ERP-actor.

Wijs met de muis op de pijl om een tooltip met uitleg te bekijken.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
