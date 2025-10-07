---
uid: help-nl-udef-layout
title: Gebruikersinterface aanpassen
description: Gebruikersinterface aanpassen
keywords: udef, aangepast veld
author: Bergfrid Dias
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
---

# Gebruikersinterface aanpassen

[!include[License requirement](../../includes/req-dev-tools.md)]

SuperOffice versie 10 (uitgebracht in oktober 2021) introduceerde [Schermontwerper][1] met aanpasbare schermopmaken voor specifieke gebruikersgroepen. Eventuele aangepaste schermopmaken met de Schermontwerper kunnen de hieronder beschreven instellingen overschrijven.

Wanneer je [nieuwe velden toevoegt][2], worden ze standaard onder elkaar geplaatst. Elk veld bestaat uit een label met een gegevensveld aan de rechterkant. Je kunt bepalen waar in het raster deze velden moeten worden geplaatst.

## Waar te beginnen

1. [!include[Ga naar velden en selecteer tabblad](includes/goto-fields.md)]

**Hoe velden te selecteren:**

* Klik op een veld in het raster om het te selecteren.
* Klik en sleep in het raster om meerdere velden te selecteren.
* Klik op een veld in de lijst **Velden** om zowel het label als het gegevensveld in het raster te selecteren.

## Verplaats veld

* Klik en sleep met de muis. De velden worden automatisch aangepast om in het raster te passen.
* Klik op een veld en gebruik de pijltoetsen op het toetsenbord.
* Klik op een veld en gebruik de pijltoetsen in de rechterbenedenhoek (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Dubbelklik op een veld en specificeer positiewaarden **X** en **Y** in het dialoogvenster **Velden**.

## Stel positie in

1. Geef het volgende in de velden rechts van **Label**:

    **X**: Horizontale positie van het label. Hoe hoger het nummer, hoe verder naar rechts.

    **Y**: Berticale positie van het label. Hoe hoger het nummer, hoe verder naar beneden.

2. Geef het volgende in de velden rechts van **Data**:

    **X**: Horizontale positie van het gegevensveld. Hoe hoger het nummer, hoe verder naar rechts.

    **Y**: Verticale positie van het gegevensveld. Hoe hoger het nummer, hoe verder naar beneden.

## Richt velden uit (rechts/links)

Selecteer de velden die je wilt aanpassen en klik op links uitlijnen (<i class="ph ph-text-align-left" aria-hidden="true"></i>) of rechts uitlijnen (<i class="ph ph-text-align-right" aria-hidden="true"></i>) onder het raster.

## Wijzig de breedte van een veld

1. Dubbelklik op het relevante veld in de lijst **Velden** of het raster.
2. Geef de breedte van het label op in het veld rechts van **Label**.
3. Geef de breedte van het gegevensveld op in het veld rechts van **Gegevens**.

## De TAB-volgorde van velden op het tabblad Meer bewerken

De TAB-volgorde is de volgorde waarin u tussen de verschillende velden beweegt wanneer u op de TAB-toets drukt. U kunt de volgorde van de tabbladen wijzigen om de logische volgorde te weerspiegelen waarin de gebruikers normaliter gegevens invoeren in de velden.

De TAB-volgorde wordt weergeven in de lijst **Naam** links in het scherm. Deze volgorde is niet dezelfde als de fysieke veldposities die u ziet in het voorbeeldvenster rechtsboven.

**Stappen:**

1. Selecteer het gewenste veld onder de lijst.

1. Klik op <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> onder de lijst om het veld omhoog of omlaag te verplaatsen.

1. Klik op **Publiceren** als u de wijzigingen beschikbaar wilt maken voor SuperOffice CRM-gebruikers.

## <a id="page-1"></a>Een door de gebruiker gedefinieerd veld op de eerste pagina weergeven

1. Schakel **Verschillende velden voor pagina 1 toestaan voor verschillende gebruikersgroepen** onder in het tabblad in om verschillende velden voor pagina 1 voor verschillende gebruikersgroepen op te geven. Als dit niet is ingeschakeld, worden de velden die u opgeeft gebruikt voor alle gebruikersgroepen.

1. In de gebruikersgroepslijst hierboven selecteert u de gewenste gebruikersgroep (als u in de vorige stap **Verschillende velden voor pagina 1 toestaan voor verschillende gebruikersgroepen** hebt ingeschakeld).

1. Kies in de keuzelijst **Veld 1** het veld dat bovenaan moet worden weergegeven. Kies in de keuzelijsten **Veld 2** en **Veld 3** de velden die moeten worden weergegeven op de volgende posities.

1. Klik op **Opslaan** als u de wijzigingen alleen wilt opslaan in Instellingen en onderhoud, of klik op **Publiceren** als u de wijzigingen beschikbaar wilt stellen voor alle SuperOffice CRM-gebruikers.

### Gebruikersgroepen en velden voor pagina 1

U definieert gebruikersgroepen in het scherm **Lijsten**. U definieert de groep waartoe een gebruiker behoort in het scherm Gebruikers.

Wanneer u een naam selecteert in de lijst **Gebruikersgroep**, worden de beschikbare Pagina 1-velden voor de betreffende gebruikersgroep weergegeven onder **Veld 1**, **2** en **3**

Als u **(alle gebruikersgroepen)** selecteert in de lijst **Gebruikersgroep**, een veld of velden selecteert en de instelling opslaat, geldt dezelfde veldselectie voor alle gebruikersgroepen in SuperOffice CRM. Als u vervolgens een specifieke gebruikersgroep selecteert, kunt u de bestaande veldinstellingen opheffen voor deze groep door een andere keuze op te geven. Als u in een veld niets opgeeft, blijft dit leeg, omdat alle drie de velden worden overschreven, ongeacht de inhoud.

> [!NOTE]
> U moet een overschrijving voor één gebruikersgroep publiceren *nadat* u een instelling voor alle gebruikersgroepen hebt opgegeven. Anders heeft het geen effect.

<!-- Referenced links -->
[1]: ../../customization/screen-designer/admin/index.md
[2]: add-udef.md
