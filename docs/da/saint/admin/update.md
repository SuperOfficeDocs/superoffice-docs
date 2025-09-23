---
uid: help-da-saint-update
title: Opdater aktivitetsovervågning
description: Opdater aktivitetsovervågning
keywords: SAINT, aktivitetsovervågning, standardopfølgningstype, slet statusovervågning, gendan statusovervågning, kriterier, regenerer statusovervågning, regenerer tæller
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
index: true
redirect_from: 
  - /da/sale/saint/learn/admin/edit-status
  - /da/saint/admin/edit-status
  - /da/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /da/saint/admin/select-default-follow-up-type-for-status
  - /da/sale/saint/learn/admin/restore-status
  - /da/saint/admin/restore-status
  - /da/sale/saint/learn/admin/select-status-criteria
  - /da/saint/admin/select-status-criteria
  - /da/sale/saint/learn/admin/manage-status-monitors
  - /da/saint/admin/manage-status-monitors
---

# Opdater aktivitetsovervågning

[!include[Requirement](../includes/note-saint-req.md)]

## Åbn SAINT-skærmbilledet

Før du udfører nogen af de følgende opgaver, skal du åbne skærmbilledet **SAINT** i Indstillinger og vedligeholdelse og vælge fanen **Firma**, **Person** eller **Projekt**.

## Redigering af statusbeskrivelse

Fanen **Beskrivelse** viser den beskrivelse, du indtastede, da du [oprettede statussen][1].

1. Gå til statuslisten, og vælg den status, du vil redigere beskrivelsen for.

1. Rediger teksten på fanen **Beskrivelse**.

## Valg af standardopfølgningstype til status

Du kan knytte en opfølgningstype til en status. Når en bruger klikker midt på statuskortet, åbnes en opfølgning automatisk. Dette kan indeholde forhåndsudfyldt tekst, der forklarer, hvilken handling der skal udføres for firmaer, personer eller projekter med denne status.

For at angive en standardopfølgningstype og beskrivelse skal du bruge fanen **Opret opfølgning**.

1. Vælg den ønskede status på statuslisten.
1. Gå til fanen **Opret opfølgning**.
1. Vælg en opfølgningstype fra rullelisten **Type**.
1. Angiv den besked, der skal vises i dialogboksen for opfølgning.

![Fanen 'Opret opfølgning' i SAINT-statusovervågningen, der viser valg af opfølgningstype og indtastning af tilpasset besked. -screenshot][img1]

## <a id="criteria"></a>Tilføj kriterier til en status

Hver status skal have mindst ét kriterium. [Kriterierne][2] bestemmer, hvilke firmaer, personer eller projekter statusen gælder for.

1. På statuslisten skal du vælge den ønskede status.

1. Under kriterielisten skal du vælge **Tilføj** for at indsætte en ny række.

1. Vælg en kriterietype fra rullelisten.

    ![Kriterieliste med flere betingelser defineret og knappen Tilføj under listen -screenshot][img3]

1. Angiv betingelsen (såsom **Før**, **Efter** eller **Lig med**), og indtast en værdi.

1. Gentag for at tilføje flere kriterier.

    > [!NOTE]
    > Du kan kun tilføje ét af hver kriterietype. Du kan f.eks. ikke tilføje kriteriet **Postnr.** to gange.

1. Vælg <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Genopretter valgt statusovervågning** for at anvende ændringerne.

## <a id="delete"></a>Slet en statusovervågning

Du kan slette en status fra statusovervågningslisten. Slettede statusser kan gendannes senere.

1. På statuslisten skal du vælge den status, du vil slette.
1. Klik på **Slet** nederst på listen.

Den slettede status fjernes fra den aktive liste, men kan vises igen ved at vælge **Vis slettede**.

## <a id="restore"></a>Gendan en slettet statusovervågning

Du kan gendanne en tidligere slettet status og regenerere den.

1. Nederst på statuslisten skal du vælge **Vis slettede**.

1. Dobbeltklik på den status, du vil gendanne.

    ![Statusovervågningsdialog åben efter valg af en slettet status, med Gendan og Gem-knapper synlige -screenshot][img2]

1. I dialogboksen **Statusovervågning** skal du vælge **Gendan** og derefter vælge **Gem**.

    Statussen gendannes og vises med sort tekst på listen.

1. Vælg **Regenerer valgt statusovervågning** for at opdatere den gendannede status.

## <a id="regen"></a>Regenerer statusser og tællere <i class="ph ph-arrow-circle-right" aria-hidden="true"></i>

I bunden af fanen **Statusovervågning** viser indikatorer datoen for den seneste opdatering. Et rødt kryds i statuslisten betyder, at statusen ikke er aktiv, før du regenererer den. Hvis et element aldrig er blevet genereret, eller den sidste generering var for længe siden, kan resultaterne være forældede.

Statusser og tællere, der ikke er opdaterede, forbliver synlige i SuperOffice CRM, men dataene kan være forkerte. Du bør regenerere, når kriterier ændres, du har redigeret en hensigt for en opgave, eller når indikatorerne antyder, at dataene er forældede.

### Regenerer statusser

| Navn | Beskrivelse | Placering |
|---|---|---|
| Genopretter valgt statusovervågning | Opdaterer den valgte status | I bunden af fanen **Firma**, **Person** eller **Projekt** |
| Generer alle statusser igen | Opdaterer alle statusser | I bunden af fanen **Statusovervågning** |

### Regenerer tællere

| Navn | Beskrivelse |
|---|---|
| Genopret alle tællere | Opdaterer alle tællere |

<!-- Referenced links -->
[1]: set-up.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
