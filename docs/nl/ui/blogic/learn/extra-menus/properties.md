---
uid: help-nl-ui-extra-menu-properties
title: Menu-eigenschappen
description: Menu-eigenschappen
author: SuperOffice RnD
date: 06.29.2022
keywords: Service
content_type: howto
language: nl
---

# Menu-eigenschappen

[!include[Legacy](../includes/legacy-extra-menus.md)]

Hier kunt u de eigenschappen van opties van extra menu's en webvensters bewerken.

* **Basisprogramma**: selecteer een basisprogramma als u wilt dat de inhoud van het veld URL wordt toegevoegd aan een geselecteerd basisprogramma. Hiertoe moet de tekst in het veld URL beginnen met &action=...

* **URL**: de URL die moet worden uitgevoerd wanneer op het menu wordt geklikt.

* **ID toevoegen**: de ID van het huidige item wordt automatisch toegevoegd aan het einde van de URL.

* **Terug naar hetzelfde scherm**: door dit vakje in te schakelen gaan de gebruikers automatisch terug naar het scherm waarin op de knop (of vergelijkbaar) is geklikt. Anders zouden de gebruikers dit handmatig moeten doen.

  * U gebruikt deze optie bijvoorbeeld: als u een knop (macro) maakt in het scherm Verzoek om de categorie van het verzoek te wijzigen. In dit geval wilt u ook teruggaan naar hetzelfde verzoek nadat op de knop is geklikt.

  * U gebruikt deze optie bijvoorbeeld NIET: als u een knop (script) maakt die allerlei informatie weergeeft op het scherm. In dit geval wilt u deze functie niet ingeschakeld hebben, omdat u de informatie op het scherm wilt weergeven. Hetzelfde geldt voor externe URL's, omdat u naar de website wilt gaan wanneer u op de knop klikt.

* **Append &lt;usec&gt;**: &lt;usec&gt; is de sessiesleutel voor de NetServer-sessie. Om een webpaneel te laten werken met NetServer met behulp van authenticatie, moet deze sleutel zijn opgenomen.

* **Doel**: doel voor de URL. U kunt het venster selecteren waarin de URL wordt geopend door de naam van het venster in te voeren in het veld **Doel**. Typ "_blanco" wanneer u altijd een nieuw venster/tabblad wilt openen of typ bijvoorbeeld "customer" om een afzonderlijk venster te openen voor deze menu-optie of groep menu-opties.

* **URL voor pictogram**: als u een eigen pictogram wilt gebruiken voor het extra menu, typt u hier de URL voor de afbeelding.

* **Positie**: de positie van de extra menu's (0= bovenaan).
