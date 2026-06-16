---
uid: help-no-webhook-create
title: Oprett webhook
description: Opprett en webhook i Innstillinger og vedlikehold uten å skrive kode eller kalle API-et.
keywords: oprett webhook, rediger webhook, varsling, hendelse
author: digitaldiina
date: 06.16.2026
version: 12.1
content_type: howto
tier: core
category: automation
topic: webhook
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
---

# Oprett webhook

Du kan opprette og administrere webhook-abonnementer direkte i **Innstillinger og vedlikehold**, uten å skrive kode eller kalle APIet.

> [!NOTE]
> For å redigere en eksisterende webhook, høyreklikk på webhook-raden i listen **Webhooker** og velg **Rediger**. Skjemaet åpnes med alle gjeldende verdier forhåndsutfylt.

## Trinn

1. Gå til **Innstillinger og vedlikehold** > **System design** og velg fanen **Webhooker**.

1. Klikk **Legg til**.

    ![Nytt webhook-skjema i Innstillinger og vedlikehold -screenshot][img1]

1. Skriv inn et **Navn** for å identifisere webhooken (obligatorisk). Maksimalt 100 tegn.

1. Du kan eventuelt legge til en **Beskrivelse**. Den vises i Webhooker-panelet.

1. **Hendelser som utløser denne webhooken** (obligatorisk).

    Velg én eller flere hendelser fra listen **Legg til operasjon**. Hver valgt hendelse vises som en tag. For å fjerne en hendelse, velg **x** på taggen.

    > [!TIP]
    > Du kan også skrive inn et egendefinert hendelsesnavn direkte i feltet og trykke **Enter**.

1. **Angi destinasjonen** (obligatorisk).

    Velg hvor webhooken skal leveres:

    * **Ekstern URL:** Skriv inn **Endepunkt-URL**en. URLen må bruke HTTPS og ha et gyldig TLS-sertifikat. Endepunktet valideres når du lagrer — en utilgjengelig eller feilende URL vil forhindre lagring. Velg **Testsending** for å verifisere tilkoblingen før lagring.
    * **CRMScript:** Velg et skript fra listen.

1. **Varsel om feil** (obligatorisk).

    Angi hvem som skal varsles, hvordan de skal nås og når varslingen skal sendes.

    * **Recipients:** Legg til CRM-brukere eller skriv inn eksterne e-postadresser. Mottakere vises som tags.
    * **Varsle via:** Velg varslingskanalen.
    * **Utløs varsel:** Velg ett eller begge alternativer:
      * **Ved første feil:** Sender et varsel første gang webhooken ikke klarer å levere.
      * **Når funksjonen er deaktivert:** Sender et varsel hvis webhooken automatisk deaktiveres etter gjentatte feil.

    ![Webhook-skjema med hendelser, destinasjon og feilvarsel konfigurert -screenshot][img2]

1. (Valgfritt) Utvid **Sikkerhet og avanserte innstillinger**.

    * **Felles hemmelig nøkkel:** Velg **Generer** for å opprette en kryptografisk tilfeldig verdi for signering av hvert nyttelast. Hemmeligheten vises bare ved opprettelse — kopier den umiddelbart. For å erstatte den senere velger du **Regenerer**.
    * **Egendefinerte overskrifter:** Nøkkel-verdi-par som legges til i hvert HTTP POST-kall. Tilgjengelig kun for Ekstern URL-webhooks.
    * **Egendefinerte egenskaper:** Ekstra data injisert i hvert nyttelast.

    ![Sikkerhet og avanserte innstillinger utvidet -screenshot][img3]

1. (Valgfritt) Slå av **Aktiv**-bryteren (øverst til høyre) for å lagre webhooken i tilstanden *Stoppet*.

1. Klikk **Lagre**.

    ![Leveringsstatus vist under Aktiv-bryteren etter lagring -screenshot][img4]

Etter lagring vises leveringsstatusinformasjon under **Aktiv**-bryteren. Klikk **Tilbake til webhooker** øverst for å gå tilbake til listen.

## Relatert innhold

* [Webhooker][1]
* [Registrer en webhook via APIet][2]
* [Oprett et CRMScript][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png
