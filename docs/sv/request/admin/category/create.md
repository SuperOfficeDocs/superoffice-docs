---
uid: help-sv-request-category-create
title: Skapa ärendekategori
description: Skapa ärendekategori
keywords: lägg till ärendekategori, skapa ärendekategori, ny ärendekategori, ärendekategori, Kategoriflik, ärende, kategori
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/request/learn/category/create
index: true
---

# Skapa ärendekategori

1. I Inställningar och underhåll, klicka på knappen **Ärenden** i navigatorn och välj fliken **Kategorier**.

1. Klicka på knappen **Lägg till**.

1. Ange ett beskrivande namn för kategorin i fältet **Kategorinamn** ovanför flikarna.

1. På fliken **Egenskaper** anger du följande information:

    * **Internt eller externt**: Om du markerar **Internt** visas kategorin inte i SuperOffice Customer Centre.

    * **Externt namn**: Här anger du det kategorinamn som visas ovanför kunden. Det här fältet är obligatoriskt, såvida inte kategorin är intern.

    * **Underkategori av**: Om detta ska vara en underkategori till en annan kategori, välj den överordnade kategorin här.

    * **Kategoriansvarig**: Välj vem som är ansvarig för ärenden i denna kategori. På fliken **Tilldelningsmetod** kan du ange att ärenden ska tilldelas kategoriansvarig om inga andra medlemmar i kategorin är tillgängliga. Normalt bör en avdelningschef ha rollen som kategoriansvarig.

        * **Visa kategori i statusbild**: Om det här alternativet är markerat, visas kategorin under **Status** på **dashboarden**.
        * **Endast tillgängligt för medlemmar**: Om det här alternativet är markerat, är kategorin endast tillgänglig för medlemmar i kategorin.
        * **Skicka meddelande om nytt ärende till medlemmar**: Om detta alternativ markeras, får alla medlemmar i kategorin meddelande om nya ärenden i kategorin.

    * **Skicka meddelande om nytt ärende till e-postadress**: Ange en e-postadress.

    * **Bli ägare när du svarar**: Om markerat, blir den användare som svarar på ett ärende i denna kategori dess ägare.

    * **Standardstatus för nytt ärende**: Välj standardstatus som ska visas i **Ärende**-skärmen. Den här inställningen åsidosätter [användarinställningar][1], om inte **Användardefinierad** är vald.

    * **Standardstatus för nytt meddelande**: Välj standardstatus för nya meddelanden. Den här inställningen åsidosätter [användarinställningar][1], om inte **Användardefinierad** är vald.

    * **Slå ihop e-postmeddelanden för den här kategorin med svarsmall**: Välj den svarsmall som ska användas i meddelanden som skickas till kunder och andra personer för ärenden som tillhör denna kategori. Detta kan vara en svarsmall som har skapats speciellt för kategorin för att alla svar från kategorin (t.ex. support eller redovisning) ska få ett enhetligt utseende.

        * Markera **Gäller för underkategorier** om du vill att den valda svarsmallen även ska användas för eventuella underkategorier. Detta förutsätter dock att mallen inte åsidosätts av de inställningar som görs i underkategorierna.

1. På fliken **Medlemmar** anger du vilka användare som ska vara medlemmar i kategorin. Välj en användare i listan **Användare** längst ner och klicka på **Lägg till**.

    > [!TIP]
    > Om **Viktad fördelning** har valts som tilldelningsmetod för ärendena i den här kategorin kan du använda vikttalet som faktor vid tilldelning av nya ärenden till varje enskild ärendehandläggare. Användarna med högst vikttal tilldelas flest ärenden. Du kan inte använda viktad fördelning för kategorimedlemmar från användargrupper.

1. På fliken **Tilldelningsmetod** anger du följande information:

    * Välj en tilldelningstyp:

        * **Jämn**: Ärenden fördelas jämnt bland kategorins medlemmar.
        * **Vikttal**: Tilldelning av ärenden baserat på vikttal som har angetts för medlemmar i kategorin.

           Exempel: Om kontakt A har vikt 1, B har vikt 2 och C har vikt 5 så kommer, under ett lopp av 8 ärenden, var och en av dessa kontakter att tilldelas lika många ärenden som deras vikttal anger.

        * **Till användare med minst aktiva ärenden**: Nya ärenden tilldelas till den kategorimedlem som har minst antal aktiva ärenden.
        * **Tilldela inte**: Ärenden tilldelas inte till specifika användare, utan alla ärenden placeras i en kö som standard. Antingen under **Ärenden** > **Otilldelade ärenden** (standard) eller i kösystemet **Hämta nästa ärende i kön** (se [Hur du konfigurerar Hämta nästa ärende i kön][3]).

    * **Tilldela bara till inloggade användare**: Tilldelar bara ärenden till användare som är inloggade i SuperOffice Service.

    * **Tilldela till kategoriansvarig om ingen är tillgänglig**: Tilldelar ärenden till kategoriansvarig om inga andra användare är tillgängliga.

    * **Omtilldela ärenden vid meddelande om användaren inte är tillgänglig**: Omtilldelar ärenden när ett nytt meddelande kommer in i ett ärende och användaren inte är tillgänglig.

    * **Tilldela vår supportansvarige om tillgänglig**: Om företaget eller kontakten har en ärendehandläggare angiven under **Vår kontakt** tilldelas ärendet till denna användare om han eller hon är tillgänglig. Om **Vår kontakt** inte har angetts eller om användaren inte är tillgänglig tilldelas ärendet enligt de vanliga tilldelningsreglerna.

    * **Tilldelningskarantän**: Ange antal minuter som du vill åsidosätta tilldelningsreglerna för och tilldela alla ärenden från samma kund till en användare. På detta sätt kan du se till att ärendena hamnar hos samma ärendehandläggare när kunder skickar två ärenden i rad till samma e-postadress. Om du anger -1 inaktiveras denna funktion och alla ärenden tilldelas enligt de vanliga tilldelningsreglerna.

1. Klicka på **Spara**. Kategorin skapas.

## Relaterat innehåll

* [Hur du konfigurerar Hämta nästa ärende i kön][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/index.md
[3]: ../next-in-queue.md
