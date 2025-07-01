---
uid: help-nl-importing-files
title: Bestanden importeren
description: Bestanden importeren
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
client: win
deployment: onsite
---

# Een gegevensbestand importeren in de SuperOffice-database

Nadat u een reservekopie hebt gemaakt van een databasebestand, het juiste gegevensbestand hebt gevonden en dit hebt geplaatst in een map waar u het weer makkelijk terugvindt (zie [Importroutines][1]), kunt u met importeren beginnen.

> [!NOTE]
> Sommige programma's vergrendelen bestanden die ze openen, waardoor deze bestanden niet toegankelijk zijn voor andere programma's. Voordat u begint met importeren, moet u er zeker van zijn dat noch het importbeschrijvingsbestand noch het gegevensbestand in geen enkel ander programma (bijvoorbeeld Excel) is geopend.

**Stappen:**

<!-- markdownlint-disable-file MD029 -->
1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->

4. Nadat u een importbeschrijvingsbestand hebt gekozen en het importbestand is gevonden, worden de andere velden automatisch ingevuld. Of [u kunt desgewenst de details in de importbeschrijving bewerken][3].

5. Het is raadzaam om te controleren of de inhoud van de velden klopt met de velden die u hebt geselecteerd. In de kolom **Veld in bestand** onder **Veldtoewijzing** staat de inhoud van de eerste record in het gegevensbestand dat u importeert. In de kolom **Veld in SuperOffice CRM** wordt aangegeven naar welke velden in de SuperOffice-database deze gegevens worden geïmporteerd. Klik enkele keren op de knop **Volgende** zodat u ook de inhoud van enkele volgende records kunt bekijken.

    > [!NOTE]
    > Als de velden niet zo worden weergegeven als de bedoeling was, moet u de [veldtoewijzing][4] aanpassen of de benodigde wijzigingen aanbrengen in het importbestand.

6. Klik op **Start** om het importeren te starten. Onder in het scherm wordt de voortgang van het importproces weergegeven.

> [!NOTE]
> De omvang van de database en de gegevensverbinding (langzame of snelle verbinding met de databaseserver) bepalen hoelang het duurt om de gegevens uit het importbestand te importeren in de SuperOffice-database. U kunt het importeren echter op elk gewenst moment annuleren door te klikken op de knop **Stoppen** rechts van de voortgangsindicator.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
