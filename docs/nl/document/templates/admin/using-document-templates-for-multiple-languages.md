---
uid: help-nl-using-document-templates-for-multiple-languages
title: Documentsjablonen voor meerdere talen gebruiken
description: Documentsjablonen voor meerdere talen in de project- en verkoopgids gebruiken
keywords: documentsjabloon, Voorkeurstaal voor documenten
author: SuperOffice Product and Engineering
date: 09.17.2025
content_type: howto
audience: settings
audience_tooltip: Instellingen en onderhoud
deployment: onsite
language: nl
redirect_from: /nl/onsite/win-client/learn/using-document-templates-for-multiple-languages
---

# Documentsjablonen in meerdere talen in de project- en verkoopgids gebruiken

Wanneer uw bedrijf branches heeft in verschillende landen, kan het nuttig zijn de documentsjablonen in het project en de verkoopgidsen in meerdere talen beschikbaar te hebben. U moet eerst de documentsjablonen voor de diverse talen in de juiste mappen opnemen en vervolgens opgeven wie de verschillende taalversies gaat gebruiken.

## Documentsjablonen toevoegen voor talen

1. Start Windows Verkenner en ga naar de map *\\SuperOffice\\SO_Arc\\Template*.

2. Maak een map voor elke taal waarvoor u documentsjablonen wilt (zie de volgende tabel). Bijvoorbeeld, *\\SuperOffice\\SO_Arc\\Template\\GE*.

3. Plaats documentsjablonen voor de verschillende taken in de betreffende taalmappen. Elke documentsjabloon moet exact dezelfde bestandsnaam hebben en van exact hetzelfde bestandstype zijn als de hoofdsjabloon. De hoofdsjabloon is de documentsjabloon in de hoofdtaal die u gebruikt in SuperOffice. Deze staat in de lijst **Documentsjabloon** in het scherm **Lijsten** (dubbelklik op een documentsjabloon in de lijst om bestandsnaam/bestandstype weer te geven). Zie de lijst Items toevoegen aan de lijst Document - Sjabloon

> [!TIP]
> wanneer de documentsjabloon voor de betreffende taal NIET in de taalmap staat, wordt de documentsjabloon in de hoofdtaal gebruikt.

### Mapnamen voor de verschillende talen

[!include[Taalcodes](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Documenttalen voor gebruikers opgeven

U moet nu de juiste documenttalen selecteren voor de gebruikers die de documentsjablonen in de verschillende talen gaan gebruiken:

1. Open het scherm **Voorkeuren**, selecteer **Systeem** in de keuzelijst **Groep weergeven** en selecteer **Voorkeurstaal voor documenten**.

2. Klik op **Toevoegen** onder de lijst **Actieve instellingen**.

3. Selecteer **Gebruiker** onder **Deze instelling is van toepassing op**.

    > [!TIP]
    > wanneer de branches satellietdatabases gebruiken, kunt u ervoor kiezen documenttalen op te geven voor databases. U kunt ook documenttalen voor groepen selecteren, maar in dat geval moet de betreffende groep de primaire groep gebruikers zijn waarvoor u de documenttaal instelt.

4. Klik op **Doel** en selecteer de gewenste gebruiker.

5. Selecteer de gewenste taal in de lijst **Voorkeurstaal voor documenten**.

6. Klik op **Opslaan**.

7. Herhaal stap 2-6 voor elke gebruiker waarvoor u de documenttaal wilt instellen.
