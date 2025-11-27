---
uid: help-da-email-service
title: Administration af e-mailkonti
description: Administration af e-mailkonti
author: SuperOffice Product and Engineering
keywords: e-mail-konto, e-mail
date: 07.10.2025
version: 10.5
content_type: concept
category: service
topic: email
functional_right:
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: da
redirect_from:
  - /da/email/service/learn/index
  - /da/email/service/learn/screen/tab-inbox-for-email
  - /da/email/service/learn/screen/tab-outbox-for-email
  - /da/email/service/learn/screen/tab-blocked-email
  - /da/email/service/learn/screen/sms-inbox
  - /da/email/service/learn/screen/sms-outbox
  - /da/email/service/learn/email-filters/index
---

# E-mails om service

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

I skærmbilledet **E-mail** kontrollerer du de mekanismer, som styrer indgående og udgående e-mails. Import af e-mail sker ved, at SuperOffice Service regelmæssigt henter e-mail fra en eller flere e-mail-konti. Disse e-mail-meddelelser kan scannes af e-mail-filtre, der behandler e-mail-meddelelserne alt efter indhold, og generere sager. Udgående e-mails (svar) fra systemet lægges i udbakken og sendes regelmæssigt til en e-mail-server, der videresender e-mail-meddelelserne. Importerede e-mail-meddelelser, der er blevet blokeret (af et filter), vises på fanen **Blokeret e-mail** og skal gennemgås manuelt.

## E-mail-konti

På fanen **E-mail-konti** finder du en oversigt over de installerede e-mail-konti. Denne oversigt indeholder følgende kolonner:

* **Adresse**: E-mail-kontoens afsenderadresse.
* **Kategori**: Sager fra e-mailkontoen vil blive tildelt til denne kategori.
* **Prioritet**: Den prioritet, som nye sager får, når de registreres fra denne e-mail-konto.
* **Videresendelsesadresse**: Hvis du ikke bruger e-mailfunktionerne i SuperOffice, videresendes e-mails til denne adresse.
* **Protokol**: Den protokol, som e-mail-kontoen bruger.

### <a id="email-in"></a>Indbakke til e-mail

På fanen **Indbakke til e-mail** finder du en oversigt over de e-mail-meddelelser, der venter på at blive læst. Følgende indstillinger er også tilgængelige fra knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Bruges til at eksportere listen til en fil. Du kan vælge mellem disse formater: Excel, HTML og almindelig tekst.

* **Slet**: Klik her for at slette de markerede e-mails.

    > [!NOTE]
    > Du kan ikke fortryde denne handling.

Hvis du klikker på en af meddelelserne på denne fane, vises skærmbilledet **Indgående e-mail**. Hér finder du oplysninger om den aktuelle meddelelse. I feltet **Sidste fejlmeddelelse** kan du se, hvad der har forårsaget problemet, f.eks. om der er fejl ved e-mail-adressen eller e-mail-serveren. Hvis du har modtaget en fejl fra SuperOffice Service, kan du klikke på **Importer med fejlsøgning** for at få vist tekniske oplysninger, som kan hjælpe brugersupport i forbindelse med fejlsøgning.

### <a id="email-out"></a>Udbakke til e-mail

På fanen **Udbakke til e-mail** finder du en oversigt over de e-mail-meddelelser, der venter på at blive sendt.

Vælg **Vis sendte e-mails** i nederste højre hjørne for også at få vist de sidste sags-e-mails.

Følgende indstillinger er også tilgængelige fra knappen <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Bruges til at eksportere listen til en fil. Du kan vælge mellem disse formater: Excel, HTML og almindelig tekst.

* **Send**: Bruges kun til at sende de valgte e-mails igen, hvis der opstod en fejl med den automatiske mailing.

* **Slet**: Klik her for at slette de markerede e-mails.

    > [!NOTE]
    > Du kan ikke fortryde denne handling.

Hvis du klikker på en af meddelelserne på denne fane, vises skærmbilledet **Udgående e-mail**. Hér finder du oplysninger om den aktuelle meddelelse, f.eks. størrelse og hvem der har oprettet den. Eventuelle fejlmeddelelser vises også.

### <a id="email-blocked"></a>Blokeret e-mail

På fanen **Blokeret e-mail** finder du en oversigt over indgående e-mail-meddelelser, der er blevet blokeret af et e-mail-filter. Klik på en e-mail-meddelelse for at få vist indholdet. Hvis der ikke er tilstrækkelig plads til alle e-mails på en side, kan du klikke på <i class="ph ph-arrow-right" aria-label="Arrow right"></i> for at navigere til næste side. Denne oversigt indeholder følgende kolonner:

* **Hvornår**: Angiver, hvornår e-mail-meddelelsen blev blokeret.
* **E-mail-konto**: Angiver, hvilken e-mail-konto der importerede e-mail-meddelelsen.
* **E-mail-filter** Angiver, hvilket e-mail-filter der blokerede e-mail-meddelelsen.
* **E-mailens emne**: Viser titlen på meddelelsen.

Følgende indstillinger er også tilgængelige fra <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>:

