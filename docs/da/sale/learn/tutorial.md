---
uid: help-da-working-with-sales-guide
title: Eksempel – salgsguide
description: Lær, hvordan du arbejder med en salgsguide i SuperOffice CRM.
keywords: salgsguide, eksempel
author: SuperOffice RnD
date: 01.07.2025
version: 10.5
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Eksempel – salgsguide

Husk, at dine salgsguider kan være konfigureret forskelligt i Indstillinger og vedligeholdelse.

## Registrer et nyt salg og vælg en salgstype

Du registrerer et nyt salg og vælger salgstypen **Salg til ny kunde**, som er knyttet til en salgsguide. Salgsguiden indeholder følgende faser, opfølgninger og dokumenter:

| Fase | Opfølgninger | Dokumenter |
|---|---|---|
| Første møde | Kundemøde (Møde ude) | Mødebekræftelse (E-mail) |
| Tilbud | Tilbudsarbejde (Opgave) | Tilbud (Brev) |
| Underskrivelse af kontrakt | Aftal kontraktsmøde (Telefon ude)<br /> Kontraktsmøde (Møde ude) | Underskrevet kontrakt |

## Fasen Første møde

1. Du har aftalt et mødetidspunkt og vil oprette opfølgningen **Kundemøde** i dagbogen og invitere deltagere.

    1. I salgsguiden klikker du på **Opret** ved siden af opfølgningen **Kundemøde**.
        Dialogboksen **Opfølgning** åbnes, med **Møde ude** angivet som type, og navnet på salget og firmaet er udfyldt på forhånd.
    2. Udfyld informationen, og [inviter deltagere][1].
    3. Klik på **Gem**.

2. For god ordens skyld vil du sende en e-mail, der bekræfter mødetidspunkt og sted.

    1. Klik på **Opret** ved siden af **Mødebekræftelse**.
        Dialogboksen **Dokument** åbnes med **E-mail** allerede valgt som dokumenttype, og navnet på firmaet og salget er udfyldt på forhånd.
    2. Udfyld de resterende felter i dialogboksen **Dokument**.
    3. Klik på **Opret** for at sende e-mailen.

3. Efter mødet vil du bekræfte det i salgsguiden.

    I salgsguiden markerer du afkrydsningsfeltet ved siden af opfølgningen **Kundemøde**.

    > [!TIP]
    > Du kan også gøre dette fra aktivitetslisten i for eksempel Dagbog eller Firma-skærmbilledet.

## Fasen Tilbud

1. Alle opfølgninger og dokumenter i fasen **Første møde** er fuldført, og du vil gå videre til næste fase i salgsguiden.

    1. Klik på <i class="ph ph-pencil-simple" aria-label="Rediger"></i> på hovedkortet **Salg**.
    2. Klik på pilen ved siden af feltet **Fase**, og vælg **Tilbud** fra listen.
    3. Klik på **Gem**.
        Opfølgningerne og dokumenterne for denne nye fase vises nu på detaljekortet **Salgsguide**.

    > [!TIP]
    > Du kan også højreklikke på knappen **Tilbud** i detaljekortet **Salgsguide** og vælge **Gå til denne fase**.

2. Du vil oprette en opgave i din dagbog, der skal minde dig om at forberede et tilbud.

    1. Klik på **Opret** ved siden af opfølgningen **Tilbudsarbejde**.
        Dialogboksen **Opgave** åbnes, med **Opfølgning** angivet som opgavetype.
    2. Udfyld informationen.
    3. Klik på **Gem**.
    4. Når du har udarbejdet tilbuddet, markerer du aktiviteten som **Udført**.

3. Du vil nu oprette tilbuddet til firmaet.

    Klik på **Opret** ved siden af dokumentet **Tilbud**, og [opret dokumentet][3].

## Fasen Underskrivelse af kontrakt

1. Når alle opfølgninger og dokumenter i fasen **Tilbud** er udført, skal du gå til den sidste fase i salgsguiden, som er **Underskrivelse af kontrakt**.

    1. Klik på <i class="ph ph-pencil-simple" aria-label="Rediger"></i> på hovedkortet **Salg**.
    2. Klik på pilen til højre for feltet **Fase**, og vælg **Underskrivelse af kontrakt** fra listen.
    3. Klik på **Gem**.
        Opfølgningerne og dokumenterne for denne fase vises nu i detaljekortet **Salgsguide**.

2. Du vil oprette og gennemføre den første opfølgning i denne fase.

    1. Klik på **Opret** ved siden af opfølgningen **Aftal kontraktsmøde**, og opret telefonopkaldet på normal vis.

    2. Når opkaldet er afsluttet, markerer du afkrydsningsfeltet.

    3. I dialogboksen **Salgsguide** har du tre muligheder:

        * Klik på **Opret** for at oprette opfølgningen **Kontraktsmøde**, som er den næste opfølgning i salgsguiden. Dette fører dig direkte til opfølgningsdialogen.

        * Klik på **Afbryd**, hvis du ikke vil oprette opfølgningen nu. Dialogboksen **Salgsguide** lukkes, og du skal huske at oprette opfølgningen senere.

        * Markér **Altid oprette opfølgning? Vis ikke denne dialogboks igen**, hvis du fremover altid vil oprette den foreslåede opfølgning. Dialogen for opfølgninger åbnes da automatisk næste gang.

    > [!NOTE]
    > Dialogboksen **Salgsguide** åbnes, fordi **Foreslå denne opfølgning automatisk** er aktiveret for opfølgningen **Kontraktsmøde** i Indstillinger og vedligeholdelse. Du kan vælge ikke at få vist denne dialogboks, så næste opfølgning foreslås automatisk.

3. Du vil oprette opfølgningen **Kontraktsmøde** fra dialogboksen **Salgsguide**.

    Klik på **Opret** i dialogboksen **Salgsguide**.
    Dialogboksen **Opfølgning** åbnes, hvor du kan oprette mødet på normal vis.

4. Derefter vil du oprette kontrakten, der skal bruges til mødet.

    1. Klik på **Opret** ved siden af dokumentet **Underskrevet kontrakt** for at oprette kontrakten.
    2. Når kontraktmødet er afsluttet, og kontrakten er underskrevet, markerer du opfølgningen **Kontraktsmøde** som udført.

Du kan nu ændre fasen til **Solgt**. Når alle ønskede opfølgninger og dokumenter for salget er udført, kan du angive salgsstatus som fuldført.

> [!TIP]
> Hvis du ønsker, at salget stadig skal være synligt i for eksempel detaljekortet **Aktiviteter** i skærmbilledet Salg og detaljekortet **Salg** i skærmbilledet Dagbog, skal du ikke markere salget som fuldført.

## Relateret indhold

* [Opsæt en salgsguide i Indstillinger og vedligeholdelse][4]

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[3]: ../../document/learn/edit.md
[4]: ../admin/create-sales-guide.md
