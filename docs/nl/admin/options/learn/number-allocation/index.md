---
uid: help-nl-number-allocation
title: Nummertoewijzing
description: Nummertoewijzing
keywords: nummer, teller
author: Bergfrid Dias
date: 03.24.2023
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Nummertoewijzing

Tellers zorgen ervoor dat telkens wanneer een nieuw exemplaar van een veld wordt gebruikt, de waarde van het veld met 1 wordt verhoogd. Wanneer het eerste bedrijf in de database in het veld **Nummer** wordt geregistreerd met de waarde 10001, krijgt het negentiende bedrijf de waarde **10019**.

Tellers kunnen van toepassing zijn op de volgende velden:

* Het veld **Nummer** in het scherm Bedrijf, het scherm Project, het scherm Verkoop en het scherm Contactpersoon.

* Het veld **Onze ref.** in het venster Document als dat is gedefinieerd voor de desbetreffende sjabloon.

* U kunt ook tellers van andere leveranciers gebruiken.

In het bovenste gedeelte van het tabblad **Nummertoewijzing** ziet u een tabel met de tellers die zijn gedefinieerd.

## Kolommen

| Kolom | Beschrijving |
|---|---|
| \[Icon\] | Geeft aan waar de teller wordt toegepast, bijvoorbeeld <i class="ph ph-buildings" aria-label="Company icon"></i> voor het scherm Bedrijf. |
| Teller | Geeft de naam van de teller weer, bijvoorbeeld **Nummer bedrijf**, die geldt voor het veld **Nummer** in het scherm Bedrijf. |
| Volgende | Geeft de volgende waarde weer voor de desbetreffende teller. |
| Toewijzen | Geeft aan of de automatische tellerfunctie wordt gebruikt, waardoor automatisch een volgnummer wordt ingevoerd. |
| Uniek | Geeft aan of de tellerwaarden uniek moeten zijn. Handig wanneer gebruikers zelf waarden toewijzen. |
| Alleen lezen | Geeft aan of gebruikers zelf waarden kunnen typen in de tellervelden. |
| Blanco toestaan | Geeft aan of een leeg tellerveld is toegestaan. Handig wanneer de tellerwaarden uniek moeten zijn. Als **Blanco toestaan**is ingeschakeld, houdt dat in dat de eis dat de waarden uniek moeten zijn niet geldt voor lege velden. |
| Laatst gebruikt | Laat zien wanneer het betreffende tellerveld het laatst is gebruikt. |
| Op - Gebruikers-ID | Laat zien door wie het betreffende tellerveld het laatst is gebruikt. |
| Op - Portret | Laat een miniatuurafbeelding zien van degene die het betreffende tellerveld het laatst heeft gebruikt. |

## Resultaten van nummertoewijzing

De volgende tabel laat de gevolgen zien van de verschillende combinaties van de waarden **Toewijzen** (T), **Uniek** (U), **Alleen lezen** (A) en **Leeg/blanco toestaan** (B):

| A | U | R | B | Resultaat |
|:-:|:-:|:-:|:-:|---|
| | | | | Gebruikers kunnen invoeren wat ze willen. |
| x | | | | Er wordt een nummer toegewezen dat de gebruiker kan wijzigen. |
| x | x | | | Er wordt een nummer toegewezen dat de gebruiker kan wijzigen in een unieke waarde. De database kan slechts één leeg veld hebben. |
| x | x | x | | Er wordt een nummer toegewezen dat de gebruiker niet kan wijzigen. |
| x | x | x | x | Er wordt een nummer toegewezen dat de gebruiker niet kan wijzigen. |
| x | x | | x | Er wordt een nummer toegewezen dat de gebruiker kan wijzigen in een unieke waarde of kan verwijderen. De database kan verschillende lege velden hebben. |
| x | | x | | Er wordt een nummer toegewezen dat de gebruiker niet kan wijzigen. Als externe processen het aantal wijzigen, wordt uniciteit niet gecontroleerd. |
| | x | | | Er wordt geen nummer toegewezen. De gebruiker kan een nummer opgeven, maar dit moet uniek zijn. De database kan slechts één leeg veld hebben. |
| | x | | x | Er wordt geen nummer toegewezen. De gebruiker kan een nummer opgeven, maar dit moet uniek zijn. De database kan verschillende lege velden hebben. |
| | | x | x | Er wordt geen nummer toegewezen en de gebruiker kan ook geen nummer opgeven. Dit is handig wanneer u tellers van andere leveranciers gebruikt. |
| | | x | | Er wordt geen nummer toegewezen en de gebruiker kan ook geen nummer opgeven. De database kan slechts één leeg veld hebben. (niet aanbevolen). |

## Gerelateerde inhoud

* [Nummertoewijzing opgeven][2]
* [Standaardwaarden voor nieuwe documentsjablonen opgeven][3]

<!-- Referenced links -->
[2]: configure.md
[3]: document-template-defaults.md