* **Eksporter**: Bruges til at eksportere listen til en fil. Du kan vælge mellem disse formater: Excel, HTML og almindelig tekst.
* **Import**: Bruges til at importere de valgte e-mails. Det e-mail-filter, der blokerede e-mail-meddelelsen, vil så blive ignoreret, men andre e-mail-filtre vil kunne blive aktiveret.
* **Slet**: Bruges til at slette de blokerede e-mail-meddelelser, der er markeret.

### <a id="sms-in"></a>Indbakke til sms

> [!NOTE]
> Hvis denne fane ikke vises, tyder det på, at du ikke har sms-modulet, eller at sms-modulet ikke er aktiveret for den licens, du bruger. Kontakt den systemansvarlige for at få flere oplysninger.

På fanen **Indbakke til sms** finder du en oversigt over de sms-meddelelser, der venter på at blive læst. Følgende alternativer er også tilgængelige fra menuknappen:

* **Eksporter**: Bruges til at eksportere listen til en fil. Du kan vælge mellem disse formater: Excel, HTML og almindelig tekst.

* **Slet**: Klik her for at slette de markerede meddelelser.

    > [!NOTE]
    > Du kan ikke fortryde denne handling.

Klik på en af meddelelserne under denne fane for at få vist oplysninger om den valgte meddelelse.

### <a id="sms-out"></a>Udbakke til sms

Fanen **Udbakke til sms** indeholder alle udgående sms'er, der endnu ikke er blevet sendt, eller som har forårsaget fejl.

> [!NOTE]
> Hvis denne fane ikke vises, tyder det på, at du ikke har sms-modulet, eller at sms-modulet ikke er aktiveret for den licens, du bruger. Kontakt den systemansvarlige for at få flere oplysninger.

Følgende alternativer er også tilgængelige fra menuknappen:

* **Eksporter**: Bruges til at eksportere listen til en fil. Du kan vælge mellem disse formater: Excel, HTML og almindelig tekst.

* **Send**: Bruges kun til at sende de valgte meddelelser igen, hvis der opstod en fejl med den automatiske mailing.

* **Slet**: Klik her for at slette de markerede meddelelser.

    > [!NOTE]
    > Du kan ikke fortryde denne handling.

Hvis du klikker på en af meddelelserne på denne fane, vises skærmbilledet **Udgående sms**. Hér finder du oplysninger om den aktuelle meddelelse, f.eks. størrelse og hvem der har oprettet den. Eventuelle fejlmeddelelser vises også.

## <a id="filter"></a>E-mailfiltre

Et e-mail-filter er et værktøj, der bruges til at analysere indholdet af indgående e-mails og generere en sag baseret på dette indhold.

Du kan også tilføje avancerede regler for håndtering af e-mail fra bestemte afsendere. E-mail-filtre anvendes ofte i forbindelse med webformularer, som virksomheden har udgivet, og som genererer en fast formateret e-mail-meddelelse, der importeres i SuperOffice Service.

### Eksempel relateret til indgående mail fra webformularer

Du kan f.eks. definere faste udtryk, der skal trække oplysninger ud, som en kunde har indsendt via formularen. På baggrund af et defineret regelsæt tilføjes oplysninger fra formularen på kunden i databasen. Sagen, der er genereret fra e-mailen/formularen, placeres derefter i en bestemt kategori, og der vælges en sagsbehandler. Derefter lukkes sagen, og kunden modtager en tilpasset kvittering baseret på en svarskabelon. Med andre ord er der mange muligheder for automatisk håndtering af indgående e-mails.

* E-mails, der modtages fra en webformular, har som regel én standardafsenderadresse. Du kan erstatte denne adresse med kundens egen e-mail-adresse.
* Du kan sammenligne kundens telefonnummer med oplysninger i kundedatabasen og koble sagen til den rigtige kunde baseret på dette.
* Du kan overskrive adresseoplysninger ved adresseændringer.
* Du kan sende en kvittering med skræddersyede oplysninger, hvis en kunde ønsker flere oplysninger om et bestemt produkt, samt fordele til den rigtige underkategori og sagsbehandler.

### Kolonner på listen over filtre

På fanen **E-mail-filter** finder du en oversigt over eksisterende e-mail-filtre. Denne oversigt indeholder følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Beskrivelse | En beskrivelse af e-mail-filteret. |
| Prioritet | E-mail-filterets prioritet. Der aktiveres kun et filter pr. e-mail-meddelelse. Hvis mere end ét filter har søgekriterier, der stemmer overens med en indgående e-mail-meddelelse, er det filteret med den højeste prioritet, der aktiveres. |
| E-mailadresser | Adresserne på den e-mail-konto, som filteret gælder for. |
| Søgestreng | Den søgestreng, som e-mail-filteret bruger. |

## Relateret indhold

* [Oprettelse af e-mailkonti][1]
* [Sletning af e-mail-konti][2]
* [E-mail-filtre][3]

<!-- Referenced links -->
[1]: create-mailbox.md
[2]: delete-mailbox.md
[3]: email-filters/create-email-filter.md

<!-- Referenced images -->
