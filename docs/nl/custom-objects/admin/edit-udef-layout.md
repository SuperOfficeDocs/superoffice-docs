---
uid: help-nl-udef-move
title: Velden verplaatsen
description: Velden verplaatsen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, aangepast veld
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Velden plaatsen

> [!NOTE]
> SuperOffice versie 10 (uitgebracht in oktober 2021) introduceerde [Schermontwerper][1] met aanpasbare schermopmaken voor specifieke gebruikersgroepen. Aanpasbare schermopmaken die gebruik maken van Schermontwerper, kunnen de hieronder beschreven instellingen overschrijven.

Wanneer u nieuwe velden toevoegt, worden ze standaard onder elkaar geplaatst. Elk veld bestaat uit een label met een gegevensveld aan de rechterkant. U kunt bepalen waar in het raster deze velden moeten worden geplaatst.

## Hoe selecteer ik velden?

* Klik op een veld in het raster om het te selecteren.
* Klik en sleep in het raster om meerdere velden te selecteren.
* Klik op een veld in de lijst **Velden** om zowel het label als het gegevensveld in het raster te selecteren.

## Hoe kan ik velden verplaatsen?

* Klik en sleep met de muis. De velden worden automatisch aangepast aan het raster.
* Klik op een veld en gebruik de pijltoetsen op het toetsenbord.
* Klik op een veld en gebruik de pijltjestoetsen in de rechterbenedenhoek ( ![pictogram][img2] ![pictogram][img1] ![pictogram][img4] ![pictogram][img3]).
* Dubbelklik op een veld een specificeer positiewaarden **X** en **Y** in het dialoogscherm **Velden**.

## Hoe stel ik de positie in?

1. Geef de volgende informatie op in de velden rechts van **Label**:

    **X**: horizontale positie van het label. Hoe hoger het getal, hoe verder naar rechts.

    **Y**: verticale positie van het label. Hoe hoger het getal, hoe verder naar beneden.

2. Geef de volgende informatie op in de velden rechts van **Gegevens**:

    **X**: horizontale positie van het gegevensveld. Hoe hoger het getal, hoe verder naar rechts.

    **Y**: verticale positie van het gegevensveld. Hoe hoger het getal, hoe verder naar beneden.

## Hoe kan ik velden rechts en links uitlijnen?

Selecteer de velden die u wilt aanpassen en klik op links uitlijnen (![pictogram][img5]) of rechts uitlijnen (![pictogram][img6]) onder het raster.

## Hoe wijzig ik de breedte van een veld?

1. Dubbelklik op het desbetreffende veld in de lijst **Velden** of het raster
2. Geef de breedte van het label op in het veld rechts van **Label**.
3. Geef de breedte van het gegevensveld op in het veld rechts van **Gegevens**.

## De TAB-volgorde van velden op het tabblad Meer bewerken

De TAB-volgorde is de volgorde waarin u tussen de verschillende velden beweegt wanneer u op de TAB-toets drukt. U kunt de volgorde van de tabbladen wijzigen om de logische volgorde te weerspiegelen waarin de gebruikers normaliter gegevens invoeren in de velden.

De TAB-volgorde wordt weergeven in de lijst **Naam** links in het scherm. Deze volgorde is niet dezelfde als de fysieke veldposities die u ziet in het voorbeeldvenster rechtsboven.

**Stappen:**

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Selecteer het gewenste veld onder de lijst.

1. Klik op een van de pijlen onder de lijst om het veld omhoog (![pictogram][img1]) of omlaag (![pictogram][img2]) te verplaatsen.

1. Klik op **Publiceren** als u de wijzigingen beschikbaar wilt maken voor SuperOffice CRM-gebruikers.

## Velden pagina 1 selecteren

> [!NOTE]
> Deze functie is niet beschikbaar als uw organisatie aangepaste schermindelingen gebruikt.

Uit de door gebruikers gedefinieerde velden die worden weergegeven op de tabbladen **Meer** in SuperOffice CRM kunt u *drie* velden kiezen die fungeren als velden voor pagina 1 (deze heten zo omdat de velden worden weergegeven op de eerste pagina van de respectievelijke schermen).

## Waar kan ik pagina 1-velden weergeven?

[!include[List](includes/list-page-1-field-locations.md)]

## Een door de gebruiker gedefinieerd veld op de eerste pagina weergeven

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Schakel **Verschillende velden voor pagina 1 toestaan voor verschillende gebruikersgroepen** onder in het tabblad in om verschillende velden voor pagina 1 voor verschillende gebruikersgroepen op te geven. Als dit niet is ingeschakeld, worden de velden die u opgeeft gebruikt voor alle gebruikersgroepen.

1. In de gebruikersgroepslijst hierboven selecteert u de gewenste gebruikersgroep (als u in de vorige stap **Verschillende velden voor pagina 1 toestaan voor verschillende gebruikersgroepen** hebt ingeschakeld).

1. Kies in de keuzelijst **Veld 1** het veld dat bovenaan moet worden weergegeven. Kies in de keuzelijsten **Veld 2** en **Veld 3** de velden die moeten worden weergegeven op de volgende posities.

1. Klik op **Opslaan** als u de wijzigingen alleen wilt opslaan in Instellingen en onderhoud, of klik op **Publiceren** als u de wijzigingen beschikbaar wilt stellen voor alle SuperOffice CRM-gebruikers.

## Gebruikersgroepen en velden voor pagina 1

Wanneer u een naam selecteert in de lijst **Gebruikersgroep**, worden de beschikbare Pagina 1-velden voor de betreffende gebruikersgroep weergegeven onder **Veld 1**, **2** en **3**

> [!NOTE]
> U definieert gebruikersgroepen in het scherm **Lijsten**. U definieert de groep waartoe een gebruiker behoort in het scherm Gebruikers.

Als u **(alle gebruikersgroepen)** selecteert in de lijst **Gebruikersgroep**, een veld of velden selecteert en de instelling opslaat, geldt dezelfde veldselectie voor alle gebruikersgroepen in SuperOffice CRM. Als u vervolgens een specifieke gebruikersgroep selecteert, kunt u de bestaande veldinstellingen opheffen voor deze groep door een andere keuze op te geven. Als u in een veld niets opgeeft, blijft dit leeg, omdat alle drie de velden worden overschreven, ongeacht de inhoud.

> [!NOTE]
> U moet een overschrijving voor één gebruikersgroep publiceren *nadat* u een instelling voor alle gebruikersgroepen hebt opgegeven. Anders heeft het geen effect.

<!-- Referenced links -->
[1]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/icons/arrow-up.png
[img4]: ../../../../media/icons/arrow-down.png
[img5]: ../../../../media/icons/admin/align-left.png
[img6]: ../../../../media/icons/admin/align-right.png
