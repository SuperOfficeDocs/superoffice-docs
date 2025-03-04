---
uid: help-da-blocked-email-addresses
title: Blokerede e-mailadresser
description: Lær mere om, hvordan du håndterer afviste mails, i denne vejledning.
keywords: Marketing
author: SuperOffice RnD
date: 12.11.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Administrere returposter

Der er mange grunde til, at e-mail-adresser afvises. Dine kontakter skifter job, en e-mail-adresse blev stavet forkert, og selv midlertidige fejl i kundens infrastruktur er de gængse årsager til, at udsendelser afvises.

De første par gange, du sendte din mail ud, fik du måske et stort antal afviste e-mails tilbage. Det er gode nyheder, for det betyder, at du kan opdatere alle e-mailadresser, der er stavet forkert eller ikke længere er i brug. Ved at opdatere afviste e-mailadresser kan du øge succesraten for dine fremtidige mailudsendelser.

Du kan administrere afviste og blokerede e-mails for individuelle udsendelser såvel som for ALLE udsendelser.

## Hvorfor kommer mine e-mails tilbage?

E-mails kan blive sendt tilbage på grund af fejl i e-mailadressen, spamfiltre, internetproblemer eller fyldte indbakker.

* Midlertidige problemer: leveringsforsinkelser, e-mail-server midlertidigt utilgængelig
* Permanente problemer: forkert adresse, ukendt domæne.

E-mailadresser, der fejler midlertidigt, bliver ikke blokeret og bliver ikke sprunget over i den næste udsendelse.

> [!NOTE]
> For at forhindre fejlstavede eller ugyldige e-mailadresser validerer SuperOffice e-mailadresser, der modtages via Chat og Formularer. Valideringen udføres ved hjælp af DNS-opslag og kontrol af grundlæggende e-mailsyntaks.

Der er to typer afvisninger:

En **hård afvisning** er, når din mail permanent ikke kan leveres, fordi e-mailadressen ikke eksisterer, domænet ikke eksisterer (længere), eller modtagerens e-mailserver har blokeret for leveringen. En opdatering af e-mail-adressen løser problemet.

En **blød afvisning** opstår, når der er et midlertidigt leveringsproblem. Hvis en e-mail bliver afvist, vil SuperOffice CRM forsøge at sende mailen igen, flere gange, for at levere den. Først når e-mailen, efter flere forsøg, ikke kan leveres, vil den blive registreret som en hård afvisning.

Brug filterknapperne (Sendt, Afvist og Åbnet) til at [filtrere din modtagerliste][1]. Når du har udvalgt alle kontakter, hvor mailen blev afvist, kan du samle dem i et udvalg eller et projekt ved hjælp af knappen i handlingsmenuen i nederste venstre hjørne.

![Filtrér dine afviste e-mails, og vælg, hvad du vil gøre med dem -screenshot][img2]

## Sådan retter du en enkelt mailadresse

1. Hvis du vil rette en enkelt e-mail-adresse, skal du markere den på listen og klikke på **Åbn** i sidepanelet for at redigere kontaktpersonen.
2. Gå til fanen **Detaljer**.
3. Et advarselsikon (<i class="ph ph-warning" aria-hidden="true"></i>) ud for e-mailadressen angiver, at der er et problem. Hold musemarkøren over ikonet for at få vist årsagen til problemet.

> [!TIP]
> Klik på en kolonne for at få adgang til sorterings- og grupperingsfunktioner.

## Blokerede e-mailadresser

E-mail-adresser, der er returneret på grund af permanente fejl eller er kommet tilbage flere gange, blokeres automatisk og springes over i fremtidige udsendelser.

> [!NOTE]
> Hvis en e-mail bliver afvist mere end 5 gange, bliver den automatisk blokeret. Du kan justere denne indstilling i de generelle indstillinger, Indstillinger og Administration, under **Antal accepterede afvisninger inden mailadressen deaktiveres**.

Alle blokerede e-mail-adresser fra alle udsendelser arkiveres under fanen **Blokerede mailadresser** .  Denne fane giver et fremragende overblik over e-mailadresser, der skal slettes.

> [!TIP]
> Klik på en kolonne for at få adgang til sorterings- og grupperingsfunktioner.

## Muligheder ved returmail

Hvis du vil håndtere flere e-mailadresser, har du muligheder for det ved hjælp af knappen **Handlinger**.

### Eksporter

1. Vælg de e-mailadresser, du vil eksportere.
2. Vælg **Handlinger** > **Eksporter**.
3. Vælg et eksportformat. Eksportfilen vises nederst i din browser. Den kan også findes i din downloadmappe.

### Tilføj til nyt udvalg

1. Vælg de e-mailadresser, du vil føje til et nyt udvalg.
2. Vælg **Handlinger** > **Føj til nyt udvalg**.
3. Skriv navnet på det nye udvalg, og klik på **OK**. Der oprettes et nyt statisk udvalg med de markerede e-mailadresser.

### Tilføj til nyt projekt

1. Vælg de e-mailadresser, du vil føje til et nyt projekt.
2. Vælg **Handlinger** > **Føj til nyt projekt**.
3. Angiv navnet på det nye projekt, og klik på **OK**. Der oprettes et nyt projekt med de valgte mailadresser.

### Føj til eksisterende udvalg

1. Vælg de e-mailadresser, du vil føje til et eksisterende udvalg.
2. Vælg **Handlinger** > **Føj til eksisterende udvalg**.
3. Begynd at skrive i søgefeltet for at finde det relevante udvalg.
4. Klik på det udvalg, du vil bruge, på listen over resultater.
5. Klik på **OK**. De markerede e-mailadresser føjes til udvalget.

### Føj til eksisterende projekt

1. Vælg de e-mailadresser, du vil føje til et eksisterende projekt.
2. Vælg **Handlinger** > **Føj til eksisterende projekt**.
3. Begynd at skrive i søgefeltet for at finde det relevante projekt.
4. Klik på det projekt, du vil bruge, på listen over resultater.
5. Klik på **OK**. De markerede e-mailadresser føjes til projektet

### Slet valgte e-mailadresser

Brug denne indstilling til permanent at slette e-mail-adresser fra databasen.

1. Vælg de e-mailadresser, du vil slette.
2. Vælg **Handlinger** > **Slet valgte e-mail-adresser**.
3. Klik på **OK** for at bekræfte.

### Fjern markering af returpost

Brug denne indstilling til at fjerne e-mailadresser fra listen, så de kan bruges til udsendelser. Det kan være relevant, hvis returneringerne skyldes forkert konfigurering eller midlertidige tekniske årsager, eller hvis du ved, at e-mailadresserne er korrekte, og gerne vil prøve at sende en gang til.

1. Vælg de e-mailadresser, hvor du vil fjerne markeringer af returpost.
2. Vælg **Handlinger** > **Fjern markering af returpost**.
3. Klik på **OK** for at bekræfte.

### Angiv som fratrådt

Brug denne indstilling til at angive en person som fratrådt medarbejder.

1. Vælg de e-mailadresser, du vil slette.
2. Vælg **Handlinger** > **Angiv som fratrådt**.
3. Klik på **OK** for at bekræfte.

<!-- Referenced links -->
[1]: look-at-recipient-list.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/handle-bounced-emails.png
