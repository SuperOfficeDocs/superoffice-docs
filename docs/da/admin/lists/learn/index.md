---
uid: help-da-lists
title: Lister
description: Sådan redigeres lister
keywords: liste
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: 
  - /da/admin/lists/learn/items
  - /da/admin/lists/learn/duplicates
language: da
---

# Lister

SuperOffice CRM indeholder mange standardlister, såsom kundekategorier, aktivitetstyper, salgstyper og mange flere. Hvis du vil ændre standardlisterne, så de passer til dit firmas jargon og processer, viser denne guide dig, hvordan du redigerer lister.

Afhængigt af hvilken type branche dit firma er i, kan du skræddersy alle lister i systemet, så de afspejler dine forretningsprocesser og behov. Du kan oprette nye forekomster, deaktivere unødvendige forekomster og redigere eksisterende. Nogle forekomster findes som standard på alle listerne i SuperOffice CRM.

## Skærmbilledet Lister

Skærmbilledet **Lister** indeholder beskrivelser og definitioner på listerne i SuperOffice CRM. Her kan du tilpasse de foruddefinerede lister, der følger med SuperOffice CRM.

[!include[Find specific list](includes/tip-find-list.md)]

Du kan også tilføje dine egne brugerdefinerede lister, som vises på fanerne **Mere** i SuperOffice CRM. Du angiver, hvad der skal vises under fanerne **Mere** på skærmbilledet [Felter][10].

Skærmbilledet **Lister** er inddelt i følgende dele:

> [!NOTE]
> Brugergrupper og overskrifter vises ikke for lister, hvor de er irrelevante.

* Øverst på skærmen kan du klikke på listen for at vælge mellem alle tilgængelige lister i SuperOffice, både foruddefinerede og [brugerdefinerede lister][5].
* Fanen **Forekomster** indeholder de [forekomster](#items), der er tilgængelige for den valgte liste.
* Fanen **Brugergrupper** viser forekomster, der er [filtreret efter brugergruppe][7].
* Fanen **Overskrifter** viser [forekomster pr. overskrift][1].
* På listen **Synlig for brugergrupper** kan du se den eller de grupper, som det element, der er valgt på listen **Forekomster**, vises til. Du kan f.eks. vælge at have forskellige opfølgningstyper tilgængelige for dine brugergrupper for salg, support og regnskab.
* Listen **Overskrifter** viser de [overskrifter][1], som de enkelte elementer vises under. Hvis en liste er meget lang (indeholder et stort antal forekomster), kan du bruge overskrifter til at gruppere forekomsterne logisk. Forekomsterne på listen **Dokument – Skabelon** er f.eks. grupperet i overskrifterne **Brev**, **Fax**, **E-mail** osv.

Øverst til højre er afkrydsningsfeltet **Brug gruppering og brugergruppefiltrering til denne liste**, hvor du angiver, om listen kan grupperes og filtreres. Denne indstilling deaktiveres for lister, hvor dette er irrelevant.

Nederst på skærmbilledet **Lister** er afkrydsningsfeltet **Vis slettede forekomster og overskrifter**, som giver dig mulighed for at [fortryde][9] sletningen af forekomster og overskrifter.

## <a id="items"></a>Forekomster

I modsætning til selve listerne kan forekomster, der er indeholdt i både foruddefinerede og brugerdefinerede lister, tilføjes, ændres eller slettes.

### Dubletter

Du kan ikke oprette to forekomster med samme navn på én liste. Det samme gælder overskrifter. Hvis du forsøger at oprette et element med samme navn som et eksisterende element eller en eksisterende overskrift, får du besked om, at dette ikke er tilladt. Denne begrænsning gælder, uanset om navnet er skrevet med store eller små bogstaver.

> [!NOTE]
> Du kan ikke tilføje et nyt element eller en ny overskrift, der har samme navn som en [slettet forekomst eller overskrift][9].

## Relateret indhold

* [Organisering af lister][3]
* [Specialiserede lister][4]
* [Tilføjelse af brugerdefinerede lister][5]
* [Dokument – Skabelon][6]
* [Rediger eller slet en forekomst][8]
* [Tilføj en forekomst][11]

<!-- Referenced links -->
[1]: organize/headings.md
[3]: organize/index.md
[4]: specialized-lists.md
[5]: ../user-defined-lists.md
[6]: ../../../document/templates/learn/index.md
[7]: ../user-group-filtering.md
[8]: ../update-items.md
[9]: ../restore.md
[10]: ../../../custom-objects/admin/edit-udef-layout.md
[11]: adding-items.md

<!-- Referenced images -->
