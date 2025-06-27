---
uid: help-nl-specifying-advanced-import-settings
title: Geavanceerde importinstellingen opgeven
description: Geavanceerde importinstellingen opgeven
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client-instellingen
content_type: howto
language: nl
client: win
envir: onsite
---

# Geavanceerde importinstellingen opgeven

Tot de geavanceerde importinstellingen behoren de instellingen voor datumnotatie en scheidingstekens. Deze instellingen moeten ervoor zorgen dat het importbestand correct kan worden geïnterpreteerd door SuperOffice.

> [!NOTE]
> Om de velden van het importbestand correct toe te wijzen, moet u mogelijk de instellingen voor de tekstindicator, het veldscheidingsteken en het rijscheidingsteken bewerken.

1. [!include[How to open import](includes/open-import.md)]

1. [!include[Select file](includes/step-select-file.md)]

1. Klik op de knop **Geavanceerd**.

1. Kies in het dialoogvenster **Geavanceerde opties** een vooraf gedefinieerd formaat uit de keuzelijst **Datumnotatie**. U kunt geen namen gebruiken voor de maanden, alleen nummers.

    > [!NOTE]
    > **Eigen ID** geeft de datum van SuperOffice weer. SuperOffice telt het aantal seconden sinds 1 januari 1970\. Dit is het getal dat wordt gebruikt voor **Eigen ID**.

1. Kies in de keuzelijst **Nummernotatie** een van de vooraf gedefinieerde opties voor decimaaltekens.

1. Typ in het veld **Selectievaknotatie** de tekens die in het importbestand worden gebruikt om aan te geven dat een selectievakje is ingeschakeld.

1. Typ in het vak **Tekstindicator** het teken waarmee in het importbestand wordt aangegeven dat wat tussen deze tekens staat gewone tekst is.

    > [!NOTE]
    > tekstindicatoren hebben voorrang boven veld- en rijscheidingstekens. Als er bijvoorbeeld een veldscheidingsteken staat tussen twee tekstindicatoren, moet dit worden geïnterpreteerd als gewone tekst. U hoeft echter geen tekstindicatoren te gebruiken als uw importbestanden veld- of rijscheidingstekens bevatten.

1. Kies in de keuzelijst **Veldscheidingsteken** een van de vooraf gedefinieerde opties voor het teken waarmee velden van elkaar worden gescheiden.

1. Kies in de keuzelijst **Rijscheidingsteken** een van de vooraf gedefinieerde opties voor het teken waarmee rijen van elkaar worden gescheiden.

1. Kies in de keuzelijst bij het veld **Werknemernotatie** een van de vooraf gedefinieerde notaties voor de interpretatie van namen in het importbestand, bijvoorbeeld of de voornaam voor de achternaam wordt geplaatst.

    > [!NOTE]
    > **Eigen ID** geeft de **medewerker-ID** weer zoals deze is geregistreerd in de database. Als deze ID niet kan worden gevonden, wordt de inhoud van het veld **Standaardmedewerker** gebruikt.

1. Kies in de keuzelijst **Standaardmedewerker** de naam die als standaard wordt ingevoerd als de SuperOffice database de werknemernotatie in het importbestand niet kan worden interpreteren.

1. Kies in de keuzelijst **Landnotatie** een van de vooraf gedefinieerde notaties voor de interpretatie van landen, bijvoorbeeld of de naam in het Engels of in de eigen taal wordt weergegeven.

    > [!NOTE]
    > **Eigen ID** geeft de **land_id** weer zoals deze is geregistreerd in de database.

1. Kies in de keuzelijst **Standaard landnaam** het land dat standaard moet worden ingevoerd in de SuperOffice database als de landnotatie in het importbestand niet kan worden geïnterpreteerd.

1. Kies in de keuzelijst **Valuta** de valuta die moet worden ingevoerd in de SuperOffice database als de valutanotatie in het importbestand niet kan worden geïnterpreteerd.

1. Schakel **Vrije-tekstindex bijwerken** in om de vrije-tekstindex voortdurend bij te werken tijdens de import, zodat de index volledig is bijgewerkt als de import voltooid is.

    > [!NOTE]
    > de snelheid van de import neemt af als u **Vrije-tekstindex bijwerken** inschakelt. Om grote hoeveelheden gegevens te importeren, kunt u de import uitvoeren zonder deze optie in te schakelen en kunt u achteraf een nieuwe [vrije-tekstindex genereren][2] via het scherm **Opties**.

1. Nadat u de vereiste instellingen hebt opgegeven, klikt u op **OK**.

    [!include[Save mapping](includes/tip-save-mapping.md)]

> [!NOTE]
> Als u een importbeschrijvingsbestand hebt opgegeven in het veld **Importbeschrijvingsbestand,** zijn sommige velden in het dialoogvenster **Geavanceerde opties** mogelijk al ingevuld. U kunt deze gegevens echter wijzigen zoals hiervoor is beschreven. Vergeet het importbeschrijvingsbestand niet op te slaan alvorens dit bestand wordt bijgewerkt met nieuwe opties.

<!-- Referenced links -->
[2]: ../../../../admin/options/learn/freetext-search/regenerate-index.md

<!-- Referenced images -->
