---
uid: help-da-selection-create
title: Opret udvalg
description: Arbejd med dynamiske og statiske markeringer
keywords: nyt udvalg, opret udvalg, kopier udvalg, gem som udvalg, udvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /da/search-options/selection/learn/create/copy
  - /da/search-options/selection/learn/create/index
  - /da/search-options/selection/learn/create/tutorial
---

# Opret udvalg

Du starter med et sæt kriterier fra skærmbilledet **Find** ved at bruge en typisk søgning eller tilføje dine egne kriterier. Derfra kan du gemme resultatet som et dynamisk eller statisk udvalg. Forskellen mellem de to er et udvalg, der bliver ved med at opdatere antal medlemmer (dynamisk), eller et udvalg, hvis medlemmer er frosset med et øjebliksbillede af det aktuelle antal medlemmer (statisk).

## Trin

1. Klik på **Ny** i toplinjen, og vælg **Udvalg**.

1. På skærmbilledet Søg skal du klikke på den **Find**-indstilling, der er relevant for den datatype, du vil bruge i dit udvalg. Du kan også klikke på **Typiske søgninger** for at bruge foruddefinerede søgninger.

1. [Tilføj dine søgekriterier][9] under fanen **Kriterier**.

1. Klik på **Søg**. Fanen **Resultater** viser de data, der opfylder kriterierne.

1. Hvis du vil gemme resultaterne i et udvalg, skal du klikke på **Gem som udvalg**. Hvis ikke, skal du indsnævre dine søgekriterier.

1. I dialogboksen **Gem som udvalg** skal du vælge type:

    * **Dynamisk udvalg:** Denne type udvalg vil altid blive opdateret med medlemmer, der matcher udvælgelseskriterierne.
    * **Statisk udvalg:** Denne type udvalg indeholder kun de medlemmer, du har tilføjet manuelt.
    * **Føj til eksisterende statiske udvalg:** Gem resultatet i et eksisterende udvalg. Du kan manuelt tilføje eller fjerne medlemmer fra udvalget senere.

1. Klik på **Gem**.

1. Indtast navnet på det nye udvalg, hvor der står *Udvalgsnavn*. Dette felt er obligatorisk.

1. I feltet **Udvalg er** kan du ændre til en anden type udvalg, hvis det er nødvendigt.

1. **Vælg detaljer:**

    * **Ejer:** I feltet vises den bruger, der er logget på, automatisk.

        Når du har gemt et nyt udvalg, kan du ændre ejeren ved at [redigere udvalget][6]. Det vil i praksis sige, at du overfører det fra dig selv til en anden person.

    * **Kategori:** Vælg den udvalgstype, du ønsker. Disse er defineret i Indstillinger og vedligeholdelse.

    * **Synlig for:** Vælg om udvalget skal være synligt for alle, være privat (kun synligt for den person, der er defineret som ejer) eller være synligt for alle i den brugergruppe, som ejeren tilhører.

1. Tilføj en beskrivelse af udvalget i feltet **Beskrivelse**, hvis det er relevant.

1. Når du er færdig med at definere kernedataene for udvalget, skal du klikke på **Gem**.

## <a id="copy"></a>Kopiér et udvalg

Du kan hurtigt og enkelt oprette en nøjagtig kopi af et udvalg ved at vælge opgaven **Kopier udvalget**.

Der bliver så oprettet en kopi af udvalget med teksten (kopi) bag udvalgsnavnet. Det betyder, at hvis du kopierer udvalget *Mit statiske udvalg*, får kopien navnet *Mit statiske udvalg (kopi)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="knappen Opgave"></i>, og vælg **Kopier udvalget**. Der oprettes en kopi af udvalget.

1. Giv det nye udvalg et nyt navn.

## Tips

* Hvis du forsøger at registrere et udvalg med samme navn som et eksisterende udvalg, åbnes [dialogboksen Dubletter][8]. Dette fungerer på samme måde som for firmaer.

* Klik på <i class="ph ph-star" aria-label="Star icon"></i> for eventuelt at føje udvalget til [dine favoritter][7].

* Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre for kolonneoverskrifterne. Her kan du gruppere og filtrere poster og tilføje/fjerne kolonner. Disse indstillinger kan gemmes til det aktive udvalg ved kun at vælge **Gem kun kolonner for det aktuelle udvalg**.

* Marker **Udført** for at angive, at udvalget er inaktivt. Hvis du ønsker, at udvalget skal være aktivt, lader du afkrydsningsfeltet være tomt.

* Med **SAINT** aktiveret (kræver Sales-Premium eller Service-Premium) kan du bruge [aktivitetsmonitorer][14] som kriterier for at oprette dynamiske udvalg. Dette giver dig et overblik over firmaer, personer eller projekter, der opfylder bestemte statuskriterier. SAINT-kriterierne findes under **Tællere (SAINT)** i [kriterielisten][9] i skærmbilledet **Find**.

## Relateret indhold

* [Kombinere udvalg][3]
* [Opdatering af udvalg][6]
* [Udførelse af opgaver med udvalg][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md

<!-- Referenced images -->
