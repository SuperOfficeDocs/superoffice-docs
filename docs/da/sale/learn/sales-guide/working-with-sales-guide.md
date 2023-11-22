---
uid: help-da-working-with-sales-guide
title: Arbejde med salgsguide
description: Arbejde med salgsguide
author: SuperOffice RnD
so.date: 02.16.2023
keywords: salg
so.topic: howto
language: da
---

# Arbejde med salgsguide

Salgsguiden fører dig gennem de forskellige faser af en foruddefineret salgsproces, giver automatisk forslag og skabeloner til dokumenter, der skal oprettes undervejs, og fremhæver opfølgningsaktiviteter, der skal udføres.

Hvis du ikke allerede har gjort det, kan du se, hvordan du opretter en salgsguide her. Du kan bruge SuperOffice Salgsguide eller oprette din egen.

Se denne video for at få mere at vide om, hvor nemt det er at bruge salgsguiden (videoens længde - 1:24):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

## Adfærd, når et salg har en guide

* Første fase i salgsguiden er valgt i feltet **Fase** på hovedkortet **Salg**.

* Opfølgninger og/eller dokumenter for fasen er angivet på detaljekortet **Salgsguide**.

## Salgsprocessen

1. Klik på knappen **Opret** foran opfølgningens/dokumentets navn.

2. I den dialogboks, der åbnes, [opretter du opfølgningen][2] eller [dokumentet][3] på normal vis. Mange af felterne er færdigudfyldte, men du kan ændre oplysningerne eller tilføje flere oplysninger.

3. Når du er færdig med opfølgningen, markerer du **Udført** i den aktuelle dialogboks eller i afkrydsningsfeltet foran opfølgningsnavnet på detaljekortet **Salgsguide**. Dokumenter er som standard markeret som udført.

    > [!TIP]
    > Hvis du vil oprette flere opfølgninger af samme type, skal du højreklikke på aktiviteten og vælge**Opret en til**.

4. Når alle opfølgninger og dokumenter for en fase er udført, skal du gå til næste faste på hovedkortet **Salg**.

    > [!NOTE]
    > Hvis du vil, kan du gå til næste fase uden at oprette eller udføre alle opfølgningerne/dokumenterne i en fase.

5. Gentag fremgangsmåden over for alle opfølgninger/dokumenter i hver fase af salgsguiden.

## Sådan fremmes status

Du kan flytte projektet til næste status på to måder:

**Fra salgsguiden:**

1. Højreklik på knappen for statussen i detaljekortet **Salgsguide**, og vælg **Gå til denne status**.

**Fra fanen Salg:**

1. Klik på **Rediger** på fanen **Salg**.
2. Klik på pilen ved siden af feltet **Fase**.
3. Vælg den ønskede fase fra den liste, der vises. Med undtagelse af statusserne **Solgt** og **Tabt** defineres indstillingerne på listen i Indstillinger og vedligeholdelse.
4. Klik på **Gem**.

## Hvorfor åbnes dialogboksen Salgsguide, når jeg markerer en opfølgning som udført?

I Indstillinger og vedligeholdelse kan du angive, at en opfølgning i en salgsguide skal foreslås automatisk, når den foregående opfølgning markeres som udført. Så åbnes dialogboksen **Salgsguide**, når du markerer den forrige opfølgning som udført.

I dialogboksen **Salgsguide** har du tre muligheder:

* Klik på **Opret** for at oprette den næste opfølgning i salgsguiden. Du kommer direkte til dialogboksen for opfølgningen.

* Klik på **Afbryd**, hvis du ikke ønsker at oprette opfølgningen nu. Dialogboksen **Salgsguide** lukkes, og du skal selv huske at oprette opfølgningen senere.

* Markér **Altid oprette opfølgning? Vis ikke denne dialogboks igen**, hvis du fremover altid vil oprette den foreslåede aktivitet. Så åbnes dialogboksen for opfølgninger automatisk næste gang.

> [!TIP]
> For at nulstille denne indstilling, så dialogboksen **Salgsuide** åbnes, skal du gå til ![ikonet][img1] **Personlige indstillinger** > **Præferencer** > **Salg** og vælge **Ja** for indstillingen **Bekræft oprettelse af foreslået opfølgning**.

## Eksempel

Husk, at dine salgsguider kan konfigureres anderledes i Indstillinger og vedligeholdelse.

### Registrering af et nyt salg og valg af salgstype

Du registrerer et nyt salg og vælger salgstypen **Salg til ny kunde**, som er tilknyttet en salgsguide. Salgsguiden kan f.eks. have følgende faser, opfølgninger og dokumenter:

| Trin | Opfølgninger | Dokumenter |
|---|---|---|
| Første møde | Kundemøde (møde ude) | Mødebekræftelse (e-mail) |
| Tilbud | Tilbudsarbejde (opgave) | Tilbud (brev) |
| Underskrivelse af kontrakt | Aftal kontraktsmøde (telefon ude)<br /> Kontraktsmøde (møde ude) | Underskrevet kontrakt |

### Fasen Første møde

1. Du har aftalt mødetidspunktet, og du vil oprette opfølgningen **Kundemøde** i dagbogen samt invitere deltagere.

    1. I projektguiden klikker du på knappen **Opret** ved siden af opfølgningen **Kundemøde**.
        Dialogboksen **Opfølgning** åbnes med **Møde ude** angivet som type og navnet på salget og firmaet færdigudfyldt.
    2. Udfyld informationer, og [inviter deltagere][1].
    3. Klik på **Gem**.

