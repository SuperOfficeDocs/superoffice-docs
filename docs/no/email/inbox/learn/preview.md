---
uid: help-no-email-inbox-preview
title: Vise e-postmeldinger
description: Hvordan forhåndsvise, flytte, merke og skrive ut e-postmeldinger i SuperOffice-innboksen
keywords: åpne e-post, vise e-post, forhåndsvisning, flytte e-post, merk som lest, skriv ut, e-post, e-postklient, SuperOffice-innboks
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/email/inbox/learn/mark-as-read
  - /no/email/inbox/learn/move-email-to-folder
  - /no/email/inbox/learn/print
---

# Vise e-postmeldinger

Når du merker en e-post i innboksen, vises en forhåndsvisning av meldingen i høyre del av skjermbildet. Dobbeltklikk på meldingen for å åpne den i et eget vindu.

![Forhåndsvisning av e-post med valgt melding og tilgjengelige handlinger -screenshot][img1]

## Forhåndsvisningsrute

Forhåndsvisningen viser innholdet i den valgte meldingen, inkludert mottakere, vedlegg og andre detaljer.

Hvis avsenderen finnes i SuperOffice CRM, kan du holde musepekeren over navnet for å vise [personkortet][9].

### Vise innebygde bilder

Slik viser du innebygde bilder i forhåndsvisningen:

1. Klikk på <i class="ph ph-user-circle" aria-label="Personal settings"></i> øverst og velg **E-postalternativer**.
1. Gå til fanen **Generelt**.
1. Merk av for **Vis innebygde bilder**.
1. Klikk på **OK** for å lagre innstillingen.

![E-postalternativer: fanen Generelt -screenshot][img2]

### Åpne et vedlegg

Vedlegg vises under e-posthodet når en melding er valgt.

1. Klikk på <i class="ph ph-caret-down" aria-label="Chevron"></i> ved siden av vedleggsnavnet.
1. Velg **Forhåndsvisning** for å åpne filen direkte i nettleseren.

    Hvordan forhåndsvisningen fungerer, avhenger av filtype og nettleserinnstillinger. PDF-filer kan for eksempel åpnes i en ny fane.

> [!TIP]
> Du kan også velge **Last ned** for å lagre filen, eller **Arkiver** for å [lagre den som et dokument i SuperOffice CRM][2].

## <a id="mark-as-read"></a>Merke e-post som lest eller ulest

E-postmeldinger blir **ikke automatisk merket som lest** med mindre du aktiverer denne innstillingen.

### Aktiver automatisk merking

1. Gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **E-postalternativer** > **Generelt**.
1. Velg **Merk som lest i forhåndsvisning**.
1. Klikk på **OK**.

### Merke meldinger manuelt

* For å merke én melding:
    1. Merk meldingen.
    1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og velg **Merk som lest/ulest**.

    ![Oppgaveliste med alternativ for merk og flytt -screenshot][img3]

* For å merke flere meldinger:
    1. **Ctrl+klikk** (Windows) eller **Cmd+klikk** (Mac) for å velge meldingene du vil oppdatere.
    1. Bruk knappene **Merk som lest** eller **Merk som ulest** i meldingsruten.

    ![Alternativer for flytt, merk og slett for flere valgte meldinger -screenshot][img4]

## <a id="move"></a>Flytte e-post til mappe

Du kan flytte meldinger til andre mapper i e-postkontoen din.

Mappelisten kommer fra e-postleverandøren din (for eksempel Outlook eller Gmail). Du kan ikke opprette, gi nytt navn til eller slette mapper i SuperOffice CRM. For å administrere mapper må du åpne e-postkontoen din direkte.

### Flytte én e-postmelding

1. Merk en melding i innboksen.
1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og velg **Flytt til mappe**.
1. Velg ønsket mappe.

    > [!CAUTION]
    > Hvis mappenavnet er nedtonet, er den ikke synkronisert med e-postkontoen din.
    >
    > For å aktivere den, velg mappen over meldingslisten og klikk på ikonet **Abonner** (<i class="ph ph-cloud-slash" aria-label="Cloud"></i>) nederst til høyre. Dette sikrer at meldingen blir flyttet riktig.

### Flytte flere e-postmeldinger

1. Velg meldingene du vil flytte: **Ctrl+klikk** (Windows) eller **Cmd+klikk** (Mac) for å velge flere meldinger.
2. Bruk knappen **Flytt til mappe** i meldingsruten.

## <a id="print"></a>Skrive ut en e-post

1. Merk en melding i innboksen.
1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og velg **Skriv ut valgt e-post**.
1. Meldingen åpnes i et forhåndsvisningsvindu i nettleseren.
1. Bruk nettleserens utskriftsalternativ for å skrive ut meldingen.

## Relatert innhold

* [Administrere avsendere][1]
* [Motta invitasjoner][3]
* [Opprett oppgave][4]
* [Opprett sak][5]

<!-- Refererte lenker -->
[1]: manage-senders.md
[2]: archive.md#attachment
[3]: invitations.md
[4]: create-task.md
[5]: create-request.md
[9]: ../../../contact/learn/index.md

<!-- Refererte bilder -->
[img1]: ../../../../media/loc/en/email/inbox-preview-message.png
[img2]: ../../../../media/loc/en/email/email-options-general.png
[img3]: ../../../../media/loc/en/email/inbox-message-task-menu.png
[img4]: ../../../../media/loc/en/email/inbox-multiselect-actions.png
