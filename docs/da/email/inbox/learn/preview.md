---
uid: help-da-email-inbox-preview
title: Vis e-mailmeddelelser
description: Sådan forhåndsvises, flyttes, markeres og udskrives e-mailmeddelelser i SuperOffice Indbakke
keywords: åbn e-mail, vis e-mail, forhåndsvisning, flyt e-mail, marker som læst, udskriv, e-mail, SuperOffice Indbakke
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/email/inbox/learn/mark-as-read
  - /da/email/inbox/learn/move-email-to-folder
  - /da/email/inbox/learn/print
---

# Vis e-mailmeddelelser

Når du vælger en e-mail i indbakken, vises en forhåndsvisning af meddelelsen i højre side af skærmbilledet. Dobbeltklik på en meddelelse for at åbne den i et separat vindue.

![Forhåndsvisning af e-mail med markeret meddelelse og tilgængelige handlinger -screenshot][img1]

## Forhåndsvisningspanel

Forhåndsvisningen viser indholdet af den valgte meddelelse, inklusive modtagere, vedhæftede filer og andre detaljer.

Hvis afsenderen findes i SuperOffice CRM, kan du holde musen over navnet for at vise [personkortet][9].

### Vis inline billeder

Sådan vises inline billeder i forhåndsvisningen:

1. Klik på <i class="ph ph-user-circle" aria-label="Personlige indstillinger"></i> i toplinjen, og vælg **E-mailindstillinger**.
1. Gå til fanen **Generelt**.
1. Markér feltet **Vis inline-billeder**.
1. Klik på **OK** for at anvende indstillingen.

![E-mailindstillinger: Generelt-fanen -screenshot][img2]

### Åbn en vedhæftet fil

Vedhæftede filer vises under e-mailoverskriften, når en meddelelse er valgt.

1. Klik på <i class="ph ph-caret-down" aria-label="Pil ned"></i> ved siden af filnavnet.
1. Vælg **Forhåndsvisning** for at åbne filen direkte i din browser.

    Browserens opførsel kan variere afhængigt af filtype og indstillinger. For eksempel åbnes PDF'er muligvis i en ny fane.

> [!TIP]
> Du kan også vælge **Download** for at gemme filen, eller **Arkiver** for at [gemme den som dokument i SuperOffice CRM][2].

## <a id="mark-as-read"></a>Marker e-mails som læst eller ulæst

E-mails **markeres ikke automatisk som læst**, medmindre du aktiverer denne indstilling.

### Aktivér automatisk markering

1. Gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **E-mailindstillinger** > **Generelt**.
1. Vælg **Marker som læst i forhåndsvisning**.
1. Klik på **OK**.

### Marker meddelelser manuelt

* For at markere en enkelt meddelelse:
    1. Vælg meddelelsen.
    1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Handlingsmenu"></i>, og vælg **Markér som læst/ulæst**.

    ![Handlingsmenu med markér- og flyt-valg -screenshot][img3]

* For at markere flere meddelelser:
    1. **Ctrl+klik** (Windows) eller **Cmd+klik** (Mac) for at vælge meddelelserne.
    1. Brug knapperne **Marker som læst** eller **Marker som ulæst** i højre panel.

    ![Flyt, markér og slet muligheder for flere markerede e-mails -screenshot][img4]

## <a id="move"></a>Flyt e-mail til mappe

Du kan flytte meddelelser til andre mapper i din e-mailkonto.

Mappelisten kommer fra din e-mailudbyder (f.eks. Outlook eller Gmail). Du kan ikke oprette, omdøbe eller slette mapper fra SuperOffice CRM. For at administrere mapper skal du åbne din e-mailkonto direkte.

### Flyt en enkelt e-mail

1. Vælg en meddelelse i indbakken.
1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Handlingsmenu"></i>, og vælg **Flyt til mappe**.
1. Vælg den ønskede mappe.

    > [!CAUTION]
    > Hvis mappenavnet er gråt, er den ikke synkroniseret med din e-mailkonto.
    >
    > For at aktivere den, skal du vælge mappen over meddelelseslisten og klikke på ikonet **Abonner** (<i class="ph ph-cloud-slash" aria-label="Sky"></i>) i nederste højre hjørne. Dette sikrer, at e-mailen flyttes korrekt.

### Flyt flere e-mails

1. Vælg de meddelelser, du vil flytte: **Ctrl+klik** (Windows) eller **Cmd+klik** (Mac).
2. Brug knappen **Flyt til mappe** i højre panel.

## <a id="print"></a>Udskriv en e-mail

1. Vælg en meddelelse i indbakken.
1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Handlingsmenu"></i>, og vælg **Udskriv valgt e-mail**.
1. Meddelelsen åbnes i et forhåndsvisningsvindue i browseren.
1. Brug din browsers **Udskriv**-indstilling til at udskrive meddelelsen.

## Relateret indhold

* [Administrér afsendere][1]
* [Modtag invitationer][3]
* [Opret opgave][4]
* [Opret sag][5]

<!-- Referenced links -->
[1]: manage-senders.md
[2]: archive.md#attachment
[3]: invitations.md
[4]: create-task.md
[5]: create-request.md
[9]: ../../../contact/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-preview-message.png
[img2]: ../../../../media/loc/en/email/email-options-general.png
[img3]: ../../../../media/loc/en/email/inbox-message-task-menu.png
[img4]: ../../../../media/loc/en/email/inbox-multiselect-actions.png
