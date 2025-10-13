---
uid: help-da-saint-setup
title: Konfigurer ny aktivitetsovervågning
description: Konfigurer ny aktivitetsovervågning
keywords: SAINT, aktivitetsovervågning, statusovervågning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
index: true
redirect_from: 
  - /da/sale/saint/learn/admin/create-status
  - /da/sale/saint/learn/admin/select-image-for-status
  - /da/saint/admin/select-image-for-status
  - /da/saint/admin/create-status
---

# Konfigurer ny aktivitetsovervågning

[!include[Requirement](../includes/note-saint-req.md)]

Med statusovervågning ser du nemt alle de kunder, der har brug for opmærksomhed.

For at oprette en status definerer du dens navn og beskrivelse, tilføjer mindst ét kriterium og indstiller eventuelt en prioritet, standardopfølgningstype eller billede. Trinene nedenfor viser hele processen.

## Trin

1. Åbn skærmbilledet **SAINT** i Indstillinger og vedligeholdelse, og vælg fanen **Firma**, **Person** eller **Projekt**.

1. Klik **Tilføj** under listen **Statusovervågning**.

1. I dialogboksen skal du udfylde disse felter:

    * **Navn:** Angiv et beskrivende navn for den status, du vil tilføje.
        Valgfrit: Vælg <i class="ph ph-translate" aria-label="Translate"></i> for at [tilføje oversættelser][8] af statusnavnet.

    * **Beskrivelse:** Angiv en klar beskrivelse af statusen og hvilken handling der kræves eller anbefales. Du kan også bruge [skabelonvariabler][9] til at skræddersy teksten til firmaet, personen eller projektet.

    ![Ny statusovervågningsdialog -screenshot][img1]

    Navnet og beskrivelsen vises i SuperOffice CRM, når brugeren holder musemarkøren over statusbilledet eller åbner statusdialogen. Du kan senere redigere beskrivelsen.

1. Klik **Gem**. Vælg derefter den nye status på listen for at fortsætte med opsætningen.

1. **Angiv kriterier for statusen:**

    1. Under kriterielisten skal du vælge **Tilføj** for at indsætte et nyt kriterium.
    1. Vælg en kriterietype, indstil betingelsen og indtast en værdi.

    ![Kriterieliste med flere betingelser defineret og knappen Tilføj under listen -screenshot][img3]

    Hver status skal indeholde mindst ét kriterium. Gentag efter behov for at tilføje flere.

1. *(Valgfrit)* [Definer en standardopfølgningstype][2] for statusen i fanen **Opret opfølgning**.

1. *(Valgfrit)* [Vælg et billede for at visualisere statusen](#image).

1. Hvis der er flere statusser på listen, indstil **prioriteten** for at kontrollere, hvilket statusbillede der vises på kortet.
    Et firma, en person eller et projekt kan matche kriterierne for flere statusser, men kun ét billede kan vises.
    Vælg en status, og brug pileknapperne under listen til at flytte den op eller ned.

    ![Liste over statusovervågninger med prioriteringer -screenshot][img2]

1. Når du er færdig, skal du vælge <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerer valgte statusovervågning** for at aktivere statusen.

## <a id="image"></a>Valg af billede til status

Du kan tilføje et billede, der skal vises på firma-, person- eller projektkort, der opfylder statuskriterierne. Billedet vises som et let vandmærke (40% gennemsigtighed), så det ikke skjuler andet indhold.

Tilføjelse af et billede er valgfrit. Det kan hjælpe med at tiltrække opmærksomhed og symbolisere den type opfølgningshandling, du ønsker, at brugerne skal udføre. Hvis du kun vil bruge statusen til søgninger eller udvalg, kan du lade den være uden billede.

1. På statuslisten skal du vælge den ønskede status.
1. I højre side af skærmen skal du markere **Visualiser** for at få vist billedet.
1. Vælg **Ændr billede**.
1. Gør ét af følgende:
    * Vælg et af de eksisterende billeder fra listen **Billeder**.
    * Vælg **Tilføj**, upload en fil, indtast en beskrivelse og vælg **Gem**.
1. Vælg **OK** for at bekræfte.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Brug enkle, lysfarvet billeder, der repræsenterer statusen meningsfuldt. For eksempel kan et spindelvæv symbolisere inaktivitet.

## Brug skabelonvariabler i beskrivelser

Du kan bruge skabelonvariabler i feltet **Beskrivelse** til at tilpasse teksten, der vises i opfølgninger eller statusdialoger. Variabler erstattes med oplysninger fra firmaet, personen eller projektet.

### Eksempel

En status kan for eksempel gælde for firmaer, som opfylder følgende kriterier:

* Kategori = Kunde
* Sidste salg er mere end 2 måneder gammelt
* Antal salg er højere end 50

Teksten i feltet **Beskrivelse** kunne for eksempel være følgende:

"&lt;name&gt; har tidligere været en god kunde, men vi har ikke solgt noget til dem i 2 måneder. &lt;cont&gt; er hovedkontakten for denne kunde og bør kontakte kunden snart på telefon (&lt;cpho&gt;) eller e-mail (&lt;mail&gt;) for at finde ud af hvorfor."

I dette eksempel bruges følgende skabelonvariabler:

| Variabel | Beskrivelse |
|---|---|
| name | Navnet på firmaet |
| cont | Navnet på vores kontakt for firmaet |
| cpho | Firmaets telefonnummer |
| mail | Firmaets e-mailadresse |

## Relateret indhold

* [Opdater, slet og gendan statusovervågning][2]
* [Tællere og tællerindstillinger (periode)][7]
* [Regenerer statusovervågning og tællere][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png
