---
uid: help-sv-recurrence
title: Återkommande händelser
description: Återkommande händelser
author: Bergfrid Dias
so.date: 10.09.2023
keywords: kalender, händelse, upprepa, återkomma, förekomst
so.topic: concept
language: sv
---

# Upprepa händelser

Det kan hända att du vill skapa en serie bokningar som återkommer med jämna mellanrum, till exempel ett veckomöte för statusuppdatering. Istället för att lägga in dessa möten ett i taget kan du använda funktionen för återkommande händelser.

## <a id="frequency" />Förekomst

**Förekomst** beskriver hur händelsen upprepas. Mönstret kan vara dagligen, veckovis, månadsvis, årligen eller upprepning med ett användardefinierat intervall. Vilka alternativ som är tillgängliga för varje förekomst varierar.

### Daglig

Om du väljer **Daglig** kan du ange att händelsen ska upprepas varje arbetsdag, varje dag i veckan eller med ett användardefinierat intervall, till exempel varannan dag.

| Alternativ | Beskrivning | Exempel |
|---|---|---|
| Alla vardagar (mån–fre) | Händelsen upprepas vid samma tidpunkt varje arbetsdag. | |
| Alla veckodagar (mån–sön) | Händelsen upprepas vid samma tidpunkt varje dag i veckan, inklusive helgen. | |
| Var &lt;number&gt; dag | Antalet dagar mellan varje möte. | Var 6:e dag. |

### Veckovis

Om du väljer **Veckovis** kan du ange att händelsen ska upprepas med ett användardefinierat veckointervall, till exempel var tredje vecka, och på vilken veckodag den ska äga rum.

| Alternativ | Beskrivning | Exempel |
|---|---|---|
| Var &lt;number&gt; vecka | Antalet veckor mellan varje möte. | Var 3:e vecka. |
| &lt;weekday&gt; | Vilken eller vilka veckodagar mötet ska äga rum. | Varje tisdag. |

### Månatlig

Om du väljer **Månatlig** kan du ange vilken dag i månaden händelsen ska upprepas, till exempel den 5:e i månaden, och ett användardefinierat månadsintervall, till exempel var 4:e månad. Du kan också ange att händelsen ska upprepas, till exempel den fjärde onsdagen i månaden.

| Alternativ | Beskrivning | Exempel |
|---|---|---|
| Dag &lt;number&gt; i varje &lt;number&gt; månad(er) | Händelsen inträffar på samma datum varje gång. | Dag 20 var 3:e månad. |
| &lt;ordinal number&gt; &lt;weekday&gt; var &lt;ordinal number&gt; månad| Händelsen inträffar på samma veckodag varje gång. | Den fjärde torsdagen varannan månad. |

### Årlig

Om du väljer **Årlig** kan du ange vilken dag och månad händelsen ska upprepas varje år, till exempel den 23 september varje år.

| Alternativ | Beskrivning | Exempel |
|---|---|---|
| Dag &lt;number&gt; i &lt;month&gt; | Händelsen inträffar på samma datum varje gång. | Dag 13 i april. |
| &lt;ordinal number&gt; &lt;weekday&gt; i &lt;month&gt; | Händelsen inträffar på samma veckodag varje gång. | Den fjärde torsdagen i augusti. |

## Relaterat innehåll

* [Skapa en återkommande händelse][4]
* [Redigera en återkommande händelse][1]
* [Stoppa en återkommande händelse][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[3]: stop.md
[4]: create.md

<!-- Referenced images -->
