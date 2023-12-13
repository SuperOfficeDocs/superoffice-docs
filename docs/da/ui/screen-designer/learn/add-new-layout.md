---
uid: help-da-screen-designer-add-layout
title: Tilføj nyt skærmudseende
description: Sådan tilføjes et nyt udseende for en brugergruppe.
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: skærmdesigner, udseende, hovedkort, arkiv
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Tilføj nyt skærmudseende

Hvis standardlayout ikke afspejler en brugergruppes behov, kan du oprette et nyt udseende, der passer til brugergruppens unikke informationsbehov. Et tilpasset udseende til person- og firmakortene og de forskellige arkivfaner/detaljekort giver dine teams og din organisation mulighed for at arbejde mere effektivt.

Med tilpassede skærmlayouts til hvert af dine teams vil det være nemmere end nogensinde at finde kundedata. De mest relevante data vil altid være tilgængelige og synlige. Fjern, flyt eller skjul irrelevante eller mindre vigtige data for at fjerne rod i firmaet, personen, salget, projekt, og sagskærmene. Tilføj tilpassede arkiver med de mest relevante data for dine teams. Resultatet bliver en renere og mere ryddelig skærm, som dine teams kan arbejde i.

## Hovedkort udseende

Et tilpasset udseende til skærmbillederne Person og Firma gør det muligt for dine teams og din organisation at arbejde mere effektivt, da det eliminerer den distraherende "informationsstøj".

Hvis dit supportteam for eksempel sjældent bruger firmaadressen, når de kommunikerer med firmaer og personer, vil du gerne gøre plads til andre felter, der er vigtigere på den første side (fanen Firma). Flyt den ved at klikke på bjælkerne i venstre side af feltet og trække den over til fanen **Mere** .

Se denne video og find ud af, hvordan du tilføjer et nyt udseende, eller følg den trinvise guide nedenunder (videoen starter ved 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

### Trin

<!-- markdownlint-disable-file MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Vælg **Hovedkort** eller **Arkiver** (også kendt som detaljekort).

4. Hvis det er relevant, skal du klikke på teksten ud for **Tildel layout til**.

    Som standard kan layoutene tildeles brugergrupper.
    Hvis du derimod tilføjer hovedkortlayout for skærmbillederne Salg, Projekt, eller Sag kan du tildele layout til salgstyper, projekttyper, eller sagstyper.

5. Klik på **Tilføj** under **Layouts**.

    ![Klik på Tilføj for at oprette et nyt udseende -screenshot][img1]

6. I dialogboksen **Tilføj nyt layout** skal du vælge et udseende på listen **Opret nyt baseret på**.

    Det nye layout baseres på det valgte layout.

7. Angiv et navn til det nye layout i feltet **Navn** .

    ![Angiv korrekt navn og brugergrupper, der skal bruge dette udseende -screenshot][img2]

8. Klik på feltet **Tildel til**, og vælg den eller de brugergrupper, der skal bruge dette nye layout.

    Listen viser kun brugergrupper, der bruger standardlayoutet. En brugergruppe kan kun tildeles ét layout. Salgstyper, projekttyper, eller sagstyper vil være tilgængelige her, hvis du har valgt disse indstillinger i trin 4.

9. Angiv en beskrivelse af layoutet i feltet **Beskrivelse**.

10. Klik på **OK**, når du er færdig. Det nye layout føjes til listen **Layouts** . Det har status **Kladde**, hvilket betyder, at det endnu ikke er synligt for nogen brugere. Forhåndsvisningen kan ses på højre side af skærmen.

    > [!TIP]
    > Hvis du senere vil redigere indstillinger for udseende, skal du dobbeltklikke på udseendet på listen for at åbne dialogboksen **Rediger layoutindstillinger**. Du kan ikke redigere indstillinger for standardlayout.

11. Når det nye layout er valgt på listen **Layout**, skal du klikke på knappen **Rediger layout** for at tilpasse skærmlayoutet. Se [Rediger layout – Hovedkort][1] eller [Rediger layout – Arkiver (detaljekort)][2].
<!-- markdownlint-restore -->

> [!NOTE]
> Hvis du vil slette et udseende, skal du vælge udseendet på listen **Layout** og klikke på **Slet**. Brugergrupper, der er tildelt det slettede udseende, går tilbage til standardlayoutet.

## Detaljekort/arkivlayout

Tilpasning af layoutet af de forskellige detaljekort/arkiver til et hovedkort sker normalt, når der er forskellige behov for de forskellige brugergrupper.

Du kan oprette et nyt layout til den/de specifikke brugergrupper og konfigurere de forskellige detaljekort, der skal vises med forskelligt indhold.

Opret et nyt layout for en bestemt brugergruppe ved at oprette detaljekort med indhold, der er relevant for den pågældende brugergruppe. Ved at tilføje og fjerne de forskellige faner kan du oprette den ønskede opsætning på et hovedkort til din brugergruppe.

![Føj navnet til det nye detaljekort/arkivlayout, og vælg den eller de brugergrupper, det skal vises for -screenshot][img3]

## Relateret indhold

* [Hvordan konfigurerer jeg, hvilken information brugerne af vores firma kan få adgang til i SuperOffice CRM?][3]
* [Hvordan opretter jeg en ny brugergruppe i SuperOffice CRM?][4]
* [Brugeradministration][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: edit-layout-archives.md
[3]: ../../../admin/user-management/learn/role/index.md
[4]: ../../../admin/user-management/learn/user-groups.md
[5]: ../../../admin/user-management/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/ui/add-new-screen-layout.png
[img3]: ../../../../media/loc/en/ui/admin-screendesigner-add-archive-layout.png
