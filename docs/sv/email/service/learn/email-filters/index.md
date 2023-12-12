---
uid: help-sv-email-filter
title: E-postfilter
description: E-postfilter
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-post
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# E-postfilter

Ett e-postfilter är ett verktyg som används för att analysera innehållet i inkommande e-post och generera ett ärende baserat på detta innehåll.

Du kan också lägga till avancerade regler för behandling av e-post från specifika avsändare. E-postfilter används ofta i samband med webbformulär som företaget har publicerat och som genererar ett e-postmeddelande med fast format som importeras i SuperOffice Service.

## Exempel kopplade till inkommande e-post från webbformulär

Du kan t.ex. definiera fasta uttryck för att extrahera information som en kund har skickat in med formuläret. Information från formuläret läggs in i kunddatabasen baserat på en definierad regeluppsättning. Ärendet som genereras från e-posten/formuläret placeras då i en specifik kategori och en ärendehandläggare väljs. Sedan stängs ärendet och kunden får ett anpassat kvitto baserat på en svarsmall. Det finns alltså många alternativ för automatisk behandling av inkommande e-post.

* E-post som kommer från ett webbformulär har i allmänhet en standardiserad avsändaradress. Du kan ersätta denna adress med kundens egen e-postadress.

* Du kan jämföra kundens telefonnummer med informationen i kunddatabasen och koppla ärendet till rätt ärende baserat på telefonnumret.

* Du kan skriva över adressinformation om adressen ändras.

* Du kan skicka ett kvitto med anpassad information om en kund vill ha mer information om en viss produkt samt tilldela ärendet till rätt underkategori och ärendehandläggare.

## Kolumner i filterlistan

På fliken **E-postfilter** finns en lista med befintliga e-postfilter. I översikten finns följande kolumner:

| Kolumn | Beskrivning |
|---|---|
| Beskrivning | En beskrivning av e-postfiltret. |
| Prioritet | E-postfiltrets prioritet. Endast ett filter aktiveras för varje e-postmeddelande. Om mer än ett filter innehåller sökkriterier som stämmer med ett inkommande e-postmeddelande aktiveras det filter som har högst prioritet. |
| E-postadresser | Adressen/adresserna till den brevlåda filtret tillämpas på. |
| Söksträng | Den söksträng som e-postfiltret använder. |

## Egenskaper för skapade ärenden

* **Ange ägare**: Om du markerar det här alternativet kan du välja vilken användare som ska tilldelas e-postmeddelanden som behandlas av detta filter.

* **Ange kategori**: Om du markerar det här alternativet och väljer en kategori placeras e-postmeddelanden som behandlas av detta filter i den angivna kategorin.

* **Ärendetyp**: Om du kryssar i här och väljer en typ kommer e-post som bearbetas av detta filter att tilldelas den angivna [ärendetypen][3]. (Endast tillgängligt i pilot.)

* **Ange prioritet**: Om du markerar det här alternativet och väljer en prioritet från listrutan får e-postmeddelanden som behandlas av detta filter den angivna prioriteten.

* **Ange åtkomstnivå**: Om du markerar det här alternativet och väljer en åtkomstnivå från listrutan får e-postmeddelanden som behandlas av detta filter den angivna åtkomstnivån. Om du väljer **Externt** är det genererade ärendet tillgängligt i SuperOffice Customer Centre.

* **Konfigurera meddelande**: Om du markerar detta alternativ och väljer en svarsmall konfigureras ärendemeddelandet enligt den valda mallen och kopplas till alla fasta uttryck som hittas. Du kan använda detta om du vill ge en snyggare presentation av ett formulär som skickas via e-post. Det här meddelandet ersätter det ursprungliga e-postmeddelandet.

* **Avsluta ärende**: Om du markerar det här alternativet avslutas ärendet omedelbart och får statusen **Avslutat**.

* **Ignorera avsändaradress**: Om du markerar det här alternativet ignorerar SuperOffice Service den ursprungliga avsändaradressen. Ärendet kan då inte kopplas till en kontakt om inte andra regler i e-postfiltret resulterar i en koppling till en kontakt.

* **Blockera e-post**: Om du markerar det här alternativet importeras inte e-postmeddelandet i SuperOffice Service. I stället läggs det i listan på fliken **Blockerad e-post**.

* **Ta bort e-post permanent**: Om du markerar det här alternativet raderas e-postmeddelandet permanent.

    > [!NOTE]
    > E-postmeddelanden som har raderats permanent kan inte återställas.

* **Vidarebefordra till**: Om du markerar det här alternativet och anger en e-postadress skickas e-postmeddelandet vidare till den angivna adressen.

* **Visa felsökningsinformation i meddelandet**: Om du markerar det här alternativet innehåller meddelandet felsökningsinformation som du kan använda för att kontrollera att e-postfiltret fungerar som det ska.

* **Markera e-post som returnerad**: Om du markerar det här alternativet blir e-post som behandlas av detta filter markerad som returnerad. Det kan vara relevant för e-post som kommer från postmaster, mailer-daemon och liknande.

## Vad vill du göra nu?

* [Skapa e-postfilter][1]
* [Ta bort e-postfilter][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->