2. For god ordens skyld vil du sende en e-mail, hvori du bekræfter mødetidspunkt og mødested.

    1. Klik på **Opret** ved siden af **Mødebekræftelse**.
        Dialogboksen **Dokument** åbnes, hvor **E-mail** allerede er valgt som dokumenttype, og navnet på firmaet og salget er færdigudfyldt.
    2. Udfyld yderligere oplysninger i felterne i dialogboksen **Dokument**.
    3. Klik på knappen **Opret** for at oprette og sende e-mailen.

3. Når mødet er gennemført, vil du gerne bekræfte dette i salgsguiden.

    I salgsguiden markerer du afkrydsningsfeltet ved siden af opfølgningen **Kundemøde**.

    > [!TIP]
    > Dette kan også gøres fra aktivitetslisten på eksempelvis skærmbillederne Dagbog og Firma.

### Fasen Tilbud

1. Alle opfølgninger og dokumenter i fasen **Første møde** er udført, og du vil gå videre til næste fase af salgsguiden.

    1. Klik på knappen **Rediger** på hovedkortet **Salg**.
    2. Klik på pilen ved siden af feltet **Fase**, og vælg **Tilbud** på listen.
    3. Klik på **Gem**.
        Opfølgningerne og dokumenterne for den nye fase vises nu på detaljekortet **Salgsguide**.

    > [!TIP]
    > Du kan også højreklikke på knappen **Tilbud** på detaljekortet **Salgsguide** og vælge **Gå til denne fase**.

2. Du vil oprette en opgave i din dagbog, der skal minde dig om, at du skal udarbejde et tilbud.

    1. Klik på **Opret** ved siden af opfølgningen **Tilbudsarbejde**.
        Dialogboksen **Opgave** vises med **Opfølgning** angivet som opgavetype.
    2. Udfyld oplysninger.
    3. Klik på **Gem**.
    4. Når du er færdig med at udarbejde indholdet i tilbuddet, markerer du opfølgningen som **Udført**.

3. Nu vil du oprette tilbuddet til firmaet.

    Klik på **Opret** ved siden af dokumentet **Tilbud**, og [opret dokumentet][3].

### Fasen Underskrivelse af kontrakt

1. Når alle de opfølgninger og dokumenter, du ønsker at bruge i fasen **Tilbud**, er udført, skal du gå til sidste fase i salgsguiden, som er **Underskrivelse af kontrakt**.

    1. Klik på knappen **Rediger** på hovedkortet **Salg**.
    2. Klik på pilen til højre for feltet **Fase**, og vælg **Underskrivelse af kontrakt** på listen.
    3. Klik på **Gem**.
        Opfølgningerne og dokumenterne for denne fase vises på detaljekortet **Salgsguide**.

2. Du vil oprette og udføre den første opfølgning i fasen.

    1. Klik på **Opret** ved siden af samtalen **Aftal kontraktsmøde**, og opret samtalen på normal vis.

    2. Når du har afsluttet samtalen, skal du vælge afkrydsningsfeltet.

    3. I dialogboksen **Salgsguide** har du tre muligheder:

        * Klik på **Opret** for at oprette opfølgningen **Kontraktsmøde**, som er den næste opfølgning i salgsguiden. Du kommer direkte til dialogboksen for opfølgningen.

        * Klik på **Afbryd**, hvis du ikke ønsker at oprette opfølgningen nu. Dialogboksen **Salgsguide** lukkes, og du skal selv huske at oprette opfølgningen senere.

        * Markér **Altid oprette opfølgning? Vis ikke denne dialogboks igen**, hvis du fremover altid vil oprette den foreslåede aktivitet. Så åbnes dialogboksen for opfølgninger automatisk næste gang.

    > [!NOTE]
    > Dialogboksen **Salgsguide** åbnes, fordi **Foreslå denne opfølgning automatisk** er indstillet for opfølgningen **Kontraktmøde** i Indstillinger og vedligeholdelse. Du kan vælge, at denne dialogboks ikke vises, så næste opfølgning foreslås automatisk.

3. Du vil oprette opfølgningen **Kontraktsmøde** fra dialogboksen **Salgsguide**.

    Klik på **Opret** i dialogboksen **Salgsguide**.
    Dialogboksen **Opfølgning** åbnes, hvor du kan oprette mødet på normal vis.

4. Derefter vil du oprette den kontrakt, du skal have med på mødet.

    1. Klik på **Opret** ved siden af dokumentet **Underskrevet kontrakt** for at oprette kontrakten.
    2. Når kontraktmødet er gennemført, og kontrakten er underskrevet, skal du markere opfølgningen **Kontraktmøde** som udført.

Du kan nu ændre fasen til **Solgt**. Når alle ønskede opfølgninger og dokumenter for salget er udført, kan du angive salgsstatus som udført.

> [!TIP]
> Hvis du ønsker, at salget stadig skal være synligt på for eksempel detaljekortet **Aktiviteter** i skærmbilledet Salg og på detaljekortet **Salg** i skærmbilledet Dagbog, skal du ikke markere salget som udført.

## Tilknyttet

* [Opsæt en salgsguide i Indstillinger og vedligeholdelse][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/personal-settings-small.png
