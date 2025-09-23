---
uid: help-da-saint-status-create
title: Opret nyt status
description: Opret nyt status
keywords: SAINT, statusovervågning, billede, visualiser, søgning
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: 
  - /da/sale/saint/learn/admin/create-status
  - /da/sale/saint/learn/admin/select-image-for-status
  - /da/saint/admin/select-image-for-status
index: true
---

# Oprettelse af ny status

[!include[Requirement](../includes/note-saint-req.md)]

## Hvorfor skal du oprette en statusovervågning?

Du vil overvåge firmaer, som du har meget få aktiviteter med, for at undgå utilfredse kunder og kundeafgang. Med denne statusovervågning ser du nemt alle de kunder, der har brug for opmærksomhed.

![Opret en statusovervågning ved at klikke på knappen Tilføj i skærmbilledet -screenshot][img1]

## Trin

1. Åbn skærmbilledet **SAINT**, og vælg fanen **Firma**, **Person** eller **Projekt**

1. Klik på **Tilføj** nedenunder listen **Statusovervågning** .

1. Udfyld disse felter i dialogboksen:

    * **Navn**: Angiv et beskrivende navn for den status, du vil tilføje.

        Valgfrit: Klik på <i class="ph ph-translate" aria-label="Translate"></i> for at [tilføje oversættelser][8] af statusnavnet.

    * **Beskrivelse**: Angiv en forklarende beskrivelse af status, og hvilke foranstaltninger der kræves eller anbefales. I dette felt kan du også bruge [skabelonvariabler][9] til at skræddersy teksten til det relevante firma, den relevante person eller det relevante projekt.

    Navnet og beskrivelsen vises i SuperOffice CRM, når brugeren holder musemarkøren over statusbilledet eller åbner statusbilledet for firmaet. Du kan efterfølgende [redigere beskrivelsen][2].

1. Klik på **Gem**. Status vises på statuslisten.

1. Hvis der er flere statusser i listen, angiv **prioritet** for at bestemme, hvilket statusbillede der vises på kortet.
    Et firma, en person eller et projekt kan matche kriterierne for flere statusser, men kun ét billede kan vises.
    Vælg en status, og brug pileknapperne under listen til at flytte den op eller ned.

    ![Liste over statusmonitorer med prioritet -screenshot][img2]

### Angiv kriterier for status

Hver status skal indeholde mindst ét kriterium. Efter oprettelse af statusen:

1. Vælg den nye status på listen.
1. Vælg **Tilføj** for at indsætte et nyt kriterium.
1. Vælg en kriterietype, indstil betingelsen og indtast en værdi.
1. Gentag efter behov, vælg derefter **Regenerer valgte statusovervågning** for at aktivere statusen.

## <a id="image"></a>Valg af billede til status

Du kan tilføje et billede, der skal vises på firma-, person- eller projektkort, der opfylder statuskriterierne. Billedet vises som et let vandmærke (40% gennemsigtighed), så det ikke skjuler andet indhold.

Tilføjelse af et billede er valgfrit. Det kan hjælpe med at tiltrække opmærksomhed og symbolisere den handling, du ønsker, at brugerne skal udføre. Hvis du kun vil bruge statusen til søgninger eller udvalg, kan du lade statusen være uden billede.

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

## Relateret indhold

* [Angivelse af statuskriterier][6]
* [Angivelse af periodelængde][7]
* [Administration af statusovervågning][4]

<!-- Referenced links -->
[2]: edit-status.md
[4]: manage-status-monitors.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
