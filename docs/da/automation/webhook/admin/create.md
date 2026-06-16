---
uid: help-da-webhook-create
title: Opret webhook
description: Opret et webhook i Indstillinger og vedligeholdelse uden at skrive kode eller kalde API'en.
keywords: opret webhook, rediger webhook, notifikation, hændelse
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
language: da
---

# Opret webhook

Du kan oprette og administrere webhook-abonnementer direkte i **Indstillinger og vedligeholdelse**, uden at skrive kode eller kalde API'en.

> [!NOTE]
> For at redigere en eksisterende webhook, højreklik på webhook-rækken i listen **Webhooks** og vælg **Rediger**. Formularen åbnes med alle aktuelle værdier udfyldt.

## Trin

1. Gå til **Indstillinger og vedligeholdelse** > **System design** og vælg fanen **Webhooks**.

1. Klik på **Tilføj**.

    ![Nyt webhook-formular i Indstillinger og vedligeholdelse -screenshot][img1]

1. Angiv et **Webhook-navn** for at identificere webhook'en (obligatorisk). Maksimalt 100 tegn.

1. Du kan eventuelt tilføje en **Beskrivelse**. Den vises i Webhooks-panelet.

1. **Begivenheder, der udløser dette webhook** (obligatorisk).

    Vælg én eller flere hændelser på listen **Tilføj handling**. Hver valgt hændelse vises som et tag. For at fjerne en hændelse skal du vælge **x** på tagget.

    > [!TIP]
    > Du kan også skrive et brugerdefineret hændelsesnavn direkte i feltet og trykke **Enter**.

1. **Angiv destinationen** (obligatorisk).

    Vælg, hvor webhook'en skal leveres:

    * **Ekstern URL:** Angiv **Slutpunktets URL**. URL'en skal bruge HTTPS og have et gyldigt TLS-certifikat. Endepunktet valideres, når du gemmer — en utilgængelig eller fejlgivende URL forhindrer lagring. Vælg **Send test** for at kontrollere forbindelsen inden lagring.
    * **CRMScript:** Vælg et skript fra listen.

1. **Fejlmeddelelse** (obligatorisk).

    Angiv, hvem der skal adviseres, hvordan de nås, og hvornår beskeden skal sendes.

    * **Modtagere:** Tilføj CRM-brugere, eller skriv eksterne e-mailadresser. Modtagerne vises som tags.
    * **Giv besked via:** Vælg beskedkanalen.
    * **Udløs besked:** Vælg én eller begge indstillinger:
      * **Ved første fejl:** Sender en besked første gang webhook'en mislykkes med at levere.
      * **Når funktionen er deaktiveret:** Sender en besked, hvis webhook'en automatisk deaktiveres efter gentagne fejl.

    ![Webhook-formular med hændelser, destination og fejlbesked konfigureret -screenshot][img2]

1. (Valgfrit) Udvid **Sikkerhed og avancerede indstillinger**.

    * **Delt hemmelighed:** Vælg **Generer** for at oprette en kryptografisk tilfældig værdi til signering af hvert payload. Hemmeligheden vises kun ved oprettelse — kopier den straks. For at erstatte den senere skal du vælge **Regenerer**.
    * **Tilpassede overskrifter:** Nøgle-værdi-par, der tilføjes til hvert HTTP POST-kald. Kun tilgængelig for Ekstern URL-webhooks.
    * **Tilpassede egenskaber:** Ekstra data, der injiceres i hvert payload.

    ![Sektionen Sikkerhed og avancerede indstillinger udvidet -screenshot][img3]

1. (Valgfrit) Slå **Aktiv**-knappen fra (øverst til højre) for at gemme webhook'en i tilstanden *Stoppet*.

1. Klik på **Gem**.

    ![Leveringsstatus vist under Aktiv-knappen efter lagring -screenshot][img4]

Efter lagring vises leveringsstatusoplysninger under **Aktiv**-knappen. Klik på **Tilbage til Webhooks** øverst for at gå tilbage til listen.

## Relateret indhold

* [Webhooks-panel][1]
* [Registrer et webhook via API'en][2]
* [Opret et CRMScript][3]

<!-- Referenced links -->
[1]: index.md
[2]: ../dev/register.md
[3]: ../../../customization/macros-and-scripts/admin/create-script.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/automation/new-webhook-required-fields.png
[img2]: ../../../../media/loc/en/automation/create-webhook-in-ui.png
[img3]: ../../../../media/loc/en/automation/webhook-advanced-settings.png
[img4]: ../../../../media/loc/en/automation/webhook-delivery-status.png
