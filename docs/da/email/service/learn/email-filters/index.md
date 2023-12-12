---
uid: help-da-email-filter
title: E-mailfiltre
description: E-mailfiltre
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-mail
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# E-mailfiltre

Et e-mail-filter er et værktøj, der bruges til at analysere indholdet af indgående e-mails og generere en sag baseret på dette indhold.

Du kan også tilføje avancerede regler for håndtering af e-mail fra bestemte afsendere. E-mail-filtre anvendes ofte i forbindelse med webformularer, som virksomheden har udgivet, og som genererer en fast formateret e-mail-meddelelse, der importeres i SuperOffice Service.

## Eksempel relateret til indgående mail fra webformularer

Du kan f.eks. definere faste udtryk, der skal trække oplysninger ud, som en kunde har indsendt via formularen. På baggrund af et defineret regelsæt tilføjes oplysninger fra formularen på kunden i databasen. Sagen, der er genereret fra e-mailen/formularen, placeres derefter i en bestemt kategori, og der vælges en sagsbehandler. Derefter lukkes sagen, og kunden modtager en tilpasset kvittering baseret på en svarskabelon. Med andre ord er der mange muligheder for automatisk håndtering af indgående e-mails.

* E-mails, der modtages fra en webformular, har som regel én standardafsenderadresse. Du kan erstatte denne adresse med kundens egen e-mail-adresse.

* Du kan sammenligne kundens telefonnummer med oplysninger i kundedatabasen og koble sagen til den rigtige kunde baseret på dette.

* Du kan overskrive adresseoplysninger ved adresseændringer.

* Du kan sende en kvittering med skræddersyede oplysninger, hvis en kunde ønsker flere oplysninger om et bestemt produkt, samt fordele til den rigtige underkategori og sagsbehandler.

## Kolonner på listen over filtre

På fanen **E-mail-filter** finder du en oversigt over eksisterende e-mail-filtre. Denne oversigt indeholder følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Beskrivelse | En beskrivelse af e-mail-filteret. |
| Prioritet | E-mail-filterets prioritet. Der aktiveres kun et filter pr. e-mail-meddelelse. Hvis mere end ét filter har søgekriterier, der stemmer overens med en indgående e-mail-meddelelse, er det filteret med den højeste prioritet, der aktiveres. |
| E-mailadresser | Adresserne på den e-mail-konto, som filteret gælder for. |
| Søgestreng | Den søgestreng, som e-mail-filteret bruger. |

## Egenskaber for genererede sager

* **Angiv sagsbehandler**: Hvis du markerer denne valgmulighed, kan du vælge, hvilken bruger der skal tildeles e-mails behandlet af dette filter.

* **Angiv kategori**: Hvis du markerer denne valgmulighed og vælger en kategori, vil e-mails, der håndteres af dette filter, havne i den angivne kategori.

* **Sagstype**: Hvis du markerer her og vælger en type, vil e-mails, der behandles af dette filter, blive tildelt den angivne [sagstype][3]. (Kun tilgængelig i pilot.)

* **Angiv prioritet**: Hvis du markerer denne valgmulighed og vælger en prioritet på rullemenuen, vil e-mails, der håndteres af dette filter, få den angivne prioritet.

* **Angiv adgangsniveau**: Hvis du markerer denne valgmulighed og vælger et adgangsniveau i rullemenuen, vil e-mails, der håndteres af dette filter, få det angivne adgangsniveau. Hvis du vælger **Ekstern**, vil den registrerede sag være tilgængelig i SuperOffice Customer Centre.

* **Opsæt meddelelse**: Hvis du markerer denne valgmulighed og vælger en svarskabelon, vil sagsmeddelelsen blive sat op i henhold til den valgte skabelon, flettet med alle de faste udtryk, som blev fundet. Dette kan f.eks. anvendes til at præsentere en formular, der er sendt via e-mail, på en mere overskuelig måde. Denne meddelelse erstatter den oprindelige e-mail.

* **Afslut sagen**: Hvis du markerer denne valgmulighed, lukkes sagen med det samme, så den får statussen **Afsluttet**.

* **Ignorer afsenderadresse**: Hvis du markerer denne valgmulighed, ignorerer SuperOffice Service den oprindelige afsender. Sagen bliver således ikke knyttet til en person, hvis ikke andre regler i e-mail-filteret resulterer i tilknytning til person.

* **Bloker e-mail**: Hvis du markerer denne valgmulighed, importeres e-mail-meddelelsen ikke til SuperOffice Service. I stedet tilføjes den på listen på fanen **Blokeret e-mail**.

* **Slet e-mail permanent**: Hvis afkrydsningsfeltet er markeret, slettes e-mailen permanent.

    > [!NOTE]
    > Det er ikke muligt at genoprette e-mail-meddelelser, som er blevet slettet permanent.

* **Videresend til**: Hvis du markerer denne valgmulighed og indtaster en e-mail-adresse, videresendes e-mail-meddelelsen til den angivne adresse.

* **Vis fejlfindingsoplysninger i meddelelsen**: Hvis du markerer denne valgmulighed, vil meddelelsen indeholde fejlfindingsoplysninger, som du kan anvende til at kontrollere, at e-mail-filteret fungerer, som det skal.

* **Marker e-mail som returpost**: Hvis du markerer denne valgmulighed, vil e-mails, der håndteres af dette filter, blive markeret som returpost. Det kan være relevant for e-mails modtaget fra postmaster, mailer-daemon osv.

## Hvad vil du foretage dig nu?

* [Oprettelse af e-mail-filtre][1]
* [Slet e-mail-filtre][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->
