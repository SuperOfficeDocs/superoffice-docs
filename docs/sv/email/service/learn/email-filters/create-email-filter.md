---
uid: help-sv-email-filter-create
title: Skapa e-postfilter
description: Skapa e-postfilter
keywords: e-post, e-postfilter, filter
author: SuperOffice RnD
date: 02.25.2025
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Skapa e-postfilter

1. [!include[Go to email](../includes/goto-email.md)]

1. Välj fliken **E-postfilter**.

1. Klicka på **Nytt e-postfilter**. Fönstret **Egenskaper för e-postfilter** visas.

1. På fliken **Filter** kan du ange vilka e-postmeddelanden som ska filtreras genom att ange följande information:

    * **Beskrivning**: Skriv in en kort beskrivning av e-postfiltret.
    * **Prioritet**: I denna listruta väljer du filtrets prioritet. 100 är högsta prioritet och 1 är lägsta.
    * **Skript**: Här kan du välja ett [skript eller makro][1] som filtret ska köra.

1. Välj vad filtret ska tillämpas på:

    * **All inkommande e-post**: Om du väljer det här alternativet används e-postfiltret för alla inkommande e-postmeddelanden.
    * **E-post som innehåller**: Om du väljer det här alternativet aktiveras e-postfiltret av e-postmeddelanden som innehåller det fasta uttryck (regexp) som anges i fälten till höger. Du kan välja mellan e-postmeddelandets sidhuvud och/eller brödtext.

1. På fliken **Sök fasta uttryck** kan du definiera reguljära uttryck som hittar text i e-postmeddelanden och spara dem som variabler. Om du vill infoga ett värde från ett reguljärt uttryck i en variabel som heter minVariabel använder du följande format: minVariabel = &lt;regexp&gt;.

1. På fliken **Ange kopplingar** kan du ange hur ett inkommande e-postmeddelande ska kopplas till ett ärende och/eller en kontakt baserat på innehållet i meddelandet:
    * **Koppla till kontakt där**: Om du vill koppla det genererade ärendet till en kontakt baserat på information från e-postmeddelandet väljer du ett av kontaktfälten i listan och anger ett fast uttryck som returnerar det värde som identifierar kontakten.
    * **Koppla till ärende där**: Här kan du koppla e-postmeddelandet till ett befintligt ärende baserat på ett reguljärt uttryck som hämtar information från e-postmeddelandet.

1. På fliken **Ange värden** kan du lägga till eller byta ut värden för kontakter, företag och ärenden baserat på innehållet i e-postmeddelandet:
    1. I listrutan till vänster väljer du önskat fält för kontakten, företaget eller ärendet.

    2. Ange något av följande i fältet till höger:
        * det reguljära uttryck som ska hitta det värde som ska anges
        * ett fast värde (måste förevigas med =)

    3. Om du markerar **Skriv över** ersätts det befintliga värdet med det värde som hittas.

    4. Klicka på **Lägg till** för att lägga till värdet.

        > [!TIP]
        > Du kan ta bort ett värde igen genom att markera det och klicka på <i class="ph ph-x-circle" aria-label="Remove icon"></i>.

1. På fliken **Ange egenskaper** kan du ange specifika egenskaper för ärenden som genereras från e-postmeddelanden som matchar det aktuella filtret:

1. På fliken **E-postsvar** kan du skapa olika e-postmeddelanden som ska skickas när det här filtret aktiveras. Här kan du ange följande information:
    * **Skicka svarsmall**: Här kan du välja vilken [svarsmall][2] som ska skickas om filtret aktiveras.
    * **... till kontakt**: Om du markerar det här alternativet skickas den valda svarsmallen tillbaka till kontakten.
    * **... till**: Om du markerar det här alternativet skickas den valda svarsmallen till den e-postadress som anges i fältet till höger.
    * **Föreslå FAQ-poster från**: Om du markerar det här alternativet [föreslår systemet FAQ-poster baserat på texten][3] i inkommande e-postmeddelanden. De föreslagna posterna blir tillgängliga som mallvariabler och kan därför upprepas i den valda svarsmallen. Du kan även specificera vilken gren av FAQ-trädet sökningen ska göras i, genom att specificera önskad mapp.
    * **Skicka inte automatiskt svar**: Om du markerar det här alternativet skickar inte systemet automatiska svar på dessa e-postmeddelanden.

1. På fliken **Brevlådor** kan du välja vilka brevlådor filtret ska tillämpas på.

1. Klicka på **OK**. E-postfiltret skapas.

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/index.md
[2]: ../../../../knowledge-base/learn/reply-templates/index.md
[3]: ../../../../knowledge-base/learn/reply-templates/create.md#faq
